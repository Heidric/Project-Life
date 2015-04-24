namespace Project_Life
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRandomPlacement = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnRunAndStop = new System.Windows.Forms.Button();
            this.lbCoordinates = new System.Windows.Forms.Label();
            this.lbCurrentX = new System.Windows.Forms.Label();
            this.lbCurrentY = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.endlessCycleTimer = new System.Windows.Forms.Timer(this.components);
            this.pField = new Project_Life.DoubleBufferedPanel();
            this.controlsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(145, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveAsImageToolStripMenuItem.Text = "Save as image";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnRandomPlacement
            // 
            this.btnRandomPlacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomPlacement.Location = new System.Drawing.Point(646, 376);
            this.btnRandomPlacement.Name = "btnRandomPlacement";
            this.btnRandomPlacement.Size = new System.Drawing.Size(87, 29);
            this.btnRandomPlacement.TabIndex = 2;
            this.btnRandomPlacement.Text = "Random";
            this.btnRandomPlacement.UseVisualStyleBackColor = true;
            this.btnRandomPlacement.Click += new System.EventHandler(this.btnRandomPlacement_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(646, 411);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear the field";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextStep.Location = new System.Drawing.Point(646, 111);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(87, 29);
            this.btnNextStep.TabIndex = 5;
            this.btnNextStep.Text = "Next step";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnRunAndStop
            // 
            this.btnRunAndStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAndStop.Location = new System.Drawing.Point(646, 76);
            this.btnRunAndStop.Name = "btnRunAndStop";
            this.btnRunAndStop.Size = new System.Drawing.Size(87, 29);
            this.btnRunAndStop.TabIndex = 6;
            this.btnRunAndStop.Text = "Run";
            this.btnRunAndStop.UseVisualStyleBackColor = true;
            this.btnRunAndStop.Click += new System.EventHandler(this.btnRunAndStop_Click);
            // 
            // lbCoordinates
            // 
            this.lbCoordinates.AutoSize = true;
            this.lbCoordinates.Location = new System.Drawing.Point(643, 207);
            this.lbCoordinates.Name = "lbCoordinates";
            this.lbCoordinates.Size = new System.Drawing.Size(31, 13);
            this.lbCoordinates.TabIndex = 7;
            this.lbCoordinates.Text = "(0, 0)";
            // 
            // lbCurrentX
            // 
            this.lbCurrentX.AutoSize = true;
            this.lbCurrentX.Location = new System.Drawing.Point(643, 262);
            this.lbCurrentX.Name = "lbCurrentX";
            this.lbCurrentX.Size = new System.Drawing.Size(14, 13);
            this.lbCurrentX.TabIndex = 8;
            this.lbCurrentX.Text = "X";
            // 
            // lbCurrentY
            // 
            this.lbCurrentY.AutoSize = true;
            this.lbCurrentY.Location = new System.Drawing.Point(643, 275);
            this.lbCurrentY.Name = "lbCurrentY";
            this.lbCurrentY.Size = new System.Drawing.Size(14, 13);
            this.lbCurrentY.TabIndex = 9;
            this.lbCurrentY.Text = "Y";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(646, 41);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 29);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // endlessCycleTimer
            // 
            this.endlessCycleTimer.Interval = 500;
            this.endlessCycleTimer.Tick += new System.EventHandler(this.endlessCycleTimer_Tick);
            // 
            // pField
            // 
            this.pField.BackColor = System.Drawing.Color.White;
            this.pField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pField.Location = new System.Drawing.Point(12, 41);
            this.pField.Name = "pField";
            this.pField.Size = new System.Drawing.Size(603, 399);
            this.pField.TabIndex = 0;
            this.pField.Paint += new System.Windows.Forms.PaintEventHandler(this.pField_Paint);
            this.pField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pField_MouseDown);
            this.pField.MouseHover += new System.EventHandler(this.pField_MouseHover);
            this.pField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pField_MouseMove);
            this.pField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pField_MouseUp);
            // 
            // controlsTooltip
            // 
            this.controlsTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.controlsTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.controlsTooltip_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(758, 453);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lbCurrentY);
            this.Controls.Add(this.lbCurrentX);
            this.Controls.Add(this.lbCoordinates);
            this.Controls.Add(this.btnRunAndStop);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRandomPlacement);
            this.Controls.Add(this.pField);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnRandomPlacement;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnRunAndStop;
        private System.Windows.Forms.Label lbCoordinates;
        private System.Windows.Forms.Label lbCurrentX;
        private System.Windows.Forms.Label lbCurrentY;
        private DoubleBufferedPanel pField;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer endlessCycleTimer;
        private System.Windows.Forms.ToolTip controlsTooltip;
    }
}

