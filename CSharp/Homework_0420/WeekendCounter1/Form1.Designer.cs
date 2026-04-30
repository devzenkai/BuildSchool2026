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
            Enter = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // userInput
            // 
            userInput.Anchor = AnchorStyles.Left;
            userInput.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userInput.Location = new Point(83, 83);
            userInput.Margin = new Padding(5);
            userInput.Name = "userInput";
            userInput.Size = new Size(395, 99);
            userInput.TabIndex = 0;
            userInput.TextChanged += userInput_TextChanged;
            // 
            // Enter
            // 
            Enter.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter.Location = new Point(83, 330);
            Enter.Margin = new Padding(5);
            Enter.Name = "Enter";
            Enter.Size = new Size(398, 115);
            Enter.TabIndex = 1;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Calculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(545, 330);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 46);
            label1.TabIndex = 2;
            label1.Text = "0";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 690);
            Controls.Add(label1);
            Controls.Add(Enter);
            Controls.Add(userInput);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userInput;
        private Button Enter;
        private Label label1;
    }
}
