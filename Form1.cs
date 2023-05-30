using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReactionTest
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        double time = 0;
        bool isGreen = false;

        public Form1()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            timer.Interval = random.Next(1000, 3000);
            timer.Start();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (isGreen)
            {
                timerClick.Stop();
                label.Text = $"Время вашей реакции: {time/50} с";
                buttonRestart.Visible = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            isGreen = true;
            pictureBox.BackColor = Color.LimeGreen;
            timerClick.Start();
        }

        private void timerClick_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
