namespace P3_3_1204013
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.rbMonitor = new System.Windows.Forms.RadioButton();
            this.rbKyeboard = new System.Windows.Forms.RadioButton();
            this.rbmouse = new System.Windows.Forms.RadioButton();
            this.rbPrinter = new System.Windows.Forms.RadioButton();
            this.rbscanner = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tsGambar = new System.Windows.Forms.ToolStrip();
            this.tsbmouse = new System.Windows.Forms.ToolStripButton();
            this.tsbmonitor = new System.Windows.Forms.ToolStripButton();
            this.tsbprinter = new System.Windows.Forms.ToolStripButton();
            this.tsbkeyboard = new System.Windows.Forms.ToolStripButton();
            this.tsbsacanner = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tslKetGambar = new System.Windows.Forms.StatusStrip();
            this.tulis = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.tsGambar.SuspendLayout();
            this.tslKetGambar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "pilih salah satu item berikutdan klik pada sesuai gambar!";
            // 
            // rbMonitor
            // 
            this.rbMonitor.AutoSize = true;
            this.rbMonitor.Location = new System.Drawing.Point(15, 23);
            this.rbMonitor.Name = "rbMonitor";
            this.rbMonitor.Size = new System.Drawing.Size(80, 22);
            this.rbMonitor.TabIndex = 1;
            this.rbMonitor.TabStop = true;
            this.rbMonitor.Text = "Monitor";
            this.rbMonitor.UseVisualStyleBackColor = true;
            // 
            // rbKyeboard
            // 
            this.rbKyeboard.AutoSize = true;
            this.rbKyeboard.Location = new System.Drawing.Point(15, 59);
            this.rbKyeboard.Name = "rbKyeboard";
            this.rbKyeboard.Size = new System.Drawing.Size(92, 22);
            this.rbKyeboard.TabIndex = 2;
            this.rbKyeboard.TabStop = true;
            this.rbKyeboard.Text = "Keyboard";
            this.rbKyeboard.UseVisualStyleBackColor = true;
            this.rbKyeboard.CheckedChanged += new System.EventHandler(this.rbKyeboard_CheckedChanged);
            // 
            // rbmouse
            // 
            this.rbmouse.AutoSize = true;
            this.rbmouse.Location = new System.Drawing.Point(15, 97);
            this.rbmouse.Name = "rbmouse";
            this.rbmouse.Size = new System.Drawing.Size(75, 22);
            this.rbmouse.TabIndex = 3;
            this.rbmouse.TabStop = true;
            this.rbmouse.Text = "Mouse";
            this.rbmouse.UseVisualStyleBackColor = true;
            this.rbmouse.CheckedChanged += new System.EventHandler(this.rbmouse_CheckedChanged);
            // 
            // rbPrinter
            // 
            this.rbPrinter.AutoSize = true;
            this.rbPrinter.Location = new System.Drawing.Point(15, 139);
            this.rbPrinter.Name = "rbPrinter";
            this.rbPrinter.Size = new System.Drawing.Size(72, 22);
            this.rbPrinter.TabIndex = 4;
            this.rbPrinter.TabStop = true;
            this.rbPrinter.Text = "Printer";
            this.rbPrinter.UseVisualStyleBackColor = true;
            // 
            // rbscanner
            // 
            this.rbscanner.AutoSize = true;
            this.rbscanner.Location = new System.Drawing.Point(15, 178);
            this.rbscanner.Name = "rbscanner";
            this.rbscanner.Size = new System.Drawing.Size(82, 22);
            this.rbscanner.TabIndex = 5;
            this.rbscanner.TabStop = true;
            this.rbscanner.Text = "scanner";
            this.rbscanner.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMonitor);
            this.groupBox1.Controls.Add(this.rbscanner);
            this.groupBox1.Controls.Add(this.rbKyeboard);
            this.groupBox1.Controls.Add(this.rbPrinter);
            this.groupBox1.Controls.Add(this.rbmouse);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nama gambar";
            // 
            // tsGambar
            // 
            this.tsGambar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsGambar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGambar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsGambar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbmouse,
            this.tsbmonitor,
            this.tsbprinter,
            this.tsbkeyboard,
            this.tsbsacanner});
            this.tsGambar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsGambar.Location = new System.Drawing.Point(281, 60);
            this.tsGambar.Name = "tsGambar";
            this.tsGambar.Size = new System.Drawing.Size(45, 237);
            this.tsGambar.TabIndex = 8;
            this.tsGambar.Text = "toolStrip2";
            // 
            // tsbmouse
            // 
            this.tsbmouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbmouse.Image = ((System.Drawing.Image)(resources.GetObject("tsbmouse.Image")));
            this.tsbmouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbmouse.Name = "tsbmouse";
            this.tsbmouse.Size = new System.Drawing.Size(43, 44);
            this.tsbmouse.Text = "mouse";
            this.tsbmouse.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsbmonitor
            // 
            this.tsbmonitor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbmonitor.Image = ((System.Drawing.Image)(resources.GetObject("tsbmonitor.Image")));
            this.tsbmonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbmonitor.Name = "tsbmonitor";
            this.tsbmonitor.Size = new System.Drawing.Size(43, 44);
            this.tsbmonitor.Text = "toolStripButton1";
            // 
            // tsbprinter
            // 
            this.tsbprinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbprinter.Image = ((System.Drawing.Image)(resources.GetObject("tsbprinter.Image")));
            this.tsbprinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbprinter.Name = "tsbprinter";
            this.tsbprinter.Size = new System.Drawing.Size(43, 44);
            this.tsbprinter.Text = "toolStripButton2";
            // 
            // tsbkeyboard
            // 
            this.tsbkeyboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbkeyboard.Image = ((System.Drawing.Image)(resources.GetObject("tsbkeyboard.Image")));
            this.tsbkeyboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbkeyboard.Name = "tsbkeyboard";
            this.tsbkeyboard.Size = new System.Drawing.Size(43, 44);
            this.tsbkeyboard.Text = "toolStripButton4";
            // 
            // tsbsacanner
            // 
            this.tsbsacanner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbsacanner.Image = ((System.Drawing.Image)(resources.GetObject("tsbsacanner.Image")));
            this.tsbsacanner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsacanner.Name = "tsbsacanner";
            this.tsbsacanner.Size = new System.Drawing.Size(43, 44);
            this.tsbsacanner.Text = "toolStripButton5";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 366);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // tslKetGambar
            // 
            this.tslKetGambar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslKetGambar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tslKetGambar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tulis});
            this.tslKetGambar.Location = new System.Drawing.Point(3, 342);
            this.tslKetGambar.Name = "tslKetGambar";
            this.tslKetGambar.Size = new System.Drawing.Size(474, 24);
            this.tslKetGambar.TabIndex = 10;
            // 
            // tulis
            // 
            this.tulis.Name = "tulis";
            this.tulis.Size = new System.Drawing.Size(0, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(477, 366);
            this.Controls.Add(this.tslKetGambar);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tsGambar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pecobaan1_1204013";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsGambar.ResumeLayout(false);
            this.tsGambar.PerformLayout();
            this.tslKetGambar.ResumeLayout(false);
            this.tslKetGambar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMonitor;
        private System.Windows.Forms.RadioButton rbKyeboard;
        private System.Windows.Forms.RadioButton rbmouse;
        private System.Windows.Forms.RadioButton rbPrinter;
        private System.Windows.Forms.RadioButton rbscanner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip tsGambar;
        private System.Windows.Forms.ToolStripButton tsbmouse;
        private System.Windows.Forms.ToolStripButton tsbmonitor;
        private System.Windows.Forms.ToolStripButton tsbprinter;
        private System.Windows.Forms.ToolStripButton tsbkeyboard;
        private System.Windows.Forms.ToolStripButton tsbsacanner;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip tslKetGambar;
        private System.Windows.Forms.ToolStripStatusLabel tulis;
    }
}

