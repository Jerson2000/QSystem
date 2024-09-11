namespace QSystem.UserControls
{
    partial class Queue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbStats = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSched = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbApp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbQNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.noQToday = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbNoQ2Day = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.noQToday.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 474);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton1.BackColor = System.Drawing.Color.Aqua;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(863, 65);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(142, 49);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Next";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(10, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1007, 341);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lbStats);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lbSched);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.lbAge);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lbApp);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.lbSex);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.lbName);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(8, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(987, 321);
            this.panel5.TabIndex = 0;
            // 
            // lbStats
            // 
            this.lbStats.AutoSize = true;
            this.lbStats.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.lbStats.Location = new System.Drawing.Point(892, 19);
            this.lbStats.Name = "lbStats";
            this.lbStats.Size = new System.Drawing.Size(59, 28);
            this.lbStats.TabIndex = 0;
            this.lbStats.Tag = "Status";
            this.lbStats.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.label5.Location = new System.Drawing.Point(825, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // lbSched
            // 
            this.lbSched.AutoSize = true;
            this.lbSched.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.lbSched.Location = new System.Drawing.Point(100, 19);
            this.lbSched.Name = "lbSched";
            this.lbSched.Size = new System.Drawing.Size(79, 28);
            this.lbSched.TabIndex = 0;
            this.lbSched.Text = "Schedule";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.label11.Location = new System.Drawing.Point(10, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Schedule:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Underline);
            this.lbAge.Location = new System.Drawing.Point(556, 109);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(40, 28);
            this.lbAge.TabIndex = 0;
            this.lbAge.Tag = "Age";
            this.lbAge.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.label7.Location = new System.Drawing.Point(489, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Age:";
            // 
            // lbApp
            // 
            this.lbApp.AutoSize = true;
            this.lbApp.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Underline);
            this.lbApp.Location = new System.Drawing.Point(556, 203);
            this.lbApp.Name = "lbApp";
            this.lbApp.Size = new System.Drawing.Size(107, 28);
            this.lbApp.TabIndex = 0;
            this.lbApp.Tag = "Request App";
            this.lbApp.Text = "Request App";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.label13.Location = new System.Drawing.Point(365, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "Request Application:";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Underline);
            this.lbSex.Location = new System.Drawing.Point(120, 203);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(66, 28);
            this.lbSex.TabIndex = 0;
            this.lbSex.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.label12.Location = new System.Drawing.Point(53, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "Gender:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Underline);
            this.lbName.Location = new System.Drawing.Point(120, 109);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(61, 28);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.label3.Location = new System.Drawing.Point(53, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lbQNo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(284, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 89);
            this.panel3.TabIndex = 1;
            // 
            // lbQNo
            // 
            this.lbQNo.AutoSize = true;
            this.lbQNo.Font = new System.Drawing.Font("Sitka Display", 45F);
            this.lbQNo.ForeColor = System.Drawing.Color.Red;
            this.lbQNo.Location = new System.Drawing.Point(187, -6);
            this.lbQNo.Name = "lbQNo";
            this.lbQNo.Size = new System.Drawing.Size(59, 87);
            this.lbQNo.TabIndex = 0;
            this.lbQNo.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 30F);
            this.label1.Location = new System.Drawing.Point(64, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 142);
            this.panel2.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(605, 6);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(149, 59);
            this.iconButton3.TabIndex = 0;
            this.iconButton3.Text = "Mark as Done";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(194, 6);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(149, 59);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "Mark as Cancel";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // noQToday
            // 
            this.noQToday.Controls.Add(this.iconButton4);
            this.noQToday.Controls.Add(this.panel6);
            this.noQToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noQToday.Location = new System.Drawing.Point(0, 0);
            this.noQToday.Name = "noQToday";
            this.noQToday.Size = new System.Drawing.Size(1030, 474);
            this.noQToday.TabIndex = 1;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(33, 31);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(144, 46);
            this.iconButton4.TabIndex = 2;
            this.iconButton4.Text = "Refresh";
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lbNoQ2Day);
            this.panel6.Location = new System.Drawing.Point(0, 133);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1027, 197);
            this.panel6.TabIndex = 1;
            // 
            // lbNoQ2Day
            // 
            this.lbNoQ2Day.AutoSize = true;
            this.lbNoQ2Day.BackColor = System.Drawing.Color.Transparent;
            this.lbNoQ2Day.Font = new System.Drawing.Font("Sitka Display", 75F);
            this.lbNoQ2Day.Location = new System.Drawing.Point(67, 24);
            this.lbNoQ2Day.Name = "lbNoQ2Day";
            this.lbNoQ2Day.Size = new System.Drawing.Size(864, 145);
            this.lbNoQ2Day.TabIndex = 0;
            this.lbNoQ2Day.Text = "No Queue for Today.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.noQToday);
            this.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Queue";
            this.Size = new System.Drawing.Size(1030, 474);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.noQToday.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbQNo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbStats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSched;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbApp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel noQToday;
        private System.Windows.Forms.Label lbNoQ2Day;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}
