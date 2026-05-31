namespace LifePathNumber
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            analyzeButton = new Button();
            label2 = new Label();
            lpnResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 43);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "請選擇生日";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(72, 91);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // analyzeButton
            // 
            analyzeButton.BackColor = SystemColors.ButtonHighlight;
            analyzeButton.Location = new Point(72, 164);
            analyzeButton.Name = "analyzeButton";
            analyzeButton.Size = new Size(200, 60);
            analyzeButton.TabIndex = 2;
            analyzeButton.Text = "分析結果";
            analyzeButton.UseVisualStyleBackColor = false;
            analyzeButton.Click += analyzeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 43);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "關於你";
            // 
            // lpnResult
            // 
            lpnResult.Location = new Point(363, 91);
            lpnResult.Name = "lpnResult";
            lpnResult.Size = new Size(351, 133);
            lpnResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lpnResult);
            Controls.Add(label2);
            Controls.Add(analyzeButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button analyzeButton;
        private Label label2;
        private Label lpnResult;
    }
}
