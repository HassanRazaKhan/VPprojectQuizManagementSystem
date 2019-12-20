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
            this.SearchTeacherButton = new System.Windows.Forms.Button();
            this.SearchTeachertextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewTeacherstsdataGridView = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.viewTeacherstsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.LightSeaGreen;
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
            // SearchTeacherButton
            // 
            this.SearchTeacherButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SearchTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTeacherButton.ForeColor = System.Drawing.Color.White;
            this.SearchTeacherButton.Location = new System.Drawing.Point(723, 50);
            this.SearchTeacherButton.Name = "SearchTeacherButton";
            this.SearchTeacherButton.Size = new System.Drawing.Size(113, 37);
            this.SearchTeacherButton.TabIndex = 41;
            this.SearchTeacherButton.Text = "Search";
            this.SearchTeacherButton.UseVisualStyleBackColor = false;
            this.SearchTeacherButton.Click += new System.EventHandler(this.SearchTeacherButton_Click);
            // 
            // SearchTeachertextBox
            // 
            this.SearchTeachertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTeachertextBox.Location = new System.Drawing.Point(266, 53);
            this.SearchTeachertextBox.Name = "SearchTeachertextBox";
            this.SearchTeachertextBox.Size = new System.Drawing.Size(405, 29);
            this.SearchTeachertextBox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Search Teacher";
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
            // ViewTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.ControlBox = false;
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.SearchTeacherButton);
            this.Controls.Add(this.SearchTeachertextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewTeacherstsdataGridView);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ViewTeachersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTeachersForm";
            ((System.ComponentModel.ISupportInitialize)(this.viewTeacherstsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button SearchTeacherButton;
        private System.Windows.Forms.TextBox SearchTeachertextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewTeacherstsdataGridView;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}