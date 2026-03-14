namespace AddItemToListBox
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxAdd = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 20;
            this.ListBox.Items.AddRange(new object[] {
            "IPHONE HIM",
            "SAMSUNG",
            "IPAD",
            "AIRPORD"});
            this.ListBox.Location = new System.Drawing.Point(13, 13);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(199, 224);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCT NAME";
            // 
            // TextBoxAdd
            // 
            this.TextBoxAdd.Location = new System.Drawing.Point(402, 66);
            this.TextBoxAdd.Multiline = true;
            this.TextBoxAdd.Name = "TextBoxAdd";
            this.TextBoxAdd.Size = new System.Drawing.Size(244, 70);
            this.TextBoxAdd.TabIndex = 2;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(402, 176);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(244, 61);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox);
            this.Name = "Form1";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxAdd;
        private System.Windows.Forms.Button ButtonAdd;
    }
}

