using UnityEngine;

namespace SLC.Social.Leagues
{
    public class ClubLevelContribution_WindowGems : ClubLevelContribution_Window
    {
        // Fields
        private GemsCollectAnimationInstantiator gemGainedAnim;
        
        // Methods
        protected override void Start()
        {
            UnityEngine.Events.UnityAction val_9;
            var val_10;
            GemsCollectAnimationInstantiator val_11;
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  879811920, name:  442544128);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  879811920, method:  new IntPtr(875472528));
            6.AddListener(call:  162246656);
            System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  879811920, method:  new IntPtr(875481744));
            System.Delegate val_4 = System.Delegate.Combine(a:  System.UInt32 System.Enum::System.IConvertible.ToUInt32(System.IFormatProvider provider), b:  7401472);
            val_10 = System.UInt32 System.Enum::System.IConvertible.ToUInt32(System.IFormatProvider provider);
            if(val_10 != 0)
            {
                    if((System.UInt32 System.Enum::System.IConvertible.ToUInt32(System.IFormatProvider provider)) == null)
            {
                goto label_11;
            }
            
            }
            
            val_10 = 0;
            label_11:
            typeof(SLC.Social.Leagues.LeaguesNotifyType).__il2cppRuntimeField_12C = val_10;
            val_11 = this.gemGainedAnim;
            System.Action val_5 = new System.Action(object:  879811920, method:  new IntPtr(875486864));
            mem2[0] = null;
            if(this.gemGainedAnim == 0)
            {
                    return;
            }
            
            val_11.RemoveAllListeners();
            val_9 = null;
            val_9 = new UnityEngine.Events.UnityAction(object:  879811920, method:  new IntPtr(879786896));
            val_11.AddListener(call:  162246656);
            UnityEngine.GameObject val_8 = this.gemGainedAnim.gameObject;
            this.gemGainedAnim.SetActive(value:  true);
        }
        protected override void SetProgressRemainingText(bool onEnable)
        {
            int val_9;
            int val_10;
            int val_11;
            int val_12;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_27;
            int val_28;
            int val_29;
            int val_30;
            int val_39;
            int val_40;
            int val_41;
            float val_42;
            var val_44;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_3 = 0.Level;
            decimal val_4 = CoinSupportRequired;
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_6 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_7 = 0.NextLevel;
            decimal val_8 = CoinSupportRequired;
            val_39 = val_10;
            SLC.Social.Leagues.LeaguesDataController val_13 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_14 = 0.MyGuild;
            decimal val_15 = GetLeagueContributedCoins;
            SLC.Social.Leagues.LeaguesDataController val_16 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_17 = 0.MyGuild;
            SLC.Social.Leagues.LeaguesDataController val_18 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_19 = 0.MyGuild;
            decimal val_20 = ProgressThisLevel(currentLevel:  val_15.hi);
            decimal val_26 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 879920232}, d2:  new System.Decimal() {flags = val_22, hi = val_21, lo = val_23, mid = val_24});
            val_40 = val_12;
            decimal val_31 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 879920216, hi = val_28, lo = val_29, mid = val_30}, d2:  new System.Decimal() {flags = val_27, hi = val_39, lo = val_11, mid = val_9});
            float val_32 = System.Decimal.op_Explicit(value:  new System.Decimal());
            string val_33 = Localization.Localize(key:  879908224, defaultValue:  879908112, useSingularKey:  false);
            val_41 = val_28;
            val_42 = "num_gems_remaining";
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_41, hi = val_29, lo = val_30, mid = val_27}, d2:  new System.Decimal() {flags = val_39, hi = val_11, lo = val_9, mid = val_40})) != false)
            {
                    val_39 = 0;
                decimal val_35 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 879920284, hi = val_39, lo = val_11, mid = val_9}, d2:  new System.Decimal() {flags = val_12, hi = val_41, lo = val_29, mid = val_30});
                decimal val_36 = new System.Decimal(value:  1000);
                val_40 = val_36.flags;
                val_41 = val_36.hi;
                string val_37 = MetricSystem.Abbreviate(number:  new System.Decimal(), maxSigFigs:  3, round:  true, useColor:  true, maxValueWithoutAbbr:  new System.Decimal() {flags = val_40, hi = val_41, lo = val_36.lo, mid = val_36.mid}, useRichText:  true, withSpaces:  false);
                val_42 = val_42;
                val_44 = R0;
            }
            else
            {
                    val_44 = "0";
            }
            
            string val_38 = System.String.Format(format:  879908224, arg0:  1254115712);
            if(mem[1152921514076713944] != 0)
            {
                    return;
            }
        
        }
        protected override bool CheckAllowedAndShowError()
        {
            ulong val_2;
            long val_9;
            var val_27;
            var val_28;
            System.Action val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            val_27 = null;
            val_27 = null;
            val_28 = 0;
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514076814880}, d2:  new System.DateTime() {dateData = val_2});
            val_29 = 1152921504622821376;
            val_30 = 0;
            System.TimeSpan val_7 = System.TimeSpan.op_Subtraction(t1:  new System.TimeSpan() {_ticks = 1152921514076814872}, t2:  new System.TimeSpan() {_ticks = SLC.Social.Leagues.LeaguesEconomy.AllowedDonationInterval});
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_9}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
            {
                    val_31 = 0;
                R5.SetActive(value:  true);
                return (bool)val_31;
            }
            
            var val_12 = (R5 + (SLC.Social.Leagues.LeaguesEconomy.AllowedDonationInterval << 4)) + 20;
            Player val_13 = App.Player;
            decimal val_14 = System.Decimal.op_Implicit(value:  880033288);
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = (R5 + (SLC.Social.Leagues.LeaguesEconomy.AllowedDonationInterval) << 4) + 16, hi = mem[((R5 + (SLC.Social.Leagues.LeaguesEconomy.AllowedDonationInterval) << 4) + 20) + (0)], lo = mem[((R5 + (SLC.Social.Leagues.LeaguesEconomy.AllowedDonationInterval) << 4) + 20) + (4)], mid = mem[((R5 + (SLC.Social.Leagues.LeaguesEconomy.AllowedDonationInterval) << 4) + 20) + (8)]}, d2:  new System.Decimal())) != false)
            {
                    var val_27 = 26437873;
                val_27 = 9188188 + val_27;
                if(val_27 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_32 = null;
                val_32 = null;
                PurchaseProxy.currentPurchasePoint = 124;
                string val_16 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
                GameStoreManager.StoreCategoryFocus = "gems_upper";
                twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_18 = ShowUGUIMonolith<System.Object>(showNext:  false);
                val_30 = 1152921505052106752;
                val_33 = null;
                val_33 = null;
                val_29 = ClubLevelContribution_WindowGems.<>c.<>9__3_0;
                if(val_29 == 0)
            {
                    val_29 = null;
                val_29 = new System.Action(object:  ClubLevelContribution_WindowGems.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(880020336));
                ClubLevelContribution_WindowGems.<>c.<>9__3_0 = val_29;
            }
            
                val_31 = 0;
                Init(outOfCredits:  true, onCloseAction:  7454720);
                UnityEngine.GameObject val_20 = this.gameObject;
                SLCWindow.CloseWindow(window:  880045360, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
                return (bool)val_31;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_21 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_22 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_23 = 0.Level;
            SLC.Social.Leagues.LeaguesDataController val_24 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_25 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_26 = 0.NextLevel;
            val_31 = 1;
            if(0 != 0)
            {
                    return (bool)val_31;
            }
        
        }
        protected override System.Collections.IEnumerator DeferredUpdate(bool success)
        {
            typeof(ClubLevelContribution_WindowGems.<DeferredUpdate>d__4).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(ClubLevelContribution_WindowGems.<DeferredUpdate>d__4).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(ClubLevelContribution_WindowGems.<DeferredUpdate>d__4).__il2cppRuntimeField_14 = success;
        }
        public ClubLevelContribution_WindowGems()
        {
        
        }
        private void <Start>b__1_0()
        {
            var val_5;
            var val_6;
            System.Action val_8;
            var val_5 = 26436841;
            val_5 = 9189220 + val_5;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            PurchaseProxy.currentPurchasePoint = 124;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_6 = null;
            val_6 = null;
            val_8 = ClubLevelContribution_WindowGems.<>c.<>9__1_1;
            if(val_8 == 0)
            {
                    val_8 = null;
                val_8 = new System.Action(object:  ClubLevelContribution_WindowGems.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(880357360));
                ClubLevelContribution_WindowGems.<>c.<>9__1_1 = val_8;
            }
            
            Init(outOfCredits:  true, onCloseAction:  7454720);
            UnityEngine.GameObject val_4 = this.gameObject;
            SLCWindow.CloseWindow(window:  880382384, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
    
    }

}
