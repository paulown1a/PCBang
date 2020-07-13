namespace ManagerForm
{
    partial class AddTimeform
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
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.bdsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.cbbTime = new System.Windows.Forms.ComboBox();
            this.bdsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.btnExecution = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbCode = new System.Windows.Forms.ComboBox();
            this.bdsCode = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.결제 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.시간 = new DevExpress.XtraLayout.LayoutControlItem();
            this.이름 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.결제)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.시간)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.이름)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.DataSource = this.bdsCustomer;
            this.cbbCustomer.DisplayMember = "Name";
            this.cbbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(50, 12);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(428, 23);
            this.cbbCustomer.TabIndex = 0;
            this.cbbCustomer.ValueMember = "CustomerID";
            // 
            // bdsCustomer
            // 
            this.bdsCustomer.DataSource = typeof(PC_Project.Data.Customer);
            // 
            // cbbTime
            // 
            this.cbbTime.DataSource = this.bdsProduct;
            this.cbbTime.DisplayMember = "Name";
            this.cbbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Location = new System.Drawing.Point(50, 42);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.Size = new System.Drawing.Size(428, 23);
            this.cbbTime.TabIndex = 1;
            this.cbbTime.ValueMember = "ProductID";
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged);
            // 
            // btnExecution
            // 
            this.btnExecution.Location = new System.Drawing.Point(247, 125);
            this.btnExecution.Name = "btnExecution";
            this.btnExecution.Size = new System.Drawing.Size(113, 25);
            this.btnExecution.TabIndex = 2;
            this.btnExecution.Text = "실행";
            this.btnExecution.UseVisualStyleBackColor = true;
            this.btnExecution.Click += new System.EventHandler(this.btnExecution_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(364, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbCode
            // 
            this.cbbCode.DataSource = this.bdsCode;
            this.cbbCode.DisplayMember = "Name";
            this.cbbCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCode.FormattingEnabled = true;
            this.cbbCode.Location = new System.Drawing.Point(50, 72);
            this.cbbCode.Name = "cbbCode";
            this.cbbCode.Size = new System.Drawing.Size(428, 23);
            this.cbbCode.TabIndex = 4;
            this.cbbCode.ValueMember = "CodeID";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnExecution);
            this.layoutControl1.Controls.Add(this.cbbCustomer);
            this.layoutControl1.Controls.Add(this.cbbCode);
            this.layoutControl1.Controls.Add(this.cbbTime);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(490, 162);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.결제,
            this.emptySpaceItem1,
            this.이름,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.시간});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(490, 162);
            this.Root.TextVisible = false;
            // 
            // 결제
            // 
            this.결제.Control = this.cbbCode;
            this.결제.Location = new System.Drawing.Point(0, 60);
            this.결제.Name = "결제";
            this.결제.Size = new System.Drawing.Size(470, 30);
            this.결제.TextSize = new System.Drawing.Size(26, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 90);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(235, 52);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // 시간
            // 
            this.시간.Control = this.cbbTime;
            this.시간.Location = new System.Drawing.Point(0, 30);
            this.시간.Name = "시간";
            this.시간.Size = new System.Drawing.Size(470, 30);
            this.시간.TextSize = new System.Drawing.Size(26, 18);
            // 
            // 이름
            // 
            this.이름.Control = this.cbbCustomer;
            this.이름.Location = new System.Drawing.Point(0, 0);
            this.이름.Name = "이름";
            this.이름.Size = new System.Drawing.Size(470, 30);
            this.이름.TextSize = new System.Drawing.Size(26, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnExecution;
            this.layoutControlItem4.Location = new System.Drawing.Point(235, 113);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(117, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCancel;
            this.layoutControlItem5.Location = new System.Drawing.Point(352, 113);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(118, 29);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(235, 90);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(235, 23);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // AddTimeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 162);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "AddTimeform";
            this.Text = "시간추가";
            this.Load += new System.EventHandler(this.AddTimeform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddTimeform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.결제)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.시간)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.이름)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cbbCustomer;
    private System.Windows.Forms.ComboBox cbbTime;
    private System.Windows.Forms.BindingSource bdsCustomer;
    private System.Windows.Forms.BindingSource bdsProduct;
        private System.Windows.Forms.Button btnExecution;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbCode;
        private System.Windows.Forms.BindingSource bdsCode;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem 결제;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem 이름;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem 시간;
    }
}