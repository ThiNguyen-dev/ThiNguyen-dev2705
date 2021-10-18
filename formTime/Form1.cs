using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formTime
{
    public partial class frmTime : Form
    {
        public frmTime()
        {
            InitializeComponent();
            label2.Text = "Hôm nay : " + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTime_Load(object sender, EventArgs e)
        {

        }
        int Tonggiay;
        private void button1_Click(object sender, EventArgs e)
        {

            if (!timer1.Enabled)
            {

                pictureBox1.Hide();
                DateTime ngay = dateTimePicker1.Value;

                DateTime today = DateTime.Today;


                TimeSpan interval = ngay.Subtract(DateTime.Today);
                String s = interval.TotalSeconds.ToString();
                double fs = double.Parse(s);
                fs = Math.Floor(fs);
                Tonggiay = Convert.ToInt32(fs);
                if (Tonggiay < 0)
                {
                    Tonggiay = 0;
                }
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            int ngay;
            int gio;
            int phut;
            int giay;
            int tam;
            //chuyen giay sang ngay thang:
            ngay = Tonggiay / (60 * 60 * 24);
            gio = (Tonggiay - ngay * (60 * 60 * 24)) / (60 * 60);
            tam = Tonggiay - ((ngay * 24 * 60 * 60) + (gio * 60 * 60));
            phut = tam / 60;
            tam = Tonggiay - ((ngay * 24 * 60 * 60) + (gio * 60 * 60) + phut * 60);
            giay = tam;

            label1.Text = "Còn: " + ngay.ToString() + "ngày," + gio.ToString() + "giờ," + phut.ToString() + "phút," + giay.ToString() + "giây";
            if (Tonggiay <= 0)
            {

                pictureBox1.Show();
                timer1.Stop();
            }
            Tonggiay--;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Xem pháo hoa")
            {
                button2.Text = "Tắt pháo hoa";
                pictureBox1.Show();
            }
            else
            {
                button2.Text = "Xem pháo hoa";
                pictureBox1.Hide();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
