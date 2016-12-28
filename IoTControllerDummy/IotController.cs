using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTControllerDummy
{
    public partial class IotController : Form
    {
        public IotController()
        {
            InitializeComponent();
            btnDoorSwitch.BackColor = Color.Gray;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabDeliver);
            btnDoorSwitch.BackColor = Color.Gray;
            txtDeliveryId.Text = "";
            txtHelpText.Text = "\nLegg inn en leveringsKode i feltet over og trykk \"Lever\"";
            chkMainLock.Checked = true;
            chkWeight.Checked = false;
            chkCamera.Checked = false;
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabInstall);
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            Console.Beep();
            if(txtDeliveryId.TextLength < 2)
            {
               
                txtHelpText.Text = "\nDu må legge inn en leveringsKode";
                return;
            }

            chkMainLock.Checked = false;
            chkWeight.Checked = false;
            chkCamera.Checked = false;
           
            txtHelpText.Text = "\nÅpne døren, sett inn varene!";
            timerSimulateAddPackage.Enabled = true;
        }

        private void timerSimulateAddPackage_Tick(object sender, EventArgs e)
        {
            Console.Beep();
            chkWeight.Checked = true;
            timerSimulateAddPackage.Enabled = false;
            txtHelpText.Text = "\nLukk døren og vent på kvittering\n\nKlikk på 'Lukk døra'";
            btnDoorSwitch.BackColor = Color.Red;
        }

        private void timerSimulateGenerateReciepe_Tick(object sender, EventArgs e)
        {
            Console.Beep();
            chkCamera.Checked = true;
            timerSimulateGenerateReciepe.Enabled = false;
            timerSendLogEntry.Enabled = true;

        }

        private void btnDoorSwitch_Click(object sender, EventArgs e)
        {
            btnDoorSwitch.BackColor = Color.LightGray;
            chkMainLock.Checked = true;
            timerSimulateGenerateReciepe.Enabled = true;
        }

        private void timerSendLogEntry_Tick(object sender, EventArgs e)
        {
            Console.Beep();
            timerSendLogEntry.Enabled = false;

            var guid = Guid.NewGuid();
            txtHelpText.Text = "\nDin kvitteringskode for leveringsKode: " + txtDeliveryId.Text + "\n\ner: " + guid.ToString() + "\n\nTa bilde av skjermen for din kvittering.";
        }

    }
}
