using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class UserResultsStorage
    {
        public static string path = "userResults.json";
        public static void Add(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            Save(userResults); 
        }

        public static List<User> GetAll()
        {
            if (!FileProvider.Exists(path))
            {
                return new List<User>();
            }
            var fileData = FileProvider.Show(path);

            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);

            return userResults;
        }

        static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(path, jsonData);

        }
    }
}
