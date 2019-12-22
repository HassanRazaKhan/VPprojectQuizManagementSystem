namespace QuizManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernametextBox = new System.Windows.Forms.TextBox();
            this.PasswardtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SignInbutton = new System.Windows.Forms.Button();
            this.SignUplinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TeacherLoginradioButton = new System.Windows.Forms.RadioButton();
            this.StudentLoginradioButton = new System.Windows.Forms.RadioButton();
            this.Exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernametextBox.ForeColor = System.Drawing.Color.Gray;
            this.UsernametextBox.Location = new System.Drawing.Point(112, 60);
            this.UsernametextBox.Name = "UsernametextBox";
            this.UsernametextBox.Size = new System.Drawing.Size(211, 29);
            this.UsernametextBox.TabIndex = 2;
            this.UsernametextBox.Text = "Username";
            this.UsernametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernametextBox.Enter += new System.EventHandler(this.UsernametextBox_Enter);
            this.UsernametextBox.Leave += new System.EventHandler(this.UsernametextBox_Leave);
            // 
            // PasswardtextBox
            // 
            this.PasswardtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswardtextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswardtextBox.Location = new System.Drawing.Point(112, 122);
            this.PasswardtextBox.Name = "PasswardtextBox";
            this.PasswardtextBox.PasswordChar = '*';
            this.PasswardtextBox.Size = new System.Drawing.Size(211, 29);
            this.PasswardtextBox.TabIndex = 3;
            this.PasswardtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role";
            // 
            // SignInbutton
            // 
            this.SignInbutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SignInbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInbutton.ForeColor = System.Drawing.Color.White;
            this.SignInbutton.Location = new System.Drawing.Point(83, 292);
            this.SignInbutton.Name = "SignInbutton";
            this.SignInbutton.Size = new System.Drawing.Size(240, 35);
            this.SignInbutton.TabIndex = 6;
            this.SignInbutton.Text = "Sign In";
            this.SignInbutton.UseVisualStyleBackColor = false;
            this.SignInbutton.Click += new System.EventHandler(this.SignInbutton_Click);
            // 
            // SignUplinkLabel
            // 
            this.SignUplinkLabel.AutoSize = true;
            this.SignUplinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignUplinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUplinkLabel.LinkColor = System.Drawing.Color.White;
            this.SignUplinkLabel.Location = new System.Drawing.Point(135, 341);
            this.SignUplinkLabel.Name = "SignUplinkLabel";
            this.SignUplinkLabel.Size = new System.Drawing.Size(132, 16);
            this.SignUplinkLabel.TabIndex = 7;
            this.SignUplinkLabel.TabStop = true;
            this.SignUplinkLabel.Text = "Create new account?";
            this.SignUplinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUplinkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // TeacherLoginradioButton
            // 
            this.TeacherLoginradioButton.AutoSize = true;
            this.TeacherLoginradioButton.BackColor = System.Drawing.Color.Transparent;
            this.TeacherLoginradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherLoginradioButton.ForeColor = System.Drawing.Color.White;
            this.TeacherLoginradioButton.Location = new System.Drawing.Point(217, 235);
            this.TeacherLoginradioButton.Name = "TeacherLoginradioButton";
            this.TeacherLoginradioButton.Size = new System.Drawing.Size(106, 28);
            this.TeacherLoginradioButton.TabIndex = 24;
            this.TeacherLoginradioButton.TabStop = true;
            this.TeacherLoginradioButton.Text = "Teacher";
            this.TeacherLoginradioButton.UseVisualStyleBackColor = false;
            // 
            // StudentLoginradioButton
            // 
            this.StudentLoginradioButton.AutoSize = true;
            this.StudentLoginradioButton.BackColor = System.Drawing.Color.Transparent;
            this.StudentLoginradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLoginradioButton.ForeColor = System.Drawing.Color.White;
            this.StudentLoginradioButton.Location = new System.Drawing.Point(83, 235);
            this.StudentLoginradioButton.Name = "StudentLoginradioButton";
            this.StudentLoginradioButton.Size = new System.Drawing.Size(99, 28);
            this.StudentLoginradioButton.TabIndex = 23;
            this.StudentLoginradioButton.TabStop = true;
            this.StudentLoginradioButton.Text = "Student";
            this.StudentLoginradioButton.UseVisualStyleBackColor = false;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Crimson;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.White;
            this.Exitbutton.Location = new System.Drawing.Point(291, 383);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(86, 33);
            this.Exitbutton.TabIndex = 25;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 428);
            this.ControlBox = false;
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.TeacherLoginradioButton);
            this.Controls.Add(this.StudentLoginradioButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignUplinkLabel);
            this.Controls.Add(this.SignInbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswardtextBox);
            this.Controls.Add(this.UsernametextBox);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.TextBox PasswardtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SignInbutton;
        private System.Windows.Forms.LinkLabel SignUplinkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton TeacherLoginradioButton;
        private System.Windows.Forms.RadioButton StudentLoginradioButton;
        private System.Windows.Forms.Button Exitbutton;
    }
}