using Quanly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManageStudent
{
    class Processing
    {
        private List<Student> lstudent;

        public Processing()
        {
            Query data = Query.init();
            lstudent = data.getStudent();
        }
        public List<Student> getStudent()
        {
            return lstudent.ToList();
        }
        public Student findStudent(string code)
        {
            foreach (Student n in lstudent)
            {
                if (n.Code == code)
                    return n;
            }
            return null;
        }
        public void editStudent(Student s)
        {
            Student n = findStudent(s.Code);
            if (n != null)
            {
                n.Last = s.Last;
                n.First = s.First;
                n.Class = s.Class;
                n.BirthDay = s.BirthDay;
                n.Address = s.Address;
                n.Gen = s.Gen;
            }
            else
            {
                MessageBox.Show("Không được sửa mã sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        public void addStudent(Student s)
        {
            if (findStudent(s.Code) == null)
            {
                this.lstudent.Add(s);
            }
            else
            {
                MessageBox.Show("Mã Sinh Viên đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void deleteStudent(string code)
        {
            Student del = findStudent(code);
            if (del != null)
            {
                lstudent.Remove(del);
            }
        }
    }
}
