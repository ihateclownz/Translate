namespace Translator
{
    partial class Form1
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
            this.langOne_CB = new System.Windows.Forms.ComboBox();
            this.langTwo_CB = new System.Windows.Forms.ComboBox();
            this.langOne_TB = new System.Windows.Forms.RichTextBox();
            this.langTwo_TB = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewWord_BTN = new System.Windows.Forms.Button();
            this.submit_BTN = new System.Windows.Forms.Button();
            this.swap_BTN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // langOne_CB
            // 
            this.langOne_CB.FormattingEnabled = true;
            this.langOne_CB.Location = new System.Drawing.Point(48, 44);
            this.langOne_CB.Name = "langOne_CB";
            this.langOne_CB.Size = new System.Drawing.Size(146, 21);
            this.langOne_CB.TabIndex = 0;
            // 
            // langTwo_CB
            // 
            this.langTwo_CB.FormattingEnabled = true;
            this.langTwo_CB.Location = new System.Drawing.Point(234, 44);
            this.langTwo_CB.Name = "langTwo_CB";
            this.langTwo_CB.Size = new System.Drawing.Size(165, 21);
            this.langTwo_CB.TabIndex = 1;
            // 
            // langOne_TB
            // 
            this.langOne_TB.Location = new System.Drawing.Point(48, 84);
            this.langOne_TB.Name = "langOne_TB";
            this.langOne_TB.Size = new System.Drawing.Size(146, 20);
            this.langOne_TB.TabIndex = 2;
            this.langOne_TB.Text = "";
            // 
            // langTwo_TB
            // 
            this.langTwo_TB.Location = new System.Drawing.Point(234, 84);
            this.langTwo_TB.Name = "langTwo_TB";
            this.langTwo_TB.Size = new System.Drawing.Size(165, 20);
            this.langTwo_TB.TabIndex = 3;
            this.langTwo_TB.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // addNewWord_BTN
            // 
            this.addNewWord_BTN.Location = new System.Drawing.Point(48, 174);
            this.addNewWord_BTN.Name = "addNewWord_BTN";
            this.addNewWord_BTN.Size = new System.Drawing.Size(92, 23);
            this.addNewWord_BTN.TabIndex = 5;
            this.addNewWord_BTN.Text = "Add new word";
            this.addNewWord_BTN.UseVisualStyleBackColor = true;
            this.addNewWord_BTN.Click += new System.EventHandler(this.AddNewWord_BTN_Click);
            // 
            // submit_BTN
            // 
            this.submit_BTN.Location = new System.Drawing.Point(309, 174);
            this.submit_BTN.Name = "submit_BTN";
            this.submit_BTN.Size = new System.Drawing.Size(75, 23);
            this.submit_BTN.TabIndex = 6;
            this.submit_BTN.Text = "Submit";
            this.submit_BTN.UseVisualStyleBackColor = true;
            this.submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // swap_BTN
            // 
            this.swap_BTN.Font = new System.Drawing.Font("MS Mincho", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swap_BTN.Location = new System.Drawing.Point(200, 44);
            this.swap_BTN.Name = "swap_BTN";
            this.swap_BTN.Size = new System.Drawing.Size(28, 29);
            this.swap_BTN.TabIndex = 7;
            this.swap_BTN.Text = "⇆";
            this.swap_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.swap_BTN.UseVisualStyleBackColor = true;
            this.swap_BTN.Click += new System.EventHandler(this.Swap_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 224);
            this.Controls.Add(this.swap_BTN);
            this.Controls.Add(this.submit_BTN);
            this.Controls.Add(this.addNewWord_BTN);
            this.Controls.Add(this.langTwo_TB);
            this.Controls.Add(this.langOne_TB);
            this.Controls.Add(this.langTwo_CB);
            this.Controls.Add(this.langOne_CB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nevaeh\'s Translator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox langOne_TB;
        private System.Windows.Forms.RichTextBox langTwo_TB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button addNewWord_BTN;
        private System.Windows.Forms.Button submit_BTN;
        private System.Windows.Forms.Button swap_BTN;
        public System.Windows.Forms.ComboBox langOne_CB;
        public System.Windows.Forms.ComboBox langTwo_CB;
    }
}

