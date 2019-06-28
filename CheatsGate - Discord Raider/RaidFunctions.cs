using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CheatsGate___Discord_Raider
{
    public class RaidFunctions
    {
        public static string returnstring(string returnme) { return returnme; }

        private class smessagestrings
        {
            public string content { get; set; }
            public string nonce { get; set; }
            public bool tts { get; set; }
        }



        private class caccountstrings
        {
            public string captcha_key { get; set; }
            public bool consent { get; set; }
            public string email { get; set; }
            public string fingerprint { get; set; }
            public string gift_code_sku_id { get; set; }
            public string invite { get; set; }
            public string password { get; set; }
            public string username { get; set; }
        }


        public static class funcs
        {
            public static HttpResponseMessage joinguild(string token, string invite, bool useproxy, string proxy)
            {
                HttpResponseMessage result;
                if (useproxy)
                {
                    Task<HttpResponseMessage> task = new HttpClient(new HttpClientHandler
                    {
                        Proxy = new WebProxy(proxy)
                    })
                    {
                        DefaultRequestHeaders =
                        {
                            {
                                "Authorization",
                                token
                            }
                        }
                    }.PostAsync("https://discordapp.com/api/v6/invite/" + invite, null);
                    result = task.Result;
                }
                else
                {
                    Task<HttpResponseMessage> task2 = new HttpClient
                    {
                        DefaultRequestHeaders =
                        {
                            {
                                "Authorization",
                                token
                            }
                        }
                    }.PostAsync("https://discordapp.com/api/v6/invite/" + invite, null);
                    result = task2.Result;
                }
                return result;
            }

            public static HttpResponseMessage sendmessage(string token, string channelid, string message, bool ttsenabled, bool bypassantispam)
            {
                bool flag = !bypassantispam;
                HttpResponseMessage result;
                if (flag)
                {
                    result = new HttpClient
                    {
                        DefaultRequestHeaders =
                        {
                            {
                                "Authorization",
                                token
                            }
                        }
                    }.PostAsync("https://discordapp.com/api/v6/channels/" + channelid + "/messages", new StringContent(JsonConvert.SerializeObject(new RaidFunctions.smessagestrings
                    {
                        content = message,
                        nonce = null,
                        tts = ttsenabled
                    }), Encoding.UTF8, "application/json")).Result;
                }
                else
                {
                    Random random = new Random();
                    result = new HttpClient
                    {
                        DefaultRequestHeaders =
                        {
                            {
                                "Authorization",
                                token
                            }
                        }
                    }.PostAsync("https://discordapp.com/api/v6/channels/" + channelid + "/messages", new StringContent(JsonConvert.SerializeObject(new RaidFunctions.smessagestrings
                    {
                        content = message + " " + random.Next(),
                        nonce = null,
                        tts = ttsenabled
                    }), Encoding.UTF8, "application/json")).Result;
                }
                return result;
            }
        }
    }
}
