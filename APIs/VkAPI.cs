using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using VkNet;

namespace API_Task9.APIs
{
    public class VkAPI
    {
        private readonly VkApi _vkApi;
        private readonly WebClient _client;
        public VkAPI()
        {
            _vkApi = new VkApi();
            _client = new WebClient() {Encoding= Encoding.UTF8 };
        }
    }
}
