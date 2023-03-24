using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Init()
        {
            label.Location = new Point(200,200);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Init();

        }
        int l = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            //levo
            Point a = new Point(0, 0);
            a = label.Location;
            
            if (a.X > 130)
            {
                a.X -= 10;
                label.Location = a;
                l++;
                levo_count.Text = $"Levo: {l}";
                label_location.Text = $"X: {label.Location.X} Y:{label.Location.Y}";
            }
            else
            {
                MessageBox.Show("nemoz");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int g = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //gore

            Point a = new Point(0, 0);
            a = label.Location;
            if (a.Y - 10 >= 0)
            {
                a.Y -= 10;
                label.Location = a;
                g++;
                gore_count.Text = $"Gore: {g}";
                label_location.Text = $"X: {label.Location.X} Y:{label.Location.Y}";
            }
            else
            {
                MessageBox.Show("nemoz");
            }
        }
        int d = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            //desno
            Point a = new Point(0, 0);
            a = label.Location;
            int b = panel3.Width;
            if (a.X + 5 <= b)
            {
                a.X += 10;
                label.Location = a;
                d++;
                desno_count.Text = $"Desno: {d}";
                label_location.Text = $"X: {label.Location.X} Y:{label.Location.Y}";
            }
            else
            {
                MessageBox.Show("nemoz");
            }
        }
        int dl = 0;
        private void button_dole_Click(object sender, EventArgs e)
        {
            //dole
            Point a = new Point(0, 0);
            a = label.Location;
            int b = panel3.Size.Height;
            if (a.Y + 10 < b)
            {
                a.Y += 10;
                label.Location = a;
                dl++;
                dole_count.Text = $"Dole: {dl}";

                label_location.Text = $"X: {label.Location.X} Y:{label.Location.Y}";
            }
            else
            {
                MessageBox.Show("nemoz");
            }
        }

        private void levo_count_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Resize(object sender, EventArgs e)
        {

        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            label.Location = new Point(panel3.Width / 2, panel3.Height / 2);
        }

        private void desno_count_Click(object sender, EventArgs e)
        {

        }
    }
}
