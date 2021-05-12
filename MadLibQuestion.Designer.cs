
namespace Madlibs
{
    partial class MadLibQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public bool IsButtonPressed { get; private set; }
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(13, 20);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(55, 13);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "LOADING";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.Location = new System.Drawing.Point(158, 81);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(75, 23);
            this.ButtonContinue.TabIndex = 2;
            this.ButtonContinue.Text = "Continue";
            this.ButtonContinue.UseVisualStyleBackColor = true;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            // 
            // MadLibQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 116);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonContinue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QuestionLabel);
            this.MaximumSize = new System.Drawing.Size(415, 155);
            this.MinimumSize = new System.Drawing.Size(415, 155);
            this.Name = "MadLibQuestion";
            this.Text = "MadLibQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label QuestionLabel;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button ButtonContinue;
    }
}