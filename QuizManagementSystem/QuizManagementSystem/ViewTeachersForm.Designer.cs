namespace QuizManagementSystem
{
    partial class ViewTeachersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTeachersForm));
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SearchTeachertextBox = new System.Windows.Forms.TextBox();
            this.viewTeacherstsdataGridView = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.SearchTeacherstpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewTeacherstsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTeacherstpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.ForeColor = System.Drawing.Color.White;
            this.MainMenuButton.Location = new System.Drawing.Point(634, 465);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(256, 35);
            this.MainMenuButton.TabIndex = 37;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // SearchTeachertextBox
            // 
            this.SearchTeachertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTeachertextBox.ForeColor = System.Drawing.Color.Gray;
            this.SearchTeachertextBox.Location = new System.Drawing.Point(298, 53);
            this.SearchTeachertextBox.Name = "SearchTeachertextBox";
            this.SearchTeachertextBox.Size = new System.Drawing.Size(328, 29);
            this.SearchTeachertextBox.TabIndex = 40;
            this.SearchTeachertextBox.Text = "Search By Username";
            this.SearchTeachertextBox.Enter += new System.EventHandler(this.SearchTeachertextBox_Enter);
            this.SearchTeachertextBox.Leave += new System.EventHandler(this.SearchTeachertextBox_Leave);
            // 
            // viewTeacherstsdataGridView
            // 
            this.viewTeacherstsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTeacherstsdataGridView.GridColor = System.Drawing.Color.LightSeaGreen;
            this.viewTeacherstsdataGridView.Location = new System.Drawing.Point(298, 108);
            this.viewTeacherstsdataGridView.Name = "viewTeacherstsdataGridView";
            this.viewTeacherstsdataGridView.Size = new System.Drawing.Size(344, 333);
            this.viewTeacherstsdataGridView.TabIndex = 38;
            this.viewTeacherstsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewStudentsdataGridView_CellContentClick);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(625, 108);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 316);
            this.vScrollBar1.TabIndex = 43;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(298, 424);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(344, 17);
            this.hScrollBar1.TabIndex = 42;
            // 
            // SearchTeacherstpictureBox
            // 
            this.SearchTeacherstpictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchTeacherstpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchTeacherstpictureBox.Image")));
            this.SearchTeacherstpictureBox.Location = new System.Drawing.Point(602, 53);
            this.SearchTeacherstpictureBox.Name = "SearchTeacherstpictureBox";
            this.SearchTeacherstpictureBox.Size = new System.Drawing.Size(40, 29);
            this.SearchTeacherstpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchTeacherstpictureBox.TabIndex = 44;
            this.SearchTeacherstpictureBox.TabStop = false;
            this.SearchTeacherstpictureBox.Click += new System.EventHandler(this.SearchStudentpictureBox_Click);
            // 
            // ViewTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.ControlBox = false;
            this.Controls.Add(this.SearchTeacherstpictureBox);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.SearchTeachertextBox);
            this.Controls.Add(this.viewTeacherstsdataGridView);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ViewTeachersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTeachersForm";
            ((System.ComponentModel.ISupportInitialize)(this.viewTeacherstsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTeacherstpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.TextBox SearchTeachertextBox;
        private System.Windows.Forms.DataGridView viewTeacherstsdataGridView;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.PictureBox SearchTeacherstpictureBox;
    }
}