namespace PBO_UTS
{
    partial class FormLogin
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
            lblHeading = new Label();
            btnSubmit = new Button();
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            lblUsername = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(260, 29);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(271, 58);
            lblHeading.TabIndex = 2;
            lblHeading.Text = "Silahkan Login!";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(473, 231);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Login";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(345, 145);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(203, 23);
            tbxUsername.TabIndex = 4;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(345, 187);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(203, 23);
            tbxPassword.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(260, 148);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 190);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 7;
            label1.Text = "Password";
            // 
            // FormLogin
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
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Button btnSubmit;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Label lblUsername;
        private Label label1;
    }
}