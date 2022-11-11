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
        public Form2()
        {
            InitializeComponent();
            process = new Processing();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Query.readFile("Student.dat");
            process = new Processing();
            showStudent();
        }
        public void showStudent()
        {
            dataGridView1.DataSource = process.getStudent();
            dataGridView1.Refresh();
        }
    }
}
