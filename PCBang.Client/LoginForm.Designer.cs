using PC_Project.Data;

namespace loginform
{
    partial class LoginForm
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
            this.lblNewAccount = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbbSeat = new System.Windows.Forms.ComboBox();
            this.seatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnNewAccount = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.비밀번호 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.좌석번호 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.비밀번호)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.좌석번호)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewAccount
            // 
            this.lblNewAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAccount.Appearance.Options.UseFont = true;
            this.lblNewAccount.Appearance.Options.UseTextOptions = true;
            this.lblNewAccount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNewAccount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNewAccount.Location = new System.Drawing.Point(5, 5);
            this.lblNewAccount.Name = "lblNewAccount";
            this.lblNewAccount.Size = new System.Drawing.Size(338, 36);
            this.lblNewAccount.StyleController = this.layoutControl1;
            this.lblNewAccount.TabIndex = 0;
            this.lblNewAccount.Text = "로그인";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbSeat);
            this.layoutControl1.Controls.Add(this.lblNewAccount);
            this.layoutControl1.Controls.Add(this.btnLogin);
            this.layoutControl1.Controls.Add(this.txbPassword);
            this.layoutControl1.Controls.Add(this.txbID);
            this.layoutControl1.Controls.Add(this.btnNewAccount);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl1.Location = new System.Drawing.Point(0, -6);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(797, 212, 812, 500);
            this.layoutControl1.OptionsView.UseSkinIndents = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(348, 519);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbSeat
            // 
            this.cbbSeat.DataSource = this.seatBindingSource;
            this.cbbSeat.DisplayMember = "SeatID";
            this.cbbSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeat.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbbSeat.Location = new System.Drawing.Point(75, 121);
            this.cbbSeat.Name = "cbbSeat";
            this.cbbSeat.Size = new System.Drawing.Size(268, 26);
            this.cbbSeat.TabIndex = 8;
            this.cbbSeat.ValueMember = "SeatID";
            this.cbbSeat.SelectedIndexChanged += new System.EventHandler(this.cbbSeat_SelectedIndexChanged);
            // 
            // seatBindingSource
            // 
            this.seatBindingSource.DataSource = typeof(PC_Project.Data.Seat);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.AutoWidthInLayoutControl = true;
            this.btnLogin.Location = new System.Drawing.Point(6, 457);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(337, 57);
            this.btnLogin.StyleController = this.layoutControl1;
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "로그인";
            this.btnLogin.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbPassword.Location = new System.Drawing.Point(74, 86);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(269, 25);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbID.Location = new System.Drawing.Point(74, 51);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(269, 25);
            this.txbID.TabIndex = 3;
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNewAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAccount.Appearance.Options.UseBackColor = true;
            this.btnNewAccount.Appearance.Options.UseFont = true;
            this.btnNewAccount.Location = new System.Drawing.Point(6, 413);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(337, 34);
            this.btnNewAccount.StyleController = this.layoutControl1;
            this.btnNewAccount.TabIndex = 6;
            this.btnNewAccount.Text = "회원가입";
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.비밀번호,
            this.simpleSeparator1,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.좌석번호});
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 5;
            this.Root.Size = new System.Drawing.Size(348, 519);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txbID;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(348, 37);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(92, 35);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(348, 35);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "ID";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 24);
            // 
            // 비밀번호
            // 
            this.비밀번호.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.비밀번호.AppearanceItemCaption.Options.UseFont = true;
            this.비밀번호.Control = this.txbPassword;
            this.비밀번호.Location = new System.Drawing.Point(0, 81);
            this.비밀번호.MaxSize = new System.Drawing.Size(348, 35);
            this.비밀번호.MinSize = new System.Drawing.Size(92, 35);
            this.비밀번호.Name = "비밀번호";
            this.비밀번호.Size = new System.Drawing.Size(348, 35);
            this.비밀번호.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.비밀번호.TextSize = new System.Drawing.Size(64, 24);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 116);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(1, 403);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(1, 152);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(347, 256);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnLogin;
            this.layoutControlItem5.Location = new System.Drawing.Point(1, 452);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(80, 44);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(347, 67);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblNewAccount;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(348, 46);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnNewAccount;
            this.layoutControlItem3.Location = new System.Drawing.Point(1, 408);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(347, 44);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // 좌석번호
            // 
            this.좌석번호.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.좌석번호.AppearanceItemCaption.Options.UseFont = true;
            this.좌석번호.Control = this.cbbSeat;
            this.좌석번호.Location = new System.Drawing.Point(1, 116);
            this.좌석번호.Name = "좌석번호";
            this.좌석번호.Size = new System.Drawing.Size(347, 36);
            this.좌석번호.TextSize = new System.Drawing.Size(64, 24);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 513);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.비밀번호)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.좌석번호)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblNewAccount;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbPassword;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem 비밀번호;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnNewAccount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.ComboBox cbbSeat;
        private DevExpress.XtraLayout.LayoutControlItem 좌석번호;
        private System.Windows.Forms.BindingSource seatBindingSource;
    }
}

