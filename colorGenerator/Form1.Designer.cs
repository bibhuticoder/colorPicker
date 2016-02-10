namespace colorGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barRed = new System.Windows.Forms.TrackBar();
            this.barGreen = new System.Windows.Forms.TrackBar();
            this.barBlue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbColorRGB = new System.Windows.Forms.PictureBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btnColorPickerCopy = new System.Windows.Forms.Button();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerPicker = new System.Windows.Forms.Timer(this.components);
            this.pbPicker = new System.Windows.Forms.PictureBox();
            this.pbColorPicker = new System.Windows.Forms.PictureBox();
            this.tbColorPickerHex = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPressP = new System.Windows.Forms.Label();
            this.lblZoomFactor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zoomFactor = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPicker)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomFactor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barRed
            // 
            this.barRed.Location = new System.Drawing.Point(19, 36);
            this.barRed.Maximum = 255;
            this.barRed.Name = "barRed";
            this.barRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barRed.Size = new System.Drawing.Size(45, 182);
            this.barRed.TabIndex = 0;
            this.barRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barRed.Value = 255;
            this.barRed.Scroll += new System.EventHandler(this.barRed_Scroll);
            // 
            // barGreen
            // 
            this.barGreen.Location = new System.Drawing.Point(59, 35);
            this.barGreen.Maximum = 255;
            this.barGreen.Name = "barGreen";
            this.barGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGreen.Size = new System.Drawing.Size(45, 183);
            this.barGreen.TabIndex = 1;
            this.barGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barGreen.Value = 255;
            this.barGreen.Scroll += new System.EventHandler(this.barRed_Scroll);
            // 
            // barBlue
            // 
            this.barBlue.LargeChange = 1;
            this.barBlue.Location = new System.Drawing.Point(99, 35);
            this.barBlue.Maximum = 255;
            this.barBlue.Name = "barBlue";
            this.barBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barBlue.Size = new System.Drawing.Size(45, 183);
            this.barBlue.TabIndex = 2;
            this.barBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barBlue.Value = 255;
            this.barBlue.Scroll += new System.EventHandler(this.barRed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(54, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(95, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // pbColorRGB
            // 
            this.pbColorRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColorRGB.Location = new System.Drawing.Point(7, 239);
            this.pbColorRGB.Name = "pbColorRGB";
            this.pbColorRGB.Size = new System.Drawing.Size(135, 21);
            this.pbColorRGB.TabIndex = 6;
            this.pbColorRGB.TabStop = false;
            // 
            // tbColor
            // 
            this.tbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColor.Location = new System.Drawing.Point(7, 266);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(84, 26);
            this.tbColor.TabIndex = 8;
            this.tbColor.Text = "#FFFFFF";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Copy";
            this.toolTip.SetToolTip(this.button1, "Copy Hex value to Clipboard");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(66, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "Pick";
            this.toolTip.SetToolTip(this.button2, "Color Picker");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnColorPickerCopy
            // 
            this.btnColorPickerCopy.Location = new System.Drawing.Point(169, 248);
            this.btnColorPickerCopy.Name = "btnColorPickerCopy";
            this.btnColorPickerCopy.Size = new System.Drawing.Size(42, 28);
            this.btnColorPickerCopy.TabIndex = 20;
            this.btnColorPickerCopy.Text = "Copy";
            this.toolTip.SetToolTip(this.btnColorPickerCopy, "Copy Hex value to Clipboard");
            this.btnColorPickerCopy.UseVisualStyleBackColor = true;
            this.btnColorPickerCopy.Click += new System.EventHandler(this.btnColorPickerCopy_Click);
            // 
            // lblRedValue
            // 
            this.lblRedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedValue.Location = new System.Drawing.Point(13, 213);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(32, 25);
            this.lblRedValue.TabIndex = 10;
            this.lblRedValue.Text = "255";
            this.lblRedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenValue.Location = new System.Drawing.Point(52, 213);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(32, 25);
            this.lblGreenValue.TabIndex = 11;
            this.lblGreenValue.Text = "255";
            this.lblGreenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueValue.Location = new System.Drawing.Point(90, 213);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(32, 25);
            this.lblBlueValue.TabIndex = 12;
            this.lblBlueValue.Text = "255";
            this.lblBlueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(585, 10);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // timerPicker
            // 
            this.timerPicker.Tick += new System.EventHandler(this.timerPicker_Tick);
            // 
            // pbPicker
            // 
            this.pbPicker.BackColor = System.Drawing.Color.White;
            this.pbPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicker.Location = new System.Drawing.Point(14, 52);
            this.pbPicker.Name = "pbPicker";
            this.pbPicker.Size = new System.Drawing.Size(190, 190);
            this.pbPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicker.TabIndex = 16;
            this.pbPicker.TabStop = false;
            this.pbPicker.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPicker_Paint);
            // 
            // pbColorPicker
            // 
            this.pbColorPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColorPicker.Location = new System.Drawing.Point(14, 249);
            this.pbColorPicker.Name = "pbColorPicker";
            this.pbColorPicker.Size = new System.Drawing.Size(27, 25);
            this.pbColorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColorPicker.TabIndex = 17;
            this.pbColorPicker.TabStop = false;
            // 
            // tbColorPickerHex
            // 
            this.tbColorPickerHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorPickerHex.Location = new System.Drawing.Point(47, 249);
            this.tbColorPickerHex.Name = "tbColorPickerHex";
            this.tbColorPickerHex.Size = new System.Drawing.Size(116, 26);
            this.tbColorPickerHex.TabIndex = 19;
            this.tbColorPickerHex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPressP);
            this.groupBox1.Controls.Add(this.lblZoomFactor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.zoomFactor);
            this.groupBox1.Controls.Add(this.pbPicker);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnColorPickerCopy);
            this.groupBox1.Controls.Add(this.pbColorPicker);
            this.groupBox1.Controls.Add(this.tbColorPickerHex);
            this.groupBox1.Location = new System.Drawing.Point(175, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 318);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Picker";
            // 
            // lblPressP
            // 
            this.lblPressP.AutoSize = true;
            this.lblPressP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPressP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressP.Location = new System.Drawing.Point(63, 63);
            this.lblPressP.Name = "lblPressP";
            this.lblPressP.Size = new System.Drawing.Size(89, 15);
            this.lblPressP.TabIndex = 23;
            this.lblPressP.Text = "Pres P to pick";
            this.lblPressP.Visible = false;
            // 
            // lblZoomFactor
            // 
            this.lblZoomFactor.AutoSize = true;
            this.lblZoomFactor.Location = new System.Drawing.Point(192, 294);
            this.lblZoomFactor.Name = "lblZoomFactor";
            this.lblZoomFactor.Size = new System.Drawing.Size(13, 13);
            this.lblZoomFactor.TabIndex = 22;
            this.lblZoomFactor.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Zoom Factor";
            // 
            // zoomFactor
            // 
            this.zoomFactor.AutoSize = false;
            this.zoomFactor.Location = new System.Drawing.Point(76, 291);
            this.zoomFactor.Maximum = 55;
            this.zoomFactor.Minimum = 5;
            this.zoomFactor.Name = "zoomFactor";
            this.zoomFactor.Size = new System.Drawing.Size(119, 21);
            this.zoomFactor.TabIndex = 13;
            this.zoomFactor.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoomFactor.Value = 5;
            this.zoomFactor.Scroll += new System.EventHandler(this.zoomFactor_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.barBlue);
            this.groupBox2.Controls.Add(this.barGreen);
            this.groupBox2.Controls.Add(this.barRed);
            this.groupBox2.Controls.Add(this.lblBlueValue);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblGreenValue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblRedValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pbColorRGB);
            this.groupBox2.Controls.Add(this.tbColor);
            this.groupBox2.Location = new System.Drawing.Point(19, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 319);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPicker)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomFactor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar barRed;
        private System.Windows.Forms.TrackBar barGreen;
        private System.Windows.Forms.TrackBar barBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbColorRGB;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerPicker;
        private System.Windows.Forms.PictureBox pbPicker;
        private System.Windows.Forms.PictureBox pbColorPicker;
        private System.Windows.Forms.TextBox tbColorPickerHex;
        private System.Windows.Forms.Button btnColorPickerCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar zoomFactor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblZoomFactor;
        private System.Windows.Forms.Label lblPressP;
    }
}

