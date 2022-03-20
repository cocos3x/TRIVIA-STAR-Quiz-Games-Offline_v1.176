using UnityEngine;
public class WGSpinKingSlotPopup : MonoSingleton<WGSpinKingSlotPopup>
{
    // Fields
    private UnityEngine.GameObject window;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private CurrencyCollectAnimationInstantiator gemAnimControl;
    private CurrencyCollectAnimationInstantiator goldCurrencyAnimControl;
    private WADPetFoodAnimationInstantiator foodAnimControl;
    private WADPetCardAnimationInstantiator petsCardAnimControl;
    private UnityEngine.Sprite big_coin_sprite;
    private UnityEngine.Sprite small_coin_sprite;
    private UnityEngine.Sprite apple_sprite;
    private UnityEngine.Sprite card_sprite;
    private UnityEngine.Sprite food_sprite;
    private UnityEngine.Sprite gem_sprite;
    private UnityEngine.UI.Text text_progress;
    private UnityEngine.UI.Image progressBar;
    private MultiGraphicButton spinBtn;
    private UnityEngine.UI.Button closeBtn;
    private UnityEngine.GameObject spin_result_go;
    private UnityEngine.UI.Text spin_result_text;
    private UnityEngine.UI.Image spin_result_icon;
    public SpinKingReelsController ReelController;
    public UnityEngine.GameObject popupInfoBtn;
    private UnityEngine.GameObject footerTimer;
    private UnityEngine.UI.Text time_left_text;
    private UnityEngine.GameObject no_spin_popup;
    private UnityEngine.GameObject no_spin_close_btn;
    private MultiGraphicButton no_spin_level_btn;
    private UnityEngine.UI.Text no_spin_level_txt;
    private MultiGraphicButton no_spin_continue_btn;
    private UnityEngine.GameObject ftux_go;
    private MultiGraphicButton ftux_spinBtn;
    private UnityEngine.UI.Text ftux_message_text;
    private SpinKingOutCome spinResult;
    private WADPets.WADPet petCard;
    private System.Collections.Generic.Dictionary<SpinKingSlotMachine.SpinKingSymbol, UnityEngine.Sprite> symbolSprites;
    private System.Collections.Generic.Dictionary<SpinKingSlotMachine.SpinType, System.Action<System.Collections.Generic.Dictionary<string, object>>> spinningStopActions;
    
