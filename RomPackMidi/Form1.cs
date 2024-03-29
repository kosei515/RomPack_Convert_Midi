﻿using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;


namespace RomPackMidi
{
    public partial class Form1 : Form
    {
 
        public int[,] data1 = new int[3, 100000];
        public int[,,] data2 = new int[40, 3, 10000];
        public int[,] data3 = new int[3, 1000000];
        public string[] data4 = new string[10000000];
        public int line0, p = 0, b, di = 0, da = 0, rn = 0, num = 0, log = 0, maxL = 0;
        public string FileName = "RomMidi";
        string MakeMidi = ".\\midi4.exe";

        public string MIdiOut = "..\\..\\..\\..\\";

        public int[] Piano = new int[5];
        public int[] Harpsichord = new int[5];
        public int[] Organ = new int[5];
        public int[] Violin = new int[5];
        public int[] Flute = new int[5];
        public int[] Clarinet = new int[5];
        public int[] Trumpet = new int[5];
        public int[] Celesta = new int[5];

        public int[] Bass = new int[3];
        public int[] Acc = new int[3];
        public int[] Rhyrhm = new int[2];

        public int[] MTrack = new int[5] {3, 4, 5, 6, 2}; // M1 M2 CodeBass CodeAcc CodeM
        public int CodeM = 1; // CodeM On1 Off0
        public int CodeV = 0; // CodeM Vol
        public int Rev = 30; // Reverb

        public string OpFile;
        public byte[,] SongList = new byte[40,100000];
        public int[] SongLen = new int[40];
        public int[] SongLen2 = new int[40];



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.MIdiOut = ConfigurationManager.AppSettings["MidiOut"];
            this.Piano[0] = int.Parse(ConfigurationManager.AppSettings["Piano0"]);
            this.Piano[1] = int.Parse(ConfigurationManager.AppSettings["Piano1"]);
            this.Piano[2] = int.Parse(ConfigurationManager.AppSettings["Piano2"]);
            this.Piano[3] = int.Parse(ConfigurationManager.AppSettings["Piano3"]);
            this.Piano[4] = int.Parse(ConfigurationManager.AppSettings["Piano4"]);
            this.Harpsichord[0] = int.Parse(ConfigurationManager.AppSettings["Harpsichord0"]);
            this.Harpsichord[1] = int.Parse(ConfigurationManager.AppSettings["Harpsichord1"]);
            this.Harpsichord[2] = int.Parse(ConfigurationManager.AppSettings["Harpsichord2"]);
            this.Harpsichord[3] = int.Parse(ConfigurationManager.AppSettings["Harpsichord3"]);
            this.Harpsichord[4] = int.Parse(ConfigurationManager.AppSettings["Harpsichord4"]);
            this.Organ[0] = int.Parse(ConfigurationManager.AppSettings["Organ0"]);
            this.Organ[1] = int.Parse(ConfigurationManager.AppSettings["Organ1"]);
            this.Organ[2] = int.Parse(ConfigurationManager.AppSettings["Organ2"]);
            this.Organ[3] = int.Parse(ConfigurationManager.AppSettings["Organ3"]);
            this.Organ[4] = int.Parse(ConfigurationManager.AppSettings["Organ4"]);
            this.Violin[0] = int.Parse(ConfigurationManager.AppSettings["Violin0"]);
            this.Violin[1] = int.Parse(ConfigurationManager.AppSettings["Violin1"]);
            this.Violin[2] = int.Parse(ConfigurationManager.AppSettings["Violin2"]);
            this.Violin[3] = int.Parse(ConfigurationManager.AppSettings["Violin3"]);
            this.Violin[4] = int.Parse(ConfigurationManager.AppSettings["Violin4"]);
            this.Flute[0] = int.Parse(ConfigurationManager.AppSettings["Flute0"]);
            this.Flute[1] = int.Parse(ConfigurationManager.AppSettings["Flute1"]);
            this.Flute[2] = int.Parse(ConfigurationManager.AppSettings["Flute2"]);
            this.Flute[3] = int.Parse(ConfigurationManager.AppSettings["Flute3"]);
            this.Flute[4] = int.Parse(ConfigurationManager.AppSettings["Flute4"]);
            this.Clarinet[0] = int.Parse(ConfigurationManager.AppSettings["Clarinet0"]);
            this.Clarinet[1] = int.Parse(ConfigurationManager.AppSettings["Clarinet1"]);
            this.Clarinet[2] = int.Parse(ConfigurationManager.AppSettings["Clarinet2"]);
            this.Clarinet[3] = int.Parse(ConfigurationManager.AppSettings["Clarinet3"]);
            this.Clarinet[4] = int.Parse(ConfigurationManager.AppSettings["Clarinet4"]);
            this.Trumpet[0] = int.Parse(ConfigurationManager.AppSettings["Trumpet0"]);
            this.Trumpet[1] = int.Parse(ConfigurationManager.AppSettings["Trumpet1"]);
            this.Trumpet[2] = int.Parse(ConfigurationManager.AppSettings["Trumpet2"]);
            this.Trumpet[3] = int.Parse(ConfigurationManager.AppSettings["Trumpet3"]);
            this.Trumpet[4] = int.Parse(ConfigurationManager.AppSettings["Trumpet4"]);
            this.Celesta[0] = int.Parse(ConfigurationManager.AppSettings["Celesta0"]);
            this.Celesta[1] = int.Parse(ConfigurationManager.AppSettings["Celesta1"]);
            this.Celesta[2] = int.Parse(ConfigurationManager.AppSettings["Celesta2"]);
            this.Celesta[3] = int.Parse(ConfigurationManager.AppSettings["Celesta3"]);
            this.Celesta[4] = int.Parse(ConfigurationManager.AppSettings["Celesta4"]);
            this.Bass[0] = int.Parse(ConfigurationManager.AppSettings["Bass0"]);
            this.Bass[1] = int.Parse(ConfigurationManager.AppSettings["Bass1"]);
            this.Bass[2] = int.Parse(ConfigurationManager.AppSettings["Bass2"]);
            this.Acc[0] = int.Parse(ConfigurationManager.AppSettings["Acc0"]);
            this.Acc[1] = int.Parse(ConfigurationManager.AppSettings["Acc1"]);
            this.Acc[2] = int.Parse(ConfigurationManager.AppSettings["Acc2"]);
            this.Rhyrhm[0] = int.Parse(ConfigurationManager.AppSettings["Rhyrhm0"]);
            this.Rhyrhm[1] = int.Parse(ConfigurationManager.AppSettings["Rhyrhm1"]);

