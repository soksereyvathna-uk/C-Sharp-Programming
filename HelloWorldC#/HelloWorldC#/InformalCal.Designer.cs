namespace HelloWorldC_
{
    partial class InformalCal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonMulty = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.TextBoxFirst = new System.Windows.Forms.TextBox();
            this.TextBoxSecond = new System.Windows.Forms.TextBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SECOND";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(169, 225);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(96, 45);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(310, 225);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(75, 45);
            this.ButtonMinus.TabIndex = 3;
            this.ButtonMinus.Text = "MINUS";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Location = new System.Drawing.Point(445, 225);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(75, 45);
            this.ButtonDivide.TabIndex = 4;
            this.ButtonDivide.Text = "DIVIDE";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonMulty
            // 
            this.ButtonMulty.Location = new System.Drawing.Point(578, 225);
            this.ButtonMulty.Name = "ButtonMulty";
            this.ButtonMulty.Size = new System.Drawing.Size(95, 45);
            this.ButtonMulty.TabIndex = 5;
            this.ButtonMulty.Text = "MULTY";
            this.ButtonMulty.UseVisualStyleBackColor = true;
            this.ButtonMulty.Click += new System.EventHandler(this.ButtonMulty_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(391, 283);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 71);
            this.ButtonClear.TabIndex = 6;
            this.ButtonClear.Text = "CLEAR";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // TextBoxFirst
            // 
            this.TextBoxFirst.Location = new System.Drawing.Point(214, 71);
            this.TextBoxFirst.Multiline = true;
            this.TextBoxFirst.Name = "TextBoxFirst";
            this.TextBoxFirst.Size = new System.Drawing.Size(421, 79);
            this.TextBoxFirst.TabIndex = 7;
            // 
            // TextBoxSecond
            // 
            this.TextBoxSecond.Location = new System.Drawing.Point(214, 156);
            this.TextBoxSecond.Multiline = true;
            this.TextBoxSecond.Name = "TextBoxSecond";
            this.TextBoxSecond.Size = new System.Drawing.Size(421, 63);
            this.TextBoxSecond.TabIndex = 8;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(391, 361);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 43);
            this.ButtonClose.TabIndex = 9;
            this.ButtonClose.Text = "CLOSE";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(214, 22);
            this.TextBoxResult.Multiline = true;
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.Size = new System.Drawing.Size(421, 43);
            this.TextBoxResult.TabIndex = 10;
            // 
            // InformalCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.TextBoxSecond);
            this.Controls.Add(this.TextBoxFirst);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonMulty);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InformalCal";
            this.Text = "FormInformalCal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonMulty;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.TextBox TextBoxFirst;
        private System.Windows.Forms.TextBox TextBoxSecond;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TextBox TextBoxResult;
    }
}