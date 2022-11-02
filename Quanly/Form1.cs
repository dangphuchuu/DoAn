using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly
{
    public partial class Form1 : Form
    {
        private XuLySinhVien xuly;

        public Form1()
        {
            InitializeComponent();
            xuly = new XuLySinhVien();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TruyVanSinhVien.docFile("sinhvien.dat");
            xuly = new XuLySinhVien();
            radnam.Checked = true;
            hienThiDSSV();
        }
        public bool check()//kiểm tra người dùng đã nhập thông tin chưa
        {
            if (string.IsNullOrWhiteSpace(txtmasv.Text))
            {
                MessageBox.Show("Chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmasv.Focus();//con trỏ trỏ đến nơi chưa nhập
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtten.Text))
            {
                MessageBox.Show("Chưa nhập họ sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtten.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtho.Text))
            {
                MessageBox.Show("Chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtho.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtlop.Text))
            {
                MessageBox.Show("Chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return false;
            }
            return true;
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                SinhVien n = new SinhVien();
                n.MSSV = txtmasv.Text;
                n.Ho = txtho.Text;
                n.Ten = txtten.Text;
                n.Lop = txtlop.Text;
                n.NgaySinh = dtpngaysinh.Value;
                n.DiaChi = txtdiachi.Text;
                string gen = "Nam";
                if (radnam.Checked == true)
                {
                    gen = "Nam";
                }
                else 
                {
                    gen = "Nữ";
                }
                n.GioiTinh = gen;
                xuly.them(n);
                hienThiDSSV();
            }

        }
        public void hienThiDSSV()
        {
            dataGridView1.DataSource = xuly.getDSSV();
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnluu_Click(object sender, EventArgs e)
        {
            bool kq = TruyVanSinhVien.ghiFile("sinhvien.dat");
            if(kq == true)
            {
                MessageBox.Show("Lưu file thành công");
            }
            else
            {
                MessageBox.Show("Lưu file thất bại");
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmasv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtho.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtten.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtlop.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpngaysinh.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            if(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "Nam")
            {
                radnam.Checked = true;
            }
            else
            {
                radnu.Checked = true;
            }
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        
        private void btnsua_Click(object sender, EventArgs e)
        {
            SinhVien n = new SinhVien();
            n.MSSV = txtmasv.Text;
            n.Ho = txtho.Text;
            n.Ten = txtten.Text;
            n.Lop = txtlop.Text;
            n.NgaySinh = dtpngaysinh.Value;
            n.DiaChi = txtdiachi.Text;
            n.GioiTinh = "Nam";
            if(radnu.Checked == true)
            {
                n.GioiTinh = "Nữ";
            }
            xuly.sua(n);
            hienThiDSSV();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtmasv.Text;
            if(MessageBox.Show("Bạn muốn xóa ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                xuly.xoa(ma);
                MessageBox.Show("Xóa thành công");
            }
            hienThiDSSV();
        }
    }
}
