namespace PolymorfismAsForm
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
            this.rbOptionA = new System.Windows.Forms.RadioButton();
            this.rbOptionB = new System.Windows.Forms.RadioButton();
            this.bSubmit = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbOptionA
            // 
            this.rbOptionA.AutoSize = true;
            this.rbOptionA.Location = new System.Drawing.Point(12, 12);
            this.rbOptionA.Name = "rbOptionA";
            this.rbOptionA.Size = new System.Drawing.Size(100, 24);
            this.rbOptionA.TabIndex = 0;
            this.rbOptionA.TabStop = true;
            this.rbOptionA.Text = "Välj typ A";
            this.rbOptionA.UseVisualStyleBackColor = true;
            // 
            // rbOptionB
            // 
            this.rbOptionB.AutoSize = true;
            this.rbOptionB.Location = new System.Drawing.Point(12, 41);
            this.rbOptionB.Name = "rbOptionB";
            this.rbOptionB.Size = new System.Drawing.Size(100, 24);
            this.rbOptionB.TabIndex = 1;
            this.rbOptionB.TabStop = true;
            this.rbOptionB.Text = "Välj typ B";
            this.rbOptionB.UseVisualStyleBackColor = true;
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(146, 12);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 53);
            this.bSubmit.TabIndex = 2;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 71);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(209, 26);
            this.tbDescription.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 110);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.rbOptionB);
            this.Controls.Add(this.rbOptionA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.TextBox tbDescription;
    }
}

