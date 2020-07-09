namespace PC_Room
{
    partial class FoodOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodOrderForm));
            this.MenuPn = new System.Windows.Forms.Panel();
            this.TicketBtn = new FontAwesome.Sharp.IconButton();
            this.SnackBtn = new FontAwesome.Sharp.IconButton();
            this.BeverageBtn = new FontAwesome.Sharp.IconButton();
            this.FoodBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeIcon = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new FontAwesome.Sharp.IconButton();
            this.CalulatorPn = new System.Windows.Forms.Panel();
            this.gridBIll = new DevExpress.XtraGrid.GridControl();
            this.bdsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeatID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BuyBtn = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrders1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeatIdbtn = new System.Windows.Forms.Label();
            this.GridFood = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnHome = new PC_Project.Client.HomeDisplay();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuPn.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).BeginInit();
            this.CalulatorPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBIll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPn
            // 
            this.MenuPn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.MenuPn.Controls.Add(this.TicketBtn);
            this.MenuPn.Controls.Add(this.SnackBtn);
            this.MenuPn.Controls.Add(this.BeverageBtn);
            this.MenuPn.Controls.Add(this.FoodBtn);
            this.MenuPn.Controls.Add(this.panel2);
            this.MenuPn.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPn.Location = new System.Drawing.Point(0, 0);
            this.MenuPn.Name = "MenuPn";
            this.MenuPn.Size = new System.Drawing.Size(220, 770);
            this.MenuPn.TabIndex = 0;
            // 
            // TicketBtn
            // 
            this.TicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.TicketBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TicketBtn.FlatAppearance.BorderSize = 0;
            this.TicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TicketBtn.Font = new System.Drawing.Font("Hobo BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TicketBtn.IconChar = FontAwesome.Sharp.IconChar.FireAlt;
            this.TicketBtn.IconColor = System.Drawing.Color.Ivory;
            this.TicketBtn.IconSize = 30;
            this.TicketBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TicketBtn.Location = new System.Drawing.Point(0, 320);
            this.TicketBtn.Name = "TicketBtn";
            this.TicketBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TicketBtn.Rotation = 0D;
            this.TicketBtn.Size = new System.Drawing.Size(220, 60);
            this.TicketBtn.TabIndex = 5;
            this.TicketBtn.Text = "Ticket";
            this.TicketBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TicketBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TicketBtn.UseVisualStyleBackColor = false;
            this.TicketBtn.Click += new System.EventHandler(this.TicketBtn_Click);
            // 
            // SnackBtn
            // 
            this.SnackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.SnackBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SnackBtn.FlatAppearance.BorderSize = 0;
            this.SnackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SnackBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SnackBtn.Font = new System.Drawing.Font("Hobo BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SnackBtn.IconChar = FontAwesome.Sharp.IconChar.Disease;
            this.SnackBtn.IconColor = System.Drawing.Color.Ivory;
            this.SnackBtn.IconSize = 30;
            this.SnackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SnackBtn.Location = new System.Drawing.Point(0, 260);
            this.SnackBtn.Name = "SnackBtn";
            this.SnackBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SnackBtn.Rotation = 0D;
            this.SnackBtn.Size = new System.Drawing.Size(220, 60);
            this.SnackBtn.TabIndex = 4;
            this.SnackBtn.Text = "Snack";
            this.SnackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SnackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SnackBtn.UseVisualStyleBackColor = false;
            this.SnackBtn.Click += new System.EventHandler(this.SnackBtn_Click_1);
            // 
            // BeverageBtn
            // 
            this.BeverageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.BeverageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BeverageBtn.FlatAppearance.BorderSize = 0;
            this.BeverageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeverageBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BeverageBtn.Font = new System.Drawing.Font("Hobo BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeverageBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BeverageBtn.IconChar = FontAwesome.Sharp.IconChar.WineGlassAlt;
            this.BeverageBtn.IconColor = System.Drawing.Color.Ivory;
            this.BeverageBtn.IconSize = 30;
            this.BeverageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeverageBtn.Location = new System.Drawing.Point(0, 200);
            this.BeverageBtn.Name = "BeverageBtn";
            this.BeverageBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BeverageBtn.Rotation = 0D;
            this.BeverageBtn.Size = new System.Drawing.Size(220, 60);
            this.BeverageBtn.TabIndex = 3;
            this.BeverageBtn.Text = "Beverage";
            this.BeverageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeverageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BeverageBtn.UseVisualStyleBackColor = false;
            this.BeverageBtn.Click += new System.EventHandler(this.BeverageBtn_Click);
            // 
            // FoodBtn
            // 
            this.FoodBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FoodBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.FoodBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoodBtn.FlatAppearance.BorderSize = 0;
            this.FoodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.FoodBtn.Font = new System.Drawing.Font("Hobo BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FoodBtn.IconChar = FontAwesome.Sharp.IconChar.PizzaSlice;
            this.FoodBtn.IconColor = System.Drawing.Color.Ivory;
            this.FoodBtn.IconSize = 30;
            this.FoodBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoodBtn.Location = new System.Drawing.Point(0, 140);
            this.FoodBtn.Name = "FoodBtn";
            this.FoodBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FoodBtn.Rotation = 0D;
            this.FoodBtn.Size = new System.Drawing.Size(220, 60);
            this.FoodBtn.TabIndex = 1;
            this.FoodBtn.Text = "Food";
            this.FoodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoodBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FoodBtn.UseVisualStyleBackColor = false;
            this.FoodBtn.Click += new System.EventHandler(this.FoodBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.HomeIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
            // 
            // HomeIcon
            // 
            this.HomeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.HomeIcon.Image = ((System.Drawing.Image)(resources.GetObject("HomeIcon.Image")));
            this.HomeIcon.Location = new System.Drawing.Point(38, 25);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Size = new System.Drawing.Size(142, 86);
            this.HomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeIcon.TabIndex = 0;
            this.HomeIcon.TabStop = false;
            this.HomeIcon.Click += new System.EventHandler(this.HomeIcon_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ExitBtn.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ExitBtn.IconColor = System.Drawing.Color.Ivory;
            this.ExitBtn.IconSize = 30;
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(713, 181);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitBtn.Rotation = 0D;
            this.ExitBtn.Size = new System.Drawing.Size(200, 60);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            this.ExitBtn.MouseHover += new System.EventHandler(this.ExitBtn_MouseHover);
            // 
            // CalulatorPn
            // 
            this.CalulatorPn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.CalulatorPn.Controls.Add(this.gridBIll);
            this.CalulatorPn.Controls.Add(this.ExitBtn);
            this.CalulatorPn.Controls.Add(this.BuyBtn);
            this.CalulatorPn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CalulatorPn.Location = new System.Drawing.Point(220, 501);
            this.CalulatorPn.Name = "CalulatorPn";
            this.CalulatorPn.Size = new System.Drawing.Size(917, 269);
            this.CalulatorPn.TabIndex = 3;
            // 
            // gridBIll
            // 
            this.gridBIll.DataSource = this.bdsOrder;
            this.gridBIll.Location = new System.Drawing.Point(6, 21);
            this.gridBIll.MainView = this.gridView1;
            this.gridBIll.Name = "gridBIll";
            this.gridBIll.Size = new System.Drawing.Size(475, 226);
            this.gridBIll.TabIndex = 7;
            this.gridBIll.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsOrder
            // 
            this.bdsOrder.DataSource = typeof(PC_Project.Data.Order);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colProductPrice,
            this.colSeatID,
            this.colCustomerID});
            this.gridView1.GridControl = this.gridBIll;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 25;
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 94;
            // 
            // colProductPrice
            // 
            this.colProductPrice.DisplayFormat.FormatString = "C0";
            this.colProductPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colProductPrice.FieldName = "ProductPrice";
            this.colProductPrice.MinWidth = 25;
            this.colProductPrice.Name = "colProductPrice";
            this.colProductPrice.OptionsColumn.ReadOnly = true;
            this.colProductPrice.Visible = true;
            this.colProductPrice.VisibleIndex = 1;
            this.colProductPrice.Width = 94;
            // 
            // colSeatID
            // 
            this.colSeatID.FieldName = "SeatID";
            this.colSeatID.MinWidth = 25;
            this.colSeatID.Name = "colSeatID";
            this.colSeatID.OptionsColumn.ReadOnly = true;
            this.colSeatID.Visible = true;
            this.colSeatID.VisibleIndex = 2;
            this.colSeatID.Width = 94;
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.MinWidth = 25;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.OptionsColumn.ReadOnly = true;
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 3;
            this.colCustomerID.Width = 94;
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.BuyBtn.FlatAppearance.BorderSize = 0;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BuyBtn.Font = new System.Drawing.Font("Hobo BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuyBtn.IconChar = FontAwesome.Sharp.IconChar.Hotjar;
            this.BuyBtn.IconColor = System.Drawing.Color.Ivory;
            this.BuyBtn.IconSize = 30;
            this.BuyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyBtn.Location = new System.Drawing.Point(487, 181);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BuyBtn.Rotation = 0D;
            this.BuyBtn.Size = new System.Drawing.Size(220, 60);
            this.BuyBtn.TabIndex = 5;
            this.BuyBtn.Text = "BUY";
            this.BuyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuyBtn.UseVisualStyleBackColor = false;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            this.BuyBtn.MouseLeave += new System.EventHandler(this.BuyBtn_MouseLeave);
            this.BuyBtn.MouseHover += new System.EventHandler(this.BuyBtn_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(220, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 15);
            this.panel4.TabIndex = 4;
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.MinWidth = 25;
            this.colProductID.Name = "colProductID";
            this.colProductID.Width = 94;
            // 
            // colCodeID
            // 
            this.colCodeID.FieldName = "CodeID";
            this.colCodeID.MinWidth = 25;
            this.colCodeID.Name = "colCodeID";
            this.colCodeID.Width = 94;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.MinWidth = 25;
            this.colName1.Name = "colName1";
            this.colName1.Width = 94;
            // 
            // colPrice1
            // 
            this.colPrice1.FieldName = "Price";
            this.colPrice1.MinWidth = 25;
            this.colPrice1.Name = "colPrice1";
            this.colPrice1.Width = 94;
            // 
            // colCode1
            // 
            this.colCode1.FieldName = "Code";
            this.colCode1.MinWidth = 25;
            this.colCode1.Name = "colCode1";
            this.colCode1.Width = 94;
            // 
            // colOrders1
            // 
            this.colOrders1.FieldName = "Orders";
            this.colOrders1.MinWidth = 25;
            this.colOrders1.Name = "colOrders1";
            this.colOrders1.Width = 94;
            // 
            // bdsProduct
            // 
            this.bdsProduct.DataSource = typeof(PC_Project.Data.Product);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SeatIdbtn);
            this.panel1.Controls.Add(this.GridFood);
            this.panel1.Controls.Add(this.pnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(220, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 486);
            this.panel1.TabIndex = 5;
            // 
            // SeatIdbtn
            // 
            this.SeatIdbtn.AutoSize = true;
            this.SeatIdbtn.Location = new System.Drawing.Point(687, 24);
            this.SeatIdbtn.Name = "SeatIdbtn";
            this.SeatIdbtn.Size = new System.Drawing.Size(0, 15);
            this.SeatIdbtn.TabIndex = 1;
            // 
            // GridFood
            // 
            this.GridFood.DataSource = this.bdsProduct;
            this.GridFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridFood.Location = new System.Drawing.Point(0, 0);
            this.GridFood.MainView = this.cardView1;
            this.GridFood.Name = "GridFood";
            this.GridFood.Size = new System.Drawing.Size(917, 486);
            this.GridFood.TabIndex = 2;
            this.GridFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.GridFood.DoubleClick += new System.EventHandler(this.GridFood_DoubleClick);
            // 
            // cardView1
            // 
            this.cardView1.Appearance.Card.Font = new System.Drawing.Font("Expo M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cardView1.Appearance.Card.Options.UseFont = true;
            this.cardView1.Appearance.FieldCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cardView1.AppearancePrint.CardCaption.Options.UseTextOptions = true;
            this.cardView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cardView1.CardInterval = 20;
            this.cardView1.CardScrollButtonBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cardView1.CardWidth = 250;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPrice,
            this.colPhoto});
            this.cardView1.DetailHeight = 400;
            this.cardView1.GridControl = this.GridFood;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.ReadOnly = true;
            this.cardView1.OptionsBehavior.Sizeable = false;
            this.cardView1.OptionsView.ShowCardExpandButton = false;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colPrice
            // 
            this.colPrice.DisplayFormat.FormatString = "c0";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            this.colPrice.Width = 94;
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.MinWidth = 25;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 2;
            this.colPhoto.Width = 94;
            // 
            // pnHome
            // 
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(0, 0);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(917, 486);
            this.pnHome.TabIndex = 3;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn1.HeaderText = "Count";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // SeatID
            // 
            this.SeatID.DataPropertyName = "SeatID";
            this.SeatID.HeaderText = "SeatID";
            this.SeatID.MinimumWidth = 6;
            this.SeatID.Name = "SeatID";
            this.SeatID.ReadOnly = true;
            this.SeatID.Width = 125;
            // 
            // FoodOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1137, 770);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.CalulatorPn);
            this.Controls.Add(this.MenuPn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FoodOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORDER FOOD";
            this.Load += new System.EventHandler(this.FoodOrderForm_Load);
            this.MenuPn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).EndInit();
            this.CalulatorPn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBIll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPn;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton FoodBtn;
        private FontAwesome.Sharp.IconButton ExitBtn;
        private FontAwesome.Sharp.IconButton BeverageBtn;
        private System.Windows.Forms.PictureBox HomeIcon;
        private System.Windows.Forms.Panel CalulatorPn;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton BuyBtn;
        private FontAwesome.Sharp.IconButton SnackBtn;
        private FontAwesome.Sharp.IconButton TicketBtn;
        private System.Windows.Forms.BindingSource bdsProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeID;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrders1;
        private System.Windows.Forms.BindingSource bdsOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SeatIdbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatID;
        private DevExpress.XtraGrid.GridControl GridFood;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private PC_Project.Client.HomeDisplay pnHome;
        private DevExpress.XtraGrid.GridControl gridBIll;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSeatID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
    }
}