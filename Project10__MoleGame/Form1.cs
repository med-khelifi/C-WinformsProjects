using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10__MoleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cursor = new Cursor("MoleGame\\Shot.cur");
        }

        Random rd = new Random();
        private Point GetRandomPosition()
        {
            switch (rd.Next(0, 6))
            {
                case 0:
                    return pb1.Location;// Point(70,160);
                case 1:
                    return pb2.Location;
                case 2:
                    return pb3.Location;
                case 3:
                    return pb4.Location;
                case 4:
                    return pb5.Location;
                case 5:
                    return pb6.Location;
            }

            return pb1.Location;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') { 

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbMole.Location = GetRandomPosition();
        }
        int score = 0;


        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // MoleGame\Gunshot Sound Effect Single Shot(MP3_320K).mp3
        SoundPlayer sd = new SoundPlayer(@"MoleGame\\Shot.wav");
        private void pbMole_Click(object sender, EventArgs e)
        {
            panel2_Click(sender, e);
            score++;
            lblScore.Text = "Score : " + score.ToString();
            showScoreIncremants();
        }

        private async void showScoreIncremants()
        {
            Label l1 = new Label();
            l1.Text = "+1";
           
            l1.BackColor = System.Drawing.Color.Transparent;
            l1.ForeColor = Color.Red;
            l1.Font = lblScore.Font; 
            l1.Location = new Point(pbMole.Left - 40, pbMole.Top + 10);
            panel2.Controls.Add(l1);
            //l1.BringToFront();
            await Task.Delay(1500);
            panel2.Controls.Remove(l1);
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            sd.Stop();
            sd.Play();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            panel2_Click(sender, e);
        }
    }
    

    
}
