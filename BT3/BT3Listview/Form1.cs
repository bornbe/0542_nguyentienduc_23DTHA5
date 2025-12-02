using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3Listview
{
    public partial class ListviewDemo : Form
    {
        public ListviewDemo()
        {
            InitializeComponent();
        }

        private void LastNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneText_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_addname_Click(object sender, EventArgs e)
        {
            // 1. Tạo một ListViewItem mới. Dữ liệu đầu tiên (họ) là phần tử chính.
            ListViewItem item = new ListViewItem(LastNameText.Text);

            // 2. Thêm các dữ liệu còn lại (tên và điện thoại) vào SubItems.
            item.SubItems.Add(FirstNameText.Text);
            item.SubItems.Add(PhoneText.Text);

            // 3. Thêm item vừa tạo vào ListView
            listView1.Items.Add(item);

            // 4. Xóa nội dung các TextBox sau khi thêm (tùy chọn)
            LastNameText.Clear();
            FirstNameText.Clear();
            PhoneText.Clear();
            LastNameText.Focus(); 
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy mục (hàng) đầu tiên được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Gán dữ liệu từ SubItems ngược lại lên các TextBox
                // Index 0: Họ (ListViewItem chính)
                LastNameText.Text = selectedItem.SubItems[0].Text;

                // Index 1: Tên (SubItem thứ nhất)
                FirstNameText.Text = selectedItem.SubItems[1].Text;

                // Index 2: Điện thoại (SubItem thứ hai)
                PhoneText.Text = selectedItem.SubItems[2].Text;
            }

        }
    }
}
