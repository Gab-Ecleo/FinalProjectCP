
namespace FinalProjectCP
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.ReceiptTB = new System.Windows.Forms.RichTextBox();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thank You and Have a nice meal!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReceiptTB
            // 
            this.ReceiptTB.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptTB.Location = new System.Drawing.Point(19, 37);
            this.ReceiptTB.Name = "ReceiptTB";
            this.ReceiptTB.ReadOnly = true;
            this.ReceiptTB.Size = new System.Drawing.Size(351, 499);
            this.ReceiptTB.TabIndex = 7;
            this.ReceiptTB.Text = "";
            this.ReceiptTB.WordWrap = false;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(123, 598);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(138, 23);
            this.Return.TabIndex = 8;
            this.Return.Text = "Return To Homepage";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 647);
            this.ControlBox = false;
            this.Controls.Add(this.Return);
            this.Controls.Add(this.ReceiptTB);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox ReceiptTB;
        private System.Windows.Forms.Button Return;
    }
}