using UnityEngine;

namespace WordForest
{
    public class WFOWordStreak : WordStreak
    {
        // Fields
        private static string PREFS_LAST_STREAK;
        private UnityEngine.UI.Text labelStreakCounter;
        private UnityEngine.UI.Button buttonStreakSaver;
        private UnityEngine.UI.Text labelStreakSaverCounter;
        private UnityEngine.UI.Text labelStreakSaverCoinCost;
        private UnityEngine.Transform upsellStreakBadge;
        private UnityEngine.Transform gameplayStreakBadge;
        private UnityEngine.ParticleSystem particles;
        public bool streakSaved;
        public bool streakSaverOffered;
        private DG.Tweening.Tweener streakMoverTween;
        private UnityEngine.Vector3 upsellBadgeInitialPos;
        private int brokenStreak;
        
        // Properties
        public bool IsUnlocked { get; }
        private bool IsTutorialUnlocked { get; }
        private bool StreakSaverEnabled { get; }
        private int MinOffer { get; }
        private decimal CostMultiplier { get; }
        
        // Methods
        public bool get_IsUnlocked()
        {
            bool val_5;
            var val_6;
            val_5 = static_value_021FA644;
            if(val_5 != true)
            {
                    val_5 = true;
            }
            
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            val_6 = 0;
            WordForest.WFOGameEcon val_2 = WordForest.WFOGameEcon.Instance;
            if(1912602624 < 786450)
            {
                    return true;
            }
            
            GameBehavior val_3 = App.getBehavior;
            GameBehavior val_4 = App.getBehavior;
            if(0 >= 0)
            {
                    val_6 = 1;
            }
            
            return true;
        }
        private bool get_IsTutorialUnlocked()
        {
            GameBehavior val_1 = App.getBehavior;
            WordForest.WFOGameEcon val_2 = WordForest.WFOGameEcon.Instance;
            if(0 >= 1282)
            {
                    0 = 1;
            }
            
            return true;
        }
        private bool get_StreakSaverEnabled()
        {
            GameEcon val_1 = App.getGameEcon;
            if(0 != 0)
            {
                    return true;
            }
            
            return true;
        }
        private int get_MinOffer()
        {
            GameEcon val_1 = App.getGameEcon;
            if(0 != 0)
            {
                    return 786450;
            }
            
            return 786450;
        }
        private decimal get_CostMultiplier()
        {
            GameEcon val_1 = App.getGameEcon;
            decimal val_2 = System.Decimal.op_Implicit(value:  355916048);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        protected override void OnLevelLoaded(GameLevel level)
        {
            var val_20;
            System.Predicate<LineWord> val_22;
            var val_23;
            var val_24;
            this.OnLevelLoaded(level:  level);
            if(this.IsTutorialUnlocked != false)
            {
                    WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
                bool val_3 = MonoExtensions.IsBitSet(value:  val_1 + 312, bit:  7);
                if(val_3 != true)
            {
                    if(val_3.IsUnlocked != false)
            {
                    WordForest.WFOPlayer val_5 = WordForest.WFOPlayer.Instance;
                WordForest.WFOPlayer val_6 = WordForest.WFOPlayer.Instance;
                mem2[0] = MonoExtensions.SetBit(value:  val_4 + 312, bit:  7);
                GameBehavior val_8 = App.getBehavior;
            }
            
            }
            
            }
            
            UnityEngine.Events.UnityAction val_10 = new UnityEngine.Events.UnityAction(object:  356044432, method:  new IntPtr(356017360));
            this.buttonStreakSaver.m_OnClick.AddListener(call:  162246656);
            NotificationCenter val_11 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  356044432, name:  -2067354288);
            WordRegion val_12 = WordRegion.instance;
            System.Action<System.String, System.Int32, System.Boolean, System.Boolean> val_13 = new System.Action<System.String, System.Int32, System.Boolean, System.Boolean>(object:  356044432, method:  new IntPtr(356018384));
            0.addOnHintedUsedAction(callback:  7614464);
            WordRegion val_14 = WordRegion.instance;
            val_20 = null;
            val_20 = null;
            val_22 = WFOWordStreak.<>c.<>9__23_0;
            if(val_22 == 0)
            {
                    val_22 = null;
                val_22 = new System.Predicate<ZooTile>(object:  WFOWordStreak.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(356019408));
                WFOWordStreak.<>c.<>9__23_0 = val_22;
            }
            
            object val_16 = 0.Find(match:  8040448);
            if(0 == 0)
            {
                    val_23 = null;
                val_23 = null;
                if((UnityEngine.PlayerPrefs.GetInt(key:  WordForest.WFOWordStreak.PREFS_LAST_STREAK)) >= 1)
            {
                    val_24 = null;
                val_24 = null;
                mem[1152921513552826012] = UnityEngine.PlayerPrefs.GetInt(key:  WordForest.WFOWordStreak.PREFS_LAST_STREAK);
            }
            
            }
            
            this.UpdateStreakCounterLabel();
        }
        private void OnFadeInBegin()
        {
            this.OnPlayerInput();
        }
        private void OnHintUsed(string word, int hintIndex, bool isFree, bool isPickerHint)
        {
            this.OnPlayerInput();
        }
        private void OnPlayerInput()
        {
            this.CancelStreakSaverAnimation();
            UnityEngine.GameObject val_1 = this.buttonStreakSaver.gameObject;
            if(this.buttonStreakSaver.activeSelf == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = R4 + 24.gameObject;
            R4 + 24.SetActive(value:  false);
            UnityEngine.GameObject val_4 = R4 + 36.gameObject;
            R4 + 36.SetActive(value:  false);
        }
        public override void ResetStreak()
        {
            var val_1;
            this.ResetStreak();
            val_1 = null;
            val_1 = null;
            UnityEngine.PlayerPrefs.SetInt(key:  WordForest.WFOWordStreak.PREFS_LAST_STREAK, value:  WordForest.WFOWordStreak.__il2cppRuntimeField_cctor_finished);
        }
        protected override void OnValidWordSubmitted(string word, bool extra)
        {
            int val_6;
            var val_7;
            if(this.IsUnlocked == false)
            {
                    return;
            }
            
            if(extra != false)
            {
                    GameBehavior val_2 = App.getBehavior;
                if(0 == 0)
            {
                    return;
            }
            
            }
            
            this.brokenStreak = 0;
            val_6 = 0 + 1;
            mem[1152921513553419804] = val_6;
            val_7 = null;
            val_7 = null;
            UnityEngine.PlayerPrefs.SetInt(key:  WordForest.WFOWordStreak.PREFS_LAST_STREAK, value:  val_6);
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  356638224, method:  new IntPtr(356613200));
            DG.Tweening.Tween val_4 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1056964608, ignoreTimeScale:  false);
            GameBehavior val_5 = App.getBehavior;
            if(35628619 < 0)
            {
                    this.StopBorderEffects();
                return;
            }
            
