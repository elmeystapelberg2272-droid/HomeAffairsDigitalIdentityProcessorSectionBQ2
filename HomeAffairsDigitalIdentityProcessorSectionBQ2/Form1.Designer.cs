namespace HomeAffairsDigitalIdentityProcessorSectionBQ2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCitizen = new System.Windows.Forms.Label();
            this.cmbCitizenship = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblValidationResult = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(440, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(537, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home Affairs Digital Identity Processor";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(446, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(617, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 22);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(446, 126);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(131, 25);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Enter your ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(617, 128);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(360, 22);
            this.txtID.TabIndex = 4;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblCitizen
            // 
            this.lblCitizen.AutoSize = true;
            this.lblCitizen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitizen.Location = new System.Drawing.Point(446, 183);
            this.lblCitizen.Name = "lblCitizen";
            this.lblCitizen.Size = new System.Drawing.Size(195, 25);
            this.lblCitizen.TabIndex = 5;
            this.lblCitizen.Text = "Choose your Citizen:";
            // 
            // cmbCitizenship
            // 
            this.cmbCitizenship.FormattingEnabled = true;
            this.cmbCitizenship.Items.AddRange(new object[] {
            "South African",
            "Permanent Resident",
            "Visitor"});
            this.cmbCitizenship.Location = new System.Drawing.Point(665, 183);
            this.cmbCitizenship.Name = "cmbCitizenship";
            this.cmbCitizenship.Size = new System.Drawing.Size(312, 24);
            this.cmbCitizenship.TabIndex = 6;
            this.cmbCitizenship.SelectedIndexChanged += new System.EventHandler(this.cmbCitizenship_SelectedIndexChanged);
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Chartreuse;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(632, 241);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(196, 32);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Validate ID";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(632, 503);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(196, 32);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate profile";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblValidationResult
            // 
            this.lblValidationResult.AutoSize = true;
            this.lblValidationResult.Location = new System.Drawing.Point(566, 296);
            this.lblValidationResult.Name = "lblValidationResult";
            this.lblValidationResult.Size = new System.Drawing.Size(44, 16);
            this.lblValidationResult.TabIndex = 9;
            this.lblValidationResult.Text = "label1";
            this.lblValidationResult.Click += new System.EventHandler(this.lblValidationResult_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(569, 333);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(417, 150);
            this.txtSummary.TabIndex = 10;
            this.txtSummary.TextChanged += new System.EventHandler(this.txtSummary_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeAffairsDigitalIdentityProcessorSectionBQ2.Properties.Resources.transparent_Photoroom__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 577);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(998, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.lblValidationResult);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.cmbCitizenship);
            this.Controls.Add(this.lblCitizen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCitizen;
        private System.Windows.Forms.ComboBox cmbCitizenship;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblValidationResult;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

