using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace RomPackMidi
{
    internal class ConvertSys
    {
        public Form1 pro;

        int vol ;

        public ConvertSys(Form1 pro2)
        {
            pro = pro2;
        }

        public void SetCon()
        {
            pro.di++;
            pro.data4[pro.di] = "6,0," + pro.MTrack[0] + ",7,127"; pro.di++;
            pro.data4[pro.di] = "6,0," + pro.MTrack[1] + ",7,127"; pro.di++;
            pro.data4[pro.di] = "6,0," + pro.MTrack[2] + ",7,127"; pro.di++;
            pro.data4[pro.di] = "6,0," + pro.MTrack[3] + ",7,127"; pro.di++;
            pro.data4[pro.di] = "6,0," + pro.MTrack[4] + ",7," + pro.CodeV; pro.di++;
            if(pro.CodeV == 0) pro.data4[pro.di] = "6,0," + pro.MTrack[4] + ",0,120"; pro.di++;

            if (pro.Rev >= 1)
            {
                pro.data4[pro.di] = "6,0," + pro.MTrack[0] + ",91," + pro.Rev; pro.di++;
                pro.data4[pro.di] = "6,0," + pro.MTrack[1] + ",91," + pro.Rev; pro.di++;
                pro.data4[pro.di] = "6,0," + pro.MTrack[2] + ",91," + pro.Rev; pro.di++;
                pro.data4[pro.di] = "6,0," + pro.MTrack[3] + ",91," + pro.Rev; pro.di++;
                pro.data4[pro.di] = "6,0," + pro.MTrack[4] + ",91," + pro.Rev; pro.di++;
            }

        }

        public void NoteCon()
        {

            int reS = 0, reE = 0, re0 = 0, re1 = 0, re2 = 0, re3 = 0, re4 = 0, re5 = 0, re6 = 0, re7 = 0, re8 = 0, reN = 0, reP = 0, reF = 0;
            int t = 0, up = 0, no = 0, p = 0;
            int ch = 0;
            

            for (int x = 0; x < pro.line0; x++)
            {

                //pro.data4[pro.di] = t + " = " ;

                //Timbre
                if (pro.data1[0, x] == 0x60)
                {
                    //pro.data4[pro.di] = t + " = ";
                    switch (pro.data1[1, x])
                    {
                        case 0x00:
                            pro.data4[pro.di] = " //Piano  r:" + pro.data1[2, x];  pro.di++;
                            if (ch == 0)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[0] + "," + pro.Piano[0];  pro.di++;

                                vol = pro.Piano[2];
                            }
                            if (ch == 1)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[1] + "," + pro.Piano[1];  pro.di++;
                                vol = pro.Piano[3];
                            }
                            if (pro.Piano[4] == 1) up = 1;
                            else up = 0;
                            break;
                        case 0x10:
                            pro.data4[pro.di] = " //Harpsichord  r:" + pro.data1[2, x];  pro.di++;
                            if (ch == 0)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[0] + "," + pro.Harpsichord[0];  pro.di++;
                                vol = pro.Harpsichord[2];
                            }
                            if (ch == 1)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[1] + "," + pro.Harpsichord[1];  pro.di++;
                                vol = pro.Harpsichord[3];
                            }
                            if (pro.Harpsichord[4] == 1) up = 1;
                            else up = 0;
                            break;
                        case 0x20:
                            pro.data4[pro.di] = " //Organ  r:" + pro.data1[2, x];  pro.di++;
                            if (ch == 0)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[0] + "," + pro.Organ[0];  pro.di++;
                                vol = pro.Organ[2];
                            }
                            if (ch == 1)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[1] + "," + pro.Organ[1];  pro.di++;
                                vol = pro.Organ[3];
                            }
                            if (pro.Organ[4] == 1) up = 1;
                            else up = 0;
                            break;
                        case 0x30:
                            pro.data4[pro.di] = " //Violin  r:" + pro.data1[2, x];  pro.di++;
                            if (ch == 0)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[0] + "," + pro.Violin[0];  pro.di++;
                                vol = pro.Violin[2];
                            }
                            if (ch == 1)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[1] + "," + pro.Violin[1];  pro.di++;
                                vol = pro.Violin[3];
                            }
                            if (pro.Violin[4] == 1) up = 1;
                            else up = 0;
                            break;
                        case 0x40:
                            pro.data4[pro.di] = " //Flute  r:" + pro.data1[2, x];  pro.di++;
                            if (ch == 0)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[0] + "," + pro.Flute[0];  pro.di++;
                                vol = pro.Flute[2];
                            }
                            if (ch == 1)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[1] + "," + pro.Flute[1];  pro.di++;
                                vol = pro.Flute[3];
                            }
                            if (pro.Flute[4] == 1) up = 1;
                            else up = 0;
                            break;
                        case 0x50:
                            pro.data4[pro.di] = " //Clarinet  r:" + pro.data1[2, x];  pro.di++;
                            if (ch == 0)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[0] + "," + pro.Clarinet[0];  pro.di++;
                                vol = pro.Clarinet[2];
                            }
                            if (ch == 1)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[1] + "," + pro.Clarinet[1];  pro.di++;
                                vol = pro.Clarinet[3];
                            }
                            if (pro.Clarinet[4] == 1) up = 1;
                            else up = 0;
                            break;
                        case 0x60:
                            pro.data4[pro.di] = " //Trumpet  r:" + pro.data1[2, x];  pro.di++;
                            if (ch == 0)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[0] + "," + pro.Trumpet[0];  pro.di++;
                                vol = pro.Trumpet[2];
                            }
                            if (ch == 1)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[1] + "," + pro.Trumpet[1];  pro.di++;
                                vol = pro.Trumpet[3];
                            }
                            if (pro.Trumpet[4] == 1) up = 1;
                            else up = 0;
                            break;
                        case 0x70:
                            pro.data4[pro.di] = " //Celesta  r:" + pro.data1[2, x];  pro.di++;
                            if (ch == 0)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[0] + "," + pro.Celesta[0];  pro.di++;
                                vol = pro.Celesta[2];
                            }
                            if (ch == 1)
                            {
                                pro.data4[pro.di] = "1," + t + "," + pro.MTrack[1] + "," + pro.Celesta[1];  pro.di++;
                                vol = pro.Celesta[3];
                            }
                            if (pro.Celesta[4] == 1) up = 1;
                            else up = 0;
                            break;
                    }

                    //Add
                    if (pro.data1[0, x + 1] == 0x20)
                    {
                        string hex12 = pro.data1[2, x].ToString("X");
                        if (hex12 == "0") hex12 = "00";
                        if (hex12 == "1") hex12 = "01";
                        if (hex12 == "2") hex12 = "02";
                        if (hex12 == "3") hex12 = "03";
                        if (hex12 == "4") hex12 = "04";
                        if (hex12 == "5") hex12 = "05";
                        if (hex12 == "6") hex12 = "06";
                        if (hex12 == "7") hex12 = "07";
                        if (hex12 == "8") hex12 = "08";
                        if (hex12 == "9") hex12 = "09";
                        if (hex12 == "A") hex12 = "0A";
                        if (hex12 == "B") hex12 = "0B";
                        if (hex12 == "C") hex12 = "0C";
                        if (hex12 == "D") hex12 = "0D";
                        if (hex12 == "E") hex12 = "0E";
                        if (hex12 == "F") hex12 = "0F";
                        string hex22 = pro.data1[2, x + 1].ToString("X");
                        if (hex22 == "0") hex22 = "00";
                        if (hex22 == "1") hex22 = "01";
                        if (hex22 == "2") hex22 = "02";
                        if (hex22 == "3") hex22 = "03";
                        if (hex22 == "4") hex22 = "04";
                        if (hex22 == "5") hex22 = "05";
                        if (hex22 == "6") hex22 = "06";
                        if (hex22 == "7") hex22 = "07";
                        if (hex22 == "8") hex22 = "08";
                        if (hex22 == "9") hex22 = "09";
                        if (hex22 == "A") hex22 = "0A";
                        if (hex22 == "B") hex22 = "0B";
                        if (hex22 == "C") hex22 = "0C";
                        if (hex22 == "D") hex22 = "0D";
                        if (hex22 == "E") hex22 = "0E";
                        if (hex22 == "F") hex22 = "0F";
                        string hex32 = String.Concat(hex22, hex12);
                        var hex34 = Convert.ToInt32(hex32, 16);

                        t += hex34;
                    }
                    else
                    {
                        t += pro.data1[2, x];
                    }
                    p = 0;
                }

                //Effect
                if (pro.data1[0, x] == 0x50)
                {
                    pro.data4[pro.di] = " //Effect  rest:" + pro.data1[2, x];  pro.di++;

                    if (pro.data1[0, x + 1] == 0x20)
                    {
                        string hex12 = pro.data1[2, x].ToString("X");
                        if (hex12 == "0") hex12 = "00";
                        if (hex12 == "1") hex12 = "01";
                        if (hex12 == "2") hex12 = "02";
                        if (hex12 == "3") hex12 = "03";
                        if (hex12 == "4") hex12 = "04";
                        if (hex12 == "5") hex12 = "05";
                        if (hex12 == "6") hex12 = "06";
                        if (hex12 == "7") hex12 = "07";
                        if (hex12 == "8") hex12 = "08";
                        if (hex12 == "9") hex12 = "09";
                        if (hex12 == "A") hex12 = "0A";
                        if (hex12 == "B") hex12 = "0B";
                        if (hex12 == "C") hex12 = "0C";
                        if (hex12 == "D") hex12 = "0D";
                        if (hex12 == "E") hex12 = "0E";
                        if (hex12 == "F") hex12 = "0F";
                        string hex22 = pro.data1[2, x + 1].ToString("X");
                        if (hex22 == "0") hex22 = "00";
                        if (hex22 == "1") hex22 = "01";
                        if (hex22 == "2") hex22 = "02";
                        if (hex22 == "3") hex22 = "03";
                        if (hex22 == "4") hex22 = "04";
                        if (hex22 == "5") hex22 = "05";
                        if (hex22 == "6") hex22 = "06";
                        if (hex22 == "7") hex22 = "07";
                        if (hex22 == "8") hex22 = "08";
                        if (hex22 == "9") hex22 = "09";
                        if (hex22 == "A") hex22 = "0A";
                        if (hex22 == "B") hex22 = "0B";
                        if (hex22 == "C") hex22 = "0C";
                        if (hex22 == "D") hex22 = "0D";
                        if (hex22 == "E") hex22 = "0E";
                        if (hex22 == "F") hex22 = "0F";
                        string hex32 = String.Concat(hex22, hex12);
                        var hex34 = Convert.ToInt32(hex32, 16);

                        t += hex34;
                    }
                    else
                    {
                        t += pro.data1[2, x];
                    }
                }

                //Rest
                if (pro.data1[0, x] == 0x10)
                {
                    string hex11 = pro.data1[1, x].ToString("X");
                    if (hex11 == "0") hex11 = "00";
                    if (hex11 == "1") hex11 = "01";
                    if (hex11 == "2") hex11 = "02";
                    if (hex11 == "3") hex11 = "03";
                    if (hex11 == "4") hex11 = "04";
                    if (hex11 == "5") hex11 = "05";
                    if (hex11 == "6") hex11 = "06";
                    if (hex11 == "7") hex11 = "07";
                    if (hex11 == "8") hex11 = "08";
                    if (hex11 == "9") hex11 = "09";
                    if (hex11 == "A") hex11 = "0A";
                    if (hex11 == "B") hex11 = "0B";
                    if (hex11 == "C") hex11 = "0C";
                    if (hex11 == "D") hex11 = "0D";
                    if (hex11 == "E") hex11 = "0E";
                    if (hex11 == "F") hex11 = "0F";
                    string hex12 = pro.data1[2, x].ToString("X");
                    if (hex12 == "0") hex12 = "00";
                    if (hex12 == "1") hex12 = "01";
                    if (hex12 == "2") hex12 = "02";
                    if (hex12 == "3") hex12 = "03";
                    if (hex12 == "4") hex12 = "04";
                    if (hex12 == "5") hex12 = "05";
                    if (hex12 == "6") hex12 = "06";
                    if (hex12 == "7") hex12 = "07";
                    if (hex12 == "8") hex12 = "08";
                    if (hex12 == "9") hex12 = "09";
                    if (hex12 == "A") hex12 = "0A";
                    if (hex12 == "B") hex12 = "0B";
                    if (hex12 == "C") hex12 = "0C";
                    if (hex12 == "D") hex12 = "0D";
                    if (hex12 == "E") hex12 = "0E";
                    if (hex12 == "F") hex12 = "0F";
                    string hex13 = String.Concat(hex12, hex11); ;
                    var hex14 = Convert.ToInt32(hex13, 16);

                    pro.data4[pro.di] = " //Rest:" + hex14 ;  pro.di++;
                    t += hex14 ;
                }

                //note
                byte byAux = (byte)((pro.data1[0, x] & 0xf0) >> 4);
                byte byAux2 = (byte)(pro.data1[0, x] & 0x0f);

                if ((byAux2 >= 0x1) && (byAux2 <= 0xC) && (byAux >= 0x3) && (byAux <= 6))
                {
                    switch (pro.data1[0, x])
                    {
                        case 0x31:
                            if (up == 0) no = 48;
                            if (up == 1) no = 60;
                            break;
                        case 0x32:
                            if (up == 0) no = 49;
                            if (up == 1) no = 61;
                            break;
                        case 0x33:
                            if (up == 0) no = 50;
                            if (up == 1) no = 62;
                            break;
                        case 0x34:
                            if (up == 0) no = 51;
                            if (up == 1) no = 63;
                            break;
                        case 0x35:
                            if (up == 0) no = 52;
                            if (up == 1) no = 64;
                            break;
                        case 0x36:
                            if (up == 0) no = 53;
                            if (up == 1) no = 65;
                            break;
                        case 0x37:
                            if (up == 0) no = 54;
                            if (up == 1) no = 66;
                            break;
                        case 0x38:
                            if (up == 0) no = 55;
                            if (up == 1) no = 67;
                            break;
                        case 0x39:
                            if (up == 0) no = 56;
                            if (up == 1) no = 68;
                            break;
                        case 0x3A:
                            if (up == 0) no = 57;
                            if (up == 1) no = 69;
                            break;
                        case 0x3B:
                            if (up == 0) no = 58;
                            if (up == 1) no = 70;
                            break;
                        case 0x3C:
                            if (up == 0) no = 59;
                            if (up == 1) no = 71;
                            break;
                        case 0x41:
                            if (up == 0) no = 60;
                            if (up == 1) no = 72;
                            break;
                        case 0x42:
                            if (up == 0) no = 61;
                            if (up == 1) no = 73;
                            break;
                        case 0x43:
                            if (up == 0) no = 62;
                            if (up == 1) no = 74;
                            break;
                        case 0x44:
                            if (up == 0) no = 63;
                            if (up == 1) no = 75;
                            break;
                        case 0x45:
                            if (up == 0) no = 64;
                            if (up == 1) no = 76;
                            break;
                        case 0x46:
                            if (up == 0) no = 65;
                            if (up == 1) no = 77;
                            break;
                        case 0x47:
                            if (up == 0) no = 66;
                            if (up == 1) no = 78;
                            break;
                        case 0x48:
                            if (up == 0) no = 67;
                            if (up == 1) no = 79;
                            break;
                        case 0x49:
                            if (up == 0) no = 68;
                            if (up == 1) no = 80;
                            break;
                        case 0x4A:
                            if (up == 0) no = 69;
                            if (up == 1) no = 81;
                            break;
                        case 0x4B:
                            if (up == 0) no = 70;
                            if (up == 1) no = 82;
                            break;
                        case 0x4C:
                            if (up == 0) no = 71;
                            if (up == 1) no = 83;
                            break;
                        case 0x51:
                            if (up == 0) no = 72;
                            if (up == 1) no = 84;
                            break;
                        case 0x52:
                            if (up == 0) no = 73;
                            if (up == 1) no = 85;
                            break;
                        case 0x53:
                            if (up == 0) no = 74;
                            if (up == 1) no = 86;
                            break;
                        case 0x54:
                            if (up == 0) no = 75;
                            if (up == 1) no = 87;
                            break;
                        case 0x55:
                            if (up == 0) no = 76;
                            if (up == 1) no = 88;
                            break;
                        case 0x56:
                            if (up == 0) no = 77;
                            if (up == 1) no = 89;
                            break;
                        case 0x57:
                            if (up == 0) no = 78;
                            if (up == 1) no = 90;
                            break;
                        case 0x58:
                            if (up == 0) no = 79;
                            if (up == 1) no = 91;
                            break;
                        case 0x59:
                            if (up == 0) no = 80;
                            if (up == 1) no = 92;
                            break;
                        case 0x5A:
                            if (up == 0) no = 81;
                            if (up == 1) no = 93;
                            break;
                        case 0x5B:
                            if (up == 0) no = 82;
                            if (up == 1) no = 94;
                            break;
                        case 0x5C:
                            if (up == 0) no = 83;
                            if (up == 1) no = 95;
                            break;
                        case 0x61:
                            if (up == 0) no = 84;
                            if (up == 1) no = 96;
                            break;
                    }

                    if (pro.data1[0, x + 1] == 0x20)
                    {
                        string hex11 = pro.data1[1, x].ToString("X");
                        if (hex11 == "0") hex11 = "00";
                        if (hex11 == "1") hex11 = "01";
                        if (hex11 == "2") hex11 = "02";
                        if (hex11 == "3") hex11 = "03";
                        if (hex11 == "4") hex11 = "04";
                        if (hex11 == "5") hex11 = "05";
                        if (hex11 == "6") hex11 = "06";
                        if (hex11 == "7") hex11 = "07";
                        if (hex11 == "8") hex11 = "08";
                        if (hex11 == "9") hex11 = "09";
                        if (hex11 == "A") hex11 = "0A";
                        if (hex11 == "B") hex11 = "0B";
                        if (hex11 == "C") hex11 = "0C";
                        if (hex11 == "D") hex11 = "0D";
                        if (hex11 == "E") hex11 = "0E";
                        if (hex11 == "F") hex11 = "0F";
                        string hex12 = pro.data1[2, x].ToString("X");
                        if (hex12 == "0") hex12 = "00";
                        if (hex12 == "1") hex12 = "01";
                        if (hex12 == "2") hex12 = "02";
                        if (hex12 == "3") hex12 = "03";
                        if (hex12 == "4") hex12 = "04";
                        if (hex12 == "5") hex12 = "05";
                        if (hex12 == "6") hex12 = "06";
                        if (hex12 == "7") hex12 = "07";
                        if (hex12 == "8") hex12 = "08";
                        if (hex12 == "9") hex12 = "09";
                        if (hex12 == "A") hex12 = "0A";
                        if (hex12 == "B") hex12 = "0B";
                        if (hex12 == "C") hex12 = "0C";
                        if (hex12 == "D") hex12 = "0D";
                        if (hex12 == "E") hex12 = "0E";
                        if (hex12 == "F") hex12 = "0F";
                        string hex21 = pro.data1[1, x + 1].ToString("X");
                        if (hex21 == "0") hex21 = "00";
                        if (hex21 == "1") hex21 = "01";
                        if (hex21 == "2") hex21 = "02";
                        if (hex21 == "3") hex21 = "03";
                        if (hex21 == "4") hex21 = "04";
                        if (hex21 == "5") hex21 = "05";
                        if (hex21 == "6") hex21 = "06";
                        if (hex21 == "7") hex21 = "07";
                        if (hex21 == "8") hex21 = "08";
                        if (hex21 == "9") hex21 = "09";
                        if (hex21 == "A") hex21 = "0A";
                        if (hex21 == "B") hex21 = "0B";
                        if (hex21 == "C") hex21 = "0C";
                        if (hex21 == "D") hex21 = "0D";
                        if (hex21 == "E") hex21 = "0E";
                        if (hex21 == "F") hex21 = "0F";
                        string hex22 = pro.data1[2, x + 1].ToString("X");
                        if (hex22 == "0") hex22 = "00";
                        if (hex22 == "1") hex22 = "01";
                        if (hex22 == "2") hex22 = "02";
                        if (hex22 == "3") hex22 = "03";
                        if (hex22 == "4") hex22 = "04";
                        if (hex22 == "5") hex22 = "05";
                        if (hex22 == "6") hex22 = "06";
                        if (hex22 == "7") hex22 = "07";
                        if (hex22 == "8") hex22 = "08";
                        if (hex22 == "9") hex22 = "09";
                        if (hex22 == "A") hex22 = "0A";
                        if (hex22 == "B") hex22 = "0B";
                        if (hex22 == "C") hex22 = "0C";
                        if (hex22 == "D") hex22 = "0D";
                        if (hex22 == "E") hex22 = "0E";
                        if (hex22 == "F") hex22 = "0F";
                        string hex31 = String.Concat(hex21, hex11);
                        string hex32 = String.Concat(hex22, hex12);
                        var hex33 = Convert.ToInt32(hex31, 16);
                        var hex34 = Convert.ToInt32(hex32, 16);

                        pro.data4[pro.di] = "3," + t + "," + pro.MTrack[ch] + "," + no + "," + vol + "," + hex33;  pro.di++;

                        t += (hex33 + hex34);
                    }
                    else
                    {
                        pro.data4[pro.di] = "3," + t + "," + pro.MTrack[ch] + "," + no + ","+ vol + "," + pro.data1[1, x];  pro.di++;

                        t += pro.data1[1, x] + pro.data1[2, x];
                    }
                }

                //repeat
                if ((byAux2 == 0xf) && (pro.data1[1, x] == 0x00) && (pro.data1[2, x] == 0x00))
                {
                    switch (byAux)
                    {
                        case 0x0:
                            pro.data4[pro.di] = " //Start Repeat";  pro.di++;
                            re0 = x;
                            reS = 0;
                            reN = 0;
                            reP = 0;
                            reF = 0;
                            break;
                        case 0x1:
                            pro.data4[pro.di] = " //Repeat";  pro.di++;
                            reE = 1;
                            if (reS == 1 && pro.data1[0, x + 1] != 0x1F) reN++;
                            if (reS == 0 && reP == 0)
                            {
                                x = re0;
                                reN++;
                                reP = reN;
                            }
                            else { reP--; }
                            break;
                        case 0x8:
                            pro.data4[pro.di] = " //Repeat 1";  pro.di++;
                            re1 = x;
                            reS = 1;
                            if (reN == 1) x = re2;
                            if (reN == 2) x = re3;
                            if (reN == 3) x = re4;
                            if (reN == 4) x = re5;
                            if (reN == 5) x = re6;
                            if (reN == 6) x = re7;
                            if (reN == 7) x = re8;
                            break;
                        case 0x9:
                            pro.data4[pro.di] = " //Repeat 2";  pro.di++;
                            re2 = x;
                            if(pro.data1[0, x - 1] != 0x8F && reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            reF = 1;
                            break;
                        case 0xA:
                            pro.data4[pro.di] = " //Repeat 3";  pro.di++;
                            if(reF == 0)re2 = x;
                            re3 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                        case 0xB:
                            pro.data4[pro.di] = " //Repeat 4";  pro.di++;
                            re4 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                        case 0xC:
                            pro.data4[pro.di] = " //Repeat 5";  pro.di++;
                            re5 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                        case 0xD:
                            pro.data4[pro.di] = " //Repeat 6";  pro.di++;
                            re6 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                        case 0xE:
                            pro.data4[pro.di] = " //Repeat 7";  pro.di++;
                            re7 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                        case 0xF:
                            pro.data4[pro.di] = " //Repeat 8";  pro.di++;
                            re8 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                    }
                }


                if (pro.data1[0, x] == 0xF0 && p == 0)
                {
                    //pro.data4[pro.di] = "5," + t + "\r\n"; pro.di++;
                    pro.data4[pro.di] = " //End\r\n\r\n";  pro.di++;
                    p = 1;
                    ch++;
                    if (ch >= 2)
                    {
                        pro.p = x + 1;
                        break;
                    }
                    t = 0;
                }



            }
        }

        public void CodeCon()
        {
            int reS = 0, reE = 0, re0 = 0, re1 = 0, re2 = 0, re3 = 0, re4 = 0, re5 = 0, re6 = 0, re7 = 0, re8 = 0, reN = 0, reP = 0, reF = 0;
            int t = 0, t2 = 0, t3 = 0, cod = 0, rhF = 0;
            //int ch = 2;
            int co = 0, co0 = 0, co1 = 0, co2 = 0, co3 = 0, co4 = 0;

            pro.data4[pro.di] = "1,0,9," + pro.Rhyrhm[0];  pro.di++;
            pro.data4[pro.di] = "1,0," + pro.MTrack[2] + "," + pro.Bass[0];  pro.di++;
            if (pro.CodeM == 1) { pro.data4[pro.di] = "1,0," + pro.MTrack[4] + "," + pro.Acc[0]; pro.di++; }

            pro.data4[pro.di] = "1,0," + pro.MTrack[3] + "," + pro.Acc[0];  pro.di++;

            for (int x = pro.p; x < pro.line0; x++)
            {
                pro.data3[0, cod] = pro.data1[0, x];
                pro.data3[1, cod] = pro.data1[1, x];
                pro.data3[2, cod] = t;
                cod++;

                byte byAux = (byte)((pro.data1[0, x] & 0xf0) >> 4);
                byte byAux2 = (byte)(pro.data1[0, x] & 0x0f);


                //Rest
                if (pro.data1[0, x] == 0x10)
                {
                    //string hex11 = pro.data1[1, x].ToString("X");
                    //string hex12 = pro.data1[2, x].ToString("X");
                    //string hex13 = String.Concat(hex12, hex11); ;
                    //var hex14 = Convert.ToInt32(hex13, 16);

                    pro.data4[pro.di] = " //Rest:" + pro.data1[1, x];  pro.di++;




                    if (pro.data1[0, x + 1] == 0x20)
                    {
                        string hex11 = pro.data1[1, x].ToString("X");
                        if (hex11 == "0") hex11 = "00";
                        if (hex11 == "1") hex11 = "01";
                        if (hex11 == "2") hex11 = "02";
                        if (hex11 == "3") hex11 = "03";
                        if (hex11 == "4") hex11 = "04";
                        if (hex11 == "5") hex11 = "05";
                        if (hex11 == "6") hex11 = "06";
                        if (hex11 == "7") hex11 = "07";
                        if (hex11 == "8") hex11 = "08";
                        if (hex11 == "9") hex11 = "09";
                        if (hex11 == "A") hex11 = "0A";
                        if (hex11 == "B") hex11 = "0B";
                        if (hex11 == "C") hex11 = "0C";
                        if (hex11 == "D") hex11 = "0D";
                        if (hex11 == "E") hex11 = "0E";
                        if (hex11 == "F") hex11 = "0F";
                        string hex21 = pro.data1[1, x + 1].ToString("X");
                        if (hex21 == "0") hex21 = "00";
                        if (hex21 == "1") hex21 = "01";
                        if (hex21 == "2") hex21 = "02";
                        if (hex21 == "3") hex21 = "03";
                        if (hex21 == "4") hex21 = "04";
                        if (hex21 == "5") hex21 = "05";
                        if (hex21 == "6") hex21 = "06";
                        if (hex21 == "7") hex21 = "07";
                        if (hex21 == "8") hex21 = "08";
                        if (hex21 == "9") hex21 = "09";
                        if (hex21 == "A") hex21 = "0A";
                        if (hex21 == "B") hex21 = "0B";
                        if (hex21 == "C") hex21 = "0C";
                        if (hex21 == "D") hex21 = "0D";
                        if (hex21 == "E") hex21 = "0E";
                        if (hex21 == "F") hex21 = "0F";
                        string hex31 = String.Concat(hex21, hex11);
                        var hex33 = Convert.ToInt32(hex31, 16);

                        if (pro.CodeM == 1)
                        {
                            if (co != 0 && co0 == 0 && co1 == 0 && co2 == 0 && co3 == 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + co + ",100," + hex33; pro.di++; }
                            if (co0 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co0 - 12) + ",100," + hex33; pro.di++; }
                            if (co1 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co1 - 12) + ",100," + hex33; pro.di++; }
                            if (co2 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co2 - 12) + ",100," + hex33; pro.di++; }
                            if (co3 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co3 - 12) + ",100," + hex33; pro.di++; }
                        }

                        t2 = hex33;
                    }
                    else
                    {
                        if (pro.CodeM == 1 && pro.data1[1, x] != 0x00)
                        {
                            if (co != 0 && co0 == 0 && co1 == 0 && co2 == 0 && co3 == 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + co + ",100," + pro.data1[1, x]; pro.di++; }
                            if (co0 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co0 - 12) + ",100," + pro.data1[1, x]; pro.di++; }
                            if (co1 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co1 - 12) + ",100," + pro.data1[1, x]; pro.di++; }
                            if (co2 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co2 - 12) + ",100," + pro.data1[1, x]; pro.di++; }
                            if (co3 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co3 - 12) + ",100," + pro.data1[1, x]; pro.di++; }
                        }
                        t2 = pro.data1[1, x];
                    }
                    t += t2;
                }

                if (pro.data1[0, x] == 0x50)
                {
                    switch (pro.data1[1, x])
                    {
                        case 0x00:
                        case 0x01:
                        case 0x10:
                        case 0x11:
                        case 0x20:
                        case 0x21:
                        case 0x30:
                        case 0x31:
                        case 0x40:
                        case 0x41:
                        case 0x50:
                        case 0x51:
                        case 0x60:
                        case 0x61:
                        case 0x70:
                        case 0x71:
                            rhF = 0;
                            break;
                        default:
                            rhF = 1;
                            break;
                    }
                }

                //Code
                if ((byAux2 >= 0x1) && (byAux2 <= 0xC))
                {
                    if (pro.data1[0, x] != 0xF1)
                    {
                        //Bass
                        switch (byAux2)
                        {
                            case 0x1:
                                co = 36;
                                co0 = 60;
                                break;
                            case 0x2:
                                co = 37;
                                co0 = 61;
                                break;
                            case 0x3:
                                co = 38;
                                co0 = 62;
                                break;
                            case 0x4:
                                co = 39;
                                co0 = 63;
                                break;
                            case 0x5:
                                co = 40;
                                co0 = 64;
                                break;
                            case 0x6:
                                co = 41;
                                co0 = 65;
                                break;
                            case 0x7:
                                co = 42;
                                co0 = 54;
                                break;
                            case 0x8:
                                co = 43;
                                co0 = 55;
                                break;
                            case 0x9:
                                co = 44;
                                co0 = 56;
                                break;
                            case 0xA:
                                co = 45;
                                co0 = 57;
                                break;
                            case 0xB:
                                co = 46;
                                co0 = 58;
                                break;
                            case 0xC:
                                co = 47;
                                co0 = 59;
                                break;
                        }
                        //code
                        switch (byAux)
                        {
                            case 0x0:
                                co1 = co0 + 4;
                                co2 = co0 + 7;
                                co3 = 0;
                                break;
                            case 0x1:
                                co1 = co0 + 3;
                                co2 = co0 + 7;
                                co3 = 0;
                                break;
                            case 0x2:
                                co1 = co0 + 4;
                                co2 = co0 + 7;
                                co3 = co0 + 10;
                                break;
                            case 0x3:
                                co1 = co0 + 3;
                                co2 = co0 + 7;
                                co3 = co0 + 10;
                                break;
                            case 0x4:
                                co1 = co0 + 4;
                                co2 = co0 + 7;
                                co3 = co0 + 11;
                                break;
                            case 0x5:
                                co1 = co0 + 4;
                                co2 = co0 + 7;
                                co3 = co0 + 9;
                                break;
                            case 0x6:
                                co1 = co0 + 3;
                                co2 = co0 + 6;
                                co3 = co0 + 10;
                                break;
                            case 0x7:
                                co1 = co0 + 5;
                                co2 = co0 + 7;
                                co3 = 0;
                                break;
                            case 0x8:
                                co1 = co0 + 3;
                                co2 = co0 + 6;
                                co3 = co0 + 9;
                                break;
                            case 0x9:
                                co1 = co0 + 4;
                                co2 = co0 + 8;
                                co3 = 0;
                                break;
                            case 0xA:
                                co1 = co0 + 3;
                                co2 = co0 + 7;
                                co3 = co0 + 9;
                                break;
                            case 0xB:
                                co1 = co0 + 4;
                                co2 = co0 + 6;
                                co3 = 0;
                                break;
                            case 0xC:
                                co1 = co0 + 2;
                                co2 = co0 + 4;
                                co3 = co0 + 7;
                                break;
                            case 0xD:
                                co1 = co0 + 2;
                                co2 = co0 + 7;
                                co3 = co0 + 10;
                                break;
                            case 0xE:
                                co0 = 0;
                                co1 = 0;
                                co2 = 0;
                                co3 = 0;
                                break;
                        }
                        if (co0 >= 66) co0 -= 12;
                        if (co1 >= 66) co1 -= 12;
                        if (co2 >= 66) co2 -= 12;
                        if (co3 >= 66) co3 -= 12;

                        if (pro.data1[0, x + 1] == 0x20)
                        {
                            string hex11 = pro.data1[1, x].ToString("X");
                            if (hex11 == "0") hex11 = "00";
                            if (hex11 == "1") hex11 = "01";
                            if (hex11 == "2") hex11 = "02";
                            if (hex11 == "3") hex11 = "03";
                            if (hex11 == "4") hex11 = "04";
                            if (hex11 == "5") hex11 = "05";
                            if (hex11 == "6") hex11 = "06";
                            if (hex11 == "7") hex11 = "07";
                            if (hex11 == "8") hex11 = "08";
                            if (hex11 == "9") hex11 = "09";
                            if (hex11 == "A") hex11 = "0A";
                            if (hex11 == "B") hex11 = "0B";
                            if (hex11 == "C") hex11 = "0C";
                            if (hex11 == "D") hex11 = "0D";
                            if (hex11 == "E") hex11 = "0E";
                            if (hex11 == "F") hex11 = "0F";
                            string hex21 = pro.data1[1, x + 1].ToString("X");
                            if (hex21 == "0") hex21 = "00";
                            if (hex21 == "1") hex21 = "01";
                            if (hex21 == "2") hex21 = "02";
                            if (hex21 == "3") hex21 = "03";
                            if (hex21 == "4") hex21 = "04";
                            if (hex21 == "5") hex21 = "05";
                            if (hex21 == "6") hex21 = "06";
                            if (hex21 == "7") hex21 = "07";
                            if (hex21 == "8") hex21 = "08";
                            if (hex21 == "9") hex21 = "09";
                            if (hex21 == "A") hex21 = "0A";
                            if (hex21 == "B") hex21 = "0B";
                            if (hex21 == "C") hex21 = "0C";
                            if (hex21 == "D") hex21 = "0D";
                            if (hex21 == "E") hex21 = "0E";
                            if (hex21 == "F") hex21 = "0F";
                            string hex31 = String.Concat(hex21, hex11);
                            var hex33 = Convert.ToInt32(hex31, 16);

                            if (pro.CodeM == 1)
                            {
                                if (co != 0 && co0 == 0 && co1 == 0 && co2 == 0 && co3 == 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + co + ",100," + hex33; pro.di++; }
                                if (co0 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co0 - 12) + ",100," + hex33; pro.di++; }
                                if (co1 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co1 - 12) + ",100," + hex33; pro.di++; }
                                if (co2 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co2 - 12) + ",100," + hex33; pro.di++; }
                                if (co3 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co3 - 12) + ",100," + hex33; pro.di++; }
                            }

                            t2 = hex33;
                        }
                        else
                        {
                            if (pro.CodeM == 1)
                            {
                                if (co != 0 && co0 == 0 && co1 == 0 && co2 == 0 && co3 == 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + co + ",100," + pro.data1[1, x]; pro.di++; }
                                if (co0 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co0 - 12) + ",100," + pro.data1[1, x]; pro.di++; }
                                if (co1 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co1 - 12) + ",100," + pro.data1[1, x]; pro.di++; }
                                if (co2 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co2 - 12) + ",100," + pro.data1[1, x]; pro.di++; }
                                if (co3 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[4] + "," + (co3 - 12) + ",100," + pro.data1[1, x]; pro.di++; }
                            }
                            t2 = pro.data1[1, x];
                        }


                        if (rhF == 1)
                        {
                            if (co != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + ", " + t2; pro.di++; }
                            if (co0 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + t2; pro.di++; }
                            if (co1 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + t2; pro.di++; }
                            if (co2 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + t2; pro.di++; }
                            if (co3 != 0) { pro.data4[pro.di] = "3," + t + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + t2; pro.di++; }
                        }

                       


                    }
                    else
                    {
                        co = 0;
                        co0 = 0;
                        co1 = 0;
                        co2 = 0;
                        co3 = 0;

                        if (pro.data1[0, x + 1] == 0x20)
                        {
                            string hex11 = pro.data1[1, x].ToString("X");
                            if (hex11 == "0") hex11 = "00";
                            if (hex11 == "1") hex11 = "01";
                            if (hex11 == "2") hex11 = "02";
                            if (hex11 == "3") hex11 = "03";
                            if (hex11 == "4") hex11 = "04";
                            if (hex11 == "5") hex11 = "05";
                            if (hex11 == "6") hex11 = "06";
                            if (hex11 == "7") hex11 = "07";
                            if (hex11 == "8") hex11 = "08";
                            if (hex11 == "9") hex11 = "09";
                            if (hex11 == "A") hex11 = "0A";
                            if (hex11 == "B") hex11 = "0B";
                            if (hex11 == "C") hex11 = "0C";
                            if (hex11 == "D") hex11 = "0D";
                            if (hex11 == "E") hex11 = "0E";
                            if (hex11 == "F") hex11 = "0F";
                            string hex21 = pro.data1[1, x + 1].ToString("X");
                            if (hex21 == "0") hex21 = "00";
                            if (hex21 == "1") hex21 = "01";
                            if (hex21 == "2") hex21 = "02";
                            if (hex21 == "3") hex21 = "03";
                            if (hex21 == "4") hex21 = "04";
                            if (hex21 == "5") hex21 = "05";
                            if (hex21 == "6") hex21 = "06";
                            if (hex21 == "7") hex21 = "07";
                            if (hex21 == "8") hex21 = "08";
                            if (hex21 == "9") hex21 = "09";
                            if (hex21 == "A") hex21 = "0A";
                            if (hex21 == "B") hex21 = "0B";
                            if (hex21 == "C") hex21 = "0C";
                            if (hex21 == "D") hex21 = "0D";
                            if (hex21 == "E") hex21 = "0E";
                            if (hex21 == "F") hex21 = "0F";
                            string hex31 = String.Concat(hex21, hex11);
                            var hex33 = Convert.ToInt32(hex31, 16);

                            pro.data4[pro.di] = " // rest:" + hex33;  pro.di++;

                            t2 = hex33;
                        }
                        else
                        {
                            pro.data4[pro.di] = " // rest:" + pro.data1[1, x];  pro.di++;
                            t2 = pro.data1[1, x];
                        }
                    }
                    t += t2;
                }

                //Repeat
                if ((byAux2 == 0xf))
                {
                    switch (byAux)
                    {
                        case 0x0:
                            pro.data4[pro.di] = " //Start Repeat";  pro.di++;
                            re0 = x;
                            reS = 0;
                            reN = 0;
                            reP = 0;
                            reF = 0;
                            break;
                        case 0x1:
                            pro.data4[pro.di] = " //Repeat";  pro.di++;
                            reE = 1;
                            if (reS == 1 && pro.data1[0, x + 1] != 0x1F) reN++;
                            if (reS == 0 && reP == 0)
                            {
                                x = re0;
                                reN++;
                                reP = reN;
                            }
                            else { reP--; }
                            break;
                        case 0x8:
                            pro.data4[pro.di] = " //Repeat 1";  pro.di++;
                            if (pro.data1[0, x - 1] != 0x1F)
                            {
                                re1 = x;
                                reS = 1;
                                if (reN == 1) x = re2;
                                if (reN == 2) x = re3;
                                if (reN == 3) x = re4;
                                if (reN == 4) x = re5;
                                if (reN == 5) x = re6;
                                if (reN == 6) x = re7;
                                if (reN == 7) x = re8;
                            }
                            break;
                        case 0x9:
                            pro.data4[pro.di] = " //Repeat 2";  pro.di++;
                            re2 = x;
                            if (reE == 1 && pro.data1[0, x - 1] != 0x8F && reS == 1) x = re0;
                            reE = 0;
                            reF = 1;
                            break;
                        case 0xA:
                            pro.data4[pro.di] = " //Repeat 3";  pro.di++;
                            if (reF == 0) re2 = x;
                            re3 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                        case 0xB:
                            pro.data4[pro.di] = " //Repeat 4";  pro.di++;
                            re4 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                        case 0xC:
                            pro.data4[pro.di] = " //Repeat 5";  pro.di++;
                            re5 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                        case 0xD:
                            pro.data4[pro.di] = " //Repeat 6";  pro.di++;
                            re6 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                        case 0xE:
                            pro.data4[pro.di] = " //Repeat 7";  pro.di++;
                            re7 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                        case 0xF:
                            pro.data4[pro.di] = " //Repeat 8";  pro.di++;
                            re8 = x;
                            if (reE == 1 && reS == 1) x = re0;
                            reE = 0;
                            break;
                    }
                }

                //Tempo
                if (pro.data1[0, x] == 0xC0)
                {
                    switch (pro.data1[1, x])
                    {
                        case 0x06:
                        case 0x07:
                            pro.data4[pro.di] = "2," + t + ",52";  pro.di++;
                            break;
                        case 0x08:
                        case 0x09:
                            pro.data4[pro.di] = "2," + t + ",54";  pro.di++;
                            break;
                        case 0x0A:
                        case 0x0B:
                            pro.data4[pro.di] = "2," + t + ",56";  pro.di++;
                            break;
                        case 0x0C:
                        case 0x0D:
                            pro.data4[pro.di] = "2," + t + ",58";  pro.di++;
                            break;
                        case 0x0E:
                        case 0x0F:
                            pro.data4[pro.di] = "2," + t + ",60";  pro.di++;
                            break;
                        case 0x10:
                        case 0x11:
                            pro.data4[pro.di] = "2," + t + ",62";  pro.di++;
                            break;
                        case 0x12:
                        case 0x13:
                            pro.data4[pro.di] = "2," + t + ",66";  pro.di++;
                            break;
                        case 0x14:
                        case 0x15:
                            pro.data4[pro.di] = "2," + t + ",70";  pro.di++;
                            break;
                        case 0x16:
                        case 0x17:
                            pro.data4[pro.di] = "2," + t + ",74";  pro.di++;
                            break;
                        case 0x18:
                        case 0x19:
                            pro.data4[pro.di] = "2," + t + ",78";  pro.di++;
                            break;
                        case 0x1A:
                        case 0x1B:
                            pro.data4[pro.di] = "2," + t + ",82";  pro.di++;
                            break;
                        case 0x1C:
                        case 0x1D:
                            pro.data4[pro.di] = "2," + t + ",86";  pro.di++;
                            break;
                        case 0x1E:
                        case 0x1F:
                            pro.data4[pro.di] = "2," + t + ",90";  pro.di++;
                            break;
                        case 0x20:
                        case 0x21:
                            pro.data4[pro.di] = "2," + t + ",98";  pro.di++;
                            break;
                        case 0x22:
                        case 0x23:
                            pro.data4[pro.di] = "2," + t + ",106";  pro.di++;
                            break;
                        case 0x24:
                        case 0x25:
                            pro.data4[pro.di] = "2," + t + ",118";  pro.di++;
                            break;
                        case 0x26:
                        case 0x27:
                            pro.data4[pro.di] = "2," + t + ",126";  pro.di++;
                            break;
                        case 0x28:
                        case 0x29:
                            pro.data4[pro.di] = "2," + t + ",136";  pro.di++;
                            break;
                        case 0x2A:
                        case 0x2B:
                            pro.data4[pro.di] = "2," + t + ",148";  pro.di++;
                            break;
                        case 0x2C:
                        case 0x2D:
                            pro.data4[pro.di] = "2," + t + ",162";  pro.di++;
                            break;
                        case 0x2E:
                        case 0x2F:
                            pro.data4[pro.di] = "2," + t + ",176"; pro.di++;
                            break;
                        case 0x30:
                        case 0x31:
                        case 0x32:
                        case 0x33:
                        case 0x34:
                        case 0x35:
                        case 0x36:
                        case 0x37:
                        case 0x38:
                        case 0x39:
                        case 0x3A:
                        case 0x3B:
                        case 0x3C:
                        case 0x3D:
                        case 0x3E:
                        case 0x3F:
                        case 0x40:
                        case 0x41:
                        case 0x42:
                        case 0x43:
                        case 0x44:
                            pro.data4[pro.di] = "2," + t + ",188";  pro.di++;
                            break;
                    }
                }
                //End
                if (pro.data1[0, x] == 0xF0)
                {
                    pro.data4[pro.di] = "6," + t + ",0,120,0"; pro.di++;
                    pro.data4[pro.di] = "5," + t + "\r\n"; pro.di++;
                    pro.data4[pro.di] = " //End\r\n\r\n";  pro.di++;

                    t3 = t;
                }

            }

            int z = 0, p = 0;
            int rh = 0, rhT = 0, fil = 0;


            for (int y = 0; y < t3; y++)
            {


                if (y == pro.data3[2, z])
                {
                    //pro.data4[pro.di] = y;  pro.di++;
                    byte byAux = (byte)((pro.data3[0, z] & 0xf0) >> 4);
                    byte byAux2 = (byte)(pro.data3[0, z] & 0x0f);
                    //Count
                    if (pro.data3[0, z] == 0x80)
                    {
                        switch (pro.data3[1, z])
                        {
                            case 0x80:
                                rh = 1;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0x81:
                                rh = 2;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0x90:
                                rh = 3;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0x91:
                                rh = 4;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xA0:
                                rh = 5;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xA1:
                                rh = 6;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xB0:
                                rh = 7;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xB1:
                                rh = 8;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xC0:
                                rh = 9;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xC1:
                                rh = 10;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xD0:
                                rh = 11;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xD1:
                                rh = 12;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xE0:
                                rh = 13;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xE1:
                                rh = 14;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                            case 0xF0:
                                rh = 15;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",3,2,24,8";  pro.di++;
                                break;
                            case 0xF1:
                                rh = 16;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",3,2,24,8";  pro.di++;
                                break;
                            default:
                                rh = 0;
                                pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8";  pro.di++;
                                break;
                        }
                        fil = 3;
                        if (rh <= 14 && rhT <= 95) rhT += 96;
                        if (rh >= 15 && rhT <= 71) rhT += 72;
                    }

                    //Rhythm
                    if (pro.data3[0, z] == 0x50)
                    {
                        switch (pro.data3[1, z])
                        {
                            case 0x00:
                                rh = 1;
                                pro.data4[pro.di] = " //Rhrthm = Rock  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x01:
                                rh = 2;
                                pro.data4[pro.di] = " //Rhrthm = Rock'n'Roll  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x10:
                                rh = 3;
                                pro.data4[pro.di] = " //Rhrthm = Disco  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x11:
                                rh = 4;
                                pro.data4[pro.di] = " //Rhrthm = 16-Beat  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x20:
                                rh = 5;
                                pro.data4[pro.di] = " //Rhrthm = Swing 2-Beat  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x21:
                                rh = 6;
                                pro.data4[pro.di] = " //Rhrthm = Swing 4-Beat  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x30:
                                rh = 7;
                                pro.data4[pro.di] = " //Rhrthm = Samba  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x31:
                                rh = 8;
                                pro.data4[pro.di] = " //Rhrthm = Latin Rock  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x40:
                                rh = 9;
                                pro.data4[pro.di] = " //Rhrthm = Bossa Nova  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x41:
                                rh = 10;
                                pro.data4[pro.di] = " //Rhrthm = Beguine  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x50:
                                rh = 11;
                                pro.data4[pro.di] = " //Rhrthm = Tango  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x51:
                                rh = 12;
                                pro.data4[pro.di] = " //Rhrthm = March  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x60:
                                rh = 13;
                                pro.data4[pro.di] = " //Rhrthm = Slow Rock  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x61:
                                rh = 14;
                                pro.data4[pro.di] = " //Rhrthm = Ballad  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x70:
                                rh = 15;
                                pro.data4[pro.di] = " //Rhrthm = Waltz  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x71:
                                rh = 16;
                                pro.data4[pro.di] = " //Rhrthm = Rock Waltz  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0xF0:
                            case 0xF1:
                                rh = 17;
                                break;
                            default:
                                rh = 0;
                                break;
                        }
                        fil = 0;
                        p = 1;
                    }
                    //Count Reset
                    if (pro.data3[0, z] == 0x90 && z >= 3)
                    {
                        
                        p = 1;
                        pro.data4[pro.di] = " //Count Reset  " + pro.data3[2, z];  pro.di++;
                        if (rh <= 14)
                        {
                            if (rhT == 6 || rhT == 102) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 6) + ",1,4,24,8"; pro.di++; }
                            if (rhT == 12 || rhT == 108) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 12) + ",1,3,24,8"; pro.di++; }
                            if (rhT == 18 || rhT == 114) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 18) + ",3,4,24,8"; pro.di++; }
                            if (rhT == 24 || rhT == 120) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 24) + ",1,2,24,8"; pro.di++; }
                            if (rhT == 30 || rhT == 126) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 30) + ",5,4,24,8"; pro.di++; }
                            if (rhT == 36 || rhT == 132) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 36) + ",3,3,24,8"; pro.di++; }
                            if (rhT == 42 || rhT == 138) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 42) + ",7,4,24,8"; pro.di++; }
                            if (rhT == 48 || rhT == 144) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 48) + ",2,2,24,8"; pro.di++; }
                            if (rhT == 54 || rhT == 150) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 54) + ",9,4,24,8"; pro.di++; }
                            if (rhT == 60 || rhT == 156) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 60) + ",5,3,24,8"; pro.di++; }
                            if (rhT == 66 || rhT == 162) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 66) + ",11,4,24,8"; pro.di++; }
                            if (rhT == 72 || rhT == 168) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 72) + ",3,2,24,8"; pro.di++; }
                            if (rhT == 78 || rhT == 174) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 78) + ",13,4,24,8"; pro.di++; }
                            if (rhT == 84 || rhT == 180) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 84) + ",7,3,24,8"; pro.di++; }
                            if (rhT == 90 || rhT == 186) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 90) + ",15,4,24,8"; pro.di++; }
                            pro.data4[pro.di] = "4," + pro.data3[2, z] + ",4,2,24,8"; pro.di++;
                        }
                        if (rh >= 15)
                        {
                            if (rhT == 6 || rhT == 78) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 6) + ",1,4,24,8"; pro.di++; }
                            if (rhT == 12 || rhT == 84) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 12) + ",1,3,24,8"; pro.di++; }
                            if (rhT == 18 || rhT == 90) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 18) + ",3,4,24,8"; pro.di++; }
                            if (rhT == 24 || rhT == 96) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 24) + ",1,2,24,8"; pro.di++; }
                            if (rhT == 30 || rhT == 102) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 30) + ",5,4,24,8"; pro.di++; }
                            if (rhT == 36 || rhT == 108) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 36) + ",3,3,24,8"; pro.di++; }
                            if (rhT == 42 || rhT == 114) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 42) + ",7,4,24,8"; pro.di++; }
                            if (rhT == 48 || rhT == 120) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 48) + ",2,2,24,8"; pro.di++; }
                            if (rhT == 54 || rhT == 126) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 54) + ",9,4,24,8"; pro.di++; }
                            if (rhT == 60 || rhT == 132) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 60) + ",5,3,24,8"; pro.di++; }
                            if (rhT == 66 || rhT == 138) { pro.data4[pro.di] = "4," + (pro.data3[2, z] - 66) + ",11,4,24,8"; pro.di++; }
                            pro.data4[pro.di] = "4," + pro.data3[2, z] + ",3,2,24,8"; pro.di++;
                        }
                        rhT = 0;
                    }
                    //Fill in
                    if (pro.data3[0, z] == 0x60)
                    {
                        byte byAux3 = (byte)((pro.data3[1, z] & 0xf0) >> 4);
                        if ((byAux3 >= 0x0) && (byAux3 <= 0x7))
                        {
                            fil = 1;
                            p = 1;
                            if (rh <= 14 && rhT <= 95) rhT += 96;
                            if (rh >= 15 && rhT <= 71) rhT += 72;
                            if (rh <= 14 && rhT >= 189) rhT -= 96;
                            if (rh >= 15 && rhT >= 141) rhT -= 72;
                            pro.data4[pro.di] = " //Fill in ON  " + pro.data3[2, z];  pro.di++;
                        }
                        else
                        {
                            fil = 0;
                            pro.data4[pro.di] = " //Fill in OFF  " + pro.data3[2, z];  pro.di++;
                        }
                    }
                    if ((byAux2 == 0xf))
                    {
                        switch (byAux)
                        {
                            case 0x0:
                                pro.data4[pro.di] = " //Start Repeat";  pro.di++;
                                break;
                            case 0x1:
                                pro.data4[pro.di] = " //Repeat";  pro.di++;
                                break;
                            case 0x8:
                                pro.data4[pro.di] = " //Repeat 1";  pro.di++;
                                break;
                            case 0x9:
                                pro.data4[pro.di] = " //Repeat 2";  pro.di++;
                                break;
                            case 0xA:
                                pro.data4[pro.di] = " //Repeat 3";  pro.di++;
                                break;
                            case 0xB:
                                pro.data4[pro.di] = " //Repeat 4";  pro.di++;
                                break;
                            case 0xC:
                                pro.data4[pro.di] = " //Repeat 5";  pro.di++;
                                break;
                            case 0xD:
                                pro.data4[pro.di] = " //Repeat 6";  pro.di++;
                                break;
                            case 0xE:
                                pro.data4[pro.di] = " //Repeat 7";  pro.di++;
                                break;
                            case 0xF:
                                pro.data4[pro.di] = " //Repeat 8";  pro.di++;
                                break;
                        }
                    }
                    if (pro.data3[0, z] == 0xF0)
                    {
                        //pro.data4[pro.di] = " //End";  pro.di++;
                    }
                    z++;
                    if (pro.data3[2, z] == pro.data3[2, z - 1]) y--;
                    else p = 0;
                }




                if (fil == 3 && p == 0)
                {
                    if (rh >= 15)
                    {
                        if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                        if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                        if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                        if (rhT >= 141) fil = 0;
                    }
                    else
                    {
                        if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                        if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                        if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                        if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                        if (rhT >= 189) fil = 0;
                    }
                }

                if (fil == 0 && p == 0) switch (rh)
                    {
                        case 1:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 2:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 3:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 138) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 150) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 4:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 6) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 18) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 30) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 42) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 54) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 66) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 78) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 90) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 102) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 126) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 138) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 150) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 174) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 42) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 126) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 5:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 40) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 88) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 136) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 152) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 160) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 176) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 184) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 6:
                        case 14:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 40) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 88) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 136) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 184) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 7:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 6) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 18) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 30) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 42) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 54) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 66) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 78) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 90) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 102) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 126) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 138) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 150) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 162) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 174) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 186) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 18) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 66) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 162) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 30) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 42) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 54) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 66) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 78) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 126) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 138) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 150) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 162) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 174) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 8:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 18) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 42) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 66) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 90) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 138) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 162) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 42) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 126) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 9:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 10:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 18) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 11:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 186) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                            break;
                        case 12:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 162) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 13:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 8) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 16) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 32) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 40) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 56) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 64) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 80) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 88) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 104) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 112) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 128) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 136) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 152) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 160) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 176) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 184) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 40) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 88) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                            if (rhT == 136) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                            if (rhT == 160) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 15:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 16:
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 12) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 30) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 36) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 102) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 0) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 60) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 24) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 48) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                    }
                if (fil == 1 && p == 0)
                {
                    switch (rh)
                    {
                        case 1:
                        case 2:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 102) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 126) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 150) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 174) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 186) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 162) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 3:
                        case 8:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 138) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 174) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 102) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 4:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 102) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 126) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 138) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 150) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 162) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 174) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 186) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 5:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 104) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 112) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 136) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 152) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 160) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 160) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 176) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 184) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 184) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 6:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 104) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 112) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 128) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 136) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 152) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 160) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 184) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 112) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 128) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 184) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 7:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 102) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 138) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 150) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 162) { pro.data4[pro.di] = "3," + y + ",9," + "63," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 174) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 186) { pro.data4[pro.di] = "3," + y + ",9," + "64," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 138) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 150) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 162) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 174) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 186) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 9:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 126) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 10:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 114) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "37," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 11:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 186) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 12:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 156) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 174) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 180) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 186) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                        case 13:
                        case 14:
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 104) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 112) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 128) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 136) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 144) { pro.data4[pro.di] = "3," + y + ",9," + "41," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 152) { pro.data4[pro.di] = "3," + y + ",9," + "41," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 152) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                            if (rhT == 160) { pro.data4[pro.di] = "3," + y + ",9," + "41," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 160) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 168) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                            if (rhT == 176) { pro.data4[pro.di] = "3," + y + ",9," + "42," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                            if (rhT == 184) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 184) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6"; pro.di++; }
                            break;
                        case 15:
                        case 16:
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 72) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 84) { pro.data4[pro.di] = "3," + y + ",9," + "38," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 96) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 108) { pro.data4[pro.di] = "3," + y + ",9," + "45," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 120) { pro.data4[pro.di] = "3," + y + ",9," + "46," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            if (rhT == 132) { pro.data4[pro.di] = "3," + y + ",9," + "36," + pro.Rhyrhm[1] + ",6";  pro.di++; }
                            break;
                    }
                    if (rh <= 14 && rhT == 187) fil = 0;
                    if (rh >= 15 && rhT == 139) fil = 0;
                }

                if (pro.data3[2, z] != pro.data3[2, z - 1]) rhT++;
                if (rh <= 14 && rhT >= 192) rhT = 0;
                if (rh >= 15 && rhT >= 144) rhT = 0;

            }


            z = 0;
            rh = 0; rhT = 0; fil = 0;
            co = 0; co0 = 0; co1 = 0; co2 = 0; co3 = 0; co4 = 0;

            for (int y = 0; y < t3; y++)
            {


                if (y == pro.data3[2, z])
                {
                    //pro.data4[pro.di] = y;  pro.di++;
                    byte byAux = (byte)((pro.data3[0, z] & 0xf0) >> 4);
                    byte byAux2 = (byte)(pro.data3[0, z] & 0x0f);
                    //Count
                    if (pro.data3[0, z] == 0x80)
                    {
                        switch (pro.data3[1, z])
                        {
                            case 0x80:
                                rh = 1;
                                break;
                            case 0x81:
                                rh = 2;
                                break;
                            case 0x90:
                                rh = 3;
                                break;
                            case 0x91:
                                rh = 4;
                                break;
                            case 0xA0:
                                rh = 5;
                                break;
                            case 0xA1:
                                rh = 6;
                                break;
                            case 0xB0:
                                rh = 7;
                                break;
                            case 0xB1:
                                rh = 8;
                                break;
                            case 0xC0:
                                rh = 9;
                                break;
                            case 0xC1:
                                rh = 10;
                                break;
                            case 0xD0:
                                rh = 11;
                                break;
                            case 0xD1:
                                rh = 12;
                                break;
                            case 0xE0:
                                rh = 13;
                                break;
                            case 0xE1:
                                rh = 14;
                                break;
                            case 0xF0:
                                rh = 15;
                                break;
                            case 0xF1:
                                rh = 16;
                                break;
                            default:
                                rh = 0;
                                break;
                        }
                        pro.data4[pro.di] = " //Count in" + pro.data3[2, z];  pro.di++;
                        fil = 3;
                        if (rh <= 14 && rhT <= 95) rhT += 96;
                        if (rh >= 15 && rhT <= 71) rhT += 72;
                    }

                    //Rhythm
                    if (pro.data3[0, z] == 0x50)
                    {
                        switch (pro.data3[1, z])
                        {
                            case 0x00:
                                rh = 1;
                                pro.data4[pro.di] = " //Rhrthm = Rock  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x01:
                                rh = 2;
                                pro.data4[pro.di] = " //Rhrthm = Rock'n'Roll  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x10:
                                rh = 3;
                                pro.data4[pro.di] = " //Rhrthm = Disco  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x11:
                                rh = 4;
                                pro.data4[pro.di] = " //Rhrthm = 16-Beat  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x20:
                                rh = 5;
                                pro.data4[pro.di] = " //Rhrthm = Swing 2-Beat  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x21:
                                rh = 6;
                                pro.data4[pro.di] = " //Rhrthm = Swing 4-Beat  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x30:
                                rh = 7;
                                pro.data4[pro.di] = " //Rhrthm = Samba  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x31:
                                rh = 8;
                                pro.data4[pro.di] = " //Rhrthm = Latin Rock  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x40:
                                rh = 9;
                                pro.data4[pro.di] = " //Rhrthm = Bossa Nova  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x41:
                                rh = 10;
                                pro.data4[pro.di] = " //Rhrthm = Beguine  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x50:
                                rh = 11;
                                pro.data4[pro.di] = " //Rhrthm = Tango  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x51:
                                rh = 12;
                                pro.data4[pro.di] = " //Rhrthm = March  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x60:
                                rh = 13;
                                pro.data4[pro.di] = " //Rhrthm = Slow Rock  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x61:
                                rh = 14;
                                pro.data4[pro.di] = " //Rhrthm = Ballad  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x70:
                                rh = 15;
                                pro.data4[pro.di] = " //Rhrthm = Waltz  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0x71:
                                rh = 16;
                                pro.data4[pro.di] = " //Rhrthm = Rock Waltz  " + pro.data3[2, z];  pro.di++;
                                break;
                            case 0xF0:
                            case 0xF1:
                                rh = 17;
                                break;
                            default:
                                rh = 0;
                                break;
                        }
                        fil = 0;
                        p = 1;
                    }
                    //Count Reset
                    if (pro.data3[0, z] == 0x90)
                    {
                        rhT = 0;
                        p = 1;
                        pro.data4[pro.di] = " //Count Reset  " + pro.data3[2, z];  pro.di++;
                    }
                    //Fill in
                    if (pro.data3[0, z] == 0x60)
                    {
                        byte byAux3 = (byte)((pro.data3[1, z] & 0xf0) >> 4);
                        if ((byAux3 >= 0x0) && (byAux3 <= 0x7))
                        {
                            fil = 1;
                            p = 1;
                            if (rh <= 14 && rhT <= 95) rhT += 96;
                            if (rh >= 15 && rhT <= 71) rhT += 72;
                            if (rh <= 14 && rhT >= 189) rhT -= 96;
                            if (rh >= 15 && rhT >= 141) rhT -= 72;
                            pro.data4[pro.di] = " //Fill in ON  " + pro.data3[2, z];  pro.di++;
                        }
                        else
                        {
                            fil = 0;
                            pro.data4[pro.di] = " //Fill in OFF  " + pro.data3[2, z];  pro.di++;
                        }
                    }
                    if ((byAux2 == 0xf))
                    {
                        switch (byAux)
                        {
                            case 0x0:
                                pro.data4[pro.di] = " //Start Repeat";  pro.di++;
                                break;
                            case 0x1:
                                pro.data4[pro.di] = " //Repeat";  pro.di++;
                                break;
                            case 0x8:
                                pro.data4[pro.di] = " //Repeat 1";  pro.di++;
                                break;
                            case 0x9:
                                pro.data4[pro.di] = " //Repeat 2";  pro.di++;
                                break;
                            case 0xA:
                                pro.data4[pro.di] = " //Repeat 3";  pro.di++;
                                break;
                            case 0xB:
                                pro.data4[pro.di] = " //Repeat 4";  pro.di++;
                                break;
                            case 0xC:
                                pro.data4[pro.di] = " //Repeat 5";  pro.di++;
                                break;
                            case 0xD:
                                pro.data4[pro.di] = " //Repeat 6";  pro.di++;
                                break;
                            case 0xE:
                                pro.data4[pro.di] = " //Repeat 7";  pro.di++;
                                break;
                            case 0xF:
                                pro.data4[pro.di] = " //Repeat 8";  pro.di++;
                                break;
                        }
                    }


                    if ((byAux2 >= 0x1) && (byAux2 <= 0xC))
                    {
                        if (pro.data3[0, z] != 0xF1)
                        {
                            //Bass
                            switch (byAux2)
                            {
                                case 0x1:
                                    co = 36;
                                    co0 = 60;
                                    break;
                                case 0x2:
                                    co = 37;
                                    co0 = 61;
                                    break;
                                case 0x3:
                                    co = 38;
                                    co0 = 62;
                                    break;
                                case 0x4:
                                    co = 39;
                                    co0 = 63;
                                    break;
                                case 0x5:
                                    co = 40;
                                    co0 = 64;
                                    break;
                                case 0x6:
                                    co = 41;
                                    co0 = 65;
                                    break;
                                case 0x7:
                                    co = 42;
                                    co0 = 54;
                                    break;
                                case 0x8:
                                    co = 43;
                                    co0 = 55;
                                    break;
                                case 0x9:
                                    co = 44;
                                    co0 = 56;
                                    break;
                                case 0xA:
                                    co = 45;
                                    co0 = 57;
                                    break;
                                case 0xB:
                                    co = 46;
                                    co0 = 58;
                                    break;
                                case 0xC:
                                    co = 47;
                                    co0 = 59;
                                    break;
                            }
                            //code
                            switch (byAux)
                            {
                                case 0x0:
                                    co1 = co0 + 4;
                                    co2 = co0 + 7;
                                    co3 = 0;
                                    co4 = co + 7;
                                    break;
                                case 0x1:
                                    co1 = co0 + 3;
                                    co2 = co0 + 7;
                                    co3 = 0;
                                    co4 = co + 7;
                                    break;
                                case 0x2:
                                    co1 = co0 + 4;
                                    co2 = co0 + 7;
                                    co3 = co0 + 10;
                                    co4 = co + 7;
                                    break;
                                case 0x3:
                                    co1 = co0 + 3;
                                    co2 = co0 + 7;
                                    co3 = co0 + 10;
                                    co4 = co + 7;
                                    break;
                                case 0x4:
                                    co1 = co0 + 4;
                                    co2 = co0 + 7;
                                    co3 = co0 + 11;
                                    co4 = co + 7;
                                    break;
                                case 0x5:
                                    co1 = co0 + 4;
                                    co2 = co0 + 7;
                                    co3 = co0 + 9;
                                    co4 = co + 7;
                                    break;
                                case 0x6:
                                    co1 = co0 + 3;
                                    co2 = co0 + 6;
                                    co3 = co0 + 10;
                                    co4 = co + 6;
                                    break;
                                case 0x7:
                                    co1 = co0 + 5;
                                    co2 = co0 + 7;
                                    co3 = 0;
                                    co4 = co + 7;
                                    break;
                                case 0x8:
                                    co1 = co0 + 3;
                                    co2 = co0 + 6;
                                    co3 = co0 + 9;
                                    co4 = co + 6;
                                    break;
                                case 0x9:
                                    co1 = co0 + 4;
                                    co2 = co0 + 8;
                                    co3 = 0;
                                    co4 = co + 8;
                                    break;
                                case 0xA:
                                    co1 = co0 + 3;
                                    co2 = co0 + 7;
                                    co3 = co0 + 9;
                                    co4 = co + 7;
                                    break;
                                case 0xB:
                                    co1 = co0 + 4;
                                    co2 = co0 + 6;
                                    co3 = 0;
                                    co4 = co + 6;
                                    break;
                                case 0xC:
                                    co1 = co0 + 2;
                                    co2 = co0 + 4;
                                    co3 = co0 + 7;
                                    co4 = co + 7;
                                    break;
                                case 0xD:
                                    co1 = co0 + 2;
                                    co2 = co0 + 7;
                                    co3 = co0 + 10;
                                    co4 = co + 7;
                                    break;
                                case 0xE:
                                    co0 = 0;
                                    co1 = 0;
                                    co2 = 0;
                                    co3 = 0;
                                    co4 = co;
                                    break;
                            }
                            if (co0 >= 66) co0 -= 12;
                            if (co1 >= 66) co1 -= 12;
                            if (co2 >= 66) co2 -= 12;
                            if (co3 >= 66) co3 -= 12;
                            if (co4 >= 48) co4 -= 12;
                        }
                        else
                        {
                            co = 0;
                            co0 = 0;
                            co1 = 0;
                            co2 = 0;
                            co3 = 0;
                            co4 = 0;
                        }

                        // if (co != 0) { pro.data4[pro.di] = "3," + y + ", 4, " + co + pro.Bass[1] + t2;  pro.di++;
                        // if (co0 != 0) { pro.data4[pro.di] = "3," + y + ", 5, " + co0 + pro.Acc[1] + t2;  pro.di++;
                        // if (co1 != 0) { pro.data4[pro.di] = "3," + y + ", 5, " + co1 + pro.Acc[1] + t2;  pro.di++;
                        // if (co2 != 0) { pro.data4[pro.di] = "3," + y + ", 5, " + co2 + pro.Acc[1] + t2;  pro.di++;
                        // if (co3 != 0) { pro.data4[pro.di] = "3," + y + ", 5, " + co3 + pro.Acc[1] + t2;  pro.di++;
                    }
                    // End
                    if (pro.data3[0, z] == 0xF0)
                    {
                        //pro.data4[pro.di] = " //End";  pro.di++;
                    }
                    z++;
                    if (pro.data3[2, z] == pro.data3[2, z - 1]) y--;
                    else p = 0;
                }



                if (fil == 0 && p == 0) switch (rh)
                    {
                        case 1:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 36) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 24) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 72) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 120) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 168) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 2:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 36) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 24) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 72) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 120) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 168) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 3:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 12) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 30) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 30) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 30) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 30) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 48) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 66) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 66) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 66) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 66) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 78) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 78) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 78) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 78) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 108) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 126) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 126) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 126) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 126) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 144) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 162) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 162) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 162) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 162) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 174) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 174) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 174) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 174) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            break;
                        case 4:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 42) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 66) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 78) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 84) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 138) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 162) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 174) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 180) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 0) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 0) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 0) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 0) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 12) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 30) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 30) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 30) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 30) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 48) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 96) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 108) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 126) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 126) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 126) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 126) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 144) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 5:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 24) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 72) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 120) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 168) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 6:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 40) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + (pro.Bass[2] + 2);  pro.di++; }
                            if (rhT == 40) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + (pro.Bass[2] + 2);  pro.di++; }
                            if (rhT == 40) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + (pro.Bass[2] + 2);  pro.di++; }
                            if (rhT == 40) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + (pro.Bass[2] + 2);  pro.di++; }

                            if (rhT == 72) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 120) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 160) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + (pro.Bass[2] + 2);  pro.di++; }
                            if (rhT == 160) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + (pro.Bass[2] + 2);  pro.di++; }
                            if (rhT == 160) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + (pro.Bass[2] + 2);  pro.di++; }
                            if (rhT == 160) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + (pro.Bass[2] + 2);  pro.di++; }
                            break;
                        case 7:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 36) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 12) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 30) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 30) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 30) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 30) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 42) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 42) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 42) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 42) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 60) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 78) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 78) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 78) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 78) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 90) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 90) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 90) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 90) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 108) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 126) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 126) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 126) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 126) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 138) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 138) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 138) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 138) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 156) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 174) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 174) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 174) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 174) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 186) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 186) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 186) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            if (rhT == 186) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2];  pro.di++; }
                            break;
                        case 8:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2]; pro.di++; }
                            if (rhT == 24) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2]; pro.di++; }
                            if (rhT == 42) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 66) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2]; pro.di++; }
                            if (rhT == 78) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 84) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2]; pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2]; pro.di++; }
                            if (rhT == 120) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2]; pro.di++; }
                            if (rhT == 138) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 162) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2]; pro.di++; }
                            if (rhT == 174) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 180) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2]; pro.di++; }

                            if (rhT == 24) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 72) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 120) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 168) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 9:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 36) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 0) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 0) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 0) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 0) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 24) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 60) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 84) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 96) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 120) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 156) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 180) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 10:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 12) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 36) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 36) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 36) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 36) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 60) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 84) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 108) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 132) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 156) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 180) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 11:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 0) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 0) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 0) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 0) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 24) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 48) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 72) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 84) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 96) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 120) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 144) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 168) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 180) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 12:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 12) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 12) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 36) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 36) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 36) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 36) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 60) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 60) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 84) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 84) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 108) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 108) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 132) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 156) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 156) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 180) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 13:
                        case 14:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 40) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + (pro.Bass[2] + 2);  pro.di++; }
                            if (rhT == 48) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 136) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + (pro.Bass[2] + 2);  pro.di++; }
                            if (rhT == 144) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 8) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 8) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 8) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 8) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 16) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 16) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 16) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 16) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 24) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 56) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 56) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 56) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 56) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 64) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 64) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 64) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 64) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 80) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 80) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 80) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 80) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 88) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 88) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 88) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 88) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 104) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 104) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 104) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 104) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 112) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 112) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 112) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 112) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 120) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2]; pro.di++; }
                            if (rhT == 120) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2]; pro.di++; }
                            if (rhT == 120) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2]; pro.di++; }
                            if (rhT == 120) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2]; pro.di++; }

                            if (rhT == 152) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 152) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 152) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 152) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 160) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 160) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 160) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 160) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 176) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 176) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 176) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 176) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            if (rhT == 184) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 184) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 184) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }
                            if (rhT == 184) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Bass[2]; pro.di++; }

                            break;
                        case 15:
                        case 16:
                            if (rhT == 0) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 24) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 24) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 48) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 48) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 96) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 120) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 120) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                    }
                if (fil == 1 && p == 0)
                {
                    switch (rh)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 11:
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 96) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 4:
                        case 8:
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 186) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Bass[2];  pro.di++; }

                            if (rhT == 96) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 5:
                        case 6:
                        case 13:
                        case 14:
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 184) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + (pro.Bass[2] + 2);  pro.di++; }

                            if (rhT == 96) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 7:
                        case 9:
                        case 10:
                        case 12:
                            if (rhT == 96) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 168) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 180) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 96) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 96) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                        case 15:
                        case 16:
                            if (rhT == 72) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 132) if (co != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[2] + "," + co4 + "," + pro.Bass[1] + "," + pro.Acc[2];  pro.di++; }

                            if (rhT == 72) if (co0 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co0 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co1 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co1 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co2 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co2 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            if (rhT == 72) if (co3 != 0) { pro.data4[pro.di] = "3," + y + "," + pro.MTrack[3] + "," + co3 + "," + pro.Acc[1] + "," + pro.Acc[2];  pro.di++; }
                            break;
                    }
                    if (rh <= 14 && rhT == 187) fil = 0;
                    if (rh >= 15 && rhT == 139) fil = 0;
                }
                if (pro.data3[2, z] != pro.data3[2, z - 1]) rhT++;
                if (rh <= 14 && rhT >= 192) rhT = 0;
                if (rh >= 15 && rhT >= 144) rhT = 0;
            }
        }

    }
}
