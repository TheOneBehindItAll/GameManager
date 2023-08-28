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
        Button[] games;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            nameSetup();
            iconSetup();
            try
            {
                this.BackColor = Properties.Settings.Default.bgColor;
                ColorButton.BackColor = Properties.Settings.Default.bgColor;
            }
            catch
            {
                MessageBox.Show("Unable to find background color");
            }
            try
            {
                ButtonColor.BackColor = Properties.Settings.Default.buttonColor;
                int whl = games.Length;
                while (whl > 0)
                {
                    whl -= 1;
                    games[whl].BackColor = Properties.Settings.Default.buttonColor;
                }
            }
            catch
            {
                MessageBox.Show("Unable to find button color");
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
                    Game1.Text = "";Game1.Image = null;
                if (richTextBox1.Text == "2")
                    Game2.Text = ""; Game2.Image = null;
                if (richTextBox1.Text == "3")
                    Game3.Text = ""; Game3.Image = null;
                if (richTextBox1.Text == "4")
                    Game4.Text = ""; Game4.Image = null;
                if (richTextBox1.Text == "5")
                    Game5.Text = ""; Game5.Image = null;
                if (richTextBox1.Text == "6")
                    Game6.Text = ""; Game6.Image = null;
                if (richTextBox1.Text == "7")
                    Game7.Text = ""; Game7.Image = null;
                if (richTextBox1.Text == "8")
                    Game8.Text = ""; Game8.Image = null;
                if (richTextBox1.Text == "9")
                    Game9.Text = ""; Game9.Image = null;
                if (richTextBox1.Text == "10")
                    Game10.Text = ""; Game10.Image = null;
                if (richTextBox1.Text == "all")
                {
                    int whl = games.Length;
                    while(whl > 0)
                    {
                        whl -= 1;
                        if (games[whl].Image != null)
                            games[whl].Image = null;
                        if(games[whl].Text != "")
                            games[whl].Text = "";
                    }
                }
                iconSetup();

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
            SaveFile();
        }


        void iconSetup()
        {

            int whl = games.Length;
            while (whl > 0)
            {
                whl -= 1;
                if (games[whl].Text != "")
                {
                    Icon theIcon1 = ExtractIconFromFilePath(games[whl].Text);
                    games[whl].Image = theIcon1.ToBitmap();
                }
            }
        }
        

        void nameSetup()
        {
            games = new Button[] {Game1, Game2, Game3, Game4, Game5, Game6, Game7, Game8, Game9, Game10 };
           

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
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            settingsPanel.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            settingsPanel.Hide();
            SaveFile();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog bgColor = new ColorDialog();
            bgColor.ShowDialog();
            ColorButton.BackColor = bgColor.Color;
            this.BackColor = bgColor.Color;
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            ColorDialog bgColor = new ColorDialog();
            bgColor.ShowDialog();
            Properties.Settings.Default.buttonColor = bgColor.Color;
            int whl = games.Length;
            while (whl > 0)
            {
                whl -= 1;
                games[whl].BackColor = bgColor.Color;
            }
          
        }

        void SaveFile()
        {
            Properties.Settings.Default.bgColor = this.BackColor;


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
