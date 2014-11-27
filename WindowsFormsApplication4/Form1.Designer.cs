namespace Postkodmiljonaren
{
    partial class Form1
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
            this.RadioA = new System.Windows.Forms.RadioButton();
            this.RadioD = new System.Windows.Forms.RadioButton();
            this.RadioB = new System.Windows.Forms.RadioButton();
            this.RadioC = new System.Windows.Forms.RadioButton();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.HalfButton = new System.Windows.Forms.Button();
            this.AskButton = new System.Windows.Forms.Button();
            this.NewQuestionButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.AddQButton = new System.Windows.Forms.Button();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.AnswerABox = new System.Windows.Forms.TextBox();
            this.AnswerBBox = new System.Windows.Forms.TextBox();
            this.AnswerCBox = new System.Windows.Forms.TextBox();
            this.AnswerDBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.DiffNummer = new System.Windows.Forms.NumericUpDown();
            this.AddCorrectA = new System.Windows.Forms.RadioButton();
            this.AddCorrectB = new System.Windows.Forms.RadioButton();
            this.AddCorrectC = new System.Windows.Forms.RadioButton();
            this.AddCorrectD = new System.Windows.Forms.RadioButton();
            this.diffLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.WinLabel = new System.Windows.Forms.Label();
            this.RightAnswerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DiffNummer)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioA
            // 
            this.RadioA.AutoSize = true;
            this.RadioA.Location = new System.Drawing.Point(144, 186);
            this.RadioA.Name = "RadioA";
            this.RadioA.Size = new System.Drawing.Size(60, 17);
            this.RadioA.TabIndex = 0;
            this.RadioA.TabStop = true;
            this.RadioA.Text = "RadioA";
            this.RadioA.UseVisualStyleBackColor = true;
            // 
            // RadioD
            // 
            this.RadioD.AutoSize = true;
            this.RadioD.Location = new System.Drawing.Point(144, 255);
            this.RadioD.Name = "RadioD";
            this.RadioD.Size = new System.Drawing.Size(61, 17);
            this.RadioD.TabIndex = 1;
            this.RadioD.TabStop = true;
            this.RadioD.Text = "RadioD";
            this.RadioD.UseVisualStyleBackColor = true;
            // 
            // RadioB
            // 
            this.RadioB.AutoSize = true;
            this.RadioB.Location = new System.Drawing.Point(144, 209);
            this.RadioB.Name = "RadioB";
            this.RadioB.Size = new System.Drawing.Size(60, 17);
            this.RadioB.TabIndex = 2;
            this.RadioB.TabStop = true;
            this.RadioB.Text = "RadioB";
            this.RadioB.UseVisualStyleBackColor = true;
            // 
            // RadioC
            // 
            this.RadioC.AutoSize = true;
            this.RadioC.Location = new System.Drawing.Point(144, 232);
            this.RadioC.Name = "RadioC";
            this.RadioC.Size = new System.Drawing.Size(60, 17);
            this.RadioC.TabIndex = 3;
            this.RadioC.TabStop = true;
            this.RadioC.Text = "RadioC";
            this.RadioC.UseVisualStyleBackColor = true;
            // 
            // AnswerButton
            // 
            this.AnswerButton.Location = new System.Drawing.Point(144, 278);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(75, 40);
            this.AnswerButton.TabIndex = 4;
            this.AnswerButton.Text = "Svara";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(141, 113);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(75, 13);
            this.QuestionLabel.TabIndex = 5;
            this.QuestionLabel.Text = "QuestionLabel";
            // 
            // HalfButton
            // 
            this.HalfButton.Location = new System.Drawing.Point(399, 237);
            this.HalfButton.Name = "HalfButton";
            this.HalfButton.Size = new System.Drawing.Size(92, 23);
            this.HalfButton.TabIndex = 6;
            this.HalfButton.Text = "50/50";
            this.HalfButton.UseVisualStyleBackColor = true;
            this.HalfButton.Click += new System.EventHandler(this.HalfButton_Click);
            // 
            // AskButton
            // 
            this.AskButton.Location = new System.Drawing.Point(399, 266);
            this.AskButton.Name = "AskButton";
            this.AskButton.Size = new System.Drawing.Size(92, 23);
            this.AskButton.TabIndex = 7;
            this.AskButton.Text = "Fråga Publiken";
            this.AskButton.UseVisualStyleBackColor = true;
            // 
            // NewQuestionButton
            // 
            this.NewQuestionButton.Location = new System.Drawing.Point(399, 295);
            this.NewQuestionButton.Name = "NewQuestionButton";
            this.NewQuestionButton.Size = new System.Drawing.Size(92, 23);
            this.NewQuestionButton.TabIndex = 8;
            this.NewQuestionButton.Text = "Ny fråga";
            this.NewQuestionButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(399, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(92, 225);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 278);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 40);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AddQButton
            // 
            this.AddQButton.Location = new System.Drawing.Point(12, 12);
            this.AddQButton.Name = "AddQButton";
            this.AddQButton.Size = new System.Drawing.Size(90, 23);
            this.AddQButton.TabIndex = 11;
            this.AddQButton.Text = "Lägg till frågor";
            this.AddQButton.UseVisualStyleBackColor = true;
            this.AddQButton.Click += new System.EventHandler(this.AddQButton_Click);
            // 
            // QuestionBox
            // 
            this.QuestionBox.Location = new System.Drawing.Point(12, 62);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(207, 20);
            this.QuestionBox.TabIndex = 12;
            this.QuestionBox.Text = "Fråga";
            // 
            // AnswerABox
            // 
            this.AnswerABox.Location = new System.Drawing.Point(12, 88);
            this.AnswerABox.Name = "AnswerABox";
            this.AnswerABox.Size = new System.Drawing.Size(100, 20);
            this.AnswerABox.TabIndex = 13;
            this.AnswerABox.Text = "AnswerA";
            // 
            // AnswerBBox
            // 
            this.AnswerBBox.Location = new System.Drawing.Point(12, 114);
            this.AnswerBBox.Name = "AnswerBBox";
            this.AnswerBBox.Size = new System.Drawing.Size(100, 20);
            this.AnswerBBox.TabIndex = 14;
            this.AnswerBBox.Text = "AnswerB";
            // 
            // AnswerCBox
            // 
            this.AnswerCBox.Location = new System.Drawing.Point(12, 140);
            this.AnswerCBox.Name = "AnswerCBox";
            this.AnswerCBox.Size = new System.Drawing.Size(100, 20);
            this.AnswerCBox.TabIndex = 15;
            this.AnswerCBox.Text = "AnswerC";
            // 
            // AnswerDBox
            // 
            this.AnswerDBox.Location = new System.Drawing.Point(12, 166);
            this.AnswerDBox.Name = "AnswerDBox";
            this.AnswerDBox.Size = new System.Drawing.Size(100, 20);
            this.AnswerDBox.TabIndex = 16;
            this.AnswerDBox.Text = "AnswerD";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(12, 274);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(66, 23);
            this.DoneButton.TabIndex = 19;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(12, 245);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(66, 23);
            this.AddQuestionButton.TabIndex = 20;
            this.AddQuestionButton.Text = "Add";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // DiffNummer
            // 
            this.DiffNummer.Location = new System.Drawing.Point(12, 192);
            this.DiffNummer.Name = "DiffNummer";
            this.DiffNummer.Size = new System.Drawing.Size(32, 20);
            this.DiffNummer.TabIndex = 21;
            this.DiffNummer.ValueChanged += new System.EventHandler(this.DiffNummer_ValueChanged);
            // 
            // AddCorrectA
            // 
            this.AddCorrectA.AutoSize = true;
            this.AddCorrectA.Location = new System.Drawing.Point(118, 88);
            this.AddCorrectA.Name = "AddCorrectA";
            this.AddCorrectA.Size = new System.Drawing.Size(45, 17);
            this.AddCorrectA.TabIndex = 22;
            this.AddCorrectA.TabStop = true;
            this.AddCorrectA.Text = "Rätt";
            this.AddCorrectA.UseVisualStyleBackColor = true;
            // 
            // AddCorrectB
            // 
            this.AddCorrectB.AutoSize = true;
            this.AddCorrectB.Location = new System.Drawing.Point(118, 114);
            this.AddCorrectB.Name = "AddCorrectB";
            this.AddCorrectB.Size = new System.Drawing.Size(45, 17);
            this.AddCorrectB.TabIndex = 23;
            this.AddCorrectB.TabStop = true;
            this.AddCorrectB.Text = "Rätt";
            this.AddCorrectB.UseVisualStyleBackColor = true;
            // 
            // AddCorrectC
            // 
            this.AddCorrectC.AutoSize = true;
            this.AddCorrectC.Location = new System.Drawing.Point(118, 140);
            this.AddCorrectC.Name = "AddCorrectC";
            this.AddCorrectC.Size = new System.Drawing.Size(45, 17);
            this.AddCorrectC.TabIndex = 24;
            this.AddCorrectC.TabStop = true;
            this.AddCorrectC.Text = "Rätt";
            this.AddCorrectC.UseVisualStyleBackColor = true;
            // 
            // AddCorrectD
            // 
            this.AddCorrectD.AutoSize = true;
            this.AddCorrectD.Location = new System.Drawing.Point(118, 166);
            this.AddCorrectD.Name = "AddCorrectD";
            this.AddCorrectD.Size = new System.Drawing.Size(45, 17);
            this.AddCorrectD.TabIndex = 25;
            this.AddCorrectD.TabStop = true;
            this.AddCorrectD.Text = "Rätt";
            this.AddCorrectD.UseVisualStyleBackColor = true;
            // 
            // diffLabel
            // 
            this.diffLabel.AutoSize = true;
            this.diffLabel.Location = new System.Drawing.Point(50, 194);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(78, 13);
            this.diffLabel.TabIndex = 26;
            this.diffLabel.Text = "Svårighetsgrad";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(241, 283);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(0, 26);
            this.TimerLabel.TabIndex = 27;
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.Location = new System.Drawing.Point(158, 21);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(0, 13);
            this.WinLabel.TabIndex = 28;
            // 
            // RightAnswerLabel
            // 
            this.RightAnswerLabel.AutoSize = true;
            this.RightAnswerLabel.Location = new System.Drawing.Point(141, 160);
            this.RightAnswerLabel.Name = "RightAnswerLabel";
            this.RightAnswerLabel.Size = new System.Drawing.Size(0, 13);
            this.RightAnswerLabel.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 325);
            this.Controls.Add(this.RightAnswerLabel);
            this.Controls.Add(this.WinLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.diffLabel);
            this.Controls.Add(this.AddCorrectD);
            this.Controls.Add(this.AddCorrectC);
            this.Controls.Add(this.AddCorrectB);
            this.Controls.Add(this.AddCorrectA);
            this.Controls.Add(this.DiffNummer);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.AnswerDBox);
            this.Controls.Add(this.AnswerCBox);
            this.Controls.Add(this.AnswerBBox);
            this.Controls.Add(this.AnswerABox);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.AddQButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.NewQuestionButton);
            this.Controls.Add(this.AskButton);
            this.Controls.Add(this.HalfButton);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.RadioC);
            this.Controls.Add(this.RadioB);
            this.Controls.Add(this.RadioD);
            this.Controls.Add(this.RadioA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DiffNummer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioA;
        private System.Windows.Forms.RadioButton RadioD;
        private System.Windows.Forms.RadioButton RadioB;
        private System.Windows.Forms.RadioButton RadioC;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button HalfButton;
        private System.Windows.Forms.Button AskButton;
        private System.Windows.Forms.Button NewQuestionButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button AddQButton;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.TextBox AnswerABox;
        private System.Windows.Forms.TextBox AnswerBBox;
        private System.Windows.Forms.TextBox AnswerCBox;
        private System.Windows.Forms.TextBox AnswerDBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.NumericUpDown DiffNummer;
        private System.Windows.Forms.RadioButton AddCorrectA;
        private System.Windows.Forms.RadioButton AddCorrectB;
        private System.Windows.Forms.RadioButton AddCorrectC;
        private System.Windows.Forms.RadioButton AddCorrectD;
        private System.Windows.Forms.Label diffLabel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label WinLabel;
        private System.Windows.Forms.Label RightAnswerLabel;
    }
}

