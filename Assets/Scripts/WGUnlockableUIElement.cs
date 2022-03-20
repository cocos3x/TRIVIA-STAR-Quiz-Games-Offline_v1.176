using UnityEngine;
public class WGUnlockableUIElement : FrameSkipper, IPointerClickHandler, IEventSystemHandler
{
    // Fields
    protected UnityEngine.UI.Image lockImage;
    private System.Collections.Generic.List<UnityEngine.UI.Text> textToDarken;
    private System.Collections.Generic.List<UnityEngine.UI.Image> imageToDarken;
    private UnityEngine.Color textLockedColor;
    private UnityEngine.Color textUnlockedColor;
    public bool topToolTip;
    protected UnityEngine.UI.Button buttonToLock;
    protected WGUnlockableUIElement.UiLockedState myLastUiState;
    private UnityEngine.GameObject currentToolTip;
    private bool setSiblingIndexWhenHidden;
    private int startingSiblingIndex;
    private UnityEngine.UI.Button.ButtonClickedEvent desiredButtonClickEvent;
    
    // Properties
    protected virtual bool FeatureLocked { get; }
    protected virtual bool FeatureHidden { get; }
    protected virtual int UnlockLevel { get; }
    protected virtual string ToolTipText { get; }
    
    // Methods
    protected virtual void Start()
    {
        mem[1152921513273728068] = 60;
        if(this.buttonToLock == 0)
        {
                UnityEngine.Transform val_2 = this.transform;
            string val_3 = this.name;
            string val_4 = 76912976 + 76946480 + 76913072;
            UnityEngine.Debug.LogError(message:  76912976);
            this.enabled = false;
            return;
        }
        
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  76946480, method:  new IntPtr(76921456));
        this.buttonToLock.m_OnClick.AddListener(call:  162246656);
        if(this.setSiblingIndexWhenHidden != false)
        {
                UnityEngine.GameObject val_6 = this.gameObject;
            UnityEngine.Transform val_7 = this.transform;
            this.startingSiblingIndex = this.GetSiblingIndex();
        }
        
