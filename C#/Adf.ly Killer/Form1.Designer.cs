namespace Adf.ly_Killer
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddLink = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddWordlist = new System.Windows.Forms.ToolStripMenuItem();
            this.miClearList = new System.Windows.Forms.ToolStripMenuItem();
            this.miKill = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.odOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.FormTheme = new Theme.MephobiaTheme();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcOptions = new Theme.MephobiaTabcontrol();
            this.tpLink = new System.Windows.Forms.TabPage();
            this.gbResult = new Theme.MephobiaGroupBox();
            this.btnCopy = new Theme.MephobiaButton();
            this.txtResult = new Theme.MephobiaTextBox();
            this.gbEnterLink = new Theme.MephobiaGroupBox();
            this.btnKill = new Theme.MephobiaButton();
            this.txtEnterLink = new Theme.MephobiaTextBox();
            this.tpWordlist = new System.Windows.Forms.TabPage();
            this.mephobiaGroupBox1 = new Theme.MephobiaGroupBox();
            this.lvLinks = new System.Windows.Forms.ListView();
            this.chLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDecoded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.gbAbout = new Theme.MephobiaGroupBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.pcAbout = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnExit = new Theme.MephobiaButton();
            this.cmsOptions.SuspendLayout();
            this.FormTheme.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.tcOptions.SuspendLayout();
            this.tpLink.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbEnterLink.SuspendLayout();
            this.tpWordlist.SuspendLayout();
            this.mephobiaGroupBox1.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miClearList,
            this.miKill,
            this.miCopy});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(123, 92);
            // 
            // miAdd
            // 
            this.miAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddLink,
            this.miAddWordlist});
            this.miAdd.Name = "miAdd";
            this.miAdd.Size = new System.Drawing.Size(122, 22);
            this.miAdd.Text = "Add";
            // 
            // miAddLink
            // 
            this.miAddLink.Name = "miAddLink";
            this.miAddLink.Size = new System.Drawing.Size(118, 22);
            this.miAddLink.Text = "Link";
            this.miAddLink.Click += new System.EventHandler(this.miAddLink_Click);
            // 
            // miAddWordlist
            // 
            this.miAddWordlist.Name = "miAddWordlist";
            this.miAddWordlist.Size = new System.Drawing.Size(118, 22);
            this.miAddWordlist.Text = "Wordlist";
            this.miAddWordlist.Click += new System.EventHandler(this.miAddWordlist_Click);
            // 
            // miClearList
            // 
            this.miClearList.Name = "miClearList";
            this.miClearList.Size = new System.Drawing.Size(122, 22);
            this.miClearList.Text = "Clear List";
            this.miClearList.Click += new System.EventHandler(this.miClearList_Click);
            // 
            // miKill
            // 
            this.miKill.Name = "miKill";
            this.miKill.Size = new System.Drawing.Size(122, 22);
            this.miKill.Text = "Kill";
            this.miKill.Click += new System.EventHandler(this.miKill_Click);
            // 
            // miCopy
            // 
            this.miCopy.Name = "miCopy";
            this.miCopy.Size = new System.Drawing.Size(122, 22);
            this.miCopy.Text = "Copy";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // odOpenFile
            // 
            this.odOpenFile.FileName = "openFileDialog1";
            // 
            // FormTheme
            // 
            this.FormTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FormTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.FormTheme.Controls.Add(this.ssStatus);
            this.FormTheme.Controls.Add(this.tcOptions);
            this.FormTheme.Controls.Add(this.imgLogo);
            this.FormTheme.Controls.Add(this.btnExit);
            this.FormTheme.Customization = "Pz8//xQUFP+qqqr/IBq0/wAAAP8=";
            this.FormTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormTheme.Image = null;
            this.FormTheme.Location = new System.Drawing.Point(0, 0);
            this.FormTheme.Movable = true;
            this.FormTheme.Name = "FormTheme";
            this.FormTheme.NoRounding = false;
            this.FormTheme.ShowIcon = false;
            this.FormTheme.Sizable = true;
            this.FormTheme.Size = new System.Drawing.Size(554, 434);
            this.FormTheme.SmartBounds = true;
            this.FormTheme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.FormTheme.TabIndex = 0;
            this.FormTheme.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormTheme.Transparent = false;
            // 
            // ssStatus
            // 
            this.ssStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.ssStatus.Location = new System.Drawing.Point(0, 412);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(554, 22);
            this.ssStatus.TabIndex = 3;
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(107, 17);
            this.status.Text = "[+] Program Ready";
            // 
            // tcOptions
            // 
            this.tcOptions.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcOptions.Controls.Add(this.tpLink);
            this.tcOptions.Controls.Add(this.tpWordlist);
            this.tcOptions.Controls.Add(this.tpAbout);
            this.tcOptions.ItemSize = new System.Drawing.Size(44, 136);
            this.tcOptions.Location = new System.Drawing.Point(12, 146);
            this.tcOptions.Multiline = true;
            this.tcOptions.Name = "tcOptions";
            this.tcOptions.SelectedIndex = 0;
            this.tcOptions.Size = new System.Drawing.Size(530, 222);
            this.tcOptions.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOptions.TabIndex = 2;
            // 
            // tpLink
            // 
            this.tpLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tpLink.Controls.Add(this.gbResult);
            this.tpLink.Controls.Add(this.gbEnterLink);
            this.tpLink.Location = new System.Drawing.Point(140, 4);
            this.tpLink.Name = "tpLink";
            this.tpLink.Padding = new System.Windows.Forms.Padding(3);
            this.tpLink.Size = new System.Drawing.Size(386, 214);
            this.tpLink.TabIndex = 0;
            this.tpLink.Text = "Link";
            // 
            // gbResult
            // 
            this.gbResult.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.gbResult.Controls.Add(this.btnCopy);
            this.gbResult.Controls.Add(this.txtResult);
            this.gbResult.Customization = "KCgo/xQUFP+qqqr/AAAA/w==";
            this.gbResult.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbResult.Image = null;
            this.gbResult.Location = new System.Drawing.Point(16, 96);
            this.gbResult.Movable = true;
            this.gbResult.Name = "gbResult";
            this.gbResult.NoRounding = false;
            this.gbResult.Sizable = true;
            this.gbResult.Size = new System.Drawing.Size(353, 77);
            this.gbResult.SmartBounds = true;
            this.gbResult.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.gbResult.TabIndex = 1;
            this.gbResult.Text = "Result";
            this.gbResult.TransparencyKey = System.Drawing.Color.Empty;
            this.gbResult.Transparent = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Customization = "KCgo/xQUFP+qqqr/";
            this.btnCopy.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnCopy.Image = null;
            this.btnCopy.Location = new System.Drawing.Point(291, 35);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.NoRounding = false;
            this.btnCopy.Size = new System.Drawing.Size(48, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Transparent = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtResult
            // 
            this.txtResult.Customization = "qqqq/xYWFv8AAAD/";
            this.txtResult.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtResult.Image = null;
            this.txtResult.Location = new System.Drawing.Point(12, 35);
            this.txtResult.MaxLength = 32767;
            this.txtResult.Multiline = false;
            this.txtResult.Name = "txtResult";
            this.txtResult.NoRounding = false;
            this.txtResult.PasswordChar = "\0";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(273, 24);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtResult.Transparent = false;
            this.txtResult.UseSystemPasswordChar = false;
            // 
            // gbEnterLink
            // 
            this.gbEnterLink.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.gbEnterLink.Controls.Add(this.btnKill);
            this.gbEnterLink.Controls.Add(this.txtEnterLink);
            this.gbEnterLink.Customization = "KCgo/xQUFP+qqqr/AAAA/w==";
            this.gbEnterLink.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbEnterLink.Image = null;
            this.gbEnterLink.Location = new System.Drawing.Point(16, 16);
            this.gbEnterLink.Movable = true;
            this.gbEnterLink.Name = "gbEnterLink";
            this.gbEnterLink.NoRounding = false;
            this.gbEnterLink.Sizable = true;
            this.gbEnterLink.Size = new System.Drawing.Size(353, 74);
            this.gbEnterLink.SmartBounds = true;
            this.gbEnterLink.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.gbEnterLink.TabIndex = 0;
            this.gbEnterLink.Text = "Enter Link";
            this.gbEnterLink.TransparencyKey = System.Drawing.Color.Empty;
            this.gbEnterLink.Transparent = false;
            // 
            // btnKill
            // 
            this.btnKill.Customization = "KCgo/xQUFP+qqqr/";
            this.btnKill.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnKill.Image = null;
            this.btnKill.Location = new System.Drawing.Point(289, 34);
            this.btnKill.Name = "btnKill";
            this.btnKill.NoRounding = false;
            this.btnKill.Size = new System.Drawing.Size(50, 23);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "Kill";
            this.btnKill.Transparent = false;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // txtEnterLink
            // 
            this.txtEnterLink.Customization = "qqqq/xYWFv8AAAD/";
            this.txtEnterLink.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtEnterLink.Image = null;
            this.txtEnterLink.Location = new System.Drawing.Point(12, 34);
            this.txtEnterLink.MaxLength = 32767;
            this.txtEnterLink.Multiline = false;
            this.txtEnterLink.Name = "txtEnterLink";
            this.txtEnterLink.NoRounding = false;
            this.txtEnterLink.PasswordChar = "\0";
            this.txtEnterLink.ReadOnly = false;
            this.txtEnterLink.Size = new System.Drawing.Size(273, 24);
            this.txtEnterLink.TabIndex = 0;
            this.txtEnterLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEnterLink.Transparent = false;
            this.txtEnterLink.UseSystemPasswordChar = false;
            // 
            // tpWordlist
            // 
            this.tpWordlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tpWordlist.Controls.Add(this.mephobiaGroupBox1);
            this.tpWordlist.Location = new System.Drawing.Point(140, 4);
            this.tpWordlist.Name = "tpWordlist";
            this.tpWordlist.Padding = new System.Windows.Forms.Padding(3);
            this.tpWordlist.Size = new System.Drawing.Size(386, 214);
            this.tpWordlist.TabIndex = 1;
            this.tpWordlist.Text = "Wordlist";
            // 
            // mephobiaGroupBox1
            // 
            this.mephobiaGroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.mephobiaGroupBox1.Controls.Add(this.lvLinks);
            this.mephobiaGroupBox1.Customization = "KCgo/xQUFP+qqqr/AAAA/w==";
            this.mephobiaGroupBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.mephobiaGroupBox1.Image = null;
            this.mephobiaGroupBox1.Location = new System.Drawing.Point(15, 16);
            this.mephobiaGroupBox1.Movable = true;
            this.mephobiaGroupBox1.Name = "mephobiaGroupBox1";
            this.mephobiaGroupBox1.NoRounding = false;
            this.mephobiaGroupBox1.Sizable = true;
            this.mephobiaGroupBox1.Size = new System.Drawing.Size(353, 183);
            this.mephobiaGroupBox1.SmartBounds = true;
            this.mephobiaGroupBox1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.mephobiaGroupBox1.TabIndex = 0;
            this.mephobiaGroupBox1.Text = "Links";
            this.mephobiaGroupBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.mephobiaGroupBox1.Transparent = false;
            // 
            // lvLinks
            // 
            this.lvLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lvLinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLink,
            this.chDecoded});
            this.lvLinks.ContextMenuStrip = this.cmsOptions;
            this.lvLinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lvLinks.FullRowSelect = true;
            this.lvLinks.Location = new System.Drawing.Point(17, 40);
            this.lvLinks.Name = "lvLinks";
            this.lvLinks.Size = new System.Drawing.Size(321, 129);
            this.lvLinks.TabIndex = 0;
            this.lvLinks.UseCompatibleStateImageBehavior = false;
            this.lvLinks.View = System.Windows.Forms.View.Details;
            // 
            // chLink
            // 
            this.chLink.Text = "Link";
            this.chLink.Width = 160;
            // 
            // chDecoded
            // 
            this.chDecoded.Text = "Decoded";
            this.chDecoded.Width = 157;
            // 
            // tpAbout
            // 
            this.tpAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tpAbout.Controls.Add(this.gbAbout);
            this.tpAbout.Location = new System.Drawing.Point(140, 4);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(386, 214);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            // 
            // gbAbout
            // 
            this.gbAbout.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.gbAbout.Controls.Add(this.lblCopyRight);
            this.gbAbout.Controls.Add(this.pcAbout);
            this.gbAbout.Customization = "KCgo/xQUFP+qqqr/AAAA/w==";
            this.gbAbout.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbAbout.Image = null;
            this.gbAbout.Location = new System.Drawing.Point(16, 12);
            this.gbAbout.Movable = true;
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.NoRounding = false;
            this.gbAbout.Sizable = true;
            this.gbAbout.Size = new System.Drawing.Size(348, 182);
            this.gbAbout.SmartBounds = true;
            this.gbAbout.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.gbAbout.TabIndex = 0;
            this.gbAbout.Text = "About";
            this.gbAbout.TransparencyKey = System.Drawing.Color.Empty;
            this.gbAbout.Transparent = false;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblCopyRight.Location = new System.Drawing.Point(151, 65);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(172, 65);
            this.lblCopyRight.TabIndex = 1;
            this.lblCopyRight.Text = "This program was coded By\r\nDoddy Hackman in the year\r\n2016.\r\n\r\nCredits : Thanks t" +
    "o fudmario";
            // 
            // pcAbout
            // 
            this.pcAbout.Image = ((System.Drawing.Image)(resources.GetObject("pcAbout.Image")));
            this.pcAbout.Location = new System.Drawing.Point(15, 44);
            this.pcAbout.Name = "pcAbout";
            this.pcAbout.Size = new System.Drawing.Size(119, 119);
            this.pcAbout.TabIndex = 0;
            this.pcAbout.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 32);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(556, 108);
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Customization = "KCgo/xQUFP+qqqr/";
            this.btnExit.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnExit.Image = null;
            this.btnExit.Location = new System.Drawing.Point(505, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.NoRounding = false;
            this.btnExit.Size = new System.Drawing.Size(37, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.Transparent = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 434);
            this.Controls.Add(this.FormTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = "Adf.ly Killer 0.5 (C) Doddy Hackman 2016";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.cmsOptions.ResumeLayout(false);
            this.FormTheme.ResumeLayout(false);
            this.FormTheme.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.tcOptions.ResumeLayout(false);
            this.tpLink.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbEnterLink.ResumeLayout(false);
            this.tpWordlist.ResumeLayout(false);
            this.mephobiaGroupBox1.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Theme.MephobiaTheme FormTheme;
        private Theme.MephobiaButton btnExit;
        private System.Windows.Forms.PictureBox imgLogo;
        private Theme.MephobiaTabcontrol tcOptions;
        private System.Windows.Forms.TabPage tpLink;
        private System.Windows.Forms.TabPage tpWordlist;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private Theme.MephobiaGroupBox gbEnterLink;
        private Theme.MephobiaGroupBox gbResult;
        private Theme.MephobiaTextBox txtResult;
        private Theme.MephobiaTextBox txtEnterLink;
        private Theme.MephobiaButton btnKill;
        private Theme.MephobiaButton btnCopy;
        private Theme.MephobiaGroupBox mephobiaGroupBox1;
        private System.Windows.Forms.ListView lvLinks;
        private System.Windows.Forms.ColumnHeader chLink;
        private System.Windows.Forms.ColumnHeader chDecoded;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miAddLink;
        private System.Windows.Forms.ToolStripMenuItem miAddWordlist;
        private System.Windows.Forms.ToolStripMenuItem miKill;
        private System.Windows.Forms.ToolStripMenuItem miClearList;
        private Theme.MephobiaGroupBox gbAbout;
        private System.Windows.Forms.ToolStripMenuItem miCopy;
        private System.Windows.Forms.OpenFileDialog odOpenFile;
        private System.Windows.Forms.PictureBox pcAbout;
        private System.Windows.Forms.Label lblCopyRight;
    }
}

