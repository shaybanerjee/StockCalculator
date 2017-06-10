using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace StockCalculator
{
    class WebClientStock
    {
        WebClient wc;
        string googleStockAddress = "http://www.google.com/finance/historical?q=[-|stamp|-]&startdate=[-|startdate|-]&enddate=[-|enddate|-]&num=30&output=csv";
        
        /// <summary>
        /// Method that gets google stock data and populates dictionary
        /// keys are dates and values are StockItem objects with all fields populated
        /// </summary>
        /// <param name="marketName">
        /// Name of focus market
        /// </param>
        /// <param name="tick">
        /// Name of focus Ticker
        /// </param>
        /// <param name="start">
        /// Start time of focus
        /// </param>
        /// <param name="end">
        /// End time of focus
        /// </param>
        /// <returns>
        /// Dictionary with desired stock content
        /// </returns>
        public Dictionary<DateTime, StockItem> getGoogleStock(string marketName, string tick, DateTime start, DateTime end)
        {
            string finalUrl = googleStockAddress;
            
            finalUrl = finalUrl.Replace("[-|stamp|-]", marketName + "%3A" + tick);
            string builtStartForGoogle = start.ToString("MMM") + "+" + start.Day.ToString() + "%2C+" + start.ToString("yyyy");
            string builtEndForGoogle = end.ToString("MMM") + "+" + end.Day.ToString() + "%2C+" + end.ToString("yyyy");

            finalUrl = finalUrl.Replace("[-|startdate|-]", builtStartForGoogle);
            finalUrl = finalUrl.Replace("[-|enddate|-]", builtEndForGoogle);
            
            return dictFromData(getGoogleData(finalUrl));
        }

       /// <summary>
       /// Method retrieves google data as a string
       /// </summary>
       /// <param name="url">
       /// URL where downloadable CSV of stock data is atainable
       /// </param>
       /// <returns>
       /// returns string containing google stock data
       /// </returns>       
        private string getGoogleData(string url)
        {
            string content = ""; 
            if (!(url == ""))
            {
                using (wc = new WebClient())
                {
                    using (Stream rStream = wc.OpenRead(url))
                    {
                        using (StreamReader sreader = new StreamReader(rStream))
                        {
                            content = sreader.ReadToEnd();
                            content = content.Replace("\n", Environment.NewLine);
                        }
                    }
                }
            }
            return content;
        }

        /// <summary>
        /// method that builds dicitionary from string stock data
        /// </summary>
        /// <param name="csvContent">
        /// representes a string that was created from a csv file
        /// </param>
        /// <returns>
        /// Dictionary populated by stock data
        /// keys are dates and values are StockItem objects with fields populated
        /// </returns>
        private Dictionary<DateTime, StockItem> dictFromData(string csvContent)
        {
            Dictionary<DateTime, StockItem> Dictdata = new Dictionary<DateTime, StockItem>();
            string currLine = "";
            using (StringReader sreader = new StringReader(csvContent))
            {
                sreader.ReadLine();
                while (sreader.ReadLine() != null)
                {
                    currLine = sreader.ReadLine();
                    string[] dataSet = currLine.Split(',');

                    if (dataSet.Length >= 6)
                    {
                        StockItem stockContent = new StockItem();

                        double OpenAmmount;
                        double HighAmmount;
                        double lowAmmount;
                        double closeAmmount;
                        double volumeAmmount;
          
                        if (Double.TryParse(dataSet[1], out OpenAmmount))
                        {
                            double o = OpenAmmount;
                            stockContent.setOpen(o);
                        }
                        if (Double.TryParse(dataSet[2], out HighAmmount))
                        {
                            double ha = HighAmmount;
                            stockContent.sethighVal(ha);
                        }
                        if (Double.TryParse(dataSet[3], out lowAmmount))
                        {
                            double l = lowAmmount;
                            stockContent.setlowVal(l);
                        }
                        if (Double.TryParse(dataSet[4], out closeAmmount))
                        {

                            double c = closeAmmount;
                            stockContent.setcloseVal(c);
                        }
                        if (Double.TryParse(dataSet[5], out volumeAmmount))
                        {
                            double v = volumeAmmount;
                            stockContent.setvolumeVal(v);
                        }

                        DateTime dt; 
                        if (DateTime.TryParse(dataSet[0], out dt))
                        {
                            Dictdata.Add(dt, stockContent);
                        }
                    }
                }
                return Dictdata;
            }


        }
    }
}
