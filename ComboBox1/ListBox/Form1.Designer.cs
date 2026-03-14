namespace ListBox
{
    partial class FormListBox
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
            this.ListBox = new System.Windows.Forms.ComboBox();
            this.TextBoxAdd = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCount = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Items.AddRange(new object[] {
            "Asus Tell",
            "Hi",
            "Ku ja"});
            this.ListBox.Location = new System.Drawing.Point(40, 40);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(229, 28);
            this.ListBox.TabIndex = 1;
            // 
            // TextBoxAdd
            // 
            this.TextBoxAdd.Location = new System.Drawing.Point(454, 41);
            this.TextBoxAdd.Name = "TextBoxAdd";
            this.TextBoxAdd.Size = new System.Drawing.Size(261, 26);
            this.TextBoxAdd.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(472, 88);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(224, 38);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonCount
            // 
            this.ButtonCount.Location = new System.Drawing.Point(472, 132);
            this.ButtonCount.Name = "ButtonCount";
            this.ButtonCount.Size = new System.Drawing.Size(224, 45);
            this.ButtonCount.TabIndex = 4;
            this.ButtonCount.Text = "COUNT";
            this.ButtonCount.UseVisualStyleBackColor = true;
            this.ButtonCount.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(472, 176);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(224, 45);
            this.ButtonSort.TabIndex = 5;
            this.ButtonSort.Text = "SORT";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(472, 224);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(224, 45);
            this.ButtonRemove.TabIndex = 6;
            this.ButtonRemove.Text = "REMOVE";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(472, 268);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(224, 45);
            this.ButtonClear.TabIndex = 7;
            this.ButtonClear.Text = "CLEAR";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // FormListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxAdd);
            this.Controls.Add(this.ListBox);
            this.Name = "FormListBox";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.FormListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListBox;
        private System.Windows.Forms.TextBox TextBoxAdd;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCount;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonClear;
    }
}

