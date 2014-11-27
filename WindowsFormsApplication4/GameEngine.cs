using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postkodmiljonaren
{
    class GameEngine
    {
        List<Question> easyQ = new List<Question>();
        List<Question> mediumQ = new List<Question>();
        List<Question> hardQ = new List<Question>();

      public void AddQuestion (string q, string aa, string ab, string ac, string ad, string co, string dif) 
      {

          try
          {
              
             // StreamWriter w = File.AppendText(@"questions.txt");
              File.AppendAllText(@"questions.txt", q + "," + aa + "," + ab + "," + ac + "," + ad + "," + co + "," + dif + Environment.NewLine);
              //w.WriteLine(q + "," + aa + "," + ab + "," + ac + "," + ad + "," + co + "," + dif);
            

          }
          catch (Exception e)
          {
              throw e;
          }

          

      }

      public void InstansiateQ()
      {
          string line;
          //easyQ.Add(new Question("ej","hej","hej","hej","hej","hej",1));

          int diffe;
          System.IO.StreamReader file =
              new System.IO.StreamReader(@"questions.txt");
          while ((line = file.ReadLine()) != null)
          {
              string[] words = line.Split(',');
           
              diffe = Convert.ToInt32(words[6]); 
              if (diffe.Equals(1))
              {
                  easyQ.Add(new Question(words[0], words[1], words[2], words[3], words[4], words[5], 1));

              }
              else if (diffe.Equals(2))
              {
                  mediumQ.Add(new Question(words[0], words[1], words[2], words[3], words[4], words[5], 2));
              }
              else if (diffe.Equals(3))
              {
                  hardQ.Add(new Question(words[0], words[1], words[2], words[3], words[4], words[5], 3));
              }
             
          }

          file.Close();

      }
      private Question GetEasyQuestion()
      {
          Random r = new Random();
          int rInt = r.Next(0, easyQ.Count());

          Question tempq = easyQ[rInt];
          easyQ.RemoveAt(rInt);
          return tempq;
      }

      public Question GetQuestion(int i)
      {
          if (i>11)
          {
            return GetEasyQuestion();
          }
          else if (i>5)
          {
            return GetMediumQuestion();
          }
           else 
          {
            return GetHardQuestion();
          }
         
      }

      private Question GetHardQuestion()
      {
          Random r = new Random();
          int rInt = r.Next(0, hardQ.Count());
          Question tempq = hardQ[rInt];
          hardQ.RemoveAt(rInt);
          return tempq;
      }

      private Question GetMediumQuestion()
      {
          Random r = new Random();
          int rInt = r.Next(0, mediumQ.Count());

          Question tempq = mediumQ[rInt];
          mediumQ.RemoveAt(rInt);
          return tempq;
      }

        public string checkanswer(Question q)
        {
            if(q.corr.Equals("A"))
            {
                return q.answera;
            }
            else if (q.corr.Equals("B"))
            {
                return q.answerb;
            }
            else if (q.corr.Equals("C"))
            {
                return q.answerc;
            }
            else if (q.corr.Equals("D"))
            {
                return q.answerd;
            }
            else
            {
                return "x";
            }
        }






        public int calculatemoney(int a)
        {
            
            {
                return 1000;
            }
            
        }
    }
}
