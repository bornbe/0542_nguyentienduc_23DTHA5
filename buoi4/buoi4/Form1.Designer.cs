namespace buoi4
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
            this.gbThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.ColMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtNu = new System.Windows.Forms.TextBox();
            this.gbThongTinSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTinSinhVien
            // 
            this.gbThongTinSinhVien.Controls.Add(this.cmbFaculty);
            this.gbThongTinSinhVien.Controls.Add(this.optFemale);
            this.gbThongTinSinhVien.Controls.Add(this.optMale);
            this.gbThongTinSinhVien.Controls.Add(this.txtFullName);
            this.gbThongTinSinhVien.Controls.Add(this.txtAverageScore);
            this.gbThongTinSinhVien.Controls.Add(this.txtStudentID);
            this.gbThongTinSinhVien.Controls.Add(this.label4);
            this.gbThongTinSinhVien.Controls.Add(this.label5);
            this.gbThongTinSinhVien.Controls.Add(this.label3);
            this.gbThongTinSinhVien.Controls.Add(this.label2);
            this.gbThongTinSinhVien.Controls.Add(this.label1);
            this.gbThongTinSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinSinhVien.Location = new System.Drawing.Point(7, 70);
            this.gbThongTinSinhVien.Name = "gbThongTinSinhVien";
            this.gbThongTinSinhVien.Size = new System.Drawing.Size(425, 238);
            this.gbThongTinSinhVien.TabIndex = 0;
            this.gbThongTinSinhVien.TabStop = false;
            this.gbThongTinSinhVien.Text = "Thông tin sinh Viên";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbFaculty.Location = new System.Drawing.Point(144, 190);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(248, 33);
            this.cmbFaculty.TabIndex = 3;
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Checked = true;
            this.optFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optFemale.Location = new System.Drawing.Point(267, 116);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(51, 24);
            this.optFemale.TabIndex = 2;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Nữ";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMale.Location = new System.Drawing.Point(144, 116);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(65, 24);
            this.optMale.TabIndex = 2;
            this.optMale.Text = "Nam";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(144, 73);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(248, 30);
            this.txtFullName.TabIndex = 1;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(144, 153);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(174, 30);
            this.txtAverageScore.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(144, 29);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(174, 30);
            this.txtStudentID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm TB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuyên ngành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMSSV,
            this.ColHoTen,
            this.ColGioiTinh,
            this.ColDTB,
            this.ColKhoa});
            this.dgvStudent.Location = new System.Drawing.Point(438, 75);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(676, 288);
            this.dgvStudent.TabIndex = 1;
            // 
            // ColMSSV
            // 
            this.ColMSSV.HeaderText = "MSSV";
            this.ColMSSV.MinimumWidth = 6;
            this.ColMSSV.Name = "ColMSSV";
            this.ColMSSV.Width = 125;
            // 
            // ColHoTen
            // 
            this.ColHoTen.HeaderText = "Họ Tên";
            this.ColHoTen.MinimumWidth = 6;
            this.ColHoTen.Name = "ColHoTen";
            this.ColHoTen.Width = 125;
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.HeaderText = "Giới tính";
            this.ColGioiTinh.MinimumWidth = 6;
            this.ColGioiTinh.Name = "ColGioiTinh";
            this.ColGioiTinh.Width = 125;
            // 
            // ColDTB
            // 
            this.ColDTB.HeaderText = "ĐTB";
            this.ColDTB.MinimumWidth = 6;
            this.ColDTB.Name = "ColDTB";
            this.ColDTB.Width = 125;
            // 
            // ColKhoa
            // 
            this.ColKhoa.HeaderText = "Khoa";
            this.ColKhoa.MinimumWidth = 6;
            this.ColKhoa.Name = "ColKhoa";
            this.ColKhoa.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(415, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(395, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quản lý thông tin sinh viên";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(172, 314);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 25);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Thêm/Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(313, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(695, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng SV Nam:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(876, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nữ:";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(797, 373);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(77, 22);
            this.txtNam.TabIndex = 5;
            this.txtNam.Text = "0";
            this.txtNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNu
            // 
            this.txtNu.Location = new System.Drawing.Point(909, 374);
            this.txtNu.Name = "txtNu";
            this.txtNu.Size = new System.Drawing.Size(77, 22);
            this.txtNu.TabIndex = 5;
            this.txtNu.Text = "0";
            this.txtNu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 453);
            this.Controls.Add(this.txtNu);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.gbThongTinSinhVien);
            this.Name = "Form1";
            this.Text = "Quản lý thông tin sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbThongTinSinhVien.ResumeLayout(false);
            this.gbThongTinSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinSinhVien;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtNu;
    }
}

