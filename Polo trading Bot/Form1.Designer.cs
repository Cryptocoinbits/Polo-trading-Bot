namespace Polo_trading_Bot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblsell_price = new System.Windows.Forms.Label();
            this.lblbtc_balance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_spend = new System.Windows.Forms.TextBox();
            this.txt_pair = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_buy_order = new System.Windows.Forms.TextBox();
            this.txt_range = new System.Windows.Forms.TextBox();
            this.txt_percentage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtapi = new System.Windows.Forms.TextBox();
            this.txtsecret = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOTE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_buy_total = new System.Windows.Forms.Label();
            this.total_blance = new System.Windows.Forms.Label();
            this.lbl_balance_status = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_run_stat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_sell_status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(469, 293);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lblsell_price);
            this.tabPage1.Controls.Add(this.lblbtc_balance);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btn_stop);
            this.tabPage1.Controls.Add(this.btn_start);
            this.tabPage1.Controls.Add(this.txt_spend);
            this.tabPage1.Controls.Add(this.txt_pair);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_buy_order);
            this.tabPage1.Controls.Add(this.txt_range);
            this.tabPage1.Controls.Add(this.txt_percentage);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(461, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(302, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "(Minutes)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(176, 196);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Cancel Buy interval :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(324, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "View Logs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "(BTC_ETH)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Top Buy Price :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "(3 and 5 only)";
            // 
            // lblsell_price
            // 
            this.lblsell_price.AutoSize = true;
            this.lblsell_price.ForeColor = System.Drawing.Color.Green;
            this.lblsell_price.Location = new System.Drawing.Point(95, 16);
            this.lblsell_price.Name = "lblsell_price";
            this.lblsell_price.Size = new System.Drawing.Size(15, 15);
            this.lblsell_price.TabIndex = 14;
            this.lblsell_price.Text = "--";
            // 
            // lblbtc_balance
            // 
            this.lblbtc_balance.AutoSize = true;
            this.lblbtc_balance.ForeColor = System.Drawing.Color.Green;
            this.lblbtc_balance.Location = new System.Drawing.Point(336, 16);
            this.lblbtc_balance.Name = "lblbtc_balance";
            this.lblbtc_balance.Size = new System.Drawing.Size(15, 15);
            this.lblbtc_balance.TabIndex = 13;
            this.lblbtc_balance.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "BTC Balance :";
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Location = new System.Drawing.Point(226, 227);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(92, 26);
            this.btn_stop.TabIndex = 11;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Green;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(127, 227);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(92, 26);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_spend
            // 
            this.txt_spend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_spend.Location = new System.Drawing.Point(176, 169);
            this.txt_spend.Name = "txt_spend";
            this.txt_spend.Size = new System.Drawing.Size(221, 21);
            this.txt_spend.TabIndex = 9;
            this.txt_spend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_spend_KeyPress);
            // 
            // txt_pair
            // 
            this.txt_pair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pair.Location = new System.Drawing.Point(176, 62);
            this.txt_pair.Name = "txt_pair";
            this.txt_pair.Size = new System.Drawing.Size(133, 21);
            this.txt_pair.TabIndex = 1;
            this.txt_pair.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pair_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Range of buy order :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max 24 Hour BTC Spend :";
            // 
            // txt_buy_order
            // 
            this.txt_buy_order.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buy_order.Location = new System.Drawing.Point(176, 89);
            this.txt_buy_order.Name = "txt_buy_order";
            this.txt_buy_order.Size = new System.Drawing.Size(133, 21);
            this.txt_buy_order.TabIndex = 3;
            this.txt_buy_order.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buy_order_KeyPress);
            // 
            // txt_range
            // 
            this.txt_range.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_range.Location = new System.Drawing.Point(176, 116);
            this.txt_range.Name = "txt_range";
            this.txt_range.Size = new System.Drawing.Size(221, 21);
            this.txt_range.TabIndex = 5;
            this.txt_range.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_range_KeyPress);
            // 
            // txt_percentage
            // 
            this.txt_percentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_percentage.Location = new System.Drawing.Point(176, 143);
            this.txt_percentage.Name = "txt_percentage";
            this.txt_percentage.Size = new System.Drawing.Size(221, 21);
            this.txt_percentage.TabIndex = 7;
            this.txt_percentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_percentage_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. of buy order :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market Pairing :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sell percentage :";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.txtapi);
            this.tabPage2.Controls.Add(this.txtsecret);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(461, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(361, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtapi
            // 
            this.txtapi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapi.Location = new System.Drawing.Point(73, 49);
            this.txtapi.Name = "txtapi";
            this.txtapi.Size = new System.Drawing.Size(380, 21);
            this.txtapi.TabIndex = 5;
            // 
            // txtsecret
            // 
            this.txtsecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsecret.Location = new System.Drawing.Point(73, 76);
            this.txtsecret.Name = "txtsecret";
            this.txtsecret.Size = new System.Drawing.Size(380, 21);
            this.txtsecret.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Secret Key :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "API Key :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Price,
            this.NOTE,
            this.BTC,
            this.OrderNumber});
            this.listView1.Location = new System.Drawing.Point(515, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 177);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 120;
            // 
            // NOTE
            // 
            this.NOTE.Text = "NOTE";
            this.NOTE.Width = 120;
            // 
            // BTC
            // 
            this.BTC.Text = "BTC";
            this.BTC.Width = 120;
            // 
            // OrderNumber
            // 
            this.OrderNumber.Text = "Order Number";
            this.OrderNumber.Width = 120;
            // 
            // lbl_buy_total
            // 
            this.lbl_buy_total.AutoSize = true;
            this.lbl_buy_total.ForeColor = System.Drawing.Color.Green;
            this.lbl_buy_total.Location = new System.Drawing.Point(657, 229);
            this.lbl_buy_total.Name = "lbl_buy_total";
            this.lbl_buy_total.Size = new System.Drawing.Size(13, 13);
            this.lbl_buy_total.TabIndex = 14;
            this.lbl_buy_total.Text = "--";
            // 
            // total_blance
            // 
            this.total_blance.AutoSize = true;
            this.total_blance.ForeColor = System.Drawing.Color.Green;
            this.total_blance.Location = new System.Drawing.Point(797, 229);
            this.total_blance.Name = "total_blance";
            this.total_blance.Size = new System.Drawing.Size(13, 13);
            this.total_blance.TabIndex = 15;
            this.total_blance.Text = "--";
            // 
            // lbl_balance_status
            // 
            this.lbl_balance_status.AutoSize = true;
            this.lbl_balance_status.ForeColor = System.Drawing.Color.Green;
            this.lbl_balance_status.Location = new System.Drawing.Point(512, 229);
            this.lbl_balance_status.Name = "lbl_balance_status";
            this.lbl_balance_status.Size = new System.Drawing.Size(13, 13);
            this.lbl_balance_status.TabIndex = 16;
            this.lbl_balance_status.Text = "--";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(515, 253);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 64);
            this.textBox1.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(900, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(119, 173);
            this.listBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(515, 323);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 64);
            this.textBox2.TabIndex = 19;
            // 
            // lbl_run_stat
            // 
            this.lbl_run_stat.AutoSize = true;
            this.lbl_run_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_run_stat.ForeColor = System.Drawing.Color.Green;
            this.lbl_run_stat.Location = new System.Drawing.Point(77, 344);
            this.lbl_run_stat.Name = "lbl_run_stat";
            this.lbl_run_stat.Size = new System.Drawing.Size(18, 18);
            this.lbl_run_stat.TabIndex = 20;
            this.lbl_run_stat.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "Status :";
            // 
            // timer1
            // 
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_sell_status
            // 
            this.lbl_sell_status.AutoSize = true;
            this.lbl_sell_status.ForeColor = System.Drawing.Color.Green;
            this.lbl_sell_status.Location = new System.Drawing.Point(897, 255);
            this.lbl_sell_status.Name = "lbl_sell_status";
            this.lbl_sell_status.Size = new System.Drawing.Size(13, 13);
            this.lbl_sell_status.TabIndex = 22;
            this.lbl_sell_status.Text = "--";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_main
            // 
            this.btn_main.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main.ForeColor = System.Drawing.Color.White;
            this.btn_main.Location = new System.Drawing.Point(16, 23);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(92, 26);
            this.btn_main.TabIndex = 24;
            this.btn_main.Text = "Main";
            this.btn_main.UseVisualStyleBackColor = false;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Location = new System.Drawing.Point(107, 23);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(92, 26);
            this.btn_settings.TabIndex = 25;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 379);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_sell_status);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_run_stat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_balance_status);
            this.Controls.Add(this.total_blance);
            this.Controls.Add(this.lbl_buy_total);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poloniex Trading Bot 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_spend;
        private System.Windows.Forms.TextBox txt_pair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_buy_order;
        private System.Windows.Forms.TextBox txt_range;
        private System.Windows.Forms.TextBox txt_percentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtapi;
        private System.Windows.Forms.TextBox txtsecret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblbtc_balance;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblsell_price;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader NOTE;
        private System.Windows.Forms.ColumnHeader BTC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_buy_total;
        private System.Windows.Forms.Label total_blance;
        private System.Windows.Forms.Label lbl_balance_status;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader OrderNumber;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_run_stat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_sell_status;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button btn_settings;
    }
}

