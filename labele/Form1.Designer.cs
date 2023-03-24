
namespace labele
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_desno = new System.Windows.Forms.Button();
            this.button_levo = new System.Windows.Forms.Button();
            this.button_dole = new System.Windows.Forms.Button();
            this.button_gore = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.desno_count = new System.Windows.Forms.Label();
            this.dole_count = new System.Windows.Forms.Label();
            this.gore_count = new System.Windows.Forms.Label();
            this.levo_count = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_location = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button_desno);
            this.panel1.Controls.Add(this.button_levo);
            this.panel1.Controls.Add(this.button_dole);
            this.panel1.Controls.Add(this.button_gore);
            this.panel1.Location = new System.Drawing.Point(1, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 125);
            this.panel1.TabIndex = 0;
            // 
            // button_desno
            // 
            this.button_desno.Location = new System.Drawing.Point(448, 28);
            this.button_desno.Name = "button_desno";
            this.button_desno.Size = new System.Drawing.Size(74, 50);
            this.button_desno.TabIndex = 5;
            this.button_desno.Text = "Desno";
            this.button_desno.UseVisualStyleBackColor = true;
            this.button_desno.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_levo
            // 
            this.button_levo.Location = new System.Drawing.Point(278, 28);
            this.button_levo.Name = "button_levo";
            this.button_levo.Size = new System.Drawing.Size(74, 50);
            this.button_levo.TabIndex = 4;
            this.button_levo.Text = "Levo";
            this.button_levo.UseVisualStyleBackColor = true;
            this.button_levo.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_dole
            // 
            this.button_dole.Location = new System.Drawing.Point(358, 57);
            this.button_dole.Name = "button_dole";
            this.button_dole.Size = new System.Drawing.Size(84, 50);
            this.button_dole.TabIndex = 3;
            this.button_dole.Text = "Dole";
            this.button_dole.UseVisualStyleBackColor = true;
            this.button_dole.Click += new System.EventHandler(this.button_dole_Click);
            // 
            // button_gore
            // 
            this.button_gore.Location = new System.Drawing.Point(358, 3);
            this.button_gore.Name = "button_gore";
            this.button_gore.Size = new System.Drawing.Size(84, 48);
            this.button_gore.TabIndex = 2;
            this.button_gore.Text = "Gore";
            this.button_gore.UseVisualStyleBackColor = true;
            this.button_gore.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label_location);
            this.panel2.Controls.Add(this.desno_count);
            this.panel2.Controls.Add(this.dole_count);
            this.panel2.Controls.Add(this.gore_count);
            this.panel2.Controls.Add(this.levo_count);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 527);
            this.panel2.TabIndex = 1;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // desno_count
            // 
            this.desno_count.AutoSize = true;
            this.desno_count.Location = new System.Drawing.Point(3, 75);
            this.desno_count.Name = "desno_count";
            this.desno_count.Size = new System.Drawing.Size(50, 13);
            this.desno_count.TabIndex = 9;
            this.desno_count.Text = "Desno: 0";
            this.desno_count.Click += new System.EventHandler(this.desno_count_Click);
            // 
            // dole_count
            // 
            this.dole_count.AutoSize = true;
            this.dole_count.Location = new System.Drawing.Point(12, 31);
            this.dole_count.Name = "dole_count";
            this.dole_count.Size = new System.Drawing.Size(41, 13);
            this.dole_count.TabIndex = 8;
            this.dole_count.Text = "Dole: 0";
            // 
            // gore_count
            // 
            this.gore_count.AutoSize = true;
            this.gore_count.Location = new System.Drawing.Point(11, 9);
            this.gore_count.Name = "gore_count";
            this.gore_count.Size = new System.Drawing.Size(42, 13);
            this.gore_count.TabIndex = 7;
            this.gore_count.Text = "Gore: 0";
            this.gore_count.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // levo_count
            // 
            this.levo_count.AutoSize = true;
            this.levo_count.Location = new System.Drawing.Point(10, 53);
            this.levo_count.Name = "levo_count";
            this.levo_count.Size = new System.Drawing.Size(43, 13);
            this.levo_count.TabIndex = 6;
            this.levo_count.Text = "Levo: 0";
            this.levo_count.Click += new System.EventHandler(this.levo_count_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(432, 160);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 13);
            this.label.TabIndex = 6;
            this.label.Text = "djole";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(127, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 399);
            this.panel3.TabIndex = 2;
            this.panel3.Resize += new System.EventHandler(this.panel3_Resize);
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(18, 100);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(44, 13);
            this.label_location.TabIndex = 10;
            this.label_location.Text = "x: 0 y: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(835, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_desno;
        private System.Windows.Forms.Button button_levo;
        private System.Windows.Forms.Button button_dole;
        private System.Windows.Forms.Button button_gore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label levo_count;
        private System.Windows.Forms.Label gore_count;
        private System.Windows.Forms.Label desno_count;
        private System.Windows.Forms.Label dole_count;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_location;
    }
}

