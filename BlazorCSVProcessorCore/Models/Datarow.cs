using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorCSVProcessorCore.Models
{
    public class Datarow
    {
        public List<string> DataList { get; set; }
        //transfor row data into array of data and add to data.
        public Datarow(string data)
        {
            DataList = data.Split(',').ToList();
        }

        public Datarow(List<string> data)
        {
            DataList = data;
        }
    }
}
