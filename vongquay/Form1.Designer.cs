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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelCombine = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.inputcb1 = new System.Windows.Forms.Button();
            this.outputcb1 = new System.Windows.Forms.TextBox();
            this.optionP = new System.Windows.Forms.RadioButton();
            this.optionW = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panelConvert.SuspendLayout();
            this.panelCombine.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConvert
            // 
            this.panelConvert.Controls.Add(this.panelCombine);
            this.panelConvert.Controls.Add(this.convert1);
            this.panelConvert.Controls.Add(this.save1);
            this.panelConvert.Controls.Add(this.browser1);
            this.panelConvert.Controls.Add(this.Savet2);
            this.panelConvert.Controls.Add(this.Savet1);
            this.panelConvert.Controls.Add(this.optionPtW);
            this.panelConvert.Controls.Add(this.optionWtP);
            this.panelConvert.Controls.Add(this.label1);
            this.panelConvert.Location = new System.Drawing.Point(257, 8);
            this.panelConvert.Name = "panelConvert";
            this.panelConvert.Size = new System.Drawing.Size(815, 678);
            this.panelConvert.TabIndex = 0;
            // 
            // convert1
            // 
            this.convert1.Location = new System.Drawing.Point(332, 546);
            this.convert1.Name = "convert1";
            this.convert1.Size = new System.Drawing.Size(138, 76);
            this.convert1.TabIndex = 9;
            this.convert1.Text = "Convert";
            this.convert1.UseVisualStyleBackColor = true;
            this.convert1.Click += new System.EventHandler(this.convert1_Click);
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(156, 379);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(75, 23);
            this.save1.TabIndex = 8;
            this.save1.Text = "Browser";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // browser1
            // 
            this.browser1.Location = new System.Drawing.Point(156, 325);
            this.browser1.Name = "browser1";
            this.browser1.Size = new System.Drawing.Size(75, 23);
            this.browser1.TabIndex = 7;
            this.browser1.Text = "Browser";
            this.browser1.UseVisualStyleBackColor = true;
            this.browser1.Click += new System.EventHandler(this.browser1_Click);
            // 
            // Savet2
            // 
            this.Savet2.Location = new System.Drawing.Point(250, 380);
            this.Savet2.Name = "Savet2";
            this.Savet2.Size = new System.Drawing.Size(362, 22);
            this.Savet2.TabIndex = 6;
            // 
            // Savet1
            // 
            this.Savet1.Location = new System.Drawing.Point(250, 325);
            this.Savet1.Name = "Savet1";
            this.Savet1.Size = new System.Drawing.Size(362, 22);
            this.Savet1.TabIndex = 5;
            // 
            // optionPtW
            // 
            this.optionPtW.AutoSize = true;
            this.optionPtW.Location = new System.Drawing.Point(427, 256);
            this.optionPtW.Name = "optionPtW";
            this.optionPtW.Size = new System.Drawing.Size(105, 20);
            this.optionPtW.TabIndex = 2;
            this.optionPtW.TabStop = true;
            this.optionPtW.Text = "PDF to Word";
            this.optionPtW.UseVisualStyleBackColor = true;
            this.optionPtW.CheckedChanged += new System.EventHandler(this.optionPtW_CheckedChanged);
            // 
            // optionWtP
            // 
            this.optionWtP.AutoSize = true;
            this.optionWtP.Location = new System.Drawing.Point(159, 256);
            this.optionWtP.Name = "optionWtP";
            this.optionWtP.Size = new System.Drawing.Size(105, 20);
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
            this.label1.Location = new System.Drawing.Point(332, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(6, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Convert_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chartreuse;
            this.button2.Location = new System.Drawing.Point(6, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Combine";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Combine_Click);
            // 
            // panelCombine
            // 
            this.panelCombine.Controls.Add(this.button3);
            this.panelCombine.Controls.Add(this.inputcb1);
            this.panelCombine.Controls.Add(this.outputcb1);
            this.panelCombine.Controls.Add(this.optionP);
            this.panelCombine.Controls.Add(this.optionW);
            this.panelCombine.Controls.Add(this.label2);
            this.panelCombine.Location = new System.Drawing.Point(0, 0);
            this.panelCombine.Name = "panelCombine";
            this.panelCombine.Size = new System.Drawing.Size(815, 678);
            this.panelCombine.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 72);
            this.button3.TabIndex = 9;
            this.button3.Text = "Combine";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // inputcb1
            // 
            this.inputcb1.Location = new System.Drawing.Point(379, 449);
            this.inputcb1.Name = "inputcb1";
            this.inputcb1.Size = new System.Drawing.Size(75, 23);
            this.inputcb1.TabIndex = 7;
            this.inputcb1.Text = "Browser";
            this.inputcb1.UseVisualStyleBackColor = true;
            this.inputcb1.Click += new System.EventHandler(this.inputCBPaths_Click);
            // 
            // outputcb1
            // 
            this.outputcb1.Location = new System.Drawing.Point(252, 228);
            this.outputcb1.Name = "outputcb1";
            this.outputcb1.Size = new System.Drawing.Size(360, 22);
            this.outputcb1.TabIndex = 5;
            // 
            // optionP
            // 
            this.optionP.AutoSize = true;
            this.optionP.Location = new System.Drawing.Point(590, 163);
            this.optionP.Name = "optionP";
            this.optionP.Size = new System.Drawing.Size(55, 20);
            this.optionP.TabIndex = 2;
            this.optionP.TabStop = true;
            this.optionP.Text = "PDF";
            this.optionP.UseVisualStyleBackColor = true;
            this.optionP.CheckedChanged += new System.EventHandler(this.optionP_CheckedChanged);
            // 
            // optionW
            // 
            this.optionW.AutoSize = true;
            this.optionW.Location = new System.Drawing.Point(239, 163);
            this.optionW.Name = "optionW";
            this.optionW.Size = new System.Drawing.Size(61, 20);
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
            this.label2.Location = new System.Drawing.Point(298, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Combine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 700);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelConvert);
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
        private System.Windows.Forms.TextBox outputcb1;
        private System.Windows.Forms.RadioButton optionP;
        private System.Windows.Forms.RadioButton optionW;
        private System.Windows.Forms.Label label2;
    }
}

