using Quanly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ManageStudent
{
    [Serializable]
    class Query
    {
        private static Query instance = null;
        private List<Student> lstudent;
        public List<Student> getStudent()
        {
            return lstudent;
        }
        public Query()
        {
            lstudent = new List<Student>();
        }
        public static Query init()
        {
            if (instance == null)
                instance = new Query();
            return instance;
        }
        public static bool writeFile(string folderName)
        {
            try
            {
                FileStream fs = new FileStream(folderName, FileMode.Create);
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
        public static bool readFile(string folderName)
        {
            try
            {
                FileStream fs = new FileStream(folderName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                instance = (Query)bf.Deserialize(fs);
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
