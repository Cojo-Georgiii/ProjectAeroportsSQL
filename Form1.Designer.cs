namespace SQLProjectAeroport
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afisareZboruriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creareTraseuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anulareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergetiCursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisarePasageriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareSiProgramareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anulareProgramareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProgramareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareZboruriToolStripMenuItem,
            this.creareTraseuToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.afisarePasageriToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // afisareZboruriToolStripMenuItem
            // 
            this.afisareZboruriToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.afisareZboruriToolStripMenuItem.Name = "afisareZboruriToolStripMenuItem";
            this.afisareZboruriToolStripMenuItem.Size = new System.Drawing.Size(149, 33);
            this.afisareZboruriToolStripMenuItem.Text = "Afisare Zboruri";
            this.afisareZboruriToolStripMenuItem.Click += new System.EventHandler(this.afisareZboruriToolStripMenuItem_Click);
            // 
            // creareTraseuToolStripMenuItem
            // 
            this.creareTraseuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anulareToolStripMenuItem,
            this.stergetiCursaToolStripMenuItem,
            this.updateCursaToolStripMenuItem});
            this.creareTraseuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.creareTraseuToolStripMenuItem.Name = "creareTraseuToolStripMenuItem";
            this.creareTraseuToolStripMenuItem.Size = new System.Drawing.Size(123, 33);
            this.creareTraseuToolStripMenuItem.Text = "Creare Ruta";
            this.creareTraseuToolStripMenuItem.Click += new System.EventHandler(this.creareTraseuToolStripMenuItem_Click);
            // 
            // anulareToolStripMenuItem
            // 
            this.anulareToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anulareToolStripMenuItem.BackgroundImage")));
            this.anulareToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.anulareToolStripMenuItem.Name = "anulareToolStripMenuItem";
            this.anulareToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.anulareToolStripMenuItem.Text = "Creati Cursa";
            this.anulareToolStripMenuItem.Click += new System.EventHandler(this.anulareToolStripMenuItem_Click);
            // 
            // stergetiCursaToolStripMenuItem
            // 
            this.stergetiCursaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.stergetiCursaToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stergetiCursaToolStripMenuItem.BackgroundImage")));
            this.stergetiCursaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.stergetiCursaToolStripMenuItem.Name = "stergetiCursaToolStripMenuItem";
            this.stergetiCursaToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.stergetiCursaToolStripMenuItem.Text = "Anulare Cursa";
            this.stergetiCursaToolStripMenuItem.Click += new System.EventHandler(this.stergetiCursaToolStripMenuItem_Click);
            // 
            // updateCursaToolStripMenuItem
            // 
            this.updateCursaToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateCursaToolStripMenuItem.BackgroundImage")));
            this.updateCursaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.updateCursaToolStripMenuItem.Name = "updateCursaToolStripMenuItem";
            this.updateCursaToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.updateCursaToolStripMenuItem.Text = "Update Cursa";
            this.updateCursaToolStripMenuItem.Click += new System.EventHandler(this.updateCursaToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(64, 33);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // afisarePasageriToolStripMenuItem
            // 
            this.afisarePasageriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareSiProgramareToolStripMenuItem,
            this.anulareProgramareToolStripMenuItem,
            this.updateProgramareToolStripMenuItem});
            this.afisarePasageriToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.afisarePasageriToolStripMenuItem.Name = "afisarePasageriToolStripMenuItem";
            this.afisarePasageriToolStripMenuItem.Size = new System.Drawing.Size(274, 33);
            this.afisarePasageriToolStripMenuItem.Text = "Afisare si Programare Pasageri";
            this.afisarePasageriToolStripMenuItem.Click += new System.EventHandler(this.afisarePasageriToolStripMenuItem_Click);
            // 
            // afisareSiProgramareToolStripMenuItem
            // 
            this.afisareSiProgramareToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("afisareSiProgramareToolStripMenuItem.BackgroundImage")));
            this.afisareSiProgramareToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.afisareSiProgramareToolStripMenuItem.Name = "afisareSiProgramareToolStripMenuItem";
            this.afisareSiProgramareToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.afisareSiProgramareToolStripMenuItem.Text = "Afisare si Programare";
            this.afisareSiProgramareToolStripMenuItem.Click += new System.EventHandler(this.afisareSiProgramareToolStripMenuItem_Click);
            // 
            // anulareProgramareToolStripMenuItem
            // 
            this.anulareProgramareToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anulareProgramareToolStripMenuItem.BackgroundImage")));
            this.anulareProgramareToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.anulareProgramareToolStripMenuItem.Name = "anulareProgramareToolStripMenuItem";
            this.anulareProgramareToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.anulareProgramareToolStripMenuItem.Text = "Anulare Programare";
            this.anulareProgramareToolStripMenuItem.Click += new System.EventHandler(this.anulareProgramareToolStripMenuItem_Click);
            // 
            // updateProgramareToolStripMenuItem
            // 
            this.updateProgramareToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateProgramareToolStripMenuItem.BackgroundImage")));
            this.updateProgramareToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.updateProgramareToolStripMenuItem.Name = "updateProgramareToolStripMenuItem";
            this.updateProgramareToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.updateProgramareToolStripMenuItem.Text = "Update Programare";
            this.updateProgramareToolStripMenuItem.Click += new System.EventHandler(this.updateProgramareToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(24, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afisareZboruriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creareTraseuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem afisarePasageriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anulareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergetiCursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareSiProgramareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anulareProgramareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProgramareToolStripMenuItem;
    }
}