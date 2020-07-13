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
            this.btnTicket = new FontAwesome.Sharp.IconButton();
            this.btnSnack = new FontAwesome.Sharp.IconButton();
            this.btnBeverage = new FontAwesome.Sharp.IconButton();
            this.btnFood = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeIcon = new System.Windows.Forms.PictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.CalulatorPn = new System.Windows.Forms.Panel();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.gridBIll = new DevExpress.XtraGrid.GridControl();
            this.bdsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuy = new FontAwesome.Sharp.IconButton();
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
            this.gridFood = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPrice = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPrice = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPhoto = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPhoto = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.pnHome = new PC_Project.Client.HomeDisplay();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuPn.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).BeginInit();
            this.CalulatorPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBIll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPn
            // 
            this.MenuPn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.MenuPn.Controls.Add(this.btnTicket);
            this.MenuPn.Controls.Add(this.btnSnack);
            this.MenuPn.Controls.Add(this.btnBeverage);
            this.MenuPn.Controls.Add(this.btnFood);
            this.MenuPn.Controls.Add(this.panel2);
            this.MenuPn.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPn.Location = new System.Drawing.Point(0, 0);
            this.MenuPn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuPn.Name = "MenuPn";
            this.MenuPn.Size = new System.Drawing.Size(220, 924);
            this.MenuPn.TabIndex = 0;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTicket.IconChar = FontAwesome.Sharp.IconChar.FireAlt;
            this.btnTicket.IconColor = System.Drawing.Color.Ivory;
            this.btnTicket.IconSize = 30;
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.Location = new System.Drawing.Point(0, 384);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTicket.Rotation = 0D;
            this.btnTicket.Size = new System.Drawing.Size(220, 72);
            this.btnTicket.TabIndex = 5;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnSnack
            // 
            this.btnSnack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnSnack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSnack.FlatAppearance.BorderSize = 0;
            this.btnSnack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSnack.IconChar = FontAwesome.Sharp.IconChar.Disease;
            this.btnSnack.IconColor = System.Drawing.Color.Ivory;
            this.btnSnack.IconSize = 30;
            this.btnSnack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnack.Location = new System.Drawing.Point(0, 312);
            this.btnSnack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSnack.Name = "btnSnack";
            this.btnSnack.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSnack.Rotation = 0D;
            this.btnSnack.Size = new System.Drawing.Size(220, 72);
            this.btnSnack.TabIndex = 4;
            this.btnSnack.Text = "Snack";
            this.btnSnack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSnack.UseVisualStyleBackColor = false;
            this.btnSnack.Click += new System.EventHandler(this.btnSnack_Click_1);
            // 
            // btnBeverage
            // 
            this.btnBeverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnBeverage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBeverage.FlatAppearance.BorderSize = 0;
            this.btnBeverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeverage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBeverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeverage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBeverage.IconChar = FontAwesome.Sharp.IconChar.WineGlassAlt;
            this.btnBeverage.IconColor = System.Drawing.Color.Ivory;
            this.btnBeverage.IconSize = 30;
            this.btnBeverage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeverage.Location = new System.Drawing.Point(0, 240);
            this.btnBeverage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBeverage.Name = "btnBeverage";
            this.btnBeverage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBeverage.Rotation = 0D;
            this.btnBeverage.Size = new System.Drawing.Size(220, 72);
            this.btnBeverage.TabIndex = 3;
            this.btnBeverage.Text = "Beverage";
            this.btnBeverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeverage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBeverage.UseVisualStyleBackColor = false;
            this.btnBeverage.Click += new System.EventHandler(this.btnBeverage_Click);
            // 
            // btnFood
            // 
            this.btnFood.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFood.IconChar = FontAwesome.Sharp.IconChar.PizzaSlice;
            this.btnFood.IconColor = System.Drawing.Color.Ivory;
            this.btnFood.IconSize = 30;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(0, 168);
            this.btnFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFood.Name = "btnFood";
            this.btnFood.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFood.Rotation = 0D;
            this.btnFood.Size = new System.Drawing.Size(220, 72);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "Food";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.HomeIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 168);
            this.panel2.TabIndex = 0;
            // 
            // HomeIcon
            // 
            this.HomeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.HomeIcon.Image = ((System.Drawing.Image)(resources.GetObject("HomeIcon.Image")));
            this.HomeIcon.Location = new System.Drawing.Point(38, 30);
            this.HomeIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Size = new System.Drawing.Size(142, 103);
            this.HomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeIcon.TabIndex = 0;
            this.HomeIcon.TabStop = false;
            this.HomeIcon.Click += new System.EventHandler(this.HomeIcon_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnExit.IconColor = System.Drawing.Color.Ivory;
            this.btnExit.IconSize = 30;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(713, 217);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(200, 72);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // CalulatorPn
            // 
            this.CalulatorPn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.CalulatorPn.Controls.Add(this.btnClear);
            this.CalulatorPn.Controls.Add(this.gridBIll);
            this.CalulatorPn.Controls.Add(this.btnExit);
            this.CalulatorPn.Controls.Add(this.btnBuy);
            this.CalulatorPn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CalulatorPn.Location = new System.Drawing.Point(220, 601);
            this.CalulatorPn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CalulatorPn.Name = "CalulatorPn";
            this.CalulatorPn.Size = new System.Drawing.Size(917, 323);
            this.CalulatorPn.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Hotjar;
            this.btnClear.IconColor = System.Drawing.Color.Ivory;
            this.btnClear.IconSize = 30;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(487, 25);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClear.Rotation = 0D;
            this.btnClear.Size = new System.Drawing.Size(220, 72);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            this.btnClear.MouseHover += new System.EventHandler(this.btnClear_MouseHover);
            // 
            // gridBIll
            // 
            this.gridBIll.DataSource = this.bdsOrder;
            this.gridBIll.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridBIll.Location = new System.Drawing.Point(6, 25);
            this.gridBIll.MainView = this.gridView1;
            this.gridBIll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridBIll.Name = "gridBIll";
            this.gridBIll.Size = new System.Drawing.Size(475, 271);
            this.gridBIll.TabIndex = 7;
            this.gridBIll.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridBIll.DoubleClick += new System.EventHandler(this.gridBIll_DoubleClick);
            // 
            // bdsOrder
            // 
            this.bdsOrder.DataSource = typeof(PC_Project.Data.Order);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colProductPrice});
            this.gridView1.DetailHeight = 420;
            this.gridView1.GridControl = this.gridBIll;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 25;
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
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
            this.colProductPrice.OptionsColumn.AllowEdit = false;
            this.colProductPrice.OptionsColumn.ReadOnly = true;
            this.colProductPrice.Visible = true;
            this.colProductPrice.VisibleIndex = 1;
            this.colProductPrice.Width = 94;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuy.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnBuy.IconColor = System.Drawing.Color.Ivory;
            this.btnBuy.IconSize = 30;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.Location = new System.Drawing.Point(487, 217);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuy.Rotation = 0D;
            this.btnBuy.Size = new System.Drawing.Size(220, 72);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "BUY";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            this.btnBuy.MouseLeave += new System.EventHandler(this.btnBuy_MouseLeave);
            this.btnBuy.MouseHover += new System.EventHandler(this.btnBuy_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(220, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 18);
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
            this.panel1.Controls.Add(this.gridFood);
            this.panel1.Controls.Add(this.pnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(220, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 583);
            this.panel1.TabIndex = 5;
            // 
            // SeatIdbtn
            // 
            this.SeatIdbtn.AutoSize = true;
            this.SeatIdbtn.Location = new System.Drawing.Point(687, 29);
            this.SeatIdbtn.Name = "SeatIdbtn";
            this.SeatIdbtn.Size = new System.Drawing.Size(0, 18);
            this.SeatIdbtn.TabIndex = 1;
            // 
            // gridFood
            // 
            this.gridFood.DataSource = this.bdsProduct;
            this.gridFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFood.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridFood.Location = new System.Drawing.Point(0, 0);
            this.gridFood.MainView = this.layoutView1;
            this.gridFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridFood.Name = "gridFood";
            this.gridFood.Size = new System.Drawing.Size(917, 583);
            this.gridFood.TabIndex = 2;
            this.gridFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            this.gridFood.Load += new System.EventHandler(this.gridFood_Load);
            this.gridFood.DoubleClick += new System.EventHandler(this.gridFood_DoubleClick);
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.layoutView1.Appearance.Card.Options.UseFont = true;
            this.layoutView1.Appearance.FieldCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.layoutView1.Appearance.FieldValue.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.layoutView1.Appearance.FieldValue.Options.UseFont = true;
            this.layoutView1.AppearancePrint.Card.Font = new System.Drawing.Font("Tahoma", 9F);
            this.layoutView1.AppearancePrint.Card.Options.UseFont = true;
            this.layoutView1.AppearancePrint.CardCaption.Options.UseTextOptions = true;
            this.layoutView1.CardHorzInterval = 1;
            this.layoutView1.CardMinSize = new System.Drawing.Size(350, 142);
            this.layoutView1.CardVertInterval = 1;
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colName,
            this.colPrice,
            this.colPhoto});
            this.layoutView1.DetailHeight = 3000;
            this.layoutView1.GridControl = this.gridFood;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.AllowRuntimeCustomization = false;
            this.layoutView1.OptionsBehavior.ReadOnly = true;
            this.layoutView1.OptionsCustomization.AllowSort = false;
            this.layoutView1.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.CustomSize;
            this.layoutView1.OptionsItemText.TextToControlDistance = 10;
            this.layoutView1.OptionsView.ShowCardExpandButton = false;
            this.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn;
            this.layoutView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPrice, DevExpress.Data.ColumnSortOrder.Descending)});
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.Caption = "이름";
            this.colName.FieldName = "Name";
            this.colName.LayoutViewField = this.layoutViewField_colName;
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsFilter.AllowAutoFilter = false;
            this.colName.OptionsFilter.AllowFilter = false;
            this.colName.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colName.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsFilter.ImmediateUpdatePopupExcelFilter = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsFilter.ShowEmptyDateFilter = false;
            this.colName.Width = 94;
            // 
            // layoutViewField_colName
            // 
            this.layoutViewField_colName.EditorPreferredWidth = 352;
            this.layoutViewField_colName.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colName.Name = "layoutViewField_colName";
            this.layoutViewField_colName.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutViewField_colName.Size = new System.Drawing.Size(362, 32);
            this.layoutViewField_colName.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_colName.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutViewField_colName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colName.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colName.TextToControlDistance = 0;
            this.layoutViewField_colName.TextVisible = false;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.colPrice.AppearanceCell.Options.UseFont = true;
            this.colPrice.Caption = "가격";
            this.colPrice.DisplayFormat.FormatString = "c0";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrice.FieldName = "Price";
            this.colPrice.LayoutViewField = this.layoutViewField_colPrice;
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.OptionsFilter.AllowAutoFilter = false;
            this.colPrice.OptionsFilter.AllowFilter = false;
            this.colPrice.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colPrice.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.OptionsFilter.ImmediateUpdatePopupExcelFilter = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.OptionsFilter.ShowEmptyDateFilter = false;
            this.colPrice.Width = 94;
            // 
            // layoutViewField_colPrice
            // 
            this.layoutViewField_colPrice.EditorPreferredWidth = 352;
            this.layoutViewField_colPrice.Location = new System.Drawing.Point(0, 32);
            this.layoutViewField_colPrice.Name = "layoutViewField_colPrice";
            this.layoutViewField_colPrice.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutViewField_colPrice.Size = new System.Drawing.Size(362, 32);
            this.layoutViewField_colPrice.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_colPrice.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colPrice.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPrice.TextVisible = false;
            // 
            // colPhoto
            // 
            this.colPhoto.Caption = " ";
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.LayoutViewField = this.layoutViewField_colPhoto;
            this.colPhoto.MaxWidth = 500;
            this.colPhoto.MinWidth = 500;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowEdit = false;
            this.colPhoto.Width = 500;
            // 
            // layoutViewField_colPhoto
            // 
            this.layoutViewField_colPhoto.EditorPreferredWidth = 352;
            this.layoutViewField_colPhoto.Location = new System.Drawing.Point(0, 64);
            this.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto";
            this.layoutViewField_colPhoto.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutViewField_colPhoto.Size = new System.Drawing.Size(362, 205);
            this.layoutViewField_colPhoto.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_colPhoto.StartNewLine = true;
            this.layoutViewField_colPhoto.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colPhoto.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPhoto.TextVisible = false;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colName,
            this.layoutViewField_colPrice,
            this.layoutViewField_colPhoto});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 10;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // pnHome
            // 
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(0, 0);
            this.pnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(917, 583);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1137, 924);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.CalulatorPn);
            this.Controls.Add(this.MenuPn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FoodOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "음식주문";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPn;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnFood;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnBeverage;
        private System.Windows.Forms.PictureBox HomeIcon;
        private System.Windows.Forms.Panel CalulatorPn;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnBuy;
        private FontAwesome.Sharp.IconButton btnSnack;
        private FontAwesome.Sharp.IconButton btnTicket;
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
        private DevExpress.XtraGrid.GridControl gridFood;
        private PC_Project.Client.HomeDisplay pnHome;
        private DevExpress.XtraGrid.GridControl gridBIll;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductPrice;
        private FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPrice;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPhoto;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPrice;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPhoto;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}