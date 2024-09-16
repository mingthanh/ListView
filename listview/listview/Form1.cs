using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class LSView : Form
    {
        public LSView()
        {
            InitializeComponent();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy dòng được chọn
                ListViewItem lvi = listView1.SelectedItems[0];
                // Gán từng cột của dòng cho giá trị tương ứng
                fn.Text = lvi.SubItems[0].Text;
                ln.Text = lvi.SubItems[1].Text;
                pnum.Text = lvi.SubItems[2].Text;
            }
        }

        private void Addclick_Click(object sender, EventArgs e)
        {
            // Tạo 1 ListViewItem => dòng dữ liệu mới
            ListViewItem lvi = new ListViewItem(fn.Text);
            // Thêm dữ liệu cho các cột còn lại của dòng
            lvi.SubItems.Add(ln.Text);
            lvi.SubItems.Add(pnum.Text);
            // Đưa dòng dữ liệu lên ListView
            listView1.Items.Add(lvi);
            // Xóa trắng các ô input sau khi thêm
            ClearInputs();
        }

        private void Deleteclick_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Xóa dòng đang được chọn
                listView1.Items.Remove(listView1.SelectedItems[0]);
                // Xóa trắng các ô input sau khi xóa
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void Updateclick_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy dòng được chọn
                ListViewItem lvi = listView1.SelectedItems[0];
                // Cập nhật giá trị cho từng cột
                lvi.SubItems[0].Text = fn.Text;
                lvi.SubItems[1].Text = ln.Text;
                lvi.SubItems[2].Text = pnum.Text;
                // Xóa trắng các ô input sau khi cập nhật
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void ClearInputs()
        {
            fn.Clear();
            ln.Clear();
            pnum.Clear();
        }

        //private void fn_TextChanged(object sender, EventArgs e) { }

        //private void ln_TextChanged(object sender, EventArgs e) { }

        //private void pnum_TextChanged(object sender, EventArgs e) { }
    }
}
