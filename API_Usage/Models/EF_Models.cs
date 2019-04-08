using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_Usage.Models
{
    public class Company
    {
        [Key]
        public string symbol { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public bool isEnabled { get; set; }
        public string type { get; set; }
        public string iexId { get; set; }
        public List<Equity> Equities { get; set; }
    }

    public class Equity
    {
        public int EquityId { get; set; }
        public string date { get; set; }
        public float open { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float close { get; set; }
        public int volume { get; set; }
        public int unadjustedVolume { get; set; }
        public float change { get; set; }
        public float changePercent { get; set; }
        public float vwap { get; set; }
        public string label { get; set; }
        public float changeOverTime { get; set; }
        public string symbol { get; set; }
    }

    public class ChartRoot
    {
        public Equity[] chart { get; set; }
    }

    public class Top_Gainers
    {
        public int ID { get; set; }
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string primaryExchange { get; set; }
        public string sector { get; set; }
        public string calculationPrice { get; set; }
        public float? open { get; set; }
        public long? openTime { get; set; }
        public float? close { get; set; }
        public long? closeTime { get; set; }
        public float? high { get; set; }
        public float? low { get; set; }
        public float? latestPrice { get; set; }
        public string latestSource { get; set; }
        public string latestTime { get; set; }
        public long? latestUpdate { get; set; }
        public int latestVolume { get; set; }
        public float? iexRealtimePrice { get; set; }
        public int? iexRealtimeSize { get; set; }
        public long? iexLastUpdated { get; set; }
        public float? delayedPrice { get; set; }
        public long? delayedPriceTime { get; set; }
        public float? extendedPrice { get; set; }
        public float? extendedChange { get; set; }
        public float? extendedChangePercent { get; set; }
        public long? extendedPriceTime { get; set; }
        public float? previousClose { get; set; }
        public float? change { get; set; }
        public float? changePercent { get; set; }
        public float? iexMarketPercent { get; set; }
        public int? iexVolume { get; set; }
        public int avgTotalVolume { get; set; }
        public int? iexBidPrice { get; set; }
        public int? iexBidSize { get; set; }
        public int? iexAskPrice { get; set; }
        public int? iexAskSize { get; set; }
        public long? marketCap { get; set; }
        public float? peRatio { get; set; }
        public float week52High { get; set; }
        public float week52Low { get; set; }
        public float ytdChange { get; set; }
        
    }

    public class Sector
    {
        public int ID { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public float performance { get; set; }
        public long lastUpdated { get; set; }
    }

    public class FinancialList
    {

        [Key]
        public int ID { get; set; }
        public string symbol { get; set; }
        public List<Financial> financials { get; set; }
    }

    public class Financial
    {

        [Key]
        public int ID { get; set; }
        public string reportDate { get; set; }
        public long grossProfit { get; set; }
        public long costOfRevenue { get; set; }
        public long operatingRevenue { get; set; }
        public long totalRevenue { get; set; }
        public long operatingIncome { get; set; }
        public long netIncome { get; set; }
        public long researchAndDevelopment { get; set; }
        public long operatingExpense { get; set; }
        public long currentAssets { get; set; }
        public long totalAssets { get; set; }
        public long totalLiabilities { get; set; }
        public long currentCash { get; set; }
        public long currentDebt { get; set; }
        public long totalCash { get; set; }
        public long totalDebt { get; set; }
        public long shareholderEquity { get; set; }
        public long cashChange { get; set; }
        public long cashFlow { get; set; }
        public string operatingGainsLosses { get; set; }
    }

    public class News
    {

        [Key]
        public int ID { get; set; }
        public string Datetime { get; set; }
        public string Headline { get; set; }
        public string Source { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        public News[] news { get; set; }
    }
}