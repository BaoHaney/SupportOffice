namespace vongquay
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
            this.panelConvert = new System.Windows.Forms.Panel();
            this.convert1 = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.browser1 = new System.Windows.Forms.Button();
            this.Savet2 = new System.Windows.Forms.TextBox();
            this.Savet1 = new System.Windows.Forms.TextBox();
            this.optionPtW = new System.Windows.Forms.RadioButton();
            this.optionWtP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCombine = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.inputcb1 = new System.Windows.Forms.Button();
            this.listFilesText = new System.Windows.Forms.TextBox();
            this.optionP = new System.Windows.Forms.RadioButton();
            this.optionW = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Savet3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panelConvert.SuspendLayout();
            this.panelCombine.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConvert
            // 
            this.panelConvert.Controls.Add(this.convert1);
            this.panelConvert.Controls.Add(this.save1);
            this.panelConvert.Controls.Add(this.browser1);
            this.panelConvert.Controls.Add(this.Savet2);
            this.panelConvert.Controls.Add(this.Savet1);
            this.panelConvert.Controls.Add(this.optionPtW);
            this.panelConvert.Controls.Add(this.optionWtP);
            this.panelConvert.Controls.Add(this.label1);
            this.panelConvert.Location = new System.Drawing.Point(193, 6);
            this.panelConvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelConvert.Name = "panelConvert";
            this.panelConvert.Size = new System.Drawing.Size(611, 551);
            this.panelConvert.TabIndex = 0;
            // 
            // convert1
            // 
            this.convert1.Location = new System.Drawing.Point(249, 444);
            this.convert1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.convert1.Name = "convert1";
            this.convert1.Size = new System.Drawing.Size(104, 62);
            this.convert1.TabIndex = 9;
            this.convert1.Text = "Convert";
            this.convert1.UseVisualStyleBackColor = true;
            this.convert1.Click += new System.EventHandler(this.convert1_Click);
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(117, 308);
            this.save1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(56, 19);
            this.save1.TabIndex = 8;
            this.save1.Text = "Browser";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // browser1
            // 
            this.browser1.Location = new System.Drawing.Point(117, 264);
            this.browser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.browser1.Name = "browser1";
            this.browser1.Size = new System.Drawing.Size(56, 19);
            this.browser1.TabIndex = 7;
            this.browser1.Text = "Browser";
            this.browser1.UseVisualStyleBackColor = true;
            this.browser1.Click += new System.EventHandler(this.browser1_Click);
            // 
            // Savet2
            // 
            this.Savet2.Location = new System.Drawing.Point(188, 309);
            this.Savet2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Savet2.Name = "Savet2";
            this.Savet2.Size = new System.Drawing.Size(272, 20);
            this.Savet2.TabIndex = 6;
            // 
            // Savet1
            // 
            this.Savet1.Location = new System.Drawing.Point(188, 264);
            this.Savet1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Savet1.Name = "Savet1";
            this.Savet1.Size = new System.Drawing.Size(272, 20);
            this.Savet1.TabIndex = 5;
            // 
            // optionPtW
            // 
            this.optionPtW.AutoSize = true;
            this.optionPtW.Location = new System.Drawing.Point(320, 208);
            this.optionPtW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionPtW.Name = "optionPtW";
            this.optionPtW.Size = new System.Drawing.Size(87, 17);
            this.optionPtW.TabIndex = 2;
            this.optionPtW.TabStop = true;
            this.optionPtW.Text = "PDF to Word";
            this.optionPtW.UseVisualStyleBackColor = true;
            this.optionPtW.CheckedChanged += new System.EventHandler(this.optionPtW_CheckedChanged);
            // 
            // optionWtP
            // 
            this.optionWtP.AutoSize = true;
            this.optionWtP.Location = new System.Drawing.Point(119, 208);
            this.optionWtP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionWtP.Name = "optionWtP";
            this.optionWtP.Size = new System.Drawing.Size(87, 17);
            this.optionWtP.TabIndex = 1;
            this.optionWtP.TabStop = true;
            this.optionWtP.Text = "Word to PDF";
            this.optionWtP.UseVisualStyleBackColor = true;
            this.optionWtP.CheckedChanged += new System.EventHandler(this.optionWtP_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelCombine
            // 
            this.panelCombine.Controls.Add(this.button5);
            this.panelCombine.Controls.Add(this.Savet3);
            this.panelCombine.Controls.Add(this.button3);
            this.panelCombine.Controls.Add(this.inputcb1);
            this.panelCombine.Controls.Add(this.listFilesText);
            this.panelCombine.Controls.Add(this.optionP);
            this.panelCombine.Controls.Add(this.optionW);
            this.panelCombine.Controls.Add(this.label2);
            this.panelCombine.Location = new System.Drawing.Point(193, 6);
            this.panelCombine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCombine.Name = "panelCombine";
            this.panelCombine.Size = new System.Drawing.Size(611, 551);
            this.panelCombine.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 444);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Combine";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonCombine_Click);
            // 
            // inputcb1
            // 
            this.inputcb1.Location = new System.Drawing.Point(278, 241);
            this.inputcb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputcb1.Name = "inputcb1";
            this.inputcb1.Size = new System.Drawing.Size(56, 19);
            this.inputcb1.TabIndex = 7;
            this.inputcb1.Text = "Browser";
            this.inputcb1.UseVisualStyleBackColor = true;
            this.inputcb1.Click += new System.EventHandler(this.inputCBPaths_Click);
            // 
            // listFilesText
            // 
            this.listFilesText.Location = new System.Drawing.Point(189, 185);
            this.listFilesText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listFilesText.Name = "listFilesText";
            this.listFilesText.Size = new System.Drawing.Size(271, 20);
            this.listFilesText.TabIndex = 5;
            // 
            // optionP
            // 
            this.optionP.AutoSize = true;
            this.optionP.Location = new System.Drawing.Point(442, 132);
            this.optionP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionP.Name = "optionP";
            this.optionP.Size = new System.Drawing.Size(46, 17);
            this.optionP.TabIndex = 2;
            this.optionP.TabStop = true;
            this.optionP.Text = "PDF";
            this.optionP.UseVisualStyleBackColor = true;
            this.optionP.CheckedChanged += new System.EventHandler(this.optionP_CheckedChanged);
            // 
            // optionW
            // 
            this.optionW.AutoSize = true;
            this.optionW.Location = new System.Drawing.Point(179, 132);
            this.optionW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionW.Name = "optionW";
            this.optionW.Size = new System.Drawing.Size(51, 17);
            this.optionW.TabIndex = 1;
            this.optionW.TabStop = true;
            this.optionW.Text = "Word";
            this.optionW.UseVisualStyleBackColor = true;
            this.optionW.CheckedChanged += new System.EventHandler(this.optionW_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Combine";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(4, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Convert_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chartreuse;
            this.button2.Location = new System.Drawing.Point(4, 80);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Combine";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Combine_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chartreuse;
            this.button4.Location = new System.Drawing.Point(4, 152);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 47);
            this.button4.TabIndex = 11;
            this.button4.Text = "Combine";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Savet3
            // 
            this.Savet3.Location = new System.Drawing.Point(179, 348);
            this.Savet3.Margin = new System.Windows.Forms.Padding(2);
            this.Savet3.Name = "Savet3";
            this.Savet3.Size = new System.Drawing.Size(271, 20);
            this.Savet3.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(278, 385);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 11;
            this.button5.Text = "Browser";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.save1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 569);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panelCombine);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelConvert);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelConvert.ResumeLayout(false);
            this.panelConvert.PerformLayout();
            this.panelCombine.ResumeLayout(false);
            this.panelCombine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button browser1;
        private System.Windows.Forms.TextBox Savet2;
        private System.Windows.Forms.TextBox Savet1;
        private System.Windows.Forms.RadioButton optionPtW;
        private System.Windows.Forms.RadioButton optionWtP;
        private System.Windows.Forms.Button convert1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelCombine;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button inputcb1;
        private System.Windows.Forms.TextBox listFilesText;
        private System.Windows.Forms.RadioButton optionP;
        private System.Windows.Forms.RadioButton optionW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Savet3;
    }
}

