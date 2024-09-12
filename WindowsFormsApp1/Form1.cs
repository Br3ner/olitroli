using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;

                this.BackColor = color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("czy chcesz zamkną","zamkniecie programu",MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (DialogResult == DialogResult.No)
            {
                label1.Text = "program n zostal zamkniety";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                this.Font = font;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(800, 600);

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "open image";
            openFileDialog1.Filter = "Image|*.png;*.jpg;*.bmp;*.gif;";
            openFileDialog1.InitialDirectory = @"C:/Users/uczen";
            openFileDialog1.ShowDialog();
            string FilePath = openFileDialog1.FileName;
            pictureBox2.Image = Image.FromFile(FilePath);
            label2.Text = FilePath;
            var size = (decimal)(new FileInfo(openFileDialog1.FileName).Length) / 1024;
            label3.Text = Math.Round(size, 2).ToString() + "KB";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(800, 600);

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "open image";
            openFileDialog1.Filter = "Image|*.png;*.jpg;*.bmp;*.gif;";
            openFileDialog1.InitialDirectory = @"C:/Users/uczen";
            openFileDialog1.ShowDialog();
            string FilePath = openFileDialog1.FileName;
            pictureBox2.Image = Image.FromFile(FilePath);
            label2.Text = FilePath;
            var size = (decimal)(new FileInfo(openFileDialog1.FileName).Length) / 1024;
            label3.Text = Math.Round(size, 2).ToString() + "KB";
        }
    }
}
