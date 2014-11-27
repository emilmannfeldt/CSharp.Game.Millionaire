using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postkodmiljonaren
{
    class Question

    {
        public Question(string Q, string AnsweA, string AnsweB, string AnsweC, string AnsweD, string correct, int diff)
        {
             q = Q;
             answera = AnsweA;
             answerb = AnsweB;
             answerc = AnsweC;
             answerd = AnsweD;
             corr = correct;
             diffi = diff;

        }

public    Question()
    {
        // TODO: Complete member initialization
    }

        public string corr { get; set; }
        public int diffi { get; set; }
        public string q { get; set;}
        public string answera { get; set;}
        public string answerb { get; set;}
        public string answerc { get; set;}
        public string answerd { get; set;}

    }

    }

