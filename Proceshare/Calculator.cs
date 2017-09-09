using System.Collections.Generic;
using Newtonsoft.Json;

namespace Proceshare
{
    class Calculator
    {
        static Message GetMessageFromApi()
        {
            HttpApi HttpApi = new HttpApi(HttpVerb.GET);
            Message message = JsonConvert.DeserializeObject<Message>(HttpApi.MakeRequest("api/message"));

            return message;
        }

        static string GetRawMethodFromApi(string Method)
        {
            HttpApi HttpApi = new HttpApi(HttpVerb.GET);
            string RawMethod = JsonConvert.DeserializeObject<string>(HttpApi.MakeRequest("api/" + Method));

            return RawMethod;
        }

        static List<int> Sort(List<int> Elements, string Method)
        {
            ScriptEngine engine = new ScriptEngine("jscript");
            ParsedScript parsed;
            string RawMethod = GetRawMethodFromApi(Method);
            for (var i=0; i < Elements.Count; i++) {
                for (var j=0; j < Elements.Count - 1 - i; j++) {
                    parsed = engine.Parse(RawMethod);
                    var result = parsed.CallMethod(Method, Elements[j + 1], Elements[j]);
                    if (true) {
                        Swap(ref Elements, j, j + 1);
                    }
                }
            }
            return Elements;
        }

        static void Swap(ref List<int> Elements, int FirstKey, int SecondKey)
        {
            var temp = Elements[FirstKey];
            Elements[FirstKey] = Elements[SecondKey];
            Elements[SecondKey] = temp;
        }

        public static List<int> Calculate()
        {
            Message Message = GetMessageFromApi();
            List<int> SortedElements = Sort(Message.Data, Message.Type);

            return SortedElements;
        }
    }
}
