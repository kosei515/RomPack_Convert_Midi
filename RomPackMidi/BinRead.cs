using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomPackMidi
{
    internal class BinRead
    {
        public Form1 pro;

        public BinRead(Form1 pro2)
        {
            pro = pro2;
        }

         
        public void ReadBin(string BinFile)
        {
            System.IO.FileStream fs = new System.IO.FileStream(BinFile,System.IO.FileMode.Open,System.IO.FileAccess.Read);
            byte[] bs = new byte[fs.Length];
            fs.Read(bs, 0, bs.Length);
            

            if (!((bs[0] == 0xA5 || bs[0] == 0x5A) && bs[1] == 0x00))
            {
                pro.textBox2.Text = "Not Rom File.";
                return;
            }
            if (bs[0] == 0x5A && bs[1] == 0x00)
            {
                for (int b = 0; b < fs.Length; b++)
                {
                    string c = bs[b].ToString("X");
                    if (c == "0") c = "00";
                    if (c == "1") c = "01";
                    if (c == "2") c = "02";
                    if (c == "3") c = "03";
                    if (c == "4") c = "04";
                    if (c == "5") c = "05";
                    if (c == "6") c = "06";
                    if (c == "7") c = "07";
                    if (c == "8") c = "08";
                    if (c == "9") c = "09";
                    if (c == "A") c = "0A";
                    if (c == "B") c = "0B";
                    if (c == "C") c = "0C";
                    if (c == "D") c = "0D";
                    if (c == "E") c = "0E";
                    if (c == "F") c = "0F";
                    string a = new string(c.Reverse().ToArray());
                    bs[b] = Convert.ToByte(a, 16);
                }
            }
            fs.Close();

            pro.num = bs[6];
            int k = 2;
            int p = 0, q = 0;

            for (int i = 0; i < pro.num; i++)
            {
                int m = 0;
                p = 0;
                q = 0;
                while (!(bs[k - 2] == 0x10 && bs[k - 1] == 0x00 && bs[k] == 0x00)) { k++; }
                pro.SongList[i, m] = bs[k - 2];
                pro.SongList[i, m + 1] = bs[k - 1];
                pro.SongList[i, m + 2] = bs[k];
                pro.data2[i, 0, q] = bs[k - 2];
                pro.data2[i, 1, q] = bs[k - 1];
                pro.data2[i, 2, q] = bs[k];
                m += 3;
                q++;
                k++;
                while (!(bs[k - 2] == 0xF0 && p == 2))
                {
                    pro.SongList[i, m] = bs[k];
                    pro.data2[i, p, q] = bs[k];
                    p++;
                    if (p >= 3)
                    {
                        p = 0;
                        q++;
                    }
                    k++;
                    m++;
                }
                pro.SongList[i, m] = bs[k];
                pro.data2[i, 0, q] = bs[k - 2];
                q++;
                m++;
                while (!((bs[k - 2] == 0x10 || (bs[k - 3] == 0x00 && bs[k + 1] == 0x60)) && bs[k - 1] == 0x00 && bs[k] == 0x00)) { k++; }
                pro.SongList[i, m] = bs[k - 2];
                pro.SongList[i, m + 1] = bs[k - 1];
                pro.SongList[i, m + 2] = bs[k];
                pro.data2[i, 0, q] = bs[k - 2];
                pro.data2[i, 1, q] = bs[k - 1];
                pro.data2[i, 2, q] = bs[k];
                m += 3;
                q++;
                k++;
                p = 0;
                while (!(bs[k - 2] == 0xF0 && bs[k] == 0x00 && p == 2))
                {
                    pro.SongList[i, m] = bs[k];
                    pro.data2[i, p, q] = bs[k];
                    p++;
                    if (p >= 3)
                    {
                        p = 0;
                        q++;
                    }
                    k++;
                    m++;
                }
                pro.SongList[i, m] = bs[k];
                pro.data2[i, 0, q] = bs[k - 2];
                q++;
                m++;
                while (!(bs[k - 1] == 0x10 && bs[k] == 0x00)) { k++; }
                pro.SongList[i, m] = bs[k - 1];
                pro.SongList[i, m + 1] = bs[k];
                pro.data2[i, 0, q] = bs[k - 1];
                pro.data2[i, 1, q] = bs[k];
                m += 2;
                k++;
                q++;
                p = 0;
                int n = 0;
                while (!(bs[k - 1] == 0xF0 && n >= 8 && p == 1))
                {
                    pro.SongList[i, m] = bs[k];
                    pro.data2[i, p, q] = bs[k];
                    p++;
                    if (p >= 2)
                    {
                        p = 0;
                        q++;
                    }
                    k++;
                    m++;
                    n++;
                }
                pro.SongList[i, m] = bs[k];
                pro.SongLen[i] = m + 1;
                pro.SongLen2[i] = q + 1;
                pro.comboBox1.Items.Add(i + 1);
            }
        }


    }
}
