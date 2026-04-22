namespace WeekendCounter1
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
            userInput = new TextBox();
            Calculate = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // userInput
            // 
            userInput.Anchor = AnchorStyles.Left;
            userInput.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userInput.Location = new Point(53, 54);
            userInput.Name = "userInput";
            userInput.Size = new Size(253, 68);
            userInput.TabIndex = 0;
            userInput.TextChanged += userInput_TextChanged;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calculate.Location = new Point(53, 215);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(253, 75);
            Calculate.TabIndex = 1;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 215);
            label1.Name = "label1";
            label1.Size = new Size(27, 30);
            label1.TabIndex = 2;
            label1.Text = "0";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Calculate);
            Controls.Add(userInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userInput;
        private Button Calculate;
        private Label label1;
    }
}
