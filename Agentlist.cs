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
    public partial class Agentlist : Form
    {
        Agent2 agent2 = new Agent2();
        public static List<string> agentslist = new List<string>();


        public static Agentlist agentlist;

        public Agentlist()
        {
            InitializeComponent();
            agentlist = this;
            //agentslist.Add("Michael");
            //agentslist.Add("Jill");
            //agentslist.Add("Ken");
            //agentslist.Add("Sasha");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addagentbutton_Click(object sender, EventArgs e)
        {

            var agent = agentTB.Text.ToString();
            if (agentslist.Contains(agent))
            {
                MessageBox.Show("Agent is already present", "Error");
                agentTB.Text = "";
            }
            else if (!agent.Equals(""))
            {
                agentslist.Add(agent);
                agentlistlabel.Text = agentlistlabel.Text.ToString() + agent + System.Environment.NewLine;
                agentTB.Text = "";
            }
            else
            {
                MessageBox.Show("Agent is empty", "Error");
            }
        }

        private void NEXTbutton_Click(object sender, EventArgs e)
        {

            if (agentslist.Count > 0)
            {
                agent2.Show();
                this.Hide();
                agent2.updatecombo();
            }
            else
            {
                MessageBox.Show("Atleast one actions needed to continue", "Error");
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agent1.agent1.Show();
        }


        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Agentlist_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            agentslist.Clear();
            agentlistlabel.Text = "";
        }
    }
}
