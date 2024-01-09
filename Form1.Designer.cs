namespace WinForms_Program01
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
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            hScrollBar1 = new HScrollBar();
            listBox1 = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.AppStarting;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(167, 119);
            button1.Name = "button1";
            button1.Size = new Size(189, 68);
            button1.TabIndex = 0;
            button1.Text = "Cliquer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(579, 119);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(410, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(134, 427);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(537, 20);
            hScrollBar1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(167, 272);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(204, 139);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(711, 119);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(526, 256);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 63);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(534, 342);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(894, 546);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(hScrollBar1);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Mon premier programme";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private HScrollBar hScrollBar1;
        private ListBox listBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private ToolTip toolTip1;
    }
}
