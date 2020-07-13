namespace Managerform
{

    partial class ManageCustomerform
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txbName = new System.Windows.Forms.TextBox();
            this.grvCustomer = new DevExpress.XtraGrid.GridControl();
            this.bdsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbPW = new System.Windows.Forms.TextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txbName);
            this.layoutControl1.Controls.Add(this.grvCustomer);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.txbID);
            this.layoutControl1.Controls.Add(this.txbPW);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(615, 452);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(41, 12);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(562, 25);
            this.txbName.TabIndex = 6;
            // 
            // grvCustomer
            // 
            this.grvCustomer.DataSource = this.bdsCustomer;
            this.grvCustomer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grvCustomer.Location = new System.Drawing.Point(12, 130);
            this.grvCustomer.MainView = this.gridView1;
            this.grvCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.grvCustomer.Name = "grvCustomer";
            this.grvCustomer.Size = new System.Drawing.Size(591, 310);
            this.grvCustomer.TabIndex = 5;
            this.grvCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grvCustomer.DoubleClick += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colRank,
            this.colLoginID,
            this.colRemainingTime});
            this.gridView1.GridControl = this.grvCustomer;
            this.gridView1.Name = "gridView1";
            // 
            // colName
            // 
            this.colName.Caption = "이름";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colRank
            // 
            this.colRank.Caption = "순위";
            this.colRank.FieldName = "Rank";
            this.colRank.MinWidth = 25;
            this.colRank.Name = "colRank";
            this.colRank.OptionsColumn.AllowEdit = false;
            this.colRank.Visible = true;
            this.colRank.VisibleIndex = 3;
            this.colRank.Width = 94;
            // 
            // colLoginID
            // 
            this.colLoginID.Caption = "ID";
            this.colLoginID.FieldName = "LoginID";
            this.colLoginID.MinWidth = 25;
            this.colLoginID.Name = "colLoginID";
            this.colLoginID.OptionsColumn.AllowEdit = false;
            this.colLoginID.Visible = true;
            this.colLoginID.VisibleIndex = 1;
            this.colLoginID.Width = 94;
            // 
            // colRemainingTime
            // 
            this.colRemainingTime.Caption = "남은시간";
            this.colRemainingTime.FieldName = "RemainingTime";
            this.colRemainingTime.MinWidth = 25;
            this.colRemainingTime.Name = "colRemainingTime";
            this.colRemainingTime.OptionsColumn.AllowEdit = false;
            this.colRemainingTime.Visible = true;
            this.colRemainingTime.VisibleIndex = 2;
            this.colRemainingTime.Width = 94;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(458, 99);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 27);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(309, 99);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 27);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "수정";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(41, 41);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(562, 25);
            this.txbID.TabIndex = 6;
            // 
            // txbPW
            // 
            this.txbPW.Location = new System.Drawing.Point(41, 70);
            this.txbPW.Name = "txbPW";
            this.txbPW.Size = new System.Drawing.Size(562, 25);
            this.txbPW.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(615, 452);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grvCustomer;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 118);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(595, 314);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txbName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(595, 29);
            this.layoutControlItem1.Text = "이름";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(26, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txbID;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(595, 29);
            this.layoutControlItem2.Text = "ID";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(26, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txbPW;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(595, 29);
            this.layoutControlItem6.Text = "PW";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(26, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSearch;
            this.layoutControlItem3.Location = new System.Drawing.Point(297, 87);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(149, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 87);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(297, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(446, 87);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(149, 31);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // ManageCustomerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 452);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "ManageCustomerform";
            this.Text = "고객관리";
            this.Load += new System.EventHandler(this.DeleteCustomerform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManagerCustomerform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

    }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grvCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource bdsCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colRank;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginID;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingTime;
        private System.Windows.Forms.TextBox txbName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TextBox txbID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.TextBox txbPW;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}