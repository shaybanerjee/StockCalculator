using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net;


namespace StockCalculator
{
    public partial class Form1 : Form
    {
        BackgroundWorker bw = new BackgroundWorker();
        private string stockData = "";
        public string expression = "";
        List<Dictionary<DateTime, StockItem>> wDictList = new List<Dictionary<DateTime, StockItem>>();
        List<string> wStringList = new List<string>();
        Dictionary<DateTime, StockItem> d = new Dictionary<DateTime, StockItem>();
        BackgroundWorker backWorker = new BackgroundWorker();
        int openCount = 0;

        /// <summary>
        /// Form Ctor Initializing (set Size) and create a dark background
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.Width = this.Width / 2;
            this.Text = "Calculator";
        }

        /// <summary>
        /// Event that builds expression when user clicks on buttons
        /// </summary>
        /// <param name="sender">
        /// Button that invoked the event
        /// </param>
        /// <param name="e">
        /// Events Arguments
        /// </param>
        private void ButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Result.Text == "0")
            {
                Result.Text = b.Text;
            }
            else
            {
                Result.Text += b.Text;
            }
            expression += b.Text;
        }

        /// <summary>
        /// Event that builds expression when user clicks on a operator button
        /// </summary>
        /// <param name="sender">
        /// Button that invoked the event
        /// </param>
        /// <param name="e">
        /// Event Arguments
        /// </param>
        private void OperatorClick(object sender, EventArgs e)
        {
            if (expression.Length != 0)
            {
                int l = expression.Length - 1;
                if (expression[l] != '+' && expression[l] != '-' && expression[l] != '*' && expression[l] != '/' && expression[l] != '(')
                {
                    Button b = (Button)sender;
                    Result.Text += b.Text;
                    expression += b.Text;
                }
            }
        }

        /// <summary>
        /// Event that clears expression when user clicks on ce button
        /// </summary>
        /// <param name="sender">
        /// Button that invoked the event
        /// </param>
        /// <param name="e">
        /// Event Arguments
        /// </param>
        private void ButtCE_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
    
            expression = "";
        }

        /// <summary>
        /// Event that evaluates the expression when user clicks equal button
        /// </summary>
        /// <param name="sender">
        /// Button that invoked the event
        /// </param>
        /// <param name="e">
        /// Event Arguments
        /// </param>
        private void ButtEq_Click(object sender, EventArgs e)
        {
            if (!Result.Text.Contains("+") && !Result.Text.Contains("-") && !Result.Text.Contains("*") && !Result.Text.Contains("/"))
            {
                double val = Convert.ToDouble(expression) * 2;
                Result.Text = Convert.ToString(val);
            }
            else
            {
                while (true)
                {
                    Dictionary<int, int> d = get_brack(expression);
                    if (d.Count() == 0)
                    {
                        KeyValuePair<int, int> kv = new KeyValuePair<int, int>(0, expression.Length - 1);
      
                        expression = simplify_exp(expression, kv);
                        Result.Text = expression;


                        break;
                    }
                    else
                    {

                        expression = simplify_exp(expression, d.Last());
                    }
                }
            }
        }

        /// <summary>
        /// method that takes a mathimatical expression as a string and simplifies it into a
        /// simpler expression
        /// </summary>
        /// <param name="s">
        /// s is the expression that will be simplified 
        /// </param>
        /// <param name="kv">
        /// kv is stores the start and end indexes of most nested parentheses
        /// </param>
        /// <returns>
        /// simplified expression
        /// </returns>
        public static string simplify_exp(string s, KeyValuePair<int, int> kv)
        {
            string exp = "";
            for (int i = kv.Key; i <= kv.Value; ++i)
            {
                exp += s[i];
            }
            double currTotal = 0;
            char currSymb = new char();
            for (int i = 0; i < exp.Length; ++i)
            {
                if (exp[i] == '+')
                {
                    currSymb = '+';
                }
                else if (exp[i] == '-')
                {
                    currSymb = '-';
                }
                else if (exp[i] == '*')
                {
                    currSymb = '*';
                }
                else if (exp[i] == '/')
                {
                    currSymb = '/';
                }
                else if (currSymb == '+')
                {
                    string val = "";
                    while (i < exp.Length && exp[i] != '+' && exp[i] != '-' && exp[i] != '*' && exp[i] != '/' && exp[i] != ')' && exp[i] != '(')
                    {
                        val += exp[i];
                        ++i;
                    }
                    --i;
                    currTotal += Convert.ToDouble(val);
                    currSymb = '$';
                }
                else if (currSymb == '*')
                {
                    string val = "";
                    while (i < exp.Length && exp[i] != '+' && exp[i] != '-' && exp[i] != '*' && exp[i] != '/' && exp[i] != ')' && exp[i] != '(')
                    {
                        val += exp[i];
                        ++i;
                    }
                    --i;
                    currTotal *= Convert.ToDouble(val);
                    currSymb = '$';
                }
                else if (currSymb == '-')
                {
                    string val = "";
                    while (i < exp.Length && exp[i] != '+' && exp[i] != '-' && exp[i] != '*' && exp[i] != '/' && exp[i] != ')' && exp[i] != '(')
                    {
                        val += exp[i];
                        ++i;
                    }
                    --i;
                    currTotal -= Convert.ToDouble(val);
                    currSymb = '$';
                }
                else if (currSymb == '/')
                {
                    string val = "";
                    while (i < exp.Length && exp[i] != '+' && exp[i] != '-' && exp[i] != '*' && exp[i] != '/' && exp[i] != ')' && exp[i] != '(')
                    {
                        val += exp[i];
                        ++i;
                    }
                    --i;
                    currTotal /= Convert.ToDouble(val);
                    currSymb = '$';
                }
                else if (exp[i] != '(' && exp[i] != ')')
                {
                    string val = "";
                    while (i < exp.Length && exp[i] != '+' && exp[i] != '-' && exp[i] != '*' && exp[i] != '/' && exp[i] != ')' && exp[i] != '(')
                    {
                        val += exp[i];
                        ++i;
                    }
                    --i;

                    currTotal = Convert.ToDouble(val);
                }
            }

            if (kv.Value != s.Length && kv.Key != 0)
            {
                s = s.Substring(0, kv.Key) + currTotal.ToString() + s.Substring(kv.Value + 1);
            }
            else if (kv.Value != s.Length && kv.Key == 0)
            {
                s = currTotal.ToString() + s.Substring(kv.Value + 1);
            }
            else if (kv.Value == s.Length && kv.Key != 0)
            {
                s = s.Substring(0, kv.Key) + currTotal.ToString();
            }
            else
            {
                s = s.Substring(0, kv.Key) + currTotal.ToString();
            }

            return s;
        }

        /// <summary>
        /// method that gets all indexes of parenthesis in an expression
        /// keys are the starting indexes and values are the ending indexes
        /// </summary>
        /// <param name="expression">
        /// string mathimatical expression
        /// </param>
        /// <returns>
        /// Dictionary containing Key Value Pairs storing start/end indexes
        /// </returns>
        public static Dictionary<int, int> get_brack(string expression)
        {
            Dictionary<int, int> di = new Dictionary<int, int>();
            int length = expression.Length;
            for (int i = 0; i < length; ++i)
            {
                if (expression[i] == '(')
                {
                    di[i] = -1;
                }
                else if (expression[i] == ')')
                {
                    foreach (KeyValuePair<int, int> kv in di.Reverse())
                    {
                        if (kv.Value == -1)
                        {
                            di[kv.Key] = i;
                            break;
                        }
                    }
                }
            }

            return di;
        }

        /// <summary>
        /// Event that is invoked when a bracket button is clicked
        /// </summary>
        /// <param name="sender">
        /// Button that invokes the event
        /// </param>
        /// <param name="e">
        /// Event Arguments
        /// </param>
        private void brackClick(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            int l = expression.Length - 1;

            if (Result.Text == "0" && b.Text != ")")
            {
                openCount += 1;
                Result.Text = b.Text;
                expression = b.Text;
            }
            else if (b.Text == ")")
            {
                if (openCount > 0)
                {
                    Result.Text += b.Text;
                    expression += b.Text;
                    openCount -= 1;
                }
            }
            else
            {
                Result.Text += b.Text;
                expression += b.Text;
                openCount += 1;
            }
        }

        /// <summary>
        /// gets Index 
        /// </summary>
        /// <param name="tick"></param>
        /// <returns></returns>
        public static string getIndex(string tick)
        {
            WebClient webcli;
            string content = "";
            string yahooStockAddress = @"http://download.finance.yahoo.com/d/quotes.csv?s=[-|tick|-]&f=sl1d1t1c1";
            string yahooURL = yahooStockAddress;
            yahooURL = yahooURL.Replace("[-|tick|-]", tick);
            if (yahooURL != "")
            {
                using (webcli = new WebClient())
                {
                    using (Stream rstream = webcli.OpenRead(yahooURL))
                    {
                        using (StreamReader sreader = new StreamReader(rstream))
                        {
                            content = sreader.ReadToEnd();
                            content = content.Replace("\n", Environment.NewLine);
                        }
                    }
                }
            }
            string[] vals = content.Split(',');
            return vals[4];
        }

        /// <summary>
        /// Event when invoked obtains stock data and populates a chart
        /// </summary>
        /// <param name="sender">
        /// Button that invokes the event
        /// </param>
        /// <param name="e">
        /// Event Arguments
        /// </param>
        private void FetchData_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy)
            {
                Fetcher.Enabled = false;
                Worker();
            }
            else
            {
                MessageBox.Show("Sorry, data is currently being fetched.");
            }
        }
        
        /// <summary>
        /// Method that extracts the stock data and populates a chart
        /// </summary>
        private void Worker()
        {

            DateTime twentyLength = DateTime.Now.Subtract(TimeSpan.FromDays(70));
            StringBuilder myString = new StringBuilder();
            WebClientStock webStock = new WebClientStock();
            Dictionary<DateTime, StockItem> retrievedStockData = new Dictionary<DateTime, StockItem>();
            if (stockTitle.Text == "")
            {
                MessageBox.Show("Please, input a New York Stock Exchange (NYSE) Stock.");
            }
            else
            {
                string index = getIndex(stockTitle.Text);
                d = webStock.getGoogleStock("NYSE", stockTitle.Text, twentyLength, DateTime.Now);
                wDictList.Add(d);
                wStringList.Add(stockTitle.Text);
                foreach (KeyValuePair<DateTime, StockItem> sitem in d)
                {
                    Console.WriteLine("Date: {0}", sitem.Key);
                    Console.WriteLine("High Value: {0}", sitem.Value.getHighVal());
                    Console.WriteLine("Low Value: {0}", sitem.Value.getLowVal());
                    Console.WriteLine("Close Value: {0}", sitem.Value.getCloseVal());
                    Console.WriteLine("Volume Value: {0}", sitem.Value.getVolVal());
                    Console.WriteLine("Index Value: {0}", index);

                }

                chart.Series.Clear();
                chart.BackColor = Color.Transparent;
                chart.ChartAreas[0].BackColor = Color.Transparent;
                chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.FromArgb(128, 128, 128);
                chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(128, 128, 128);
                var series1 = chart.Series.Add(stockTitle.Text + ": " + index);
                var series2 = chart.Series.Add("Points");
                chart.Legends["Legend1"].BackColor = Color.Transparent;
                chart.Legends["Legend1"].ForeColor = Color.FromArgb(128, 128, 128);
                series2.IsVisibleInLegend = false;
                
                if (chart.Titles.Count() > 0)
                {
                    chart.Titles.Clear();
                }
                System.Windows.Forms.DataVisualization.Charting.Title t = chart.Titles.Add("Open Values");
                t.ForeColor = Color.FromArgb(128, 128, 128);
                t.Font = new System.Drawing.Font("Headline", 12, FontStyle.Bold);
                button2.Text = "High";

                foreach (KeyValuePair<DateTime, StockItem> sItem in d)
                {
                    chart.Series[stockTitle.Text + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getOpenVal());
                    chart.Series["Points"].Points.AddXY(sItem.Key, sItem.Value.getOpenVal());
                    

                }
                
                chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                this.Width *= 2;
                RunWCompleted();
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Enables the fetch data button when the data has finished being obtained
        /// </summary>
        private void RunWCompleted()
        {
            Fetcher.Enabled = true;
        }

        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();
        /// <summary>
        /// event that is invoked when the cursor is moved on the chart
        /// </summary>
        /// <param name="sender">
        /// Mouse Movement that invokes the Event
        /// </param>
        /// <param name="e">
        /// Event Arguments
        /// </param>
        private void Show_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart.HitTest(pos.X, pos.Y, false, System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    DateTime val = DateTime.FromOADate(result.ChartArea.AxisX.PixelPositionToValue(pos.X));
                    tooltip.Show("[" + val.Day.ToString() + ", " + ((int)yVal).ToString() + "]", chart, pos.X, pos.Y - 15);

                }
            }
        }

        /// <summary>
        /// Event representing when the button to change the chart content is pressed
        /// </summary>
        /// <param name="sender">
        /// Button that invokes the event
        /// </param>
        /// <param name="e">
        /// Event Arguments
        /// </param>
        private void button2_Click(object sender, EventArgs e)
        {

            if (stockTitle.Text != "" && d.Count > 0)
            {
                if (button2.Text == "High")
                {
                    chart.Series.Clear();
                    chart.Titles.Clear();
                    System.Windows.Forms.DataVisualization.Charting.Title t = chart.Titles.Add("High Values:");
                    t.Font = new System.Drawing.Font("Headline", 12, FontStyle.Bold);
                    t.ForeColor = Color.FromArgb(128, 128, 128);
                    int count = 0;
                    foreach (Dictionary<DateTime, StockItem> wD in wDictList)
                    {
                        string index = getIndex(wStringList[count]);
                        var series1 = chart.Series.Add(wStringList[count] + ": " + index);
                        var series2 = chart.Series.Add(wStringList[count] + "Points");
                        chart.Legends["Legend1"].BackColor = Color.Transparent;
                        chart.Legends["Legend1"].ForeColor = Color.FromArgb(128, 128, 128);
                        series2.IsVisibleInLegend = false;
                        foreach (KeyValuePair<DateTime, StockItem> sItem in wD)
                        {
                            chart.Series[wStringList[count] + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getHighVal());
                            chart.Series[wStringList[count] + "Points"].Points.AddXY(sItem.Key, sItem.Value.getHighVal());

                        }
                        button2.Text = "Low";
                        chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                        series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        count += 1;
                    }

                }
                else if (button2.Text == "Low")
                {

                    chart.Series.Clear();
                    chart.Titles.Clear();
                    System.Windows.Forms.DataVisualization.Charting.Title t = chart.Titles.Add("Low Values:");
                    t.Font = new System.Drawing.Font("Headline", 12, FontStyle.Bold);
                    t.ForeColor = Color.FromArgb(128, 128, 128);
                    int count = 0;
                    foreach (Dictionary<DateTime, StockItem> wD in wDictList)
                    {
                        string index = getIndex(wStringList[count]);
                        var series1 = chart.Series.Add(wStringList[count] + ": " + index);
                        var series2 = chart.Series.Add(wStringList[count] + "Points");
                        chart.Legends["Legend1"].BackColor = Color.Transparent;
                        chart.Legends["Legend1"].ForeColor = Color.FromArgb(128, 128, 128);
                        series2.IsVisibleInLegend = false;
                        foreach (KeyValuePair<DateTime, StockItem> sItem in wD)
                        {
                            chart.Series[wStringList[count] + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getLowVal());
                            chart.Series[wStringList[count] + "Points"].Points.AddXY(sItem.Key, sItem.Value.getLowVal());

                        }
                        button2.Text = "Close";
                        chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                        series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        count += 1;
                    }

                }
                else if (button2.Text == "Close")
                {

                    chart.Series.Clear();
                    chart.Titles.Clear();
                    System.Windows.Forms.DataVisualization.Charting.Title t = chart.Titles.Add("Close Values:");
                    t.Font = new System.Drawing.Font("Headline", 12, FontStyle.Bold);
                    t.ForeColor = Color.FromArgb(128, 128, 128);
                    int count = 0;
                    foreach (Dictionary<DateTime, StockItem> wD in wDictList)
                    {
                        string index = getIndex(wStringList[count]);
                        var series1 = chart.Series.Add(wStringList[count] + ": " + index);
                        var series2 = chart.Series.Add(wStringList[count] + "Points");
                        chart.Legends["Legend1"].BackColor = Color.Transparent;
                        chart.Legends["Legend1"].ForeColor = Color.FromArgb(128, 128, 128);
                        series2.IsVisibleInLegend = false;
                        foreach (KeyValuePair<DateTime, StockItem> sItem in wD)
                        {
                            chart.Series[wStringList[count] + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getCloseVal());
                            chart.Series[wStringList[count] + "Points"].Points.AddXY(sItem.Key, sItem.Value.getCloseVal());

                        }
                        button2.Text = "Volume";
                        chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                        series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        count += 1;
                    }

                }
                else if (button2.Text == "Volume")
                {

                    chart.Series.Clear();
                    chart.Titles.Clear();
                    System.Windows.Forms.DataVisualization.Charting.Title t = chart.Titles.Add("Volume Values:");
                    t.Font = new System.Drawing.Font("Headline", 12, FontStyle.Bold);
                    t.ForeColor = Color.FromArgb(128, 128, 128);
                    int count = 0;
                    foreach (Dictionary<DateTime, StockItem> wD in wDictList)
                    {
                        string index = getIndex(wStringList[count]);
                        var series1 = chart.Series.Add(wStringList[count] + ": " + index);
                        var series2 = chart.Series.Add(wStringList[count] + "Points");
                        chart.Legends["Legend1"].BackColor = Color.Transparent;
                        chart.Legends["Legend1"].ForeColor = Color.FromArgb(128, 128, 128);
                        series2.IsVisibleInLegend = false;
                        foreach (KeyValuePair<DateTime, StockItem> sItem in wD)
                        {
                            chart.Series[wStringList[count] + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getVolVal());
                            chart.Series[wStringList[count] + "Points"].Points.AddXY(sItem.Key, sItem.Value.getVolVal());

                        }
                        button2.Text = "Open";
                        chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                        series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        count += 1;
                    }

                }
                else
                {
                    chart.Series.Clear();
                    chart.Titles.Clear();
                    System.Windows.Forms.DataVisualization.Charting.Title t = chart.Titles.Add("Open Values:");
                    t.Font = new System.Drawing.Font("Headline", 12, FontStyle.Bold);
                    t.ForeColor = Color.FromArgb(128, 128, 128);
                    int count = 0;
                    foreach (Dictionary<DateTime, StockItem> wD in wDictList)
                    {
                        string index = getIndex(wStringList[count]);
                        var series1 = chart.Series.Add(wStringList[count] + ": " + index);
                        var series2 = chart.Series.Add(wStringList[count] + "Points");
                        chart.Legends["Legend1"].BackColor = Color.Transparent;
                        chart.Legends["Legend1"].ForeColor = Color.FromArgb(128, 128, 128);
                        series2.IsVisibleInLegend = false;
                        foreach (KeyValuePair<DateTime, StockItem> sItem in wD)
                        {
                            chart.Series[wStringList[count] + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getHighVal());
                            chart.Series[wStringList[count] + "Points"].Points.AddXY(sItem.Key, sItem.Value.getHighVal());

                        }
                        button2.Text = "Low";
                        chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                        series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        count += 1;
                    }
                }
            }
        }

        /// <summary>
        /// Event that is invoked when user wishes to add another stock
        /// </summary>
        /// <param name="sender">
        /// Button that invokes the event
        /// </param>
        /// <param name="e">
        /// Event Arguments
        /// </param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (stockTitle.Text == "")
            {
                MessageBox.Show("Please, input a valid stock from the NYSE");
            }
            else
            {
                DateTime twentyLength = DateTime.Now.Subtract(TimeSpan.FromDays(20));
                StringBuilder myString = new StringBuilder();
                WebClientStock webStock = new WebClientStock();
                Dictionary<DateTime, StockItem> retrievedStockData = new Dictionary<DateTime, StockItem>();
                string index = getIndex(stockTitle.Text);
                d = webStock.getGoogleStock("NYSE", stockTitle.Text, twentyLength, DateTime.Now);


                var series1 = chart.Series.Add(stockTitle.Text + ": " + index);
                var series2 = chart.Series.Add(stockTitle.Text + "Points");
                series2.IsVisibleInLegend = false;
                wDictList.Add(d);
                wStringList.Add(stockTitle.Text);

                foreach (KeyValuePair<DateTime, StockItem> sItem in d)
                {
                   if (button2.Text == "High")
                    {
                        chart.Series[stockTitle.Text + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getOpenVal());
                        chart.Series[stockTitle.Text + "Points"].Points.AddXY(sItem.Key, sItem.Value.getOpenVal());
                    }
                   else if (button2.Text == "Low")
                    {
                        chart.Series[stockTitle.Text + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getHighVal());
                        chart.Series[stockTitle.Text + "Points"].Points.AddXY(sItem.Key, sItem.Value.getHighVal());
                    }
                   else if (button2.Text == "Close")
                    {
                        chart.Series[stockTitle.Text + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getLowVal());
                        chart.Series[stockTitle.Text + "Points"].Points.AddXY(sItem.Key, sItem.Value.getLowVal());
                    }
                   else if (button2.Text == "Volume")
                    {
                        chart.Series[stockTitle.Text + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getCloseVal());
                        chart.Series[stockTitle.Text + "Points"].Points.AddXY(sItem.Key, sItem.Value.getCloseVal());
                    }
                   else
                    {
                        chart.Series[stockTitle.Text + ": " + index].Points.AddXY(sItem.Key, sItem.Value.getVolVal());
                        chart.Series[stockTitle.Text + "Points"].Points.AddXY(sItem.Key, sItem.Value.getVolVal());
                    }
                }
                chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;



            }
        }

        /// <summary>
        /// Event invoked when math buttons are pressed
        /// </summary>
        /// <param name="sender">
        /// Button invoking the event
        /// </param>
        /// <param name="e">
        /// Event Arguments
        /// </param>
        private void math_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "sin")
            {
                char wLastChar = expression[expression.Length-1];
                double wLastDoub = Convert.ToDouble(wLastChar.ToString());
                double wResult = Math.Sin(wLastDoub);
                expression = expression.Remove(expression.Length - 1, 1);
                expression = expression.Insert(expression.Length, wResult.ToString());
                Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1);
                Result.Text = Result.Text.Insert(Result.Text.Length, String.Format("Sin({0})", wLastChar));
              
            }
            else if (b.Text == "cos")
            {
                char wLastChar = expression[expression.Length - 1];
                double wLastDoub = Convert.ToDouble(wLastChar.ToString());
                double wResult = Math.Cos(wLastDoub);
                expression = expression.Remove(expression.Length - 1, 1);
                expression = expression.Insert(expression.Length, wResult.ToString());
                Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1);
                Result.Text = Result.Text.Insert(Result.Text.Length, String.Format("Cos({0})", wLastChar));
            }
            else if (b.Text == "tan")
            {
                char wLastChar = expression[expression.Length - 1];
                double wLastDoub = Convert.ToDouble(wLastChar.ToString());
                double wResult = Math.Tan(wLastDoub);
                expression = expression.Remove(expression.Length - 1, 1);
                expression = expression.Insert(expression.Length, wResult.ToString());
                Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1);
                Result.Text = Result.Text.Insert(Result.Text.Length, String.Format("Tan({0})", wLastChar));
            }
            else if (b.Text == "ln")
            {
                char wLastChar = expression[expression.Length - 1];
                double wLastDoub = Convert.ToDouble(wLastChar.ToString());
                double wResult = Math.Log(wLastDoub);
                expression = expression.Remove(expression.Length - 1, 1);
                expression = expression.Insert(expression.Length, wResult.ToString());
                Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1);
                Result.Text = Result.Text.Insert(Result.Text.Length, String.Format("ln({0})", wLastChar));
            }
            else if (b.Text == "Log")
            {
                char wLastChar = expression[expression.Length - 1];
                double wLastDoub = Convert.ToDouble(wLastChar.ToString());
                double wResult = Math.Log10(wLastDoub);
                expression = expression.Remove(expression.Length - 1, 1);
                expression = expression.Insert(expression.Length, wResult.ToString());
                Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1);
                Result.Text = Result.Text.Insert(Result.Text.Length, String.Format("Log({0})", wLastChar));
            }
            else if (b.Text == "√")
            {
                char wLastChar = expression[expression.Length - 1];
                double wLastDoub = Convert.ToDouble(wLastChar.ToString());
                double wResult = Math.Sqrt(wLastDoub);
                expression = expression.Remove(expression.Length - 1, 1);
                expression = expression.Insert(expression.Length, wResult.ToString());
                Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1);
                Result.Text = Result.Text.Insert(Result.Text.Length, String.Format("Sqrt({0})", wLastChar));
            }
            else if (b.Text == "x!")
            {
                char wLastChar = expression[expression.Length - 1];
                int val = Convert.ToInt32(wLastChar.ToString());
                int fact = factorial(val);
                expression = expression.Remove(expression.Length - 1, 1);
                expression = expression.Insert(expression.Length, fact.ToString());
                Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1);
                Result.Text = Result.Text.Insert(Result.Text.Length, String.Format("{0}!", wLastChar));
            }
            else if (b.Text == "EXP")
            {
                char wLastChar = expression[expression.Length - 1];
                double wLastDoub = Convert.ToDouble(wLastChar.ToString());
                double wResult = Math.Exp(wLastDoub);
                expression = expression.Remove(expression.Length - 1, 1);
                expression = expression.Insert(expression.Length, wResult.ToString());
                Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1);
                Result.Text = Result.Text.Insert(Result.Text.Length, String.Format("Exp({0})", wLastChar));

            }
        }
        /// <summary>
        /// Method that gets the nth factorial
        /// </summary>
        /// <param name="n">
        /// Integer that represent the factorial we wish to achieve
        /// </param>
        /// <returns>
        /// the n'th factorial
        /// </returns>
        private int factorial(int n)
        {
            if (n == 0)
            {
                return 1; 
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

        /// <summary>
        /// Method that calculates the final value of an expression
        /// </summary>
        /// <param name="expression">
        /// String mathimatical expression
        /// </param>
        /// <returns>
        /// returns the final value of a mathimatical expressionS
        /// </returns>
        private double eq(string expression)
        {
            if (!Result.Text.Contains("+") && !Result.Text.Contains("-") && !Result.Text.Contains("*") && !Result.Text.Contains("/"))
            {
                double val = Convert.ToDouble(expression) * 2;
                expression = Convert.ToString(val);
            }
            else
            {
                while (true)
                {
                    Dictionary<int, int> d = get_brack(expression);
                    if (d.Count() == 0)
                    {
                        KeyValuePair<int, int> kv = new KeyValuePair<int, int>(0, expression.Length - 1);

                        expression = simplify_exp(expression, kv);


                        break;
                    }
                    else
                    {

                        expression = simplify_exp(expression, d.Last());
                    }
                }
            }
            return Convert.ToDouble(expression);
        }
    }
}
