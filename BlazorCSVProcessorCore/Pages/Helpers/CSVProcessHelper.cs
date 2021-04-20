using BlazorCSVProcessorCore.Models;
using BlazorCSVProcessorCore.Pages.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCSVProcessorCore.Pages.Helpers
{
    public static class CSVProcessHelper 
    {
        public async static Task ReaderHelper(Stream stream, List<string> list)
        {
            using (var reader=new StreamReader(stream))
            {
                await Task.Run(async() => {
                    var line =await reader.ReadLineAsync();
                    while (line!=null)
                    {
                        list.Add(line);
                        line= await reader.ReadLineAsync();
                    }
                });
            }
        }

        public static void ChangeRefTrueHelp(ref bool val)
        {
            val = true;
        }

        public static void ChangeRefFalseHelp(ref bool val)
        {
            val = false;
        }

        public static byte[] StringToByte(string str)
        {
            byte[] fileBytes = Encoding.UTF8.GetBytes(str);
            return fileBytes;           
        }

        public static byte[] StringToByte(List<string> strs)
        {
            var str = string.Empty;
            for(int i = 0; i < strs.Count; i++)
            {

                str = str + strs[i] + (i < strs.Count - 1 ? "/r/n" : "");
                
            }
            byte[] fileBytes = Encoding.UTF8.GetBytes(str);
            return fileBytes;
        }

        public static byte[] StringToByte(List<Datarow> strs)
        {
            var str = string.Empty;
            for (int i = 0; i < strs.Count; i++)
            {

                str = str + strs[i] + (i < strs.Count - 1 ? "/r/n" : "");

            }
            byte[] fileBytes = Encoding.UTF8.GetBytes(str);
            return fileBytes;
        }

        public static string FlatList(List<Datarow> strs)
        {
            var str = string.Empty;
            for (int i = 0; i < strs.Count; i++)
            {
                var line = string.Join(",", strs[i].DataList);
                str = str + line + (i < strs.Count - 1 ? Environment.NewLine : "");

            }

            return str;
        }
    }
}
