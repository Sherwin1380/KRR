using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRR
{
    public partial class Agent1 : Form
    {
        Agentlist agentlist = new Agentlist(); 
        public static List<string> actionlist = new List<string>();


        public static Agent1 agent1;
        public Agent1()
        {
            InitializeComponent();
            agent1 = this;
            //actionlist.Add("MAKE");
            //actionlist.Add("DRINK");
            //actionlist.Add("LOAD");
            //actionlist.Add("DRIVE");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (actionlist.Count > 0)
            {
                agentlist.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Atleast one actions needed to continue", "Error");
            }
        }

        private void Agent1_Load(object sender, EventArgs e)
        {

        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void actionaddbutton_Click(object sender, EventArgs e)
        {
            var action = actionTB.Text.ToString();
            if (actionlist.Contains(action))
            {
                MessageBox.Show("Action is already present", "Error");
                actionTB.Text = "";
            }
            else if (!action.Equals(""))
            {
                actionlist.Add(action);
                actionTBList.Text = actionTBList.Text.ToString() + action + System.Environment.NewLine;
                actionTB.Text = "";
            }
            else
            {
                MessageBox.Show("Action is empty", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.form1.Show();
            this.Hide();
        }
    }
}
