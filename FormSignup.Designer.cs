namespace PBO_UTS
{
    partial class FormSignup
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
            label1 = new Label();
            lblUsername = new Label();
            tbxPassword = new TextBox();
            tbxUsername = new TextBox();
            btnSubmit = new Button();
            lblHeading = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 255);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 13;
            label1.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(262, 213);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 12;
            lblUsername.Text = "Username";
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(347, 252);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(203, 23);
            tbxPassword.TabIndex = 11;
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(347, 210);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(203, 23);
            tbxUsername.TabIndex = 10;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(475, 296);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Signup";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(262, 94);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(295, 58);
            lblHeading.TabIndex = 8;
            lblHeading.Text = "Silahkan Signup!";
            // 
            // FormSignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblUsername);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(btnSubmit);
            Controls.Add(lblHeading);
            Name = "FormSignup";
            Text = "FormSignup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private TextBox tbxPassword;
        private TextBox tbxUsername;
        private Button btnSubmit;
        private Label lblHeading;
    }
}