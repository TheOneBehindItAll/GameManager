using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace CustomGameManager
{
    public partial class Form1 : Form
    {
        string[] games;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game1.Text = Properties.Settings.Default.one;
            Game2.Text = Properties.Settings.Default.two;
            Game3.Text = Properties.Settings.Default.three;
            Game4.Text = Properties.Settings.Default.four;
            Game5.Text = Properties.Settings.Default.five;
            Game6.Text = Properties.Settings.Default.six;
            Game7.Text = Properties.Settings.Default.seven;
            Game8.Text = Properties.Settings.Default.eight;
            Game9.Text = Properties.Settings.Default.nine;
            Game10.Text = Properties.Settings.Default.ten;

            if(Game1.Text != "")
            {
                Icon theIcon1 = ExtractIconFromFilePath(Game1.Text);
                Game1.Image = theIcon1.ToBitmap();
            }
            if (Game2.Text != "")
            {
                Icon theIcon2 = ExtractIconFromFilePath(Game2.Text);
                Game2.Image = theIcon2.ToBitmap();
            }
            if (Game3.Text != "")
            {
                Icon theIcon3 = ExtractIconFromFilePath(Game3.Text);
                Game3.Image = theIcon3.ToBitmap();
            }
                
            if (Game4.Text != "")
            {
                Icon theIcon4 = ExtractIconFromFilePath(Game4.Text);
                Game4.Image = theIcon4.ToBitmap();
            }
             
            if (Game5.Text != "")
            {
                Icon theIcon5 = ExtractIconFromFilePath(Game5.Text);
                Game5.Image = theIcon5.ToBitmap();
            }
              
            if (Game6.Text != "")
            {
                Icon theIcon6 = ExtractIconFromFilePath(Game6.Text);
                Game6.Image = theIcon6.ToBitmap();
            }
               
            if (Game7.Text != "")
            {
                Icon theIcon7 = ExtractIconFromFilePath(Game7.Text);
                Game7.Image = theIcon7.ToBitmap();
            }
               
            if (Game8.Text != "")
            {
                Icon theIcon8 = ExtractIconFromFilePath(Game8.Text);
                Game8.Image = theIcon8.ToBitmap();
            }
                
            if (Game9.Text != "")
            {
                Icon theIcon9 = ExtractIconFromFilePath(Game9.Text);
                Game9.Image = theIcon9.ToBitmap();
            }
           
            if (Game10.Text != "")
            {
                Icon theIcon10 = ExtractIconFromFilePath(Game10.Text);
                Game10.Image = theIcon10.ToBitmap();
            }
            



        }

        public static Icon ExtractIconFromFilePath(string executablePath)
        {
            Icon result = (Icon)null;

            try
            {
                result = Icon.ExtractAssociatedIcon(executablePath);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to extract the icon from the binary");
            }

            return result;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "")
            {
                MessageBox.Show("Please Input The Game Slot You Would Like To Reset");
            }

            if (richTextBox1.Text != "")
            {
                if (richTextBox1.Text == "1")
                    Game1.Text = "";
                if (richTextBox1.Text == "2")
                    Game2.Text = "";
                if (richTextBox1.Text == "3")
                    Game3.Text = "";
                if (richTextBox1.Text == "4")
                    Game4.Text = "";
                if (richTextBox1.Text == "5")
                    Game5.Text = "";
                if (richTextBox1.Text == "6")
                    Game6.Text = "";
                if (richTextBox1.Text == "7")
                    Game7.Text = "";
                if (richTextBox1.Text == "8")
                    Game8.Text = "";
                if (richTextBox1.Text == "9")
                    Game9.Text = "";
                if (richTextBox1.Text == "10")
                    Game10.Text = "";
            }
        }

        private void Game1_Click(object sender, EventArgs e)
        {
            if(Game1.Text == "")
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Game1.Text = fd.FileName;
            }
            else
            {
                Process.Start(Game1.Text);
            }
        }

        private void Game2_Click(object sender, EventArgs e)
        {
            if (Game2.Text == "")
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Game2.Text = fd.FileName;
            }
            else
            {
                Process.Start(Game2.Text);
            }

            if (Game2.Text != "")
            {
                Icon theIcon2 = ExtractIconFromFilePath(Game2.Text);
                Game2.Image = theIcon2.ToBitmap();
            }
        }

        private void Game3_Click(object sender, EventArgs e)
        {
            if (Game3.Text == "")
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Game3.Text = fd.FileName;
            }
            else
            {
                Process.Start(Game3.Text);
            }

            if (Game3.Text != "")
            {
                Icon theIcon3 = ExtractIconFromFilePath(Game3.Text);
                Game3.Image = theIcon3.ToBitmap();
            }
        }

        private void Game4_Click(object sender, EventArgs e)
        {
            if (Game4.Text == "")
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Game4.Text = fd.FileName;
            }
            else
            {
                Process.Start(Game4.Text);
            }

            if (Game4.Text != "")
            {
                Icon theIcon4 = ExtractIconFromFilePath(Game4.Text);
                Game4.Image = theIcon4.ToBitmap();
            }
        }

        private void Game5_Click(object sender, EventArgs e)
        {
            if (Game5.Text == "")
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Game5.Text = fd.FileName;
            }
            else
            {
                Process.Start(Game5.Text);
            }
            if (Game5.Text != "")
            {
                Icon theIcon5 = ExtractIconFromFilePath(Game5.Text);
                Game5.Image = theIcon5.ToBitmap();
            }
        }

        private void Game6_Click(object sender, EventArgs e)
        {
            if (Game6.Text == "")
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Game6.Text = fd.FileName;
            }
            else
            {
                Process.Start(Game6.Text);
            }
            if (Game6.Text != "")
            {
                Icon theIcon6 = ExtractIconFromFilePath(Game6.Text);
                Game6.Image = theIcon6.ToBitmap();
            }
        }

        private void Game7_Click(object sender, EventArgs e)
        {
            if (Game7.Text == "")
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Game7.Text = fd.FileName;
            }
            else
            {
                Process.Start(Game7.Text);
            }
            if (Game7.Text != "")
            {
                Icon theIcon7 = ExtractIconFromFilePath(Game7.Text);
                Game7.Image = theIcon7.ToBitmap();
            }
        }

        private void Game8_Click(object sender, EventArgs e)
        {
            if (Game8.Text == "")
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Game8.Text = fd.FileName;
            }
            else
            {
                Process.Start(Game8.Text);
            }

            if (Game8.Text != "")
            {
                Icon theIcon8 = ExtractIconFromFilePath(Game8.Text);
                Game8.Image = theIcon8.ToBitmap();
            }
        }

        private void Game9_Click(object sender, EventArgs e)
        {
            if (Game9.Text == "")
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Game9.Text = fd.FileName;
            }
            else
            {
                Process.Start(Game9.Text);
            }
            if (Game9.Text != "")
            {
                Icon theIcon9 = ExtractIconFromFilePath(Game9.Text);
                Game9.Image = theIcon9.ToBitmap();
            }
        }

        private void Game10_Click(object sender, EventArgs e)
        {
            if (Game10.Text == "")
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Game10.Text = fd.FileName;
            }
            else
            {
                Process.Start(Game10.Text);
            }
            if (Game10.Text != "")
            {
                Icon theIcon10 = ExtractIconFromFilePath(Game10.Text);
                Game10.Image = theIcon10.ToBitmap();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.one = Game1.Text;
            Properties.Settings.Default.two = Game2.Text;
            Properties.Settings.Default.three = Game3.Text;
            Properties.Settings.Default.four = Game4.Text;
            Properties.Settings.Default.five = Game5.Text;
            Properties.Settings.Default.six = Game6.Text;
            Properties.Settings.Default.seven = Game7.Text;
            Properties.Settings.Default.eight = Game8.Text;
            Properties.Settings.Default.nine = Game9.Text;
            Properties.Settings.Default.ten = Game10.Text;
            Properties.Settings.Default.Save();
        }
    }
}
