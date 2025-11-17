using System.Windows.Forms;
using System.Xml.Linq;

namespace GUIAdventure
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 83);
            label1.Name = "label1";
            label1.Size = new Size(432, 90);
            label1.TabIndex = 0;
            label1.Text = "Welcome!\r\nWant to start your adventure?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(155, 292);
            button1.Name = "button1";
            button1.Size = new Size(202, 60);
            button1.TabIndex = 1;
            button1.Text = "No!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(435, 292);
            button2.Name = "button2";
            button2.Size = new Size(208, 60);
            button2.TabIndex = 2;
            button2.Text = "Yes!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(175, 220);
            trackBar1.Maximum = 5;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(449, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TrackBar trackBar1;
    }
}
