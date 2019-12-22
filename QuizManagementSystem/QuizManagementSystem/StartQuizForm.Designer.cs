namespace QuizManagementSystem
{
    partial class StartQuizForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartQuizForm));
            this.CreateQuiz1button = new System.Windows.Forms.Button();
            this.NextQuestionbutton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.QuestionHeadingLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterQuizIDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AoptionradioButton = new System.Windows.Forms.RadioButton();
            this.BoptionRadioButton = new System.Windows.Forms.RadioButton();
            this.CoptionRadioButton = new System.Windows.Forms.RadioButton();
            this.DoptionRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.StartQuizbutton = new System.Windows.Forms.Button();
            this.StartQuizCourseNamecomboBox = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDatabaseDataSet = new QuizManagementSystem.ProjectDatabaseDataSet();
            this.teachersTableAdapter = new QuizManagementSystem.ProjectDatabaseDataSetTableAdapters.TeachersTableAdapter();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.MarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateQuiz1button
            // 
            this.CreateQuiz1button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CreateQuiz1button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateQuiz1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateQuiz1button.ForeColor = System.Drawing.Color.White;
            this.CreateQuiz1button.Location = new System.Drawing.Point(623, 461);
            this.CreateQuiz1button.Name = "CreateQuiz1button";
            this.CreateQuiz1button.Size = new System.Drawing.Size(256, 35);
            this.CreateQuiz1button.TabIndex = 39;
            this.CreateQuiz1button.Text = "Sumbit Quiz";
            this.CreateQuiz1button.UseVisualStyleBackColor = false;
            // 
            // NextQuestionbutton
            // 
            this.NextQuestionbutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.NextQuestionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextQuestionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestionbutton.ForeColor = System.Drawing.Color.White;
            this.NextQuestionbutton.Location = new System.Drawing.Point(326, 461);
            this.NextQuestionbutton.Name = "NextQuestionbutton";
            this.NextQuestionbutton.Size = new System.Drawing.Size(256, 35);
            this.NextQuestionbutton.TabIndex = 38;
            this.NextQuestionbutton.Text = "Next Question";
            this.NextQuestionbutton.UseVisualStyleBackColor = false;
            this.NextQuestionbutton.Click += new System.EventHandler(this.NextQuestionbutton_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.ForeColor = System.Drawing.Color.White;
            this.MainMenuButton.Location = new System.Drawing.Point(31, 461);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(256, 35);
            this.MainMenuButton.TabIndex = 37;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // QuestionHeadingLabel
            // 
            this.QuestionHeadingLabel.AutoSize = true;
            this.QuestionHeadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionHeadingLabel.ForeColor = System.Drawing.Color.White;
            this.QuestionHeadingLabel.Location = new System.Drawing.Point(47, 145);
            this.QuestionHeadingLabel.Name = "QuestionHeadingLabel";
            this.QuestionHeadingLabel.Size = new System.Drawing.Size(94, 24);
            this.QuestionHeadingLabel.TabIndex = 27;
            this.QuestionHeadingLabel.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 25;
            // 
            // EnterQuizIDtextBox
            // 
            this.EnterQuizIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterQuizIDtextBox.Location = new System.Drawing.Point(227, 24);
            this.EnterQuizIDtextBox.Name = "EnterQuizIDtextBox";
            this.EnterQuizIDtextBox.Size = new System.Drawing.Size(238, 29);
            this.EnterQuizIDtextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Enter Quiz ID";
            // 
            // AoptionradioButton
            // 
            this.AoptionradioButton.AutoSize = true;
            this.AoptionradioButton.BackColor = System.Drawing.Color.Transparent;
            this.AoptionradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AoptionradioButton.ForeColor = System.Drawing.Color.White;
            this.AoptionradioButton.Location = new System.Drawing.Point(48, 302);
            this.AoptionradioButton.Name = "AoptionradioButton";
            this.AoptionradioButton.Size = new System.Drawing.Size(14, 13);
            this.AoptionradioButton.TabIndex = 40;
            this.AoptionradioButton.TabStop = true;
            this.AoptionradioButton.UseVisualStyleBackColor = false;
            // 
            // BoptionRadioButton
            // 
            this.BoptionRadioButton.AutoSize = true;
            this.BoptionRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.BoptionRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoptionRadioButton.ForeColor = System.Drawing.Color.White;
            this.BoptionRadioButton.Location = new System.Drawing.Point(480, 302);
            this.BoptionRadioButton.Name = "BoptionRadioButton";
            this.BoptionRadioButton.Size = new System.Drawing.Size(14, 13);
            this.BoptionRadioButton.TabIndex = 41;
            this.BoptionRadioButton.TabStop = true;
            this.BoptionRadioButton.UseVisualStyleBackColor = false;
            // 
            // CoptionRadioButton
            // 
            this.CoptionRadioButton.AutoSize = true;
            this.CoptionRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.CoptionRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoptionRadioButton.ForeColor = System.Drawing.Color.White;
            this.CoptionRadioButton.Location = new System.Drawing.Point(48, 381);
            this.CoptionRadioButton.Name = "CoptionRadioButton";
            this.CoptionRadioButton.Size = new System.Drawing.Size(14, 13);
            this.CoptionRadioButton.TabIndex = 42;
            this.CoptionRadioButton.TabStop = true;
            this.CoptionRadioButton.UseVisualStyleBackColor = false;
            // 
            // DoptionRadioButton
            // 
            this.DoptionRadioButton.AutoSize = true;
            this.DoptionRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.DoptionRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoptionRadioButton.ForeColor = System.Drawing.Color.White;
            this.DoptionRadioButton.Location = new System.Drawing.Point(480, 381);
            this.DoptionRadioButton.Name = "DoptionRadioButton";
            this.DoptionRadioButton.Size = new System.Drawing.Size(14, 13);
            this.DoptionRadioButton.TabIndex = 43;
            this.DoptionRadioButton.TabStop = true;
            this.DoptionRadioButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "Course Name";
            // 
            // StartQuizbutton
            // 
            this.StartQuizbutton.BackColor = System.Drawing.Color.Lime;
            this.StartQuizbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartQuizbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartQuizbutton.ForeColor = System.Drawing.Color.White;
            this.StartQuizbutton.Location = new System.Drawing.Point(524, 24);
            this.StartQuizbutton.Name = "StartQuizbutton";
            this.StartQuizbutton.Size = new System.Drawing.Size(141, 79);
            this.StartQuizbutton.TabIndex = 46;
            this.StartQuizbutton.Text = "Start Quiz";
            this.StartQuizbutton.UseVisualStyleBackColor = false;
            this.StartQuizbutton.Click += new System.EventHandler(this.StartQuizbutton_Click);
            // 
            // StartQuizCourseNamecomboBox
            // 
            this.StartQuizCourseNamecomboBox.DataSource = this.teachersBindingSource;
            this.StartQuizCourseNamecomboBox.DisplayMember = "CourseName";
            this.StartQuizCourseNamecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartQuizCourseNamecomboBox.FormattingEnabled = true;
            this.StartQuizCourseNamecomboBox.Location = new System.Drawing.Point(227, 71);
            this.StartQuizCourseNamecomboBox.Name = "StartQuizCourseNamecomboBox";
            this.StartQuizCourseNamecomboBox.Size = new System.Drawing.Size(238, 32);
            this.StartQuizCourseNamecomboBox.TabIndex = 47;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.projectDatabaseDataSetBindingSource;
            // 
            // projectDatabaseDataSetBindingSource
            // 
            this.projectDatabaseDataSetBindingSource.DataSource = this.projectDatabaseDataSet;
            this.projectDatabaseDataSetBindingSource.Position = 0;
            // 
            // projectDatabaseDataSet
            // 
            this.projectDatabaseDataSet.DataSetName = "ProjectDatabaseDataSet";
            this.projectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.ForeColor = System.Drawing.Color.White;
            this.QuestionLabel.Location = new System.Drawing.Point(47, 188);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(0, 24);
            this.QuestionLabel.TabIndex = 48;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(709, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(705, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Marks";
            // 
            // MarksLabel
            // 
            this.MarksLabel.AutoSize = true;
            this.MarksLabel.BackColor = System.Drawing.Color.Transparent;
            this.MarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarksLabel.ForeColor = System.Drawing.Color.White;
            this.MarksLabel.Location = new System.Drawing.Point(796, 42);
            this.MarksLabel.Name = "MarksLabel";
            this.MarksLabel.Size = new System.Drawing.Size(0, 24);
            this.MarksLabel.TabIndex = 51;
            // 
            // StartQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.ControlBox = false;
            this.Controls.Add(this.MarksLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.StartQuizCourseNamecomboBox);
            this.Controls.Add(this.StartQuizbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DoptionRadioButton);
            this.Controls.Add(this.CoptionRadioButton);
            this.Controls.Add(this.BoptionRadioButton);
            this.Controls.Add(this.AoptionradioButton);
            this.Controls.Add(this.CreateQuiz1button);
            this.Controls.Add(this.NextQuestionbutton);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.QuestionHeadingLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterQuizIDtextBox);
            this.Controls.Add(this.label1);
            this.Name = "StartQuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartQuizForm";
            this.Load += new System.EventHandler(this.StartQuizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateQuiz1button;
        private System.Windows.Forms.Button NextQuestionbutton;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label QuestionHeadingLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnterQuizIDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton AoptionradioButton;
        private System.Windows.Forms.RadioButton BoptionRadioButton;
        private System.Windows.Forms.RadioButton CoptionRadioButton;
        private System.Windows.Forms.RadioButton DoptionRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartQuizbutton;
        private System.Windows.Forms.ComboBox StartQuizCourseNamecomboBox;
        private System.Windows.Forms.BindingSource projectDatabaseDataSetBindingSource;
        private ProjectDatabaseDataSet projectDatabaseDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private ProjectDatabaseDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MarksLabel;
    }
}