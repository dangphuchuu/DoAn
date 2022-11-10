using System;
using System.Collections.Generic;
using System.Text;

namespace Quanly
{
    [Serializable]
    class Student
    {
        private string m_studentcode;
        private string m_lastname;
        private string m_firstname;
        private string m_class;
        private DateTime m_birthday;
        private string m_gen;
        private string m_address;
        public Student(string code, string last, string first, string c, DateTime bd, string g, string add)
        {
            this.m_studentcode = code;
            this.m_lastname = last;
            this.m_firstname = first;
            this.m_class = c;
            this.m_birthday = bd;
            this.m_gen = g;
            this.m_address = add;
        }
        public Student()
        {
            this.m_studentcode = "";
            this.m_lastname = "";
            this.m_firstname = "";
            this.m_class = "";
            this.m_birthday = DateTime.Today;
            this.m_gen = "";
            this.m_address = "";
        }
        public string Code 
        {
            get { return m_studentcode; }
            set { m_studentcode = value; }
        }
        public string Last
        {
            get { return m_lastname; }
            set { m_lastname = value; }
        }
        public string First 
        { 
            get {return m_firstname; }
            set { m_firstname = value;} 
        }
        public string Class
        {
            get { return m_class; }
            set { m_class = value; }
        }
        public DateTime BirthDay
        {
           get { return m_birthday; }
           set { m_birthday = value; }
        }
        public string Gen 
        { 
            get {return m_gen; }
            set { m_gen = value;} 
        }
        public string Address 
        { 
            get {return m_address; }
            set { m_address = value;} 
        }
        
        
    }
}
