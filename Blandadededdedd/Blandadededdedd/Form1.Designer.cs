
namespace Blandadededdedd
{
    partial class frmMain
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
            this.tbxTalA = new System.Windows.Forms.TextBox();
            this.tbxTalB = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxTalA
            // 
            this.tbxTalA.Location = new System.Drawing.Point(169, 58);
            this.tbxTalA.Name = "tbxTalA";
            this.tbxTalA.Size = new System.Drawing.Size(71, 20);
            this.tbxTalA.TabIndex = 0;
            // 
            // tbxTalB
            // 
            this.tbxTalB.Location = new System.Drawing.Point(169, 101);
            this.tbxTalB.Name = "tbxTalB";
            this.tbxTalB.Size = new System.Drawing.Size(71, 20);
            this.tbxTalB.TabIndex = 1;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(169, 147);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(71, 23);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(98, 193);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(222, 13);
            this.lblSvar.TabIndex = 3;
            this.lblSvar.Text = "Här kan du räkna ut blandad bråk av hela tal.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 266);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxTalB);
            this.Controls.Add(this.tbxTalA);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blandad form bråk kalkylator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTalA;
        private System.Windows.Forms.TextBox tbxTalB;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblSvar;
    }
}

