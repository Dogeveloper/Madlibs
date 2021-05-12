
namespace Madlibs
{
    partial class MadLibOutput
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
            this.OutputText = new System.Windows.Forms.TextBox();
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputText
            // 
            this.OutputText.AcceptsReturn = true;
            this.OutputText.AcceptsTab = true;
            this.OutputText.Location = new System.Drawing.Point(13, 13);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.Size = new System.Drawing.Size(561, 132);
            this.OutputText.TabIndex = 0;
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.Location = new System.Drawing.Point(123, 166);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(142, 23);
            this.CopyToClipboard.TabIndex = 1;
            this.CopyToClipboard.Text = "Copy to Clipboard";
            this.CopyToClipboard.UseVisualStyleBackColor = true;
            this.CopyToClipboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.Location = new System.Drawing.Point(308, 166);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(142, 23);
            this.CloseApp.TabIndex = 2;
            this.CloseApp.Text = "Close";
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // MadLibOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 214);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.CopyToClipboard);
            this.Controls.Add(this.OutputText);
            this.MaximumSize = new System.Drawing.Size(602, 253);
            this.MinimumSize = new System.Drawing.Size(602, 253);
            this.Name = "MadLibOutput";
            this.Text = "Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button CopyToClipboard;
        private System.Windows.Forms.Button CloseApp;
    }
}