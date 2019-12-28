namespace QuizManagementSystem
{
    partial class TeacherViewCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherViewCourses));
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SearchCoursevScrollBar = new System.Windows.Forms.VScrollBar();
            this.SearchTeacherCoursetextBox = new System.Windows.Forms.TextBox();
            this.SeachCourselabel = new System.Windows.Forms.Label();
            this.viewTeacherCoursetsdataGridView = new System.Windows.Forms.DataGridView();
            this.SearchCoursehScrollBar = new System.Windows.Forms.HScrollBar();
            this.SearchTeachersCoursespictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewTeacherCoursetsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTeachersCoursespictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.ForeColor = System.Drawing.Color.White;
            this.MainMenuButton.Location = new System.Drawing.Point(630, 465);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(256, 35);
            this.MainMenuButton.TabIndex = 20;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // SearchCoursevScrollBar
            // 
            this.SearchCoursevScrollBar.Location = new System.Drawing.Point(623, 123);
            this.SearchCoursevScrollBar.Name = "SearchCoursevScrollBar";
            this.SearchCoursevScrollBar.Size = new System.Drawing.Size(17, 316);
            this.SearchCoursevScrollBar.TabIndex = 48;
            // 
            // SearchTeacherCoursetextBox
            // 
            this.SearchTeacherCoursetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTeacherCoursetextBox.Location = new System.Drawing.Point(167, 68);
            this.SearchTeacherCoursetextBox.Name = "SearchTeacherCoursetextBox";
            this.SearchTeacherCoursetextBox.Size = new System.Drawing.Size(606, 29);
            this.SearchTeacherCoursetextBox.TabIndex = 46;
            // 
            // SeachCourselabel
            // 
            this.SeachCourselabel.AutoSize = true;
            this.SeachCourselabel.BackColor = System.Drawing.Color.Transparent;
            this.SeachCourselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeachCourselabel.ForeColor = System.Drawing.Color.White;
            this.SeachCourselabel.Location = new System.Drawing.Point(163, 41);
            this.SeachCourselabel.Name = "SeachCourselabel";
            this.SeachCourselabel.Size = new System.Drawing.Size(149, 24);
            this.SeachCourselabel.TabIndex = 45;
            this.SeachCourselabel.Text = "Search Course";
            // 
            // viewTeacherCoursetsdataGridView
            // 
            this.viewTeacherCoursetsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTeacherCoursetsdataGridView.GridColor = System.Drawing.Color.LightSeaGreen;
            this.viewTeacherCoursetsdataGridView.Location = new System.Drawing.Point(296, 123);
            this.viewTeacherCoursetsdataGridView.Name = "viewTeacherCoursetsdataGridView";
            this.viewTeacherCoursetsdataGridView.Size = new System.Drawing.Size(344, 333);
            this.viewTeacherCoursetsdataGridView.TabIndex = 44;
            // 
            // SearchCoursehScrollBar
            // 
            this.SearchCoursehScrollBar.Location = new System.Drawing.Point(296, 439);
            this.SearchCoursehScrollBar.Name = "SearchCoursehScrollBar";
            this.SearchCoursehScrollBar.Size = new System.Drawing.Size(344, 17);
            this.SearchCoursehScrollBar.TabIndex = 49;
            // 
            // SearchTeachersCoursespictureBox
            // 
            this.SearchTeachersCoursespictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchTeachersCoursespictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchTeachersCoursespictureBox.Image")));
            this.SearchTeachersCoursespictureBox.Location = new System.Drawing.Point(743, 68);
            this.SearchTeachersCoursespictureBox.Name = "SearchTeachersCoursespictureBox";
            this.SearchTeachersCoursespictureBox.Size = new System.Drawing.Size(30, 29);
            this.SearchTeachersCoursespictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchTeachersCoursespictureBox.TabIndex = 57;
            this.SearchTeachersCoursespictureBox.TabStop = false;
            this.SearchTeachersCoursespictureBox.Click += new System.EventHandler(this.SearchTeachersCoursespictureBox_Click);
            // 
            // TeacherViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.Controls.Add(this.SearchTeachersCoursespictureBox);
            this.Controls.Add(this.SearchCoursehScrollBar);
            this.Controls.Add(this.SearchCoursevScrollBar);
            this.Controls.Add(this.SearchTeacherCoursetextBox);
            this.Controls.Add(this.SeachCourselabel);
            this.Controls.Add(this.viewTeacherCoursetsdataGridView);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "TeacherViewCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherViewCourses";
            ((System.ComponentModel.ISupportInitialize)(this.viewTeacherCoursetsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTeachersCoursespictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.VScrollBar SearchCoursevScrollBar;
        private System.Windows.Forms.TextBox SearchTeacherCoursetextBox;
        private System.Windows.Forms.Label SeachCourselabel;
        private System.Windows.Forms.DataGridView viewTeacherCoursetsdataGridView;
        private System.Windows.Forms.HScrollBar SearchCoursehScrollBar;
        private System.Windows.Forms.PictureBox SearchTeachersCoursespictureBox;
    }
}