using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RomPackMidi
{
    public partial class Form2 : Form
    {
        public Form1 pro = new Form1();

 
        public Form2(Form1 pro2)
        {
            pro = pro2;
        }
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = pro.MIdiOut;

            dataGridView1.Rows.Add("Piano", pro.Piano[0], pro.Piano[1], pro.Piano[2], pro.Piano[3], pro.Piano[4]);
            dataGridView1.Rows.Add("Harpsichord", pro.Harpsichord[0], pro.Harpsichord[1], pro.Harpsichord[2], pro.Harpsichord[3], pro.Harpsichord[4]);
            dataGridView1.Rows.Add("Organ", pro.Organ[0], pro.Organ[1], pro.Organ[2], pro.Organ[3], pro.Organ[4]);
            dataGridView1.Rows.Add("Violin", pro.Violin[0], pro.Violin[1], pro.Violin[2], pro.Violin[3], pro.Violin[4]);
            dataGridView1.Rows.Add("Flute", pro.Flute[0], pro.Flute[1], pro.Flute[2], pro.Flute[3], pro.Flute[4]);
            dataGridView1.Rows.Add("Clarinet", pro.Clarinet[0], pro.Clarinet[1], pro.Clarinet[2], pro.Clarinet[3], pro.Clarinet[4]);
            dataGridView1.Rows.Add("Trumpet", pro.Trumpet[0], pro.Trumpet[1], pro.Trumpet[2], pro.Trumpet[3], pro.Trumpet[4]);
            dataGridView1.Rows.Add("Celesta", pro.Celesta[0], pro.Celesta[1], pro.Celesta[2], pro.Celesta[3], pro.Celesta[4]);
            dataGridView2.Rows.Add("Bass", pro.Bass[0], pro.Bass[1], pro.Bass[2], pro.Rhyrhm[0]);
            dataGridView2.Rows.Add("Acc", pro.Acc[0], pro.Acc[1], pro.Acc[2], pro.Rhyrhm[1]);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //表示されているコントロールがDataGridViewTextBoxEditingControlか調べる
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                DataGridView dgv = (DataGridView)sender;

                //編集のために表示されているコントロールを取得
                DataGridViewTextBoxEditingControl tb =
                    (DataGridViewTextBoxEditingControl)e.Control;

                //イベントハンドラを削除
                tb.KeyPress -=
                    new KeyPressEventHandler(dataGridViewTextBox_KeyPress);

                //該当する列か調べる
                if (dgv.CurrentCell.OwningColumn.Name == "Column1")
                {
                    //KeyPressイベントハンドラを追加
                    tb.KeyPress +=
                        new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
                }
            }
        }
        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数字しか入力できないようにする
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pro.MIdiOut = textBox1.Text;

            string A;
            pro.Piano[0] = Convert.ToInt32(dataGridView1[1, 0].Value.ToString());
            pro.Piano[1] = Convert.ToInt32(dataGridView1[2, 0].Value.ToString());
            pro.Piano[2] = Convert.ToInt32(dataGridView1[3, 0].Value.ToString());
            pro.Piano[3] = Convert.ToInt32(dataGridView1[4, 0].Value.ToString());
            A = dataGridView1[5, 0].Value.ToString();
            if (A == "True") pro.Piano[4] = 1;
            else pro.Piano[4] = 0;
            pro.Harpsichord[0] = Convert.ToInt32(dataGridView1[1, 1].Value.ToString());
            pro.Harpsichord[1] = Convert.ToInt32(dataGridView1[2, 1].Value.ToString());
            pro.Harpsichord[2] = Convert.ToInt32(dataGridView1[3, 1].Value.ToString());
            pro.Harpsichord[3] = Convert.ToInt32(dataGridView1[4, 1].Value.ToString());
            A = dataGridView1[5, 1].Value.ToString();
            if (A == "True") pro.Harpsichord[4] = 1;
            else pro.Harpsichord[4] = 0;
            pro.Organ[0] = Convert.ToInt32(dataGridView1[1, 2].Value.ToString());
            pro.Organ[1] = Convert.ToInt32(dataGridView1[2, 2].Value.ToString());
            pro.Organ[2] = Convert.ToInt32(dataGridView1[3, 2].Value.ToString());
            pro.Organ[3] = Convert.ToInt32(dataGridView1[4, 2].Value.ToString());
            A = dataGridView1[5, 2].Value.ToString();
            if (A == "True") pro.Organ[4] = 1;
            else pro.Organ[4] = 0;
            pro.Violin[0] = Convert.ToInt32(dataGridView1[1, 3].Value.ToString());
            pro.Violin[1] = Convert.ToInt32(dataGridView1[2, 3].Value.ToString());
            pro.Violin[2] = Convert.ToInt32(dataGridView1[3, 3].Value.ToString());
            pro.Violin[3] = Convert.ToInt32(dataGridView1[4, 3].Value.ToString());
            A = dataGridView1[5, 3].Value.ToString();
            if (A == "True") pro.Violin[4] = 1;
            else pro.Violin[4] = 0;
            pro.Flute[0] = Convert.ToInt32(dataGridView1[1, 4].Value.ToString());
            pro.Flute[1] = Convert.ToInt32(dataGridView1[2, 4].Value.ToString());
            pro.Flute[2] = Convert.ToInt32(dataGridView1[3, 4].Value.ToString());
            pro.Flute[3] = Convert.ToInt32(dataGridView1[4, 4].Value.ToString());
            A = dataGridView1[5, 4].Value.ToString();
            if (A == "True") pro.Flute[4] = 1;
            else pro.Flute[4] = 0;
            pro.Clarinet[0] = Convert.ToInt32(dataGridView1[1, 5].Value.ToString());
            pro.Clarinet[1] = Convert.ToInt32(dataGridView1[2, 5].Value.ToString());
            pro.Clarinet[2] = Convert.ToInt32(dataGridView1[3, 5].Value.ToString());
            pro.Clarinet[3] = Convert.ToInt32(dataGridView1[4, 5].Value.ToString());
            A = dataGridView1[5, 5].Value.ToString();
            if (A == "True") pro.Piano[4] = 1;
            else pro.Piano[4] = 0;
            pro.Trumpet[0] = Convert.ToInt32(dataGridView1[1, 6].Value.ToString());
            pro.Trumpet[1] = Convert.ToInt32(dataGridView1[2, 6].Value.ToString());
            pro.Trumpet[2] = Convert.ToInt32(dataGridView1[3, 6].Value.ToString());
            pro.Trumpet[3] = Convert.ToInt32(dataGridView1[4, 6].Value.ToString());
            A = dataGridView1[5, 6].Value.ToString();
            if (A == "True") pro.Clarinet[4] = 1;
            else pro.Clarinet[4] = 0;
            pro.Celesta[0] = Convert.ToInt32(dataGridView1[1, 7].Value.ToString());
            pro.Celesta[1] = Convert.ToInt32(dataGridView1[2, 7].Value.ToString());
            pro.Celesta[2] = Convert.ToInt32(dataGridView1[3, 7].Value.ToString());
            pro.Celesta[3] = Convert.ToInt32(dataGridView1[4, 7].Value.ToString());
            A = dataGridView1[5, 7].Value.ToString();
            if (A == "True") pro.Celesta[4] = 1;
            else pro.Celesta[4] = 0;
            pro.Bass[0] = Convert.ToInt32(dataGridView2[1, 0].Value.ToString());
            pro.Bass[1] = Convert.ToInt32(dataGridView2[2, 0].Value.ToString());
            pro.Bass[2] = Convert.ToInt32(dataGridView2[3, 0].Value.ToString());
            pro.Rhyrhm[0] = Convert.ToInt32(dataGridView2[4, 0].Value.ToString());
            pro.Acc[0] = Convert.ToInt32(dataGridView2[1, 1].Value.ToString());
            pro.Acc[1] = Convert.ToInt32(dataGridView2[2, 1].Value.ToString());
            pro.Acc[2] = Convert.ToInt32(dataGridView2[3, 1].Value.ToString());
            pro.Rhyrhm[1] = Convert.ToInt32(dataGridView2[4, 1].Value.ToString());




            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
