namespace NoughtsAndCrosses
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
            this.startbutton = new System.Windows.Forms.Button();
            this.p2name = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p1name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(291, 279);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(127, 33);
            this.startbutton.TabIndex = 2;
            this.startbutton.Text = "Start! Epic!";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // p2name
            // 
            this.p2name.Location = new System.Drawing.Point(291, 189);
            this.p2name.Name = "p2name";
            this.p2name.Size = new System.Drawing.Size(127, 20);
            this.p2name.TabIndex = 3;
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(151, 135);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(91, 13);
            this.p1.TabIndex = 4;
            this.p1.Text = "Player 1 (Crosses)";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(151, 192);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(94, 13);
            this.p2.TabIndex = 5;
            this.p2.Text = "Player 2 (Noughts)";
            // 
            // p1name
            // 
            this.p1name.Location = new System.Drawing.Point(291, 132);
            this.p1name.Name = "p1name";
            this.p1name.Size = new System.Drawing.Size(127, 20);
            this.p1name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "Epic!!!1! Game!1!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1name);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p2name);
            this.Controls.Add(this.startbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.TextBox p2name;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.TextBox p1name;
        private System.Windows.Forms.Label label1;
    }
}

