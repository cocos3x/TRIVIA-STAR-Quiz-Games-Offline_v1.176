using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIGuildTierDisplay : MonoBehaviour
    {
        // Fields
        public static System.Collections.Generic.List<string> TierTextHexColors;
        private UnityEngine.UI.Text tierNameText;
        private TMPro.TextMeshProUGUI tierNameTextMesh;
        private bool defaultToMyGuildOnEnable;
        private bool refreshOnMyGuildUpdate;
        public static System.Collections.Generic.Dictionary<int, int> GuildTierToSimpleType;
        private SLC.Social.Leagues.Guild guild;
        
        // Methods
        private void Start()
        {
            if(this.refreshOnMyGuildUpdate == false)
            {
                    return;
            }
            
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  859300496, name:  442544128);
        }
        public void OnMyGuildUpdate()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_2 = MyProfile;
            this.Refresh(guildId:  SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_generic_class);
        }
        private void OnEnable()
        {
            if(this.defaultToMyGuildOnEnable == false)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_2 = MyProfile;
            this.Refresh(guildId:  SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_generic_class);
        }
        public void Refresh(int guildId)
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = GetGuild(guildId:  guildId);
            this.guild = null;
            if(null == 0)
            {
                    return;
            }
            
            this.UpdateTierUI(guildTier:  typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_14);
        }
        public void UpdateRankUI(int guildRank, int tier, bool showRank = True)
        {
        
        }
        public void UpdateTierUI(int guildTier)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = this;
            val_11 = guildTier;
            if(val_11 == 1)
            {
                goto label_1;
            }
            
            if(val_11 != 0)
            {
                goto label_2;
            }
            
            UnityEngine.Debug.LogError(message:  854530576);
            return;
            label_1:
            UnityEngine.GameObject val_1 = this.tierNameText.gameObject;
            this.tierNameText.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.tierNameTextMesh.gameObject;
            this.tierNameTextMesh.SetActive(value:  true);
            string val_3 = SLC.Social.Leagues.GuildTierLoc.GetLocalizedTier(tier:  1);
            this.tierNameTextMesh.text = 1;
            label_2:
            UnityEngine.GameObject val_4 = R5 + 16.gameObject;
            R5 + 16.SetActive(value:  false);
            UnityEngine.GameObject val_5 = R5 + 12.gameObject;
            R5 + 12.SetActive(value:  true);
            val_12 = null;
            val_12 = null;
            int val_6 = SLC.Social.Leagues.LeaguesUIGuildTierDisplay.GuildTierToSimpleType.Item[R4];
            if((SLC.Social.Leagues.LeaguesUIGuildTierDisplay.TierTextHexColors + 12) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = SLC.Social.Leagues.LeaguesUIGuildTierDisplay.TierTextHexColors + 8;
            val_9 = val_9 + (val_6 << 2);
            string val_7 = SLC.Social.Leagues.GuildTierLoc.GetLocalizedTier(tier:  R4);
            string val_8 = System.String.Format(format:  -1670416656, arg0:  (SLC.Social.Leagues.LeaguesUIGuildTierDisplay.TierTextHexColors + 8 + (val_6) << 2) + 16, arg1:  R4);
            if((R5 + 12) == 0)
            {
                
            }
        
        }
        public LeaguesUIGuildTierDisplay()
        {
        
        }
        private static LeaguesUIGuildTierDisplay()
        {
            var val_3;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(null != 0)
            {
                    Add(item:  -1669742640);
            }
            else
            {
                    Add(item:  -1669742640);
            }
            
            Add(item:  -1669742560);
            if(null != 0)
            {
                    Add(item:  -1669742480);
            }
            else
            {
                    Add(item:  -1669742480);
            }
            
            Add(item:  -1669742400);
            if(null != 0)
            {
                    Add(item:  -1669742320);
            }
            else
            {
                    Add(item:  -1669742320);
            }
            
            Add(item:  -1669742240);
            SLC.Social.Leagues.LeaguesUIGuildTierDisplay.TierTextHexColors = null;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            if(null != 0)
            {
                    val_3 = 1152921511111014784;
                Add(key:  1, value:  0);
                Add(key:  2, value:  1);
                Add(key:  3, value:  2);
                Add(key:  4, value:  3);
                Add(key:  5, value:  3);
                Add(key:  6, value:  3);
                Add(key:  7, value:  4);
                Add(key:  8, value:  4);
                Add(key:  9, value:  4);
                Add(key:  10, value:  5);
                Add(key:  11, value:  5);
                Add(key:  12, value:  5);
                Add(key:  13, value:  5);
                Add(key:  14, value:  5);
            }
            else
            {
                    val_3 = 1152921511111014784;
                Add(key:  1, value:  0);
                Add(key:  2, value:  1);
                Add(key:  3, value:  2);
                Add(key:  4, value:  3);
                Add(key:  5, value:  3);
                Add(key:  6, value:  3);
                Add(key:  7, value:  4);
                Add(key:  8, value:  4);
                Add(key:  9, value:  4);
                Add(key:  10, value:  5);
                Add(key:  11, value:  5);
                Add(key:  12, value:  5);
                Add(key:  13, value:  5);
                Add(key:  14, value:  5);
            }
            
            Add(key:  15, value:  5);
            SLC.Social.Leagues.LeaguesUIGuildTierDisplay.GuildTierToSimpleType = null;
        }
    
    }

}
