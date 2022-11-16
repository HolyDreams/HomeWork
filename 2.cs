using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace HomeWork
{
    //Следующие задание такое, используя HttpClient сделать запрос на этот адрес
    //https://data.townofcary.org/api/records/1.0/search/?dataset=points-of-interest&q=&facet=owner&facet=owntype&facet=featurecode&facet=descript

    //в ответ получить json и при помощи библиотеки Newtonsoft(подключаем через nuget) прочитать блок records, т.е.конечный результат — это список(List).
    public class Record
    {
    }
    public class Program
    {

        static async Task Main(string[] args)
        {
            var http = new HttpClient();
            var url = http.GetAsync("https://data.townofcary.org/api/records/1.0/search/?dataset=points-of-interest&q=&facet=owner&facet=owntype&facet=featurecode&facet=descript").Result.Content.ReadAsStringAsync().Result;
            var json = JObject.Parse(url);
            var record = json["records"].Select(x => new
            {
                DatasetID = (string)x["datasetid"],
                RecordID = (string)x["recordid"],
                Fields = new
                {
                    FeatureCode = (string)x["fields"]["featurecode"],
                    Name = (string)x["fields"]["name"],
                    Geo_Shape = new
                    {
                        Coordinates = x["fields"]["geo_shape"]["coordinates"].Select(q => (double)q),
                        Type = (string)x["fields"]["geo_shape"]["type"],
                    },
                    Geo_Point_2D = x["fields"]["geo_point_2d"].Select(q => (double)q),
                    Owner = (string)x["fields"]["owner"],
                    OwnType = (string)x["fields"]["owntype"],
                    FullAddr = (string)x["fields"]["fulladdr"],
                    Geometry = new
                    {
                        Type = (string)x["fields"]["geometry"]["type"],
                        Coordinates = x["fields"]["geometry"]["coordinates"].Select(q => (double)q),
                    },
                    Record_Timestamp = (DateTime)x["fields"]["record_timestamp"],
                }
            }).ToList();


        }
    }
}
