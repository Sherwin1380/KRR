namespace KRR
{
    partial class Agentlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.agentlistlabel = new System.Windows.Forms.Label();
            this.agentTB = new System.Windows.Forms.TextBox();
            this.addagentbutton = new System.Windows.Forms.Button();
            this.NEXTbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the name of the Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "LIST OF AGENTS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // agentlistlabel
            // 
            this.agentlistlabel.AutoSize = true;
            this.agentlistlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentlistlabel.Location = new System.Drawing.Point(172, 183);
            this.agentlistlabel.Name = "agentlistlabel";
            this.agentlistlabel.Size = new System.Drawing.Size(0, 29);
            this.agentlistlabel.TabIndex = 2;
            // 
            // agentTB
            // 
            this.agentTB.Location = new System.Drawing.Point(328, 59);
            this.agentTB.Name = "agentTB";
            this.agentTB.Size = new System.Drawing.Size(315, 20);
            this.agentTB.TabIndex = 3;
            // 
            // addagentbutton
            // 
            this.addagentbutton.Location = new System.Drawing.Point(677, 59);
            this.addagentbutton.Name = "addagentbutton";
            this.addagentbutton.Size = new System.Drawing.Size(75, 23);
            this.addagentbutton.TabIndex = 4;
            this.addagentbutton.Text = "ADD";
            this.addagentbutton.UseVisualStyleBackColor = true;
            this.addagentbutton.Click += new System.EventHandler(this.addagentbutton_Click);
            // 
            // NEXTbutton
            // 
            this.NEXTbutton.Location = new System.Drawing.Point(677, 392);
            this.NEXTbutton.Name = "NEXTbutton";
            this.NEXTbutton.Size = new System.Drawing.Size(75, 23);
            this.NEXTbutton.TabIndex = 5;
            this.NEXTbutton.Text = "NEXT";
            this.NEXTbutton.UseVisualStyleBackColor = true;
            this.NEXTbutton.Click += new System.EventHandler(this.NEXTbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(570, 391);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 6;
            this.backbutton.Text = "BACK";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Agentlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.NEXTbutton);
            this.Controls.Add(this.addagentbutton);
            this.Controls.Add(this.agentTB);
            this.Controls.Add(this.agentlistlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agentlist";
            this.Text = "Agentlist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Result_FormClosing);
            this.Load += new System.EventHandler(this.Agentlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label agentlistlabel;
        private System.Windows.Forms.TextBox agentTB;
        private System.Windows.Forms.Button addagentbutton;
        private System.Windows.Forms.Button NEXTbutton;
        private System.Windows.Forms.Button backbutton;
    }
}