namespace TimeAllocator
{
    partial class ActivityEntryForm
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
            this.activityEntryText = new System.Windows.Forms.TextBox();
            this.entryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activityEntryText
            // 
            this.activityEntryText.Location = new System.Drawing.Point(12, 59);
            this.activityEntryText.Name = "activityEntryText";
            this.activityEntryText.Size = new System.Drawing.Size(260, 20);
            this.activityEntryText.TabIndex = 0;
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(41, 134);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(189, 66);
            this.entryButton.TabIndex = 1;
            this.entryButton.Text = "Enter";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // ActivityEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.entryButton);
            this.Controls.Add(this.activityEntryText);
            this.Name = "ActivityEntryForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox activityEntryText;
        private System.Windows.Forms.Button entryButton;
    }
}