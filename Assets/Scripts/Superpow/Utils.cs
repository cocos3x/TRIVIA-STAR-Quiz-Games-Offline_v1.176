using UnityEngine;

namespace Superpow
{
    public class Utils
    {
        // Methods
        public static int GetNumLevels(int world, int chapter)
        {
            return 0;
        }
        public static int GetNumChapters(int world, bool forceResources = False)
        {
            return 0;
        }
        public static int GetNumWorlds(bool forceResources = False)
        {
            return 1;
        }
        public static void SaveAllLevelsForCurrentGame(System.Collections.Generic.List<object> responseObject)
        {
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        public static void SaveLevelsFromChaptersCurrentGame(System.Collections.Generic.List<object> chapters, string language = "")
        {
            GameBehavior val_1 = App.getBehavior;
            string val_2 = Superpow.Utils.ConvertLangugaeServerToClient(serverLanguage:  language);
            if(0 == 0)
            {
                
            }
        
        }
        public static string ConvertLangugaeServerToClient(string serverLanguage)
        {
            if((System.String.op_Equality(a:  serverLanguage, b:  1206204416)) != false)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  serverLanguage, b:  -135011984)) == false)
            {
                    "en" = serverLanguage;
            }
        
        }
        public Utils()
        {
        
        }
    
    }

}
