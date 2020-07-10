namespace PC_Project.Client
{
    partial class ChattingForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbText = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsChatting = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendTIme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ChattingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChatting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.btnSend);
            this.layoutControl1.Controls.Add(this.txbText);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(402, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(386, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 413);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(386, 25);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbText
            // 
            this.txbText.Location = new System.Drawing.Point(12, 384);
            this.txbText.Name = "txbText";
            this.txbText.Size = new System.Drawing.Size(776, 25);
            this.txbText.TabIndex = 5;
            this.txbText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbText_KeyDown);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsChatting;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 368);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsChatting
            // 
            this.bdsChatting.DataSource = typeof(PC_Project.Data.Chatting);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colText,
            this.colSendTIme});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colText
            // 
            this.colText.FieldName = "Text";
            this.colText.MinWidth = 25;
            this.colText.Name = "colText";
            this.colText.OptionsColumn.AllowEdit = false;
            this.colText.Visible = true;
            this.colText.VisibleIndex = 0;
            this.colText.Width = 560;
            // 
            // colSendTIme
            // 
            this.colSendTIme.DisplayFormat.FormatString = "MM/dd hh:mm:ss";
            this.colSendTIme.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSendTIme.FieldName = "SendTIme";
            this.colSendTIme.MinWidth = 25;
            this.colSendTIme.Name = "colSendTIme";
            this.colSendTIme.Visible = true;
            this.colSendTIme.VisibleIndex = 1;
            this.colSendTIme.Width = 186;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 372);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txbText;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 372);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 29);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSend;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 401);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(390, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnClose;
            this.layoutControlItem4.Location = new System.Drawing.Point(390, 401);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(390, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // ChattingTimer
            // 
            this.ChattingTimer.Interval = 2000;
            this.ChattingTimer.Tick += new System.EventHandler(this.ChattingTimer_Tick);
            // 
            // ChattingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ChattingForm";
            this.Text = "ChattingForm";
            this.Load += new System.EventHandler(this.ChattingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChatting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txbText;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bdsChatting;
        private DevExpress.XtraGrid.Columns.GridColumn colText;
        private System.Windows.Forms.Timer ChattingTimer;
        private DevExpress.XtraGrid.Columns.GridColumn colSendTIme;
    }
}