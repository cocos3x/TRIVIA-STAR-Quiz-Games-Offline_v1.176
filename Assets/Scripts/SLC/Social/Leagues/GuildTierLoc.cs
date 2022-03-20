using UnityEngine;

namespace SLC.Social.Leagues
{
    public class GuildTierLoc
    {
        // Methods
        public static string GetLocalizedTier(int tier)
        {
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            typeof(System.Char[]).__il2cppRuntimeField_10 = 95;
            System.String[] val_1 = Split(separator:  478563824);
            string val_2 = SLC.Social.Leagues.GuildTier.__il2cppRuntimeField_byval_arg.ToLower();
            string val_3 = System.String.Format(format:  -5365696, arg0:  SLC.Social.Leagues.GuildTier.__il2cppRuntimeField_byval_arg);
            string val_4 = Localization.Localize(key:  -5365696, defaultValue:  1098586544, useSingularKey:  false);
            string val_5 = System.String.Format(format:  1592589744, arg0:  -5365696, arg1:  typeof(SLC.Social.Leagues.GuildTier).__il2cppRuntimeField_14);
        }
        public GuildTierLoc()
        {
        
        }
    
    }

}
