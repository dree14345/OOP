namespace OOP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAngel = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtMode1 = new System.Windows.Forms.Label();
            this.AngelSearch = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.angelListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtMode = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.NumRate = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.personListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.l_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heart_rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TxtFirst = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtMiddle = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtLast = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumRate)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.TxtAngel);
            this.tabPage2.Controls.Add(this.TxtMode1);
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.ImageKey = "user.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1148, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Angel";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Angel\'s Name";
            // 
            // TxtAngel
            // 
            this.TxtAngel.AnimateReadOnly = false;
            this.TxtAngel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtAngel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtAngel.Depth = 0;
            this.TxtAngel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtAngel.HideSelection = true;
            this.TxtAngel.Hint = "Enter Angel\'s Name";
            this.TxtAngel.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("TxtAngel.LeadingIcon")));
            this.TxtAngel.Location = new System.Drawing.Point(32, 148);
            this.TxtAngel.MaxLength = 32767;
            this.TxtAngel.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtAngel.Name = "TxtAngel";
            this.TxtAngel.PasswordChar = '\0';
            this.TxtAngel.PrefixSuffixText = null;
            this.TxtAngel.ReadOnly = false;
            this.TxtAngel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtAngel.SelectedText = "";
            this.TxtAngel.SelectionLength = 0;
            this.TxtAngel.SelectionStart = 0;
            this.TxtAngel.ShortcutsEnabled = true;
            this.TxtAngel.Size = new System.Drawing.Size(391, 48);
            this.TxtAngel.TabIndex = 46;
            this.TxtAngel.TabStop = false;
            this.TxtAngel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtAngel.TrailingIcon = null;
            this.TxtAngel.UseSystemPasswordChar = false;
            // 
            // TxtMode1
            // 
            this.TxtMode1.AutoSize = true;
            this.TxtMode1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMode1.Location = new System.Drawing.Point(16, 28);
            this.TxtMode1.Name = "TxtMode1";
            this.TxtMode1.Size = new System.Drawing.Size(113, 22);
            this.TxtMode1.TabIndex = 44;
            this.TxtMode1.Text = "Adding Angel";
            // 
            // AngelSearch
            // 
            this.AngelSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AngelSearch.Location = new System.Drawing.Point(456, 30);
            this.AngelSearch.Name = "AngelSearch";
            this.AngelSearch.Size = new System.Drawing.Size(506, 29);
            this.AngelSearch.TabIndex = 43;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(840, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 47);
            this.button5.TabIndex = 45;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(456, 383);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 47);
            this.button6.TabIndex = 38;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(584, 383);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 47);
            this.button7.TabIndex = 41;
            this.button7.Text = "Edit";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(712, 383);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 47);
            this.button8.TabIndex = 40;
            this.button8.Text = "Delete Item";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // angelListView
            // 
            this.angelListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.angelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.angelListView.FullRowSelect = true;
            this.angelListView.GridLines = true;
            this.angelListView.HideSelection = false;
            this.angelListView.Location = new System.Drawing.Point(456, 74);
            this.angelListView.MultiSelect = false;
            this.angelListView.Name = "angelListView";
            this.angelListView.Size = new System.Drawing.Size(506, 303);
            this.angelListView.TabIndex = 39;
            this.angelListView.UseCompatibleStateImageBehavior = false;
            this.angelListView.View = System.Windows.Forms.View.Details;
            this.angelListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "#";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Angel Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 456;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.TxtMode);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ImageKey = "angel.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1148, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // TxtMode
            // 
            this.TxtMode.AutoSize = true;
            this.TxtMode.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMode.Location = new System.Drawing.Point(19, 17);
            this.TxtMode.Name = "TxtMode";
            this.TxtMode.Size = new System.Drawing.Size(111, 22);
            this.TxtMode.TabIndex = 33;
            this.TxtMode.Text = "Adding Users";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtSearch.Location = new System.Drawing.Point(460, 15);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(506, 29);
            this.TxtSearch.TabIndex = 32;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // NumRate
            // 
            this.NumRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumRate.Location = new System.Drawing.Point(33, 333);
            this.NumRate.Name = "NumRate";
            this.NumRate.Size = new System.Drawing.Size(374, 29);
            this.NumRate.TabIndex = 0;
            this.NumRate.ThousandsSeparator = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(844, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 47);
            this.button2.TabIndex = 34;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(460, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 27;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(588, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 47);
            this.button4.TabIndex = 30;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(716, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 47);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // personListView
            // 
            this.personListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.personListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.f_name,
            this.m_name,
            this.l_name,
            this.heart_rate});
            this.personListView.FullRowSelect = true;
            this.personListView.GridLines = true;
            this.personListView.HideSelection = false;
            this.personListView.Location = new System.Drawing.Point(460, 59);
            this.personListView.MultiSelect = false;
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(506, 303);
            this.personListView.TabIndex = 28;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.Details;
            this.personListView.SelectedIndexChanged += new System.EventHandler(this.personListView_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 50;
            // 
            // f_name
            // 
            this.f_name.Text = "Firstname";
            this.f_name.Width = 114;
            // 
            // m_name
            // 
            this.m_name.Text = "Middlename";
            this.m_name.Width = 114;
            // 
            // l_name
            // 
            this.l_name.Text = "Lastname";
            this.l_name.Width = 114;
            // 
            // heart_rate
            // 
            this.heart_rate.Text = "Heart Rate";
            this.heart_rate.Width = 114;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1156, 693);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.Click += new System.EventHandler(this.materialTabControl1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "angel.png");
            this.imageList1.Images.SetKeyName(1, "user.png");
            this.imageList1.Images.SetKeyName(2, "doctor.png");
            // 
            // TxtFirst
            // 
            this.TxtFirst.AnimateReadOnly = false;
            this.TxtFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFirst.Depth = 0;
            this.TxtFirst.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtFirst.Hint = "Enter Firstname here ...";
            this.TxtFirst.LeadingIcon = null;
            this.TxtFirst.Location = new System.Drawing.Point(32, 59);
            this.TxtFirst.MaxLength = 50;
            this.TxtFirst.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtFirst.Multiline = false;
            this.TxtFirst.Name = "TxtFirst";
            this.TxtFirst.Size = new System.Drawing.Size(374, 50);
            this.TxtFirst.TabIndex = 35;
            this.TxtFirst.Text = "";
            this.TxtFirst.TrailingIcon = null;
            // 
            // TxtMiddle
            // 
            this.TxtMiddle.AnimateReadOnly = false;
            this.TxtMiddle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMiddle.Depth = 0;
            this.TxtMiddle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtMiddle.Hint = "Enter Middlename here ...";
            this.TxtMiddle.LeadingIcon = null;
            this.TxtMiddle.Location = new System.Drawing.Point(32, 144);
            this.TxtMiddle.MaxLength = 50;
            this.TxtMiddle.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtMiddle.Multiline = false;
            this.TxtMiddle.Name = "TxtMiddle";
            this.TxtMiddle.Size = new System.Drawing.Size(374, 50);
            this.TxtMiddle.TabIndex = 36;
            this.TxtMiddle.Text = "";
            this.TxtMiddle.TrailingIcon = null;
            // 
            // TxtLast
            // 
            this.TxtLast.AnimateReadOnly = false;
            this.TxtLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLast.Depth = 0;
            this.TxtLast.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtLast.Hint = "Enter Lastname here ...";
            this.TxtLast.LeadingIcon = null;
            this.TxtLast.Location = new System.Drawing.Point(32, 229);
            this.TxtLast.MaxLength = 50;
            this.TxtLast.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtLast.Multiline = false;
            this.TxtLast.Name = "TxtLast";
            this.TxtLast.Size = new System.Drawing.Size(374, 50);
            this.TxtLast.TabIndex = 37;
            this.TxtLast.Text = "";
            this.TxtLast.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Heart Rate";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.TxtSearch);
            this.materialCard1.Controls.Add(this.personListView);
            this.materialCard1.Controls.Add(this.NumRate);
            this.materialCard1.Controls.Add(this.button3);
            this.materialCard1.Controls.Add(this.TxtLast);
            this.materialCard1.Controls.Add(this.button4);
            this.materialCard1.Controls.Add(this.TxtMiddle);
            this.materialCard1.Controls.Add(this.button1);
            this.materialCard1.Controls.Add(this.TxtFirst);
            this.materialCard1.Controls.Add(this.button2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1037, 447);
            this.materialCard1.TabIndex = 39;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.angelListView);
            this.materialCard2.Controls.Add(this.button8);
            this.materialCard2.Controls.Add(this.button7);
            this.materialCard2.Controls.Add(this.AngelSearch);
            this.materialCard2.Controls.Add(this.button6);
            this.materialCard2.Controls.Add(this.button5);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 74);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(999, 468);
            this.materialCard2.TabIndex = 48;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "doctor.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1148, 663);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Doctor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 760);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Person";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumRate)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label TxtMode;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.NumericUpDown NumRate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView personListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader f_name;
        private System.Windows.Forms.ColumnHeader m_name;
        private System.Windows.Forms.ColumnHeader l_name;
        private System.Windows.Forms.ColumnHeader heart_rate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label TxtMode1;
        private System.Windows.Forms.TextBox AngelSearch;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListView angelListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialTextBox2 TxtAngel;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox TxtFirst;
        private MaterialSkin.Controls.MaterialTextBox TxtLast;
        private MaterialSkin.Controls.MaterialTextBox TxtMiddle;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}