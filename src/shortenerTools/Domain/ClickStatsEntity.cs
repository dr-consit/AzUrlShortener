using System;
using Microsoft.Azure.Cosmos.Table;

namespace Cloud5mins.domain
{
    public class ClickStatsEntity : TableEntity
    {
        //public string Id { get; set; }
        public string Datetime { get; set; }

        public string Domain { get; set; }

        public ClickStatsEntity(){}

        public ClickStatsEntity(string vanity, string domain){
            PartitionKey = vanity;
            RowKey = Guid.NewGuid().ToString();
            Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            Domain = domain;
        }
    }


}
