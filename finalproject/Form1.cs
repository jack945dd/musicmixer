using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

namespace finalproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string test1;
        //bool isdrug=false;
        //int sX, sY;
        int i = -1;
        int j = -1;
        int a = -1;
        int b = -1;
        int c = -1;
        int d = -1;
        List<Button> d1buttonlist = new List<Button>();
        List<Button> d2buttonlist = new List<Button>();
        SoundPlayer myMusic = new SoundPlayer("鼓聲1.wav");
        int[] musicarray = new int[64] { 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37 };
        int[] music2array = new int[64] { 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37};
        /*private void mousedown(object sender, MouseEventArgs e)
        {
            isdrug = true;
            sX = e.X; sY = e.Y;
        }*/
        /*private void mouseup(object sender, MouseEventArgs e)
        {
            isdrug = false;
        }*/
        /*private void mousemove(object sender, MouseEventArgs e)
        {
            if (isdrug)
            {
                Button btn = (Button)sender;
                Point newloc = new Point();
                newloc.X = e.X - sX;
                newloc.Y = e.Y - sY;
                btn.Left += newloc.X;
                btn.Top += newloc.Y;
            }
        }*/

        private void drum1_Click(object sender, EventArgs e)
        {      
            myMusic.SoundLocation = "鼓聲1.wav";
            myMusic.Play();
            if (i < 63)
            {
                d1buttonlist.Add(new Button());
                i+=1;
                d1buttonlist[i].BackColor = Color.Red;
                if (i % 8 == 0)
                {
                    a++;
                    b++;
                }
                d1buttonlist[i].Location = new Point(500+i*100-b*800, 100+a*50);
                this.Controls.Add(d1buttonlist[i]);
                musicarray[i] = 1;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void drum2_Click(object sender, EventArgs e)
        {
            myMusic.SoundLocation = "鼓聲2.wav";
            myMusic.Play();
            if (i < 63)
            {
                d1buttonlist.Add(new Button());
                i += 1;
                d1buttonlist[i].BackColor = Color.Yellow;
                if (i % 8 == 0)
                {
                    a++;
                    b++;
                }
                d1buttonlist[i].Location = new Point(500 + i * 100 - b * 800, 100 + a * 50);
                this.Controls.Add(d1buttonlist[i]);
                musicarray[i] = 2;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void drum3_Click(object sender, EventArgs e)
        {
            myMusic.SoundLocation = "鼓聲3.wav";
            myMusic.Play();
            if (i < 63)
            {
                d1buttonlist.Add(new Button());
                i += 1;
                d1buttonlist[i].BackColor = Color.Green;
                if (i % 8 == 0)
                {
                    a++;
                    b++;
                }
                d1buttonlist[i].Location = new Point(500 + i * 100 - b * 800, 100 + a * 50);
                this.Controls.Add(d1buttonlist[i]);
                musicarray[i] = 3;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void clap_Click(object sender, EventArgs e)
        {
            myMusic.SoundLocation = "拍手聲.wav";
            myMusic.Play();

            if (i < 63)
            {
                d1buttonlist.Add(new Button());
                i += 1;
                d1buttonlist[i].BackColor = Color.Purple;
                if (i % 8 == 0)
                {
                    a++;
                    b++;
                }
                d1buttonlist[i].Location = new Point(500 + i * 100 - b * 800, 100 + a * 50);
                this.Controls.Add(d1buttonlist[i]);
                musicarray[i] = 4;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void ring_Click(object sender, EventArgs e)
        {
            myMusic.SoundLocation = "鈴聲.wav";
            myMusic.Play();

            if (i < 63)
            {
                d1buttonlist.Add(new Button());
                i += 1;
                d1buttonlist[i].BackColor = Color.DodgerBlue;
                if (i % 8 == 0)
                {
                    a++;
                    b++;
                }
                d1buttonlist[i].Location = new Point(500 + i * 100 - b * 800, 100 + a * 50);
                this.Controls.Add(d1buttonlist[i]);
                musicarray[i] = 5;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dbDataSet.db' 資料表。您可以視需要進行移動或移除。
            this.dbTableAdapter.Fill(this.dbDataSet.db);
            // TODO: 這行程式碼會將資料載入 'dbDataSet.db' 資料表。您可以視需要進行移動或移除。
            this.dbTableAdapter.Fill(this.dbDataSet.db);
            label1.Text = test1;
        }

        private void MenuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            throw new NotImplementedException();
        }

        int speed = 500;
        private void button1_Click(object sender, EventArgs e)
        {
            for(int a=0 ; a< 64; a++)
            {
                if (musicarray[a] == 1)
                {
                    myMusic.SoundLocation = "鼓聲1.wav";
                    myMusic.Play();
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 2)
                {
                    myMusic.SoundLocation = "鼓聲2.wav";
                    myMusic.Play();
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 3)
                {
                    myMusic.SoundLocation = "鼓聲3.wav";
                    myMusic.Play();
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 4)
                {
                    myMusic.SoundLocation = "拍手聲.wav";
                    myMusic.Play();
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 5)
                {
                    myMusic.SoundLocation = "鈴聲.wav";
                    myMusic.Play();
                    Console.Beep(music2array[a], 500);
                }
                else if(musicarray[a] == 37&& music2array[a] != 37)
                {
                    Console.Beep(music2array[a], 500);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (speed > 100)
            {
                speed -= 100;
            }
            label3.Text = speed.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            speed += 100;
            label3.Text = speed.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Beep(262, 100);
            if (j < 63)
            {
                d2buttonlist.Add(new Button());
                j += 1;
                d2buttonlist[j].BackColor = Color.White;
                d2buttonlist[j].Text = "C";
                if (j % 8 == 0)
                {
                    c++;
                    d++;
                }
                d2buttonlist[j].Location = new Point(500 + j * 100 - d * 800, 100 + c * 50-25);
                this.Controls.Add(d2buttonlist[j]);
                music2array[j] = 262;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.Beep(294, 100);
            if (j < 63)
            {
                d2buttonlist.Add(new Button());
                j += 1;
                d2buttonlist[j].BackColor = Color.White;
                d2buttonlist[j].Text = "D";
                if (j % 8 == 0)
                {
                    c++;
                    d++;
                }
                d2buttonlist[j].Location = new Point(500 + j * 100 - d * 800, 100 + c * 50 - 25);
                this.Controls.Add(d2buttonlist[j]);
                music2array[j] = 294;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep(330, 100);
            if (j < 63)
            {
                d2buttonlist.Add(new Button());
                j += 1;
                d2buttonlist[j].BackColor = Color.White;
                d2buttonlist[j].Text = "E";
                if (j % 8 == 0)
                {
                    c++;
                    d++;
                }
                d2buttonlist[j].Location = new Point(500 + j * 100 - d * 800, 100 + c * 50 - 25);
                this.Controls.Add(d2buttonlist[j]);
                music2array[j] = 330;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.Beep(349, 100);
            if (j < 63)
            {
                d2buttonlist.Add(new Button());
                j += 1;
                d2buttonlist[j].BackColor = Color.White;
                d2buttonlist[j].Text = "F";
                if (j % 8 == 0)
                {
                    c++;
                    d++;
                }
                d2buttonlist[j].Location = new Point(500 + j * 100 - d * 800, 100 + c * 50 - 25);
                this.Controls.Add(d2buttonlist[j]);
                music2array[j] = 349;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.Beep(392, 100);
            if (j < 63)
            {
                d2buttonlist.Add(new Button());
                j += 1;
                d2buttonlist[j].BackColor = Color.White;
                d2buttonlist[j].Text = "G";
                if (j % 8 == 0)
                {
                    c++;
                    d++;
                }
                d2buttonlist[j].Location = new Point(500 + j * 100 - d * 800, 100 + c * 50 - 25);
                this.Controls.Add(d2buttonlist[j]);
                music2array[j] = 392;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Console.Beep(440, 100);
            if (j < 63)
            {
                d2buttonlist.Add(new Button());
                j += 1;
                d2buttonlist[j].BackColor = Color.White;
                d2buttonlist[j].Text = "A";
                if (j % 8 == 0)
                {
                    c++;
                    d++;
                }
                d2buttonlist[j].Location = new Point(500 + j * 100 - d * 800, 100 + c * 50 - 25);
                this.Controls.Add(d2buttonlist[j]);
                music2array[j] = 440;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Console.Beep(493, 100);
            if (j < 63)
            {
                d2buttonlist.Add(new Button());
                j += 1;
                d2buttonlist[j].BackColor = Color.White;
                d2buttonlist[j].Text = "B";
                if (j % 8 == 0)
                {
                    c++;
                    d++;
                }
                d2buttonlist[j].Location = new Point(500 + j * 100 - d * 800, 100 + c * 50 - 25);
                this.Controls.Add(d2buttonlist[j]);
                music2array[j] = 493;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Console.Beep(38, 100);
            if (j < 63)
            {
                d2buttonlist.Add(new Button());
                j += 1;
                d2buttonlist[j].BackColor = Color.White;
                d2buttonlist[j].Text = "休息";
                if (j % 8 == 0)
                {
                    c++;
                    d++;
                }
                d2buttonlist[j].Location = new Point(500 + j * 100 - d * 800, 100 + c * 50 - 25);
                this.Controls.Add(d2buttonlist[j]);
                music2array[j] = 38;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 8; a++)
            {
                if (musicarray[a] == 1)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 2)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 3)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 4)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 5)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Console.Beep(music2array[a], 500);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            for (int a = 8; a < 16; a++)
            {
                if (musicarray[a] == 1)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 2)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 3)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 4)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 5)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Console.Beep(music2array[a], 500);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int a = 16; a < 24; a++)
            {
                if (musicarray[a] == 1)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 2)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 3)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 4)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 5)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Console.Beep(music2array[a], 500);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            for (int a = 24; a < 32; a++)
            {
                if (musicarray[a] == 1)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 2)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 3)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 4)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 5)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Console.Beep(music2array[a], 500);
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            for (int a = 32; a < 40; a++)
            {
                if (musicarray[a] == 1)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 2)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 3)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 4)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 5)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Console.Beep(music2array[a], 500);
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            for (int a = 40; a < 48; a++)
            {
                if (musicarray[a] == 1)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 2)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 3)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 4)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 5)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Console.Beep(music2array[a], 500);
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            for (int a = 48; a < 56; a++)
            {
                if (musicarray[a] == 1)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 2)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 3)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 4)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 5)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Console.Beep(music2array[a], 500);
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            for (int a = 56; a < 64; a++)
            {
                if (musicarray[a] == 1)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 2)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 3)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 4)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 5)
                {
                    Console.Beep(music2array[a], 500);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Console.Beep(music2array[a], 500);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 8; a++)
            {
                if (musicarray[a] == 1)
                {
                    myMusic.SoundLocation = "鼓聲1.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 2)
                {
                    myMusic.SoundLocation = "鼓聲2.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 3)
                {
                    myMusic.SoundLocation = "鼓聲3.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 4)
                {
                    myMusic.SoundLocation = "拍手聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 5)
                {
                    myMusic.SoundLocation = "鈴聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Thread.Sleep(speed);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            for (int a = 8; a < 16; a++)
            {
                if (musicarray[a] == 1)
                {
                    myMusic.SoundLocation = "鼓聲1.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 2)
                {
                    myMusic.SoundLocation = "鼓聲2.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 3)
                {
                    myMusic.SoundLocation = "鼓聲3.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 4)
                {
                    myMusic.SoundLocation = "拍手聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 5)
                {
                    myMusic.SoundLocation = "鈴聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Thread.Sleep(speed);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            for (int a = 16; a < 24; a++)
            {
                if (musicarray[a] == 1)
                {
                    myMusic.SoundLocation = "鼓聲1.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 2)
                {
                    myMusic.SoundLocation = "鼓聲2.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 3)
                {
                    myMusic.SoundLocation = "鼓聲3.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 4)
                {
                    myMusic.SoundLocation = "拍手聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 5)
                {
                    myMusic.SoundLocation = "鈴聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Thread.Sleep(speed);
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            for (int a = 24; a < 32; a++)
            {
                if (musicarray[a] == 1)
                {
                    myMusic.SoundLocation = "鼓聲1.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 2)
                {
                    myMusic.SoundLocation = "鼓聲2.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 3)
                {
                    myMusic.SoundLocation = "鼓聲3.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 4)
                {
                    myMusic.SoundLocation = "拍手聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 5)
                {
                    myMusic.SoundLocation = "鈴聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Thread.Sleep(speed);
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            for (int a = 32; a < 40; a++)
            {
                if (musicarray[a] == 1)
                {
                    myMusic.SoundLocation = "鼓聲1.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 2)
                {
                    myMusic.SoundLocation = "鼓聲2.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 3)
                {
                    myMusic.SoundLocation = "鼓聲3.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 4)
                {
                    myMusic.SoundLocation = "拍手聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 5)
                {
                    myMusic.SoundLocation = "鈴聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Thread.Sleep(speed);
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            for (int a = 40; a < 48; a++)
            {
                if (musicarray[a] == 1)
                {
                    myMusic.SoundLocation = "鼓聲1.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 2)
                {
                    myMusic.SoundLocation = "鼓聲2.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 3)
                {
                    myMusic.SoundLocation = "鼓聲3.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 4)
                {
                    myMusic.SoundLocation = "拍手聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 5)
                {
                    myMusic.SoundLocation = "鈴聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Thread.Sleep(speed);
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            for (int a = 48; a < 56; a++)
            {
                if (musicarray[a] == 1)
                {
                    myMusic.SoundLocation = "鼓聲1.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 2)
                {
                    myMusic.SoundLocation = "鼓聲2.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 3)
                {
                    myMusic.SoundLocation = "鼓聲3.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 4)
                {
                    myMusic.SoundLocation = "拍手聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 5)
                {
                    myMusic.SoundLocation = "鈴聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Thread.Sleep(speed);
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            for (int a = 56; a < 64; a++)
            {
                if (musicarray[a] == 1)
                {
                    myMusic.SoundLocation = "鼓聲1.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 2)
                {
                    myMusic.SoundLocation = "鼓聲2.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 3)
                {
                    myMusic.SoundLocation = "鼓聲3.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 4)
                {
                    myMusic.SoundLocation = "拍手聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 5)
                {
                    myMusic.SoundLocation = "鈴聲.wav";
                    myMusic.Play();
                    Thread.Sleep(speed);
                }
                else if (musicarray[a] == 37 && music2array[a] != 37)
                {
                    Thread.Sleep(speed);
                }
            }
        }

        private void dbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void dbBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(i.ToString());
            d1buttonlist.Remove(d1buttonlist[i]);
            d1buttonlist[i].Visible = false;

        }

        private void 匯入伴奏ToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            string access = dbDataGridView.Rows[0].Cells[2].Value.ToString();
            for(int ikk = 0; ikk < access.Length; ikk++)
            {
                if (test1 == "S10755034")
                {
                    access = dbDataGridView.Rows[0].Cells[2].Value.ToString();
                    int abc = Convert.ToInt32(access[ikk].ToString());
                    if (i < 63)
                    {
                        d1buttonlist.Add(new Button());
                        i += 1;
                        switch (abc)
                        {
                            case 1:
                                d1buttonlist[i].BackColor = Color.Red;
                                break;
                            case 2:
                                d1buttonlist[i].BackColor = Color.Yellow;
                                break;
                            case 3:
                                d1buttonlist[i].BackColor = Color.Green;
                                break;
                            case 4:
                                d1buttonlist[i].BackColor = Color.Purple;
                                break;
                            case 5:
                                d1buttonlist[i].BackColor = Color.DodgerBlue;
                                break;
                        }
                        if (i % 8 == 0)
                        {
                            a++;
                            b++;
                        }
                        d1buttonlist[i].Location = new Point(500 + i * 100 - b * 800, 100 + a * 50);
                        this.Controls.Add(d1buttonlist[i]);
                        musicarray[i] = abc;
                    }
                    else
                    {
                        button1.Enabled = true;
                    }

                }
                if (test1 == "S10755001")
                {
                    access = dbDataGridView.Rows[1].Cells[2].Value.ToString();
                    int abc = Convert.ToInt32(access[ikk].ToString());
                    if (i < 63)
                    {
                        d1buttonlist.Add(new Button());
                        i += 1;
                        switch (abc)
                        {
                            case 1:
                                d1buttonlist[i].BackColor = Color.Red;
                                break;
                            case 2:
                                d1buttonlist[i].BackColor = Color.Yellow;
                                break;
                            case 3:
                                d1buttonlist[i].BackColor = Color.Green;
                                break;
                            case 4:
                                d1buttonlist[i].BackColor = Color.Purple;
                                break;
                            case 5:
                                d1buttonlist[i].BackColor = Color.DodgerBlue;
                                break;
                        }
                        if (i % 8 == 0)
                        {
                            a++;
                            b++;
                        }
                        d1buttonlist[i].Location = new Point(500 + i * 100 - b * 800, 100 + a * 50);
                        this.Controls.Add(d1buttonlist[i]);
                        musicarray[i] = abc;
                    }
                    else
                    {
                        button1.Enabled = true;
                    }

                }
                if (test1 == "S10755002")
                {
                    access = dbDataGridView.Rows[2].Cells[2].Value.ToString();
                    int abc = Convert.ToInt32(access[ikk].ToString());
                    if (i < 63)
                    {
                        d1buttonlist.Add(new Button());
                        i += 1;
                        switch (abc)
                        {
                            case 1:
                                d1buttonlist[i].BackColor = Color.Red;
                                break;
                            case 2:
                                d1buttonlist[i].BackColor = Color.Yellow;
                                break;
                            case 3:
                                d1buttonlist[i].BackColor = Color.Green;
                                break;
                            case 4:
                                d1buttonlist[i].BackColor = Color.Purple;
                                break;
                            case 5:
                                d1buttonlist[i].BackColor = Color.DodgerBlue;
                                break;
                        }
                        if (i % 8 == 0)
                        {
                            a++;
                            b++;
                        }
                        d1buttonlist[i].Location = new Point(500 + i * 100 - b * 800, 100 + a * 50);
                        this.Controls.Add(d1buttonlist[i]);
                        musicarray[i] = abc;
                    }
                    else
                    {
                        button1.Enabled = true;
                    }

                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Visible = false;
        }
    }
}
