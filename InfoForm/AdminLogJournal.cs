using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoForm
{
    public class AdminLogJournal
    {

        private string lag;
        private FileStream file;
        private StreamWriter writer;
        private string temp;
        private const string border = "=============================================================";

        public void ErrorLagWriterFile(string[] error) => this.WriterFile(error);

        private void WriterFile(string[] text) {

            FileStream file = new FileStream("C: \\Users\\jayson\\Desktop\\SQL\\SQL_Lag.txt", mode: FileMode.OpenOrCreate, FileAccess.ReadWrite);
            writer = new StreamWriter(file);
            for (int i = 0 ; i < text.Length ; i++)
            {

                text[i] = writer.NewLine +
                    text[i] +
                 writer.NewLine;

            }
            for (int i = 0 ; i < text.Length ; i++)
            {

                temp += text[i];

            }
            lag += border + writer.NewLine + DateTime.Now + border + writer.NewLine + temp + writer.NewLine + border;
            writer.WriteLine(lag);
            writer.Close();
            file.Close();

        }

        public void LogWriterFile(string[] log) => this.WriterFile(log);

    }
}
