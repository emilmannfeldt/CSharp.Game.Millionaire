using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Postkodmiljonaren
{
    public partial class Form1 : Form
    {
        GameEngine ge = new GameEngine();
        int answeredquestions = 15;
        Question question1;
        int money;
        
        public Form1()
        {
            //states of gui componets
            InitializeComponent();
            QuestionLabel.Visible = false;
            RadioA.Visible = false;
            RadioB.Visible = false;
            RadioC.Visible = false;
            RadioD.Visible = false;
            QuestionBox.Visible = false;
            AnswerABox.Visible = false;
            AnswerBBox.Visible = false;
            AnswerCBox.Visible = false;
            AnswerDBox.Visible = false;
            DiffNummer.Maximum = 3;
            DiffNummer.Minimum = 1;
            DiffNummer.Visible = false;
            DoneButton.Visible = false;
            AddQuestionButton.Visible = false;
            AddCorrectA.Visible = false;
            AddCorrectB.Visible = false;
            AddCorrectC.Visible = false;
            AddCorrectD.Visible = false;
            AnswerButton.Enabled = false;
            AskButton.Enabled = false;
            HalfButton.Enabled = false;
           
            NewQuestionButton.Enabled = false;
            listBox1.Enabled = false;
            diffLabel.Visible = false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void HalfButton_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            RightAnswerLabel.ResetText();
            WinLabel.ResetText();
            listBox1.Items.Clear();
            QuestionLabel.Visible = true;
            RadioA.Visible = true;
            RadioB.Visible = true;
            RadioC.Visible = true;
            RadioD.Visible = true;
            AddQButton.Enabled = false;
            StartButton.Enabled = false;
            AnswerButton.Enabled = true;
            AskButton.Enabled = true;
            HalfButton.Enabled = true;
            listBox1.Enabled = true;
            NewQuestionButton.Enabled = true;
            listBox1.Items.Add("1000000");
            listBox1.Items.Add("500000");
            listBox1.Items.Add("350000");
            listBox1.Items.Add("225000");
            listBox1.Items.Add("150000");
         
            listBox1.Items.Add("100000");
            listBox1.Items.Add("75000");
            listBox1.Items.Add("50000");
            listBox1.Items.Add("30000");
            listBox1.Items.Add("20000");
            
            listBox1.Items.Add("10000");
            listBox1.Items.Add("5000");
            listBox1.Items.Add("3000");
            listBox1.Items.Add("2000");
            listBox1.Items.Add("1000");
            ge.InstansiateQ();
            
            startround();
          
            
            












        }

        private void AddQButton_Click(object sender, EventArgs e)
        {
            QuestionBox.Visible = true;
            AnswerABox.Visible = true;
            AnswerBBox.Visible = true;
            AnswerCBox.Visible = true;
            AnswerDBox.Visible = true;
            
            DiffNummer.Visible = true;
            DoneButton.Visible = true;
            AddQuestionButton.Visible = true;
            AddCorrectA.Visible = true;
            AddCorrectB.Visible = true;
            AddCorrectC.Visible = true;
            AddCorrectD.Visible = true;
            StartButton.Visible = false;
            QuestionLabel.Visible = false;
            RadioA.Visible = false;
            RadioB.Visible = false;
            RadioC.Visible = false;
            RadioD.Visible = false;
            AnswerButton.Visible = false;
            AskButton.Visible = false;
            HalfButton.Visible = false;
            listBox1.Visible = false;
            NewQuestionButton.Visible = false;
            AddQButton.Visible = false;
            diffLabel.Visible = true;


            
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            QuestionBox.Visible = false;
            AnswerABox.Visible = false;
            AnswerBBox.Visible = false;
            AnswerCBox.Visible = false;
            AnswerDBox.Visible = false;
            diffLabel.Visible = false;
            DiffNummer.Visible = false;
            DoneButton.Visible = false;
            AddQuestionButton.Visible = false;
            AddCorrectA.Visible = false;
            AddCorrectB.Visible = false;
            AddCorrectC.Visible = false;
            AddCorrectD.Visible = false;
            StartButton.Visible = true;
            QuestionLabel.Visible = true;
            RadioA.Visible = true;
            RadioB.Visible = true;
            RadioC.Visible = true;
            RadioD.Visible = true;
            AnswerButton.Visible = true;
            AskButton.Visible = true;
            HalfButton.Visible = true;
            listBox1.Visible = true;
            NewQuestionButton.Visible = true;
            AddQButton.Visible = true;
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            string correct="x";
            if (AddCorrectA.Checked)
            {
                correct = "A";
            }
            else if (AddCorrectB.Checked)
            {
                correct = "B";
            }
            else if (AddCorrectC.Checked)
            {
                correct = "C";
            }
            else if (AddCorrectD.Checked)
            {
                correct = "D";
            }
            ge.AddQuestion(QuestionBox.Text, AnswerABox.Text, AnswerBBox.Text, AnswerCBox.Text, AnswerDBox.Text, correct, DiffNummer.Value.ToString());
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            
            string answer = "x";
            if (RadioA.Checked)
            {
                answer = RadioA.Text;
            }
            else if (RadioB.Checked)
            {
                answer = RadioB.Text;
            }
            else if (RadioC.Checked)
            {
                answer = RadioC.Text;
            }
            else if (RadioD.Checked)
            {
                answer = RadioD.Text;
            }
            
            string correct = ge.checkanswer(question1);
            if (correct.Equals(answer))
            {
                answeredquestions -= 1;
                money = Convert.ToInt32(listBox1.Items[answeredquestions]);
                
                Console.WriteLine(money);
                startround();
                
            }
            else
            {
               RightAnswerLabel.Text = " Rätt svar: " + correct;
                endgame();
            }

        }

        private void DiffNummer_ValueChanged(object sender, EventArgs e)
        {

        }
        public void startround()
        {
            listBox1.SelectedIndex = answeredquestions - 1;
            question1 = ge.GetQuestion(answeredquestions);
            QuestionLabel.Text = "Frågor kvar till miljonen: "+ answeredquestions +"\n \n" + question1.q;
            RadioA.Text = question1.answera;
            RadioB.Text = question1.answerb;
            RadioC.Text = question1.answerc;
            RadioD.Text = question1.answerd;

        

           
        }
        public void endgame()
        {
            WinLabel.Text = "Du vann "+money;
            AnswerButton.Enabled = false;
            AskButton.Enabled = false;
            HalfButton.Enabled = false;
            NewQuestionButton.Enabled = false;
            StartButton.Enabled = true;
            answeredquestions = 15;
            AddQButton.Enabled = true;
            money = 0;
        }

       
      
    }
}
