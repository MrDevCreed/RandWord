
namespace RandWord
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.WordText = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerTxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Turntxt = new System.Windows.Forms.Label();
            this.NextTurntxt = new System.Windows.Forms.Label();
            this.RoundText = new System.Windows.Forms.Label();
            this.PouseBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(246, 490);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(97, 34);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // WordText
            // 
            this.WordText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WordText.AutoSize = true;
            this.WordText.Font = new System.Drawing.Font("Segoe UI", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordText.Location = new System.Drawing.Point(465, -71);
            this.WordText.Name = "WordText";
            this.WordText.Size = new System.Drawing.Size(321, 355);
            this.WordText.TabIndex = 3;
            this.WordText.Text = "A";
            this.WordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Next
            // 
            this.Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next.Location = new System.Drawing.Point(470, 275);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(142, 73);
            this.Next.TabIndex = 4;
            this.Next.Text = "Start";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerTxt
            // 
            this.TimerTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimerTxt.AutoSize = true;
            this.TimerTxt.Font = new System.Drawing.Font("Segoe UI", 130F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerTxt.Location = new System.Drawing.Point(475, 305);
            this.TimerTxt.Name = "TimerTxt";
            this.TimerTxt.Size = new System.Drawing.Size(285, 230);
            this.TimerTxt.TabIndex = 5;
            this.TimerTxt.Text = "00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Score,
            this.Time});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(792, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(442, 536);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.FillWeight = 200F;
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Score.FillWeight = 200F;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 490);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Competitors";
            this.textBox1.Size = new System.Drawing.Size(228, 34);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(349, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 73);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Turntxt
            // 
            this.Turntxt.AutoSize = true;
            this.Turntxt.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Turntxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Turntxt.Location = new System.Drawing.Point(11, 89);
            this.Turntxt.Name = "Turntxt";
            this.Turntxt.Size = new System.Drawing.Size(166, 72);
            this.Turntxt.TabIndex = 9;
            this.Turntxt.Text = "Turn :";
            // 
            // NextTurntxt
            // 
            this.NextTurntxt.AutoSize = true;
            this.NextTurntxt.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextTurntxt.Location = new System.Drawing.Point(27, 192);
            this.NextTurntxt.Name = "NextTurntxt";
            this.NextTurntxt.Size = new System.Drawing.Size(168, 42);
            this.NextTurntxt.TabIndex = 10;
            this.NextTurntxt.Text = "Next Turn :";
            // 
            // RoundText
            // 
            this.RoundText.AutoSize = true;
            this.RoundText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundText.ForeColor = System.Drawing.Color.Red;
            this.RoundText.Location = new System.Drawing.Point(12, 12);
            this.RoundText.Name = "RoundText";
            this.RoundText.Size = new System.Drawing.Size(192, 54);
            this.RoundText.TabIndex = 11;
            this.RoundText.Text = "Round : 1";
            // 
            // PouseBtn
            // 
            this.PouseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PouseBtn.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PouseBtn.Location = new System.Drawing.Point(618, 275);
            this.PouseBtn.Name = "PouseBtn";
            this.PouseBtn.Size = new System.Drawing.Size(142, 73);
            this.PouseBtn.TabIndex = 12;
            this.PouseBtn.Text = "Pause";
            this.PouseBtn.UseVisualStyleBackColor = true;
            this.PouseBtn.Click += new System.EventHandler(this.PouseBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(11, 450);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "IsRemote Competitor";
            this.textBox2.Size = new System.Drawing.Size(228, 34);
            this.textBox2.TabIndex = 14;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown2.Location = new System.Drawing.Point(245, 450);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(97, 34);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 536);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.PouseBtn);
            this.Controls.Add(this.RoundText);
            this.Controls.Add(this.NextTurntxt);
            this.Controls.Add(this.Turntxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.WordText);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.TimerTxt);
            this.Name = "Form1";
            this.Text = "RandWord";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label WordText;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Turntxt;
        private System.Windows.Forms.Label NextTurntxt;
        private System.Windows.Forms.Label RoundText;
        private System.Windows.Forms.Button PouseBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}

