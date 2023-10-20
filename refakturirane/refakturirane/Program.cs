using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refakturirane
{
    internal class Program  
    {
        public const string FILE_NAME = "example.bin";
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew);
            BinaryWriter w = new BinaryWriter (fs);
            for (int i = 0; i<11; i++)
            {
                w.Write((int)i);
            }
            w.Close();
            fs.Close();
            using (fs=new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read));
            BinaryReader r= new BinaryReader(fs);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine (r.ReadInt32());
            }
            r Close();
            fs.Close();

        }
    }
}
