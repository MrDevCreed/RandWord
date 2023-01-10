using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RandWord.Models
{
    public class Game
    {
        public Game()
        {
            this.Competitotors = new List<Competitotor>();
            this.Turns = new List<Turn>();
            this.Round = 0;
            this.IsStarted = false;
            RandomWord = new RandomWord();
        }

        public List<Competitotor> Competitotors { get; private set; }
        public Turn CurrentTurn { get; private set; }
        public List<Turn> Turns { get; set; }
        public int Round { get; private set; }
        public bool IsStarted { get; private set; }
        private RandomWord RandomWord { get; set; }


        public string NextCompetitorName()
        {
            return GetNextCompetitor().Name;
        }

        public Turn NextTurn()
        {
            if (IsStarted != true)
            {
                throw new InvalidOperationException("Game Dont Started yet");
            }

            Competitotor Competitor = GetNextCompetitor();

            if (Competitotors.Last() == CurrentTurn.Competitotor)
            {
                Round += 1;
            }

            Turns.Add(CurrentTurn);

            Turn turn = new Turn(Competitor, RandomWord.GenarateRandomWord(Competitor.questions.Select(P => P.Word).ToList()), Round, false);

            CurrentTurn = turn;

            return CurrentTurn;
        }

        private Competitotor GetNextCompetitor()
        {
            int currentIndex = Competitotors.IndexOf(CurrentTurn.Competitotor);

            if (currentIndex >= Competitotors.Count - 1)
            {
                return Competitotors.First();
            }

            return Competitotors[currentIndex + 1];
        }

        public void AddCompetitors(List<Competitotor> competitotors)
        {
            if (IsStarted == true)
            {
                throw new InvalidOperationException("Cannot Add Competitor When Game Is Starting");
            }

            if (competitotors.Select(p => p.Name).Distinct().Count() != competitotors.Count)
            {
                throw new ArgumentException("Competitor Input List Has Duplicate Name");
            }

            if (Competitotors.Any(P => competitotors.Any(O => O.Name == P.Name)))
            {
                throw new ArgumentException("Atleast one of Competitor Input Name Already Exists in the Game");
            }

            Competitotors.AddRange(competitotors);
        }

        public void Start()
        {
            this.CurrentTurn = new Turn(Competitotors.First(), RandomWord.GenarateRandomWord(), 1, false);
            this.Round = 1;
            this.IsStarted = true;
        }

        public Competitotor FindCompetitor(string name)
        {
            return Competitotors.Where(P => P.Name == name).FirstOrDefault();
        }

        public void ChangeCompetitorScore(string name, int score)
        {
            Competitotors.Where(P => P.Name == name).First().Score = score;
        }

        public void FinishTurn(int Time, bool SayedCorrect)
        {
            if (IsStarted != true)
            {
                throw new InvalidOperationException("Game Dont Started yet");
            }

            if (CurrentTurn.IsFinished == true)
            {
                throw new InvalidOperationException("Current Turn Is Already Finshed!");
            }

            if (SayedCorrect == false)
            {
                CurrentTurn.Finish();
                FindCompetitor(CurrentTurn.Competitotor.Name).questions.Add(new question(CurrentTurn.Word,SayedCorrect,0,30));
                return;
            }

            CurrentTurn.Finish();
            int score = CalculateScore(Time);
            FindCompetitor(CurrentTurn.Competitotor.Name).Score += score;
            FindCompetitor(CurrentTurn.Competitotor.Name).questions.Add(new question(CurrentTurn.Word, SayedCorrect, score, 30 - Time));
        }

        private int CalculateScore(int time)
        {
            if (time <= 0)
            {
                return 1;
            }

            int Score = time / 10 + 1;

            if (Score == 4)
            {
                Score = 3;
            }

            return Score;
        }
    }
}
