﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Weibo.Models
{

    public partial class AlimamaShopHotData
    {
        public class Paginator2
        {
            public int length { get; set; }
            public int offset { get; set; }
            public int page { get; set; }
            public int beginIndex { get; set; }
            public int endIndex { get; set; }
            public int items { get; set; }
            public int lastPage { get; set; }
            public int itemsPerPage { get; set; }
            public int previousPage { get; set; }
            public int nextPage { get; set; }
            public int pages { get; set; }
            public int firstPage { get; set; }
            public int[] slider { get; set; }
        }
    }

    public partial class AlimamaShopHotData
    {
        public class Pagelist2
        {
            public int groupId { get; set; }
            public string commentCount { get; set; }
            public int userType { get; set; }
            public string pictUrl { get; set; }
            public string title { get; set; }
            public object auctionId { get; set; }
            public double commissionRate { get; set; }
            public double reservePrice { get; set; }
            public double zkPrice { get; set; }
            public string nick { get; set; }
            public int biz30day { get; set; }
            public int totalNum { get; set; }
            public double totalFee { get; set; }
            public string auctionUrl { get; set; }
            public int rootCat { get; set; }
            public double zkRate { get; set; }
            public bool specialAuctionCommission { get; set; }
            public bool useSpecialCampaignCommission { get; set; }
            public long userNumberId { get; set; }
            public string zkType { get; set; }
            public double groupCommission { get; set; }
            public double groupRate { get; set; }
            public bool hasCommonCampaign { get; set; }
            public double commissionRatePercent { get; set; }
            public double calCommission { get; set; }
        }
    }

    public partial class AlimamaShopHotData
    {
        public class Data2
        {
            public Paginator2 paginator { get; set; }
            public string rewriteQuery { get; set; }
            public string searchUrl { get; set; }
            public Pagelist2[] pagelist { get; set; }
        }
    }

    public partial class AlimamaShopHotData
    {
        public class Info2
        {
            public object message { get; set; }
            public bool ok { get; set; }
        }
    }

    public partial class AlimamaShopHotData
    {
        public Data2 data { get; set; }
        public Info2 info { get; set; }
        public bool ok { get; set; }
        public object invalidKey { get; set; }
    }

}