            this.PlayBorderEffects(restoreEffects:  false);
        }
        protected override void OnInvalidWordSubmitted()
        {
            if(this.IsUnlocked == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_3 = TotalAdditionalMultipliers;
            bool val_4 = val_3.StreakSaverEnabled;
            if(val_4 == true)
            {
                    val_4 = val_3 + R6;
                this.brokenStreak = val_4;
            }
            
            this.StopBorderEffects();
            this.UpdateStreakCounterLabel();
        }
        private void UpdateStreakCounterLabel()
        {
            int val_11;
            int val_12;
            int val_13;
            int val_15;
            var val_28;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            UnityEngine.GameObject val_1 = this.buttonStreakSaver.gameObject;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_5 = TotalAdditionalMultipliers + R6;
            string val_6 = System.String.Format(format:  -1232359984, arg0:  13152256);
            UnityEngine.GameObject val_7 = this.gameplayStreakBadge.gameObject;
            if(val_5 > 0)
            {
                    0 = 1;
            }
            
            this.gameplayStreakBadge.SetActive(value:  true);
            string val_8 = System.String.Format(format:  -1232359984, arg0:  13152256);
            val_41 = 0;
            decimal val_9 = System.Decimal.op_Implicit(value:  356927972);
            decimal val_10 = CostMultiplier;
            decimal val_16 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 356927936, hi = this.brokenStreak}, d2:  new System.Decimal() {flags = val_13, hi = val_11, lo = val_12, mid = val_15});
            string val_17 = ToString();
            val_42 = 0;
            this.buttonStreakSaver.interactable = true;
            UnityEngine.GameObject val_18 = this.buttonStreakSaver.gameObject;
            val_43 = this.buttonStreakSaver;
            bool val_19 = this.buttonStreakSaver.StreakSaverEnabled;
            if(val_19 != false)
            {
                    if(this.brokenStreak >= val_19.MinOffer)
            {
                    if(this.brokenStreak > val_5)
            {
                    val_42 = 1;
            }
            
            }
            
            }
            
            val_43.SetActive(value:  true);
            UnityEngine.GameObject val_21 = this.upsellStreakBadge.gameObject;
            UnityEngine.GameObject val_22 = this.buttonStreakSaver.gameObject;
            this.upsellStreakBadge.SetActive(value:  this.buttonStreakSaver.activeSelf);
            UnityEngine.Vector3 val_24 = this.brokenStreak.position;
            UnityEngine.Transform val_25 = this.buttonStreakSaver.transform;
            val_44 = 0;
            UnityEngine.Vector3 val_26 = position;
            UnityEngine.Vector3 val_27 = position;
            UnityEngine.Vector3 val_29 = new UnityEngine.Vector3(x:  val_27.x, y:  val_27.y, z:  val_27.z);
            if(this.buttonStreakSaver.activeSelf == true)
            {
                    return;
            }
            
            UnityEngine.GameObject val_30 = this.buttonStreakSaver.gameObject;
            if(this.buttonStreakSaver.activeSelf == false)
            {
                    return;
            }
            
