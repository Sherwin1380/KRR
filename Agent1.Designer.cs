namespace KRR
{
    partial class Agent1
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
            this.label3 = new System.Windows.Forms.Label();
            this.actionTBList = new System.Windows.Forms.Label();
            this.actionTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.actionaddbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "This System accepts mutiple actions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter name of the Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter effect on Fluent1";
            // 
            // actionTBList
            // 
            this.actionTBList.AutoSize = true;
            this.actionTBList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTBList.Location = new System.Drawing.Point(155, 156);
            this.actionTBList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actionTBList.Name = "actionTBList";
            this.actionTBList.Size = new System.Drawing.Size(0, 29);
            this.actionTBList.TabIndex = 3;
            this.actionTBList.Click += new System.EventHandler(this.label4_Click);
            // 
            // actionTB
            // 
            this.actionTB.Location = new System.Drawing.Point(283, 62);
            this.actionTB.Margin = new System.Windows.Forms.Padding(2);
            this.actionTB.Name = "actionTB";
            this.actionTB.Size = new System.Drawing.Size(200, 22);
            this.actionTB.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 328);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // actionaddbutton
            // 
            this.actionaddbutton.Location = new System.Drawing.Point(502, 62);
            this.actionaddbutton.Name = "actionaddbutton";
            this.actionaddbutton.Size = new System.Drawing.Size(75, 23);
            this.actionaddbutton.TabIndex = 9;
            this.actionaddbutton.Text = "Add";
            this.actionaddbutton.UseVisualStyleBackColor = true;
            this.actionaddbutton.Click += new System.EventHandler(this.actionaddbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.actionaddbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.actionTB);
            this.Controls.Add(this.actionTBList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Agent1";
            this.Text = "Agent1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Result_FormClosing);
            this.Load += new System.EventHandler(this.Agent1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label actionTBList;
        private System.Windows.Forms.TextBox actionTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button actionaddbutton;
        private System.Windows.Forms.Button button2;
    }
}