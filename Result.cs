using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace KRR
{
    public partial class Result : Form
    {

        List<string> InitialList = new List<string>();
        Boolean domainstate = true;
        public static Result result;
        public Result()
        {
            InitializeComponent();
            result = this;
        }

        private void display()
        {
           
        }

        private void Result_Load(object sender, EventArgs e)
        {
            display();
        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                domainstate = Agent2.agent2.updateinitial(domainstate);
                InitialList = Agent2.InitialList.ToList();
                if (domainstate)
                checkafter();
                samestate();
            }
            catch
            {
            
            }

            if (!domainstate)
            {
                resultLabel.Text = "THE RESULT IS TRUE" + " - Inconsistent Domain";
                domainstate = true;
                return;
            }
            try
            {
                string query = queryTB.Text.ToString();
                string[] k = query.Split(' ', ',', '=');
                List<string> resultset = new List<string>();

                switch (k[1])
                {
                    case "holds":
                        {
                            string tocheck = k[0];
                            resultset = InitialList.ToList();
                            for (int i = 3; i < k.Length; i++)
                            {
                                foreach (var state in Agent2.states)
                                {
                                    if (state.action.Equals(k[i]) && state.agent.Equals(k[i + 1]))
                                    {
                                        var flag = 0;
                                        foreach (var cond in state.condition)
                                        {
                                            if (!resultset.Contains(cond))
                                            {
                                                flag = 1;
                                            }
                                        }
                                        if (flag == 0)
                                        {
                                            string agh = "";
                                            if (state.fluent[0] == '-')
                                            {
                                                agh = state.fluent.Remove(0, 1);
                                            }
                                            else
                                            {
                                                agh = "-" + state.fluent;
                                            }
                                            if (resultset.Contains(agh))
                                            {
                                                resultset.Remove(agh);
                                                resultset.Add(state.fluent);
                                            }
                                            else if (!resultset.Contains(state.fluent))
                                            {
                                                resultset.Add(state.fluent);
                                            }
                                        }
                                    }
                                }
                            }

                                if (resultset.Contains(tocheck))
                                {
                                    resultLabel.Text = "THE RESULT IS TRUE";
                                }
                                else
                                {
                                    resultLabel.Text = "THE RESULT IS FALSE";
                                }
                                break;
                            }
                      


                    case "is":
                        {
                            resultset = InitialList.ToList();
                            var tofind = k[0];
                            var resultflag = 0;
                            for (int i = 4; i < k.Length; i++)
                            {
                                foreach (var state in Agent2.states)
                                {
                                    if (state.action.Equals(k[i]) && state.agent.Equals(k[i + 1]))
                                    {
                                        var flag = 0;
                                        foreach (var cond in state.condition)
                                        {
                                            if (!resultset.Contains(cond))
                                            {
                                                flag = 1;
                                            }
                                        }
                                        if (flag == 0)
                                        {
                                            if (state.agent.Equals(tofind))
                                                resultflag = 1;
                                            string agh = "";
                                            if (state.fluent[0] == '-')
                                            {
                                                agh = state.fluent.Remove(0, 1);
                                            }
                                            else
                                            {
                                                agh = "-" + state.fluent;
                                            }
                                            if (resultset.Contains(agh))
                                            {
                                                resultset.Remove(agh);
                                                resultset.Add(state.fluent);
                                            }
                                            else if (!resultset.Contains(state.fluent))
                                            {
                                                resultset.Add(state.fluent);
                                            }
                                        }
                                    }
                                }
                            }

                            if (resultflag == 1)
                            {
                                resultLabel.Text = "THE RESULT IS TRUE";
                            }
                            else
                            {
                                resultLabel.Text = "THE RESULT IS FALSE";
                            }

                            break;
                        }

                    default:
                        {
                            MessageBox.Show("Query not in expected Format", "Error");
                            break;
                        }
                }
            }
            catch(Exception ex)
            { 
            
            }
        }

        private void samestate()
        {
            Dictionary<string, string> h = new Dictionary<string, string>();
            foreach (var state in Agent2.states)
            {
                string agh = "";
                if (state.fluent[0] == '-')
                {
                    agh = state.fluent.Remove(0, 1);
                }
                else
                {
                    agh = "-" + state.fluent;
                }
                string find = state.action + state.agent;
                if (h.Keys.Contains(find))
                {
                    if (agh.Equals(h[find]))
                    {
                        domainstate = false;
                    }
                }
                else
                {
                    h.Add(find, state.fluent);
                }
            }
        }

        private void checkafter()
        {
            foreach (var after in Agent2.afterstatements)
            {
                List<string> actions = after.action;
                List<string> incopy = InitialList.ToList();
                foreach (var ac in actions)
                {
                    foreach (var state in Agent2.states)
                    {
                        if (state.agent == after.agent && state.action == ac)
                        {
                            if (state.condition.Count < 1)
                            {
                                string agh = "";
                                if (state.fluent[0] == '-')
                                {
                                    agh = state.fluent.Remove(0, 1);
                                }
                                else
                                {
                                    agh = "-" + state.fluent;
                                }
                                if (incopy.Contains(agh))
                                {
                                    incopy.Remove(agh);
                                    incopy.Add(state.fluent);
                                }
                                else if (!incopy.Contains(state.fluent))
                                {
                                    incopy.Add(state.fluent);
                                }
                            }
                            else
                            {
                                int flag = 0;
                                foreach (var conditions in state.condition)
                                {
                                    if (!incopy.Contains(conditions))
                                    {
                                        flag = 1;
                                        break;
                                    }
                                }
                                if (flag == 0 && Form1.fluentstatelist.Contains(state.fluent))
                                {
                                    string agh = "";
                                    if (state.fluent[0] == '-')
                                    {
                                        agh = state.fluent.Remove(0, 1);
                                    }
                                    else
                                    {
                                        agh = "-" + state.fluent;
                                    }
                                    if (incopy.Contains(agh))
                                    {
                                        incopy.Remove(agh);
                                        incopy.Add(state.fluent);
                                    }
                                    else if (!incopy.Contains(state.fluent))
                                    {
                                        incopy.Add(state.fluent);
                                    }
                                }
                            }
                        }
                }
                }
                if (!incopy.Contains(after.fluent))
                {
                    domainstate = false;
                }

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agent2.agent2.Show();
        }

        private void queryTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
            Form1.form1.Show();
            result.Hide();
            Form1.form1.clear();
            Agent1.agent1.clear();
            Agent2.agent2.clear();
            Agentlist.agentlist.clear();
        }
    }
}
