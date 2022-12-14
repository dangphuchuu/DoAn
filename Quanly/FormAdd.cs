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
    public partial class FormAdd : Form
    {
        public BindingSource form1bs;
        private Processing process;
        public FormAdd(BindingSource bs)
        {
            
            InitializeComponent();
            form1bs = bs;
            process = new Processing();
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
                MessageBox.Show("Chưa nhập lớp sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if(process.addStudent(n))
                    form1bs.Add(n);
            }

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
            if(process.editStudent(n))
            {
                form1bs.Insert(form1bs.IndexOf(form1bs.Current), n);
                form1bs.RemoveCurrent();
                this.Close();
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            string code = txtcode.Text;
            if(MessageBox.Show("Bạn muốn xóa ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
               process.deleteStudent(code);
                form1bs.RemoveCurrent();
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
        }
       
    }
}
