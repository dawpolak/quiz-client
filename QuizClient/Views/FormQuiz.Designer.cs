namespace QuizClient
{
    partial class FormQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuestion = new System.Windows.Forms.Label();
            this.flowLayoutAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelAmountOfQestions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 34);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(0, 17);
            this.labelQuestion.TabIndex = 0;
            // 
            // flowLayoutAnswers
            // 
            this.flowLayoutAnswers.AutoScroll = true;
            this.flowLayoutAnswers.Location = new System.Drawing.Point(12, 105);
            this.flowLayoutAnswers.Name = "flowLayoutAnswers";
            this.flowLayoutAnswers.Size = new System.Drawing.Size(776, 291);
            this.flowLayoutAnswers.TabIndex = 1;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(688, 402);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 36);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(12, 402);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(110, 36);
            this.buttonFinish.TabIndex = 3;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // labelAmountOfQestions
            // 
            this.labelAmountOfQestions.AutoSize = true;
            this.labelAmountOfQestions.Location = new System.Drawing.Point(601, 412);
            this.labelAmountOfQestions.Name = "labelAmountOfQestions";
            this.labelAmountOfQestions.Size = new System.Drawing.Size(0, 17);
            this.labelAmountOfQestions.TabIndex = 4;
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAmountOfQestions);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.flowLayoutAnswers);
            this.Controls.Add(this.labelQuestion);
            this.Name = "FormQuiz";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAnswers;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelAmountOfQestions;
    }
}