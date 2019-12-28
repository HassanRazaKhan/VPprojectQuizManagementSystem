namespace QuizManagementSystem
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartScreenprogressBar = new System.Windows.Forms.ProgressBar();
            this.StartScreeentimer = new System.Windows.Forms.Timer(this.components);
            this.Loadinglabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartScreenprogressBar
            // 
            this.StartScreenprogressBar.Location = new System.Drawing.Point(134, 329);
            this.StartScreenprogressBar.Name = "StartScreenprogressBar";
            this.StartScreenprogressBar.Size = new System.Drawing.Size(471, 23);
            this.StartScreenprogressBar.TabIndex = 1;
            this.StartScreenprogressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // StartScreeentimer
            // 
            this.StartScreeentimer.Enabled = true;
            this.StartScreeentimer.Interval = 20;
            this.StartScreeentimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loadinglabel
            // 
            this.Loadinglabel.AutoSize = true;
            this.Loadinglabel.BackColor = System.Drawing.Color.Transparent;
            this.Loadinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadinglabel.ForeColor = System.Drawing.Color.White;
            this.Loadinglabel.Location = new System.Drawing.Point(341, 372);
            this.Loadinglabel.Name = "Loadinglabel";
            this.Loadinglabel.Size = new System.Drawing.Size(0, 20);
            this.Loadinglabel.TabIndex = 2;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 417);
            this.ControlBox = false;
            this.Controls.Add(this.Loadinglabel);
            this.Controls.Add(this.StartScreenprogressBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar StartScreenprogressBar;
        private System.Windows.Forms.Timer StartScreeentimer;
        private System.Windows.Forms.Label Loadinglabel;
    }
}

