namespace GuessNumber
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
            gameStart = new Button();
            reveal = new Button();
            checkResult = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            reset = new Button();
            guessHistory = new RichTextBox();
            SuspendLayout();
            // 
            // gameStart
            // 
            gameStart.Location = new Point(24, 35);
            gameStart.Name = "gameStart";
            gameStart.Size = new Size(112, 34);
            gameStart.TabIndex = 0;
            gameStart.Text = "開始遊戲";
            gameStart.UseVisualStyleBackColor = true;
            gameStart.Click += gameStart_Click;
            // 
            // reveal
            // 
            reveal.Location = new Point(24, 104);
            reveal.Name = "reveal";
            reveal.Size = new Size(112, 34);
            reveal.TabIndex = 1;
            reveal.Text = "看答案";
            reveal.UseVisualStyleBackColor = true;
            reveal.Click += reveal_Click;
            // 
            // checkResult
            // 
            checkResult.Location = new Point(24, 386);
            checkResult.Name = "checkResult";
            checkResult.Size = new Size(112, 34);
            checkResult.TabIndex = 2;
            checkResult.Text = "檢查答案";
            checkResult.UseVisualStyleBackColor = true;
            checkResult.Click += checkResult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 293);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 4;
            label1.Text = "輸入";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 319);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 30);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 32);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 7;
            label2.Text = "遊戲歷程";
            // 
            // reset
            // 
            reset.Location = new Point(168, 386);
            reset.Name = "reset";
            reset.Size = new Size(112, 34);
            reset.TabIndex = 10;
            reset.Text = "放棄重來";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // guessHistory
            // 
            guessHistory.Location = new Point(461, 58);
            guessHistory.Name = "guessHistory";
            guessHistory.Size = new Size(270, 326);
            guessHistory.TabIndex = 13;
            guessHistory.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reset);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(checkResult);
            Controls.Add(reveal);
            Controls.Add(gameStart);
            Controls.Add(guessHistory);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button gameStart;
        private Button reveal;
        private Button checkResult;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button reset;
        private RichTextBox guessHistory;
    }
}
