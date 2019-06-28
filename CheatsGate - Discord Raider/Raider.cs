using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace CheatsGate___Discord_Raider
{
    public partial class Raider : MetroFramework.Forms.MetroForm
    {
        public static string invite;
        public static string message;
        public static string channelid;
        public static string empty = string.Empty;

        public Raider()
        {
            InitializeComponent();
        }

        private void RaidBtn_Click(object sender, EventArgs e)
        {
            if (Message_Send.Text == empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "You can't send an Empty message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Invite_ID.Text == empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please provide a correct Invite ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Channel_ID.Text == empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please provide a correct Channel ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            RaidTimer.Start();
        }

        private void RaidTimer_Tick(object sender, EventArgs e)
        {
            
            invite = Invite_ID.Text;
            channelid = Channel_ID.Text;
            message = Message_Send.Text;


            string currd = Directory.GetCurrentDirectory();
            string[] tokens = File.ReadAllLines(currd + @"/tokens.txt");

            foreach (string i in tokens) { RaidFunctions.funcs.joinguild(i, invite, false, null); } // joins srv

            foreach (string i in tokens)
            {
                RaidFunctions.funcs.sendmessage(i, channelid, "**[uwu'ed - sowwy :s]** "+message, false, false); // send msg 
            }

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            RaidTimer.Stop();
        }

        private void Raider_Load(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            invite = Invite_ID.Text;
        
            string currd = Directory.GetCurrentDirectory();
            string[] tokens = File.ReadAllLines(currd + @"/tokens.txt");

            foreach (string i in tokens) { RaidFunctions.funcs.joinguild(i, invite, false, null); } // joins srv
        }
    }
}
