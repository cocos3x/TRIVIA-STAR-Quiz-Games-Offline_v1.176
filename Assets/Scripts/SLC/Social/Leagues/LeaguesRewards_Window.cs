using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesRewards_Window : MonoBehaviour
    {
        // Fields
        private SLC.Social.Leagues.LeaguesUIGuildTierDisplay mainTierDisplay;
        private SLC.Social.Leagues.LeaguesUIGuildTierDisplay prevButtonDisplay;
        private SLC.Social.Leagues.LeaguesUIGuildTierDisplay nextButtonDisplay;
        private SLC.Social.Leagues.LeaguesUI_TierRewardDisplay[] rewards;
        private UnityEngine.UI.Button prevButton;
        private UnityEngine.UI.Button nextButton;
        private UnityEngine.UI.Button closeButton;
        private int currentTier;
        
        // Properties
        private int buttonIndex { get; }
        
        // Methods
        private int get_buttonIndex()
        {
            int val_1 = this.currentTier;
            val_1 = val_1 - 1;
            return (int)val_1;
        }
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  882261424, method:  new IntPtr(882217968));
            this.prevButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  882261424, method:  new IntPtr(882227184));
            this.nextButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  882261424, method:  new IntPtr(882236400));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnEnable()
        {
            int val_5;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            if(null != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_4 = MyGuild;
                if(null != 0)
            {
                goto label_9;
            }
            
            }
            else
            {
                    val_5 = 1;
            }
            
            label_9:
            this.currentTier = val_5;
            this.UpdateUITier();
        }
        private void UpdateUITier()
        {
            var val_6;
            this.mainTierDisplay.UpdateTierUI(guildTier:  this.currentTier);
            val_6 = 0;
            goto label_2;
            label_7:
            SLC.Social.Leagues.LeaguesUI_TierRewardDisplay val_6 = this.rewards[val_6];
            val_6 = 1;
            val_6.UpdateFromLeagueTier(rank:  1, tier:  this.currentTier);
            label_2:
            if(val_6 < val_6)
            {
                goto label_7;
            }
            
            this.nextButtonDisplay.UpdateTierUI(guildTier:  (UnityEngine.Mathf.Repeat(t:  (float)this.currentTier - 2, length:  null)) + 1);
            if(this.prevButtonDisplay == 0)
            {
                    -D16 = -(-D16);
            }
            
            this.prevButtonDisplay.UpdateTierUI(guildTier:  (UnityEngine.Mathf.Repeat(t:  (float)this.currentTier, length:  null)) + 1);
        }
        private void OnClick_Previous()
        {
            float val_1 = UnityEngine.Mathf.Repeat(t:  (float)this.currentTier, length:  null);
            int val_2 = (float)this.currentTier;
            val_2 = val_2 + 1;
            this.currentTier = val_2;
            this.UpdateUITier();
        }
        private void OnClick_Next()
        {
            float val_2 = UnityEngine.Mathf.Repeat(t:  (float)this.currentTier - 2, length:  null);
            int val_3 = (float)this.currentTier - 2;
            val_3 = val_3 + 1;
            this.currentTier = val_3;
            this.UpdateUITier();
        }
        public LeaguesRewards_Window()
        {
            this.currentTier = 0;
        }
        private void <Start>b__10_0()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  883138224, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
    
    }

}
