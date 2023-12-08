using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppppp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnСombination_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnСombination.Checked)
            {
                panel11.Enabled = true;
                panel22.Enabled = false;
                panel33.Enabled = false;
            }
        }

        private void BtnPlacement_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnPlacement.Checked)
            {
                panel11.Enabled = false;
                panel22.Enabled = true;
                panel33.Enabled = false;
            }
        }

        private void BtnPermutations_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnPermutations.Checked)
            {
                panel11.Enabled = false;
                panel22.Enabled = false;
                panel33.Enabled = true;
            }
        }

        private int factarial(int n)
        {
            if (n == 1) return 1;

            return n * factarial(n - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            int m;

            if (BtnСombination.Checked)
            {
                if (!int.TryParse(textBox1.Text, out m) || !int.TryParse(textBox2.Text, out n))
                {
                    MessageBox.Show("Введите целое число не больше 20");
                    return;
                }


                if (n > 20 || m > 20 || n < 0 || m < 0)
                {
                    MessageBox.Show("Введите целое число не больше 20");
                    return;
                }

                label8.Text = ((factarial(n + m - 1) / (factarial(m) * factarial(n - 1))).ToString());
            }

            if (BtnPlacement.Checked)
            {
                if (!int.TryParse(textBox3.Text, out m) || !int.TryParse(textBox4.Text, out n))
                {
                    MessageBox.Show("Введите целое число не больше 20");
                    return;
                }


                if (n > 20 || m > 20 || n < 0 || m < 0)
                {
                    MessageBox.Show("Введите целое число не больше 20");
                    return;
                }

                label8.Text = Math.Pow(n, m).ToString();

            }


            if (BtnPermutations.Checked)
            {
                if (!int.TryParse(textBox5.Text, out m) || !int.TryParse(textBox6.Text, out n))
                {
                    MessageBox.Show("Введите целое число не больше 20");
                    return;
                }


                if (n > 20 || m > 20 || n < 0 || m < 0)
                {
                    MessageBox.Show("Введите целое число не больше 20");
                    return;
                }

                label8.Text = (factarial(n + m) / (factarial(n) * factarial(m))).ToString();

            }
        }
    }
}
