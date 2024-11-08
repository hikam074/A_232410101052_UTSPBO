namespace PBO_UTS
{
    partial class FormWelcome
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
            lblHeading = new Label();
            btnTugas = new Button();
            btnSignup = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(103, 34);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(629, 58);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Selamat Datang di Task Management!";
            // 
            // btnTugas
            // 
            btnTugas.Location = new Point(338, 144);
            btnTugas.Name = "btnTugas";
            btnTugas.Size = new Size(135, 51);
            btnTugas.TabIndex = 2;
            btnTugas.Text = "Lihat Tugas";
            btnTugas.UseVisualStyleBackColor = true;
            btnTugas.Click += btnTugas_Click;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(338, 297);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(135, 51);
            btnSignup.TabIndex = 3;
            btnSignup.Text = "SignUp";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(338, 221);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(135, 51);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnSignup);
            Controls.Add(btnTugas);
            Controls.Add(lblHeading);
            Name = "FormWelcome";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHeading;
        private Button btnTugas;
        private Button btnSignup;
        private Button btnLogin;
    }
}
