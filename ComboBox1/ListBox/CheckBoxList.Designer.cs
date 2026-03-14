namespace ListBox
{
    partial class CheckBoxList
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
            this.CheckBoxList1 = new System.Windows.Forms.CheckedListBox();
            this.BtnGetItems = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CheckBoxList1
            // 
            this.CheckBoxList1.FormattingEnabled = true;
            this.CheckBoxList1.Items.AddRange(new object[] {
            "Messi",
            "CR7",
            "Neymar",
            "Vini Jr",
            "Mbappe"});
            this.CheckBoxList1.Location = new System.Drawing.Point(12, 12);
            this.CheckBoxList1.Name = "CheckBoxList1";
            this.CheckBoxList1.Size = new System.Drawing.Size(273, 142);
            this.CheckBoxList1.TabIndex = 0;
            // 
            // BtnGetItems
            // 
            this.BtnGetItems.Location = new System.Drawing.Point(12, 161);
            this.BtnGetItems.Name = "BtnGetItems";
            this.BtnGetItems.Size = new System.Drawing.Size(273, 44);
            this.BtnGetItems.TabIndex = 1;
            this.BtnGetItems.Text = "Get Items";
            this.BtnGetItems.UseVisualStyleBackColor = true;
            this.BtnGetItems.Click += new System.EventHandler(this.BtnGetItems_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 20;
            this.ListBox1.Items.AddRange(new object[] {
            "ListBox ColdDrink"});
            this.ListBox1.Location = new System.Drawing.Point(13, 212);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(272, 204);
            this.ListBox1.TabIndex = 2;
            // 
            // CheckBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.BtnGetItems);
            this.Controls.Add(this.CheckBoxList1);
            this.Name = "CheckBoxList";
            this.Text = "CheckBoxList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckBoxList1;
        private System.Windows.Forms.Button BtnGetItems;
        private System.Windows.Forms.ListBox ListBox1;
    }
}