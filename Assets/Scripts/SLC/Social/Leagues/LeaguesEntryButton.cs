using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesEntryButton : MonoBehaviour
    {
        // Fields
        private UGUINetworkedButton networkedButton;
        private UnityEngine.UI.Text labelText;
        private bool gameButton;
        private bool disablesButton;
        private UnityEngine.UI.Image clubAvatarImage;
        private UnityEngine.UI.Image defaultImage;
        private UnityEngine.GameObject rewardAvailableTooltip;
        private UnityEngine.GameObject rewardIcon;
        private bool displayLeagueName;
        public SLC.Social.AvatarConfig guildAvatarHandler;
        private bool showingFreeCoins;
        private bool showingDailyReward;
        public System.Action onLeaguesEntryAction;
        public System.Action onExitLeaguesAction;
        private bool playingEffect;
        
        // Properties
        public UGUINetworkedButton getButton { get; }
        
        // Methods
        public UGUINetworkedButton get_getButton()
        {
        
        }
        private void Awake()
        {
            System.Action<System.Boolean> val_7;
            if(this.enabled == false)
            {
                    return;
            }
            
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  821096912, method:  new IntPtr(821071888));
            System.Delegate val_3 = System.Delegate.Combine(a:  this.networkedButton.OnConnectionClick, b:  7401472);
            val_7 = this.networkedButton.OnConnectionClick;
            if(val_7 != 0)
            {
                    if(null == null)
            {
                goto label_5;
            }
            
            }
            
            val_7 = 0;
            label_5:
            this.networkedButton.OnConnectionClick = val_7;
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  821096912, name:  -1898880160);
            NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  821096912, name:  442544128);
            NotificationCenter val_6 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  821096912, name:  1799422256);
        }
        private void Start()
        {
            this.CheckActive();
        }
        private void OnServerSync()
        {
            this.CheckActive();
        }
        private void OnMyProfileUpdate()
        {
            this.CheckActive();
        }
        private void OnLocalize()
        {
            this.CheckActive();
        }
        private void CheckActive()
        {
            if(SLC.Social.Leagues.LeaguesManager.IsAvailable() == false)
            {
                goto label_12;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1937797680) == 0)
            {
                goto label_12;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_5 = this.networkedButton.gameObject;
            this.networkedButton.SetActive(value:  true);
            goto label_15;
            label_12:
            if(this.disablesButton != false)
            {
                    UnityEngine.GameObject val_6 = this.networkedButton.gameObject;
                this.networkedButton.SetActive(value:  false);
                return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(441638912 == 0)
            {
                    return;
            }
            
            label_15:
            this.UpdateButtonUI();
        }
        private void UpdateButtonUI()
        {
            int val_30;
            SLC.Social.AvatarConfig val_31;
            int val_32;
            var val_33;
            var val_34;
            var val_35;
            int val_37;
            int val_39;
            var val_40;
            var val_41;
            var val_42;
            int val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_49;
            int val_50;
            val_30 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            if(null != 0)
            {
                    if(this.displayLeagueName != false)
            {
                    if(this.labelText != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_5 = MyGuild;
            }
            
            }
            
                UnityEngine.GameObject val_6 = this.clubAvatarImage.gameObject;
                this.clubAvatarImage.SetActive(value:  true);
                if(this.defaultImage != 0)
            {
                    UnityEngine.GameObject val_8 = this.defaultImage.gameObject;
                this.defaultImage.SetActive(value:  false);
            }
            
                val_31 = this.guildAvatarHandler;
                SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_10 = MyGuild;
                UnityEngine.Sprite val_11 = val_31.GetAvatarSpriteByID(id:  -523368192);
                this.clubAvatarImage.sprite = val_31;
                val_32 = 1;
                val_33 = 1152921505049763840;
            }
            else
            {
                    string val_12 = Localization.Localize(key:  821798240, defaultValue:  821798160, useSingularKey:  false);
                val_31 = 1152921504765685760;
                bool val_13 = UnityEngine.Object.op_Inequality(x:  this.labelText, y:  0);
                UnityEngine.GameObject val_14 = this.clubAvatarImage.gameObject;
                this.clubAvatarImage.SetActive(value:  false);
                if(this.defaultImage != 0)
            {
                    UnityEngine.GameObject val_16 = this.defaultImage.gameObject;
                this.defaultImage.SetActive(value:  true);
            }
            
                val_32 = 0;
                val_33 = 1152921505049763840;
            }
            
            val_34 = null;
            SLC.Social.Leagues.LeaguesUIManager.openDirectlyToContainer = val_32;
            this.showingFreeCoins = false;
            this.showingDailyReward = false;
            if(this.rewardAvailableTooltip == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_18 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_35 = null;
            val_35 = null;
            val_39 = val_37;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {hi = 294248448, lo = val_39, mid = 441638912}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
            {
                goto label_49;
            }
            
            val_40 = 1;
            goto label_51;
            label_49:
            val_41 = 1152921505048485888;
            if(this.gameButton == true)
            {
                goto label_52;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_20 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_42 = null;
            val_42 = null;
            val_39 = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_generic_class;
            val_45 = 1152921505048485888;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {hi = 294248448, lo = val_39, mid = 441638912}, d2:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30})) == false)
            {
                goto label_58;
            }
            
            var val_30 = 24551887;
            val_30 = 11073900 + val_30;
            if(val_30 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_46 = null;
            val_46 = null;
            if(App.game != 17)
            {
                goto label_64;
            }
            
            label_58:
            if(this.gameButton == false)
            {
                goto label_81;
            }
            
            label_52:
            SLC.Social.Leagues.LeaguesDataController val_22 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_47 = null;
            val_47 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_this_arg, hi = R5, lo = val_31, mid = val_30}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
            {
                goto label_71;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_24 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_25 = MyGuild;
            if(null != 0)
            {
                goto label_85;
            }
            
            label_71:
            SLC.Social.Leagues.LeaguesDataController val_26 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_49 = null;
            val_49 = null;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_this_arg, hi = R5, lo = val_50, mid = val_44}, d2:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30})) == false)
            {
                goto label_81;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_28 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_29 = MyGuild;
            if(null == 0)
            {
                goto label_85;
            }
            
            label_81:
            val_40 = 0;
            label_51:
            this.rewardAvailableTooltip.SetActive(value:  false);
            return;
            label_85:
            this.rewardAvailableTooltip.SetActive(value:  true);
            this.showingDailyReward = true;
            return;
            label_64:
            this.rewardAvailableTooltip.SetActive(value:  true);
            this.showingFreeCoins = true;
        }
        private void OnConnectionClick(bool connected)
        {
            var val_38;
            float val_39;
            var val_40;
            var val_41;
            int val_42;
            int val_43;
            var val_44;
            int val_46;
            int val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            float val_55;
            var val_56;
            FeatureAccessPoints val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            val_38 = this;
            if(connected == false)
            {
                goto label_1;
            }
            
            if(this.showingDailyReward == false)
            {
                goto label_2;
            }
            
            val_39 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_40 = null;
            val_40 = null;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_this_arg, hi = R6, lo = val_42, mid = val_43}, d2:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30})) == false)
            {
                goto label_8;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_4 = MyGuild;
            if(null == 0)
            {
                goto label_12;
            }
            
            label_8:
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_44 = null;
            val_44 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_this_arg, hi = R5, lo = val_46, mid = val_47}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
            {
                    return;
            }
            
            if(this.playingEffect == true)
            {
                    return;
            }
            
            this.playingEffect = true;
            UnityEngine.Transform val_7 = this.rewardIcon.transform;
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.rewardIcon, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  822067456, method:  new IntPtr(822025024));
            object val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.rewardIcon, action:  190734336);
            return;
            label_1:
            var val_38 = 24550395;
            val_38 = 11075392 + val_38;
            if(val_38 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_48 = null;
            val_48 = null;
            if(App.game == 17)
            {
                    val_49 = public static WGFlyoutManager MonoSingleton<WGFlyoutManager>::get_Instance();
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_50 = val_49;
                val_51 = 1152921512895498400;
            }
            else
            {
                    val_49 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
                twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_50 = val_49;
                val_51 = 1152921511472608448;
            }
            
            object val_13 = ShowUGUIMonolith<System.Object>(showNext:  false);
            string val_14 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
            val_52 = "internet_required_upper";
            string val_15 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_16 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_53 = null;
            val_47 = "connection_required_explanation";
            val_54 = val_50;
            val_46 = System.Decimal.MinusOne;
            if( == 0)
            {
                    val_54 = val_50;
            }
            
            SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = val_46}, collectType:  "credits");
            return;
            label_2:
            if(this.showingFreeCoins == false)
            {
                goto label_46;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_18 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_55 = 1152921504617017344;
            val_56 = null;
            val_56 = null;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {hi = 294248448, lo = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_generic_class, mid = 441638912}, d2:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30})) == false)
            {
                    return;
            }
            
            GameBehavior val_20 = App.getBehavior;
            val_41 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_21 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(null != 0)
            {
                goto label_60;
            }
            
            goto label_60;
            label_46:
            SLC.Social.Leagues.LeaguesDataController val_22 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_23 = MyGuild;
            if(null == 0)
            {
                goto label_64;
            }
            
            if(this.gameButton == false)
            {
                goto label_65;
            }
            
            GameBehavior val_24 = App.getBehavior;
            val_57 = 14;
            if(0 == 0)
            {
                goto label_74;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge == true)
            {
                    val_57 = 15;
            }
            
            goto label_74;
            label_12:
            GameBehavior val_27 = App.getBehavior;
            SLC.Social.Leagues.LeaguesDataController val_28 = SLC.Social.Leagues.LeaguesManager.DAO;
            label_60:
            label_120:
            this.UpdateButtonUI();
            return;
            label_64:
            SLC.Social.Leagues.LeaguesDataController val_29 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_58 = null;
            val_58 = null;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {hi = 294248448, lo = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_generic_class, mid = 441638912}, d2:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30})) != false)
            {
                    SLC.Social.Leagues.LeaguesDataController val_31 = SLC.Social.Leagues.LeaguesManager.DAO;
            }
            
            var val_39 = 24548451;
            val_39 = 11077336 + val_39;
            if(val_39 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_59 = null;
            val_59 = null;
            if(App.game == 17)
            {
                goto label_96;
            }
            
            if(val_39 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_59 = null;
            val_59 = null;
            if(App.game != 19)
            {
                goto label_102;
            }
            
            label_96:
            GameBehavior val_32 = App.getBehavior;
            val_60 = 0;
            object val_33 = val_60.GetComponent<System.Object>();
            goto label_108;
            label_65:
            val_57 = 13;
            label_74:
            var val_40 = 24548071;
            val_40 = 11077720 + val_40;
            if(val_40 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_61 = null;
            val_61 = null;
            AmplitudePluginHelper.lastFeatureAccessPoint = val_57;
            twelvegigs.Autopilot.AutopilotManager val_34 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_35 = ShowUGUIMonolith<System.Object>(showNext:  false);
            if(this.onExitLeaguesAction != 0)
            {
                    public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = this.onExitLeaguesAction;
            }
            
            if(this.onLeaguesEntryAction == 0)
            {
                goto label_120;
            }
            
            this.onLeaguesEntryAction.Invoke();
            goto label_120;
            label_102:
            twelvegigs.Autopilot.AutopilotManager val_36 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_60 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            object val_37 = ShowUGUIMonolith<System.Object>(showNext:  false);
            label_108:
            if(this.onExitLeaguesAction != 0)
            {
                    public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = this.onExitLeaguesAction;
            }
            
            if(this.onLeaguesEntryAction == 0)
            {
                    return;
            }
            
            this.onLeaguesEntryAction.Invoke();
        }
        private void OnCollectDailyAnimationComplete()
        {
            var val_7;
            Player val_1 = App.Player;
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            var val_7 = 0;
            0.AddCredits(amount:  new System.Decimal() {flags = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_this_arg, hi = typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_1C, lo = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_element_class, mid = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_castClass}, source:  "Daily First Golden Currency Reward", subSource:  0, externalParams:  0, doTrack:  true);
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_7 = val_7 + 24;
            this.UpdateButtonUI();
            MainController val_4 = MainController.instance;
            System.Action val_5 = new System.Action(object:  822201104, method:  new IntPtr(822176080));
            System.Delegate val_6 = System.Delegate.Remove(source:  2621448, value:  7454720);
            val_7 = 2621448;
            if(val_7 != 0)
            {
                    if(23 == null)
            {
                goto label_14;
            }
            
            }
            
            val_7 = 0;
            label_14:
            mem[44] = val_7;
        }
        public LeaguesEntryButton()
        {
            this.displayLeagueName = true;
            this.disablesButton = true;
        }
        private void <OnConnectionClick>b__24_0()
        {
            UnityEngine.Transform val_1 = this.rewardIcon.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  this.rewardIcon, duration:  null, strength:  null, vibrato:  1065353216, randomness:  null, snapping:  false, fadeOut:  true);
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  822430224, method:  new IntPtr(822405200));
            object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.rewardIcon, action:  190734336);
        }
        private void <OnConnectionClick>b__24_1()
        {
            var val_13;
            object val_1 = this.rewardIcon.GetComponent<System.Object>();
            PluginExtension.SetColorAlpha(graphic:  this.rewardIcon, a:  null);
            object val_2 = this.rewardIcon.GetComponentInChildren<System.Object>();
            this.rewardIcon.Play();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -2090695808, clipIndex:  0);
            MainController val_4 = MainController.instance;
            Player val_5 = App.Player;
            Player val_6 = App.Player;
            SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            decimal val_8 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 822543484, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_this_arg, lo = typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_1C, mid = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_element_class});
            UnityEngine.Transform val_9 = this.rewardIcon.transform;
            0.Play(startCoins:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, finalCoins:  new System.Decimal(), particleStart:  this.rewardIcon, forceTextTween:  false);
            MainController val_10 = MainController.instance;
            System.Action val_11 = new System.Action(object:  822555536, method:  new IntPtr(822176080));
            System.Delegate val_12 = System.Delegate.Combine(a:  2621448, b:  7454720);
            val_13 = 2621448;
            if(val_13 != 0)
            {
                    if(23 == null)
            {
                goto label_26;
            }
            
            }
            
            val_13 = 0;
            label_26:
            mem[44] = val_13;
            mem[1152921514019337164] = 0;
        }
    
    }

}
