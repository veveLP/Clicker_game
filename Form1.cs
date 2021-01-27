using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clicker_game2._0
{
    public partial class Form1 : Form
    {
        int[] nasobic_buy = new int[10];
        double[] nasobic_price = new double[10];
        int[] aut_buy = new int[10];
        double[] aut_price = new double[10];

        int score = 0;
        int multiplier = 1;
        int clic_ps = 0;
        public Form1()
        {
            InitializeComponent();
            initial_setup();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score += 1 * multiplier;
            score_show.Text = score.ToString();
        }

        public void initial_setup()
        {
            score_show.Text = score.ToString();
            nasobic_price[0] = 100; label5.Text = nasobic_price[0].ToString();
            nasobic_price[1] = 500; label7.Text = nasobic_price[1].ToString();
            nasobic_price[2] = 1000; label9.Text = nasobic_price[2].ToString();
            nasobic_price[3] = 2000; label11.Text = nasobic_price[3].ToString();
            nasobic_price[4] = 5000; label13.Text = nasobic_price[4].ToString();
            nasobic_price[5] = 10000; label15.Text = nasobic_price[5].ToString();
            nasobic_price[6] = 50000; label17.Text = nasobic_price[6].ToString();
            nasobic_price[7] = 100000; label19.Text = nasobic_price[7].ToString();
            nasobic_price[8] = 500000; label21.Text = nasobic_price[8].ToString();
            nasobic_price[9] = 1000000; label23.Text = nasobic_price[9].ToString();
            label6.Text = nasobic_buy[0].ToString();
            label8.Text = nasobic_buy[1].ToString();
            label10.Text = nasobic_buy[2].ToString();
            label12.Text = nasobic_buy[3].ToString();
            label14.Text = nasobic_buy[4].ToString();
            label16.Text = nasobic_buy[5].ToString();
            label18.Text = nasobic_buy[6].ToString();
            label20.Text = nasobic_buy[7].ToString();
            label22.Text = nasobic_buy[8].ToString();
            label24.Text = nasobic_buy[9].ToString();
            label43.Text = aut_buy[0].ToString();
            label41.Text = aut_buy[1].ToString();
            label39.Text = aut_buy[2].ToString();
            label37.Text = aut_buy[3].ToString();
            label35.Text = aut_buy[4].ToString();
            label33.Text = aut_buy[5].ToString();
            label31.Text = aut_buy[6].ToString();
            label29.Text = aut_buy[7].ToString();
            label27.Text = aut_buy[8].ToString();
            label25.Text = aut_buy[9].ToString();
            aut_price[0] = 100; label47.Text = aut_price[0].ToString();
            aut_price[1] = 500; label42.Text = aut_price[1].ToString();
            aut_price[2] = 1000; label40.Text = aut_price[2].ToString();
            aut_price[3] = 2000; label38.Text = aut_price[3].ToString();
            aut_price[4] = 5000; label36.Text = aut_price[4].ToString();
            aut_price[5] = 10000; label34.Text = aut_price[5].ToString();
            aut_price[6] = 50000; label32.Text = aut_price[6].ToString();
            aut_price[7] = 100000; label30.Text = aut_price[7].ToString();
            aut_price[8] = 500000; label28.Text = aut_price[8].ToString();
            aut_price[9] = 1000000; label26.Text = aut_price[9].ToString();
            timer1.Enabled = true;
        }

      

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            if (score >= nasobic_price[0]) {score -= (int)nasobic_price[0]; multiplier += 1; nasobic_buy[0]++; nasobic_price[0] *= 1.1; nasobic_price[0] = (int)nasobic_price[0];
                label5.Text = nasobic_price[0].ToString();
                label6.Text = nasobic_buy[0].ToString();
                score_show.Text = score.ToString();


            }
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            score += 100000;
            score_show.Text = score.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (score >= nasobic_price[1])
            {
                score -= (int)nasobic_price[1]; multiplier += 5; nasobic_buy[1]++; nasobic_price[1] *= 1.1; nasobic_price[1] = (int)nasobic_price[1];
                label7.Text = nasobic_price[1].ToString();
                label8.Text = nasobic_buy[1].ToString();
                score_show.Text = score.ToString();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (score >= nasobic_price[2])
            {
                score -= (int)nasobic_price[2]; multiplier += 10; nasobic_buy[2]++; nasobic_price[2] *= 1.1; nasobic_price[2] = (int)nasobic_price[2];
                label9.Text = nasobic_price[2].ToString();
                label10.Text = nasobic_buy[2].ToString();
                score_show.Text = score.ToString();


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(score >= nasobic_price[3])
            {
                score -= (int)nasobic_price[3]; multiplier += 20; nasobic_buy[3]++; nasobic_price[3] *= 1.1; nasobic_price[3] = (int)nasobic_price[3];
                label11.Text = nasobic_price[3].ToString();
                label12.Text = nasobic_buy[3].ToString();
                score_show.Text = score.ToString();
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (score >= nasobic_price[4])
            {
                score -= (int)nasobic_price[4]; multiplier += 50; nasobic_buy[4]++; nasobic_price[4] *= 1.1; nasobic_price[4] = (int)nasobic_price[4];
                label13.Text = nasobic_price[4].ToString();
                label14.Text = nasobic_buy[4].ToString();
                score_show.Text = score.ToString();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (score >= nasobic_price[5])
            {
                score -= (int)nasobic_price[5]; multiplier += 100; nasobic_buy[5]++; nasobic_price[5] *= 1.1; nasobic_price[5] = (int)nasobic_price[5];
                label15.Text = nasobic_price[5].ToString();
                label16.Text = nasobic_buy[5].ToString();
                score_show.Text = score.ToString();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (score >= nasobic_price[6])
            {
                score -= (int)nasobic_price[6]; multiplier += 500; nasobic_buy[6]++; nasobic_price[6] *= 1.1; nasobic_price[6] = (int)nasobic_price[6];
                label17.Text = nasobic_price[6].ToString();
                label18.Text = nasobic_buy[6].ToString();
                score_show.Text = score.ToString();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (score >= nasobic_price[7])
            {
                score -= (int)nasobic_price[7]; multiplier += 1000; nasobic_buy[7]++; nasobic_price[7] *= 1.1; nasobic_price[7] = (int)nasobic_price[7];
                label19.Text = nasobic_price[7].ToString();
                label20.Text = nasobic_buy[7].ToString();
                score_show.Text = score.ToString();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (score >= nasobic_price[8])
            {
                score -= (int)nasobic_price[8]; multiplier += 5000; nasobic_buy[8]++; nasobic_price[8] *= 1.1; nasobic_price[8] = (int)nasobic_price[8];
                label21.Text = nasobic_price[8].ToString();
                label22.Text = nasobic_buy[8].ToString();
                score_show.Text = score.ToString();

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (score >= nasobic_price[9])
            {
                score -= (int)nasobic_price[9]; multiplier += 10000; nasobic_buy[9]++; nasobic_price[9] *= 1.1; nasobic_price[9] = (int)nasobic_price[9];
                label23.Text = nasobic_price[9].ToString();
                label24.Text = nasobic_buy[9].ToString();
                score_show.Text = score.ToString();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (score >= aut_price[0])
            {
                score -= (int)aut_price[0]; clic_ps += 1; aut_buy[0]++; aut_price[0] *= 1.1; aut_price[0] = (int)aut_price[0];
                label47.Text = aut_price[0].ToString();
                label43.Text = aut_buy[0].ToString();
                score_show.Text = score.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (score >= aut_price[1])
            {
                score -= (int)aut_price[1]; clic_ps += 5; aut_buy[1]++; aut_price[1] *= 1.1; aut_price[1] = (int)aut_price[1];
                label42.Text = aut_price[1].ToString();
                label41.Text = aut_buy[1].ToString();
                score_show.Text = score.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (score >= aut_price[2])
            {
                score -= (int)aut_price[2]; clic_ps += 10; aut_buy[2]++; aut_price[2] *= 1.1; aut_price[2] = (int)aut_price[2];
                label40.Text = aut_price[2].ToString();
                label39.Text = aut_buy[2].ToString();
                score_show.Text = score.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (score >= aut_price[3])
            {
                score -= (int)aut_price[3]; clic_ps += 20; aut_buy[3]++; aut_price[3] *= 1.1; aut_price[3] = (int)aut_price[3];
                label38.Text = aut_price[3].ToString();
                label37.Text = aut_buy[3].ToString();
                score_show.Text = score.ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (score >= aut_price[4])
            {
                score -= (int)aut_price[4]; clic_ps += 50; aut_buy[4]++; aut_price[4] *= 1.1; aut_price[4] = (int)aut_price[4];
                label36.Text = aut_price[4].ToString();
                label35.Text = aut_buy[4].ToString();
                score_show.Text = score.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(score >= aut_price[5])
            {
                score -= (int)aut_price[5]; clic_ps += 100; aut_buy[5]++; aut_price[5] *= 1.1; aut_price[5] = (int)aut_price[5];
                label34.Text = aut_price[5].ToString();
                label33.Text = aut_buy[5].ToString();
                score_show.Text = score.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (score >= aut_price[6])
            {
                score -= (int)aut_price[6]; clic_ps += 500; aut_buy[6]++; aut_price[6] *= 1.1; aut_price[6] = (int)aut_price[6];
                label32.Text = aut_price[6].ToString();
                label31.Text = aut_buy[6].ToString();
                score_show.Text = score.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (score >= aut_price[7])
            {
                score -= (int)aut_price[7]; clic_ps += 1000; aut_buy[7]++; aut_price[7] *= 1.1; aut_price[7] = (int)aut_price[7];
                label30.Text = aut_price[7].ToString();
                label29.Text = aut_buy[7].ToString();
                score_show.Text = score.ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (score >= aut_price[8])
            {
                score -= (int)aut_price[8]; clic_ps += 5000; aut_buy[8]++; aut_price[8] *= 1.1; aut_price[8] = (int)aut_price[8];
                label30.Text = aut_price[8].ToString();
                label29.Text = aut_buy[8].ToString();
                score_show.Text = score.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (score >= aut_price[9])
            {
                score -= (int)aut_price[9]; clic_ps += 10000; aut_buy[9]++; aut_price[9] *= 1.1; aut_price[9] = (int)aut_price[9];
                label30.Text = aut_price[9].ToString();
                label29.Text = aut_buy[9].ToString();
                score_show.Text = score.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score += clic_ps;
            score_show.Text = score.ToString();
        }
    }
}
