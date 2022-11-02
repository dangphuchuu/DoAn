using System;
using System.Collections.Generic;
using System.Text;

namespace Quanly
{
    [Serializable]
    class SinhVien
    {
        private string m_mssv;
        private string m_ho;
        private string m_ten;
        private string m_lop;
        private DateTime m_ngaysinh;
        private string m_gioitinh;
        private string m_diachi;
        public SinhVien(string ma, string ho, string ten,string lop, DateTime ns, string gt, string dc)
        {
            this.m_mssv = ma;
            this.m_ho = ho;
            this.m_ten = ten;
            this.m_lop = lop;
            this.m_ngaysinh = ns;
            this.m_gioitinh = gt;
            this.m_diachi = dc;
        }
        public SinhVien()
        {
            this.m_mssv = "";
            this.m_ho = "";
            this.m_ten = "";
            this.m_lop = "";
            this.m_ngaysinh = DateTime.Today;
            this.m_gioitinh = "";
            this.m_diachi = "";
        }
        public string MSSV 
        {
            get { return m_mssv; }
            set { m_mssv = value; }
        }
        public string Ho
        {
            get { return m_ho; }
            set { m_ho = value; }
        }
        public string Ten { 
            get {return m_ten;}
            set {m_ten = value;} 
        }
        public string Lop
        {
            get { return m_lop; }
            set { m_lop = value; }
        }
        public DateTime NgaySinh
        {
           get { return m_ngaysinh; }
           set { m_ngaysinh = value; }
        }
        public string GioiTinh 
        { 
            get {return m_gioitinh;}
            set {m_gioitinh = value;} 
        }
        public string DiaChi 
        { 
            get {return m_diachi;}
            set {m_diachi = value;} 
        }
        
        
    }
}
