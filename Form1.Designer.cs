namespace KRR
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fluent1TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fluentlistlabel = new System.Windows.Forms.Label();
            this.addfluentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the name of the Fluent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "LIST OF FLUENTS";
            // 
            // fluent1TB
            // 
            this.fluent1TB.Location = new System.Drawing.Point(289, 83);
            this.fluent1TB.Margin = new System.Windows.Forms.Padding(2);
            this.fluent1TB.Name = "fluent1TB";
            this.fluent1TB.Size = new System.Drawing.Size(152, 20);
            this.fluent1TB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "This System accepts multiple fluents";
            // 
            // fluentlistlabel
            // 
            this.fluentlistlabel.AutoSize = true;
            this.fluentlistlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluentlistlabel.Location = new System.Drawing.Point(141, 175);
            this.fluentlistlabel.Name = "fluentlistlabel";
            this.fluentlistlabel.Size = new System.Drawing.Size(0, 29);
            this.fluentlistlabel.TabIndex = 6;
            // 
            // addfluentbutton
            // 
            this.addfluentbutton.Location = new System.Drawing.Point(469, 83);
            this.addfluentbutton.Name = "addfluentbutton";
            this.addfluentbutton.Size = new System.Drawing.Size(75, 23);
            this.addfluentbutton.TabIndex = 7;
            this.addfluentbutton.Text = "Add";
            this.addfluentbutton.UseVisualStyleBackColor = true;
            this.addfluentbutton.Click += new System.EventHandler(this.addfluentbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.addfluentbutton);
            this.Controls.Add(this.fluentlistlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fluent1TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fluent1TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fluentlistlabel;
        private System.Windows.Forms.Button addfluentbutton;
    }
}

