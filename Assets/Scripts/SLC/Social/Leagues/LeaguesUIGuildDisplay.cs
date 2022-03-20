using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIGuildDisplay : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text guildName;
        private SLC.Social.Leagues.LeaguesUIGuildTierDisplay guildTierDisplay;
        private UnityEngine.UI.Image guildAvatar;
        private UnityEngine.UI.Button guildButton;
        private bool defaultToMyGuildOnEnable;
        private bool refreshOnMyGuildUpdate;
        private int guildDisplaying;
        public System.Action OnGuildDisplayClicked;
        private SLC.Social.Leagues.Guild guild;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_4;
            if(this.guildButton != 0)
            {
                    val_4 = null;
                val_4 = new UnityEngine.Events.UnityAction(object:  853423696, method:  new IntPtr(853398672));
                this.guildButton.m_OnClick.AddListener(call:  162246656);
            }
            
            if(this.refreshOnMyGuildUpdate == false)
            {
                    return;
            }
            
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            val_4 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  853423696, name:  442544128);
        }
        private void OnMyGuildUpdate()
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
            SLC.Social.Leagues.Guild val_6;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_6 = null;
            SLC.Social.Leagues.Guild val_2 = GetGuild(guildId:  guildId);
            this.guild = val_6;
            if(val_6 == 0)
            {
                    return;
            }
            
            this.guildDisplaying = guildId;
            SLC.Social.AvatarConfig val_3 = SLC.Social.Leagues.LeaguesUIManager.guildAvatarHandler;
            UnityEngine.Sprite val_4 = GetAvatarSpriteByID(id:  this.guild.AvatarId);
            this.guildAvatar.sprite = 442916864;
            val_6 = this.guildTierDisplay;
            if((UnityEngine.Object.op_Implicit(exists:  val_6)) == false)
            {
                    return;
            }
            
            this.guildTierDisplay.Refresh(guildId:  guildId);
        }
        private void OnThisButtonClicked()
        {
            if(this.OnGuildDisplayClicked != 0)
            {
                    this.OnGuildDisplayClicked.Invoke();
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-747685408) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGuildInfoPopup(guildId:  this.guildDisplaying);
        }
        public void SetButtonInteractable(bool isInteractable)
        {
            this.guildButton.interactable = isInteractable;
        }
        public LeaguesUIGuildDisplay()
        {
            this.guildDisplaying = 0;
        }
    
    }

}
