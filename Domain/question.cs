namespace RandWord
{
    public class question
    {
        public question(string word, bool cansayed, int score, int saytime)
        {
            this.Word = word;
            this.CanSayed = cansayed;
            this.Score = score;
            this.SayTime = saytime;
        }

        public string Word { get; set; }

        public bool CanSayed { get; set; }

        public int Score { get; set; }

        public int SayTime { get; set; }
    }
}
