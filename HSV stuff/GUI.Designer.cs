namespace HSV_stuff
{
    partial class GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScreenWidth = new System.Windows.Forms.NumericUpDown();
            this.ScreenHeight = new System.Windows.Forms.NumericUpDown();
            this.CapWidth = new System.Windows.Forms.NumericUpDown();
            this.CapHeight = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.getImage = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.H_MIN = new System.Windows.Forms.NumericUpDown();
            this.H_MAX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.S_MIN = new System.Windows.Forms.NumericUpDown();
            this.S_MAX = new System.Windows.Forms.NumericUpDown();
            this.V_MIN = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.V_MAX = new System.Windows.Forms.NumericUpDown();
            this.range = new System.Windows.Forms.CheckBox();
            this.morph = new System.Windows.Forms.CheckBox();
            this.morphAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_MIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_MAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_MIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_MAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_MIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_MAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.morphAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Screen X/Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Capture X/Y";
            // 
            // ScreenWidth
            // 
            this.ScreenWidth.Location = new System.Drawing.Point(81, 7);
            this.ScreenWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ScreenWidth.Name = "ScreenWidth";
            this.ScreenWidth.Size = new System.Drawing.Size(100, 20);
            this.ScreenWidth.TabIndex = 16;
            // 
            // ScreenHeight
            // 
            this.ScreenHeight.Location = new System.Drawing.Point(187, 7);
            this.ScreenHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ScreenHeight.Name = "ScreenHeight";
            this.ScreenHeight.Size = new System.Drawing.Size(100, 20);
            this.ScreenHeight.TabIndex = 17;
            // 
            // CapWidth
            // 
            this.CapWidth.Location = new System.Drawing.Point(81, 33);
            this.CapWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CapWidth.Name = "CapWidth";
            this.CapWidth.Size = new System.Drawing.Size(100, 20);
            this.CapWidth.TabIndex = 18;
            // 
            // CapHeight
            // 
            this.CapHeight.Location = new System.Drawing.Point(187, 33);
            this.CapHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CapHeight.Name = "CapHeight";
            this.CapHeight.Size = new System.Drawing.Size(100, 20);
            this.CapHeight.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1557, 790);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // getImage
            // 
            this.getImage.Location = new System.Drawing.Point(1486, 4);
            this.getImage.Name = "getImage";
            this.getImage.Size = new System.Drawing.Size(86, 23);
            this.getImage.TabIndex = 21;
            this.getImage.Text = "Start";
            this.getImage.UseVisualStyleBackColor = true;
            this.getImage.Click += new System.EventHandler(this.getImage_Click_1);
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(1486, 30);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(86, 23);
            this.modify.TabIndex = 22;
            this.modify.Text = "Stop";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1020, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "H_MIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1020, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "H_MAX";
            // 
            // H_MIN
            // 
            this.H_MIN.Location = new System.Drawing.Point(1070, 7);
            this.H_MIN.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.H_MIN.Name = "H_MIN";
            this.H_MIN.Size = new System.Drawing.Size(100, 20);
            this.H_MIN.TabIndex = 25;
            // 
            // H_MAX
            // 
            this.H_MAX.Location = new System.Drawing.Point(1070, 33);
            this.H_MAX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.H_MAX.Name = "H_MAX";
            this.H_MAX.Size = new System.Drawing.Size(100, 20);
            this.H_MAX.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1176, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "S_MIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1176, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "S_MAX";
            // 
            // S_MIN
            // 
            this.S_MIN.Location = new System.Drawing.Point(1225, 7);
            this.S_MIN.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.S_MIN.Name = "S_MIN";
            this.S_MIN.Size = new System.Drawing.Size(100, 20);
            this.S_MIN.TabIndex = 29;
            // 
            // S_MAX
            // 
            this.S_MAX.Location = new System.Drawing.Point(1225, 33);
            this.S_MAX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.S_MAX.Name = "S_MAX";
            this.S_MAX.Size = new System.Drawing.Size(100, 20);
            this.S_MAX.TabIndex = 30;
            // 
            // V_MIN
            // 
            this.V_MIN.Location = new System.Drawing.Point(1380, 7);
            this.V_MIN.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.V_MIN.Name = "V_MIN";
            this.V_MIN.Size = new System.Drawing.Size(100, 20);
            this.V_MIN.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1331, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "V_MIN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1331, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "V_MAX";
            // 
            // V_MAX
            // 
            this.V_MAX.Location = new System.Drawing.Point(1380, 33);
            this.V_MAX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.V_MAX.Name = "V_MAX";
            this.V_MAX.Size = new System.Drawing.Size(100, 20);
            this.V_MAX.TabIndex = 34;
            // 
            // range
            // 
            this.range.AutoSize = true;
            this.range.Location = new System.Drawing.Point(923, 8);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(58, 17);
            this.range.TabIndex = 35;
            this.range.Text = "Range";
            this.range.UseVisualStyleBackColor = true;
            // 
            // morph
            // 
            this.morph.AutoSize = true;
            this.morph.Location = new System.Drawing.Point(923, 34);
            this.morph.Name = "morph";
            this.morph.Size = new System.Drawing.Size(75, 17);
            this.morph.TabIndex = 36;
            this.morph.Text = "MorphOps";
            this.morph.UseVisualStyleBackColor = true;
            // 
            // morphAmount
            // 
            this.morphAmount.Location = new System.Drawing.Point(817, 33);
            this.morphAmount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.morphAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.morphAmount.Name = "morphAmount";
            this.morphAmount.Size = new System.Drawing.Size(100, 20);
            this.morphAmount.TabIndex = 37;
            this.morphAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.morphAmount);
            this.Controls.Add(this.morph);
            this.Controls.Add(this.range);
            this.Controls.Add(this.V_MAX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.V_MIN);
            this.Controls.Add(this.S_MAX);
            this.Controls.Add(this.S_MIN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.H_MAX);
            this.Controls.Add(this.H_MIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.getImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CapHeight);
            this.Controls.Add(this.CapWidth);
            this.Controls.Add(this.ScreenHeight);
            this.Controls.Add(this.ScreenWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ScreenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_MIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_MAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_MIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_MAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_MIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_MAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.morphAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ScreenWidth;
        private System.Windows.Forms.NumericUpDown ScreenHeight;
        private System.Windows.Forms.NumericUpDown CapWidth;
        private System.Windows.Forms.NumericUpDown CapHeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button getImage;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown H_MIN;
        private System.Windows.Forms.NumericUpDown H_MAX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown S_MIN;
        private System.Windows.Forms.NumericUpDown S_MAX;
        private System.Windows.Forms.NumericUpDown V_MIN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown V_MAX;
        private System.Windows.Forms.CheckBox range;
        private System.Windows.Forms.CheckBox morph;
        private System.Windows.Forms.NumericUpDown morphAmount;
    }
}

