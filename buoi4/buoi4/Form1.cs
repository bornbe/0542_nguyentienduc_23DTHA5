using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                cmbFaculty.SelectedIndex = 0;
                optFemale.Checked = true; 
                optMale.Checked = false;
                UpdateStudentCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value != null &&
                    dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtAverageScore.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cmbFaculty.Text;
        }
        private void UpdateStudentCount()
        {
            int nam = 0, nu = 0;
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[2].Value != null)
                {
                    string gioitinh = dgvStudent.Rows[i].Cells[2].Value.ToString();
                    if (gioitinh == "Nam") nam++;
                    else if (gioitinh == "Nữ") nu++;
                }
            }
            txtNam.Text = nam.ToString();
            txtNu.Text = nu.ToString();
        }
        private void ResetInput()
        {
            txtStudentID.Text = "";
            txtFullName.Text = "";
            txtAverageScore.Text = "";
            cmbFaculty.SelectedIndex = 0;
            optFemale.Checked = true;
            optMale.Checked = false;
            txtStudentID.Focus();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtAverageScore.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!float.TryParse(txtAverageScore.Text, out float score))
            {
                MessageBox.Show("Điểm trung bình phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvStudent.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                    txtStudentID.Text = row.Cells[0].Value.ToString();
                    txtFullName.Text = row.Cells[1].Value.ToString();
                    string gioitinh = row.Cells[2].Value.ToString();
                    if (gioitinh == "Nữ")
                    {
                        optFemale.Checked = true;
                        optMale.Checked = false;
                    }
                    else
                    {
                        optFemale.Checked = false;
                        optMale.Checked = true;
                    }
                    txtAverageScore.Text = row.Cells[3].Value.ToString();
                    cmbFaculty.Text = row.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa sinh viên mã " + txtStudentID.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    dgvStudent.Rows.RemoveAt(selectedRow);
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                    UpdateStudentCount();
                    ResetInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (!ValidateInput()) return;
                int selectedRow = GetSelectedRow(txtStudentID.Text);

                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo");
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
                }
                UpdateStudentCount();
                ResetInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