        this.CheckHiddenOrLocked();
    }
    protected virtual void OnEnable()
    {
        this.myLastUiState = 0;
        goto typeof(WGUnlockableUIElement).__il2cppRuntimeField_DC;
    }
    private void OnPreClickCheck()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  77215536, method:  new IntPtr(76921456));
        this.buttonToLock.m_OnClick.RemoveListener(call:  162246656);
        this.desiredButtonClickEvent = this.buttonToLock.m_OnClick;
        this.CheckHiddenOrLocked();
        if(this != 0)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        if(this.desiredButtonClickEvent.GetPersistentEventCount() >= 1)
        {
                this.desiredButtonClickEvent.Invoke();
        }
        
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  77215536, method:  new IntPtr(76921456));
        this.buttonToLock.m_OnClick.AddListener(call:  162246656);
    }
    protected virtual bool get_FeatureLocked()
    {
        Player val_1 = App.Player;
        if(0 < this)
        {
                0 = 1;
        }
        
        return true;
    }
    protected virtual bool get_FeatureHidden()
    {
        return false;
    }
    protected virtual int get_UnlockLevel()
    {
        return 0;
    }
    protected virtual string get_ToolTipText()
    {
        string val_1 = Localization.Localize(key:  77672416, defaultValue:  77672304, useSingularKey:  false);
        string val_2 = System.String.Format(format:  77672416, arg0:  13152256);
    }
    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        if(this != 0)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        if(R4 == 0)
        {
                return;
        }
        
        goto R4 + 284;
    }
    private void PlaceToolTip()
    {
        var val_8;
        UnityEngine.GameObject val_9;
        val_8 = 1152921504765685760;
        if(this.currentToolTip != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = PlaceGameObject<System.Object>(loc:  0);
        UnityEngine.GameObject val_4 = gameObject;
        this.currentToolTip = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        UnityEngine.GameObject val_5 = this.buttonToLock.gameObject;
        val_9 = this.buttonToLock;
        if(this.lockImage != 0)
        {
                UnityEngine.GameObject val_7 = this.lockImage.gameObject;
            val_9 = this.lockImage;
        }
        
        val_8 = this;
        if(this.topToolTip == true)
        {
                this.topToolTip = 1;
        }
        
        ShowToolTip(objToToolTip:  val_9, text:  77953280, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  0, showPick:  false, maxFontSize:  0);
    }
    protected virtual void OnClickLocked()
    {
        this.PlaceToolTip();
    }
    protected virtual void OnClickUnlocked()
    {
    
    }
    protected override void UpdateLogic()
    {
        this.UpdateLogic();
        this.CheckHiddenOrLocked();
    }
    private void CheckHiddenOrLocked()
    {
        UnityEngine.Object val_15;
        UnityEngine.Object val_27;
        WGUnlockableUIElement val_33;
        UiLockedState val_34;
        UiLockedState val_35;
        UiLockedState val_36;
        val_33 = this;
        val_34 = this.myLastUiState;
        if(val_33 == 0)
        {
            goto label_1;
        }
        
        if(this.myLastUiState == 1)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.lockImage)) != false)
        {
                UnityEngine.GameObject val_2 = this.lockImage.gameObject;
            this.lockImage.SetActive(value:  false);
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.UI.LayoutElement val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  78482176);
        this.alpha = null;
        if(this.setSiblingIndexWhenHidden != false)
        {
                UnityEngine.GameObject val_5 = this.gameObject;
            UnityEngine.Transform val_6 = this.transform;
            this.SetAsLastSibling();
        }
        
        this.buttonToLock.interactable = false;
        val_35 = 1;
        goto label_58;
        label_1:
        if(val_33 == 0)
        {
            goto label_14;
        }
        
        if(this.myLastUiState == 2)
        {
                return;
        }
        
        if((this.myLastUiState == 1) && (this.startingSiblingIndex != 1))
        {
                val_36 = val_34;
            UnityEngine.GameObject val_7 = this.gameObject;
            UnityEngine.Transform val_8 = this.transform;
            this.SetSiblingIndex(index:  this.startingSiblingIndex);
            val_34 = val_36;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.lockImage)) != false)
        {
                UnityEngine.GameObject val_10 = this.lockImage.gameObject;
            this.lockImage.SetActive(value:  true);
        }
        
        UnityEngine.GameObject val_11 = this.gameObject;
        UnityEngine.UI.LayoutElement val_12 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  78482176);
        this.alpha = null;
        this.buttonToLock.interactable = false;
        if((this.textToDarken == 0) || (this.buttonToLock < 1))
        {
            goto label_28;
        }
        
        List.Enumerator<T> val_13 = GetEnumerator();
        label_31:
        if(MoveNext() == false)
        {
            goto label_29;
        }
        
        if(val_15 != 0)
        {
            goto label_31;
        }
        
        goto label_31;
        label_14:
        if(this.myLastUiState == 3)
        {
                return;
        }
        
        if((this.myLastUiState == 1) && (this.startingSiblingIndex != 1))
        {
                val_36 = val_34;
            UnityEngine.GameObject val_16 = this.gameObject;
            UnityEngine.Transform val_17 = this.transform;
            this.SetSiblingIndex(index:  this.startingSiblingIndex);
            val_34 = val_36;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.lockImage)) != false)
        {
                UnityEngine.GameObject val_19 = this.lockImage.gameObject;
            this.lockImage.SetActive(value:  false);
        }
        
        UnityEngine.GameObject val_20 = this.gameObject;
        UnityEngine.UI.LayoutElement val_21 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  78482176);
        this.alpha = null;
        this.buttonToLock.interactable = true;
        if((this.textToDarken == 0) || (this.buttonToLock < 1))
        {
            goto label_45;
        }
        
        List.Enumerator<T> val_22 = GetEnumerator();
        label_51:
        if(MoveNext() == false)
        {
            goto label_46;
        }
        
        if((val_15 == 0) || (val_15 != 0))
        {
            goto label_51;
        }
        
        goto label_51;
        label_29:
        Dispose();
        val_34 = val_34;
        label_28:
        val_35 = 2;
        if((this.imageToDarken == 0) || (78470120 < 1))
        {
            goto label_58;
        }
        
        List.Enumerator<T> val_25 = GetEnumerator();
        label_56:
        if(MoveNext() == false)
        {
            goto label_59;
        }
        
        UnityEngine.Color val_28 = UnityEngine.Color.gray;
        if(val_27 != 0)
        {
            goto label_56;
        }
        
        goto label_56;
        label_46:
        Dispose();
        val_34 = val_34;
        val_33 = val_33;
        label_45:
        val_35 = 3;
        if((this.imageToDarken == 0) || (78470120 < 1))
        {
            goto label_58;
        }
        
        List.Enumerator<T> val_29 = GetEnumerator();
        label_64:
        if(MoveNext() == false)
        {
            goto label_59;
        }
        
        if(val_27 == 0)
        {
            goto label_64;
        }
        
        UnityEngine.Color val_32 = UnityEngine.Color.white;
        if(val_27 != 0)
        {
            goto label_64;
        }
        
        goto label_64;
        label_59:
        Dispose();
        val_34 = val_34;
        label_58:
        this.myLastUiState = val_35;
        if(val_35 == val_34)
        {
                return;
        }
    
    }
    protected virtual void SetNewState(WGUnlockableUIElement.UiLockedState newState)
    {
    
    }
    protected virtual void UpdateButton()
    {
    
    }
    public WGUnlockableUIElement()
    {
        this.startingSiblingIndex = 0;
        this.topToolTip = true;
    }

}
