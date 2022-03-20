using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_MyClubTabsNotifs : MonoBehaviour
    {
        // Fields
        public const string LeaguesChatLastMessagePref = "leagues_last_message_seen";
        private UnityEngine.GameObject chatsNotifObject;
        private UnityEngine.UI.Text chatsNotifCountText;
        private UnityEngine.UI.Toggle chatToggle;
        
        // Methods
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  869332192, name:  442544128);
        }
        private void OnMyGuildChatUpdate()
        {
            var val_14;
            System.Predicate<System.String> val_16;
            UnityEngine.GameObject val_17;
            var val_18;
            var val_19;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            val_14 = null;
            val_14 = null;
            val_16 = LeaguesUI_MyClubTabsNotifs.<>c.<>9__5_0;
            if(val_16 == 0)
            {
                    val_16 = null;
                val_16 = new System.Predicate<ZooTile>(object:  LeaguesUI_MyClubTabsNotifs.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(869420192));
                LeaguesUI_MyClubTabsNotifs.<>c.<>9__5_0 = val_16;
            }
            
            int val_4 = 2900448.FindIndex(match:  8040448);
            if(val_4 == 1)
            {
                goto label_11;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_7 = 0.MyGuild;
            var val_13 = 35298812;
            val_13 = val_13 - 1;
            if(val_4 != val_13)
            {
                goto label_17;
            }
            
            val_17 = this.chatsNotifObject;
            goto label_30;
            label_11:
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_9 = 0.MyGuild;
            val_18 = 35298812;
            goto label_24;
            label_17:
            SLC.Social.Leagues.LeaguesDataController val_10 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_11 = 0.MyGuild;
            val_18 = 35298812 + (~val_4);
            label_24:
            val_17 = this.chatsNotifObject;
            if(val_18 < 1)
            {
                goto label_30;
            }
            
            val_19 = this.chatToggle.m_IsOn >> 5;
            goto label_32;
            label_30:
            val_19 = 0;
            label_32:
            val_17.SetActive(value:  false);
            string val_12 = val_18.ToString();
            if(this.chatsNotifCountText != 0)
            {
                    return;
            }
        
        }
        public LeaguesUI_MyClubTabsNotifs()
        {
        
        }
    
    }

}
