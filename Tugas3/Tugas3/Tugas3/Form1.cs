using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3
{
    public partial class akumati : Form
    {
        int userkeberapa = 0;
        List<string>UsernamedanPassword=new List<string>();
        List<int>Uang=new List<int>();
        public akumati()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            userkeberapa = -1;
            bool cekorang = false;
            foreach (string s in UsernamedanPassword)
            {
                userkeberapa++;
                string[]userdanpasstapipisah=s.Split('⣿');
                string user = userdanpasstapipisah[0];
                string pass= userdanpasstapipisah[1];
                if (user == tbxuse.Text && pass == tbxpas.Text)
                {
                    cekorang = true;
                    break;
                }
            }
            if (cekorang)
            {
                MessageBox.Show("Successfully Logged in");
                panel1.Visible = true;
                label4.Text = "Balance: " + Uang[userkeberapa];
                tbxpas.Text = "";
                tbxuse.Text = "";
            }
            else
            {
                MessageBox.Show("No User Found");
            }
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            if (btnlog.Visible == true)
            {
                btnlog.Visible = false;
            }
            else
            {
                btnlog.Visible = true;
                bool cekadauser = false;
                foreach (string s in UsernamedanPassword)
                {
                    string[] userdanpasstapipisah = s.Split('⣿');
                    string user = userdanpasstapipisah[0];
                    if (user == tbxuse.Text)
                    {
                        cekadauser = true;
                        break;
                    }
                }
                if (cekadauser)
                {
                    MessageBox.Show("Name Already Registered");
                }
                else
                {
                    MessageBox.Show("Succefully Registered");
                    UsernamedanPassword.Add(tbxuse.Text + "⣿" + tbxpas.Text);
                    Uang.Add(0);
                }
            }

        }

        private void btndep_Click(object sender, EventArgs e)
        {
            if (btnwit.Visible == true)
            {
                btnwit.Visible = false;
                tbxuang.Visible = true;
                tbxuang.Text = "";
                label5.Visible = true;
                btnlogout.Visible = false;
            }
            else
            {
                int uangpunyaku = Uang[userkeberapa];
                int uang = Convert.ToInt32(tbxuang.Text);
                if (uang < 1)
                {
                    MessageBox.Show("Cannot Deposit less or equal to 0");
                }
                else
                {
                    
                    MessageBox.Show("Deposit Successful");
                    Uang[userkeberapa] = uangpunyaku + uang;
                    
                }

                btnlogout.Visible = true;
                btnwit.Visible = true;
                tbxuang.Visible = false;
                tbxuang.Text = "";
                label5.Visible = false;
                label4.Text = "Balance: " + Uang[userkeberapa];
            }
        }

        private void btnwit_Click(object sender, EventArgs e)
        {
            if (btndep.Visible == true)
            {
                btndep.Visible = false;
                tbxuang.Visible = true;
                tbxuang.Text = "";
                label5.Visible = true;
                btnlogout.Visible = false;
            }
            else
            {
                int uangpunyaku = Uang[userkeberapa];
                int uang = Convert.ToInt32(tbxuang.Text);
                if (uang < 1)
                {
                    MessageBox.Show("Cannot withdraw less or equal to 0");
                }
                else
                {
                    if (uangpunyaku < uang)
                    {
                        MessageBox.Show("Cannot Withdraw, Not enough balance");
                    }
                    else
                    {
                        MessageBox.Show("Withdraw Successful");
                        Uang[userkeberapa] = uangpunyaku - uang;
                    }
                }

                btndep.Visible = true;
                tbxuang.Visible = false;
                tbxuang.Text = "";
                label5.Visible = false;
                label4.Text = "Balance: " + Uang[userkeberapa];
                btnlogout.Visible = true;
            }

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log out Successfully");
            panel1.Visible = false;

        }

        private void tbxuse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
