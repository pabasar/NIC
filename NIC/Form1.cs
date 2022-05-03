using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NICLibrary;

namespace NIC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        int numOfPersons = 0;

        string nicNumber,gndr,yr,vt;

        NICLibrary.NICOperations nl= new NICLibrary.NICOperations();

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtNIC.Text = "";
            txtGender.Text = "";
            txtDOB.Text = "";
            txtVote.Text = "";

            txtNIC.Focus();
            btnNext.Enabled = false;

            numOfPersons++;
        }

        

        private void Enter_KeyUp(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter && txtNIC.Text != "")
            {
                nicNumber = txtNIC.Text;

                if(nicNumber.Length == 10 || nicNumber.Length == 12)
                {
                    nicNumber = nl.NICFormat(nicNumber);
                    gndr = nl.GenderCheck(nicNumber);
                    vt = nl.VoteCheck(nicNumber);
                    yr = nl.DayCheck(nicNumber);

                    txtGender.Text = gndr;
                    txtDOB.Text = yr;
                    txtVote.Text = vt;
                }
                else
                {
                    MessageBox.Show("Invalid NIC!");
                }          

                btnNext.Enabled = true;
                btnNext.Focus();

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnNext.PerformClick();
        }
    }
}