            textBox3.Text = FileName;


            button6.Enabled = false;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox6.Checked = true;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 || (!(string.IsNullOrEmpty(textBox1.Text)) && comboBox1.SelectedIndex == -1))
            {
                //Run
                textBox2.Text = "";
                ConvertSys ConSys = new ConvertSys(this);
                this.DataCon();
                p = 0;
                di = 0;
                maxL = 0;
                ConSys.SetCon();
                if (checkBox1.Checked == true) ConSys.NoteCon();
                if (checkBox2.Checked == true) ConSys.CodeCon();
                da = di;
                for (int r = 0; r < da; r++) textBox2.Text += (data4[r] + "\r\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                //Save
                rn = 1;
                SaveF();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace("\r\n", "");
            textBox1.Text = textBox1.Text.Replace(" ", "");

            if (textBox1.Text != "")
            {
                int One0 = textBox1.TextLength;

                int Len1 = 0, se = 0;
                char Len2 = ' ', Len3 = ' ', Len22 = ' ', Len33 = ' ';
                if (checkBox1.Checked == false) se = 4;

                for (int i = 0; i < One0; i++)
                {
                    char[] Len0 = textBox1.Text.ToCharArray();
                    if (Len1 == 6) Len2 = Len0[i - 6];
                    else if (Len1 == 1) Len3 = Len0[i];
                    else if (Len1 == 4) Len22 = Len0[i];
                    else if (Len1 == 5) Len33 = Len0[i];

                    if (se == 1 || se == 3)
                    {
                        se++;
                        textBox1.Text = textBox1.Text.Insert(i - 1, "\r\n");
                        One0 += 2;
                        i += 2;
                    }
                    if (Len1 >= 6 && (se == 0 || se == 2))
                    {
                        textBox1.Text = textBox1.Text.Insert(i, "\r\n");
                        One0 += 2;
                        i += 2;
                        if (Len2 == 'F' && Len3 == '0') se++;
                        Len1 = 0;
                    }
                    if (Len1 >= 4 && se == 4)
                    {
                        textBox1.Text = textBox1.Text.Insert(i, "\r\n");
                        One0 += 2;
                        i += 2;
                        Len1 = 0;
                    }
                    Len1++;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 || (!(string.IsNullOrEmpty(textBox1.Text)) && comboBox1.SelectedIndex == -1))
            {
                if (checkBox5.Checked == false)
                {
                    textBox1.Text = textBox1.Text.Replace("\r\n", "");
                    textBox1.Text = textBox1.Text.Replace(" ", "");

                    if (textBox1.Text != "")
                    {
                        int One0 = textBox1.TextLength;

                        int Len1 = 0, se = 0;
                        char Len2 = ' ', Len3 = ' ';
                        if (checkBox1.Checked == false) se = 4;

                        for (int i = 0; i < One0; i++)
                        {
                            char[] Len0 = textBox1.Text.ToCharArray();
                            if (Len1 == 6) Len2 = Len0[i - 6];
                            else if (Len1 == 1) Len3 = Len0[i];

                            if (se == 1 || se == 3)
                            {
                                se++;
                                textBox1.Text = textBox1.Text.Insert(i - 1, "\r\n");
                                One0 += 2;
                                i += 2;
                            }
                            if (Len1 >= 6 && (se == 0 || se == 2))
                            {
                                textBox1.Text = textBox1.Text.Insert(i, "\r\n");
                                One0 += 2;
                                i += 2;
                                if (Len2 == 'F' && Len3 == '0') se++;
                                Len1 = 0;
                            }
                            if (Len1 >= 4 && se == 4)
                            {
                                textBox1.Text = textBox1.Text.Insert(i, "\r\n");
                                One0 += 2;
                                i += 2;
                                Len1 = 0;
                            }
                            Len1++;
                        }
                    }
                    textBox2.Text = "";

                }

                ConvertSys ConSys = new ConvertSys(this);
                this.DataCon();
                p = 0;
                di = 0;
                maxL = 0;
                ConSys.SetCon();
                if (checkBox1.Checked == true) ConSys.NoteCon();
                if (checkBox2.Checked == true) ConSys.CodeCon();
                da = di;
                SaveF();
            }
        }


        public void DataCon()
        {
            if (checkBox5.Checked == false)
            {
                string[] sWork2 = new string[3];
                var sr = new StringReader(textBox1.Text);

                line0 = textBox1.Lines.Length;

                for (int i = 0; i < line0; i++)
                {
                    string sWork = sr.ReadLine();

                    if (sWork == null) continue;
                    if (sWork == "")
                    {
                        line0--;
                        i--;
                        continue;
                    }
                    sWork = sWork.Replace(" ", "");
                    int len = sWork.Length;
                    if (len < 4) continue;
                    sWork2[0] = sWork.Substring(0, 2);
                    sWork2[1] = sWork.Substring(2, 2);
                    if (len >= 5) sWork2[2] = sWork.Substring(4, 2);

                    for (int j = 0; j < 3; j++)
                    {
                        var hex1 = Convert.ToInt32(sWork2[j], 16); // 16進数
                        data1[j, i] = hex1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < SongLen2[b - 1]; i++) for (int j = 0; j < 3; j++) data1[j, i] = data2[b - 1, j, i];
                line0 = SongLen2[b - 1];
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.pro = this;
            form2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["MidiOut"].Value = this.MIdiOut;
            config.AppSettings.Settings["Piano0"].Value = (this.Piano[0]).ToString();
            config.AppSettings.Settings["Piano1"].Value = (this.Piano[1]).ToString();
            config.AppSettings.Settings["Piano2"].Value = (this.Piano[2]).ToString();
            config.AppSettings.Settings["Piano3"].Value = (this.Piano[3]).ToString();
            config.AppSettings.Settings["Piano4"].Value = (this.Piano[4]).ToString();
            config.AppSettings.Settings["Harpsichord0"].Value = (this.Harpsichord[0]).ToString();
            config.AppSettings.Settings["Harpsichord1"].Value = (this.Harpsichord[1]).ToString();
            config.AppSettings.Settings["Harpsichord2"].Value = (this.Harpsichord[2]).ToString();
            config.AppSettings.Settings["Harpsichord3"].Value = (this.Harpsichord[3]).ToString();
            config.AppSettings.Settings["Harpsichord4"].Value = (this.Harpsichord[4]).ToString();
            config.AppSettings.Settings["Organ0"].Value = (this.Organ[0]).ToString();
            config.AppSettings.Settings["Organ1"].Value = (this.Organ[1]).ToString();
            config.AppSettings.Settings["Organ2"].Value = (this.Organ[2]).ToString();
            config.AppSettings.Settings["Organ3"].Value = (this.Organ[3]).ToString();
            config.AppSettings.Settings["Organ4"].Value = (this.Organ[4]).ToString();
            config.AppSettings.Settings["Violin0"].Value = (this.Violin[0]).ToString();
            config.AppSettings.Settings["Violin1"].Value = (this.Violin[1]).ToString();
            config.AppSettings.Settings["Violin2"].Value = (this.Violin[2]).ToString();
            config.AppSettings.Settings["Violin3"].Value = (this.Violin[3]).ToString();
            config.AppSettings.Settings["Violin4"].Value = (this.Violin[4]).ToString();
            config.AppSettings.Settings["Flute0"].Value = (this.Flute[0]).ToString();
            config.AppSettings.Settings["Flute1"].Value = (this.Flute[1]).ToString();
            config.AppSettings.Settings["Flute2"].Value = (this.Flute[2]).ToString();
            config.AppSettings.Settings["Flute3"].Value = (this.Flute[3]).ToString();
            config.AppSettings.Settings["Flute4"].Value = (this.Flute[4]).ToString();
            config.AppSettings.Settings["Clarinet0"].Value = (this.Clarinet[0]).ToString();
            config.AppSettings.Settings["Clarinet1"].Value = (this.Clarinet[1]).ToString();
            config.AppSettings.Settings["Clarinet2"].Value = (this.Clarinet[2]).ToString();
            config.AppSettings.Settings["Clarinet3"].Value = (this.Clarinet[3]).ToString();
            config.AppSettings.Settings["Clarinet4"].Value = (this.Clarinet[4]).ToString();
            config.AppSettings.Settings["Trumpet0"].Value = (this.Trumpet[0]).ToString();
            config.AppSettings.Settings["Trumpet1"].Value = (this.Trumpet[1]).ToString();
            config.AppSettings.Settings["Trumpet2"].Value = (this.Trumpet[2]).ToString();
            config.AppSettings.Settings["Trumpet3"].Value = (this.Trumpet[3]).ToString();
            config.AppSettings.Settings["Trumpet4"].Value = (this.Trumpet[4]).ToString();
            config.AppSettings.Settings["Celesta0"].Value = (this.Celesta[0]).ToString();
            config.AppSettings.Settings["Celesta1"].Value = (this.Celesta[1]).ToString();
            config.AppSettings.Settings["Celesta2"].Value = (this.Celesta[2]).ToString();
            config.AppSettings.Settings["Celesta3"].Value = (this.Celesta[3]).ToString();
            config.AppSettings.Settings["Celesta4"].Value = (this.Celesta[4]).ToString();
            config.AppSettings.Settings["Bass0"].Value = (this.Bass[0]).ToString();
            config.AppSettings.Settings["Bass1"].Value = (this.Bass[1]).ToString();
            config.AppSettings.Settings["Bass2"].Value = (this.Bass[2]).ToString();
            config.AppSettings.Settings["Acc0"].Value = (this.Acc[0]).ToString();
            config.AppSettings.Settings["Acc1"].Value = (this.Acc[1]).ToString();
            config.AppSettings.Settings["Acc2"].Value = (this.Acc[2]).ToString();
            config.AppSettings.Settings["Rhyrhm0"].Value = (this.Rhyrhm[0]).ToString();
            config.AppSettings.Settings["Rhyrhm1"].Value = (this.Rhyrhm[1]).ToString();

            config.Save();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true) Rev = 30;
            else Rev = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!(checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == true)) button6.Enabled = false;
            else button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (num >= 1)
            {
                for (int u = 0; u < num; u++)
                {
                    log = 1;
                    comboBox1.SelectedIndex = u;
                    b = Convert.ToInt32(comboBox1.SelectedItem);
                    if (b <= 9) textBox3.Text = (Path.GetFileNameWithoutExtension(OpFile)) + "_0" + b;
                    if (b >= 10) textBox3.Text = (Path.GetFileNameWithoutExtension(OpFile)) + "_" + b;

                    ConvertSys ConSys = new ConvertSys(this);
                    this.DataCon();
                    p = 0;
                    di = 0;
                    maxL = 0;
                    ConSys.SetCon();
                    if (checkBox1.Checked == true) ConSys.NoteCon();
                    if (checkBox2.Checked == true) ConSys.CodeCon();
                    da = di;
                    SaveF();
                }
                MessageBox.Show("All Saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!(checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == true)) button6.Enabled = false;
            else button6.Enabled = true;
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            //ダイアログのタイトルを指定する
            ofDialog.Title = "Open File (.bin Only)";
            ofDialog.Filter = "Binary File|*.bin|All Files|*.*";
            //ダイアログを表示する
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                OpFile = ofDialog.FileName;
                label1.Text = Path.GetFileName(OpFile);
                comboBox1.Items.Clear();
                BinRead br = new BinRead(this);
                br.ReadBin(OpFile);
            }
            // オブジェクトを破棄する
            ofDialog.Dispose();

            //textBox1.Text = data2[0,1,5].ToString("X");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(comboBox1.SelectedItem);

            if (checkBox5.Checked == false)
            {
                textBox1.Text = "";

                for (int n = 0; n < SongLen[b - 1]; n++)
                {
                    string d0 = SongList[b - 1, n].ToString("X");
                    if (d0 == "0") d0 = "00";
                    if (d0 == "1") d0 = "01";
                    if (d0 == "2") d0 = "02";
                    if (d0 == "3") d0 = "03";
                    if (d0 == "4") d0 = "04";
                    if (d0 == "5") d0 = "05";
                    if (d0 == "6") d0 = "06";
                    if (d0 == "7") d0 = "07";
                    if (d0 == "8") d0 = "08";
                    if (d0 == "9") d0 = "09";
                    if (d0 == "A") d0 = "0A";
                    if (d0 == "B") d0 = "0B";
                    if (d0 == "C") d0 = "0C";
                    if (d0 == "D") d0 = "0D";
                    if (d0 == "E") d0 = "0E";
                    if (d0 == "F") d0 = "0F";
                    textBox1.Text += d0;
                }
            }
            if (checkBox4.Checked == true)
            {
                if (b <= 9) textBox3.Text = (Path.GetFileNameWithoutExtension(OpFile)) + "_0" + b;
                if (b >= 10) textBox3.Text = (Path.GetFileNameWithoutExtension(OpFile)) + "_" + b;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (!(checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == true)) button6.Enabled = false;
            else button6.Enabled = true;
        }

        public void SaveF()
        {

            FileName = textBox3.Text;
            string file = ".\\RomMidi.txt";
            StreamWriter sw = new StreamWriter(file, false, Encoding.GetEncoding("utf-8"));
            for (int r = 0; r < da; r++)
            {
                if (checkBox5.Checked == false && rn == 0) textBox2.Text += (data4[r] + "\r\n");
                sw.WriteLine(data4[r]);
            }

            sw.Close();
            rn = 0;
            System.Diagnostics.Process oc = System.Diagnostics.Process.Start(MakeMidi);
            oc.WaitForExit();

            if (log == 0)
            {
                System.IO.File.Delete(MIdiOut + FileName + ".mid");
                System.IO.File.Move(".\\RomMidi.mid", MIdiOut + FileName + ".mid");

            }
            else
            {
                if (!System.IO.Directory.Exists(MIdiOut + "AllMidiOut")) Directory.CreateDirectory(MIdiOut + "AllMidiOut");
                System.IO.File.Delete(MIdiOut + "AllMidiOut\\" + FileName + ".mid");
                System.IO.File.Move(".\\RomMidi.mid", MIdiOut + "AllMidiOut\\" + FileName + ".mid");
            }
            if (log == 0) MessageBox.Show("Saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.None);

            if (checkBox3.Checked == true) Process.Start(MIdiOut + FileName + ".mid");

        }



    }




}

