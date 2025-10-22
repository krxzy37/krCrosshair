namespace krCrosshair
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControlMain = new TabControl();
            tabPage_uploadCross = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            button_setCr = new Button();
            label2 = new Label();
            textBox_sizeCr = new TextBox();
            button_addCr = new Button();
            label1 = new Label();
            pictureBox_CrPreview = new PictureBox();
            tabPage_createOwn = new TabPage();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            tabPage_hotKeys = new TabPage();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            colorDialog1 = new ColorDialog();
            label9 = new Label();
            panel1 = new Panel();
            trackBar1 = new TrackBar();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            tabControlMain.SuspendLayout();
            tabPage_uploadCross.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CrPreview).BeginInit();
            tabPage_createOwn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage_uploadCross);
            tabControlMain.Controls.Add(tabPage_createOwn);
            tabControlMain.Controls.Add(tabPage_hotKeys);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(558, 429);
            tabControlMain.TabIndex = 0;
            // 
            // tabPage_uploadCross
            // 
            tabPage_uploadCross.BackColor = Color.WhiteSmoke;
            tabPage_uploadCross.Controls.Add(listBox2);
            tabPage_uploadCross.Controls.Add(button4);
            tabPage_uploadCross.Controls.Add(button3);
            tabPage_uploadCross.Controls.Add(button2);
            tabPage_uploadCross.Controls.Add(label3);
            tabPage_uploadCross.Controls.Add(button1);
            tabPage_uploadCross.Controls.Add(button_setCr);
            tabPage_uploadCross.Controls.Add(label2);
            tabPage_uploadCross.Controls.Add(textBox_sizeCr);
            tabPage_uploadCross.Controls.Add(button_addCr);
            tabPage_uploadCross.Controls.Add(label1);
            tabPage_uploadCross.Controls.Add(pictureBox_CrPreview);
            tabPage_uploadCross.Location = new Point(4, 34);
            tabPage_uploadCross.Name = "tabPage_uploadCross";
            tabPage_uploadCross.Padding = new Padding(3);
            tabPage_uploadCross.Size = new Size(550, 391);
            tabPage_uploadCross.TabIndex = 0;
            tabPage_uploadCross.Text = "Upload Crosshair";
            // 
            // button4
            // 
            button4.Location = new Point(147, 205);
            button4.Name = "button4";
            button4.Size = new Size(141, 35);
            button4.TabIndex = 15;
            button4.Text = "Hide";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 205);
            button3.Name = "button3";
            button3.Size = new Size(141, 35);
            button3.TabIndex = 14;
            button3.Text = "Show";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 123);
            button2.Name = "button2";
            button2.Size = new Size(282, 35);
            button2.TabIndex = 13;
            button2.Text = "Delete crosshair";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 243);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 7;
            label3.Text = "Yours profiles:";
            // 
            // button1
            // 
            button1.Location = new Point(6, 82);
            button1.Name = "button1";
            button1.Size = new Size(282, 35);
            button1.TabIndex = 6;
            button1.Text = "Save Crosshair";
            button1.UseVisualStyleBackColor = true;
            // 
            // button_setCr
            // 
            button_setCr.Location = new Point(6, 164);
            button_setCr.Name = "button_setCr";
            button_setCr.Size = new Size(282, 35);
            button_setCr.TabIndex = 5;
            button_setCr.Text = "Set crosshair";
            button_setCr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 47);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 4;
            label2.Text = "set size";
            // 
            // textBox_sizeCr
            // 
            textBox_sizeCr.Location = new Point(100, 44);
            textBox_sizeCr.Name = "textBox_sizeCr";
            textBox_sizeCr.Size = new Size(188, 32);
            textBox_sizeCr.TabIndex = 3;
            // 
            // button_addCr
            // 
            button_addCr.Location = new Point(6, 6);
            button_addCr.Name = "button_addCr";
            button_addCr.Size = new Size(282, 35);
            button_addCr.TabIndex = 2;
            button_addCr.Text = "Upload crosshair";
            button_addCr.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 259);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 1;
            label1.Text = "crosshair preview";
            // 
            // pictureBox_CrPreview
            // 
            pictureBox_CrPreview.Location = new Point(294, 6);
            pictureBox_CrPreview.Name = "pictureBox_CrPreview";
            pictureBox_CrPreview.Size = new Size(250, 250);
            pictureBox_CrPreview.TabIndex = 0;
            pictureBox_CrPreview.TabStop = false;
            // 
            // tabPage_createOwn
            // 
            tabPage_createOwn.BackColor = Color.WhiteSmoke;
            tabPage_createOwn.Controls.Add(listBox1);
            tabPage_createOwn.Controls.Add(trackBar1);
            tabPage_createOwn.Controls.Add(panel1);
            tabPage_createOwn.Controls.Add(label9);
            tabPage_createOwn.Controls.Add(button8);
            tabPage_createOwn.Controls.Add(button7);
            tabPage_createOwn.Controls.Add(button6);
            tabPage_createOwn.Controls.Add(button5);
            tabPage_createOwn.Controls.Add(checkBox2);
            tabPage_createOwn.Controls.Add(checkBox1);
            tabPage_createOwn.Controls.Add(numericUpDown3);
            tabPage_createOwn.Controls.Add(numericUpDown2);
            tabPage_createOwn.Controls.Add(numericUpDown1);
            tabPage_createOwn.Controls.Add(label13);
            tabPage_createOwn.Controls.Add(label12);
            tabPage_createOwn.Controls.Add(label8);
            tabPage_createOwn.Controls.Add(label7);
            tabPage_createOwn.Controls.Add(label6);
            tabPage_createOwn.Controls.Add(label5);
            tabPage_createOwn.Controls.Add(label4);
            tabPage_createOwn.Controls.Add(pictureBox4);
            tabPage_createOwn.Location = new Point(4, 34);
            tabPage_createOwn.Name = "tabPage_createOwn";
            tabPage_createOwn.Padding = new Padding(3);
            tabPage_createOwn.Size = new Size(550, 391);
            tabPage_createOwn.TabIndex = 1;
            tabPage_createOwn.Text = "Create own";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 121);
            label13.Name = "label13";
            label13.Size = new Size(119, 25);
            label13.TabIndex = 15;
            label13.Text = "Center dot";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 215);
            label12.Name = "label12";
            label12.Size = new Size(69, 25);
            label12.TabIndex = 14;
            label12.Text = "Alpha";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 152);
            label8.Name = "label8";
            label8.Size = new Size(65, 25);
            label8.TabIndex = 10;
            label8.Text = "Color";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 84);
            label7.Name = "label7";
            label7.Size = new Size(52, 25);
            label7.TabIndex = 9;
            label7.Text = "Gap";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 46);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 8;
            label6.Text = "Thickness";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 8);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 7;
            label5.Text = "Lenght";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 259);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 3;
            label4.Text = "crosshair preview";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(294, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(250, 250);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // tabPage_hotKeys
            // 
            tabPage_hotKeys.BackColor = Color.WhiteSmoke;
            tabPage_hotKeys.Location = new Point(4, 34);
            tabPage_hotKeys.Name = "tabPage_hotKeys";
            tabPage_hotKeys.Size = new Size(550, 391);
            tabPage_hotKeys.TabIndex = 2;
            tabPage_hotKeys.Text = "Hotkeys";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(136, 6);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(153, 32);
            numericUpDown1.TabIndex = 16;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(136, 44);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(152, 32);
            numericUpDown2.TabIndex = 17;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(137, 82);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(152, 32);
            numericUpDown3.TabIndex = 18;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(137, 126);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 22;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(81, 220);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 23;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(134, 318);
            button5.Name = "button5";
            button5.Size = new Size(122, 35);
            button5.TabIndex = 25;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(6, 277);
            button6.Name = "button6";
            button6.Size = new Size(122, 35);
            button6.TabIndex = 26;
            button6.Text = "Show";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(6, 318);
            button7.Name = "button7";
            button7.Size = new Size(122, 35);
            button7.TabIndex = 27;
            button7.Text = "Save";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(134, 277);
            button8.Name = "button8";
            button8.Size = new Size(122, 35);
            button8.TabIndex = 28;
            button8.Text = "Hide";
            button8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 177);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 29;
            label9.Text = "Choose color";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(153, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 30);
            panel1.TabIndex = 30;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(105, 215);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(183, 56);
            trackBar1.TabIndex = 31;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(319, 299);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(225, 54);
            listBox1.TabIndex = 32;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(16, 296);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(511, 79);
            listBox2.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(tabControlMain);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            Text = "krCrosshair";
            tabControlMain.ResumeLayout(false);
            tabPage_uploadCross.ResumeLayout(false);
            tabPage_uploadCross.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CrPreview).EndInit();
            tabPage_createOwn.ResumeLayout(false);
            tabPage_createOwn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPage_uploadCross;
        private TabPage tabPage_createOwn;
        private Label label1;
        private PictureBox pictureBox_CrPreview;
        private Button button_addCr;
        private Label label2;
        private TextBox textBox_sizeCr;
        private Button button_setCr;
        private Label label3;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label4;
        private PictureBox pictureBox4;
        private TabPage tabPage_hotKeys;
        private Label label13;
        private Label label12;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Panel panel1;
        private Label label9;
        private Button button8;
        private ColorDialog colorDialog1;
        private TrackBar trackBar1;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}
