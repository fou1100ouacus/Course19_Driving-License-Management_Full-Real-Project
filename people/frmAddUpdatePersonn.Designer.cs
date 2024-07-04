namespace DVLD_System
{
    partial class frmAddUpdatePersonn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "National No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gendor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(359, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "DateOfBirth";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(277, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 26);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Add New Person";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(105, 100);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(122, 20);
            this.txtFirstName.TabIndex = 10;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(487, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(122, 20);
            this.txtLastName.TabIndex = 11;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(361, 100);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(122, 20);
            this.txtThirdName.TabIndex = 12;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(233, 100);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(122, 20);
            this.txtSecondName.TabIndex = 13;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(130, 137);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(122, 20);
            this.txtNationalNo.TabIndex = 14;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(113, 279);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(122, 20);
            this.txtAddress.TabIndex = 16;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(122, 20);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(489, 178);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(122, 20);
            this.txtPhone.TabIndex = 18;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(490, 137);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.TabIndex = 19;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(490, 210);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 20;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::DVLD_System.Properties.Resources.man_4140037;
            this.pbPersonImage.Location = new System.Drawing.Point(630, 36);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(140, 121);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 21;
            this.pbPersonImage.TabStop = false;
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Location = new System.Drawing.Point(649, 185);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(47, 13);
            this.llRemoveImage.TabIndex = 22;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Location = new System.Drawing.Point(720, 185);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(23, 13);
            this.llSetImage.TabIndex = 23;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(154, 187);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(59, 17);
            this.rbfemale.TabIndex = 24;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            this.rbfemale.CheckedChanged += new System.EventHandler(this.rbfemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(91, 187);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 25;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 23;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(473, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 48);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(108, 55);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(66, 26);
            this.lblPersonID.TabIndex = 27;
            this.lblPersonID.Text = "??????";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdatePerson1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.llRemoveImage);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNationalNo);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtThirdName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddUpdatePerson1";
            this.Text = "frmAddUpdatePerson";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbMale;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}