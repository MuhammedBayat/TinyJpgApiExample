namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblToplam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PgBarDurum = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(137, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "COMPRESS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCounter.Location = new System.Drawing.Point(107, 147);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(54, 23);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "135";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(227, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "RESIM ISLENDI";
            // 
            // LblToplam
            // 
            this.LblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplam.Location = new System.Drawing.Point(167, 147);
            this.LblToplam.Name = "LblToplam";
            this.LblToplam.Size = new System.Drawing.Size(54, 23);
            this.LblToplam.TabIndex = 4;
            this.LblToplam.Text = "135";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(154, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // PgBarDurum
            // 
            this.PgBarDurum.Location = new System.Drawing.Point(12, 173);
            this.PgBarDurum.MarqueeAnimationSpeed = 0;
            this.PgBarDurum.Maximum = 200;
            this.PgBarDurum.Name = "PgBarDurum";
            this.PgBarDurum.Size = new System.Drawing.Size(460, 23);
            this.PgBarDurum.Step = 1;
            this.PgBarDurum.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 305);
            this.Controls.Add(this.PgBarDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "TINYJPG Image Compress TOOL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblToplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PgBarDurum;
    }
}

