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
    public partial class Form1 : Form
    {
        Agent1 agent1window = new Agent1();
        public static List<string> fluentlist = new List<string>();
        public static List<string> fluentstatelist = new List<string>();
        
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (fluentlist.Count > 0)
            {
                agent1window.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Atleast one fluents needed to continue", "Error");
            }
        }

        private void addfluentbutton_Click(object sender, EventArgs e)
        {
            var fluent = fluent1TB.Text.ToString();
            if (fluentlist.Contains(fluent))
            {
                MessageBox.Show("Fluent is already present", "Error");
                fluent1TB.Text = "";
            }
            else if (!fluent.Equals(""))
            {
                fluentlist.Add(fluent);
                fluentstatelist.Add(fluent);
                fluentstatelist.Add("-" + fluent);
                fluentlistlabel.Text = fluentlistlabel.Text.ToString() + fluent + System.Environment.NewLine;
                fluent1TB.Text = "";
            }
            else
            {
                MessageBox.Show("Fluent is empty", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            fluentlist.Clear();
            fluentstatelist.Clear();
            fluentlistlabel.Text = "";
        }
    }
}
