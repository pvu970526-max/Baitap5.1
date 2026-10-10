namespace WinFormsApp10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpPersonal = new GroupBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirm = new Label();
            txtConfirm = new TextBox();
            grpAdditional = new GroupBox();
            lblBirth = new Label();
            dtpBirth = new DateTimePicker();
            lblGender = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            chkAgree = new CheckBox();
            btnRegister = new Button();
            btnReset = new Button();
            epCheck = new ErrorProvider(components);
            grpPersonal.SuspendLayout();
            grpAdditional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // grpPersonal
            // 
            grpPersonal.Controls.Add(lblUsername);
            grpPersonal.Controls.Add(txtUsername);
            grpPersonal.Controls.Add(lblPassword);
            grpPersonal.Controls.Add(txtPassword);
            grpPersonal.Controls.Add(lblConfirm);
            grpPersonal.Controls.Add(txtConfirm);
            grpPersonal.Location = new Point(12, 12);
            grpPersonal.Name = "grpPersonal";
            grpPersonal.Size = new Size(413, 150);
            grpPersonal.TabIndex = 0;
            grpPersonal.TabStop = false;
            grpPersonal.Text = "Thông tin cá nhân";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(16, 28);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(110, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(162, 21);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 27);
            txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(16, 62);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 55);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(16, 96);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(137, 20);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "Xác nhận mật khẩu:";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(162, 93);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(220, 27);
            txtConfirm.TabIndex = 2;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // grpAdditional
            // 
            grpAdditional.Controls.Add(lblBirth);
            grpAdditional.Controls.Add(dtpBirth);
            grpAdditional.Controls.Add(lblGender);
            grpAdditional.Controls.Add(rbMale);
            grpAdditional.Controls.Add(rbFemale);
            grpAdditional.Controls.Add(chkAgree);
            grpAdditional.Location = new Point(12, 168);
            grpAdditional.Name = "grpAdditional";
            grpAdditional.Size = new Size(360, 150);
            grpAdditional.TabIndex = 1;
            grpAdditional.TabStop = false;
            grpAdditional.Text = "Thông tin bổ sung";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Location = new Point(16, 28);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(77, 20);
            lblBirth.TabIndex = 0;
            lblBirth.Text = "Ngày sinh:";
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(120, 24);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(220, 27);
            dtpBirth.TabIndex = 3;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(16, 64);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Giới tính:";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(120, 62);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 4;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(190, 62);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 5;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // chkAgree
            // 
            chkAgree.AutoSize = true;
            chkAgree.Location = new Point(16, 100);
            chkAgree.Name = "chkAgree";
            chkAgree.Size = new Size(253, 24);
            chkAgree.TabIndex = 6;
            chkAgree.Text = "Tôi đồng ý với điều khoản dịch vụ";
            chkAgree.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(444, 59);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 35);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(444, 100);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 35);
            btnReset.TabIndex = 8;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // epCheck
            // 
            epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 340);
            Controls.Add(grpPersonal);
            Controls.Add(grpAdditional);
            Controls.Add(btnRegister);
            Controls.Add(btnReset);
            Name = "Form1";
            Text = "Đăng ký tài khoản";
            grpPersonal.ResumeLayout(false);
            grpPersonal.PerformLayout();
            grpAdditional.ResumeLayout(false);
            grpAdditional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.GroupBox grpAdditional;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}
