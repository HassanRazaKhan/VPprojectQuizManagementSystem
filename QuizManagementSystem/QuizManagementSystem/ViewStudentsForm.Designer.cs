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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchStudentButton = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.viewStudentsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewStudentsdataGridView_CellContentClick);
            // 
            // SearchStudenttextBox
            // 
            this.SearchStudenttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudenttextBox.Location = new System.Drawing.Point(276, 39);
            this.SearchStudenttextBox.Name = "SearchStudenttextBox";
            this.SearchStudenttextBox.Size = new System.Drawing.Size(414, 29);
            this.SearchStudenttextBox.TabIndex = 23;
            this.SearchStudenttextBox.TextChanged += new System.EventHandler(this.SearchStudenttextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search Student";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchStudentButton
            // 
            this.SearchStudentButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SearchStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudentButton.ForeColor = System.Drawing.Color.White;
            this.SearchStudentButton.Location = new System.Drawing.Point(733, 36);
            this.SearchStudentButton.Name = "SearchStudentButton";
            this.SearchStudentButton.Size = new System.Drawing.Size(122, 37);
            this.SearchStudentButton.TabIndex = 24;
            this.SearchStudentButton.Text = "Search";
            this.SearchStudentButton.UseVisualStyleBackColor = false;
            this.SearchStudentButton.Click += new System.EventHandler(this.SearchStudentButton_Click);
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
            // ViewStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.ControlBox = false;
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.SearchStudentButton);
            this.Controls.Add(this.SearchStudenttextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewStudentsdataGridView);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ViewStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudentsForm";
            this.Load += new System.EventHandler(this.ViewStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.DataGridView viewStudentsdataGridView;
        private System.Windows.Forms.TextBox SearchStudenttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchStudentButton;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}