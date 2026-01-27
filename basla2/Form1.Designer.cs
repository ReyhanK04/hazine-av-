
namespace basla2
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            boyutgirlabel = new Label();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(495, 436);
            button1.Name = "button1";
            button1.Size = new Size(151, 93);
            button1.TabIndex = 0;
            button1.Text = "oyunu başlat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // boyutgirlabel
            // 
            boyutgirlabel.AutoSize = true;
            boyutgirlabel.BackColor = Color.CornflowerBlue;
            boyutgirlabel.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            boyutgirlabel.ForeColor = Color.FromArgb(192, 0, 0);
            boyutgirlabel.Location = new Point(420, 239);
            boyutgirlabel.Name = "boyutgirlabel";
            boyutgirlabel.Size = new Size(282, 46);
            boyutgirlabel.TabIndex = 1;
            boyutgirlabel.Tag = "boyutgirlabel";
            boyutgirlabel.Text = "boyutu giriniz ! ";
            boyutgirlabel.Click += boyutgirlabel_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(128, 128, 255);
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.FromArgb(192, 0, 0);
            textBox1.Location = new Point(481, 340);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 38);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Ekran_görüntüsü_2024_03_18_030527;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1150, 803);
            Controls.Add(textBox1);
            Controls.Add(boyutgirlabel);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void boyutgirlabel_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Button button1;
        private Label boyutgirlabel;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
