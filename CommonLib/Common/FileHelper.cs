using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarlonLab.CommonLib.Common
{
    public class FileHelper
    {

        public static string  ReadFromFile(string FilePath)
        {
            //读取文件
            FileStream fs = new FileStream(FilePath, FileMode.Open);
            byte[] btFileContent = new byte[fs.Length];
            fs.Read(btFileContent, 0, (int)fs.Length);
            fs.Close();
            string strFileContent = Encoding.Default.GetString(btFileContent);

            return strFileContent;
        }
        public static void SaveToFile(string FilePath, string FileContent)
        {
            //写入文件
            FileStream fs = new FileStream(FilePath, FileMode.Create);
            byte[] btFileContent = Encoding.Default.GetBytes(FileContent);
            fs.Write(btFileContent, 0, btFileContent.Length);
            fs.Flush();
            fs.Close();
        }
    }
}
