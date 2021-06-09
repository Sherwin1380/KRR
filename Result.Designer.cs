namespace KRR
{
    partial class Result
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.queryTB = new System.Windows.Forms.TextBox();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.InitialLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changebutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your Query Here";
            // 
            // queryTB
            // 
            this.queryTB.Location = new System.Drawing.Point(69, 71);
            this.queryTB.Name = "queryTB";
            this.queryTB.Size = new System.Drawing.Size(532, 22);
            this.queryTB.TabIndex = 2;
            this.queryTB.Text = "drank holds after MAKE-Michael,DRINK-Jill,MAKE-Micahel,DRINK-Jill";
            this.queryTB.TextChanged += new System.EventHandler(this.queryTB_TextChanged);
            // 
            // calculatebutton
            // 
            this.calculatebutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.calculatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatebutton.Location = new System.Drawing.Point(257, 113);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(146, 38);
            this.calculatebutton.TabIndex = 3;
            this.calculatebutton.Text = "CALCULATE";
            this.calculatebutton.UseVisualStyleBackColor = false;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "RESULT";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(95, 321);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 39);
            this.resultLabel.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(555, 371);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // InitialLabel
            // 
            this.InitialLabel.AutoSize = true;
            this.InitialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialLabel.Location = new System.Drawing.Point(30, 202);
            this.InitialLabel.Name = "InitialLabel";
            this.InitialLabel.Size = new System.Drawing.Size(145, 25);
            this.InitialLabel.TabIndex = 7;
            this.InitialLabel.Text = "Initial State = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "CHANGE INITIAL STATE FLUENT:";
            // 
            // changebutton
            // 
            this.changebutton.Location = new System.Drawing.Point(428, 164);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(135, 23);
            this.changebutton.TabIndex = 9;
            this.changebutton.Text = "CHANGE";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // Result
            // 
            this.ClientSize = new System.Drawing.Size(670, 423);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InitialLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.queryTB);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "STATE CALCULATIONS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Result_FormClosing);
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox queryTB;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label InitialLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}