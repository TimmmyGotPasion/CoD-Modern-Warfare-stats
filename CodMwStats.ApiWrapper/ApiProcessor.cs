using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CodMwStats.ApiWrapper.Models;

namespace CodMwStats.ApiWrapper
{
    public class ApiProcessor
    {
        public static async Task<string> GetUser(string apiUrl)
        {
            var jsonAsString = await ApiHelper.ApiClient.GetStringAsync(apiUrl);
            return jsonAsString ?? string.Empty;
        }
    }
}
