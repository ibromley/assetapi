using System.Collections.Generic;

namespace AssetApi.Models
{
    public class AssetItem
    {
        public long Id { get; set;}
        public string name { get; set;}
        public List<DataPoint> projectiondata { get; set; }
        public string assettitle { get ; set; }
        public string maintext { get; set; }
        public string splashimage { get; set; }
    }

    public class DataPoint
    {
        public long Id { get; set; }
        public long year { get; set; }
        public double value { get; set; }
    }



}