namespace QSystem
{
    partial class Main
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.usercontrolpanel = new System.Windows.Forms.Panel();
            this.queue1 = new QSystem.UserControls.Queue();
            this.dashboard1 = new QSystem.UserControls.Dashboard();
            this.request2 = new QSystem.UserControls.Request();
            this.request1 = new QSystem.UserControls.Request();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.usercontrolpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 522);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButton5);
            this.panel4.Controls.Add(this.iconButton3);
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 303);
            this.panel4.TabIndex = 1;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.MediumPurple;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 35;
            this.iconButton5.Location = new System.Drawing.Point(0, 183);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(197, 50);
            this.iconButton5.TabIndex = 1;
            this.iconButton5.Text = "Sign out";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.MediumPurple;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.Location = new System.Drawing.Point(0, 127);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(197, 50);
            this.iconButton3.TabIndex = 1;
            this.iconButton3.Text = "Queue";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.MediumPurple;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Location = new System.Drawing.Point(0, 71);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(197, 50);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Request";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.MediumPurple;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(0, 15);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(197, 50);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Dashboard";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 240);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 213);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::QSystem.Properties.Resources.userplaceholder;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.iconButton4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1030, 48);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Silver;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 40;
            this.iconButton4.Location = new System.Drawing.Point(0, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(47, 48);
            this.iconButton4.TabIndex = 0;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // usercontrolpanel
            // 
            this.usercontrolpanel.AutoScroll = true;
            this.usercontrolpanel.Controls.Add(this.dashboard1);
            this.usercontrolpanel.Controls.Add(this.request2);
            this.usercontrolpanel.Controls.Add(this.queue1);
            this.usercontrolpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usercontrolpanel.Location = new System.Drawing.Point(200, 48);
            this.usercontrolpanel.Name = "usercontrolpanel";
            this.usercontrolpanel.Size = new System.Drawing.Size(1030, 474);
            this.usercontrolpanel.TabIndex = 2;
            // 
            // queue1
            // 
            this.queue1.AutoScroll = true;
            this.queue1.AutoSize = true;
            this.queue1.BackColor = System.Drawing.Color.White;
            this.queue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queue1.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.queue1.Location = new System.Drawing.Point(0, 0);
            this.queue1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.queue1.Name = "queue1";
            this.queue1.Size = new System.Drawing.Size(1030, 474);
            this.queue1.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.AutoScroll = true;
            this.dashboard1.BackColor = System.Drawing.Color.White;
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1030, 474);
            this.dashboard1.TabIndex = 0;
            // 
            // request2
            // 
            this.request2.AutoScroll = true;
            this.request2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.request2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request2.Location = new System.Drawing.Point(0, 0);
            this.request2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.request2.Name = "request2";
            this.request2.Size = new System.Drawing.Size(1030, 474);
            this.request2.TabIndex = 3;
            // 
            // request1
            // 
            this.request1.AutoScroll = true;
            this.request1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request1.Location = new System.Drawing.Point(0, 0);
            this.request1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.request1.Name = "request1";
            this.request1.Size = new System.Drawing.Size(1054, 474);
            this.request1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 522);
            this.Controls.Add(this.usercontrolpanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.usercontrolpanel.ResumeLayout(false);
            this.usercontrolpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel usercontrolpanel;
        private UserControls.Dashboard dashboard1;
        private System.Windows.Forms.Label label1;
        private UserControls.Queue queue1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private UserControls.Request request1;
        private UserControls.Request request2;
    }
}