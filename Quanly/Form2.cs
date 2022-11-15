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
        private List<Student> lstudent;
        public BindingSource bd1;
        public Form2()
        {
            InitializeComponent();
            process = new Processing();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Query.readFile("Student.dat");
            process = new Processing();
            //bd1 = new BindingSource();
            showStudent();
           
        }
        public void showStudent()
        {
            bd1 = new BindingSource();
            bd1.DataSource = process.getStudent();
            dataGridView1.DataSource = bd1;
            dataGridView1.Refresh();
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(bd1);
            f1.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
