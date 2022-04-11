namespace MoviesGuide
{
    partial class removeUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(removeUC));
            this.label1 = new System.Windows.Forms.Label();
            this.showbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.filenametxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.removebtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.moviesdgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(207, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Enter a correct file name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // showbtn
            // 
            this.showbtn.ActiveBorderThickness = 1;
            this.showbtn.ActiveCornerRadius = 1;
            this.showbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.showbtn.ActiveForecolor = System.Drawing.Color.White;
            this.showbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.showbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.showbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showbtn.BackgroundImage")));
            this.showbtn.ButtonText = "Show";
            this.showbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.showbtn.IdleBorderThickness = 1;
            this.showbtn.IdleCornerRadius = 40;
            this.showbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.showbtn.IdleForecolor = System.Drawing.Color.White;
            this.showbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.showbtn.Location = new System.Drawing.Point(219, 286);
            this.showbtn.Margin = new System.Windows.Forms.Padding(5);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(129, 46);
            this.showbtn.TabIndex = 52;
            this.showbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click_1);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(177, 219);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(86, 21);
            this.bunifuCustomLabel6.TabIndex = 51;
            this.bunifuCustomLabel6.Text = "File Name";
            this.bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
            // 
            // filenametxt
            // 
            this.filenametxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.filenametxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filenametxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.filenametxt.BorderThickness = 2;
            this.filenametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filenametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.filenametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.filenametxt.isPassword = false;
            this.filenametxt.Location = new System.Drawing.Point(173, 244);
            this.filenametxt.Margin = new System.Windows.Forms.Padding(4);
            this.filenametxt.Name = "filenametxt";
            this.filenametxt.Size = new System.Drawing.Size(248, 33);
            this.filenametxt.TabIndex = 50;
            this.filenametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.filenametxt.OnValueChanged += new System.EventHandler(this.filenametxt_OnValueChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(561, 38);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 49;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // removebtn
            // 
            this.removebtn.ActiveBorderThickness = 1;
            this.removebtn.ActiveCornerRadius = 1;
            this.removebtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.removebtn.ActiveForecolor = System.Drawing.Color.White;
            this.removebtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.removebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.removebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removebtn.BackgroundImage")));
            this.removebtn.ButtonText = "Remove Movie";
            this.removebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.removebtn.IdleBorderThickness = 1;
            this.removebtn.IdleCornerRadius = 40;
            this.removebtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.removebtn.IdleForecolor = System.Drawing.Color.White;
            this.removebtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.removebtn.Location = new System.Drawing.Point(52, 448);
            this.removebtn.Margin = new System.Windows.Forms.Padding(5);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(491, 46);
            this.removebtn.TabIndex = 48;
            this.removebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click_1);
            // 
            // moviesdgv
            // 
            this.moviesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesdgv.Location = new System.Drawing.Point(28, 94);
            this.moviesdgv.Name = "moviesdgv";
            this.moviesdgv.Size = new System.Drawing.Size(539, 316);
            this.moviesdgv.TabIndex = 47;
            this.moviesdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesdgv_CellContentClick_1);
            // 
            // removeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.filenametxt);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.moviesdgv);
            this.Name = "removeUC";
            this.Size = new System.Drawing.Size(627, 532);
            this.Load += new System.EventHandler(this.removeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 showbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox filenametxt;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 removebtn;
        private System.Windows.Forms.DataGridView moviesdgv;

    }
}
