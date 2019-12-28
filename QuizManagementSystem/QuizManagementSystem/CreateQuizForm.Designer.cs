namespace QuizManagementSystem
{
    partial class CreateQuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuizForm));
            this.QuizIDtextBox = new System.Windows.Forms.TextBox();
            this.QuizIDlabel = new System.Windows.Forms.Label();
            this.CourseNamelabel = new System.Windows.Forms.Label();
            this.AddQuestionlabel = new System.Windows.Forms.Label();
            this.AddQuestiontextBox = new System.Windows.Forms.TextBox();
            this.OptionAtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OptionBtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OptionCtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OptionDtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.NextQuestionbutton = new System.Windows.Forms.Button();
            this.CreateQuiz1button = new System.Windows.Forms.Button();
            this.MustBeUniquelabel = new System.Windows.Forms.Label();
            this.CorrectAnswerlabel = new System.Windows.Forms.Label();
            this.CorrectAnswertextBox = new System.Windows.Forms.TextBox();
            this.projectDatabaseDataSet = new QuizManagementSystem.ProjectDatabaseDataSet();
            this.projectDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CourseNamecomboBox = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new QuizManagementSystem.ProjectDatabaseDataSetTableAdapters.TeachersTableAdapter();
            this.QuizdateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // QuizIDtextBox
            // 
            this.QuizIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizIDtextBox.Location = new System.Drawing.Point(228, 28);
            this.QuizIDtextBox.Name = "QuizIDtextBox";
            this.QuizIDtextBox.Size = new System.Drawing.Size(238, 29);
            this.QuizIDtextBox.TabIndex = 6;
            // 
            // QuizIDlabel
            // 
            this.QuizIDlabel.AutoSize = true;
            this.QuizIDlabel.BackColor = System.Drawing.Color.Transparent;
            this.QuizIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizIDlabel.ForeColor = System.Drawing.Color.White;
            this.QuizIDlabel.Location = new System.Drawing.Point(45, 31);
            this.QuizIDlabel.Name = "QuizIDlabel";
            this.QuizIDlabel.Size = new System.Drawing.Size(78, 24);
            this.QuizIDlabel.TabIndex = 5;
            this.QuizIDlabel.Text = "Quiz ID";
            // 
            // CourseNamelabel
            // 
            this.CourseNamelabel.AutoSize = true;
            this.CourseNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.CourseNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNamelabel.ForeColor = System.Drawing.Color.White;
            this.CourseNamelabel.Location = new System.Drawing.Point(45, 79);
            this.CourseNamelabel.Name = "CourseNamelabel";
            this.CourseNamelabel.Size = new System.Drawing.Size(138, 24);
            this.CourseNamelabel.TabIndex = 7;
            this.CourseNamelabel.Text = "Course Name";
            // 
            // AddQuestionlabel
            // 
            this.AddQuestionlabel.AutoSize = true;
            this.AddQuestionlabel.BackColor = System.Drawing.Color.Transparent;
            this.AddQuestionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuestionlabel.ForeColor = System.Drawing.Color.White;
            this.AddQuestionlabel.Location = new System.Drawing.Point(45, 128);
            this.AddQuestionlabel.Name = "AddQuestionlabel";
            this.AddQuestionlabel.Size = new System.Drawing.Size(138, 24);
            this.AddQuestionlabel.TabIndex = 9;
            this.AddQuestionlabel.Text = "Add Question";
            // 
            // AddQuestiontextBox
            // 
            this.AddQuestiontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuestiontextBox.Location = new System.Drawing.Point(49, 155);
            this.AddQuestiontextBox.Multiline = true;
            this.AddQuestiontextBox.Name = "AddQuestiontextBox";
            this.AddQuestiontextBox.Size = new System.Drawing.Size(815, 87);
            this.AddQuestiontextBox.TabIndex = 10;
            // 
            // OptionAtextBox
            // 
            this.OptionAtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionAtextBox.Location = new System.Drawing.Point(120, 263);
            this.OptionAtextBox.Name = "OptionAtextBox";
            this.OptionAtextBox.Size = new System.Drawing.Size(321, 29);
            this.OptionAtextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "A)";
            // 
            // OptionBtextBox
            // 
            this.OptionBtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionBtextBox.Location = new System.Drawing.Point(561, 263);
            this.OptionBtextBox.Name = "OptionBtextBox";
            this.OptionBtextBox.Size = new System.Drawing.Size(303, 29);
            this.OptionBtextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(478, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "B)";
            // 
            // OptionCtextBox
            // 
            this.OptionCtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionCtextBox.Location = new System.Drawing.Point(120, 341);
            this.OptionCtextBox.Name = "OptionCtextBox";
            this.OptionCtextBox.Size = new System.Drawing.Size(321, 29);
            this.OptionCtextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "C)";
            // 
            // OptionDtextBox
            // 
            this.OptionDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionDtextBox.Location = new System.Drawing.Point(561, 341);
            this.OptionDtextBox.Name = "OptionDtextBox";
            this.OptionDtextBox.Size = new System.Drawing.Size(303, 29);
            this.OptionDtextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(478, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "D)";
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.ForeColor = System.Drawing.Color.White;
            this.MainMenuButton.Location = new System.Drawing.Point(32, 465);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(256, 35);
            this.MainMenuButton.TabIndex = 19;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // NextQuestionbutton
            // 
            this.NextQuestionbutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.NextQuestionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextQuestionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestionbutton.ForeColor = System.Drawing.Color.White;
            this.NextQuestionbutton.Location = new System.Drawing.Point(327, 465);
            this.NextQuestionbutton.Name = "NextQuestionbutton";
            this.NextQuestionbutton.Size = new System.Drawing.Size(256, 35);
            this.NextQuestionbutton.TabIndex = 20;
            this.NextQuestionbutton.Text = "Next Question";
            this.NextQuestionbutton.UseVisualStyleBackColor = false;
            this.NextQuestionbutton.Click += new System.EventHandler(this.NextQuestionbutton_Click);
            // 
            // CreateQuiz1button
            // 
            this.CreateQuiz1button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CreateQuiz1button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateQuiz1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateQuiz1button.ForeColor = System.Drawing.Color.White;
            this.CreateQuiz1button.Location = new System.Drawing.Point(624, 465);
            this.CreateQuiz1button.Name = "CreateQuiz1button";
            this.CreateQuiz1button.Size = new System.Drawing.Size(256, 35);
            this.CreateQuiz1button.TabIndex = 21;
            this.CreateQuiz1button.Text = "Create Quiz";
            this.CreateQuiz1button.UseVisualStyleBackColor = false;
            this.CreateQuiz1button.Click += new System.EventHandler(this.CreateQuiz1button_Click);
            // 
            // MustBeUniquelabel
            // 
            this.MustBeUniquelabel.AutoSize = true;
            this.MustBeUniquelabel.BackColor = System.Drawing.Color.Transparent;
            this.MustBeUniquelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MustBeUniquelabel.ForeColor = System.Drawing.Color.White;
            this.MustBeUniquelabel.Location = new System.Drawing.Point(479, 42);
            this.MustBeUniquelabel.Name = "MustBeUniquelabel";
            this.MustBeUniquelabel.Size = new System.Drawing.Size(98, 13);
            this.MustBeUniquelabel.TabIndex = 22;
            this.MustBeUniquelabel.Text = "*must be unique";
            // 
            // CorrectAnswerlabel
            // 
            this.CorrectAnswerlabel.AutoSize = true;
            this.CorrectAnswerlabel.BackColor = System.Drawing.Color.Transparent;
            this.CorrectAnswerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswerlabel.ForeColor = System.Drawing.Color.White;
            this.CorrectAnswerlabel.Location = new System.Drawing.Point(224, 410);
            this.CorrectAnswerlabel.Name = "CorrectAnswerlabel";
            this.CorrectAnswerlabel.Size = new System.Drawing.Size(154, 24);
            this.CorrectAnswerlabel.TabIndex = 23;
            this.CorrectAnswerlabel.Text = "Correct Answer";
            // 
            // CorrectAnswertextBox
            // 
            this.CorrectAnswertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswertextBox.Location = new System.Drawing.Point(411, 407);
            this.CorrectAnswertextBox.Name = "CorrectAnswertextBox";
            this.CorrectAnswertextBox.Size = new System.Drawing.Size(321, 29);
            this.CorrectAnswertextBox.TabIndex = 24;
            // 
            // projectDatabaseDataSet
            // 
            this.projectDatabaseDataSet.DataSetName = "ProjectDatabaseDataSet";
            this.projectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectDatabaseDataSetBindingSource
            // 
            this.projectDatabaseDataSetBindingSource.DataSource = this.projectDatabaseDataSet;
            this.projectDatabaseDataSetBindingSource.Position = 0;
            // 
            // CourseNamecomboBox
            // 
            this.CourseNamecomboBox.DataSource = this.teachersBindingSource;
            this.CourseNamecomboBox.DisplayMember = "CourseName";
            this.CourseNamecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNamecomboBox.FormattingEnabled = true;
            this.CourseNamecomboBox.Location = new System.Drawing.Point(228, 71);
            this.CourseNamecomboBox.Name = "CourseNamecomboBox";
            this.CourseNamecomboBox.Size = new System.Drawing.Size(238, 32);
            this.CourseNamecomboBox.TabIndex = 25;
            this.CourseNamecomboBox.ValueMember = "CourseName";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.projectDatabaseDataSetBindingSource;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // QuizdateTimePicker
            // 
            this.QuizdateTimePicker.Location = new System.Drawing.Point(699, 12);
            this.QuizdateTimePicker.Name = "QuizdateTimePicker";
            this.QuizdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.QuizdateTimePicker.TabIndex = 26;
            // 
            // CreateQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.ControlBox = false;
            this.Controls.Add(this.QuizdateTimePicker);
            this.Controls.Add(this.CourseNamecomboBox);
            this.Controls.Add(this.CorrectAnswertextBox);
            this.Controls.Add(this.CorrectAnswerlabel);
            this.Controls.Add(this.MustBeUniquelabel);
            this.Controls.Add(this.CreateQuiz1button);
            this.Controls.Add(this.NextQuestionbutton);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.OptionDtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OptionCtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OptionBtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OptionAtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddQuestiontextBox);
            this.Controls.Add(this.AddQuestionlabel);
            this.Controls.Add(this.CourseNamelabel);
            this.Controls.Add(this.QuizIDtextBox);
            this.Controls.Add(this.QuizIDlabel);
            this.Name = "CreateQuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateQuizForm";
            this.Load += new System.EventHandler(this.CreateQuizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuizIDtextBox;
        private System.Windows.Forms.Label QuizIDlabel;
        private System.Windows.Forms.Label CourseNamelabel;
        private System.Windows.Forms.Label AddQuestionlabel;
        private System.Windows.Forms.TextBox AddQuestiontextBox;
        private System.Windows.Forms.TextBox OptionAtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OptionBtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OptionCtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OptionDtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button NextQuestionbutton;
        private System.Windows.Forms.Button CreateQuiz1button;
        private System.Windows.Forms.Label MustBeUniquelabel;
        private System.Windows.Forms.Label CorrectAnswerlabel;
        private System.Windows.Forms.TextBox CorrectAnswertextBox;
        private System.Windows.Forms.BindingSource projectDatabaseDataSetBindingSource;
        private ProjectDatabaseDataSet projectDatabaseDataSet;
        private System.Windows.Forms.ComboBox CourseNamecomboBox;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private ProjectDatabaseDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DateTimePicker QuizdateTimePicker;
    }
}