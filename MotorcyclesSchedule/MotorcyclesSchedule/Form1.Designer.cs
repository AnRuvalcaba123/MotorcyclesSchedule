
namespace MotorcyclesSchedule
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title1 = new System.Windows.Forms.Label();
            this.Ttitle2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.btmPlus = new System.Windows.Forms.Button();
            this.btmMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title1.Location = new System.Drawing.Point(60, 9);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(170, 30);
            this.Title1.TabIndex = 0;
            this.Title1.Text = "Available riders";
            this.Title1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ttitle2
            // 
            this.Ttitle2.AutoSize = true;
            this.Ttitle2.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ttitle2.Location = new System.Drawing.Point(390, 9);
            this.Ttitle2.Name = "Ttitle2";
            this.Ttitle2.Size = new System.Drawing.Size(105, 30);
            this.Ttitle2.TabIndex = 1;
            this.Ttitle2.Text = "Schedule";
            this.Ttitle2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl1.Location = new System.Drawing.Point(125, 65);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(32, 37);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "8";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cB1
            // 
            this.cB1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cB1.FormattingEnabled = true;
            this.cB1.Location = new System.Drawing.Point(281, 65);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(351, 33);
            this.cB1.TabIndex = 3;
            this.cB1.SelectedIndexChanged += new System.EventHandler(this.cB1_SelectedIndexChanged);
            // 
            // btmPlus
            // 
            this.btmPlus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmPlus.Location = new System.Drawing.Point(75, 60);
            this.btmPlus.Name = "btmPlus";
            this.btmPlus.Size = new System.Drawing.Size(29, 46);
            this.btmPlus.TabIndex = 4;
            this.btmPlus.Text = "+";
            this.btmPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btmPlus.UseVisualStyleBackColor = true;
            // 
            // btmMinus
            // 
            this.btmMinus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmMinus.Location = new System.Drawing.Point(179, 60);
            this.btmMinus.Name = "btmMinus";
            this.btmMinus.Size = new System.Drawing.Size(29, 46);
            this.btmMinus.TabIndex = 5;
            this.btmMinus.Text = "-";
            this.btmMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btmMinus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(644, 141);
            this.Controls.Add(this.btmMinus);
            this.Controls.Add(this.btmPlus);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Ttitle2);
            this.Controls.Add(this.Title1);
            this.Name = "Form1";
            this.Text = "MotorcyclesSchedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.Label Ttitle2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.Button btmPlus;
        private System.Windows.Forms.Button btmMinus;
    }
}

