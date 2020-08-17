using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlinkStickDotNet;

namespace THE_FINAL_TEST_MAYBE
{
    public partial class Form1 : Form
    {
        BlinkStick device;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            device = BlinkStick.FindFirst();
            device.OpenDevice();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void availableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColor("green");
        }

        private void availableToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void awayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColor("Yellow");
        }

        private void busyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColor("red");
        }

        private void inMeetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColor("orange");
        }

        private void bathroomBreakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColor("blue");
        }

        private void languageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buttonAvailable = "Présent";
            string ButtonBusy = "Occupé";
            string ButtonAway = "Absent";
            string ButtonMeeting = "Conférence";
            string ButtonBreak = "Pause";
            string ButtonSetting = "Paramètres";
            string ButtonExit = "Fermer";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buttonAvailable = "Available";
            string ButtonBusy = "Busy";
            string ButtonAway = "Away";
            string ButtonMeeting = "Meeting";
            string ButtonBreak = "Break";
            string ButtonSetting = "Settings";
            string ButtonExit = "Exit";
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buttonAvailable = "verfügbar";
            string ButtonBusy = "Beschäftigt";
            string ButtonAway = "Weg";
            string ButtonMeeting = "Treffen";
            string ButtonBreak = "Pause";
            string ButtonSetting = "Einstellungen";
            string ButtonExit = "Schließen";
        }

        private void powerOffToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            SetColor("black");
        }

        private void OnProcessExit(object sender, EventArgs e)
        {
            /* for (byte i = 0; i < 10; i++)
             {
                 device.SetColor(0, i, 0, 0, 0);
             } */
           // SetColor("black");

        }

        private void SetColor(string Color)
        {
            for (int i = 0; i < 80; i++)
            {
                device.SetColor(0, (byte)(i % 8), Color);
            }
        }
        
        }
    }

