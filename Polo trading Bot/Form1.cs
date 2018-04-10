using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Net;
using System.Collections;
using System.Threading;
using System.Diagnostics;

namespace Polo_trading_Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += BackgroundWorkerOnDoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorkerOnProgressChanged;

            backgroundWorker2.WorkerSupportsCancellation = true;
            backgroundWorker2.DoWork += BackgroundWorkerOnDoWork2;
            backgroundWorker2.ProgressChanged += BackgroundWorkerOnProgressChanged2;
        }

        string lowest_buy_price;
        string result_buy;
        string result_sell;
        string sell_amount;
        decimal total_btc_spend;
        decimal total_btc_buy;

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            try
            {
                load_api();
                load_trade();
            }
            catch { }
            //backgroundWorker1.RunWorkerAsync();
        }

        private void load_api()
        {
            string text = "";
            string text2 = "";

            StreamReader streamReader = File.OpenText(Application.StartupPath + "\\config.dat");
            string text3 = streamReader.ReadLine();
            int num = 1;
            while (text3 != null)
            {
                switch (num)
                {
                    case 1:
                        text = text3;
                        break;
                    case 2:
                        text2 = text3;
                        break;
                }
                num++;
                text3 = streamReader.ReadLine();
            }

           txtapi.Text = text;
           txtsecret.Text = text2;
           streamReader.Close();
        }

        private void getbalance()
        {
            try
            {
                string f1ss = txt_percentage.Text.Replace("-", "_");
                StreamReader inStream;

                WebRequest webRequest = WebRequest.Create("http://ifastbit.com/netlist/polotradingbot/balance.php?&key=" + txtapi.Text + "&secret=" + txtsecret.Text);
                WebResponse webresponse = webRequest.GetResponse();

                inStream = new StreamReader(webresponse.GetResponseStream());
                string res = inStream.ReadToEnd();

                //MessageBox.Show(res);
                RichTextBox rich = new RichTextBox();
                rich.Text = res;

                int posa = rich.Text.IndexOf("BTC");
                if (posa != 1)
                {
                    rich.SelectionStart = posa;
                    rich.SelectionLength = rich.Text.Length - posa;
                    rich.Focus();

                    string myTexta = rich.SelectedText;

                    string btc1 = myTexta.Split('>')[1];
                    string btc2 = btc1.Split('"')[1];

                    if (lblbtc_balance.InvokeRequired)
                    {
                        lblbtc_balance.Invoke((MethodInvoker)delegate()
                        {
                            lblbtc_balance.Text = btc2;
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        class WebPostRequest
        {
            WebRequest theRequest;
            HttpWebResponse theResponse;
            ArrayList theQueryData;

            public WebPostRequest(string url)
            {
                theRequest = WebRequest.Create(url);
                theRequest.Method = "POST";
                theQueryData = new ArrayList();
            }

            public void Add(string key, string value)
            {
                theQueryData.Add(String.Format("{0}={1}", key, HttpUtility.UrlEncode(value)));
            }

            public string GetResponse()
            {

                theRequest.ContentType = "application/x-www-form-urlencoded";

                string Parameters = String.Join("&", (String[])theQueryData.ToArray(typeof(string)));
                theRequest.ContentLength = Parameters.Length;

                StreamWriter sw = new StreamWriter(theRequest.GetRequestStream());
                sw.Write(Parameters);
                sw.Close();

                theResponse = (HttpWebResponse)theRequest.GetResponse();
                StreamReader sr = new StreamReader(theResponse.GetResponseStream());
                return sr.ReadToEnd();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (txt_pair.Text == "" | txt_buy_order.Text == "" | txt_range.Text == "" | txt_percentage.Text == "" | txt_spend.Text == "")
            {
                MessageBox.Show("Please input all fields");
            }
            else
            {
                if (txt_buy_order.Text == "3" | txt_buy_order.Text == "5")
                {
                    if (txtapi.Text != "" | txtsecret.Text != "")
                    {
                        try
                        {
                            lbl_run_stat.Text = "Running.......";
                            backgroundWorker2.RunWorkerAsync();
                            btn_start.Enabled = false;
                            btn_stop.Enabled = true;

                            int inter = Convert.ToInt32(numericUpDown1.Value);
                            int inter2 = inter * 60000;
                            timer1.Interval = inter2;
                            timer1.Start();//start the cancel order in 10 minutes interval
                        }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("API and Secret is missing, please add api and secret in config.dat file.");
                    }
                }
                else
                {
                    MessageBox.Show("No. of order not valid, only 3 and 5 accepted!");
                }
            }
        }

        private void get_sell_price()
        {
            try
            {
                WebClient client = new WebClient();
                client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                string downloadString = client.DownloadString("https://poloniex.com/public?command=returnOrderBook&currencyPair=" + txt_pair.Text);

                RichTextBox rich = new RichTextBox();
                rich.Text = downloadString;

                int posa = rich.Text.IndexOf("bids");
                if (posa != 1)
                {
                    rich.SelectionStart = posa;
                    rich.SelectionLength = rich.Text.Length - posa;
                    rich.Focus();

                    string myTexta = rich.SelectedText;

                    string bids = myTexta.Split(',')[0];
                    string bids2 = bids.Split('"')[2];

                    if (lblsell_price.InvokeRequired)
                    {
                        lblsell_price.Invoke((MethodInvoker)delegate()
                        {
                            lblsell_price.Text = bids2;
                        });
                    }
                    lowest_buy_price = bids2;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void sell()
        {
            try
            {
                if (listView1.InvokeRequired)
                {
                    listView1.Invoke((MethodInvoker)delegate()
                    {
                        for (int x = 0; x < listView1.Items.Count; x++)
                        {
                            string amount = listView1.Items[x].SubItems[0].Text;

                            if (textBox1.Text.Contains(amount))
                            {
                   
                            }
                            else
                            {
                                //MessageBox.Show("Nothing here, do a sell now, then remove to the listbox1");
                                if (lbl_sell_status.Text == "--")
                                {
                                    decimal sell_per = Convert.ToDecimal(txt_percentage.Text) / 100;
                                    decimal range_buy = Convert.ToDecimal(listView1.Items[x].SubItems[0].Text);
                                    decimal result = range_buy * sell_per;
                                    decimal f_amount = result + range_buy;
                                    sell_amount = f_amount.ToString();

                                    //add 3 percent fees
                                    decimal f_note = Convert.ToDecimal(listView1.Items[x].SubItems[1].Text);
                                    decimal fees = Convert.ToDecimal(".997");
                                    decimal final_note_ammount = f_note * fees;
                                    string NOTE = string.Format("{0:N8}", final_note_ammount);

                                    StreamReader inStream;
                                    WebRequest webRequest = WebRequest.Create("http://ifastbit.com/netlist/polotradingbot/sell.php?&key=" + txtapi.Text + "&secret=" + txtsecret.Text + "&symbol=" + txt_pair.Text + "&amt=" + NOTE + "&rate=" + sell_amount);
                                    WebResponse webresponse = webRequest.GetResponse();

                                    inStream = new StreamReader(webresponse.GetResponseStream());
                                    string res = inStream.ReadToEnd();

                                    result_sell = res;

                                    File.AppendAllText(Application.StartupPath + @"\logs.txt", DateTime.Now.ToString() + " - SELL - Rate=" + sell_amount + " - Amount=" + listView1.Items[x].SubItems[1].Text + " - Result=" + result_sell + Environment.NewLine);
                                    listView1.Items.RemoveAt(x);
                                    listBox1.Items.RemoveAt(x);
                                }
                            }
                            //Thread.Sleep(2000);
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void buy()
        {
            try
            {
                if (listView1.InvokeRequired)
                {
                    listView1.Invoke((MethodInvoker)delegate()
                    {
                        for (int x = 0; x < listView1.Items.Count; x++)
                        {

                            //MessageBox.Show(listView1.Items[x].SubItems[0].Text);
                            StreamReader inStream;
                            WebRequest webRequest = WebRequest.Create("http://ifastbit.com/netlist/polotradingbot/buy.php?&key=" + txtapi.Text + "&secret=" + txtsecret.Text + "&symbol=" + txt_pair.Text + "&amt=" + listView1.Items[x].SubItems[1].Text + "&rate=" + listView1.Items[x].SubItems[0].Text);
                            WebResponse webresponse = webRequest.GetResponse();

                            inStream = new StreamReader(webresponse.GetResponseStream());
                            string res = inStream.ReadToEnd();

                            result_buy = res;

                            //get the order number
                            string ord1 = res.Split('>')[1];
                            string ord2 = ord1.Split('"')[1];
                            string ordernum = ord2;

                            listBox1.Items.Add(ordernum);
                            File.AppendAllText(Application.StartupPath + @"\logs.txt", DateTime.Now.ToString() + " - BUY - Rate=" + listView1.Items[x].SubItems[0].Text + " - Amount=" + listView1.Items[x].SubItems[1].Text + " - Result=" + result_buy + Environment.NewLine);

                            //Thread.Sleep(2000);
                        }
                    });
                }

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void write_log()
        {
            File.AppendAllText(Application.StartupPath + @"\logs.txt", DateTime.Now.ToString() + " - BUY - Rate=" + lowest_buy_price + " - Amount=" + txt_buy_order.Text + " - Result=" + result_buy  + Environment.NewLine);
        }
        private void write_sell()
        {
            File.AppendAllText(Application.StartupPath + @"\logs.txt", DateTime.Now.ToString() + " - SELL - Rate=" + sell_amount + " - Amount=" + txt_buy_order.Text+ "-Result = " + result_sell + Environment.NewLine);
        }

        private void txt_pair_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_buy_order_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_range_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_percentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_spend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker2.WorkerSupportsCancellation == true)
            {
               lbl_run_stat.Text = "Stop";
               backgroundWorker2.CancelAsync();
               btn_start.Enabled = true;
               btn_stop.Enabled = false;
               timer1.Stop();
            }
        }

        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            object userObject = e.UserState;
            int percentage = e.ProgressPercentage;
        }

        private void BackgroundWorkerOnProgressChanged2(object sender, ProgressChangedEventArgs e)
        {
            object userObject = e.UserState;
            int percentage = e.ProgressPercentage;
        }

        private void BackgroundWorkerOnDoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; (i <= 10); i++)
            {
                if ((backgroundWorker1.CancellationPending == true))
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    while (!backgroundWorker1.CancellationPending)
                    {
                        get_open_orders();
                        getbalance();// getting balance
                        get_sell_price();//getting lowest sell price
                        Thread.Sleep(10000);
                    }
                }
            }
        }

        private void BackgroundWorkerOnDoWork2(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; (i <= 10); i++)
            {
                if ((backgroundWorker2.CancellationPending == true))
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    while (!backgroundWorker2.CancellationPending)
                    {
                       
                        get_open_orders();
                        getbalance();// getting balance
                        get_sell_price();//getting lowest sell price
                        if (lbl_balance_status.Text != "Negative")
                        {
                            if (textBox1.Text.Contains("bool(false)") || lbl_sell_status.Text =="Cancel")
                            {

                                if (lowest_buy_price != "")
                                {

                                    if (listView1.InvokeRequired)
                                    {
                                        listView1.Invoke((MethodInvoker)delegate()
                                        {
                                            listView1.Items.Clear();
                                        });
                                    }



                                    int bu = Convert.ToInt32(txt_buy_order.Text);
                                    for (int u = 1; u <= bu; u++)
                                    {

                                        decimal deviden = 0;
                                        //formula here
                                        decimal RANGE = Convert.ToDecimal(txt_range.Text);
                                        decimal low_price = Convert.ToDecimal(lowest_buy_price);
                                        decimal no_of_order = Convert.ToDecimal(txt_buy_order.Text);
                                        decimal limit_balance = Convert.ToDecimal(txt_spend.Text);
                                        decimal twentyfive = Convert.ToDecimal(0.25);
                                        decimal per = limit_balance * twentyfive;

                                        decimal BTC_AMOUNT = per / no_of_order;
                                        // get the deviden
                                        if (txt_buy_order.Text == "3")
                                        {
                                            deviden = RANGE / 2;
                                        }
                                        else if (txt_buy_order.Text == "5")
                                        {
                                            deviden = RANGE / 4;
                                        }

                                        //First buy
                                        if (u == 1)
                                        {
                                            decimal not = BTC_AMOUNT / low_price;
                                            string NOTE = string.Format("{0:N8}", not);
                                            string BTC_TOTAL_AMOUNT = string.Format("{0:N8}", BTC_AMOUNT);

                                            if (listView1.InvokeRequired)
                                            {
                                                listView1.Invoke((MethodInvoker)delegate()
                                                {
                                                    string[] items = { lowest_buy_price, NOTE, BTC_TOTAL_AMOUNT/*, ........... */};
                                                    ListViewItem lvi = new ListViewItem(items);
                                                    listView1.Items.Add(lvi);
                                                });
                                            }
                                        }

                                        //2nd buy
                                        decimal PRICE2 = low_price - deviden;
                                        decimal not2 = BTC_AMOUNT / PRICE2;
                                        string NOTE2 = string.Format("{0:N8}", not2);
                                        string BTC_TOTAL_AMOUNT2 = string.Format("{0:N8}", BTC_AMOUNT);

                                        if (u == 2)
                                        {

                                            if (listView1.InvokeRequired)
                                            {
                                                listView1.Invoke((MethodInvoker)delegate()
                                                {
                                                    string[] items = { PRICE2.ToString(), NOTE2, BTC_TOTAL_AMOUNT2/*, ........... */};
                                                    ListViewItem lvi = new ListViewItem(items);
                                                    listView1.Items.Add(lvi);
                                                });
                                            }
                                        }

                                        //3rd buy
                                        decimal PRICE3 = PRICE2 - deviden;
                                        decimal not3 = BTC_AMOUNT / PRICE3;
                                        string NOTE3 = string.Format("{0:N8}", not3);
                                        string BTC_TOTAL_AMOUNT3 = string.Format("{0:N8}", BTC_AMOUNT);
                                        if (u == 3)
                                        {

                                            if (listView1.InvokeRequired)
                                            {
                                                listView1.Invoke((MethodInvoker)delegate()
                                                {
                                                    string[] items = { PRICE3.ToString(), NOTE3, BTC_TOTAL_AMOUNT3/*, ........... */};
                                                    ListViewItem lvi = new ListViewItem(items);
                                                    listView1.Items.Add(lvi);
                                                });
                                            }
                                        }

                                        if (txt_buy_order.Text == "5")
                                        {
                                            //4th buy
                                            decimal PRICE4 = PRICE3 - deviden;
                                            decimal not4 = BTC_AMOUNT / PRICE4;
                                            string NOTE4 = string.Format("{0:N8}", not4);
                                            string BTC_TOTAL_AMOUNT4 = string.Format("{0:N8}", BTC_AMOUNT);
                                            if (u == 3)
                                            {

                                                if (listView1.InvokeRequired)
                                                {
                                                    listView1.Invoke((MethodInvoker)delegate()
                                                    {
                                                        string[] items = { PRICE4.ToString(), NOTE4, BTC_TOTAL_AMOUNT4/*, ........... */};
                                                        ListViewItem lvi = new ListViewItem(items);
                                                        listView1.Items.Add(lvi);
                                                    });
                                                }
                                            }

                                            //4th buy
                                            decimal PRICE5 = PRICE4 - deviden;
                                            decimal not5 = BTC_AMOUNT / PRICE5;
                                            string NOTE5 = string.Format("{0:N8}", not5);
                                            string BTC_TOTAL_AMOUNT5 = string.Format("{0:N8}", BTC_AMOUNT);
                                            if (u == 3)
                                            {

                                                if (listView1.InvokeRequired)
                                                {
                                                    listView1.Invoke((MethodInvoker)delegate()
                                                    {
                                                        string[] items = { PRICE5.ToString(), NOTE5, BTC_TOTAL_AMOUNT5/*, ........... */};
                                                        ListViewItem lvi = new ListViewItem(items);
                                                        listView1.Items.Add(lvi);
                                                    });
                                                }
                                            }
                                        }
                                    }
                                }

                                //total the listview1
                                if (listView1.InvokeRequired)
                                {
                                    listView1.Invoke((MethodInvoker)delegate()
                                    {
                                        decimal value = 0;
                                        for (int x = 0; x < listView1.Items.Count; x++)
                                        {
                                            value += Convert.ToDecimal(listView1.Items[x].SubItems[2].Text);
                                        }

                                        lbl_buy_total.Text = value.ToString();

                                        decimal bal = Convert.ToDecimal("0.2");
                                        decimal lbal = Convert.ToDecimal(txt_spend.Text);
                                        decimal balance = bal - lbal;
                                        total_blance.Text = balance.ToString();

                                        decimal tot = Convert.ToDecimal(lbl_buy_total.Text);

                                        if (balance <= tot)
                                        {
                                            lbl_balance_status.Text = "Negative";
                                        }
                                    });
                                }

                                buy();//buy now the listview post!
                                if (lbl_sell_status.InvokeRequired)
                                {
                                    lbl_sell_status.Invoke((MethodInvoker)delegate()
                                    {
                                        lbl_sell_status.Text = "--";//back to normal the cancel status
                                    });
                                }
                               
                                Thread.Sleep(30000);
                            }
                            else //Sell here
                            {
                                sell();
                            }
                        }
                        else
                        {
                            if (backgroundWorker2.WorkerSupportsCancellation == true)
                            {
                                lbl_run_stat.Text = "Stop";
                                backgroundWorker2.CancelAsync();
                                btn_start.Enabled = true;
                                btn_stop.Enabled = false;
                            }
                            if (backgroundWorker1.WorkerSupportsCancellation == true)
                            {
                                lbl_run_stat.Text = "Stop";
                                backgroundWorker1.CancelAsync();
                                btn_start.Enabled = true;
                                btn_stop.Enabled = false;
                            }
                            timer1.Stop();
                            MessageBox.Show("Max amount btc spend reach!");
                        }
                    }
                }
            }
        }

        private void get_open_orders()
        {
            try
            {
                StreamReader inStream;
                WebRequest webRequest = WebRequest.Create("http://ifastbit.com/netlist/polotradingbot/open_orders.php?&key=" + txtapi.Text + "&secret=" + txtsecret.Text + "&symbol=" + txt_pair.Text);
                WebResponse webresponse = webRequest.GetResponse();

                inStream = new StreamReader(webresponse.GetResponseStream());
                string res = inStream.ReadToEnd();

                if (textBox1.InvokeRequired)
                {
                    textBox1.Invoke((MethodInvoker)delegate()
                    {
                        textBox1.Text = res;
                    });
                }
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cancel_order();
            if (txtapi.Text != "" || txtsecret.Text != "")
            {
                string[] lines = {txtapi.Text, txtsecret.Text};
                System.IO.File.WriteAllLines(Application.StartupPath + "\\config.dat", lines);

                MessageBox.Show("Api info successfully saved.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process.Start("notepad.exe", Application.StartupPath + "\\logs.txt");
        }

        private void cancel_order()
        {
            try
            {
               int val= listBox1.Items.Count;
               if (val > 0)
               {
                   foreach (string i in listBox1.Items)
                   {

                       WebClient client = new WebClient();
                       client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                       string downloadString = client.DownloadString("http://ifastbit.com/netlist/polotradingbot/cancel_order.php?&key=" + txtapi.Text + "&secret=" + txtsecret.Text + "&symbol=" + txt_pair.Text + "&order=" + i);

                       RichTextBox rich = new RichTextBox();
                       rich.Text = downloadString;

                       File.AppendAllText(Application.StartupPath + @"\logs.txt", DateTime.Now.ToString() + " - Cancel buy order  - Result=" + downloadString + Environment.NewLine);

                       if (downloadString.Contains("success"))
                       {
                           lbl_sell_status.Text = "Cancel";
                       }

                       //Thread.Sleep(3000);
                   }
                   listBox1.Items.Clear();
               }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cancel_order();
        }

        private void txt_cancelbuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string[] lines = { txt_pair.Text, txt_buy_order.Text, txt_range.Text, txt_percentage.Text, txt_spend.Text };
            System.IO.File.WriteAllLines(Application.StartupPath + "\\trade.dat", lines);

            Application.Exit();
        }

        private void load_trade()
        {
            string text1 = "";
            string text2 = "";
            string text3 = "";
            string text4= "";
            string text5 = "";

            StreamReader streamReader = File.OpenText(Application.StartupPath + "\\trade.dat");
            string text = streamReader.ReadLine();
            int num = 1;
            while (text != null)
            {
                switch (num)
                {
                    case 1:
                        text1 = text;
                        break;
                    case 2:
                        text2 = text;
                        break;
                    case 3:
                        text3 = text;
                        break;
                    case 4:
                        text4 = text;
                        break;
                    case 5:
                        text5 = text;
                        break;
                }
                num++;
                text = streamReader.ReadLine();
            }

            txt_pair.Text = text1;
            txt_buy_order.Text = text2;
                txt_range.Text = text3;
                    txt_percentage.Text = text4;
                    txt_spend.Text = text5;
            streamReader.Close();
        }
    }
}
