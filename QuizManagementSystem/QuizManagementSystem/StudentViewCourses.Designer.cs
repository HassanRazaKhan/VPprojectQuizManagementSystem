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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SearchStudentsCourseButton = new System.Windows.Forms.Button();
            this.SearchStudentsCoursetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewStudentsCoursetsdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsCoursetsdataGridView)).BeginInit();
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
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(296, 423);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(344, 17);
            this.hScrollBar1.TabIndex = 55;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(623, 107);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 316);
            this.vScrollBar1.TabIndex = 54;
            // 
            // SearchStudentsCourseButton
            // 
            this.SearchStudentsCourseButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SearchStudentsCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchStudentsCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudentsCourseButton.ForeColor = System.Drawing.Color.White;
            this.SearchStudentsCourseButton.Location = new System.Drawing.Point(721, 49);
            this.SearchStudentsCourseButton.Name = "SearchStudentsCourseButton";
            this.SearchStudentsCourseButton.Size = new System.Drawing.Size(113, 37);
            this.SearchStudentsCourseButton.TabIndex = 53;
            this.SearchStudentsCourseButton.Text = "Search";
            this.SearchStudentsCourseButton.UseVisualStyleBackColor = false;
            this.SearchStudentsCourseButton.Click += new System.EventHandler(this.SearchTeacherCourseButton_Click);
            // 
            // SearchStudentsCoursetextBox
            // 
            this.SearchStudentsCoursetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudentsCoursetextBox.Location = new System.Drawing.Point(264, 52);
            this.SearchStudentsCoursetextBox.Name = "SearchStudentsCoursetextBox";
            this.SearchStudentsCoursetextBox.Size = new System.Drawing.Size(405, 29);
            this.SearchStudentsCoursetextBox.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Search Course";
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
            // StudentViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.ControlBox = false;
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.SearchStudentsCourseButton);
            this.Controls.Add(this.SearchStudentsCoursetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewStudentsCoursetsdataGridView);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "StudentViewCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentViewCourses";
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsCoursetsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button SearchStudentsCourseButton;
        private System.Windows.Forms.TextBox SearchStudentsCoursetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewStudentsCoursetsdataGridView;
    }
}