            this.streakSaverOffered = true;
            UnityEngine.Vector3 val_32 = this.brokenStreak.position;
            this.upsellStreakBadge.position = new UnityEngine.Vector3() {x = this.brokenStreak};
            val_41 = 16140;
            val_41 = 1057803469;
            DG.Tweening.Tweener val_33 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.upsellStreakBadge, endValue:  new UnityEngine.Vector3() {x = mem[this.upsellBadgeInitialPos + (0)], y = mem[this.upsellBadgeInitialPos + (4)], z = mem[this.upsellBadgeInitialPos + (8)]}, duration:  val_32.x, snapping:  true);
            val_43 = 1152921509932985248;
            object val_34 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.upsellStreakBadge, ease:  7);
            UnityEngine.Transform val_35 = this.buttonStreakSaver.transform;
            val_44 = 0;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.zero;
            this.buttonStreakSaver.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_37 = this.buttonStreakSaver.transform;
            val_28 = 0;
            UnityEngine.Vector3 val_38 = new UnityEngine.Vector3(x:  val_36.x, y:  val_36.y, z:  val_36.z);
            DG.Tweening.Tweener val_39 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.buttonStreakSaver, endValue:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, duration:  val_36.x);
            object val_40 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.buttonStreakSaver, ease:  31);
        }
        private void OnStreakSaverButtonClicked()
        {
            int val_4;
            int val_11;
            int val_13;
            int val_14;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_17;
            int val_18;
            string val_19;
            var val_20;
            int val_21;
            var val_22;
            Player val_1 = App.Player;
            val_17 = 52;
            decimal val_2 = System.Decimal.op_Implicit(value:  357113820);
            decimal val_3 = CostMultiplier;
            decimal val_5 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 357113788}, d2:  new System.Decimal() {flags = val_4});
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
            {
                    var val_17 = 28081249;
                val_17 = 7544812 + val_17;
                if(val_17 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_20 = null;
                val_20 = null;
                PurchaseProxy.currentPurchasePoint = 121;
                GameBehavior val_7 = App.getBehavior;
                0.Init(outOfCredits:  true, onCloseAction:  0);
                return;
            }
            
            val_17 = 0;
            decimal val_9 = System.Decimal.op_Implicit(value:  357113820);
            decimal val_10 = CostMultiplier;
            val_18 = val_14;
            decimal val_15 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 357113788}, d2:  new System.Decimal() {flags = val_4, hi = val_11, lo = val_18, mid = val_13});
            val_19 = "Streak Saver";
            bool val_16 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  val_19, externalParams:  val_17, animated:  false);
            val_21 = this.brokenStreak;
            mem[1152921513553907488] = 1;
            mem[1152921513553907452] = val_21;
            val_22 = null;
            val_21 = mem[1152921513553907452];
            val_22 = null;
            UnityEngine.PlayerPrefs.SetInt(key:  WordForest.WFOWordStreak.PREFS_LAST_STREAK, value:  val_21);
            this.brokenStreak = val_17;
            mem[1152921513553907464].interactable = false;
            this.AnimateStreakSaved();
        }
        private void AnimateStreakSaved()
        {
            UnityEngine.Vector3 val_1 = position;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.upsellStreakBadge, endValue:  new UnityEngine.Vector3(), duration:  val_1.x, snapping:  false);
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  357247088, method:  new IntPtr(357222064));
            object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.upsellStreakBadge, action:  190734336);
            object val_5 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.upsellStreakBadge, delay:  val_1.x);
            object val_6 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  this.upsellStreakBadge, autoKillOnCompletion:  true);
            this.streakMoverTween = this.upsellStreakBadge;
        }
        private void OnAnimComplete()
        {
            DG.Tweening.TweenExtensions.Kill(t:  this.streakMoverTween, complete:  false);
            UnityEngine.GameObject val_1 = this.upsellStreakBadge.gameObject;
            this.upsellStreakBadge.SetActive(value:  true);
            this.particles.Play();
            this.UpdateStreakCounterLabel();
            this.PlayBorderEffects(restoreEffects:  false);
        }
        private void CancelStreakSaverAnimation()
        {
            DG.Tweening.TweenExtensions.Kill(t:  this.streakMoverTween, complete:  false);
            this.upsellStreakBadge.position = new UnityEngine.Vector3() {x = mem[this.upsellBadgeInitialPos + (0)], y = mem[this.upsellBadgeInitialPos + (4)], z = mem[this.upsellBadgeInitialPos + (8)]};
            UnityEngine.GameObject val_1 = this.upsellStreakBadge.gameObject;
            this.upsellStreakBadge.SetActive(value:  false);
            this.UpdateStreakCounterLabel();
            this.PlayBorderEffects(restoreEffects:  false);
        }
        public WFOWordStreak()
        {
        
        }
        private static WFOWordStreak()
        {
            WordForest.WFOWordStreak.PREFS_LAST_STREAK = "prefs_wfo_last_streak";
        }
    
    }

}
