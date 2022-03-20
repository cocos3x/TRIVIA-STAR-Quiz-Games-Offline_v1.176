using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIManager : MonoSingleton<SLC.Social.Leagues.LeaguesUIManager>
    {
        // Fields
        public static int openDirectlyToContainer;
        public static System.Action DoOnStart;
        private UnityEngine.GameObject noGuildContainer;
        private UnityEngine.UI.Toggle defaultNoGuildContainerToggle;
        private UnityEngine.GameObject hasGuildContainer;
        private UnityEngine.UI.Toggle defaultHasGuildContainerToggle;
        private UnityEngine.GameObject tierStandingsContainer;
        private TweenCoinsText coinsText;
        private UGUIMonolithTutorialHighlights tutorialHighlights;
        private UnityEngine.GameObject loadingPopup;
        
        // Properties
        public static SLC.Social.AvatarConfig guildAvatarHandler { get; }
        public static SLC.Social.AvatarConfig memberAvatarHandler { get; }
        public UGUIMonolithTutorialHighlights GetMyClubTutorialHighlights { get; }
        
        // Methods
        public static SLC.Social.AvatarConfig get_guildAvatarHandler()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        public static SLC.Social.AvatarConfig get_memberAvatarHandler()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        public UGUIMonolithTutorialHighlights get_GetMyClubTutorialHighlights()
        {
        
        }
        private void Start()
        {
            var val_20;
            var val_21;
            var val_22;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            DisableSnapshottedCameras();
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  844379488, name:  442544128);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1937797680) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            }
            
            UnityEngine.Debug.LogError(message:  844334800);
            val_20 = null;
            val_20 = null;
            if(SLC.Social.Leagues.LeaguesUIManager.openDirectlyToContainer != 1)
            {
                    SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_7 = MyGuild;
                if(null != 0)
            {
                    null = 1;
            }
            
                this.hasGuildContainer.SetActive(value:  true);
                SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_9 = this.hasGuildContainer.MyGuild;
                this.noGuildContainer.SetActive(value:  this.hasGuildContainer >> 5);
                val_21 = 0;
            }
            else
            {
                    this.hasGuildContainer.SetActive(value:  false);
                SLC.Social.Leagues.LeaguesDataController val_11 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_12 = MyGuild;
                this.noGuildContainer.SetActive(value:  false);
                SLC.Social.Leagues.LeaguesDataController val_13 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_14 = this.noGuildContainer.MyGuild;
                if(this.noGuildContainer != 0)
            {
                    this.noGuildContainer = 1;
            }
            
                val_21 = 1;
            }
            
            this.tierStandingsContainer.SetActive(value:  true);
            val_22 = null;
            val_22 = null;
            SLC.Social.Leagues.LeaguesUIManager.openDirectlyToContainer = 0;
            if(SLC.Social.Leagues.LeaguesUIManager.DoOnStart != 0)
            {
                    0.Invoke();
                SLC.Social.Leagues.LeaguesUIManager.DoOnStart = 0;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_16 = UnityEngine.Time.time;
            public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance().__il2cppRuntimeField_38 = 0;
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameBehavior val_18 = App.getBehavior;
            if(0 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.PlayRandomMusicTrack(type:  0);
        }
        private void OnEnable()
        {
            System.Action val_1 = new System.Action(object:  844512992, method:  new IntPtr(844487968));
            DeviceKeypressManager.AddBackAction(backAction:  7454720);
        }
        private void HandleBackButtonClose()
        {
            SLC.Social.Leagues.LeaguesUIManager.LeaveLeaguesScene();
        }
        private void OnError_Null_Response()
        {
            var val_8;
            var val_9;
            var val_10;
            System.Func<System.Boolean> val_12;
            var val_13;
            var val_8 = 24450750;
            val_8 = 11175308 + val_8;
            if(val_8 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_8 = null;
            val_8 = null;
            if(App.networkManager != 0)
            {
                    if(val_8 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_9 = null;
                val_9 = null;
                if(App.networkManager.Reachable() == true)
            {
                    return;
            }
            
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  true);
            string val_4 = Localization.Localize(key:  -1724172096, defaultValue:  -1724171984, useSingularKey:  false);
            string val_5 = Localization.Localize(key:  -1724171872, defaultValue:  -1724171744, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_6 = Localization.Localize(key:  -1724171600, defaultValue:  -1724171488, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "return_home_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "";
            val_10 = null;
            val_10 = null;
            val_12 = LeaguesUIManager.<>c.<>9__19_0;
            if(val_12 == 0)
            {
                    val_12 = null;
                val_12 = new System.Func<System.Boolean>(object:  LeaguesUIManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(844712992));
                LeaguesUIManager.<>c.<>9__19_0 = val_12;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_12;
            val_13 = null;
            val_13 = null;
            SetupMessage(titleTxt:  -1724172096, messageTxt:  -1724171872, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        }
        public void AnimateCreditGain(decimal creditsToGain, float seconds)
        {
            int val_7;
            UnityEngine.GameObject val_1 = this.coinsText.gameObject;
            this.coinsText.SetActive(value:  true);
            Player val_2 = App.Player;
            var val_3 = 0 + 60;
            decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 844846152, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256, hi = creditsToGain.flags, lo = creditsToGain.hi, mid = creditsToGain.lo});
            Player val_5 = App.Player;
            this.coinsText.Tween(startValue:  new System.Decimal() {mid = val_7}, endValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, seconds:  seconds);
        }
        public void OnSeasonRollover()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_14 = 0;
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            mem[16] = 7;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
            Show();
        }
        public void OnRemovedFromGuild()
        {
            var val_8;
            var val_9;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_10 = 7;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
            string val_4 = Localization.Localize(key:  845067424, defaultValue:  845067536, useSingularKey:  false);
            string val_5 = Localization.Localize(key:  845067632, defaultValue:  845067744, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_6 = Localization.Localize(key:  845067888, defaultValue:  845068000, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "join_another_club";
            string val_7 = Localization.Localize(key:  824289376, defaultValue:  824289296, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_14 = "close_upper";
            val_8 = null;
            val_9 = public static SLC.Social.Leagues.LeaguesWindowManager MonoSingleton<SLC.Social.Leagues.LeaguesWindowManager>::get_Instance();
            if( == 0)
            {
                    val_9 = public static SLC.Social.Leagues.LeaguesWindowManager MonoSingleton<SLC.Social.Leagues.LeaguesWindowManager>::get_Instance();
            }
            
            SetupMessage(titleTxt:  845067424, messageTxt:  845067632, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
            this.tierStandingsContainer.SetActive(value:  false);
            this.hasGuildContainer.SetActive(value:  false);
            this.noGuildContainer.SetActive(value:  true);
            this.defaultNoGuildContainerToggle.isOn = true;
        }
        public void OnBecameMaster()
        {
            var val_8;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_10 = 7;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
            string val_4 = Localization.Localize(key:  -7698336, defaultValue:  -7698448, useSingularKey:  false);
            string val_5 = Localization.Localize(key:  845212880, defaultValue:  845212992, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_6 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            string val_7 = Localization.Localize(key:  824289376, defaultValue:  824289296, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_14 = "close_upper";
            val_8 = null;
            val_8 = null;
            SetupMessage(titleTxt:  -7698336, messageTxt:  845212880, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        }
        public void OnBecameOfficer()
        {
            var val_8;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_10 = 7;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
            string val_4 = Localization.Localize(key:  -7698336, defaultValue:  -7698448, useSingularKey:  false);
            string val_5 = Localization.Localize(key:  845325168, defaultValue:  845325280, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_6 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            string val_7 = Localization.Localize(key:  824289376, defaultValue:  824289296, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_14 = "close_upper";
            val_8 = null;
            val_8 = null;
            SetupMessage(titleTxt:  -7698336, messageTxt:  845325168, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        }
        public void OnGotGuildInvite()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            string val_3 = Localization.Localize(key:  845437472, defaultValue:  845437584, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_4 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            string val_5 = Localization.Localize(key:  824289376, defaultValue:  824289296, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_14 = "close_upper";
            val_6 = null;
            val_6 = null;
            SetupMessage(titleTxt:  1098586544, messageTxt:  845437472, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        }
        public void OnGuildJoinSuccess(bool created)
        {
            this.noGuildContainer.SetActive(value:  false);
            this.tierStandingsContainer.SetActive(value:  false);
            this.hasGuildContainer.SetActive(value:  true);
            this.defaultHasGuildContainerToggle.isOn = true;
            if(created != false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public void ShowGuildInfoPopup(int guildId)
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            if(null != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_4 = MyGuild;
                this.ShowHasGuildContainer();
                return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_6 = MyGuild;
            if(null != 0)
            {
                    if(guildId == 1)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
                ShowGuild(guildId:  guildId);
                return;
            }
            
            this.ShowNoGuildContainer();
        }
        public void ShowHasGuildContainer()
        {
            this.noGuildContainer.SetActive(value:  false);
            this.tierStandingsContainer.SetActive(value:  false);
            this.hasGuildContainer.SetActive(value:  true);
        }
        public void ShowNoGuildContainer()
        {
            this.tierStandingsContainer.SetActive(value:  false);
            this.hasGuildContainer.SetActive(value:  false);
            this.noGuildContainer.SetActive(value:  true);
        }
        public void ShowTierStandingsContainer()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            if(null == 0)
            {
                    return;
            }
            
            this.noGuildContainer.SetActive(value:  false);
            this.hasGuildContainer.SetActive(value:  false);
            this.tierStandingsContainer.SetActive(value:  true);
        }
        public void OnShowContributePopup()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public void ToggleLoadingPopup(bool state)
        {
            this.loadingPopup.SetActive(value:  state);
        }
        public static void ShowPlayerProfile(int serverId, UnityEngine.GameObject gridItem)
        {
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            val_28 = serverId;
            val_29 = gridItem;
            val_30 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_2 = MyProfile;
            val_31 = null;
            GameBehavior val_3 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        public void ShowConnectionRequired()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
            string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_6 = null;
            val_6 = null;
            SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        }
        public static void LeaveLeaguesScene()
        {
            var val_12;
            GameBehavior val_1 = App.getBehavior;
            if(0 == 2)
            {
                    twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.PlayRandomMusicTrack(type:  1);
            }
            
            GameBehavior val_3 = App.getBehavior;
            ThemesHandler val_4 = App.ThemesHandler;
            string val_5 = 0.CurrentThemeName;
            if((System.String.IsNullOrEmpty(value:  null)) != false)
            {
                    val_12 = "";
            }
            else
            {
                    ThemesHandler val_7 = App.ThemesHandler;
                string val_8 = 0.CurrentThemeName;
                string val_9 = 2144339952 + null;
                val_12 = "_";
            }
            
            string val_10 = null + 2144339952;
            UnityEngine.AsyncOperation val_11 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
        }
        private void OnDestroy()
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            RestoreCameraStateSnapshot();
            System.Action val_2 = new System.Action(object:  846820688, method:  new IntPtr(844487968));
            DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        }
        public LeaguesUIManager()
        {
        
        }
        private static LeaguesUIManager()
        {
            SLC.Social.Leagues.LeaguesUIManager.openDirectlyToContainer = 0;
            SLC.Social.Leagues.LeaguesUIManager.DoOnStart = 0;
        }
    
    }

}
