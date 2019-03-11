namespace Hotel_Mater
{
    partial class registration
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
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnCheckIn = new System.Windows.Forms.Button();
            this.tblTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appdata = new Hotel_Mater.appdata();
            this.Label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRoomTableAdapter = new Hotel_Mater.appdataTableAdapters.tblRoomTableAdapter();
            this.tblTransactionTableAdapter = new Hotel_Mater.appdataTableAdapters.tblTransactionTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdults = new System.Windows.Forms.TextBox();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.MaskedTextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDaysNumber = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dtCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblAdvancePayment = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnCancel
            // 
            this.bttnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancel.Location = new System.Drawing.Point(654, 391);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(113, 35);
            this.bttnCancel.TabIndex = 103;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnCheckIn
            // 
            this.bttnCheckIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCheckIn.Location = new System.Drawing.Point(524, 391);
            this.bttnCheckIn.Name = "bttnCheckIn";
            this.bttnCheckIn.Size = new System.Drawing.Size(113, 35);
            this.bttnCheckIn.TabIndex = 102;
            this.bttnCheckIn.Text = "&Check In";
            this.bttnCheckIn.UseVisualStyleBackColor = true;
            this.bttnCheckIn.Click += new System.EventHandler(this.bttnCheckIn_Click);
            // 
            // tblTransactionBindingSource
            // 
            this.tblTransactionBindingSource.DataMember = "tblTransaction";
            this.tblTransactionBindingSource.DataSource = this.appdata;
            // 
            // appdata
            // 
            this.appdata.DataSetName = "appdata";
            this.appdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Label1
            // 
            this.Label1.AutoEllipsis = true;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(26, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(212, 28);
            this.Label1.TabIndex = 76;
            this.Label1.Text = "Registration Form";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(813, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 22);
            this.label16.TabIndex = 112;
            this.label16.Text = "X";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(450, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 237);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tblRoom";
            this.tblRoomBindingSource.DataSource = this.appdata;
            // 
            // tblRoomTableAdapter
            // 
            this.tblRoomTableAdapter.ClearBeforeFill = true;
            // 
            // tblTransactionTableAdapter
            // 
            this.tblTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtAdults);
            this.groupBox1.Controls.Add(this.txtChildren);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Label12);
            this.groupBox1.Controls.Add(this.Label10);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.txtGuestName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 165);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // txtAdults
            // 
            this.txtAdults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdults.Location = new System.Drawing.Point(596, 28);
            this.txtAdults.Multiline = true;
            this.txtAdults.Name = "txtAdults";
            this.txtAdults.Size = new System.Drawing.Size(51, 25);
            this.txtAdults.TabIndex = 127;
            this.txtAdults.Text = "0";
            this.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChildren
            // 
            this.txtChildren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildren.Location = new System.Drawing.Point(597, 64);
            this.txtChildren.Multiline = true;
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.Size = new System.Drawing.Size(51, 25);
            this.txtChildren.TabIndex = 126;
            this.txtChildren.Text = "0";
            this.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(454, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 21);
            this.label13.TabIndex = 125;
            this.label13.Text = "Email";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(454, 69);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(128, 21);
            this.Label12.TabIndex = 125;
            this.Label12.Text = "No. Of Children";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(454, 33);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(113, 21);
            this.Label10.TabIndex = 124;
            this.Label10.Text = "No. Of Adults";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(166, 59);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(210, 64);
            this.address.TabIndex = 123;
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(166, 133);
            this.number.Mask = "(999) 000-0000";
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(210, 21);
            this.number.TabIndex = 122;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(529, 111);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(251, 25);
            this.email.TabIndex = 121;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(166, 23);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(211, 25);
            this.txtGuestName.TabIndex = 121;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 21);
            this.label11.TabIndex = 118;
            this.label11.Text = "Mobile No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 119;
            this.label2.Text = "Address";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(23, 23);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(109, 21);
            this.Label3.TabIndex = 120;
            this.Label3.Text = "Guest Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtRoomRate);
            this.groupBox2.Controls.Add(this.Label6);
            this.groupBox2.Controls.Add(this.txtRoomType);
            this.groupBox2.Controls.Add(this.Label5);
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Controls.Add(this.txtnum);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 135);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 25);
            this.button1.TabIndex = 134;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomRate.Location = new System.Drawing.Point(165, 107);
            this.txtRoomRate.Multiline = true;
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.Size = new System.Drawing.Size(210, 25);
            this.txtRoomRate.TabIndex = 130;
            this.txtRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(28, 108);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(97, 21);
            this.Label6.TabIndex = 133;
            this.Label6.Text = "Room Rate";
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(165, 59);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(210, 25);
            this.txtRoomType.TabIndex = 129;
            this.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(26, 66);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 21);
            this.Label5.TabIndex = 132;
            this.Label5.Text = "Room Type";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(9, 19);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(122, 21);
            this.Label4.TabIndex = 131;
            this.Label4.Text = "Room Number";
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(165, 15);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(175, 25);
            this.txtnum.TabIndex = 128;
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.txtDaysNumber);
            this.groupBox3.Controls.Add(this.Label9);
            this.groupBox3.Controls.Add(this.Label8);
            this.groupBox3.Controls.Add(this.txtCheckInDate);
            this.groupBox3.Controls.Add(this.dtCheckOutDate);
            this.groupBox3.Controls.Add(this.Label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(464, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 135);
            this.groupBox3.TabIndex = 121;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stay-In Details";
            // 
            // txtDaysNumber
            // 
            this.txtDaysNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDaysNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysNumber.Location = new System.Drawing.Point(148, 91);
            this.txtDaysNumber.Multiline = true;
            this.txtDaysNumber.Name = "txtDaysNumber";
            this.txtDaysNumber.ReadOnly = true;
            this.txtDaysNumber.Size = new System.Drawing.Size(51, 21);
            this.txtDaysNumber.TabIndex = 98;
            this.txtDaysNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDaysNumber.TextChanged += new System.EventHandler(this.txtDaysNumber_TextChanged_1);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(42, 91);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(100, 21);
            this.Label9.TabIndex = 99;
            this.Label9.Text = "No. Of Days";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(16, 18);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(124, 21);
            this.Label8.TabIndex = 97;
            this.Label8.Text = "Check In Date";
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCheckInDate.Location = new System.Drawing.Point(146, 18);
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.Size = new System.Drawing.Size(197, 22);
            this.txtCheckInDate.TabIndex = 94;
            // 
            // dtCheckOutDate
            // 
            this.dtCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckOutDate.Location = new System.Drawing.Point(146, 58);
            this.dtCheckOutDate.Name = "dtCheckOutDate";
            this.dtCheckOutDate.Size = new System.Drawing.Size(199, 22);
            this.dtCheckOutDate.TabIndex = 95;
            this.dtCheckOutDate.ValueChanged += new System.EventHandler(this.dtCheckOutDate_ValueChanged_1);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(6, 58);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(140, 21);
            this.Label7.TabIndex = 96;
            this.Label7.Text = "Check Out Date";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.lblAdvancePayment);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.Label15);
            this.groupBox4.Controls.Add(this.txtAdvance);
            this.groupBox4.Controls.Add(this.Label14);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(27, 373);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 100);
            this.groupBox4.TabIndex = 122;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment Details";
            // 
            // lblAdvancePayment
            // 
            this.lblAdvancePayment.AutoSize = true;
            this.lblAdvancePayment.ForeColor = System.Drawing.Color.Red;
            this.lblAdvancePayment.Location = new System.Drawing.Point(80, 62);
            this.lblAdvancePayment.Name = "lblAdvancePayment";
            this.lblAdvancePayment.Size = new System.Drawing.Size(0, 17);
            this.lblAdvancePayment.TabIndex = 115;
            this.lblAdvancePayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(216, 56);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(98, 25);
            this.txtTotal.TabIndex = 112;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(46, 57);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(117, 21);
            this.Label15.TabIndex = 114;
            this.Label15.Text = "Total Balance";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.Location = new System.Drawing.Point(216, 18);
            this.txtAdvance.Multiline = true;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(98, 25);
            this.txtAdvance.TabIndex = 111;
            this.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdvance.TextChanged += new System.EventHandler(this.txtAdvance_TextChanged_1);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(5, 18);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(159, 21);
            this.Label14.TabIndex = 113;
            this.Label14.Text = "Advance Payment";
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Hotel_Mater.Properties.Resources.blurred_background_12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(847, 487);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnCheckIn);
            this.Controls.Add(this.Label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registration";
            this.Load += new System.EventHandler(this.registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button bttnCancel;
        internal System.Windows.Forms.Button bttnCheckIn;
        internal System.Windows.Forms.Label Label1;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private appdata appdata;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private appdataTableAdapters.tblRoomTableAdapter tblRoomTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource;
        private appdataTableAdapters.tblTransactionTableAdapter tblTransactionTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label lblAdvancePayment;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtAdvance;
        internal System.Windows.Forms.Label Label14;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtDaysNumber;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DateTimePicker txtCheckInDate;
        internal System.Windows.Forms.DateTimePicker dtCheckOutDate;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox txtRoomRate;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtRoomType;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtAdults;
        internal System.Windows.Forms.TextBox txtChildren;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.MaskedTextBox number;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox txtGuestName;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}