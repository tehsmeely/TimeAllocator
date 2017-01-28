namespace TimeAllocator
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuBar = new System.Windows.Forms.ToolStrip();
            this.settings = new System.Windows.Forms.ToolStripButton();
            this.newActivity = new System.Windows.Forms.Button();
            this.activityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activityStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activityEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.336823F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.32635F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.336823F));
            this.tableLayoutPanel1.Controls.Add(this.newActivity, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.61853F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.38147F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 367);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.activityName,
            this.activityStart,
            this.activityEnd});
            this.listView1.Location = new System.Drawing.Point(52, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(429, 289);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(559, 25);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuBar";
            this.menuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuBar_ItemClicked);
            // 
            // settings
            // 
            this.settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(23, 22);
            this.settings.Text = "Settings";
            // 
            // newActivity
            // 
            this.newActivity.Location = new System.Drawing.Point(52, 3);
            this.newActivity.Name = "newActivity";
            this.newActivity.Size = new System.Drawing.Size(429, 66);
            this.newActivity.TabIndex = 4;
            this.newActivity.Text = "New Activity";
            this.newActivity.UseVisualStyleBackColor = true;
            this.newActivity.Click += new System.EventHandler(this.newActivity_Click);
            // 
            // activityName
            // 
            this.activityName.Text = "Activity";
            this.activityName.Width = 149;
            // 
            // activityStart
            // 
            this.activityStart.Text = "Start Time";
            this.activityStart.Width = 74;
            // 
            // activityEnd
            // 
            this.activityEnd.Text = "End";
            this.activityEnd.Width = 316;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 546);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EntryForm";
            this.Text = "TimeAllocator";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip menuBar;
        private System.Windows.Forms.ToolStripButton settings;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button newActivity;
        private System.Windows.Forms.ColumnHeader activityName;
        private System.Windows.Forms.ColumnHeader activityStart;
        private System.Windows.Forms.ColumnHeader activityEnd;
    }
}

