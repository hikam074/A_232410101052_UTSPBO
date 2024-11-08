namespace PBO_UTS
{
    partial class FormDashboard
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
            btnAddTugas = new Button();
            lblHeading = new Label();
            dgvTugas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTugas).BeginInit();
            SuspendLayout();
            // 
            // btnAddTugas
            // 
            btnAddTugas.Location = new Point(708, 49);
            btnAddTugas.Name = "btnAddTugas";
            btnAddTugas.Size = new Size(80, 65);
            btnAddTugas.TabIndex = 0;
            btnAddTugas.Text = "Tambah Tugas Baru";
            btnAddTugas.UseVisualStyleBackColor = true;
            btnAddTugas.Click += btnAddTugas_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(137, 49);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(519, 58);
            lblHeading.TabIndex = 4;
            lblHeading.Text = "Dashboad Admin : Daftar Tugas";
            // 
            // dgvTugas
            // 
            dgvTugas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTugas.Location = new Point(112, 134);
            dgvTugas.Name = "dgvTugas";
            dgvTugas.Size = new Size(568, 191);
            dgvTugas.TabIndex = 3;
            dgvTugas.CellContentClick += dgvTugas_CellContentClick;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeading);
            Controls.Add(dgvTugas);
            Controls.Add(btnAddTugas);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTugas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddTugas;
        private Label lblHeading;
        private DataGridView dgvTugas;
    }
}