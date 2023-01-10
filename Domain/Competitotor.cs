using System.Collections.Generic;
using System.Linq;

namespace RandWord
{
    public class Competitotor
    {
        public Competitotor(string name,bool isremote)
        {
            this.Name = name;
            this.Score = 0;
            this.CantSayedCount = 0;
            this.questions = new List<question>();
            this.IsRemote = isremote;
        }

        public string Name { get; set; }

        public int Score { get; set; }

        public int CantSayedCount { get; set; }

        public List<question> questions { get; set; }

        public bool IsRemote { get; set; }

        public int CorrectSayCount()
        {
            return questions.Count(P => P.CanSayed == true);
        }

        public int WrongSayCount()
        {
            return questions.Count(P => P.CanSayed == false);
        }

        public int SayTime()
        {
            return questions.Sum(P => P.SayTime);
        }

        public double AverageSayTime()
        {
            return questions.Average(P => P.SayTime);
        }
    }
}
