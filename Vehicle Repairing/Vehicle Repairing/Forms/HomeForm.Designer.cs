namespace Vehicle_Repairing.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bookbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Engravers MT", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 71);
            label1.Name = "label1";
            label1.Size = new Size(0, 0);
            label1.TabIndex = 0;
            label1.Text = "GORE GARAGE";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Driving Around", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.BurlyWood;
            label2.Location = new Point(176, 106);
            label2.Name = "label2";
            label2.Size = new Size(451, 54);
            label2.TabIndex = 1;
            label2.Text = "UMBRELLA GARAGE";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(253, 160);
            label3.Name = "label3";
            label3.Size = new Size(320, 31);
            label3.TabIndex = 2;
            label3.Text = "Kenali kendaraan anda sekarang!";
            // 
            // bookbtn
            // 
            bookbtn.Font = new Font("Baskerville Old Face", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookbtn.Location = new Point(329, 256);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(161, 60);
            bookbtn.TabIndex = 3;
            bookbtn.Text = "BOOK NOW!";
            bookbtn.UseVisualStyleBackColor = true;
            bookbtn.Click += bookbtn_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(bookbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomeForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button bookbtn;
    }
}