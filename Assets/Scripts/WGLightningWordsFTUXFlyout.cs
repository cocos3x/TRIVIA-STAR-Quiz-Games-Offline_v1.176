using UnityEngine;
public class WGLightningWordsFTUXFlyout : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject windowGroup;
    private UnityEngine.RectTransform windowBubble;
    private UnityEngine.Transform tooltipPick;
    private UnityEngine.UI.Image tooltipPickImg;
    private UnityEngine.Sprite tooltipPickUp;
    private UnityEngine.Sprite tooltipPickDown;
    private UnityEngine.UI.Button lightningWordsButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button screenButton;
    private UnityEngine.GameObject targetButtonObject;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  10500832, method:  new IntPtr(10458400));
        this.lightningWordsButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  10500832, method:  new IntPtr(10467616));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  10500832, method:  new IntPtr(10467616));
        this.screenButton.m_OnClick.AddListener(call:  162246656);
    }
    private void Start()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.targetButtonObject = this;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        Interactable = true;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_5 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_6 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_6.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AddRange(collection:  public static LightningWordsUIController MonoSingleton<LightningWordsUIController>::get_Instance().__il2cppRuntimeField_38);
        UnityEngine.Transform val_11 = this.targetButtonObject.transform;
        Add(item:  this.targetButtonObject);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_13 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
    }
    private void SetupButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.targetButtonObject = this;
    }
    private void OnClick_LightningWordsButton()
    {
        LightningWordsHandler.DEFAULT_REWARD_VALUE.ShowLightningWordsPopup();
        this.Close();
    }
    private void Close()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = false;
        Interactable = false;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  10982624, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void ShowFTUX(UnityEngine.Transform word, UnityEngine.Transform firstLetter, UnityEngine.Transform mainLayout, UnityEngine.Rect wordRegion)
    {
        float val_12;
        float val_13;
        float val_16;
        float val_17;
        float val_18;
        float val_39;
        float val_40;
        UnityEngine.Transform val_41;
        float val_45;
        float val_46;
        var val_47;
        this.windowGroup.SetActive(value:  false);
        UnityEngine.GameObject val_1 = this.tooltipPick.gameObject;
        this.tooltipPick.SetActive(value:  false);
        UnityEngine.Rect val_2 = wordRegion.m_XMin.rect;
        float val_3 = height;
        UnityEngine.Rect val_4 = rect;
        float val_5 = width;
        object val_6 = firstLetter.GetComponent<System.Object>();
        UnityEngine.Rect val_7 = rect;
        float val_8 = height;
        float val_9 = wordRegion.m_XMin.height;
        float val_10 = wordRegion.m_XMin.width;
        UnityEngine.Vector3 val_11 = position;
        UnityEngine.Vector3 val_15 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = mainLayout, y = val_12, z = val_13});
        float val_19 = 11160376 * (-0.25f);
        if(mainLayout <= 0)
        {
            goto label_10;
        }
        
        val_39 = -40f;
        goto label_11;
        label_10:
        float val_35 = 0.25f;
        val_35 = 11160376 * val_35;
        if(mainLayout >= 0)
        {
            goto label_12;
        }
        
        val_39 = 40f;
        label_11:
        val_40 = val_16 + val_39;
        goto label_13;
        label_12:
        val_40 = 0f;
        label_13:
        var val_36 = val_17;
        val_36 = 11160360 - val_36;
        if(mainLayout < 0)
        {
                this.tooltipPickImg.sprite = this.tooltipPickUp;
            val_41 = this.tooltipPick;
            object val_20 = val_41.GetComponent<System.Object>();
            UnityEngine.Rect val_21 = wordRegion.m_XMin.rect;
            float val_22 = height;
            uint val_37 = 11160376;
            val_37 = val_37 * 0.5f;
            UnityEngine.Vector3 val_23 = new UnityEngine.Vector3(x:  0.5f, y:  val_21.m_YMin, z:  val_37);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 1.563895E-38f, y = val_16, z = val_17}, b:  new UnityEngine.Vector3() {x = val_18, y = val_23.x, z = val_23.y});
            val_41.localPosition = new UnityEngine.Vector3();
            UnityEngine.Vector3 val_25 = localPosition;
            val_46 = -102f;
            val_47 = val_13 + val_46;
        }
        else
        {
                this.tooltipPickImg.sprite = this.tooltipPickDown;
            val_41 = this.tooltipPick;
            object val_26 = val_41.GetComponent<System.Object>();
            UnityEngine.Rect val_27 = wordRegion.m_XMin.rect;
            float val_28 = height;
            uint val_38 = 11160376;
            val_38 = val_38 * 0.5f;
            UnityEngine.Vector3 val_29 = new UnityEngine.Vector3(x:  val_38, y:  val_27.m_YMin, z:  val_27.m_Width);
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 1.563895E-38f, y = val_16, z = val_17}, b:  new UnityEngine.Vector3() {x = val_18, y = val_29.x, z = val_29.y});
            val_41.localPosition = new UnityEngine.Vector3();
            UnityEngine.Vector3 val_31 = localPosition;
            val_45 = -95f;
            val_47 = val_13 + val_45;
        }
        
        UnityEngine.Transform val_32 = this.windowGroup.transform;
        UnityEngine.Vector3 val_33 = new UnityEngine.Vector3(x:  val_13, y:  val_31.y, z:  val_45);
        this.windowGroup.localPosition = new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z};
        this.windowGroup.SetActive(value:  true);
        UnityEngine.GameObject val_34 = this.tooltipPick.gameObject;
        this.tooltipPick.SetActive(value:  true);
    }
    public WGLightningWordsFTUXFlyout()
    {
    
    }

}
