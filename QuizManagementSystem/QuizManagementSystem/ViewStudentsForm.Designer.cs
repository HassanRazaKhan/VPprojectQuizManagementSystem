namespace QuizManagementSystem
{
    partial class ViewStudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentsForm));
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.viewStudentsdataGridView = new System.Windows.Forms.DataGridView();
            this.SearchStudenttextBox = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SearchStudentpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStudentpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.ForeColor = System.Drawing.Color.White;
            this.MainMenuButton.Location = new System.Drawing.Point(633, 464);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(256, 35);
            this.MainMenuButton.TabIndex = 20;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // viewStudentsdataGridView
            // 
            this.viewStudentsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewStudentsdataGridView.GridColor = System.Drawing.Color.LightSeaGreen;
            this.viewStudentsdataGridView.Location = new System.Drawing.Point(311, 91);
            this.viewStudentsdataGridView.Name = "viewStudentsdataGridView";
            this.viewStudentsdataGridView.Size = new System.Drawing.Size(344, 333);
            this.viewStudentsdataGridView.TabIndex = 21;
            // 
            // SearchStudenttextBox
            // 
            this.SearchStudenttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudenttextBox.ForeColor = System.Drawing.Color.Gray;
            this.SearchStudenttextBox.Location = new System.Drawing.Point(311, 39);
            this.SearchStudenttextBox.Name = "SearchStudenttextBox";
            this.SearchStudenttextBox.Size = new System.Drawing.Size(322, 29);
            this.SearchStudenttextBox.TabIndex = 23;
            this.SearchStudenttextBox.Text = "Search By Username";
            this.SearchStudenttextBox.Enter += new System.EventHandler(this.SearchStudenttextBox_Enter);
            this.SearchStudenttextBox.Leave += new System.EventHandler(this.SearchStudenttextBox_Leave);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(311, 407);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(344, 17);
            this.hScrollBar1.TabIndex = 25;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(638, 91);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 316);
            this.vScrollBar1.TabIndex = 26;
            // 
            // SearchStudentpictureBox
            // 
            this.SearchStudentpictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchStudentpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchStudentpictureBox.Image")));
            this.SearchStudentpictureBox.Location = new System.Drawing.Point(615, 39);
            this.SearchStudentpictureBox.Name = "SearchStudentpictureBox";
            this.SearchStudentpictureBox.Size = new System.Drawing.Size(40, 29);
            this.SearchStudentpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchStudentpictureBox.TabIndex = 27;
            this.SearchStudentpictureBox.TabStop = false;
            this.SearchStudentpictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.ControlBox = false;
            this.Controls.Add(this.SearchStudentpictureBox);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.SearchStudenttextBox);
            this.Controls.Add(this.viewStudentsdataGridView);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ViewStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStudentpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.DataGridView viewStudentsdataGridView;
        private System.Windows.Forms.TextBox SearchStudenttextBox;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox SearchStudentpictureBox;
    }
}