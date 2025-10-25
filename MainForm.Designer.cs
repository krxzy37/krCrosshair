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
            numericSize = new NumericUpDown();
            listBox2 = new ListBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            button_SaveCr = new Button();
            button_setCr = new Button();
            label2 = new Label();
            button_addCr = new Button();
            label1 = new Label();
            pictureBox_CrPreview = new PictureBox();
            tabPage_createOwn = new TabPage();
            listBox1 = new ListBox();
            trackBar1 = new TrackBar();
            panel1 = new Panel();
            label9 = new Label();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            tabPage_hotKeys = new TabPage();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            colorDialog1 = new ColorDialog();
            tabControlMain.SuspendLayout();
            tabPage_uploadCross.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CrPreview).BeginInit();
            tabPage_createOwn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabPage_hotKeys.SuspendLayout();
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
            tabPage_uploadCross.Controls.Add(numericSize);
            tabPage_uploadCross.Controls.Add(listBox2);
            tabPage_uploadCross.Controls.Add(button4);
            tabPage_uploadCross.Controls.Add(button3);
            tabPage_uploadCross.Controls.Add(button2);
            tabPage_uploadCross.Controls.Add(label3);
            tabPage_uploadCross.Controls.Add(button_SaveCr);
            tabPage_uploadCross.Controls.Add(button_setCr);
            tabPage_uploadCross.Controls.Add(label2);
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
            // numericSize
            // 
            numericSize.Location = new Point(100, 47);
            numericSize.Name = "numericSize";
            numericSize.Size = new Size(188, 32);
            numericSize.TabIndex = 17;
            numericSize.ValueChanged += numericSize_ValueChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(6, 297);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(511, 79);
            listBox2.TabIndex = 16;
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
            // button_SaveCr
            // 
            button_SaveCr.Location = new Point(6, 82);
            button_SaveCr.Name = "button_SaveCr";
            button_SaveCr.Size = new Size(282, 35);
            button_SaveCr.TabIndex = 6;
            button_SaveCr.Text = "Save Crosshair";
            button_SaveCr.UseVisualStyleBackColor = true;
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
            // button_addCr
            // 
            button_addCr.Location = new Point(6, 6);
            button_addCr.Name = "button_addCr";
            button_addCr.Size = new Size(282, 35);
            button_addCr.TabIndex = 2;
            button_addCr.Text = "Upload crosshair";
            button_addCr.UseVisualStyleBackColor = true;
            button_addCr.Click += button_addCr_Click;
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
            pictureBox_CrPreview.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_CrPreview.Location = new Point(294, 6);
            pictureBox_CrPreview.Name = "pictureBox_CrPreview";
            pictureBox_CrPreview.Size = new Size(250, 250);
            pictureBox_CrPreview.SizeMode = PictureBoxSizeMode.Zoom;
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
            tabPage_createOwn.Location = new Point(4, 29);
            tabPage_createOwn.Name = "tabPage_createOwn";
            tabPage_createOwn.Padding = new Padding(3);
            tabPage_createOwn.Size = new Size(550, 396);
            tabPage_createOwn.TabIndex = 1;
            tabPage_createOwn.Text = "Create own";
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
            // trackBar1
            // 
            trackBar1.Location = new Point(105, 215);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(183, 56);
            trackBar1.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(153, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 30);
            panel1.TabIndex = 30;
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
            // button8
            // 
            button8.Location = new Point(134, 277);
            button8.Name = "button8";
            button8.Size = new Size(122, 35);
            button8.TabIndex = 28;
            button8.Text = "Hide";
            button8.UseVisualStyleBackColor = true;
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
            // button6
            // 
            button6.Location = new Point(6, 277);
            button6.Name = "button6";
            button6.Size = new Size(122, 35);
            button6.TabIndex = 26;
            button6.Text = "Show";
            button6.UseVisualStyleBackColor = true;
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
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(81, 220);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 23;
            checkBox2.UseVisualStyleBackColor = true;
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
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(137, 82);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(152, 32);
            numericUpDown3.TabIndex = 18;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(136, 44);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(152, 32);
            numericUpDown2.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(136, 6);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(153, 32);
            numericUpDown1.TabIndex = 16;
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
            tabPage_hotKeys.Controls.Add(button11);
            tabPage_hotKeys.Controls.Add(button10);
            tabPage_hotKeys.Controls.Add(button9);
            tabPage_hotKeys.Controls.Add(textBox3);
            tabPage_hotKeys.Controls.Add(textBox2);
            tabPage_hotKeys.Controls.Add(textBox1);
            tabPage_hotKeys.Controls.Add(label14);
            tabPage_hotKeys.Controls.Add(label11);
            tabPage_hotKeys.Controls.Add(label10);
            tabPage_hotKeys.Location = new Point(4, 29);
            tabPage_hotKeys.Name = "tabPage_hotKeys";
            tabPage_hotKeys.Size = new Size(550, 396);
            tabPage_hotKeys.TabIndex = 2;
            tabPage_hotKeys.Text = "Hotkeys";
            // 
            // button11
            // 
            button11.Location = new Point(336, 83);
            button11.Name = "button11";
            button11.Size = new Size(32, 32);
            button11.TabIndex = 8;
            button11.Text = "X";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(336, 44);
            button10.Name = "button10";
            button10.Size = new Size(32, 32);
            button10.TabIndex = 7;
            button10.Text = "X";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(336, 7);
            button9.Name = "button9";
            button9.Size = new Size(32, 32);
            button9.TabIndex = 6;
            button9.Text = "X";
            button9.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 32);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 32);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 32);
            textBox1.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 86);
            label14.Name = "label14";
            label14.Size = new Size(196, 25);
            label14.TabIndex = 2;
            label14.Text = "Previous crosshair";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 45);
            label11.Name = "label11";
            label11.Size = new Size(157, 25);
            label11.TabIndex = 1;
            label11.Text = "Next crosshair";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 9);
            label10.Name = "label10";
            label10.Size = new Size(135, 25);
            label10.TabIndex = 0;
            label10.Text = "Show / Hide";
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
            ((System.ComponentModel.ISupportInitialize)numericSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CrPreview).EndInit();
            tabPage_createOwn.ResumeLayout(false);
            tabPage_createOwn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabPage_hotKeys.ResumeLayout(false);
            tabPage_hotKeys.PerformLayout();
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
        private Button button_setCr;
        private Label label3;
        private Button button_SaveCr;
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
        private Label label10;
        private Button button11;
        private Button button10;
        private Button button9;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label14;
        private Label label11;
        private NumericUpDown numericSize;
    }
}
