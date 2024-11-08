namespace PBO_UTS
{
    partial class FormAddTugas
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
            tbxJudul = new TextBox();
            tbxDesc = new TextBox();
            dtpDL = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(223, 35);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(335, 58);
            lblHeading.TabIndex = 5;
            lblHeading.Text = "Tambah Tugas Baru";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(447, 303);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(84, 23);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Tambahkan";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxJudul
            // 
            tbxJudul.Location = new Point(331, 130);
            tbxJudul.Name = "tbxJudul";
            tbxJudul.Size = new Size(200, 23);
            tbxJudul.TabIndex = 7;
            // 
            // tbxDesc
            // 
            tbxDesc.Location = new Point(331, 180);
            tbxDesc.Name = "tbxDesc";
            tbxDesc.Size = new Size(200, 23);
            tbxDesc.TabIndex = 8;
            // 
            // dtpDL
            // 
            dtpDL.Location = new Point(331, 253);
            dtpDL.Name = "dtpDL";
            dtpDL.Size = new Size(200, 23);
            dtpDL.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 133);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 10;
            label1.Text = "Judul";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 183);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 11;
            label2.Text = "Deskripsi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 259);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 12;
            label3.Text = "Deadline";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(331, 303);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormAddTugas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpDL);
            Controls.Add(tbxDesc);
            Controls.Add(tbxJudul);
            Controls.Add(btnSubmit);
            Controls.Add(lblHeading);
            Name = "FormAddTugas";
            Text = "FormAddTugas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Button btnSubmit;
        private TextBox tbxJudul;
        private TextBox tbxDesc;
        private DateTimePicker dtpDL;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBatal;
    }
}