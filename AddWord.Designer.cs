namespace Translator
{
    partial class AddWord
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
        public void InitializeComponent()
        {
            this.cancel_BTN = new System.Windows.Forms.Button();
            this.addWord_BTN = new System.Windows.Forms.Button();
            this.langOneAdd_CB = new System.Windows.Forms.ComboBox();
            this.langTwoAdd_CB = new System.Windows.Forms.ComboBox();
            this.langOneAdd_TB = new System.Windows.Forms.TextBox();
            this.langTwoAdd_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel_BTN
            // 
            this.cancel_BTN.Location = new System.Drawing.Point(295, 125);
            this.cancel_BTN.Name = "cancel_BTN";
            this.cancel_BTN.Size = new System.Drawing.Size(75, 23);
            this.cancel_BTN.TabIndex = 0;
            this.cancel_BTN.Text = "Cancel";
            this.cancel_BTN.UseVisualStyleBackColor = true;
            this.cancel_BTN.Click += new System.EventHandler(this.Cancel_BTN_Click);
            // 
            // addWord_BTN
            // 
            this.addWord_BTN.Location = new System.Drawing.Point(65, 125);
            this.addWord_BTN.Name = "addWord_BTN";
            this.addWord_BTN.Size = new System.Drawing.Size(75, 23);
            this.addWord_BTN.TabIndex = 1;
            this.addWord_BTN.Text = "Add";
            this.addWord_BTN.UseVisualStyleBackColor = true;
            this.addWord_BTN.Click += new System.EventHandler(this.AddWord_BTN_Click);
            // 
            // langOneAdd_CB
            // 
            this.langOneAdd_CB.FormattingEnabled = true;
            this.langOneAdd_CB.Location = new System.Drawing.Point(19, 22);
            this.langOneAdd_CB.Name = "langOneAdd_CB";
            this.langOneAdd_CB.Size = new System.Drawing.Size(121, 21);
            this.langOneAdd_CB.TabIndex = 2;
            // 
            // langTwoAdd_CB
            // 
            this.langTwoAdd_CB.FormattingEnabled = true;
            this.langTwoAdd_CB.Location = new System.Drawing.Point(249, 22);
            this.langTwoAdd_CB.Name = "langTwoAdd_CB";
            this.langTwoAdd_CB.Size = new System.Drawing.Size(121, 21);
            this.langTwoAdd_CB.TabIndex = 3;
            // 
            // langOneAdd_TB
            // 
            this.langOneAdd_TB.Location = new System.Drawing.Point(19, 68);
            this.langOneAdd_TB.Name = "langOneAdd_TB";
            this.langOneAdd_TB.Size = new System.Drawing.Size(121, 20);
            this.langOneAdd_TB.TabIndex = 4;
            // 
            // langTwoAdd_TB
            // 
            this.langTwoAdd_TB.Location = new System.Drawing.Point(249, 68);
            this.langTwoAdd_TB.Name = "langTwoAdd_TB";
            this.langTwoAdd_TB.Size = new System.Drawing.Size(121, 20);
            this.langTwoAdd_TB.TabIndex = 5;
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 166);
            this.ControlBox = false;
            this.Controls.Add(this.langTwoAdd_TB);
            this.Controls.Add(this.langOneAdd_TB);
            this.Controls.Add(this.langTwoAdd_CB);
            this.Controls.Add(this.langOneAdd_CB);
            this.Controls.Add(this.addWord_BTN);
            this.Controls.Add(this.cancel_BTN);
            this.Name = "AddWord";
            this.Text = "AddWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_BTN;
        private System.Windows.Forms.Button addWord_BTN;
        private System.Windows.Forms.TextBox langOneAdd_TB;
        private System.Windows.Forms.TextBox langTwoAdd_TB;
        public System.Windows.Forms.ComboBox langOneAdd_CB;
        public System.Windows.Forms.ComboBox langTwoAdd_CB;
    }
}