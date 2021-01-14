namespace Csharp_encryption_grid_WindowsFormsApp
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
            this.buttonAlphaBB = new System.Windows.Forms.Button();
            this.buttonAlphaE10x10 = new System.Windows.Forms.Button();
            this.buttonAlphaD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAlphaB = new System.Windows.Forms.Button();
            this.textBoxAlphabet = new System.Windows.Forms.TextBox();
            this.lblShowResult = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAlphaBB
            // 
            this.buttonAlphaBB.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAlphaBB.Location = new System.Drawing.Point(12, 142);
            this.buttonAlphaBB.Name = "buttonAlphaBB";
            this.buttonAlphaBB.Size = new System.Drawing.Size(105, 52);
            this.buttonAlphaBB.TabIndex = 153;
            this.buttonAlphaBB.Text = "AlphaBB";
            this.buttonAlphaBB.UseVisualStyleBackColor = true;
            this.buttonAlphaBB.Click += new System.EventHandler(this.buttonAlphaBB_Click);
            // 
            // buttonAlphaE10x10
            // 
            this.buttonAlphaE10x10.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAlphaE10x10.Location = new System.Drawing.Point(12, 499);
            this.buttonAlphaE10x10.Name = "buttonAlphaE10x10";
            this.buttonAlphaE10x10.Size = new System.Drawing.Size(121, 52);
            this.buttonAlphaE10x10.TabIndex = 152;
            this.buttonAlphaE10x10.Text = "AlphaE10x10";
            this.buttonAlphaE10x10.UseVisualStyleBackColor = true;
            this.buttonAlphaE10x10.Click += new System.EventHandler(this.buttonAlphaE10x10_Click);
            // 
            // buttonAlphaD
            // 
            this.buttonAlphaD.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAlphaD.Location = new System.Drawing.Point(12, 397);
            this.buttonAlphaD.Name = "buttonAlphaD";
            this.buttonAlphaD.Size = new System.Drawing.Size(105, 52);
            this.buttonAlphaD.TabIndex = 151;
            this.buttonAlphaD.Text = "AlphaD";
            this.buttonAlphaD.UseVisualStyleBackColor = true;
            this.buttonAlphaD.Click += new System.EventHandler(this.buttonAlphaD_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(12, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 52);
            this.button1.TabIndex = 150;
            this.button1.Text = "AlphaC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAlphaB
            // 
            this.buttonAlphaB.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAlphaB.Location = new System.Drawing.Point(12, 48);
            this.buttonAlphaB.Name = "buttonAlphaB";
            this.buttonAlphaB.Size = new System.Drawing.Size(105, 52);
            this.buttonAlphaB.TabIndex = 149;
            this.buttonAlphaB.Text = "AlphaB";
            this.buttonAlphaB.UseVisualStyleBackColor = true;
            this.buttonAlphaB.Click += new System.EventHandler(this.buttonAlphaB_Click);
            // 
            // textBoxAlphabet
            // 
            this.textBoxAlphabet.Location = new System.Drawing.Point(12, 12);
            this.textBoxAlphabet.Name = "textBoxAlphabet";
            this.textBoxAlphabet.Size = new System.Drawing.Size(254, 20);
            this.textBoxAlphabet.TabIndex = 148;
            // 
            // lblShowResult
            // 
            this.lblShowResult.AutoSize = true;
            this.lblShowResult.Font = new System.Drawing.Font("DFKai-SB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShowResult.Location = new System.Drawing.Point(266, 63);
            this.lblShowResult.Name = "lblShowResult";
            this.lblShowResult.Size = new System.Drawing.Size(0, 21);
            this.lblShowResult.TabIndex = 147;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(171, 56);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(89, 30);
            this.lblResult.TabIndex = 146;
            this.lblResult.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 765);
            this.Controls.Add(this.buttonAlphaBB);
            this.Controls.Add(this.buttonAlphaE10x10);
            this.Controls.Add(this.buttonAlphaD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAlphaB);
            this.Controls.Add(this.textBoxAlphabet);
            this.Controls.Add(this.lblShowResult);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlphaBB;
        private System.Windows.Forms.Button buttonAlphaE10x10;
        private System.Windows.Forms.Button buttonAlphaD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAlphaB;
        private System.Windows.Forms.TextBox textBoxAlphabet;
        private System.Windows.Forms.Label lblShowResult;
        private System.Windows.Forms.Label lblResult;
    }
}

