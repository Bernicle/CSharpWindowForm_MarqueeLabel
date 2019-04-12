namespace MarqueeLabelProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.marqueeLabel1 = new MarqueeLabelProject.MarqueeLabel();
            this.marqueeLabel2 = new MarqueeLabelProject.MarqueeLabel();
            this.marqueeLabel3 = new MarqueeLabelProject.MarqueeLabel();
            this.marqueeLabel4 = new MarqueeLabelProject.MarqueeLabel();
            this.marqueeLabel5 = new MarqueeLabelProject.MarqueeLabel();
            this.SuspendLayout();
            // 
            // marqueeLabel1
            // 
            this.marqueeLabel1.BackColor = System.Drawing.Color.White;
            this.marqueeLabel1.Location = new System.Drawing.Point(44, 35);
            this.marqueeLabel1.MarqueeSpeed = 50;
            this.marqueeLabel1.Name = "marqueeLabel1";
            this.marqueeLabel1.PrimaryColor = System.Drawing.Color.White;
            this.marqueeLabel1.SecondaryColor = System.Drawing.Color.Black;
            this.marqueeLabel1.Size = new System.Drawing.Size(718, 32);
            this.marqueeLabel1.TabIndex = 0;
            this.marqueeLabel1.TextDisplay = "Marquee Label With 50 MarqueeSpeed";
            // 
            // marqueeLabel2
            // 
            this.marqueeLabel2.BackColor = System.Drawing.Color.Aqua;
            this.marqueeLabel2.Location = new System.Drawing.Point(44, 103);
            this.marqueeLabel2.MarqueeSpeed = 500;
            this.marqueeLabel2.Name = "marqueeLabel2";
            this.marqueeLabel2.PrimaryColor = System.Drawing.Color.Aqua;
            this.marqueeLabel2.SecondaryColor = System.Drawing.Color.SaddleBrown;
            this.marqueeLabel2.Size = new System.Drawing.Size(718, 32);
            this.marqueeLabel2.TabIndex = 1;
            this.marqueeLabel2.TextDisplay = "Marquee Label With Costume Color";
            // 
            // marqueeLabel3
            // 
            this.marqueeLabel3.BackColor = System.Drawing.Color.CadetBlue;
            this.marqueeLabel3.Location = new System.Drawing.Point(44, 164);
            this.marqueeLabel3.MarqueeSpeed = 500;
            this.marqueeLabel3.Name = "marqueeLabel3";
            this.marqueeLabel3.PrimaryColor = System.Drawing.Color.CadetBlue;
            this.marqueeLabel3.SecondaryColor = System.Drawing.Color.PaleTurquoise;
            this.marqueeLabel3.Size = new System.Drawing.Size(718, 32);
            this.marqueeLabel3.TabIndex = 2;
            this.marqueeLabel3.TextDisplay = "Marquee Label With Costume Color";
            // 
            // marqueeLabel4
            // 
            this.marqueeLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marqueeLabel4.Location = new System.Drawing.Point(44, 228);
            this.marqueeLabel4.MarqueeSpeed = 500;
            this.marqueeLabel4.Name = "marqueeLabel4";
            this.marqueeLabel4.PrimaryColor = System.Drawing.SystemColors.Control;
            this.marqueeLabel4.SecondaryColor = System.Drawing.SystemColors.ControlText;
            this.marqueeLabel4.Size = new System.Drawing.Size(718, 51);
            this.marqueeLabel4.TabIndex = 3;
            this.marqueeLabel4.TextDisplay = "Marquee Label With Border";
            // 
            // marqueeLabel5
            // 
            this.marqueeLabel5.BackColor = System.Drawing.Color.Aqua;
            this.marqueeLabel5.Location = new System.Drawing.Point(44, 312);
            this.marqueeLabel5.MarqueeSpeed = 500;
            this.marqueeLabel5.Name = "marqueeLabel5";
            this.marqueeLabel5.PrimaryColor = System.Drawing.Color.Aqua;
            this.marqueeLabel5.SecondaryColor = System.Drawing.Color.SaddleBrown;
            this.marqueeLabel5.Size = new System.Drawing.Size(718, 52);
            this.marqueeLabel5.TabIndex = 4;
            this.marqueeLabel5.TextDisplay = resources.GetString("marqueeLabel5.TextDisplay");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.marqueeLabel5);
            this.Controls.Add(this.marqueeLabel4);
            this.Controls.Add(this.marqueeLabel3);
            this.Controls.Add(this.marqueeLabel2);
            this.Controls.Add(this.marqueeLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MarqueeLabel marqueeLabel1;
        private MarqueeLabel marqueeLabel2;
        private MarqueeLabel marqueeLabel3;
        private MarqueeLabel marqueeLabel4;
        private MarqueeLabel marqueeLabel5;
    }
}

