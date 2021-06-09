using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace KRR
{
    public partial class Agent2 : Form
    {
        Result result = new Result();

        public static List<State> states = new List<State>();
        public static List<string> condition1 = new List<string>();

        public static Agent2 agent2;
        public Agent2()
        {
            InitializeComponent();
            conditioncomboBox.Items.Add("");
            actioncomboBox.Items.Add("");
            agent2 = this;

            //State state1 = new State { action = "MAKE", agent = "Michael", fluent = "full", condition = "" };
            //State state2 = new State { action = "DRINK", agent = "Jill", fluent = "-full", condition = "" };
            //State state3 = new State { action = "DRINK", agent = "Jill", fluent = "drank", condition = "full" };

            //states.Add(state1);
            //states.Add(state2);
            //states.Add(state3);

            //State state1 = new State { action = "LOAD", agent = "Ken", fluent = "loaded", condition = "" };
            //State state2 = new State { action = "DRIVE", agent = "Sasha", fluent = "-loaded", condition = "" };
            //State state3 = new State { action = "DRIVE", agent = "Sasha", fluent = "delivered", condition = "loaded" };

            //states.Add(state1);
            //states.Add(state2);
            //states.Add(state3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Agent ag = new Agent();

                if (ag.agentname != "" && ag.agentaction != "" && ( ag.agenteffectonfluent1 != "" || ag.agenteffectonfluent2 != ""))
                {
                    this.Hide();
                    result.Show();
                }
                else
                {
                    MessageBox.Show("Enter required fields", "Agent1Details");
                }

            }
            catch { }
        }

        public void updatecombo()
        {
            actioncomboBox.Items.Clear();
            fluentcomboBox.Items.Clear();
            agentcomboBox.Items.Clear();
            conditioncomboBox.Items.Clear();
            actioncomboBox2.Items.Clear();
            fluentcomboBox2.Items.Clear();
            agentcomboBox2.Items.Clear();

            andcomboBox.Items.Add("");
            conditioncomboBox.Items.Add("");


            foreach (string action in Agent1.actionlist)
            {
                actioncomboBox.Items.Add(action);
                actioncomboBox2.Items.Add(action);
            }
            actioncomboBox.SelectedIndex = 0;
            actioncomboBox2.SelectedIndex = 0;

            foreach (string action in Form1.fluentstatelist)
            {
                conditioncomboBox.Items.Add(action);
                andcomboBox.Items.Add(action);
            }
            conditioncomboBox.SelectedIndex = 0;
            andcomboBox.SelectedIndex = 0;

            foreach (string action in Form1.fluentstatelist)
            {
                fluentcomboBox.Items.Add(action);
                fluentcomboBox2.Items.Add(action);
            }
            fluentcomboBox.SelectedIndex = 0;
            fluentcomboBox2.SelectedIndex = 0;

            foreach (string action in Agentlist.agentslist)
            {
                agentcomboBox.Items.Add(action);
                agentcomboBox2.Items.Add(action);
            }
            agentcomboBox.SelectedIndex = 0;
            agentcomboBox2.SelectedIndex = 0;
        }

        private void agent2fluent1TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agent2_Load(object sender, EventArgs e)
        {

        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string action = actioncomboBox.SelectedItem.ToString();
            string agent = agentcomboBox.SelectedItem.ToString();
            string fluent = fluentcomboBox.SelectedItem.ToString();
            string condition = conditioncomboBox.SelectedItem.ToString();
            int flag = 0;

            foreach (var statevalue in states)
            {
                if (statevalue.action == action && statevalue.agent == agent && statevalue.fluent == fluent)
                {
                    if(condition!="" && !condition1.Contains(condition))
                    condition1.Add(condition);

                    bool boolflag = Enumerable.SequenceEqual(condition1.OrderBy(ec => ec), statevalue.condition.OrderBy(ec => ec));
                    if (boolflag)
                        flag = 1;
                }
            }

            if (flag == 0)
            {
                if (condition != "")
                {
                    if (!condition1.Contains(condition))
                        condition1.Add(condition);
                }
                State state = new State { action = action, agent = agent, condition = condition1.ToList(), fluent = fluent };
                states.Add(state);

                storyLabel.Text = storyLabel.Text.ToString() + action + " by " + agent + " causes " + fluent + " ";
                if (condition!="")
                {
                    storyLabel.Text = storyLabel.Text.ToString() + " if " + condition + " ";
                }
                foreach (var t in condition1)
                {
                    if (!t.Equals(condition))
                    {
                        storyLabel.Text = storyLabel.Text.ToString() + " AND " + t;
                    }
                }
                storyLabel.Text = storyLabel.Text.ToString() + Environment.NewLine;
                condition1.Clear();
                andLabel.Text = "";
            }
            else
            {
                MessageBox.Show("Already present", "Error");
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agentlist.agentlist.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Show();
            this.Hide();
            result.displayinitial();
            result.updatecombo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string action = actioncomboBox2.SelectedItem.ToString();
            string agent = agentcomboBox2.SelectedItem.ToString();
            string fluent = fluentcomboBox2.SelectedItem.ToString();
            int flag = 0;

            foreach (var statevalue in states)
            {
                if (statevalue.action == action && statevalue.agent == agent && statevalue.fluent == fluent)
                {
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                State state = new State { action = action, agent = agent, fluent = fluent , condition = new List<string>() };
                states.Add(state);

                storyLabel.Text = storyLabel.Text.ToString() + fluent + " after " + action + " by " + agent + " ";
                storyLabel.Text = storyLabel.Text.ToString() + Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Already present", "Error");
            }
        }

        private void andLabel_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string andcond = andcomboBox.SelectedItem.ToString();
            if (andcond != "" && !condition1.Contains(andcond))
            {
                condition1.Add(andcond);
                andLabel.Text = andLabel.Text.ToString() + "AND" + andcond + Environment.NewLine;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            condition1.Clear();
            andLabel.Text = "";
        }
    }
}
