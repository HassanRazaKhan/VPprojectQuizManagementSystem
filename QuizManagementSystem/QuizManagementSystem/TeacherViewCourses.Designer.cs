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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SearchTeacherCourseButton = new System.Windows.Forms.Button();
            this.SearchTeacherCoursetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewTeacherCoursetsdataGridView = new System.Windows.Forms.DataGridView();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.viewTeacherCoursetsdataGridView)).BeginInit();
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
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(623, 123);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 316);
            this.vScrollBar1.TabIndex = 48;
            // 
            // SearchTeacherCourseButton
            // 
            this.SearchTeacherCourseButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SearchTeacherCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchTeacherCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTeacherCourseButton.ForeColor = System.Drawing.Color.White;
            this.SearchTeacherCourseButton.Location = new System.Drawing.Point(721, 65);
            this.SearchTeacherCourseButton.Name = "SearchTeacherCourseButton";
            this.SearchTeacherCourseButton.Size = new System.Drawing.Size(113, 37);
            this.SearchTeacherCourseButton.TabIndex = 47;
            this.SearchTeacherCourseButton.Text = "Search";
            this.SearchTeacherCourseButton.UseVisualStyleBackColor = false;
            this.SearchTeacherCourseButton.Click += new System.EventHandler(this.SearchTeacherCourseButton_Click);
            // 
            // SearchTeacherCoursetextBox
            // 
            this.SearchTeacherCoursetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTeacherCoursetextBox.Location = new System.Drawing.Point(264, 68);
            this.SearchTeacherCoursetextBox.Name = "SearchTeacherCoursetextBox";
            this.SearchTeacherCoursetextBox.Size = new System.Drawing.Size(405, 29);
            this.SearchTeacherCoursetextBox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Search Course";
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
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(296, 439);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(344, 17);
            this.hScrollBar1.TabIndex = 49;
            // 
            // TeacherViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.SearchTeacherCourseButton);
            this.Controls.Add(this.SearchTeacherCoursetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewTeacherCoursetsdataGridView);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "TeacherViewCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherViewCourses";
            ((System.ComponentModel.ISupportInitialize)(this.viewTeacherCoursetsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button SearchTeacherCourseButton;
        private System.Windows.Forms.TextBox SearchTeacherCoursetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewTeacherCoursetsdataGridView;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}