using ManageStudent;
using Quanly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManageStudent
{
    
    public partial class Form2 : Form
    {
        private Processing process;
        public BindingSource bd1;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Query.readFile("Student.dat");
            process = new Processing();
            showStudent();
        }
        public void showStudent()
        {
            bd1 = new BindingSource();
            bd1.DataSource = process.getStudent();
            dataGridView1.DataSource = bd1;
            dataGridView1.Refresh();
        }
      
        private void Form2_click(object sender, EventArgs e)
        {
            Form1 f1= new Form1(bd1);
            f1.txtcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f1.txtlast.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f1.txtfirst.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f1.txtclass.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f1.dtpbirthday.Value = Convert.ToDateTime( dataGridView1.CurrentRow.Cells[4].Value.ToString());
            f1.txtaddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "Nam")
                f1.radmale.Checked = true;
            else
                f1.radfemale.Checked = true;
            f1.Show();
        }

        private void btnfindcode_Click(object sender, EventArgs e)
        {
            List<Student> l2 = new List<Student>();
            String word = txtfindcode.Text;
            foreach (Student n in process.getStudent())
            {
                if (String.Compare(word,n.Code) ==0 )
                {
                    l2.Add(n);
                }
                if(String.Compare(word,n.Class)==0 && rdclass.Checked == true)
                {
                    l2.Add(n);
                }
            }
            dataGridView1.DataSource = l2;
        }



        private void MSsave_Click(object sender, EventArgs e)
        {
            bool result = Query.writeFile("Student.dat");
            if (result == true)
            {
                MessageBox.Show("Lưu file thành công");
            }
            else
            {
                MessageBox.Show("Lưu file thất bại");
            }
        }

        private void MSadd_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(bd1);
            f1.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            showStudent();
        }
    }
}
