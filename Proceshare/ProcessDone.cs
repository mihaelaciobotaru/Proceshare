using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Proceshare
{
    class ProcessDone
    {
        static RewardMessage GetMessageFromApi(Tuple<List<int>, string> Result)
        {
            if (Result.Item1.Count > 0) {
                MessageResponse Response = new MessageResponse();
                {
                    Response.username = "test.test";
                    Response.data = Result.Item1;
                    Response.requestId = Result.Item2;
                }
                HttpApi HttpApi = new HttpApi(HttpVerb.POST, JsonConvert.SerializeObject(Response));
                try {
                    RewardMessage message = JsonConvert.DeserializeObject<RewardMessage>(HttpApi.MakeRequest("api/message/response"));
                    return message;
                } catch (Exception) {
                    return null;
                }
            }
            else {
                return null;
            }
            
        }

        public static float GetReward(Tuple<List<int>, string> Result)
        {
            RewardMessage Message = GetMessageFromApi(Result);
            if (Message is RewardMessage) {
                return Message.reward;
            }
            return 0;
        }
    }
}
