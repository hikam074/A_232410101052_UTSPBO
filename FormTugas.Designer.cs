namespace PBO_UTS
{
    partial class FormTugas
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
            dgvTugas = new DataGridView();
            lblHeading = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTugas).BeginInit();
            SuspendLayout();
            // 
            // dgvTugas
            // 
            dgvTugas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTugas.Location = new Point(123, 128);
            dgvTugas.Name = "dgvTugas";
            dgvTugas.Size = new Size(568, 191);
            dgvTugas.TabIndex = 0;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(296, 32);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(227, 58);
            lblHeading.TabIndex = 2;
            lblHeading.Text = "Daftar Tugas";
            // 
            // FormTugas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeading);
            Controls.Add(dgvTugas);
            Name = "FormTugas";
            Text = "FormTugas";
            Load += FormTugas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTugas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTugas;
        private Label lblHeading;
    }
}