<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

// Database connection parameters
$servername = "localhost";
$username = "root";
$password = "";
$database = "case_management";

// Create connection
$conn = new mysqli($servername, $username, $password, $database);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Handle GET request
if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    // Fetch data from the database
    $sql = "SELECT  courtcases.case_number, courtcases.case_title, courtcases.case_status, courtcases.case_type, CONCAT(attorney.fname, ' ', attorney.lname) AS attorney_name, CONCAT(prosecutor.fname, ' ', prosecutor.lname) AS prosecutor_name FROM courtcases JOIN case_assignment ON courtcases.case_id = case_assignment.case_id JOIN attorney ON case_assignment.att_id = attorney.att_id JOIN prosecutor ON case_assignment.prosec_id = prosecutor.pro_sec_id";

    $result = $conn->query($sql);

    if ($result->num_rows > 0) {
        $data = array();
        while ($row = $result->fetch_assoc()) {
            $data[] = $row;
        }
        echo json_encode($data);
    } else {
        echo "No data found";
    }
}


// Handle POST request
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Extract POST data
    $case_number = $_POST['case_number'];
    $case_title = $_POST['case_title'];
    $case_type = $_POST['case_type'];
    $case_status = $_POST['case_status'];
    $attorney_fname = $_POST['attorney_fname'];
    $attorney_lname = $_POST['attorney_lname'];
    $prosecutor_fname = $_POST['prosecutor_fname'];
    $prosecutor_lname = $_POST['prosecutor_lname'];
  
    // Insert data into courtcases table
    $sql = "INSERT INTO courtcases (case_number, case_title, case_type, case_status) VALUES ('$case_number', '$case_title', '$case_type', '$case_status')";
    if ($conn->query($sql) === TRUE) {
      $case_id = $conn->insert_id; // Get the auto-generated case_id
  
      // Insert data into attorney table
      $sql_attorney = "INSERT INTO attorney (fname, lname) VALUES ('$attorney_fname', '$attorney_lname')";
      if ($conn->query($sql_attorney) === TRUE) {
        $att_id = $conn->insert_id; // Get the auto-generated att_id
      } else {
        echo "Error inserting attorney: " . $conn->error;
        exit;
      }
  
      // Insert data into prosecutor table
      $sql_prosecutor = "INSERT INTO prosecutor (fname, lname) VALUES ('$prosecutor_fname', '$prosecutor_lname')";
      if ($conn->query($sql_prosecutor) === TRUE) {
        $prosec_id = $conn->insert_id; // Get the auto-generated pro_sec_id
      } else {
        echo "Error inserting prosecutor: " . $conn->error;
        exit;
      }
  
      // Insert data into case_assignment table
      $sql_case_assignment = "INSERT INTO case_assignment (case_id, att_id, prosec_id) VALUES ($case_id, $att_id, $prosec_id)";
      if ($conn->query($sql_case_assignment) === TRUE) {
        echo "New record created successfully";
      } else {
        echo "Error inserting into case_assignment: " . $conn->error;
      }
    } else {
      echo "Error inserting into courtcases: " . $conn->error;
    }
  }
  
  $conn->close();
  ?>