using UnityEngine;

namespace SLC.Social
{
    public class SocialManager : MonoSingleton<SLC.Social.SocialManager>
    {
        // Fields
        private static string[] _Adjectives;
        private static string[] _Nouns;
        private const int MAX_AVATARS = 25;
        
        // Properties
        public static string ProfileName { get; }
        public static int AvatarID { get; }
        
        // Methods
        public static string GetRandomProfileName()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_7 = null;
            val_7 = null;
            if(SLC.Social.SocialManager.MAX_AVATARS != 0)
            {
                    val_8 = SLC.Social.SocialManager.MAX_AVATARS;
                val_9 = UnityEngine.Random.Range(min:  0, max:  SLC.Social.SocialManager.MAX_AVATARS + 12);
            }
            else
            {
                    val_8 = 12;
                val_9 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            int val_3 = SLC.Social.SocialManager.MAX_AVATARS + (val_9 << 2);
            if(SLC.Social.SocialManager._Nouns != null)
            {
                    val_10 = SLC.Social.SocialManager._Nouns;
                val_11 = UnityEngine.Random.Range(min:  0, max:  SLC.Social.SocialManager._Nouns + 12);
            }
            else
            {
                    val_10 = 12;
                val_11 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            System.String[] val_6 = SLC.Social.SocialManager._Nouns + (val_11 << 2);
            return System.String.Format(format:  1592589744, arg0:  (SLC.Social.SocialManager.MAX_AVATARS + (val_2) << 2) + 16, arg1:  (SLC.Social.SocialManager._Nouns + (val_5) << 2) + 16);
        }
        public static void ResetProfileName()
        {
            Player val_1 = App.Player;
            string val_2 = SLC.Social.SocialManager.GetRandomProfileName();
            Player val_3 = App.Player;
            2621448.Save(writePrefs:  true);
        }
        public static string get_ProfileName()
        {
            var val_11;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1937797680) == 0)
            {
                goto label_5;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_4 = 0.MyProfile;
            if((0.Equals(value:  -1927030288)) == false)
            {
                goto label_11;
            }
            
            label_5:
            Player val_6 = App.Player;
            if((static_value_002800A0.Equals(value:  -1927030288)) != false)
            {
                    SLC.Social.SocialManager.ResetProfileName();
            }
            
            Player val_8 = App.Player;
            val_11 = 2621448 + 152;
            return;
            label_11:
            SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_10 = 0.MyProfile;
            val_11 = 12;
        }
        public static int GetRandomAvatarID()
        {
            return UnityEngine.Random.Range(min:  0, max:  25);
        }
        private static void ResetProfileAvatar()
        {
            Player val_1 = App.Player;
            int val_2 = UnityEngine.Random.Range(min:  0, max:  25);
            Player val_3 = App.Player;
            2621448.Save(writePrefs:  true);
        }
        public static int get_AvatarID()
        {
            var val_10;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1937797680) != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Profile val_4 = 0.MyProfile;
                if((0.Equals(value:  -1927030288)) != false)
            {
                    SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Profile val_7 = 0.MyProfile;
                val_10 = 36;
                return (int)val_10;
            }
            
            }
            
            Player val_8 = App.Player;
            SLC.Social.SocialManager.ResetProfileAvatar();
            Player val_9 = App.Player;
            val_10 = 2621448 + 156;
            return (int)val_10;
        }
        public SocialManager()
        {
        
        }
        private static SocialManager()
        {
            if(mem[35635938] != true)
            {
                
            }
        
        }
    
    }

}
