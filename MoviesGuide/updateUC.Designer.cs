namespace MoviesGuide
{
    partial class updateUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateUC));
            this.moviesdgv = new System.Windows.Forms.DataGridView();
            this.imagetxt = new System.Windows.Forms.TextBox();
            this.posteraddbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.namelbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.movienametxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.yeartxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.directornametxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ratingtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.updatemoviebtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.movieidtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.filenametxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.showbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.generestxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.genereschecklist = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviesdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesdgv
            // 
            this.moviesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesdgv.Location = new System.Drawing.Point(5, 51);
            this.moviesdgv.Name = "moviesdgv";
            this.moviesdgv.Size = new System.Drawing.Size(617, 237);
            this.moviesdgv.TabIndex = 0;
            this.moviesdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesdgv_CellClick);
            // 
            // imagetxt
            // 
            this.imagetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imagetxt.Enabled = false;
            this.imagetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagetxt.Location = new System.Drawing.Point(154, 308);
            this.imagetxt.Name = "imagetxt";
            this.imagetxt.Size = new System.Drawing.Size(308, 28);
            this.imagetxt.TabIndex = 10;
            // 
            // posteraddbtn
            // 
            this.posteraddbtn.ActiveBorderThickness = 1;
            this.posteraddbtn.ActiveCornerRadius = 1;
            this.posteraddbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.posteraddbtn.ActiveForecolor = System.Drawing.Color.White;
            this.posteraddbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.posteraddbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.posteraddbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("posteraddbtn.BackgroundImage")));
            this.posteraddbtn.ButtonText = "Add Poster";
            this.posteraddbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.posteraddbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posteraddbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.posteraddbtn.IdleBorderThickness = 1;
            this.posteraddbtn.IdleCornerRadius = 40;
            this.posteraddbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.posteraddbtn.IdleForecolor = System.Drawing.Color.White;
            this.posteraddbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.posteraddbtn.Location = new System.Drawing.Point(9, 300);
            this.posteraddbtn.Margin = new System.Windows.Forms.Padding(5);
            this.posteraddbtn.Name = "posteraddbtn";
            this.posteraddbtn.Size = new System.Drawing.Size(129, 46);
            this.posteraddbtn.TabIndex = 9;
            this.posteraddbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.posteraddbtn.Click += new System.EventHandler(this.posteraddbtn_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.DarkGray;
            this.namelbl.Location = new System.Drawing.Point(14, 353);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(110, 21);
            this.namelbl.TabIndex = 24;
            this.namelbl.Text = "Movie Name";
            // 
            // movienametxt
            // 
            this.movienametxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.movienametxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.movienametxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.movienametxt.BorderThickness = 2;
            this.movienametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.movienametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.movienametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.movienametxt.isPassword = false;
            this.movienametxt.Location = new System.Drawing.Point(10, 378);
            this.movienametxt.Margin = new System.Windows.Forms.Padding(4);
            this.movienametxt.Name = "movienametxt";
            this.movienametxt.Size = new System.Drawing.Size(248, 33);
            this.movienametxt.TabIndex = 23;
            this.movienametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(14, 422);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(99, 21);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "Movie Year";
            // 
            // yeartxt
            // 
            this.yeartxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.yeartxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yeartxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.yeartxt.BorderThickness = 2;
            this.yeartxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yeartxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.yeartxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.yeartxt.isPassword = false;
            this.yeartxt.Location = new System.Drawing.Point(10, 447);
            this.yeartxt.Margin = new System.Windows.Forms.Padding(4);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(154, 33);
            this.yeartxt.TabIndex = 29;
            this.yeartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(278, 353);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(133, 21);
            this.bunifuCustomLabel1.TabIndex = 28;
            this.bunifuCustomLabel1.Text = "Director\'s Name";
            // 
            // directornametxt
            // 
            this.directornametxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.directornametxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.directornametxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.directornametxt.BorderThickness = 2;
            this.directornametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.directornametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.directornametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.directornametxt.isPassword = false;
            this.directornametxt.Location = new System.Drawing.Point(274, 378);
            this.directornametxt.Margin = new System.Windows.Forms.Padding(4);
            this.directornametxt.Name = "directornametxt";
            this.directornametxt.Size = new System.Drawing.Size(223, 34);
            this.directornametxt.TabIndex = 27;
            this.directornametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(328, 422);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(114, 21);
            this.bunifuCustomLabel4.TabIndex = 34;
            this.bunifuCustomLabel4.Text = "Movie Rating";
            // 
            // ratingtxt
            // 
            this.ratingtxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.ratingtxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ratingtxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.ratingtxt.BorderThickness = 2;
            this.ratingtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ratingtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ratingtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.ratingtxt.isPassword = false;
            this.ratingtxt.Location = new System.Drawing.Point(324, 447);
            this.ratingtxt.Margin = new System.Windows.Forms.Padding(4);
            this.ratingtxt.Name = "ratingtxt";
            this.ratingtxt.Size = new System.Drawing.Size(173, 33);
            this.ratingtxt.TabIndex = 33;
            this.ratingtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(175, 423);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(117, 21);
            this.bunifuCustomLabel3.TabIndex = 32;
            this.bunifuCustomLabel3.Text = "Movie Genres";
            // 
            // updatemoviebtn
            // 
            this.updatemoviebtn.ActiveBorderThickness = 1;
            this.updatemoviebtn.ActiveCornerRadius = 1;
            this.updatemoviebtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.updatemoviebtn.ActiveForecolor = System.Drawing.Color.White;
            this.updatemoviebtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.updatemoviebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.updatemoviebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatemoviebtn.BackgroundImage")));
            this.updatemoviebtn.ButtonText = "Update Movie";
            this.updatemoviebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatemoviebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatemoviebtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.updatemoviebtn.IdleBorderThickness = 1;
            this.updatemoviebtn.IdleCornerRadius = 40;
            this.updatemoviebtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.updatemoviebtn.IdleForecolor = System.Drawing.Color.White;
            this.updatemoviebtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.updatemoviebtn.Location = new System.Drawing.Point(506, 378);
            this.updatemoviebtn.Margin = new System.Windows.Forms.Padding(5);
            this.updatemoviebtn.Name = "updatemoviebtn";
            this.updatemoviebtn.Size = new System.Drawing.Size(116, 79);
            this.updatemoviebtn.TabIndex = 35;
            this.updatemoviebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatemoviebtn.Click += new System.EventHandler(this.updatemoviebtn_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(583, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 36;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(472, 315);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(27, 21);
            this.bunifuCustomLabel5.TabIndex = 38;
            this.bunifuCustomLabel5.Text = "ID";
            // 
            // movieidtxt
            // 
            this.movieidtxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.movieidtxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.movieidtxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.movieidtxt.BorderThickness = 2;
            this.movieidtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.movieidtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.movieidtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.movieidtxt.isPassword = false;
            this.movieidtxt.Location = new System.Drawing.Point(506, 312);
            this.movieidtxt.Margin = new System.Windows.Forms.Padding(4);
            this.movieidtxt.Name = "movieidtxt";
            this.movieidtxt.Size = new System.Drawing.Size(100, 34);
            this.movieidtxt.TabIndex = 37;
            this.movieidtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(202, 144);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(86, 21);
            this.bunifuCustomLabel6.TabIndex = 40;
            this.bunifuCustomLabel6.Text = "File Name";
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
            this.filenametxt.Location = new System.Drawing.Point(198, 169);
            this.filenametxt.Margin = new System.Windows.Forms.Padding(4);
            this.filenametxt.Name = "filenametxt";
            this.filenametxt.Size = new System.Drawing.Size(248, 33);
            this.filenametxt.TabIndex = 39;
            this.filenametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.showbtn.Location = new System.Drawing.Point(244, 211);
            this.showbtn.Margin = new System.Windows.Forms.Padding(5);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(129, 46);
            this.showbtn.TabIndex = 41;
            this.showbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(232, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Enter a correct file name";
            // 
            // generestxt
            // 
            this.generestxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.generestxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generestxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.generestxt.BorderThickness = 2;
            this.generestxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.generestxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.generestxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(137)))));
            this.generestxt.isPassword = false;
            this.generestxt.Location = new System.Drawing.Point(167, 447);
            this.generestxt.Margin = new System.Windows.Forms.Padding(4);
            this.generestxt.Name = "generestxt";
            this.generestxt.Size = new System.Drawing.Size(154, 33);
            this.generestxt.TabIndex = 43;
            this.generestxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // genereschecklist
            // 
            this.genereschecklist.FormattingEnabled = true;
            this.genereschecklist.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Comedy",
            "Crime",
            "Drama",
            "Fantasy",
            "Historical",
            "Horror",
            "Romance",
            "Animation"});
            this.genereschecklist.Location = new System.Drawing.Point(192, 487);
            this.genereschecklist.Name = "genereschecklist";
            this.genereschecklist.Size = new System.Drawing.Size(100, 34);
            this.genereschecklist.TabIndex = 44;
            // 
            // updateUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.genereschecklist);
            this.Controls.Add(this.generestxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.filenametxt);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.movieidtxt);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.updatemoviebtn);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.ratingtxt);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.directornametxt);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.movienametxt);
            this.Controls.Add(this.imagetxt);
            this.Controls.Add(this.posteraddbtn);
            this.Controls.Add(this.moviesdgv);
            this.Name = "updateUC";
            this.Size = new System.Drawing.Size(627, 532);
            this.Load += new System.EventHandler(this.updateUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView moviesdgv;
        private System.Windows.Forms.TextBox imagetxt;
        private Bunifu.Framework.UI.BunifuThinButton2 posteraddbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel namelbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox movienametxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox yeartxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox directornametxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox ratingtxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 updatemoviebtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox movieidtxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox filenametxt;
        private Bunifu.Framework.UI.BunifuThinButton2 showbtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox generestxt;
        private System.Windows.Forms.CheckedListBox genereschecklist;
    }
}
