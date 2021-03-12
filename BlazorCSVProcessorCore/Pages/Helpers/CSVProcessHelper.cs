using BlazorCSVProcessorCore.Pages.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    }
}
