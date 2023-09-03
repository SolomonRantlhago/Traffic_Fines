using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Traffic_fines
{
    public partial class CfrmTraffic_Fines : Form
    {
        public CfrmTraffic_Fines()
        {
            InitializeComponent();
        }

        private string Getoffence(string sPrompt)
        {
            return Interaction.InputBox(sPrompt,"Traffic Offence");
        }

        private decimal GetspeedFine(int iDriverspeed)
        {
            if(iDriverspeed>=1 && iDriverspeed <= 10)
            {
                return 0;
            }
            else
            {
                if(iDriverspeed >= 11 && iDriverspeed <= 15)
                {
                    return 250;
                }
                else
                {
                    if(iDriverspeed >= 16 && iDriverspeed <= 20)
                    {
                        return 500;
                    }
                    else
                    {
                        if(iDriverspeed >= 21 && iDriverspeed <= 25)
                        {
                            return 750;
                        }
                        else
                        {
                            if(iDriverspeed >= 26 && iDriverspeed <= 30)
                            {
                                return 1000;
                            }
                            else
                            {
                                if(iDriverspeed >= 31 && iDriverspeed <= 35)
                                {
                                    return 1250;
                                }
                                else
                                {
                                    if(iDriverspeed >= 36 && iDriverspeed <= 40)
                                    {
                                        return 1500;
                                    }
                                    else
                                    {
                                        return 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            
        }

        private void radSpeeding_Click(object sender, EventArgs e)
        {
            if (radSpeeding.Checked)
            {
                int idriverspeed = 0;
                int ispeedlimit = 0;
                bool isTrue = false;
                do
                {
                    isTrue = int.TryParse(Getoffence("Driver's Speed (Km/h)"), out idriverspeed);
                }
                while (!isTrue);


                do
                {
                    isTrue = int.TryParse(Getoffence("Speed limit (Km/h)"), out ispeedlimit);
                }
                while (!isTrue);

                int iExcessspeed = idriverspeed - ispeedlimit;

                if (iExcessspeed > 0)
                {
                    decimal mspeedfine = GetspeedFine(iExcessspeed);
                    MessageBox.Show("Name: " + txtinitialsSurname.Text + "\nID: " + txtIDNum.Text + "\nRegistration: " + txtVehReg.Text + "\nFine: " + mspeedfine.ToString("C") +
                  "\nExcessive speed: " + iExcessspeed.ToString());
                }
                else
                {
                    MessageBox.Show("Name: " + txtinitialsSurname.Text + "\nID: " + txtIDNum.Text + "\nRegistration: " + txtVehReg.Text + "\nFine:NO " +
                "\nExcessive speed: " + 0);
                }

                

              
            }
            else
            {
                string sDescription = Getoffence("Description of Traffic offence");

                MessageBox.Show("Name: " + txtinitialsSurname.Text + "\nID: " + txtIDNum.Text + "\nRegistration: " + txtVehReg.Text + "\nFine:R 300.00 " +
                   "\nOffence: " + sDescription);


            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtinitialsSurname.Clear();
            txtIDNum.Clear();
            txtVehReg.Clear();

            radSpeeding.Checked = radOthers.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
