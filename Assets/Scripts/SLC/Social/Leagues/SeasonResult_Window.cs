using UnityEngine;

namespace SLC.Social.Leagues
{
    public class SeasonResult_Window : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text seasonNumber;
        private SLC.Social.Leagues.LeaguesUIGuildTierDisplay tierText;
        private UnityEngine.UI.Text rewardAmount;
        private UnityEngine.UI.Button collectButton;
        private SLC.Social.Leagues.LeaguesUIGuildListView listView;
        private GridCoinCollectAnimationInstantiator coinsAnimControl;
        private GemsCollectAnimationInstantiator gemAnimControl;
        private bool isShowing;
        private decimal reward;
        
        // Methods
        private void Awake()
        {
            GridCoinCollectAnimationInstantiator val_8;
            var val_9;
            System.Action val_10;
            var val_11;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  888557440, method:  new IntPtr(888508864));
            this.collectButton.m_OnClick.AddListener(call:  162246656);
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  888557440, method:  new IntPtr(888513984));
            this.listView.OnGuildListFinishedUIUpdate = null;
            val_8 = this.coinsAnimControl;
            System.Action val_3 = null;
            val_9 = val_3;
            val_3 = new System.Action(object:  888557440, method:  new IntPtr(888524224));
            System.Delegate val_4 = System.Delegate.Combine(a:  this.coinsAnimControl.OnCompleteCallback, b:  7454720);
            val_10 = this.coinsAnimControl.OnCompleteCallback;
            if(val_10 != 0)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
            val_10 = 0;
            label_7:
            this.coinsAnimControl.OnCompleteCallback = val_10;
            if(this.gemAnimControl == 0)
            {
                    return;
            }
            
            val_8 = this.gemAnimControl;
            System.Action val_6 = null;
            val_9 = val_6;
            val_6 = new System.Action(object:  888557440, method:  new IntPtr(888524224));
            System.Delegate val_7 = System.Delegate.Combine(a:  this.gemAnimControl, b:  7454720);
            val_11 = this.gemAnimControl;
            if(val_11 != 0)
            {
                    if(null == null)
            {
                goto label_14;
            }
            
            }
            
            val_11 = 0;
            label_14:
            mem2[0] = val_11;
        }
        private void OnListViewUpdate(UnityEngine.UI.ScrollRect scrollRect)
        {
            var val_4;
            float val_5;
            val_4 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(50331648 < 2)
            {
                    val_5 = 1f;
            }
            else
            {
                    SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
                val_4 = 52;
                SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
                var val_5 = 50331648;
                val_5 = val_5 - 1;
                float val_6 = (float)val_4 - 1;
                val_6 = val_6 / (float)val_5;
                val_5 = 1f - val_6;
            }
            
            scrollRect.verticalNormalizedPosition = val_6;
        }
        public void Show()
        {
            SLC.Social.Leagues.LeaguesUIGuildTierDisplay val_20;
            var val_21;
            var val_22;
            var val_23;
            if(this.isShowing != false)
            {
                    return;
            }
            
            this.isShowing = true;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            GameEcon val_2 = App.getGameEcon;
            string val_3 = this.reward.ToString(format:  null);
            val_20 = this.reward;
            SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_5 = 0.MyGuild;
            if(0 == 0)
            {
                goto label_10;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(52 <= 1)
            {
                goto label_14;
            }
            
            val_21 = 0;
            SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
            goto label_17;
            label_10:
            var val_20 = 0;
            SLC.Social.Leagues.LeaguesDataController val_10 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_20 = val_20 + 40;
            UnityEngine.GameObject val_11 = this.gameObject;
            val_22 = 0;
            goto label_22;
            label_14:
            SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_21 = 0;
            SLC.Social.Leagues.Guild val_13 = val_21.MyGuild;
            label_17:
            SLC.Social.Leagues.LeaguesDataController val_14 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(52 > 1)
            {
                    SLC.Social.Leagues.LeaguesDataController val_16 = SLC.Social.Leagues.LeaguesManager.DAO;
                val_23 = 64;
            }
            else
            {
                    SLC.Social.Leagues.LeaguesDataController val_17 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_18 = 0.MyGuild;
                val_23 = 20;
            }
            
            val_20 = this.tierText;
            val_20.UpdateTierUI(guildTier:  1);
            this.collectButton.interactable = true;
            UnityEngine.GameObject val_19 = this.gameObject;
            val_22 = 1;
            label_22:
            this.SetActive(value:  true);
        }
        private void OnCollectClicked()
        {
            int val_19;
            int val_27;
            int val_28;
            int val_29;
            int val_30;
            int val_38;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_39;
            var val_40;
            int val_41;
            float val_42;
            var val_43;
            var val_44;
            int val_45;
            var val_46;
            int val_47;
            int val_48;
            var val_49;
            float val_50;
            int val_51;
            int val_52;
            var val_53;
            var val_54;
            val_38 = this;
            this.collectButton.interactable = false;
            SLC.Social.Leagues.LeaguesTracker.TrackSeasonRollover();
            GameBehavior val_1 = App.getBehavior;
            if(0 != 0)
            {
                    Player val_3 = App.Player;
                val_41 = R6;
                0.AddCredits(amount:  new System.Decimal() {flags = this.reward, hi = val_41, lo = R7, mid = 1152921504892043264}, source:  "Leagues Season Reward", subSource:  0, externalParams:  0, doTrack:  true);
                val_42 = 1152921504892043264;
            }
            else
            {
                    Player val_4 = App.Player;
                val_39 = 0;
                val_40 = "Leagues Season Reward";
                0.AddGems(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.reward + (0)], hi = mem[this.reward + (4)], lo = mem[this.reward + (8)], mid = 1152921504892043264}), source:  888934976, subsource:  null);
                Player val_6 = App.Player;
                string val_7 = this.reward.ToString();
                val_42 = 1152921504892043264;
                val_41 = 0;
                0.TrackNonCoinReward(source:  888934976, subSource:  null, rewardType:  -1668821072, rewardAmount:  this.reward, additionalParams:  val_39);
            }
            
            var val_38 = 0;
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_38 = val_38 + 40;
            val_43 = null;
            val_43 = null;
            val_45 = mem[this.reward + (8)];
            if((System.Decimal.op_Inequality(d1:  new System.Decimal() {flags = mem[this.reward + (0)], hi = mem[this.reward + (4)], lo = val_45, mid = mem[this.reward + (12)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    val_46 = null;
                val_46 = null;
                val_45 = R6;
                if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = this.reward, hi = R5, lo = val_45, mid = R7}, d2:  new System.Decimal() {flags = System.Decimal.One, mid = System.Decimal.Powers10.__il2cppRuntimeField_20})) != false)
            {
                    GameBehavior val_11 = App.getBehavior;
                if(0 != 0)
            {
                    Player val_12 = App.Player;
                var val_39 = 0;
                val_39 = val_39 + 64;
                val_48 = mem[(0 + 64) + (4)];
                val_47 = mem[(0 + 64) + (0)];
                decimal val_13 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 888955228, hi = 52, lo = val_47, mid = val_48}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)], hi = this.reward, lo = this.reward});
                Player val_14 = App.Player;
                val_44 = 52;
                val_42 = 1152921504892043264;
                if((System.Decimal.op_Inequality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256})) != false)
            {
                    Player val_16 = App.Player;
                val_49 = 256;
                val_49 = val_49;
                decimal val_17 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 888955228, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = mem[this.reward + (0)], lo = mem[this.reward + (4)], mid = mem[this.reward + (8)]});
                Player val_18 = App.Player;
                val_50 = 7.286752E-44f;
                this.coinsAnimControl.Play(fromValue:  new System.Decimal() {mid = val_19}, toValue:  new System.Decimal() {flags = 52, hi = val_51, lo = val_52, mid = val_38}, textTickTime:  null, delayBeforeComplete:  null);
                return;
            }
            
            }
            
            }
            
            }
            
            val_50 = this.reward;
            val_53 = null;
            val_53 = null;
            if((System.Decimal.op_Inequality(d1:  new System.Decimal() {flags = val_50, hi = R5, lo = R6, mid = R7}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    val_50 = this.reward;
                val_54 = null;
                val_54 = null;
                if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_50, hi = R5, lo = R6, mid = R7}, d2:  new System.Decimal() {flags = System.Decimal.One, mid = System.Decimal.Powers10.__il2cppRuntimeField_20})) != false)
            {
                    Player val_22 = App.Player;
                val_50 = 0;
                decimal val_23 = System.Decimal.op_Implicit(value:  888955228);
                decimal val_24 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 888955212}, d2:  new System.Decimal() {flags = ???, hi = this.reward, mid = ???});
                Player val_25 = App.Player;
                decimal val_26 = System.Decimal.op_Implicit(value:  888955196);
                val_52 = val_27;
                val_51 = val_28;
                if((System.Decimal.op_Inequality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_52, hi = val_51, lo = val_29, mid = val_30})) != false)
            {
                    val_50 = this.gemAnimControl;
                Player val_32 = App.Player;
                val_42 = 0;
                decimal val_33 = System.Decimal.op_Implicit(value:  888955228);
                decimal val_34 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 888955212}, d2:  new System.Decimal() {flags = ???, hi = this.reward, lo = val_52});
                Player val_36 = App.Player;
                val_51 = 0;
                decimal val_37 = System.Decimal.op_Implicit(value:  888955196);
                val_52 = 49024;
                val_52 = 3212836864;
                val_50.Play(fromValue:  System.Decimal.op_Explicit(value:  new System.Decimal()), toValue:  new System.Decimal() {flags = val_27, hi = val_28, lo = val_29, mid = val_30}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  val_52, originObject:  val_52);
                return;
            }
            
            }
            
            }
            
            this.OnCoinsAnimFinished();
        }
        private void OnCoinsAnimFinished()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            UnityEngine.GameObject val_3 = this.gameObject;
            SLCWindow.CloseWindow(window:  889092592, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public SeasonResult_Window()
        {
        
        }
    
    }

}
