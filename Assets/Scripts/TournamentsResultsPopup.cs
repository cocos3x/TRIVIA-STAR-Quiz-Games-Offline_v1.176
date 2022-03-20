using UnityEngine;
public class TournamentsResultsPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button_continue;
    private UnityEngine.UI.Button button_collect;
    private TournamentsTierDisplay tier_display;
    private UnityEngine.UI.Text text_rank;
    private UnityEngine.UI.Text text_rank_ordinal;
    private UnityEngine.UI.Text text_gemReward;
    private UnityEngine.UI.Text text_coinReward;
    private UnityEngine.GameObject giftReward;
    private UnityEngine.GameObject promotion;
    private UnityEngine.GameObject demotion;
    private CurrencyCollectAnimationInstantiator coinsAnimControl;
    private CurrencyCollectAnimationInstantiator gemAnimControl;
    private int coins;
    private int gemsOrPetFood;
    private System.Collections.Generic.List<GiftReward> giftRewards;
    private bool canCollect;
    
    // Properties
    private int PlayerCurrentGemsOrPetFood { get; }
    
    // Methods
    private int get_PlayerCurrentGemsOrPetFood()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_4 = 25352771;
        val_4 = 10273016 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_6 = 0;
        if(val_4 != 0)
        {
                val_6 = (App.__il2cppRuntimeField_BA & 512);
        }
        
        if(App.game == 17)
        {
                Player val_2 = App.Player;
            val_7 = 92;
            return (int)val_7;
        }
        
        Player val_3 = App.Player;
        val_7 = 84;
        return (int)val_7;
    }
    private void Awake()
    {
        var val_7;
        var val_8;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1661146752, method:  new IntPtr(2633777088));
        this.button_collect.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1661146752, method:  new IntPtr(2633777088));
        this.button_continue.m_OnClick.AddListener(call:  162246656);
        System.Action val_3 = new System.Action(object:  -1661146752, method:  new IntPtr(2633790400));
        System.Delegate val_4 = System.Delegate.Combine(a:  this.button_continue.m_OnClick, b:  7454720);
        val_7 = this.button_continue.m_OnClick;
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_8;
        }
        
        }
        
        val_7 = 0;
        label_8:
        mem2[0] = val_7;
        System.Action val_5 = new System.Action(object:  -1661146752, method:  new IntPtr(2633795520));
        System.Delegate val_6 = System.Delegate.Combine(a:  0, b:  7454720);
        val_8 = val_7;
        if(val_8 != 0)
        {
                if(1179403647 == null)
        {
            goto label_12;
        }
        
        }
        
        val_8 = 0;
        label_12:
        mem2[0] = val_8;
    }
    public void ShowResults(int coinReward, int gemsOrPetFoodReward, System.Collections.Generic.List<GiftReward> giftRewards, int rankIndex, int lastTournamentTier)
    {
        var val_15;
        bool val_16;
        bool val_15 = true;
        this.coins = coinReward;
        this.gemsOrPetFood = gemsOrPetFoodReward;
        this.giftRewards = giftRewards;
        coinReward = gemsOrPetFoodReward + coinReward;
        val_15 = coinReward + val_15;
        if(val_15 > 0)
        {
                0 = 1;
        }
        
        this.canCollect = true;
        this.tier_display.RefreshDisplay(tierIndex:  lastTournamentTier);
        int val_1 = rankIndex + 1;
        string val_2 = val_1.ToString();
        string val_3 = Ordinal.AddOrdinal(num:  val_1);
        UnityEngine.GameObject val_4 = this.giftReward.gameObject;
        if(this.text_rank_ordinal > 0)
        {
                0 = 1;
        }
        
        this.giftReward.SetActive(value:  true);
        string val_5 = gemsOrPetFoodReward.ToString();
        string val_6 = System.String.Format(format:  2128510224, arg0:  -1660977164);
        string val_7 = coinReward.ToString();
        string val_8 = System.String.Format(format:  2128510224, arg0:  -1660977160);
        if(lastTournamentTier != 0)
        {
                val_15 = TournamentsEconomy.RankIndexIsPromotion(rankIndex:  rankIndex);
        }
        else
        {
                val_15 = 0;
        }
        
        val_16 = 0;
        this.promotion.SetActive(value:  false);
        if((TournamentsEconomy.TierIndexCanDemote(tierIndex:  lastTournamentTier)) != false)
        {
                val_16 = TournamentsEconomy.RankIndexIsDemotion(rankIndex:  rankIndex);
        }
        
        this.demotion.SetActive(value:  val_16);
        UnityEngine.GameObject val_12 = this.button_collect.gameObject;
        if(this.canCollect == true)
        {
                this.canCollect = 1;
        }
        
        this.button_collect.SetActive(value:  true);
        UnityEngine.GameObject val_13 = this.button_continue.gameObject;
        this.button_continue.SetActive(value:  this.button_continue >> 5);
    }
    private void OnCollectContinueClicked()
    {
        float val_17;
        float val_18;
        CurrencyCollectAnimationInstantiator val_19;
        int val_20;
        int val_21;
        int val_22;
        int val_23;
        CurrencyCollectAnimationInstantiator val_24;
        if(this.canCollect == false)
        {
                this.canCollect = this;
            this.OnCollectAnimsFinished();
        }
        
        if(this.coins >= 1)
        {
                if(this.gemsOrPetFood >= 1)
        {
                Player val_2 = App.Player;
            var val_3 = 0 + 60;
            val_18 = 3.587324E-43f;
            val_19 = 0;
            val_20 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = 256});
            val_21 = this.coins;
            Player val_5 = App.Player;
            val_22 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256});
            val_23 = val_20 - val_21;
            val_24 = this.coinsAnimControl;
        }
        else
        {
                Player val_7 = App.Player;
            var val_8 = 0 + 64;
            val_17 = 7.286752E-44f;
            val_19 = 0;
            val_18 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = 52, hi = mem[(0 + 64) + (0)], lo = mem[(0 + 64) + (4)], mid = mem[(0 + 64) + (8)]});
            val_20 = this.coins;
            Player val_10 = App.Player;
            val_21 = null;
            val_21 = new System.Action(object:  -1660790656, method:  new IntPtr(2634139328));
            val_23 = val_18 - val_20;
            val_24 = this.coinsAnimControl;
            val_22 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256});
        }
        
            this.AnimatePurchase(animControl:  val_24, fromAmount:  val_23, toAmount:  val_22, actionOnComplete:  val_21, delay:  null);
        }
        
        if(this.gemsOrPetFood >= 1)
        {
                val_19 = this.gemAnimControl;
            int val_13 = this.gemsOrPetFood.PlayerCurrentGemsOrPetFood;
            val_18 = val_13;
            val_20 = this.gemsOrPetFood;
            val_21 = val_13.PlayerCurrentGemsOrPetFood;
            System.Action val_15 = new System.Action(object:  -1660790656, method:  new IntPtr(2634139328));
            this.AnimatePurchase(animControl:  val_19, fromAmount:  val_18 - val_20, toAmount:  val_21, actionOnComplete:  null, delay:  null);
        }
        
        this.button_collect.interactable = false;
        this.button_continue.interactable = false;
    }
    private void AnimatePurchase(CurrencyCollectAnimationInstantiator animControl, int fromAmount, int toAmount, System.Action actionOnComplete, float delay = 0)
    {
        animControl.OnCompleteCallback = actionOnComplete;
        System.Collections.IEnumerator val_2 = this.StartAnimating(animControl:  animControl, fromAmount:  fromAmount, toAmount:  toAmount, delay:  delay);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -1660654080);
    }
    private System.Collections.IEnumerator StartAnimating(CurrencyCollectAnimationInstantiator animControl, int fromAmount, int toAmount, float delay)
    {
        float val_1;
        typeof(TournamentsResultsPopup.<StartAnimating>d__22).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TournamentsResultsPopup.<StartAnimating>d__22).__il2cppRuntimeField_14 = animControl;
            typeof(TournamentsResultsPopup.<StartAnimating>d__22).__il2cppRuntimeField_18 = fromAmount;
            typeof(TournamentsResultsPopup.<StartAnimating>d__22).__il2cppRuntimeField_1C = toAmount;
        }
        else
        {
                mem[20] = animControl;
            mem[24] = fromAmount;
            mem[28] = toAmount;
        }
        
        typeof(TournamentsResultsPopup.<StartAnimating>d__22).__il2cppRuntimeField_10 = val_1;
    }
    private void OnCollectAnimsFinished()
    {
        var val_8;
        System.Collections.Generic.List<GiftReward> val_9;
        System.Collections.Generic.List<GiftReward> val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleTournamentResultsCollected();
        if((this.giftRewards != 0) && (this.giftRewards >= 1))
        {
                var val_8 = 25350979;
            val_8 = 10274808 + val_8;
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_8 = null;
            val_8 = null;
            if(App.game == 17)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
            val_9 = this.giftRewards;
            if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
            goto label_16;
        }
        
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = ShowUGUIMonolith<System.Object>(showNext:  true);
            val_10 = this.giftRewards;
        }
        
        }
        
        label_16:
        UnityEngine.GameObject val_7 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1660399360, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TournamentsResultsPopup()
    {
    
    }
    private void <Awake>b__18_0()
    {
        Player val_1 = App.Player;
        this.coinsAnimControl.SetStatViewValue(instantValue:  (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256})) - this.coins);
    }
    private void <Awake>b__18_1()
    {
        this.gemAnimControl.SetStatViewValue(instantValue:  this.PlayerCurrentGemsOrPetFood - this.gemsOrPetFood);
    }

}
