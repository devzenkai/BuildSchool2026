namespace TemperatureConversion
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
            textBox1 = new TextBox();
            button_convert = new Button();
            button_clear = new Button();
            label_result = new Label();
            num1 = new Button();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num3 = new Button();
            num2 = new Button();
            numdecimal = new Button();
            num0 = new Button();
            radioButton_CtoF = new RadioButton();
            radioButton_FtoC = new RadioButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox1.Location = new Point(590, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 50);
            textBox1.TabIndex = 0;
            // 
            // button_convert
            // 
            button_convert.Location = new Point(590, 160);
            button_convert.Name = "button_convert";
            button_convert.Size = new Size(100, 50);
            button_convert.TabIndex = 1;
            button_convert.Text = "轉換";
            button_convert.UseVisualStyleBackColor = true;
            button_convert.Click += button_convert_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(736, 160);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(100, 50);
            button_clear.TabIndex = 2;
            button_clear.Text = "清除";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Location = new Point(590, 246);
            label_result.Name = "label_result";
            label_result.Size = new Size(64, 23);
            label_result.TabIndex = 3;
            label_result.Text = "結果：";
            // 
            // num1
            // 
            num1.Location = new Point(306, 100);
            num1.Margin = new Padding(5);
            num1.Name = "num1";
            num1.Size = new Size(50, 50);
            num1.TabIndex = 4;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += NumBtnClick;
            // 
            // num9
            // 
            num9.Location = new Point(426, 219);
            num9.Margin = new Padding(5);
            num9.Name = "num9";
            num9.Size = new Size(50, 50);
            num9.TabIndex = 5;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += NumBtnClick;
            // 
            // num8
            // 
            num8.Location = new Point(366, 219);
            num8.Margin = new Padding(5);
            num8.Name = "num8";
            num8.Size = new Size(50, 50);
            num8.TabIndex = 6;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += NumBtnClick;
            // 
            // num7
            // 
            num7.Location = new Point(306, 219);
            num7.Margin = new Padding(5);
            num7.Name = "num7";
            num7.Size = new Size(50, 50);
            num7.TabIndex = 7;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += NumBtnClick;
            // 
            // num6
            // 
            num6.Location = new Point(426, 160);
            num6.Margin = new Padding(5);
            num6.Name = "num6";
            num6.Size = new Size(50, 50);
            num6.TabIndex = 8;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += NumBtnClick;
            // 
            // num5
            // 
            num5.Location = new Point(366, 160);
            num5.Margin = new Padding(5);
            num5.Name = "num5";
            num5.Size = new Size(50, 50);
            num5.TabIndex = 9;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += NumBtnClick;
            // 
            // num4
            // 
            num4.Location = new Point(306, 160);
            num4.Margin = new Padding(5);
            num4.Name = "num4";
            num4.Size = new Size(50, 50);
            num4.TabIndex = 10;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += NumBtnClick;
            // 
            // num3
            // 
            num3.Location = new Point(426, 100);
            num3.Margin = new Padding(5);
            num3.Name = "num3";
            num3.Size = new Size(50, 50);
            num3.TabIndex = 11;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += NumBtnClick;
            // 
            // num2
            // 
            num2.Location = new Point(366, 100);
            num2.Margin = new Padding(5);
            num2.Name = "num2";
            num2.Size = new Size(50, 50);
            num2.TabIndex = 12;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += NumBtnClick;
            // 
            // numdecimal
            // 
            numdecimal.Location = new Point(366, 279);
            numdecimal.Margin = new Padding(5);
            numdecimal.Name = "numdecimal";
            numdecimal.Size = new Size(50, 50);
            numdecimal.TabIndex = 13;
            numdecimal.Text = ".";
            numdecimal.UseVisualStyleBackColor = true;
            numdecimal.Click += NumBtnClick;
            // 
            // num0
            // 
            num0.Location = new Point(306, 279);
            num0.Margin = new Padding(5);
            num0.Name = "num0";
            num0.Size = new Size(50, 50);
            num0.TabIndex = 14;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += NumBtnClick;
            // 
            // radioButton_CtoF
            // 
            radioButton_CtoF.AutoSize = true;
            radioButton_CtoF.Checked = true;
            radioButton_CtoF.Location = new Point(76, 123);
            radioButton_CtoF.Name = "radioButton_CtoF";
            radioButton_CtoF.Size = new Size(161, 27);
            radioButton_CtoF.TabIndex = 15;
            radioButton_CtoF.TabStop = true;
            radioButton_CtoF.Text = "攝氏轉換為華氏";
            radioButton_CtoF.UseVisualStyleBackColor = true;
            // 
            // radioButton_FtoC
            // 
            radioButton_FtoC.AutoSize = true;
            radioButton_FtoC.Location = new Point(76, 168);
            radioButton_FtoC.Name = "radioButton_FtoC";
            radioButton_FtoC.Size = new Size(161, 27);
            radioButton_FtoC.TabIndex = 16;
            radioButton_FtoC.Text = "華氏轉換為攝氏";
            radioButton_FtoC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 450);
            Controls.Add(radioButton_FtoC);
            Controls.Add(radioButton_CtoF);
            Controls.Add(num0);
            Controls.Add(numdecimal);
            Controls.Add(num2);
            Controls.Add(num3);
            Controls.Add(num4);
            Controls.Add(num5);
            Controls.Add(num6);
            Controls.Add(num7);
            Controls.Add(num8);
            Controls.Add(num9);
            Controls.Add(num1);
            Controls.Add(label_result);
            Controls.Add(button_clear);
            Controls.Add(button_convert);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button_convert;
        private Button button_clear;
        private Label label_result;
        private Button num1;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num3;
        private Button num2;
        private Button numdecimal;
        private Button num0;
        private RadioButton radioButton_CtoF;
        private RadioButton radioButton_FtoC;
    }
}
