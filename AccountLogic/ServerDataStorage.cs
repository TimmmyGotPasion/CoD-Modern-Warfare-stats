using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using CodMwStats.AccountLogic.ServerAccounts;

namespace CodMwStats.AccountLogic
{
    class ServerDataStorage
    {
        public static void SaveServerAccounts(IEnumerable<ServerAccount> accounts, string filePath)
        {
            string json = JsonConvert.SerializeObject(accounts, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static IEnumerable<ServerAccount> LoadServerAccounts(string filePath)
        {
            if (!File.Exists(filePath)) return null;
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<ServerAccount>>(json);
        }

        public static bool SaveExists(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
