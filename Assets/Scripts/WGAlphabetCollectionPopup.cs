using UnityEngine;
public class WGAlphabetCollectionPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject progressWindow;
    private UnityEngine.GameObject completeWindow;
    private UnityEngine.GameObject infoWindow;
    private AlphabetWordRegion wordRegion;
    private UnityEngine.UI.Slider progressSlider;
    private UnityEngine.UI.Text sliderLabel;
    private UnityEngine.GameObject progressCoinRewardGroup;
    private UnityEngine.UI.Text rewardAmount;
    private UnityEngine.UI.Button infoButton;
    private UnityEngine.UI.Button closeInfoButton;
    private UnityEngine.UI.Button closeButton;
    private AlphabetWordRegion wordRegionComplete;
    private UnityEngine.GameObject completeCoinRewardGroup;
    private UnityEngine.UI.Text rewardAmountComplete;
    private UnityEngine.UI.Button collectButton;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private bool startInfo;
    
    // Properties
    private UnityEngine.GameObject collectParticle { get; }
    
    // Methods
    private UnityEngine.GameObject get_collectParticle()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1752778768, prefabName:  -1559151072);
    }
    public void SetupWithInfo()
    {
        this.startInfo = true;
    }
    private void Start()
    {
        this.Setup();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1558866096, method:  new IntPtr(2736048528));
        this.infoButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1558866096, method:  new IntPtr(2736057744));
        this.closeInfoButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1558866096, method:  new IntPtr(2736066960));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1558866096, method:  new IntPtr(2736076176));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void Setup()
    {
        var val_24;
        var val_26;
        UnityEngine.UI.Text val_27;
        val_24 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_26 = IsCurrentCollectionComplete();
        if(this.startInfo != false)
        {
                this.ShowInfoWindow();
            return;
        }
        
        if(val_26 != false)
        {
                this.progressWindow.SetActive(value:  false);
            this.infoWindow.SetActive(value:  false);
            this.completeWindow.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_4 = GetCurrentCollection;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_6 = GetCurrentCollectionProgress;
            val_24 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
            this.wordRegionComplete.Setup(requiredWords:  -2100700048, progressWords:  -2100700048);
            this.completeCoinRewardGroup.SetActive(value:  true);
            val_27 = this.rewardAmountComplete;
        }
        else
        {
                this.progressWindow.SetActive(value:  true);
            this.infoWindow.SetActive(value:  false);
            this.completeWindow.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_8 = GetCurrentCollection;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_10 = GetCurrentCollectionProgress;
            this.wordRegion.Setup(requiredWords:  -2100700048, progressWords:  -2100700048);
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_12 = GetCurrentCollectionBox;
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_24 = (float)public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C;
            val_24 = ((float)public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C) / val_24;
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_15 = GetCurrentCollectionBox;
            string val_16 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C.ToString();
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_24 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
            string val_18 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C.ToString();
            string val_19 = System.String.Format(format:  1629069648, arg0:  -1558680116, arg1:  -1558680116);
            this.progressCoinRewardGroup.SetActive(value:  true);
            val_27 = this.rewardAmount;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_21 = GetCurrentRewardAmount;
        GameEcon val_22 = App.getGameEcon;
        string val_23 = ToString(format:  null);
    }
    private void onClick_Info()
    {
        this.ShowInfoWindow();
    }
    private void onClick_CloseInfo()
    {
        if(this.startInfo != false)
        {
                this.startInfo = false;
            this.Setup();
            return;
        }
        
        this.progressWindow.SetActive(value:  true);
        this.infoWindow.SetActive(value:  false);
    }
    private void onClick_Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1558262448, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1558150448, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void ShowInfoWindow()
    {
        this.progressWindow.SetActive(value:  false);
        this.infoWindow.SetActive(value:  true);
    }
    private void onClick_Collect()
    {
        this.collectButton.interactable = false;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_2 = GetCurrentRewardAmount;
        CurrencyController.CreditBalance(value:  new System.Decimal(), source:  "Alphabet Collection", externalParams:  0, animated:  false);
        System.Collections.IEnumerator val_3 = this.PlayCelebrationAnimation();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -1557905856);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CompleteCurrentCollection();
    }
    private System.Collections.IEnumerator PlayCelebrationAnimation()
    {
        object val_1 = new System.Object();
        typeof(WGAlphabetCollectionPopup.<PlayCelebrationAnimation>d__28).__il2cppRuntimeField_8 = 0;
        typeof(WGAlphabetCollectionPopup.<PlayCelebrationAnimation>d__28).__il2cppRuntimeField_10 = this;
    }
    private void OnCoinsAnimFinished()
    {
        this.Setup();
    }
    public WGAlphabetCollectionPopup()
    {
    
    }

}
