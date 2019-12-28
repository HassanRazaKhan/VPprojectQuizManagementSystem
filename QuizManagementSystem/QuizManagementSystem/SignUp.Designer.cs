namespace QuizManagementSystem
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.SignupUsernametextBox = new System.Windows.Forms.TextBox();
            this.SignupUsernamelabel = new System.Windows.Forms.Label();
            this.SignupDepartmenttextBox = new System.Windows.Forms.TextBox();
            this.SignupDepartmentlabel = new System.Windows.Forms.Label();
            this.SignupEmailtextBox = new System.Windows.Forms.TextBox();
            this.SignupEmaillabel = new System.Windows.Forms.Label();
            this.SignupPasswardtextBox = new System.Windows.Forms.TextBox();
            this.SignupPasswardlabel = new System.Windows.Forms.Label();
            this.SignUpbutton = new System.Windows.Forms.Button();
            this.SignupRolelabel = new System.Windows.Forms.Label();
            this.StudentSignupradioButton = new System.Windows.Forms.RadioButton();
            this.TeacherSignupradioButton = new System.Windows.Forms.RadioButton();
            this.TeacherSignupCourseNametextBox = new System.Windows.Forms.TextBox();
            this.CourseNamelabel = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignupUsernametextBox
            // 
            this.SignupUsernametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupUsernametextBox.Location = new System.Drawing.Point(316, 97);
            this.SignupUsernametextBox.Name = "SignupUsernametextBox";
            this.SignupUsernametextBox.Size = new System.Drawing.Size(405, 29);
            this.SignupUsernametextBox.TabIndex = 4;
            this.SignupUsernametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignupUsernametextBox_KeyPress);
            // 
            // SignupUsernamelabel
            // 
            this.SignupUsernamelabel.AutoSize = true;
            this.SignupUsernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.SignupUsernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupUsernamelabel.ForeColor = System.Drawing.Color.White;
            this.SignupUsernamelabel.Location = new System.Drawing.Point(80, 98);
            this.SignupUsernamelabel.Name = "SignupUsernamelabel";
            this.SignupUsernamelabel.Size = new System.Drawing.Size(105, 24);
            this.SignupUsernamelabel.TabIndex = 3;
            this.SignupUsernamelabel.Text = "Username";
            // 
            // SignupDepartmenttextBox
            // 
            this.SignupDepartmenttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupDepartmenttextBox.ForeColor = System.Drawing.Color.Gray;
            this.SignupDepartmenttextBox.Location = new System.Drawing.Point(316, 262);
            this.SignupDepartmenttextBox.Name = "SignupDepartmenttextBox";
            this.SignupDepartmenttextBox.Size = new System.Drawing.Size(405, 29);
            this.SignupDepartmenttextBox.TabIndex = 6;
            this.SignupDepartmenttextBox.Text = "e.g. : Software Engineering";
            this.SignupDepartmenttextBox.Enter += new System.EventHandler(this.SignupDepartmenttextBox_Enter);
            this.SignupDepartmenttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignupDepartmenttextBox_KeyPress);
            this.SignupDepartmenttextBox.Leave += new System.EventHandler(this.SignupDepartmenttextBox_Leave);
            // 
            // SignupDepartmentlabel
            // 
            this.SignupDepartmentlabel.AutoSize = true;
            this.SignupDepartmentlabel.BackColor = System.Drawing.Color.Transparent;
            this.SignupDepartmentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupDepartmentlabel.ForeColor = System.Drawing.Color.White;
            this.SignupDepartmentlabel.Location = new System.Drawing.Point(80, 263);
            this.SignupDepartmentlabel.Name = "SignupDepartmentlabel";
            this.SignupDepartmentlabel.Size = new System.Drawing.Size(117, 24);
            this.SignupDepartmentlabel.TabIndex = 5;
            this.SignupDepartmentlabel.Text = "Department";
            // 
            // SignupEmailtextBox
            // 
            this.SignupEmailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupEmailtextBox.ForeColor = System.Drawing.Color.Gray;
            this.SignupEmailtextBox.Location = new System.Drawing.Point(316, 209);
            this.SignupEmailtextBox.Name = "SignupEmailtextBox";
            this.SignupEmailtextBox.Size = new System.Drawing.Size(405, 29);
            this.SignupEmailtextBox.TabIndex = 10;
            this.SignupEmailtextBox.Text = "someone@gmail.com";
            this.SignupEmailtextBox.Enter += new System.EventHandler(this.SignupEmailtextBox_Enter);
            this.SignupEmailtextBox.Leave += new System.EventHandler(this.SignupEmailtextBox_Leave);
            // 
            // SignupEmaillabel
            // 
            this.SignupEmaillabel.AutoSize = true;
            this.SignupEmaillabel.BackColor = System.Drawing.Color.Transparent;
            this.SignupEmaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupEmaillabel.ForeColor = System.Drawing.Color.White;
            this.SignupEmaillabel.Location = new System.Drawing.Point(80, 210);
            this.SignupEmaillabel.Name = "SignupEmaillabel";
            this.SignupEmaillabel.Size = new System.Drawing.Size(62, 24);
            this.SignupEmaillabel.TabIndex = 9;
            this.SignupEmaillabel.Text = "Email";
            // 
            // SignupPasswardtextBox
            // 
            this.SignupPasswardtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupPasswardtextBox.Location = new System.Drawing.Point(316, 155);
            this.SignupPasswardtextBox.Name = "SignupPasswardtextBox";
            this.SignupPasswardtextBox.Size = new System.Drawing.Size(405, 29);
            this.SignupPasswardtextBox.TabIndex = 12;
            this.SignupPasswardtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignupPasswardtextBox_KeyPress);
            // 
            // SignupPasswardlabel
            // 
            this.SignupPasswardlabel.AutoSize = true;
            this.SignupPasswardlabel.BackColor = System.Drawing.Color.Transparent;
            this.SignupPasswardlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupPasswardlabel.ForeColor = System.Drawing.Color.White;
            this.SignupPasswardlabel.Location = new System.Drawing.Point(80, 156);
            this.SignupPasswardlabel.Name = "SignupPasswardlabel";
            this.SignupPasswardlabel.Size = new System.Drawing.Size(99, 24);
            this.SignupPasswardlabel.TabIndex = 11;
            this.SignupPasswardlabel.Text = "Passward";
            // 
            // SignUpbutton
            // 
            this.SignUpbutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SignUpbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbutton.ForeColor = System.Drawing.Color.White;
            this.SignUpbutton.Location = new System.Drawing.Point(540, 391);
            this.SignUpbutton.Name = "SignUpbutton";
            this.SignUpbutton.Size = new System.Drawing.Size(256, 35);
            this.SignUpbutton.TabIndex = 13;
            this.SignUpbutton.Text = "Create Account";
            this.SignUpbutton.UseVisualStyleBackColor = false;
            this.SignUpbutton.Click += new System.EventHandler(this.SignUpbutton_Click);
            // 
            // SignupRolelabel
            // 
            this.SignupRolelabel.AutoSize = true;
            this.SignupRolelabel.BackColor = System.Drawing.Color.Transparent;
            this.SignupRolelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupRolelabel.ForeColor = System.Drawing.Color.White;
            this.SignupRolelabel.Location = new System.Drawing.Point(80, 45);
            this.SignupRolelabel.Name = "SignupRolelabel";
            this.SignupRolelabel.Size = new System.Drawing.Size(53, 24);
            this.SignupRolelabel.TabIndex = 14;
            this.SignupRolelabel.Text = "Role";
            // 
            // StudentSignupradioButton
            // 
            this.StudentSignupradioButton.AutoSize = true;
            this.StudentSignupradioButton.BackColor = System.Drawing.Color.Transparent;
            this.StudentSignupradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSignupradioButton.ForeColor = System.Drawing.Color.White;
            this.StudentSignupradioButton.Location = new System.Drawing.Point(316, 45);
            this.StudentSignupradioButton.Name = "StudentSignupradioButton";
            this.StudentSignupradioButton.Size = new System.Drawing.Size(99, 28);
            this.StudentSignupradioButton.TabIndex = 15;
            this.StudentSignupradioButton.TabStop = true;
            this.StudentSignupradioButton.Text = "Student";
            this.StudentSignupradioButton.UseVisualStyleBackColor = false;
            this.StudentSignupradioButton.CheckedChanged += new System.EventHandler(this.StudentSignupradioButton_CheckedChanged);
            // 
            // TeacherSignupradioButton
            // 
            this.TeacherSignupradioButton.AutoSize = true;
            this.TeacherSignupradioButton.BackColor = System.Drawing.Color.Transparent;
            this.TeacherSignupradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherSignupradioButton.ForeColor = System.Drawing.Color.White;
            this.TeacherSignupradioButton.Location = new System.Drawing.Point(615, 45);
            this.TeacherSignupradioButton.Name = "TeacherSignupradioButton";
            this.TeacherSignupradioButton.Size = new System.Drawing.Size(106, 28);
            this.TeacherSignupradioButton.TabIndex = 16;
            this.TeacherSignupradioButton.TabStop = true;
            this.TeacherSignupradioButton.Text = "Teacher";
            this.TeacherSignupradioButton.UseVisualStyleBackColor = false;
            this.TeacherSignupradioButton.CheckedChanged += new System.EventHandler(this.TeacherSignupradioButton_CheckedChanged);
            // 
            // TeacherSignupCourseNametextBox
            // 
            this.TeacherSignupCourseNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherSignupCourseNametextBox.Location = new System.Drawing.Point(316, 315);
            this.TeacherSignupCourseNametextBox.Name = "TeacherSignupCourseNametextBox";
            this.TeacherSignupCourseNametextBox.Size = new System.Drawing.Size(405, 29);
            this.TeacherSignupCourseNametextBox.TabIndex = 17;
            this.TeacherSignupCourseNametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeacherSignupCourseNametextBox_KeyPress);
            // 
            // CourseNamelabel
            // 
            this.CourseNamelabel.AutoSize = true;
            this.CourseNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.CourseNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNamelabel.ForeColor = System.Drawing.Color.White;
            this.CourseNamelabel.Location = new System.Drawing.Point(80, 316);
            this.CourseNamelabel.Name = "CourseNamelabel";
            this.CourseNamelabel.Size = new System.Drawing.Size(138, 24);
            this.CourseNamelabel.TabIndex = 18;
            this.CourseNamelabel.Text = "Course Name";
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.Color.White;
            this.Backbutton.Location = new System.Drawing.Point(12, 391);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(256, 35);
            this.Backbutton.TabIndex = 19;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.CourseNamelabel);
            this.Controls.Add(this.TeacherSignupCourseNametextBox);
            this.Controls.Add(this.TeacherSignupradioButton);
            this.Controls.Add(this.StudentSignupradioButton);
            this.Controls.Add(this.SignupRolelabel);
            this.Controls.Add(this.SignUpbutton);
            this.Controls.Add(this.SignupPasswardtextBox);
            this.Controls.Add(this.SignupPasswardlabel);
            this.Controls.Add(this.SignupEmailtextBox);
            this.Controls.Add(this.SignupEmaillabel);
            this.Controls.Add(this.SignupDepartmenttextBox);
            this.Controls.Add(this.SignupDepartmentlabel);
            this.Controls.Add(this.SignupUsernametextBox);
            this.Controls.Add(this.SignupUsernamelabel);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SignupUsernametextBox;
        private System.Windows.Forms.Label SignupUsernamelabel;
        private System.Windows.Forms.TextBox SignupDepartmenttextBox;
        private System.Windows.Forms.Label SignupDepartmentlabel;
        private System.Windows.Forms.TextBox SignupEmailtextBox;
        private System.Windows.Forms.Label SignupEmaillabel;
        private System.Windows.Forms.TextBox SignupPasswardtextBox;
        private System.Windows.Forms.Label SignupPasswardlabel;
        private System.Windows.Forms.Button SignUpbutton;
        private System.Windows.Forms.Label SignupRolelabel;
        private System.Windows.Forms.RadioButton StudentSignupradioButton;
        private System.Windows.Forms.RadioButton TeacherSignupradioButton;
        private System.Windows.Forms.TextBox TeacherSignupCourseNametextBox;
        private System.Windows.Forms.Label CourseNamelabel;
        private System.Windows.Forms.Button Backbutton;
    }
}