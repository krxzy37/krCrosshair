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
            tabPage_createOwn = new TabPage();
            pictureBox_CrPreview = new PictureBox();
            label1 = new Label();
            button_addCr = new Button();
            textBox_sizeCr = new TextBox();
            label2 = new Label();
            button_setCr = new Button();
            button1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tabControlMain.SuspendLayout();
            tabPage_uploadCross.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CrPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage_uploadCross);
            tabControlMain.Controls.Add(tabPage_createOwn);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(558, 429);
            tabControlMain.TabIndex = 0;
            // 
            // tabPage_uploadCross
            // 
            tabPage_uploadCross.BackColor = Color.WhiteSmoke;
            tabPage_uploadCross.Controls.Add(button4);
            tabPage_uploadCross.Controls.Add(button3);
            tabPage_uploadCross.Controls.Add(button2);
            tabPage_uploadCross.Controls.Add(pictureBox5);
            tabPage_uploadCross.Controls.Add(pictureBox4);
            tabPage_uploadCross.Controls.Add(pictureBox3);
            tabPage_uploadCross.Controls.Add(pictureBox2);
            tabPage_uploadCross.Controls.Add(pictureBox1);
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
            // tabPage_createOwn
            // 
            tabPage_createOwn.BackColor = Color.WhiteSmoke;
            tabPage_createOwn.Location = new Point(4, 34);
            tabPage_createOwn.Name = "tabPage_createOwn";
            tabPage_createOwn.Padding = new Padding(3);
            tabPage_createOwn.Size = new Size(550, 391);
            tabPage_createOwn.TabIndex = 1;
            tabPage_createOwn.Text = "Create own";
            // 
            // pictureBox_CrPreview
            // 
            pictureBox_CrPreview.Location = new Point(294, 6);
            pictureBox_CrPreview.Name = "pictureBox_CrPreview";
            pictureBox_CrPreview.Size = new Size(250, 250);
            pictureBox_CrPreview.TabIndex = 0;
            pictureBox_CrPreview.TabStop = false;
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
            // button_addCr
            // 
            button_addCr.Location = new Point(6, 6);
            button_addCr.Name = "button_addCr";
            button_addCr.Size = new Size(282, 35);
            button_addCr.TabIndex = 2;
            button_addCr.Text = "Upload crosshair";
            button_addCr.UseVisualStyleBackColor = true;
            // 
            // textBox_sizeCr
            // 
            textBox_sizeCr.Location = new Point(100, 44);
            textBox_sizeCr.Name = "textBox_sizeCr";
            textBox_sizeCr.Size = new Size(188, 32);
            textBox_sizeCr.TabIndex = 3;
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
            // button_setCr
            // 
            button_setCr.Location = new Point(6, 164);
            button_setCr.Name = "button_setCr";
            button_setCr.Size = new Size(282, 35);
            button_setCr.TabIndex = 5;
            button_setCr.Text = "Set crosshair";
            button_setCr.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 259);
            label3.Name = "label3";
            label3.Size = new Size(184, 25);
            label3.TabIndex = 7;
            label3.Text = "Yours crosshairs:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 287);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(117, 287);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(226, 287);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 90);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(336, 287);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(90, 90);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(454, 287);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(90, 90);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
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
            // button3
            // 
            button3.Location = new Point(6, 205);
            button3.Name = "button3";
            button3.Size = new Size(141, 35);
            button3.TabIndex = 14;
            button3.Text = "Show";
            button3.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
