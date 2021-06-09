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
    public partial class Result : Form
    {

        List<string> InitialList = new List<string>();
        public Result()
        {
            InitializeComponent();

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
                string query = queryTB.Text.ToString();
                string[] k = query.Split(' ', ',', '=');
                List<string> resultset = new List<string>();

                switch (k[1])
                {
                    case "holds":
                        {
                            string tocheck = k[0];
                            var checklist = InitialList.ToList();
                            resultset = InitialList.ToList();
                            for (int i = 3; i < k.Length; i++)
                            {
                                foreach (var state in Agent2.states)
                                {
                                    if (state.action.Equals(k[i]) && state.agent.Equals(k[i + 1]))
                                    {
                                        string change = state.fluent;
                                        var condition = state.condition;
                                        string changefactor = change;
                                        if (change[0] == '-')
                                        {
                                            changefactor = change.Remove(0, 1);
                                        }
                                        else
                                        {
                                            changefactor = "-" + change;
                                        }
                                        if (condition.Count == 0)
                                        {
                                            for (int j = 0; j < checklist.Count; j++)
                                            {
                                                if (checklist[j] == changefactor)
                                                {
                                                    resultset[j] = change;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            var flag = true;
                                            foreach (var con in condition)
                                            {
                                                if (!checklist.Contains(con))
                                                    flag = false;
                                            }
                                            if (flag == true)
                                            {
                                                for (int j = 0; j < checklist.Count; j++)
                                                {
                                                    if (checklist[j] == changefactor)
                                                        resultset[j] = change;
                                                }
                                            }
                                        }
                                    }
                                }
                                checklist = resultset.ToList();
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
                            var checklist = InitialList.ToList();
                            resultset = InitialList.ToList();
                            var resultflag = 0;
                            for (int i = 4; i < k.Length; i++)
                            {
                                if (k[i].Equals("by"))
                                    break;
                                foreach (var state in Agent2.states)
                                {
                                    if (state.action.Equals(k[i]) && state.agent.Equals(k[i + 1]))
                                    {
                                        string change = state.fluent;
                                        var condition = state.condition;
                                        string changefactor = change;
                                        if (change[0] == '-')
                                        {
                                            changefactor = change.Remove(0, 1);
                                        }
                                        else
                                        {
                                            changefactor = "-" + change;
                                        }
                                        if (condition.Count == 0)
                                        {
                                            for (int j = 0; j < checklist.Count; j++)
                                            {
                                                if (checklist[j] == changefactor)
                                                {
                                                    resultset[j] = change;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            var flag = true;
                                            foreach (var con in condition)
                                            {
                                                if (!checklist.Contains(con))
                                                    flag = false;
                                            }
                                            if (flag == true)
                                            {
                                                for (int j = 0; j < checklist.Count; j++)
                                                {
                                                    if (checklist[j] == changefactor)
                                                    {
                                                        resultset[j] = change;
                                                        if (state.agent.Equals(k[0]))
                                                            resultflag = 1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                checklist = resultset.ToList();
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

        internal void updatecombo()
        {

            foreach (string action in Form1.fluentstatelist)
            {
                comboBox1.Items.Add(action);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agent2.agent2.Show();
        }

        public void displayinitial()
        {
            string initial = "";
            foreach (var fluent in Form1.fluentstatelist)
            {
                if (fluent[0] != '-')
                {
                    initial = initial + fluent + ",";
                    InitialList.Add(fluent);
                }
            }
            initial = initial.Remove(initial.Length - 1);
            InitialLabel.Text = "Initial State = (" + initial + ")";
        }

        private void queryTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            string tochange = comboBox1.SelectedItem.ToString();
            string find = "";
            if (tochange[0] == '-')
            {
                find = tochange.Remove(0, 1);
            }
            else
            {
                find = "-" + tochange;
            }
            List<string> update = new List<string>();

            update = InitialList.Where(x => !x.Equals(find)).ToList();

            if(!update.Contains(tochange))
            update.Add(tochange);

            InitialList = update.ToList();

            updateinitialstate(update);


        }

        private void updateinitialstate(List<String> Inlist)
        {
            string initial = "";
            foreach (var fluent in Inlist)
            {
                    initial = initial + fluent + ",";
            }
            initial = initial.Remove(initial.Length - 1);
            InitialLabel.Text = "Initial State = (" + initial + ")";
        }
    }
}
