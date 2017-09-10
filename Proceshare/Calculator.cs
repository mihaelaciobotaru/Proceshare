using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace Proceshare
{
    class Calculator
    {
        static Message GetMessageFromApi()
        {
            HttpApi HttpApi = new HttpApi(HttpVerb.GET);
            try {
                Message message = JsonConvert.DeserializeObject<Message>(HttpApi.MakeRequest("api/message"));
                return message;
            } catch (Exception) {
                return null;
            }
        }

        static string GetRawMethodFromApi(string Method)
        {
            try {
                HttpApi HttpApi = new HttpApi(HttpVerb.GET);
                string RawMethod = HttpApi.MakeRequest("api/function/" + Method);
                return RawMethod;
            } catch (Exception) {
                return "";
            }
           
        }

        static List<int> Sort(List<int> Elements, string Method)
        {
            ScriptEngine Engine = new ScriptEngine("jscript");
            ParsedScript Parsed;
            string RawMethod = GetRawMethodFromApi(Method);
            if (!string.IsNullOrEmpty(RawMethod)) {
                for (var i = 0; i < Elements.Count; i++) {
                    for (var j = 0; j < Elements.Count - 1 - i; j++) {
                        Parsed = Engine.Parse(RawMethod);
                        var Result = (bool)Parsed.CallMethod(Method, Elements[j + 1], Elements[j]);
                        if (Result) {
                            Swap(ref Elements, j, j + 1);
                        }
                    }
                }
                return Elements;
            }
            return new List<int>();
        }

        static void Swap(ref List<int> Elements, int FirstKey, int SecondKey)
        {
            var temp = Elements[FirstKey];
            Elements[FirstKey] = Elements[SecondKey];
            Elements[SecondKey] = temp;
        }

        public static Tuple<List<int>, string> Calculate()
        {
            try {
                Message Message = GetMessageFromApi();
                List<int> SortedElements = Sort(Message.Data, Message.Type);
                return Tuple.Create(SortedElements, Message.RequestId);
            } catch (Exception) {
                return Tuple.Create(new List<int>(), "");
            }
            
        }
    }
}
