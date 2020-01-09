using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreWebApi.Api.Model
{
    public class ProductionOrder
    {
        public int Id { get; set; }
        public string ProductionStockNo { get; set; }
        public string OrderNo { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
