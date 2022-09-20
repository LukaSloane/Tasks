using System;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace Tasks_in_C_Sharp
{
    public static class Objecthelper
    {
        public static string Dump(this object data)
        {
            string json = JsonConvert.SerializeObject(data, (Newtonsoft.Json.Formatting) Formatting.Indented);
            Console.WriteLine(json);
            return json;
        }
    }
}