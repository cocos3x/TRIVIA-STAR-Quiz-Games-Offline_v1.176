using UnityEngine;

namespace SLC.Minigames
{
    public static class MinigamesKnobsManager
    {
        // Fields
        public static System.Action<twelvegigs.storage.JsonDictionary> OnKnobsRecieved;
        private const string defaultKnobData = "{\"meta\": {\"versions\": {\"knobs\": 0000 } }, \"data\": {\"knobs\": {} } }";
        private static string rawKnobs;
        private static bool requestingEconData;
        
        // Methods
        private static string RetrieveRawKnobs()
        {
            var val_3;
            SLC.Minigames.MinigamesKnobsManager.RequestEconData();
            if((System.String.IsNullOrEmpty(value:  SLC.Minigames.MinigamesKnobsManager.rawKnobs)) != false)
            {
                    string val_2 = UnityEngine.PlayerPrefs.GetString(key:  910932816, defaultValue:  910932592);
                val_3 = null;
                val_3 = null;
                SLC.Minigames.MinigamesKnobsManager.rawKnobs = "mg_knbs";
            }
            else
            {
                    val_3 = null;
            }
            
            val_3 = null;
        }
        private static void RequestEconData()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            if(SLC.Minigames.MinigamesKnobsManager.requestingEconData == true)
            {
                    return;
            }
            
            val_5 = 1152921505054081032;
            SLC.Minigames.MinigamesKnobsManager.requestingEconData = true;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1383323792, value:  -1953384624);
            Player val_2 = App.Player;
            Add(key:  -1824276800, value:  33449456);
            val_6 = null;
            val_6 = null;
            System.Action<System.Threading.Tasks.Task, System.Object> val_3 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(911044912));
            App.networkManager.DoGet(path:  911045936, onCompleteFunction:  7507968, destroy:  false, immediate:  false, getParams:  null, timeout:  20);
        }
        private static void OnEconDataRequestComplete(string apiCall, System.Collections.Generic.Dictionary<string, object> response)
        {
            var val_11;
            var val_13;
            if((response != 0) && ((response.ContainsKey(key:  1616271776)) != false))
            {
                    object val_2 = response.Item[1616271776];
                string val_3 = response.ToString();
                if((System.Boolean.Parse(value:  response)) != false)
            {
                    string val_5 = MiniJSON.Json.Serialize(obj:  response);
                val_11 = null;
                val_11 = null;
                SLC.Minigames.MinigamesKnobsManager.rawKnobs = response;
                UnityEngine.PlayerPrefs.SetString(key:  910932816, value:  SLC.Minigames.MinigamesKnobsManager.rawKnobs);
                bool val_6 = PrefsSerializationManager.SavePlayerPrefs();
                if(SLC.Minigames.MinigamesKnobsManager.defaultKnobData != null)
            {
                    object val_7 = MiniJSON.Json.Deserialize(json:  SLC.Minigames.MinigamesKnobsManager.rawKnobs);
                twelvegigs.storage.JsonDictionary val_8 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  SLC.Minigames.MinigamesKnobsManager.rawKnobs);
                twelvegigs.storage.JsonDictionary val_9 = getJsonDictionary(key:  1658600960);
                twelvegigs.storage.JsonDictionary val_10 = getJsonDictionary(key:  -309557360);
                SLC.Minigames.MinigamesKnobsManager.defaultKnobData.Invoke(obj:  458731520);
            }
            
            }
            
            }
            
            val_13 = null;
            val_13 = null;
            SLC.Minigames.MinigamesKnobsManager.requestingEconData = false;
        }
        public static twelvegigs.storage.JsonDictionary GetKnobs()
        {
            string val_1 = SLC.Minigames.MinigamesKnobsManager.RetrieveRawKnobs();
            object val_2 = MiniJSON.Json.Deserialize(json:  447229952);
            twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  447229952);
            twelvegigs.storage.JsonDictionary val_4 = getJsonDictionary(key:  1658600960);
            if(null != 0)
            {
                    return getJsonDictionary(key:  -309557360);
            }
            
            return getJsonDictionary(key:  -309557360);
        }
        private static MinigamesKnobsManager()
        {
        
        }
    
    }

}
