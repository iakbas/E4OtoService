using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4Oto.Crypt
{
   public class Reader
    {
        public static string ErrMess { get; set; }
        private static  string P { get; set; }
        public static System.Data.SqlClient.SqlConnectionStringBuilder GetCnnStr(string filePath = "")
        {
            System.Data.SqlClient.SqlConnectionStringBuilder builder =
                 new System.Data.SqlClient.SqlConnectionStringBuilder(); 

            if (ReadFile(filePath))
            {
                builder.ConnectionString = P;
                builder.Password = DeCrypt.DoDecrypt(builder.Password, "iAYazilim1@./*");


                return builder;

            }
            else { return null; }
        } 

        private static bool ReadFile(string filePath = "")
        {
            string mainFile = "";

            if (filePath.Trim().Length == 0)
            {
                mainFile = "cnn.ini";
            }
            else
            {
                if (File.Exists(filePath))
                    mainFile = filePath;
                else
                {
                    ErrMess = "Belirtilen dosya yolu bulunamadı !";
                    return false;
                }
            }
            int chk = -1;


            const Int32 BufferSize = 128;
            if (File.Exists(mainFile))
            {
                using (var fileStream = File.OpenRead(mainFile))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        P = line;
                        chk = 1;
                    }

                }
            }
            else
            {
                ErrMess = "Cnn Dosyası Bulunamadı !";
                chk = -1;
            }

            return chk < 0 ? false : true;
        }
    }
}
