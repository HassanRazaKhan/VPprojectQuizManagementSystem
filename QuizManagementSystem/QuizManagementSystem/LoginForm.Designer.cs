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
            this.Rolelabel = new System.Windows.Forms.Label();
            this.SignInbutton = new System.Windows.Forms.Button();
            this.SignUplinkLabel = new System.Windows.Forms.LinkLabel();
            this.UsernamepictureBox = new System.Windows.Forms.PictureBox();
            this.TeacherLoginradioButton = new System.Windows.Forms.RadioButton();
            this.StudentLoginradioButton = new System.Windows.Forms.RadioButton();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Loginpanel = new System.Windows.Forms.Panel();
            this.PasswardpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsernamepictureBox)).BeginInit();
            this.Loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswardpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernametextBox.ForeColor = System.Drawing.Color.Gray;
            this.UsernametextBox.Location = new System.Drawing.Point(102, 33);
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
            this.PasswardtextBox.Location = new System.Drawing.Point(102, 93);
            this.PasswardtextBox.Name = "PasswardtextBox";
            this.PasswardtextBox.PasswordChar = '*';
            this.PasswardtextBox.Size = new System.Drawing.Size(211, 29);
            this.PasswardtextBox.TabIndex = 3;
            this.PasswardtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rolelabel
            // 
            this.Rolelabel.AutoSize = true;
            this.Rolelabel.BackColor = System.Drawing.Color.Transparent;
            this.Rolelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolelabel.ForeColor = System.Drawing.Color.White;
            this.Rolelabel.Location = new System.Drawing.Point(60, 172);
            this.Rolelabel.Name = "Rolelabel";
            this.Rolelabel.Size = new System.Drawing.Size(53, 24);
            this.Rolelabel.TabIndex = 4;
            this.Rolelabel.Text = "Role";
            // 
            // SignInbutton
            // 
            this.SignInbutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SignInbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInbutton.ForeColor = System.Drawing.Color.White;
            this.SignInbutton.Location = new System.Drawing.Point(64, 271);
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
            this.SignUplinkLabel.Location = new System.Drawing.Point(119, 320);
            this.SignUplinkLabel.Name = "SignUplinkLabel";
            this.SignUplinkLabel.Size = new System.Drawing.Size(132, 16);
            this.SignUplinkLabel.TabIndex = 7;
            this.SignUplinkLabel.TabStop = true;
            this.SignUplinkLabel.Text = "Create new account?";
            this.SignUplinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUplinkLabel_LinkClicked);
            // 
            // UsernamepictureBox
            // 
            this.UsernamepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UsernamepictureBox.Image")));
            this.UsernamepictureBox.Location = new System.Drawing.Point(64, 33);
            this.UsernamepictureBox.Name = "UsernamepictureBox";
            this.UsernamepictureBox.Size = new System.Drawing.Size(32, 29);
            this.UsernamepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsernamepictureBox.TabIndex = 22;
            this.UsernamepictureBox.TabStop = false;
            // 
            // TeacherLoginradioButton
            // 
            this.TeacherLoginradioButton.AutoSize = true;
            this.TeacherLoginradioButton.BackColor = System.Drawing.Color.Transparent;
            this.TeacherLoginradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherLoginradioButton.ForeColor = System.Drawing.Color.White;
            this.TeacherLoginradioButton.Location = new System.Drawing.Point(198, 211);
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
            this.StudentLoginradioButton.Location = new System.Drawing.Point(64, 211);
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
            this.Exitbutton.Location = new System.Drawing.Point(660, 392);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(136, 33);
            this.Exitbutton.TabIndex = 25;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Loginpanel
            // 
            this.Loginpanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.Loginpanel.Controls.Add(this.PasswardpictureBox);
            this.Loginpanel.Controls.Add(this.PasswardtextBox);
            this.Loginpanel.Controls.Add(this.UsernametextBox);
            this.Loginpanel.Controls.Add(this.TeacherLoginradioButton);
            this.Loginpanel.Controls.Add(this.Rolelabel);
            this.Loginpanel.Controls.Add(this.StudentLoginradioButton);
            this.Loginpanel.Controls.Add(this.SignInbutton);
            this.Loginpanel.Controls.Add(this.UsernamepictureBox);
            this.Loginpanel.Controls.Add(this.SignUplinkLabel);
            this.Loginpanel.Location = new System.Drawing.Point(214, 21);
            this.Loginpanel.Name = "Loginpanel";
            this.Loginpanel.Size = new System.Drawing.Size(371, 404);
            this.Loginpanel.TabIndex = 26;
            this.Loginpanel.Visible = false;
            this.Loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Loginpanel_Paint);
            // 
            // PasswardpictureBox
            // 
            this.PasswardpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PasswardpictureBox.Image")));
            this.PasswardpictureBox.Location = new System.Drawing.Point(64, 93);
            this.PasswardpictureBox.Name = "PasswardpictureBox";
            this.PasswardpictureBox.Size = new System.Drawing.Size(32, 29);
            this.PasswardpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswardpictureBox.TabIndex = 25;
            this.PasswardpictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Loginpanel);
            this.Controls.Add(this.Exitbutton);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsernamepictureBox)).EndInit();
            this.Loginpanel.ResumeLayout(false);
            this.Loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswardpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.TextBox PasswardtextBox;
        private System.Windows.Forms.Label Rolelabel;
        private System.Windows.Forms.Button SignInbutton;
        private System.Windows.Forms.LinkLabel SignUplinkLabel;
        private System.Windows.Forms.PictureBox UsernamepictureBox;
        private System.Windows.Forms.RadioButton TeacherLoginradioButton;
        private System.Windows.Forms.RadioButton StudentLoginradioButton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Panel Loginpanel;
        private System.Windows.Forms.PictureBox PasswardpictureBox;
    }
}