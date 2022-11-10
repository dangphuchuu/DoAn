using ManageStudent;
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
        private Processing process;

        public Form1()
        {
            InitializeComponent();
            process = new Processing();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Query.readFile("Student.dat");
            process = new Processing();
            radmale.Checked = true;
            showStudent();
        }
        public bool check()//kiểm tra người dùng đã nhập thông tin chưa
        {
            if (string.IsNullOrWhiteSpace(txtcode.Text))
            {
                MessageBox.Show("Chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcode.Focus();//con trỏ trỏ đến nơi chưa nhập
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtfirst.Text))
            {
                MessageBox.Show("Chưa nhập họ sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfirst.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtlast.Text))
            {
                MessageBox.Show("Chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlast.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtclass.Text))
            {
                MessageBox.Show("Chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtclass.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtaddress.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaddress.Focus();
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
                Student n = new Student();
                n.Code = txtcode.Text;
                n.Last = txtlast.Text;
                n.First = txtfirst.Text;
                n.Class = txtclass.Text;
                n.BirthDay = dtpbirthday.Value;
                n.Address = txtaddress.Text;
                string gen = "Nam";
                if (radmale.Checked == true)
                {
                    gen = "Nam";
                }
                else 
                {
                    gen = "Nữ";
                }
                n.Gen = gen;
                process.addStudent(n);
                showStudent();
            }

        }
        public void showStudent()
        {
            dataGridView1.DataSource = process.getStudent();
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnluu_Click(object sender, EventArgs e)
        {
            bool result = Query.writeFile("Student.dat");
            if(result == true)
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
            txtcode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtlast.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtfirst.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtclass.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpbirthday.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            if(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "Nam")
            {
                radmale.Checked = true;
            }
            else
            {
                radfemale.Checked = true;
            }
            txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        
        private void btnsua_Click(object sender, EventArgs e)
        {
            Student n = new Student();
            n.Code = txtcode.Text;
            n.Last = txtlast.Text;
            n.First = txtfirst.Text;
            n.Class = txtclass.Text;
            n.BirthDay = dtpbirthday.Value;
            n.Address = txtaddress.Text;
            n.Gen = "Nam";
            if(radfemale.Checked == true)
            {
                n.Gen = "Nữ";
            }
            process.editStudent(n);
            showStudent();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string code = txtcode.Text;
            if(MessageBox.Show("Bạn muốn xóa ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
               process.deleteStudent(code);
                MessageBox.Show("Xóa thành công");
            }
            showStudent();
        }
    }
}
