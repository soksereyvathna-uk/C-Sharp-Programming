namespace ListBox
{
    partial class FormCheckBox
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
            this.CBSamSung = new System.Windows.Forms.CheckBox();
            this.CBIphone = new System.Windows.Forms.CheckBox();
            this.CBNokia = new System.Windows.Forms.CheckBox();
            this.CBOppo = new System.Windows.Forms.CheckBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.CBEnable = new System.Windows.Forms.CheckBox();
            this.BtnMybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBSamSung
            // 
            this.CBSamSung.AutoSize = true;
            this.CBSamSung.Location = new System.Drawing.Point(67, 65);
            this.CBSamSung.Name = "CBSamSung";
            this.CBSamSung.Size = new System.Drawing.Size(103, 24);
            this.CBSamSung.TabIndex = 0;
            this.CBSamSung.Text = "Samsung";
            this.CBSamSung.UseVisualStyleBackColor = true;
            this.CBSamSung.CheckedChanged += new System.EventHandler(this.CBSamSung_CheckedChanged);
            // 
            // CBIphone
            // 
            this.CBIphone.AutoSize = true;
            this.CBIphone.Location = new System.Drawing.Point(67, 112);
            this.CBIphone.Name = "CBIphone";
            this.CBIphone.Size = new System.Drawing.Size(86, 24);
            this.CBIphone.TabIndex = 1;
            this.CBIphone.Text = "IPhone";
            this.CBIphone.UseVisualStyleBackColor = true;
            this.CBIphone.CheckedChanged += new System.EventHandler(this.CBIphone_CheckedChanged);
            // 
            // CBNokia
            // 
            this.CBNokia.AutoSize = true;
            this.CBNokia.Location = new System.Drawing.Point(67, 157);
            this.CBNokia.Name = "CBNokia";
            this.CBNokia.Size = new System.Drawing.Size(75, 24);
            this.CBNokia.TabIndex = 2;
            this.CBNokia.Text = "Nokia";
            this.CBNokia.UseVisualStyleBackColor = true;
            this.CBNokia.CheckedChanged += new System.EventHandler(this.CBNokia_CheckedChanged);
            // 
            // CBOppo
            // 
            this.CBOppo.AutoSize = true;
            this.CBOppo.Location = new System.Drawing.Point(67, 200);
            this.CBOppo.Name = "CBOppo";
            this.CBOppo.Size = new System.Drawing.Size(79, 24);
            this.CBOppo.TabIndex = 3;
            this.CBOppo.Text = "OPPO";
            this.CBOppo.UseVisualStyleBackColor = true;
            this.CBOppo.CheckedChanged += new System.EventHandler(this.CBOppo_CheckedChanged);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(67, 248);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(153, 38);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // CBEnable
            // 
            this.CBEnable.AutoSize = true;
            this.CBEnable.Location = new System.Drawing.Point(67, 292);
            this.CBEnable.Name = "CBEnable";
            this.CBEnable.Size = new System.Drawing.Size(85, 24);
            this.CBEnable.TabIndex = 5;
            this.CBEnable.Text = "Enable";
            this.CBEnable.UseVisualStyleBackColor = true;
            this.CBEnable.CheckedChanged += new System.EventHandler(this.CBEnable_CheckedChanged);
            // 
            // BtnMybutton
            // 
            this.BtnMybutton.Enabled = false;
            this.BtnMybutton.Location = new System.Drawing.Point(230, 292);
            this.BtnMybutton.Name = "BtnMybutton";
            this.BtnMybutton.Size = new System.Drawing.Size(152, 39);
            this.BtnMybutton.TabIndex = 6;
            this.BtnMybutton.Text = "MyButton";
            this.BtnMybutton.UseVisualStyleBackColor = true;
            this.BtnMybutton.Click += new System.EventHandler(this.BtnMybutton_Click);
            // 
            // FormCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMybutton);
            this.Controls.Add(this.CBEnable);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.CBOppo);
            this.Controls.Add(this.CBNokia);
            this.Controls.Add(this.CBIphone);
            this.Controls.Add(this.CBSamSung);
            this.Name = "FormCheckBox";
            this.Text = "FormCheckBox";
            this.Load += new System.EventHandler(this.FormCheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBSamSung;
        private System.Windows.Forms.CheckBox CBIphone;
        private System.Windows.Forms.CheckBox CBNokia;
        private System.Windows.Forms.CheckBox CBOppo;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.CheckBox CBEnable;
        private System.Windows.Forms.Button BtnMybutton;
    }
}