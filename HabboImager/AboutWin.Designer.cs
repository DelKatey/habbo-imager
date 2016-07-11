namespace Arav_Imager
{
    partial class AboutWin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wemjfiwejifj = new System.Windows.Forms.Label();
            this.ergwhgtrewg = new System.Windows.Forms.Label();
            this.iopuytr = new System.Windows.Forms.Label();
            this.j9eikf9wkogk = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Arav_Imager.Properties.Resources.DarkBox_nl_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // wemjfiwejifj
            // 
            this.wemjfiwejifj.AutoSize = true;
            this.wemjfiwejifj.BackColor = System.Drawing.Color.Transparent;
            this.wemjfiwejifj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wemjfiwejifj.Location = new System.Drawing.Point(108, 167);
            this.wemjfiwejifj.Name = "wemjfiwejifj";
            this.wemjfiwejifj.Size = new System.Drawing.Size(252, 24);
            this.wemjfiwejifj.TabIndex = 1;
            this.wemjfiwejifj.Text = "Programmed by:  Delaney, Katie";
            this.wemjfiwejifj.UseCompatibleTextRendering = true;
            // 
            // ergwhgtrewg
            // 
            this.ergwhgtrewg.AutoSize = true;
            this.ergwhgtrewg.BackColor = System.Drawing.Color.Transparent;
            this.ergwhgtrewg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ergwhgtrewg.Location = new System.Drawing.Point(122, 100);
            this.ergwhgtrewg.Name = "ergwhgtrewg";
            this.ergwhgtrewg.Size = new System.Drawing.Size(214, 37);
            this.ergwhgtrewg.TabIndex = 2;
            this.ergwhgtrewg.Text = "DarkBox Edition";
            this.ergwhgtrewg.UseCompatibleTextRendering = true;
            // 
            // iopuytr
            // 
            this.iopuytr.AutoSize = true;
            this.iopuytr.BackColor = System.Drawing.Color.Transparent;
            this.iopuytr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iopuytr.Location = new System.Drawing.Point(157, 133);
            this.iopuytr.Name = "iopuytr";
            this.iopuytr.Size = new System.Drawing.Size(160, 24);
            this.iopuytr.TabIndex = 3;
            this.iopuytr.Text = "Enjoy the movement!";
            this.iopuytr.UseCompatibleTextRendering = true;
            // 
            // j9eikf9wkogk
            // 
            this.j9eikf9wkogk.AutoSize = true;
            this.j9eikf9wkogk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j9eikf9wkogk.Location = new System.Drawing.Point(173, 191);
            this.j9eikf9wkogk.Name = "j9eikf9wkogk";
            this.j9eikf9wkogk.Size = new System.Drawing.Size(122, 24);
            this.j9eikf9wkogk.TabIndex = 4;
            this.j9eikf9wkogk.TabStop = true;
            this.j9eikf9wkogk.Text = "Visit DarkBox.nl";
            this.j9eikf9wkogk.UseCompatibleTextRendering = true;
            this.j9eikf9wkogk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.j9eikf9wkogk_LinkClicked);
            // 
            // AboutWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 219);
            this.Controls.Add(this.j9eikf9wkogk);
            this.Controls.Add(this.iopuytr);
            this.Controls.Add(this.ergwhgtrewg);
            this.Controls.Add(this.wemjfiwejifj);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWin";
            this.ShowIcon = false;
            this.Text = "About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutWin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wemjfiwejifj;
        private System.Windows.Forms.Label ergwhgtrewg;
        private System.Windows.Forms.Label iopuytr;
        private System.Windows.Forms.LinkLabel j9eikf9wkogk;
    }
}