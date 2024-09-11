namespace QSystem
{
    partial class Loading
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.customProgressbar1 = new QSystem.CustomControlTools.CustomProgressbar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 136);
            this.label1.TabIndex = 0;
            this.label1.Text = "   WELCOME";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // customProgressbar1
            // 
            this.customProgressbar1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.customProgressbar1.ChannelHeight = 20;
            this.customProgressbar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customProgressbar1.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customProgressbar1.ForeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(13)))));
            this.customProgressbar1.ForeColor = System.Drawing.Color.White;
            this.customProgressbar1.Location = new System.Drawing.Point(0, 391);
            this.customProgressbar1.Name = "customProgressbar1";
            this.customProgressbar1.ShowMaximun = false;
            this.customProgressbar1.ShowValue = QSystem.CustomControlTools.TextPosition.Sliding;
            this.customProgressbar1.Size = new System.Drawing.Size(800, 59);
            this.customProgressbar1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(244)))), ((int)(((byte)(140)))));
            this.customProgressbar1.SliderHeight = 26;
            this.customProgressbar1.Step = 2;
            this.customProgressbar1.SymbolAfter = " %";
            this.customProgressbar1.SymbolBefore = "";
            this.customProgressbar1.TabIndex = 1;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customProgressbar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControlTools.CustomProgressbar customProgressbar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

