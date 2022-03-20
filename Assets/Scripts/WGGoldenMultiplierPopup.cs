using UnityEngine;
public class WGGoldenMultiplierPopup : MonoBehaviour
{
    // Fields
    private const float BASE_HEIGHT = 1060;
    private const float BONUSUI_HEIGHT = 150;
    private const float BONUSUI_SPACE = 20;
    private UnityEngine.UI.Text multiplierText;
    private UnityEngine.UI.Text addMultiplierButtonText;
    private UnityEngine.UI.Text addMultiplierButtonCostText;
    private UnityEngine.GameObject addMultiplierButtonCostGroup;
    private MultiGraphicButton addMultiplierButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.GameObject notEnoughTooltip;
    private UnityEngine.GameObject flourishParticle;
    private UnityEngine.GameObject bonusPrefab;
    private UnityEngine.RectTransform bonusesParent;
    private UnityEngine.RectTransform mainUI;
    private UnityEngine.Sprite subs;
    private UnityEngine.Sprite difficulty;
    private UnityEngine.GameObject subsBonusUI;
    private UnityEngine.GameObject difficultyBonusUI;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1225311968, method:  new IntPtr(3069625184));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1225311968, method:  new IntPtr(3069630304));
        this.addMultiplierButton.AddListener(call:  162246656);
    }
    private void Start()
    {
        this.UpdateUI();
    }
    private void UpdateUI()
    {
        UnityEngine.UI.Text val_18;
        var val_19;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_2 = GetCurrentGoldenMultiplier;
        string val_3 = public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance().ToString(format:  -1232360064);
        string val_4 = System.String.Format(format:  -1232359984, arg0:  -1225066788);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_6 = IsMaxGoldedMultiplier;
        bool val_7 = val_6 ^ 1;
        this.addMultiplierButton.interactable = val_7;
        this.addMultiplierButtonCostGroup.SetActive(value:  val_7);
        val_18 = this.addMultiplierButtonText;
        if(val_6 != false)
        {
                val_19 = "max_reached_upper";
            string val_8 = Localization.Localize(key:  -1225083200, defaultValue:  -1225083296, useSingularKey:  false);
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_10 = GetMultiplierIncrement;
            string val_11 = public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance().ToString(format:  -1225083088);
            val_19 = "+{0}X";
            string val_12 = System.String.Format(format:  -1225083008, arg0:  -1225066788);
        }
        
        if(val_6 != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_14 = GetNextCost;
            GameEcon val_15 = App.getGameEcon;
            string val_16 = public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance().ToString(format:  null);
            string val_17 = System.String.Format(format:  -1225078832, arg0:  -1225066788);
            val_18 = "{0}";
        }
        
        this.SetupBonusSection();
    }
    private void OnClick_AddMultiplierButton()
    {
        float val_11;
        float val_12;
        float val_13;
        UnityEngine.AnimationCurve val_14;
        UnityEngine.AnimationCurve val_15;
        var val_20;
        float val_21;
        val_20 = 1152921504901095424;
        val_21 = 1152921511964420480;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PurchaseMultiplier() != false)
        {
                UnityEngine.Transform val_3 = this.multiplierText.transform;
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.flourishParticle, parent:  this.multiplierText, worldPositionStays:  false);
            object val_5 = this.flourishParticle.GetComponent<System.Object>();
            EmissionModule val_6 = this.flourishParticle.emission;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_8 = GetCurrentGoldenMultiplier;
            float val_20 = 100f;
            val_20 = 3062606208 * val_20;
            int val_9 = UnityEngine.Mathf.RoundToInt(f:  val_20);
            if(42949672 == 0)
        {
                100 = 300;
        }
        
            MinMaxCurve val_10 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  600f);
            val_12 = val_10.m_ConstantMin;
            ParticleSystem.Burst val_17 = new ParticleSystem.Burst(_time:  600f, _count:  new MinMaxCurve() {m_CurveMultiplier = val_12, m_CurveMin = val_14, m_CurveMax = val_15, m_ConstantMin = val_11, m_ConstantMax = val_13});
            val_21 = val_17.m_Time;
            val_6.m_ParticleSystem.SetBurst(index:  0, burst:  new Burst() {m_Time = val_17.m_Time, m_Count = new MinMaxCurve() {m_Mode = val_17.m_Count.m_Mode, m_CurveMultiplier = val_21, m_CurveMin = val_17.m_Count.m_CurveMin, m_CurveMax = val_17.m_Count.m_CurveMax, m_ConstantMin = val_17.m_Count.m_ConstantMin, m_ConstantMax = val_17.m_Count.m_ConstantMax}, m_RepeatCount = val_17.m_RepeatCount, m_RepeatInterval = val_17.m_RepeatInterval, m_InvProbability = val_17.m_InvProbability});
            this.flourishParticle.Play();
            this.UpdateUI();
            return;
        }
        
        System.Collections.IEnumerator val_18 = this.ShowNotEnoughTooltip();
        UnityEngine.Coroutine val_19 = this.StartCoroutine(routine:  -1224914080);
    }
    private System.Collections.IEnumerator ShowNotEnoughTooltip()
    {
        object val_1 = new System.Object();
        typeof(WGGoldenMultiplierPopup.<ShowNotEnoughTooltip>d__22).__il2cppRuntimeField_8 = 0;
        typeof(WGGoldenMultiplierPopup.<ShowNotEnoughTooltip>d__22).__il2cppRuntimeField_10 = this;
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1224681888, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void SetupBonusSection()
    {
        var val_23;
        var val_24;
        UnityEngine.GameObject val_25;
        UnityEngine.Sprite val_26;
        var val_27;
        UnityEngine.GameObject val_28;
        val_23 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_24 = 0;
        float val_2 = GetCurrentBonusFromSubs;
        if((public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance()) > 0)
        {
                if(this.subsBonusUI == 0)
        {
                object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.bonusPrefab, parent:  this.bonusesParent);
            val_25 = this.bonusPrefab;
            this.subsBonusUI = this.bonusPrefab;
        }
        else
        {
                val_25 = this.subsBonusUI;
        }
        
            val_26 = this.subs;
            string val_5 = Localization.Localize(key:  1098586544, defaultValue:  -1224577504, useSingularKey:  false);
            val_27 = "";
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_7 = GetCurrentBonusFromSubs;
            string val_8 = public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance().ToString();
            string val_9 = System.String.Format(format:  1098586544, arg0:  -1224536556);
            SetUpBonusUI(bonusUI:  val_25, iconImage:  val_26, descText:  1098586544);
            val_24 = 1;
            val_23 = 1152921504901095424;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_11 = GetCurrentBonusFromDifficulty;
        if((public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance()) <= 0)
        {
            goto label_17;
        }
        
        if(this.difficultyBonusUI != 0)
        {
            goto label_20;
        }
        
        object val_13 = UnityEngine.Object.Instantiate<System.Object>(original:  this.bonusPrefab, parent:  this.bonusesParent);
        val_28 = this.bonusPrefab;
        this.difficultyBonusUI = this.bonusPrefab;
        goto label_23;
        label_17:
        if(val_24 == 0)
        {
                20f = 0;
        }
        
        goto label_24;
        label_20:
        val_28 = this.difficultyBonusUI;
        label_23:
        val_26 = this.difficulty;
        string val_14 = Localization.Localize(key:  1098586544, defaultValue:  -1224556864, useSingularKey:  false);
        val_27 = "";
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_23 = public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance();
        float val_16 = GetCurrentBonusFromDifficulty;
        string val_17 = val_23.ToString();
        string val_18 = System.String.Format(format:  1098586544, arg0:  -1224536556);
        SetUpBonusUI(bonusUI:  val_28, iconImage:  val_26, descText:  1098586544);
        val_24 = val_24 + 1;
        label_24:
        float val_19 = 20f + 1060f;
        UnityEngine.Vector2 val_20 = sizeDelta;
        UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_20.x, y:  val_20.y);
        this.mainUI.sizeDelta = new UnityEngine.Vector2() {x = val_22.x, y = val_22.y};
    }
    private void SetUpBonusUI(UnityEngine.GameObject bonusUI, UnityEngine.Sprite iconImage, string descText)
    {
        T[] val_1 = bonusUI.GetComponentsInChildren<System.Object>();
        if(bonusUI != 0)
        {
                bonusUI.sprite = iconImage;
        }
        else
        {
                0.sprite = iconImage;
        }
        
        bonusUI.preserveAspect = true;
        object val_2 = bonusUI.GetComponentInChildren<System.Object>();
        if(bonusUI == 0)
        {
            
        }
    
    }
    public WGGoldenMultiplierPopup()
    {
    
    }

}
