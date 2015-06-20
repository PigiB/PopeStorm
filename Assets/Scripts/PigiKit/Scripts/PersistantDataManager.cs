//using System.Collections;
//using System.IO;
//using System.Text;
//using Newtonsoft.Json;
//using UnityEngine;

//public static class PersistantDataManager
//{
//    private static string _json;

//    static PersistantDataManager()
//    {
        
//    }

//    public static T LoadJson<T>(string path)
//    {
//        return JsonConvert.DeserializeObject<T>(LoadText(path));
//    }

//    private static string LoadText(string path)
//    {
//        // Open file for reading
//        var streamReader = new StreamReader(path);
//        var stringBuilder = new StringBuilder();

//        var line = streamReader.ReadLine();
//        while (line != null)
//        {
//            stringBuilder.Append(line);
//            line = streamReader.ReadLine();
//        }

//        return stringBuilder.ToString();
//    }
//}