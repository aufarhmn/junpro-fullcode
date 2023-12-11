namespace JunproANR
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAlamat = new TextBox();
            txtNo_handphone = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            dgvKaryawan = new DataGridView();
            cbDepartemen = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(479, 60);
            label1.TabIndex = 0;
            label1.Text = "Data Pegawai PT ANR";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 99);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 189);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 3;
            label4.Text = "No Handphone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 236);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 4;
            label5.Text = "Departemen";
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 27);
            txtName.TabIndex = 5;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(177, 143);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(187, 27);
            txtAlamat.TabIndex = 6;
            // 
            // txtNo_handphone
            // 
            txtNo_handphone.Location = new Point(177, 189);
            txtNo_handphone.Name = "txtNo_handphone";
            txtNo_handphone.Size = new Size(187, 27);
            txtNo_handphone.TabIndex = 7;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(422, 96);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(106, 109);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(534, 96);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 109);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(650, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 109);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(422, 211);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(336, 52);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Location = new Point(42, 282);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.RowHeadersWidth = 51;
            dgvKaryawan.Size = new Size(716, 156);
            dgvKaryawan.TabIndex = 13;
            dgvKaryawan.CellClick += dgvKaryawan_CellClick;
            // 
            // cbDepartemen
            // 
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Items.AddRange(new object[] { "HR", "IT", "CO", "SP", "MG" });
            cbDepartemen.Location = new Point(177, 233);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(187, 28);
            cbDepartemen.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbDepartemen);
            Controls.Add(dgvKaryawan);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtNo_handphone);
            Controls.Add(txtAlamat);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAlamat;
        private TextBox txtNo_handphone;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoad;
        private DataGridView dgvKaryawan;
        private ComboBox cbDepartemen;
    }
}
