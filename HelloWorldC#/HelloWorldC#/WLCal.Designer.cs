namespace HelloWorldC_
{
    partial class WLCal
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
            this.labelLength = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.TextBoxLength = new System.Windows.Forms.TextBox();
            this.TextBoxWidth = new System.Windows.Forms.TextBox();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(151, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM AREA CALCULATION";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(81, 156);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(74, 20);
            this.labelLength.TabIndex = 1;
            this.labelLength.Text = "LENGTH";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(81, 217);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(62, 20);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "WIDTH";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(81, 277);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(73, 20);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "RESULT";
            // 
            // TextBoxLength
            // 
            this.TextBoxLength.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxLength.Location = new System.Drawing.Point(188, 150);
            this.TextBoxLength.Multiline = true;
            this.TextBoxLength.Name = "TextBoxLength";
            this.TextBoxLength.Size = new System.Drawing.Size(378, 26);
            this.TextBoxLength.TabIndex = 4;
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxWidth.Location = new System.Drawing.Point(188, 214);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(378, 26);
            this.TextBoxWidth.TabIndex = 5;
            this.TextBoxWidth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxResult.Location = new System.Drawing.Point(188, 271);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.Size = new System.Drawing.Size(378, 26);
            this.TextBoxResult.TabIndex = 6;
            this.TextBoxResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.BackColor = System.Drawing.Color.Lime;
            this.ButtonCalculate.Location = new System.Drawing.Point(188, 351);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(126, 58);
            this.ButtonCalculate.TabIndex = 7;
            this.ButtonCalculate.Text = "CALCULATE";
            this.ButtonCalculate.UseVisualStyleBackColor = false;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(320, 351);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(103, 58);
            this.ButtonClear.TabIndex = 8;
            this.ButtonClear.Text = "CLEAR";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Red;
            this.ButtonClose.Location = new System.Drawing.Point(429, 351);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(131, 58);
            this.ButtonClose.TabIndex = 9;
            this.ButtonClose.Text = "CLOSE";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // WLCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 581);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.TextBoxWidth);
            this.Controls.Add(this.TextBoxLength);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.label1);
            this.Name = "WLCal";
            this.Text = "FormArea";
            this.Load += new System.EventHandler(this.textBox3_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox TextBoxLength;
        private System.Windows.Forms.TextBox TextBoxWidth;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonClose;
    }
}

