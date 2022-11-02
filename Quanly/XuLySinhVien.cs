using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanly
{
    class XuLySinhVien
    {
        private List<SinhVien> dssv;
        
        public XuLySinhVien()
        {
            TruyVanSinhVien dulieu = TruyVanSinhVien.khoitao();
            this.dssv = dulieu.getDSSV();
        }
        public List<SinhVien> getDSSV()
        {
            return this.dssv.ToList();
        }
        public SinhVien timSV(string ma)
        {
            foreach (SinhVien n in dssv)
            {
                if (n.MSSV == ma)
                    return n;
            }
            return null;
        }
        public void sua(SinhVien sv)
        {
            SinhVien n = timSV(sv.MSSV);
            if(n != null)
            {
                n.Ho = sv.Ho;
                n.Ten = sv.Ten;
                n.Lop = sv.Lop;
                n.NgaySinh = sv.NgaySinh;
                n.DiaChi = sv.DiaChi;
                n.GioiTinh = sv.GioiTinh;
            }
            else
            {
                MessageBox.Show("Không được sửa mã sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }
        public void them(SinhVien sv)
        {
            
            if (timSV(sv.MSSV) == null)
                {
                    this.dssv.Add(sv);
                }
            else
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
        }
        public void xoa(string ma)
        {
            SinhVien xoa = timSV(ma);
            if(xoa !=null)
            {
                dssv.Remove(xoa);
            }
        }
    }
}