    // Methods
    public override void InitMonoSingleton()
    {
        if(this.coinsAnimControl != 0)
        {
                if(this.coinsAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(this.gemAnimControl != 0)
        {
                if(this.gemAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(this.goldCurrencyAnimControl != 0)
        {
                if(this.goldCurrencyAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(this.foodAnimControl != 0)
        {
                if(this.foodAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(this.petsCardAnimControl != 0)
        {
                if(this.petsCardAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        this.symbolSprites.Add(key:  1, value:  this.big_coin_sprite);
        this.symbolSprites.Add(key:  2, value:  this.small_coin_sprite);
        this.symbolSprites.Add(key:  3, value:  this.apple_sprite);
        this.symbolSprites.Add(key:  4, value:  this.card_sprite);
        this.symbolSprites.Add(key:  5, value:  this.food_sprite);
        this.symbolSprites.Add(key:  6, value:  this.gem_sprite);
        System.Action<twelvegigs.storage.JsonDictionary> val_11 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283066736));
        this.spinningStopActions.Add(key:  1, value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_12 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283066736));
        this.spinningStopActions.Add(key:  2, value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_13 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283066736));
        this.spinningStopActions.Add(key:  3, value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_14 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283081072));
        this.spinningStopActions.Add(key:  4, value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_15 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283081072));
        this.spinningStopActions.Add(key:  5, value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_16 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283081072));
        this.spinningStopActions.Add(key:  6, value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_17 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283094384));
        this.spinningStopActions.Add(key:  7, value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_18 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283099504));
        this.spinningStopActions.Add(key:  8, value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_19 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283104624));
        this.spinningStopActions.Add(key:  9, value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_20 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283109744));
        this.spinningStopActions.Add(key:  10, value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_21 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1011785424, method:  new IntPtr(3283114864));
        this.spinningStopActions.Add(key:  0, value:  7401472);
        string val_22 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_23 = App.Player;
        string val_24 = System.String.Format(format:  -1672741904, arg0:  13152256);
        UnityEngine.Events.UnityAction val_25 = new UnityEngine.Events.UnityAction(object:  -1011785424, method:  new IntPtr(3283124080));
        this.spinBtn.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_26 = new UnityEngine.Events.UnityAction(object:  -1011785424, method:  new IntPtr(3283129200));
        this.ftux_spinBtn.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_27 = new UnityEngine.Events.UnityAction(object:  -1011785424, method:  new IntPtr(3283138416));
        this.closeBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_28 = new UnityEngine.Events.UnityAction(object:  -1011785424, method:  new IntPtr(3283143536));
        this.no_spin_level_btn.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_29 = new UnityEngine.Events.UnityAction(object:  -1011785424, method:  new IntPtr(3283138416));
        this.no_spin_continue_btn.AddListener(call:  162246656);
        System.Action<System.Int32> val_30 = new System.Action<System.Int32>(object:  -1011785424, method:  new IntPtr(3283152752));
        this.ReelController.OnSpinReelStop = null;
        this.UpdateProgress(animate:  false);
        UnityEngine.Transform val_31 = this.spin_result_go.transform;
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.zero;
        this.spin_result_go.localScale = new UnityEngine.Vector3();
    }
    private void Start()
    {
        this.Invoke(methodName:  -1011504912, time:  null);
    }
    private void Update()
    {
        this.UpdateSlotEndTime();
    }
    public void SetPlayFromLevelComplete(bool level_complete)
    {
        bool val_1 = level_complete ^ 1;
        this.popupInfoBtn.SetActive(value:  val_1);
        this.footerTimer.SetActive(value:  val_1);
        UnityEngine.GameObject val_2 = this.no_spin_level_btn.gameObject;
        this.no_spin_level_btn.SetActive(value:  val_1);
        UnityEngine.GameObject val_3 = this.no_spin_continue_btn.gameObject;
        this.no_spin_continue_btn.SetActive(value:  level_complete);
        this.no_spin_close_btn.SetActive(value:  val_1);
        this.ftux_go.SetActive(value:  false);
        bool val_4 = SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.isBankedSpinsMax;
        if(level_complete != true)
        {
                return;
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  -1011256240, defaultValue:  0)) != 0)
        {
                return;
        }
        
        this.ftux_go.SetActive(value:  true);
        string val_6 = Localization.Localize(key:  -1011247728, defaultValue:  -1011247936, useSingularKey:  false);
        string val_7 = System.String.Format(format:  -1011247728, arg0:  13152256);
        UnityEngine.PlayerPrefs.SetInt(key:  -1011256240, value:  1);
    }
    public UnityEngine.Sprite GetSymbolSprite(SpinKingSlotMachine.SpinKingSymbol symbol)
    {
        if(this.symbolSprites != 0)
        {
                return this.symbolSprites.Item[symbol];
        }
        
        return this.symbolSprites.Item[symbol];
    }
    private void Spin()
    {
        string val_2;
        var val_2 = 28557866;
        val_2 = 7069808 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY;
        if((SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 32) > 0)
        {
            goto label_3;
        }
        
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY;
        if((SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 24) == 0)
        {
            goto label_6;
        }
        
        label_3:
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.Spin();
        this.spinBtn.interactable = false;
        SpinKingOutCome val_1 = SpinKingSlotMachine.CreateSpinOutCome();
        this.spinResult = 0;
        this.ReelController.StartSpin();
        this.UpdateProgress(animate:  true);
        return;
        label_6:
        this.window.SetActive(value:  false);
        this.no_spin_popup.SetActive(value:  true);
    }
    private void OnSpinReelStop(int reel)
    {
        if(reel != 2)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1010828688, value:  13152256);
        if(this.spinResult.SType != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1010820400, clipIndex:  0);
        }
        
        35627655 = this.spinResult.SType;
        System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> val_3 = this.spinningStopActions.Item[35627655];
        this.spinningStopActions.Invoke(obj:  78753792);
    }
    private void BigCoinSpinResultAction(System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        int val_3;
        Player val_1 = App.Player;
        decimal val_2 = System.Decimal.op_Implicit(value:  -1010645056);
        0.AddCredits(amount:  new System.Decimal() {mid = val_3}, source:  "Spin King", subSource:  0, externalParams:  additionalParams, doTrack:  true);
        System.Action val_4 = new System.Action(object:  -1010633008, method:  new IntPtr(3284309264));
        this.ShowReward(icon:  this.big_coin_sprite, amount:  this.spinResult.Reward, onComplete:  7454720);
    }
    private void SmallCoinSpinResultAction(System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        int val_3;
        Player val_1 = App.Player;
        decimal val_2 = System.Decimal.op_Implicit(value:  -1010499264);
        0.AddCredits(amount:  new System.Decimal() {mid = val_3}, source:  "Spin King", subSource:  0, externalParams:  additionalParams, doTrack:  true);
        System.Action val_4 = new System.Action(object:  -1010487216, method:  new IntPtr(3284455056));
        this.ShowReward(icon:  this.small_coin_sprite, amount:  this.spinResult.Reward, onComplete:  7454720);
    }
    private void ApplesSpinResultAction(System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_2 = new System.Action(object:  -1010341424, method:  new IntPtr(3284600848));
        this.ShowReward(icon:  this.apple_sprite, amount:  this.spinResult.Reward, onComplete:  7454720);
    }
    private void CardsSpinResultAction(System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        this.GetNewPet();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RewardPetCards(amount:  this.spinResult.Reward, pet:  this.petCard, source:  -1010666320, subsource:  0, additionalParam:  additionalParams);
        System.Action val_2 = new System.Action(object:  -1010191536, method:  new IntPtr(3284750736));
        this.ShowReward(icon:  this.card_sprite, amount:  this.spinResult.Reward, onComplete:  7454720);
    }
    private void FoodSpinResultAction(System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        Player val_1 = App.Player;
        0.AddPetsFood(amount:  this.spinResult.Reward, source:  -1010666320, subSource:  null, FoodSpentParams:  0, additionalParam:  additionalParams);
        System.Action val_2 = new System.Action(object:  -1010041648, method:  new IntPtr(3284900624));
        this.ShowReward(icon:  this.food_sprite, amount:  this.spinResult.Reward, onComplete:  7454720);
    }
    private void GemsSpinResultAction(System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        Player val_1 = App.Player;
        0.AddGems(amount:  this.spinResult.Reward, source:  -1010666320, subsource:  null);
        Player val_2 = App.Player;
        string val_3 = this.spinResult.Reward.ToString();
        0.TrackNonCoinReward(source:  -1010666320, subSource:  null, rewardType:  -1668821072, rewardAmount:  this.spinResult.Reward, additionalParams:  additionalParams);
        System.Action val_4 = new System.Action(object:  -1009891760, method:  new IntPtr(3285050512));
        this.ShowReward(icon:  this.gem_sprite, amount:  this.spinResult.Reward, onComplete:  7454720);
    }
    private void UpdateSlotEndTime()
    {
        var val_12 = 28559918;
        val_12 = 7067756 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        System.TimeSpan val_1 = GetRemainingTime();
        string val_2 = Localization.Localize(key:  -1009779184, defaultValue:  -1009779088, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "spin_king_ends";
        typeof(System.String[]).__il2cppRuntimeField_14 = " ";
        string val_4 = ???.Days.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_18 = ;
        typeof(System.String[]).__il2cppRuntimeField_1C = ":";
        string val_6 = ???.Hours.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_20 = ;
        typeof(System.String[]).__il2cppRuntimeField_24 = ":";
        string val_8 = ???.Minutes.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_28 = ;
        typeof(System.String[]).__il2cppRuntimeField_2C = ":";
        string val_10 = ???.Seconds.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_30 = ;
        string val_11 = +477709520;
        if(this.time_left_text != 0)
        {
                return;
        }
    
    }
    private void GetNewPet()
    {
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        var val_9;
        var val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WADPets.WADPet val_2 = GetRandomPet();
        this.petCard = public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance();
        WADPets.WADPetUpgradeRequirement val_3 = WADPetsManager.GetUpgradeRequirement(levelIndex:  public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance().__il2cppRuntimeField_C);
        val_9 = 0;
        decimal val_4 = System.Decimal.op_Implicit(value:  -1009642736);
        if(this.petsCardAnimControl != 0)
        {
                val_10 = null;
            val_10 = null;
            val_9 = 0;
            if(((WADPetCardAnimationInstantiator.__il2cppRuntimeField_typeHierarchy + (PetsCardStatView.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_10)
        {
                this.petsCardAnimControl = 0;
        }
        
            val_9 = this.petsCardAnimControl;
        }
        
        val_9.Setup(pet:  this.petCard, progressStartBalance:  new System.Decimal() {flags = val_6, hi = val_7, lo = val_8, mid = val_5}, upgradeRequirement:  public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance().__il2cppRuntimeField_C);
    }
    private void UpdateProgress(bool animate)
    {
        var val_9;
        bool val_10;
        float val_9 = 6.605036E-38f;
        val_9 = 7066680 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY != null)
        {
                val_9 = mem[SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 32];
            val_9 = SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 32;
        }
        else
        {
                val_9 = mem[SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 32];
            val_9 = SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 32;
            if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        val_10 = animate;
        float val_2 = (float)val_9 / ((float)SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 28 + 12);
        if(val_10 != false)
        {
                WGSpinKingSlotPopup.<>c__DisplayClass50_0 val_3 = new WGSpinKingSlotPopup.<>c__DisplayClass50_0();
            typeof(WGSpinKingSlotPopup.<>c__DisplayClass50_0).__il2cppRuntimeField_C = this;
            typeof(WGSpinKingSlotPopup.<>c__DisplayClass50_0).__il2cppRuntimeField_8 = mem[1152921512187277280] + 128;
            DG.Tweening.Core.DOSetter<System.Single> val_4 = new DG.Tweening.Core.DOSetter<System.Single>(object:  333651968, method:  new IntPtr(3285436896));
            DG.Tweening.Tweener val_5 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  (float)SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 28 + 12, endValue:  null, duration:  (float)val_9);
            object val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  1);
            val_10 = null;
            val_10 = new DG.Tweening.TweenCallback(object:  333651968, method:  new IntPtr(3285437920));
            object val_8 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198881280, action:  190734336);
            return;
        }
        
        mem[1152921512187277280].fillAmount = (float)SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 28 + 12;
    }
    private void ShowReward(UnityEngine.Sprite icon, int amount, System.Action onComplete)
    {
        if((new WGSpinKingSlotPopup.<>c__DisplayClass51_0()) != 0)
        {
                typeof(WGSpinKingSlotPopup.<>c__DisplayClass51_0).__il2cppRuntimeField_8 = onComplete;
        }
        else
        {
                mem[8] = onComplete;
        }
        
        typeof(WGSpinKingSlotPopup.<>c__DisplayClass51_0).__il2cppRuntimeField_C = this;
        this.spin_result_icon.sprite = icon;
        string val_2 = amount.ToString();
        DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_4 = this.spin_result_go.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.spin_result_go, endValue:  new UnityEngine.Vector3(), duration:  val_5.x);
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  333705216, method:  new IntPtr(3285575520));
        object val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.spin_result_go, action:  190734336);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.spin_result_go);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_5.x);
        DG.Tweening.TweenCallback val_11 = new DG.Tweening.TweenCallback(object:  333705216, method:  new IntPtr(3285576544));
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_5.x);
        UnityEngine.Transform val_14 = this.spin_result_go.transform;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.spin_result_go, endValue:  new UnityEngine.Vector3(), duration:  val_15.x);
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.spin_result_go);
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_15.x);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1009225056, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY == null)
        {
            
        }
    
    }
    public WGSpinKingSlotPopup()
    {
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        this.symbolSprites = null;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_2 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        this.spinningStopActions = null;
    }
    private void <InitMonoSingleton>b__35_0(System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        this.spinBtn.interactable = true;
    }
    private void <InitMonoSingleton>b__35_1()
    {
        this.Spin();
        this.ftux_go.SetActive(value:  false);
    }
    private void <InitMonoSingleton>b__35_2()
    {
        var val_9;
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_3 = val_2.m_Handle.name;
        val_9;
        if(0 != 2)
        {
                val_9 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayingChallenge = false;
        }
        
            GameBehavior val_7 = App.getBehavior;
        }
        
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1008749408, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void <BigCoinSpinResultAction>b__42_0()
    {
        int val_6;
        if(this.coinsAnimControl == 0)
        {
                return;
        }
        
        Player val_2 = App.Player;
        decimal val_3 = System.Decimal.op_Implicit(value:  -1008637172);
        decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1008637188, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_5 = App.Player;
        this.coinsAnimControl.Play(fromValue:  new System.Decimal() {mid = val_6}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void <SmallCoinSpinResultAction>b__43_0()
    {
        int val_6;
        if(this.coinsAnimControl == 0)
        {
                return;
        }
        
        Player val_2 = App.Player;
        decimal val_3 = System.Decimal.op_Implicit(value:  -1008500596);
        decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1008500612, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_5 = App.Player;
        this.coinsAnimControl.Play(fromValue:  new System.Decimal() {mid = val_6}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void <ApplesSpinResultAction>b__44_0()
    {
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        if(this.goldCurrencyAnimControl == 0)
        {
                return;
        }
        
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        decimal val_4 = System.Decimal.op_Implicit(value:  -1008364016);
        this.goldCurrencyAnimControl.Play(fromValue:  4 - this.spinResult.Reward, toValue:  new System.Decimal() {flags = val_7, hi = val_8, lo = val_6, mid = val_5}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void <CardsSpinResultAction>b__45_0()
    {
        int val_6;
        var val_7;
        WGSpinKingSlotPopup.<>c__DisplayClass45_0 val_1 = new WGSpinKingSlotPopup.<>c__DisplayClass45_0();
        typeof(WGSpinKingSlotPopup.<>c__DisplayClass45_0).__il2cppRuntimeField_10 = this;
        WADPets.WADPetUpgradeRequirement val_2 = WADPetsManager.GetUpgradeRequirement(levelIndex:  this.petCard.LevelIndex);
        typeof(WGSpinKingSlotPopup.<>c__DisplayClass45_0).__il2cppRuntimeField_C = this.petCard.LevelIndex;
        val_6 = this.petCard.LevelIndex;
        if(this.petCard == 0)
        {
                val_6 = typeof(WGSpinKingSlotPopup.<>c__DisplayClass45_0).__il2cppRuntimeField_C;
        }
        
        float val_6 = (float)this.petCard.LevelIndex + 8;
        val_6 = (float)this.petCard.Cards / val_6;
        float val_3 = UnityEngine.Mathf.Min(a:  val_6, b:  null);
        typeof(WGSpinKingSlotPopup.<>c__DisplayClass45_0).__il2cppRuntimeField_8 = val_6;
        val_7 = null;
        val_7 = null;
        this.petsCardAnimControl.Play(fromValue:  0, toValue:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, textTickTime:  val_3, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  333598720, method:  new IntPtr(3286727904));
        DG.Tweening.Tween val_5 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_3, callback:  1065353216, ignoreTimeScale:  false);
    }
    private void <FoodSpinResultAction>b__46_0()
    {
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        if(this.foodAnimControl == 0)
        {
                return;
        }
        
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        decimal val_4 = System.Decimal.op_Implicit(value:  -1008089840);
        this.foodAnimControl.Play(fromValue:  1 - this.spinResult.Reward, toValue:  new System.Decimal() {flags = val_7, hi = val_8, lo = val_6, mid = val_5}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void <GemsSpinResultAction>b__47_0()
    {
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        if(this.gemAnimControl == 0)
        {
                return;
        }
        
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        decimal val_4 = System.Decimal.op_Implicit(value:  -1007953264);
        this.gemAnimControl.Play(fromValue:  0 - this.spinResult.Reward, toValue:  new System.Decimal() {flags = val_7, hi = val_8, lo = val_6, mid = val_5}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }

}
