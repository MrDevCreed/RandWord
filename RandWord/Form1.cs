using RandWord.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace RandWord
{
    public partial class Form1 : Form
    {
        public int IsRemoteDelayTime = 0;
        public int IsDelay = 0;
        public Game Game;
        public Form1()
        {
            InitializeComponent();
            Game = new Game();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            TimerTxt.Text = numericUpDown1.Value.ToString();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Game.IsStarted != true)
            {
                Game.Start();
                UpdateTurn();
                Next.Text = "Next";
                return;
            }

            if (Game.IsStarted)
            {
                timer1.Stop();
                var Answere = MessageBox.Show("If Sayed Correct Word?", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Answere == DialogResult.Yes)
                {
                    Game.FinishTurn(int.Parse(TimerTxt.Text), true);
                    Game.NextTurn();
                    UpdateTurn();
                    return;
                }

                Game.FinishTurn(int.Parse(TimerTxt.Text), false);
                Game.NextTurn();
                UpdateTurn();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval != 1000)
            {
                timer1.Interval = 1000;
            }

            int time = int.Parse(TimerTxt.Text);

            if (time != 1)
            {
                time--;
                TimerTxt.Text = time.ToString();
                return;
            }
            TimerTxt.Text = "0";
            timer1.Stop();
            MessageBox.Show("Time Ended");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string[] CompetitorsName = textBox1.Text.Split(",");
                foreach (var item in CompetitorsName)
                {
                    List<Competitotor> Competitors = new List<Competitotor> { new Competitotor(item, false) };
                    Game.AddCompetitors(Competitors);
                    dataGridView1.Rows.Add(item, 0, 0);
                }
            }
            if (textBox2.Text != "")
            {
                string[] IsRemoteCompetitors = textBox2.Text.Split(",");
                foreach (var item in IsRemoteCompetitors)
                {
                    List<Competitotor> Competitors = new List<Competitotor> { new Competitotor(item, true) };
                    Game.AddCompetitors(Competitors);
                    dataGridView1.Rows.Add(item, 0, 0);
                }
            }
            IsRemoteDelayTime = int.Parse(numericUpDown2.Value.ToString());
        }

        private void PouseBtn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                PouseBtn.Text = "Start";
            }
            else
            {
                timer1.Start();
                PouseBtn.Text = "Pause";
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[0].Value == dataGridView1.Rows[e.RowIndex].Cells[0].Value)
                {
                    Game.FindCompetitor(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).Score = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells[1].ValueType = typeof(Int32);
            }

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Competitotor com = Game.FindCompetitor(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            WordSayedForm wordSayedForm = new WordSayedForm(com);
            wordSayedForm.Show();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            IsRemoteDelayTime = int.Parse(numericUpDown2.Value.ToString());
        }

        public void UpdateTurn()
        {
            RoundText.Text = "Round : " + Game.Round.ToString();
            Turntxt.Text = "Turn : " + Game.CurrentTurn.Competitotor.Name;
            NextTurntxt.Text = "Next Turn : " + Game.NextCompetitorName();
            WordText.Text = Game.CurrentTurn.Word;
            TimerTxt.Text = numericUpDown1.Value.ToString();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells[1].Value = Game.FindCompetitor(item.Cells[0].Value.ToString()).Score;
                item.Cells[2].Value = Game.FindCompetitor(item.Cells[0].Value.ToString()).SayTime();
            }

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);

            if (Game.CurrentTurn.Competitotor.IsRemote == true && IsRemoteDelayTime != 0)
            {
                timer1.Interval = int.Parse(IsRemoteDelayTime.ToString() + "000");
            }

            timer1.Start();
            PouseBtn.Text = "Pause";
        }
    }
}
