using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;


namespace TestTask_bMuse
{
    [Table("Weather")]
    public class Weather
    {
        [Key]
        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("data")]
        public List<WeatherDataList> Data { get; set; }

    }

    [Table("WeatherDataList")]
    public class WeatherDataList
    {
        [Key]
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("max_temp")]
        public int MaxTemp { get; set; }

        [JsonProperty("min_temp")]
        public int MinTemp { get; set; }
    }
}



