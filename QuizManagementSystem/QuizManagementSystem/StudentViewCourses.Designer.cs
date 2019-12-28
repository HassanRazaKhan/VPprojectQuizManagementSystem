namespace QuizManagementSystem
{
    partial class StudentViewCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentViewCourses));
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.ViewCoursehScrollBar = new System.Windows.Forms.HScrollBar();
            this.ViewCoursevScrollBar = new System.Windows.Forms.VScrollBar();
            this.SearchStudentsCoursetextBox = new System.Windows.Forms.TextBox();
            this.SearchCourselabel = new System.Windows.Forms.Label();
            this.viewStudentsCoursetsdataGridView = new System.Windows.Forms.DataGridView();
            this.SearchStudentCoursespictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsCoursetsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStudentCoursespictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.ForeColor = System.Drawing.Color.White;
            this.MainMenuButton.Location = new System.Drawing.Point(631, 465);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(256, 35);
            this.MainMenuButton.TabIndex = 36;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // ViewCoursehScrollBar
            // 
            this.ViewCoursehScrollBar.Location = new System.Drawing.Point(296, 423);
            this.ViewCoursehScrollBar.Name = "ViewCoursehScrollBar";
            this.ViewCoursehScrollBar.Size = new System.Drawing.Size(344, 17);
            this.ViewCoursehScrollBar.TabIndex = 55;
            // 
            // ViewCoursevScrollBar
            // 
            this.ViewCoursevScrollBar.Location = new System.Drawing.Point(623, 107);
            this.ViewCoursevScrollBar.Name = "ViewCoursevScrollBar";
            this.ViewCoursevScrollBar.Size = new System.Drawing.Size(17, 316);
            this.ViewCoursevScrollBar.TabIndex = 54;
            // 
            // SearchStudentsCoursetextBox
            // 
            this.SearchStudentsCoursetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudentsCoursetextBox.Location = new System.Drawing.Point(165, 52);
            this.SearchStudentsCoursetextBox.Name = "SearchStudentsCoursetextBox";
            this.SearchStudentsCoursetextBox.Size = new System.Drawing.Size(614, 29);
            this.SearchStudentsCoursetextBox.TabIndex = 52;
            // 
            // SearchCourselabel
            // 
            this.SearchCourselabel.AutoSize = true;
            this.SearchCourselabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchCourselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCourselabel.ForeColor = System.Drawing.Color.White;
            this.SearchCourselabel.Location = new System.Drawing.Point(161, 25);
            this.SearchCourselabel.Name = "SearchCourselabel";
            this.SearchCourselabel.Size = new System.Drawing.Size(149, 24);
            this.SearchCourselabel.TabIndex = 51;
            this.SearchCourselabel.Text = "Search Course";
            // 
            // viewStudentsCoursetsdataGridView
            // 
            this.viewStudentsCoursetsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewStudentsCoursetsdataGridView.GridColor = System.Drawing.Color.LightSeaGreen;
            this.viewStudentsCoursetsdataGridView.Location = new System.Drawing.Point(296, 107);
            this.viewStudentsCoursetsdataGridView.Name = "viewStudentsCoursetsdataGridView";
            this.viewStudentsCoursetsdataGridView.Size = new System.Drawing.Size(344, 333);
            this.viewStudentsCoursetsdataGridView.TabIndex = 50;
            // 
            // SearchStudentCoursespictureBox
            // 
            this.SearchStudentCoursespictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchStudentCoursespictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchStudentCoursespictureBox.Image")));
            this.SearchStudentCoursespictureBox.Location = new System.Drawing.Point(749, 52);
            this.SearchStudentCoursespictureBox.Name = "SearchStudentCoursespictureBox";
            this.SearchStudentCoursespictureBox.Size = new System.Drawing.Size(30, 29);
            this.SearchStudentCoursespictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchStudentCoursespictureBox.TabIndex = 56;
            this.SearchStudentCoursespictureBox.TabStop = false;
            this.SearchStudentCoursespictureBox.Click += new System.EventHandler(this.SearchStudentCoursespictureBox_Click);
            // 
            // StudentViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.ControlBox = false;
            this.Controls.Add(this.SearchStudentCoursespictureBox);
            this.Controls.Add(this.ViewCoursehScrollBar);
            this.Controls.Add(this.ViewCoursevScrollBar);
            this.Controls.Add(this.SearchStudentsCoursetextBox);
            this.Controls.Add(this.SearchCourselabel);
            this.Controls.Add(this.viewStudentsCoursetsdataGridView);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "StudentViewCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentViewCourses";
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsCoursetsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStudentCoursespictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.HScrollBar ViewCoursehScrollBar;
        private System.Windows.Forms.VScrollBar ViewCoursevScrollBar;
        private System.Windows.Forms.TextBox SearchStudentsCoursetextBox;
        private System.Windows.Forms.Label SearchCourselabel;
        private System.Windows.Forms.DataGridView viewStudentsCoursetsdataGridView;
        private System.Windows.Forms.PictureBox SearchStudentCoursespictureBox;
    }
}