using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class RandomWord
    {
        private Dictionary<string, int> WordsWithWeight = new Dictionary<string, int>()
        {
            { "A",20 },{"B",24 },{"C",35 },{"D",21 },{"E",14 },{"F",25 },{"G",13 },{"H",17 },{"I",12 },{"J",4 },{"K",4 },{"L",14 },{"M",18 },{"N",7 },{"O",10 },{"P",29 },{"Q",2 },{"R",19 },{"S",54 },{"T",32 },{"U",6 },{"V",4 },{"W",15 },{"Y",2 },{"Z",1 }
        };

        private List<string> Words { get; set; }

        public RandomWord()
        {
            Words = new List<string>();
            foreach (var item in WordsWithWeight)
            {
                for (int i = 0; i <= item.Value; i++)
                {
                    Words.Add(item.Key);
                }
            }

            Words = Words.OrderBy(a => Guid.NewGuid()).ToList();
        }

        public string GenarateRandomWord()
        {
            return GenarateRandomWordInternaly(Words);
        }

        public string GenarateRandomWord(List<string> ExceptedWordList)
        {
            List<string> ExceptedWords = Words.ToList();

            foreach (var item in Words)
            {
                if (ExceptedWordList.Contains(item))
                {
                    ExceptedWords.Remove(item);
                }
            }

            return GenarateRandomWordInternaly(ExceptedWords.ToList());
        }

        private string GenarateRandomWordInternaly(List<string> Words)
        {
            Random rand = new Random();
            int RandomIndex = rand.Next(0, Words.Count - 1);
            return Words[RandomIndex];
        }

    }
}
