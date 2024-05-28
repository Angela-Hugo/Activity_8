namespace ACTIVITY_6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.get_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtAttorneyName = new System.Windows.Forms.TextBox();
            this.txtCaseStatus = new System.Windows.Forms.TextBox();
            this.txtCaseType = new System.Windows.Forms.TextBox();
            this.txtCaseTitle = new System.Windows.Forms.TextBox();
            this.txtCaseNumber = new System.Windows.Forms.TextBox();
            this.txtProsecutorName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(585, 199);
            this.dataGridView.TabIndex = 0;
            // 
            // get_btn
            // 
            this.get_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.get_btn.Font = new System.Drawing.Font("Myriad Hebrew", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.get_btn.Location = new System.Drawing.Point(211, 223);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(158, 36);
            this.get_btn.TabIndex = 1;
            this.get_btn.Text = "GET";
            this.get_btn.UseVisualStyleBackColor = false;
            this.get_btn.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPost);
            this.panel1.Controls.Add(this.txtAttorneyName);
            this.panel1.Controls.Add(this.txtCaseStatus);
            this.panel1.Controls.Add(this.txtCaseType);
            this.panel1.Controls.Add(this.txtCaseTitle);
            this.panel1.Controls.Add(this.txtCaseNumber);
            this.panel1.Controls.Add(this.txtProsecutorName);
            this.panel1.Location = new System.Drawing.Point(13, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 216);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Case Handled By";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(319, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Attorney";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(311, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prosecutor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Case Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Case Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Case Title ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Case Number";
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPost.Font = new System.Drawing.Font("Myriad Hebrew", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPost.Location = new System.Drawing.Point(404, 142);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(158, 36);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click_1);
            // 
            // txtAttorneyName
            // 
            this.txtAttorneyName.Location = new System.Drawing.Point(390, 86);
            this.txtAttorneyName.Multiline = true;
            this.txtAttorneyName.Name = "txtAttorneyName";
            this.txtAttorneyName.Size = new System.Drawing.Size(187, 30);
            this.txtAttorneyName.TabIndex = 5;
            // 
            // txtCaseStatus
            // 
            this.txtCaseStatus.Location = new System.Drawing.Point(88, 157);
            this.txtCaseStatus.Multiline = true;
            this.txtCaseStatus.Name = "txtCaseStatus";
            this.txtCaseStatus.Size = new System.Drawing.Size(187, 30);
            this.txtCaseStatus.TabIndex = 4;
            // 
            // txtCaseType
            // 
            this.txtCaseType.Location = new System.Drawing.Point(88, 114);
            this.txtCaseType.Multiline = true;
            this.txtCaseType.Name = "txtCaseType";
            this.txtCaseType.Size = new System.Drawing.Size(187, 30);
            this.txtCaseType.TabIndex = 3;
            // 
            // txtCaseTitle
            // 
            this.txtCaseTitle.Location = new System.Drawing.Point(88, 72);
            this.txtCaseTitle.Multiline = true;
            this.txtCaseTitle.Name = "txtCaseTitle";
            this.txtCaseTitle.Size = new System.Drawing.Size(187, 30);
            this.txtCaseTitle.TabIndex = 2;
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.Location = new System.Drawing.Point(89, 29);
            this.txtCaseNumber.Multiline = true;
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.Size = new System.Drawing.Size(187, 30);
            this.txtCaseNumber.TabIndex = 1;
            // 
            // txtProsecutorName
            // 
            this.txtProsecutorName.Location = new System.Drawing.Point(390, 33);
            this.txtProsecutorName.Multiline = true;
            this.txtProsecutorName.Name = "txtProsecutorName";
            this.txtProsecutorName.Size = new System.Drawing.Size(187, 30);
            this.txtProsecutorName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.get_btn);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button get_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProsecutorName;
        private System.Windows.Forms.TextBox txtCaseStatus;
        private System.Windows.Forms.TextBox txtCaseType;
        private System.Windows.Forms.TextBox txtCaseTitle;
        private System.Windows.Forms.TextBox txtCaseNumber;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtAttorneyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

