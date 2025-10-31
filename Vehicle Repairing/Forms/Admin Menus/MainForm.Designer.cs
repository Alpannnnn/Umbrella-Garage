namespace Vehicle_Repairing.Forms
{
    partial class MainForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            label2 = new Label();
            namatextbox = new TextBox();
            nomortextbox = new TextBox();
            label3 = new Label();
            emailtextbox = new TextBox();
            label4 = new Label();
            alamattextbox = new TextBox();
            label5 = new Label();
            tipetextbox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            perbaikancombobox = new ComboBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            submitbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 43);
            label1.Name = "label1";
            label1.Size = new Size(400, 41);
            label1.TabIndex = 0;
            label1.Text = "SIAPKAN DATA DIRI ANDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 151);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama Lengkap";
            // 
            // namatextbox
            // 
            namatextbox.Location = new Point(233, 148);
            namatextbox.Name = "namatextbox";
            namatextbox.Size = new Size(343, 27);
            namatextbox.TabIndex = 2;
            // 
            // nomortextbox
            // 
            nomortextbox.Location = new Point(233, 193);
            nomortextbox.Name = "nomortextbox";
            nomortextbox.Size = new Size(343, 27);
            nomortextbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 196);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 3;
            label3.Text = "Nomor Telepon";
            // 
            // emailtextbox
            // 
            emailtextbox.Location = new Point(233, 238);
            emailtextbox.Name = "emailtextbox";
            emailtextbox.Size = new Size(343, 27);
            emailtextbox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 241);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // alamattextbox
            // 
            alamattextbox.Location = new Point(233, 281);
            alamattextbox.Name = "alamattextbox";
            alamattextbox.Size = new Size(343, 27);
            alamattextbox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(74, 284);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 7;
            label5.Text = "Alamat";
            // 
            // tipetextbox
            // 
            tipetextbox.Location = new Point(233, 324);
            tipetextbox.Name = "tipetextbox";
            tipetextbox.Size = new Size(343, 27);
            tipetextbox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(74, 327);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 9;
            label6.Text = "Tipe Mobil";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.White;
            label7.Location = new Point(74, 372);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 11;
            label7.Text = "Perbaikan";
            // 
            // perbaikancombobox
            // 
            perbaikancombobox.FormattingEnabled = true;
            perbaikancombobox.Location = new Point(233, 369);
            perbaikancombobox.Name = "perbaikancombobox";
            perbaikancombobox.Size = new Size(343, 28);
            perbaikancombobox.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(74, 416);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 14;
            label8.Text = "Tanggal Perbaikan";
            label8.Click += label8_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(233, 411);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(343, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // submitbutton
            // 
            submitbutton.Location = new Point(482, 464);
            submitbutton.Name = "submitbutton";
            submitbutton.Size = new Size(94, 29);
            submitbutton.TabIndex = 16;
            submitbutton.Text = "Submit";
            submitbutton.UseVisualStyleBackColor = true;
            submitbutton.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(submitbutton);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(perbaikancombobox);
            Controls.Add(label7);
            Controls.Add(tipetextbox);
            Controls.Add(label6);
            Controls.Add(alamattextbox);
            Controls.Add(label5);
            Controls.Add(emailtextbox);
            Controls.Add(label4);
            Controls.Add(nomortextbox);
            Controls.Add(label3);
            Controls.Add(namatextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Size = new Size(781, 568);
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox namatextbox;
        private TextBox nomortextbox;
        private Label label3;
        private TextBox emailtextbox;
        private Label label4;
        private TextBox alamattextbox;
        private Label label5;
        private TextBox tipetextbox;
        private Label label6;
        private Label label7;
        private ComboBox perbaikancombobox;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Button submitbutton;
    }
}
