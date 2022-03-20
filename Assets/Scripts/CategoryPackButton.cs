using UnityEngine;
public class CategoryPackButton : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.UI.Text packTitleLabel;
    private UnityEngine.UI.Image packTitleBackground;
    private UnityEngine.GameObject completionMeterObject;
    private UnityEngine.UI.Slider completionMeterSlider;
    private UnityEngine.UI.Text completionMeterLabel;
    private UnityEngine.UI.Text unlockCostLabel;
    private UnityEngine.UI.Button buttonPack;
    private UnityEngine.GameObject badgeNew;
    private UnityEngine.UI.Image badgeCompleted;
    private UnityEngine.GameObject groupStateLocked;
    private UnityEngine.GameObject groupStateUnlocked;
    private UnityEngine.GameObject groupStateCompleted;
    private UnityEngine.GameObject timerObject;
    private UnityEngine.UI.Text timerLabel;
    private CategoryPackInfo packData;
    
    // Properties
    public int PackId { get; }
    public UnityEngine.UI.Image BadgeCompleted { get; }
    
    // Methods
    public int get_PackId()
    {
        if(this.packData != 0)
        {
                this.packData = this.packData.packId;
        }
        
        if(this.packData == 0)
        {
                this.packData = 0;
        }
        
        return (int)this.packData;
    }
    public UnityEngine.UI.Image get_BadgeCompleted()
    {
    
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1508837424, method:  new IntPtr(2786102800));
        this.buttonPack.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.WUTAutopilotGameplay val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  -1508837424);
        System.Action val_3 = new System.Action(object:  -1508837424, method:  new IntPtr(2786104848));
        this.completionMeterObject = null;
    }
    private void Start()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean, System.Int32> val_2 = new System.Action<System.Boolean, System.Int32>(object:  -1508715184, method:  new IntPtr(2786226064));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18, b:  7507968);
        val_4 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18 = val_4;
    }
    private void OnDestroy()
    {
        var val_6;
        System.Action<System.Boolean, System.Int32> val_7;
        var val_8;
        val_6 = 1152921504901095424;
        val_7 = 1152921511094568976;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2102212592) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Action<System.Boolean, System.Int32>(object:  -1508603184, method:  new IntPtr(2786226064));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18, value:  7507968);
        val_8 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18 = val_8;
    }
    public void Initialize(CategoryPackInfo data)
    {
        this.packData = data;
        this.RefreshUI();
    }
    private void ScrollCellIndex(int index)
    {
        int val_5 = index;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_3 = this.transform;
        OnScrollFocusChanged(currScrollFocalIndex:  val_5, currScrollFocalTransform:  -1508357680);
        if(val_5 > 1)
        {
                this.canvasGroup.blocksRaycasts = true;
            this.canvasGroup.interactable = true;
            this.canvasGroup.alpha = null;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = val_5 - 2;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            this.packData = (public static CategoryPacksScreenMain MonoSingleton<CategoryPacksScreenMain>::get_Instance().__il2cppRuntimeField_3C + 8 + ((index - 2)) << 2) + 16;
            this.RefreshUI();
            return;
        }
        
        this.canvasGroup.blocksRaycasts = false;
        this.canvasGroup.interactable = false;
        this.canvasGroup.alpha = null;
    }
    private void OnPackPurchaseComplete(bool isSuccess, int packPurchased)
    {
        if(isSuccess != true)
        {
                return;
        }
        
        if(this.packData.packId != packPurchased)
        {
                return;
        }
        
        this.RefreshUI();
    }
    public void RefreshUI()
    {
        UnityEngine.UI.Text val_15;
        float val_16;
        int val_17;
        var val_18;
        var val_19;
        float val_20;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_2 = this.packData.FullTitle;
        if((IsPackCompleted(packId:  this.packData.packId)) != false)
        {
                CategoryColor val_4 = GetColor(colorCode:  this.packData.color);
            this.packTitleBackground.color = new UnityEngine.Color() {r = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_C, g = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_10, b = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_14, a = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18};
            this.groupStateLocked.SetActive(value:  false);
            val_18 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
            this.groupStateUnlocked.SetActive(value:  false);
            val_19 = 1;
        }
        else
        {
                if((IsPackOwned(packId:  this.packData.packId)) != false)
        {
                CategoryColor val_6 = GetColor(colorCode:  this.packData.color);
            this.packTitleBackground.color = new UnityEngine.Color() {r = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_C, g = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_10, b = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_14, a = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18};
            val_18 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
            val_17 = GetPackProgress(packId:  this.packData.packId);
            CategoryPackWordBank val_8 = GetWordBank(packId:  this.packData.packId);
            float val_15 = (float)Size;
            val_15 = (float)val_17 / val_15;
            val_15 = this.completionMeterLabel;
            val_16 = 1152921504619999232;
            string val_10 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            this.groupStateLocked.SetActive(value:  false);
            this.groupStateUnlocked.SetActive(value:  true);
            val_19 = 0;
        }
        else
        {
                CategoryColor val_11 = GetColor(colorCode:  0);
            val_17 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
            if(this.packTitleBackground == 0)
        {
                val_20 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_C;
        }
        
            this.packTitleBackground.color = new UnityEngine.Color() {r = val_20, g = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_10, b = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_14, a = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18};
            val_15 = this.unlockCostLabel;
            val_18 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
            decimal val_12 = val_17.GetPackUnlockCost(packId:  -2102212592);
            string val_13 = ToString();
            this.groupStateLocked.SetActive(value:  true);
            this.groupStateUnlocked.SetActive(value:  false);
            this.groupStateCompleted.SetActive(value:  false);
            if(this.packData.timeLimited == true)
        {
                this.packData.timeLimited = 1;
        }
        
            val_19 = 1;
        }
        
        }
        
        this.timerObject.SetActive(value:  true);
        this.badgeNew.SetActive(value:  IsPackNewlyDiscovered(packId:  this.packData.packId));
        SetPackDiscovered(packId:  this.packData.packId);
    }
    private void OnClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPackCompleted(packId:  this.packData.packId)) != false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPackOwned(packId:  this.packData.packId)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OpenAndPlayPack(packId:  this.packData.packId);
            return;
        }
        
        if(this.packData.timeLimited != false)
        {
                if(this.packData.IsAvailable == false)
        {
                return;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
        Show(packId:  this.packData.packId);
    }
    private void UpdateLogic()
    {
        var val_4;
        int val_5;
        var val_14;
        if(this.packData.timeLimited == false)
        {
                return;
        }
        
        System.DateTime val_1 = AddDays(value:  null);
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511689185768}, d2:  new System.DateTime());
        if(val_4 <= 1)
        {
                val_14 = null;
            val_14 = null;
        }
        
        int val_6 = System.TimeSpan.Zero.Days;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_7 = System.TimeSpan.Zero.Hours;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        val_5 = System.TimeSpan.Zero.Minutes;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_9 = System.TimeSpan.Zero.Seconds;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_10 = System.String.Format(format:  -1507612144, args:  472754880);
        string val_11 = Localization.Localize(key:  -1507607920, defaultValue:  -1507607824, useSingularKey:  false);
        string val_12 = System.String.Format(format:  1592589744, arg0:  -1507607920, arg1:  -1507612144);
    }
    public CategoryPackButton()
    {
    
    }

}
