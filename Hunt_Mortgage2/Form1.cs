using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hunt_Mortgage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            finumLabel.Visible = false;
            mptxt.Visible = false;

            sPTxtb.Text = "";
            sIntrCb.Text = "";
            sOrbTxtb.Text = "";

            b15rb.Checked = false;
            b30rb.Checked = false;
            bOrb.Checked = false;

            RstBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            finumLabel.Visible = false;
            mptxt.Visible = false;

            sPTxtb.Text = "";
            sIntrCb.Text = "";
            sOrbTxtb.Text = "";

            b15rb.Checked = false;
            b30rb.Checked = false;
            bOrb.Checked = false;

            RstBtn.Enabled = false;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            bool Pgo = false;
            bool RBgo = false;
            bool Ogo = false;
            bool INgo = false;

            double tiy = 0;
            double x = 0;
            bool pisNum = double.TryParse(sPTxtb.Text, out x);
            bool oisNum = double.TryParse(sOrbTxtb.Text, out x);
            bool noErr = false;
            if (pisNum == false)
            {
                noErr = false;
                sPErr.Visible = true;
            }else { Pgo = true; }
            if (b15rb.Checked == false && b30rb.Checked == false && bOrb.Checked == false)
            {
                noErr = false;
                stiyErr.Visible = true;
            }else { RBgo = true; }
            if (bOrb.Checked == true && oisNum == false)
            {
                noErr = false;
                sOrbErr.Visible = true;
            }else { Ogo = true; }
            if (sIntrCb.Text == "")
            {
                noErr = false;
                sintrErr.Visible = true;
            }else { INgo = true; }

            if (Pgo && RBgo && Ogo && INgo)
            {
                noErr = true;
            }

            if (noErr == true)
            {
                if (b15rb.Checked == true)
                {
                    tiy = 15;
                }
                if (b30rb.Checked == true)
                {
                    tiy = 30;
                }
                if (bOrb.Checked == true)
                {
                    tiy = double.Parse(sOrbTxtb.Text);
                }

                sPErr.Visible = false;
                stiyErr.Visible = false;
                sOrbErr.Visible = false;
                sintrErr.Visible = false;

                double p = double.Parse(sPTxtb.Text);
                double t = tiy;
                double i = double.Parse(sIntrCb.Text);

                double finPrice = 0;

                double r = i / 100;
                double nt = 12 * t;

                double upper = p * (r / 12);
                double lower = 1 + (r / 12);
                finPrice = upper / (1 - (Math.Pow(lower, -nt)));

                finumLabel.Text = finPrice.ToString("C2");
                mptxt.Visible = true;
                finumLabel.Visible = true;

                RstBtn.Enabled = true;
            }
        }

        private void bOrb_CheckedChanged(object sender, EventArgs e)
        {
            if (bOrb.Checked == true)
            {
                bOrb.Text = "Other";
                sOrbTxtb.Visible = true;
            }else
            {
                bOrb.Text = "Other...";
                sOrbTxtb.Visible = false;
            }
        }

        private void RstBtn_Click(object sender, EventArgs e)
        {
            finumLabel.Visible = false;
            mptxt.Visible = false;

            sPTxtb.Text = "";
            sIntrCb.Text = "";
            sOrbTxtb.Text = "";

            b15rb.Checked = false;
            b30rb.Checked = false;
            bOrb.Checked = false;

            RstBtn.Enabled = false;
        }

        private void finumTxt_Click(object sender, EventArgs e)
        {
            
        }
    }
}
