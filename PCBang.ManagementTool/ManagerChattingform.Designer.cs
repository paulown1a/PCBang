namespace ManagerForm
{

    partial class ManagerChattingform
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
            this.txbText = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbbSeat = new System.Windows.Forms.ComboBox();
            this.dbsSeat = new System.Windows.Forms.BindingSource(this.components);
            this.grvChatting = new DevExpress.XtraGrid.GridControl();
            this.dbsChatting = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSeatID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendTIme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.좌석 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.내용 = new DevExpress.XtraLayout.LayoutControlItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colSent = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbsSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChatting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsChatting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.좌석)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.내용)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txbText);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.btnSend);
            this.layoutControl1.Controls.Add(this.cbbSeat);
            this.layoutControl1.Controls.Add(this.grvChatting);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(489, 417);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txbText
            // 
            this.txbText.Location = new System.Drawing.Point(41, 349);
            this.txbText.Name = "txbText";
            this.txbText.Size = new System.Drawing.Size(436, 25);
            this.txbText.TabIndex = 9;
            this.txbText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbText_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(244, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(233, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 378);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(228, 27);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbbSeat
            // 
            this.cbbSeat.DataSource = this.dbsSeat;
            this.cbbSeat.DisplayMember = "SeatID";
            this.cbbSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeat.FormattingEnabled = true;
            this.cbbSeat.Location = new System.Drawing.Point(41, 319);
            this.cbbSeat.Name = "cbbSeat";
            this.cbbSeat.Size = new System.Drawing.Size(436, 26);
            this.cbbSeat.TabIndex = 5;
            this.cbbSeat.ValueMember = "SeatID";
            this.cbbSeat.DropDown += new System.EventHandler(this.cbbSeat_DropDown);
            // 
            // grvChatting
            // 
            this.grvChatting.DataSource = this.dbsChatting;
            this.grvChatting.Location = new System.Drawing.Point(12, 12);
            this.grvChatting.MainView = this.gridView1;
            this.grvChatting.Name = "grvChatting";
            this.grvChatting.Size = new System.Drawing.Size(465, 303);
            this.grvChatting.TabIndex = 4;
            this.grvChatting.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grvChatting.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // dbsChatting
            // 
            this.dbsChatting.DataSource = typeof(PC_Project.Data.Chatting);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSeatID,
            this.colText,
            this.colSendTIme,
            this.colSent});
            this.gridView1.GridControl = this.grvChatting;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSeatID
            // 
            this.colSeatID.FieldName = "SeatID";
            this.colSeatID.MinWidth = 25;
            this.colSeatID.Name = "colSeatID";
            this.colSeatID.OptionsColumn.AllowEdit = false;
            this.colSeatID.Visible = true;
            this.colSeatID.VisibleIndex = 1;
            this.colSeatID.Width = 53;
            // 
            // colText
            // 
            this.colText.FieldName = "Text";
            this.colText.MinWidth = 25;
            this.colText.Name = "colText";
            this.colText.OptionsColumn.AllowEdit = false;
            this.colText.Visible = true;
            this.colText.VisibleIndex = 2;
            this.colText.Width = 238;
            // 
            // colSendTIme
            // 
            this.colSendTIme.DisplayFormat.FormatString = "MM/dd hh:mm";
            this.colSendTIme.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSendTIme.FieldName = "SendTIme";
            this.colSendTIme.MinWidth = 25;
            this.colSendTIme.Name = "colSendTIme";
            this.colSendTIme.Visible = true;
            this.colSendTIme.VisibleIndex = 3;
            this.colSendTIme.Width = 103;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.좌석,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.내용});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(489, 417);
            this.Root.TextVisible = false;
            // 
            // 좌석
            // 
            this.좌석.Control = this.cbbSeat;
            this.좌석.Location = new System.Drawing.Point(0, 307);
            this.좌석.Name = "좌석";
            this.좌석.Size = new System.Drawing.Size(469, 30);
            this.좌석.TextSize = new System.Drawing.Size(26, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSend;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 366);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(232, 31);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnClose;
            this.layoutControlItem5.Location = new System.Drawing.Point(232, 366);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(237, 31);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grvChatting;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(469, 307);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // 내용
            // 
            this.내용.Control = this.txbText;
            this.내용.Location = new System.Drawing.Point(0, 337);
            this.내용.Name = "내용";
            this.내용.Size = new System.Drawing.Size(469, 29);
            this.내용.TextSize = new System.Drawing.Size(26, 18);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colSent
            // 
            this.colSent.FieldName = "Sent";
            this.colSent.MinWidth = 25;
            this.colSent.Name = "colSent";
            this.colSent.Visible = true;
            this.colSent.VisibleIndex = 0;
            this.colSent.Width = 41;
            // 
            // ManagerChattingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 417);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagerChattingform";
            this.Text = "ManagerChattingform";
            this.Load += new System.EventHandler(this.ManagerChattingform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbsSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChatting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsChatting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.좌석)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.내용)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.ComboBox cbbSeat;
    private System.Windows.Forms.BindingSource dbsSeat;
    private DevExpress.XtraGrid.GridControl grvChatting;
    private System.Windows.Forms.BindingSource dbsChatting;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlItem 좌석;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colSeatID;
        private DevExpress.XtraGrid.Columns.GridColumn colText;
        private System.Windows.Forms.TextBox txbText;
        private DevExpress.XtraLayout.LayoutControlItem 내용;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Columns.GridColumn colSendTIme;
        private DevExpress.XtraGrid.Columns.GridColumn colSent;
    }
}