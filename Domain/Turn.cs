namespace RandWord.Models
{
    public class Turn
    {
        public Turn(Competitotor competitotor, string word, int roundnumber, bool isFinished)
        {
            this.Competitotor = competitotor;
            this.Word = word;
            this.RoundNmber = roundnumber;
            this.IsFinished = isFinished;
        }

        public Competitotor Competitotor { get; private set; }

        public string Word { get; private set; }

        public int RoundNmber { get; private set; }

        public bool IsFinished { get; private set; }

        public void Finish()
        {
            IsFinished = true;
        }
    }
}
