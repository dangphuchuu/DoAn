using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Quanly
{
    [Serializable]
    class TruyVanSinhVien
    {
        private static TruyVanSinhVien instance = null;
        private List<SinhVien> dssv;
        public List<SinhVien> getDSSV()
        {
            return dssv;
        }
        public TruyVanSinhVien()
        {
            dssv = new List<SinhVien>();
        }
        public static TruyVanSinhVien khoitao()
        {
            if (instance == null)
                instance = new TruyVanSinhVien();
            return instance;
        }
        public static bool ghiFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, instance);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool docFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                instance = (TruyVanSinhVien)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
