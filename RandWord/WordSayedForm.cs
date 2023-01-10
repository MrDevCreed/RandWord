using System;
using System.Windows.Forms;

namespace RandWord
{
    public partial class WordSayedForm : Form
    {
        public Competitotor Competitotor;
        public WordSayedForm(Competitotor competitotor)
        {
            Competitotor = competitotor;
            InitializeComponent();
        }

        private void WordSayedForm_Load(object sender, EventArgs e)
        {
            this.Text = "Data Table For " + Competitotor.Name;

            foreach (var item in Competitotor.questions)
            {
                if (item.CanSayed == true)
                {
                    dataGridView1.Rows.Add(item.Word, "OK",item.Score,item.SayTime);
                }
                else
                {
                    dataGridView1.Rows.Add(item.Word, "-", item.Score, item.SayTime);
                }
            }

            label1.Text = "Correct Say Count : " + Competitotor.CorrectSayCount();
            label3.Text = "Wrong Say Count : " + Competitotor.WrongSayCount();
            label2.Text = "Say Time : " + Competitotor.SayTime();
            label4.Text = "Average Time Count : " + Competitotor.AverageSayTime();
        }
    }
}
