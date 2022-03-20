using UnityEngine;
public class DynamicToolTip : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject topTTParent;
    private UnityEngine.GameObject bottomTTParent;
    private UnityEngine.RectTransform topToolTipBox;
    private UnityEngine.RectTransform bottomToolTipBox;
    private UnityEngine.UI.Text topToolTipText;
    private UnityEngine.UI.Text bottomToolTipText;
    private UnityEngine.RectTransform topToolTipPick;
    private UnityEngine.RectTransform bottomToolTipPick;
    private UnityEngine.UI.Button topGotItButton;
    private UnityEngine.UI.Button bottomGotItButton;
    private UnityEngine.GameObject topGotItGroup;
    private UnityEngine.GameObject bottomGotItGroup;
    private System.Action GotItButtonAction;
    private UnityEngine.CanvasGroup cGroup;
    public System.Action onDestroyAction;
    
    // Methods
    public void Dismiss()
    {
        int val_1 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.cGroup, complete:  false);
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.cGroup, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  -163938480, method:  new IntPtr(4131003792));
        object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.cGroup, action:  190734336);
    }
    private void Awake()
    {
        int val_7;
        UnityEngine.GameObject val_1 = this.gameObject;
        val_7 = UnityEngine.LayerMask.NameToLayer(layerName:  1805920352);
        this.layer = val_7;
        if((UnityEngine.Object.op_Implicit(exists:  this.topGotItButton)) != false)
        {
                val_7 = null;
            val_7 = new UnityEngine.Events.UnityAction(object:  -163792688, method:  new IntPtr(4131137296));
            this.topGotItButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bottomGotItButton)) == false)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -163792688, method:  new IntPtr(4131137296));
        this.bottomGotItButton.m_OnClick.AddListener(call:  162246656);
    }
    public void ShowToolTip(UnityEngine.GameObject objToToolTip, string text, bool topToolTip = True, float displayDuration = 3.5, float width = 0, float height = 0, float tooltipOffsetX = 0, float tooltipOffsetY = 0, PopupViewportSettings viewportSettings, bool showGotItButton = False, System.Action gotItCallback, bool showPick = True, int maxFontSize = -1)
    {
        int val_11;
        PopupViewportSettings val_12;
        System.Action val_15;
        bool val_27;
        bool val_30;
        UnityEngine.GameObject val_33;
        UnityEngine.UI.Button val_37;
        val_33 = objToToolTip;
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  displayDuration, y:  width);
        if(topToolTip == true)
        {
                this.bottomToolTipBox = this.topToolTipBox;
        }
        
        UnityEngine.Rect val_2 = rect;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  height, y:  val_2.m_YMin);
        this.bottomToolTipBox.sizeDelta = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        val_33 = val_33;
        if(this.bottomToolTipBox > 0)
        {
                if(topToolTip == false)
        {
                this.bottomToolTipBox = this.bottomToolTipBox;
        }
        
            if(topToolTip == true)
        {
                this.bottomToolTipBox = this.topToolTipBox;
        }
        
            UnityEngine.Rect val_5 = rect;
            float val_6 = width;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_6, y:  val_5.m_YMin);
            this.bottomToolTipBox.sizeDelta = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            val_33 = val_33;
        }
        
        UnityEngine.GameObject val_8 = this.topTTParent.gameObject;
        this.topTTParent.SetActive(value:  topToolTip);
        UnityEngine.GameObject val_9 = this.bottomTTParent.gameObject;
        this.bottomTTParent.SetActive(value:  topToolTip ^ 1);
        if(val_11 != 1)
        {
                this.topToolTipText.resizeTextMaxSize = val_11;
            this.bottomToolTipText.resizeTextMaxSize = val_11;
        }
        
        this.PlaceToolTip(objToToolTip:  val_33, topTT:  topToolTip, viewportSettings:  val_12, tooltipOffset:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        UnityEngine.GameObject val_13 = this.gameObject;
        UnityEngine.UI.LayoutElement val_14 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -163569072);
        this.cGroup = this;
        this.alpha = val_6;
        DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.cGroup, endValue:  val_6, duration:  val_5.m_YMin);
        if((this > 0) && (val_15 == 0))
        {
                DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.cGroup, endValue:  val_6, duration:  val_5.m_YMin);
            object val_18 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.cGroup, delay:  val_6);
            DG.Tweening.TweenCallback val_19 = new DG.Tweening.TweenCallback(object:  -163569072, method:  new IntPtr(4131003792));
            object val_20 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.cGroup, action:  190734336);
        }
        
        UnityEngine.GameObject val_21 = this.cGroup.gameObject;
        this.SetActive(value:  true);
        UnityEngine.GameObject val_22 = this.gameObject;
        UnityEngine.UI.LayoutElement val_23 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -163569072);
        if(this != 0)
        {
                this.overrideSorting = true;
        }
        else
        {
                this.overrideSorting = true;
        }
        
        this.sortingLayerName = -2059812896;
        val_37 = this.topGotItButton;
        if(val_37 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_25 = this.gameObject;
        UnityEngine.UI.LayoutElement val_26 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -163569072);
        UnityEngine.GameObject val_28 = this.topGotItGroup.gameObject;
        this.topGotItGroup.SetActive(value:  val_27);
        UnityEngine.GameObject val_29 = this.bottomGotItGroup.gameObject;
        this.bottomGotItGroup.SetActive(value:  val_27);
        this.GotItButtonAction = val_15;
        UnityEngine.GameObject val_31 = this.topToolTipPick.gameObject;
        val_37 = this.topToolTipPick;
        val_37.SetActive(value:  val_30);
        UnityEngine.GameObject val_32 = this.bottomToolTipPick.gameObject;
        this.bottomToolTipPick.SetActive(value:  val_30);
    }
    private void PlaceToolTip(UnityEngine.GameObject objToToolTip, bool topTT, PopupViewportSettings viewportSettings, UnityEngine.Vector2 tooltipOffset)
    {
        float val_9;
        float val_12;
        float val_13;
        float val_16;
        float val_17;
        float val_18;
        float val_20;
        float val_21;
        float val_23;
        float val_24;
        float val_51;
        float val_52;
        float val_53;
        UnityEngine.Transform val_59;
        UnityEngine.RectTransform val_60;
        var val_61;
        float val_62;
        val_59 = objToToolTip;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = val_59.transform;
        this.SetParent(p:  val_59);
        UnityEngine.Transform val_3 = this.transform;
        MonoExtensions.ResetLocal(trans:  -163321904);
        if(topTT != false)
        {
                object val_4 = this.topTTParent.GetComponent<System.Object>();
            UnityEngine.Vector2 val_5 = anchoredPosition;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.up;
            UnityEngine.Rect val_7 = rect;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -9.924243E+32f, y = val_9}, d:  height);
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = -9.924237E+32f, y = val_12}, d:  val_11.x);
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -9.924231E+32f, y = val_16}, b:  new UnityEngine.Vector2() {x = val_17, y = val_18});
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -9.924225E+32f, y = val_20}, b:  new UnityEngine.Vector2() {x = val_21, y = tooltipOffset.x});
            this.topTTParent.anchoredPosition = new UnityEngine.Vector2() {x = val_23, y = val_24};
            val_60 = this.topToolTipBox;
        }
        else
        {
                object val_25 = this.bottomTTParent.GetComponent<System.Object>();
            UnityEngine.Vector2 val_26 = anchoredPosition;
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.up;
            UnityEngine.Rect val_28 = rect;
            UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -9.924243E+32f, y = val_9}, d:  height);
            UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = -9.924237E+32f, y = val_12}, d:  val_30.x);
            UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = -9.924231E+32f, y = val_16}, b:  new UnityEngine.Vector2() {x = val_17, y = val_18});
            UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -9.924225E+32f, y = val_20}, b:  new UnityEngine.Vector2() {x = val_21, y = tooltipOffset.x});
            this.bottomTTParent.anchoredPosition = new UnityEngine.Vector2() {x = val_23, y = val_24};
            val_60 = this.bottomToolTipBox;
        }
        
        val_61 = 1152921504985972736;
        UnityEngine.Camera val_34 = SLCWindowManager<WGWindowManager>.gameplayCamera;
        val_62 = public static UnityEngine.Camera SLCWindowManager<WGWindowManager>::get_gameplayCamera();
        UnityEngine.Transform val_35 = val_59.transform;
        UnityEngine.Vector3 val_36 = position;
        UnityEngine.Vector3 val_38 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = -3.856473E-19f, y = val_16, z = val_17});
        var val_59 = val_9;
        UnityEngine.Rect val_39 = rect;
        float val_40 = width;
        val_59 = val_59 + (-0.5f);
        UnityEngine.Vector2 val_42 = anchoredPosition;
        UnityEngine.Vector2 val_43 = UnityEngine.Vector2.right;
        float val_44 = val_59 * (4131633304 * 0.9f);
        float val_45 = val_44 ^ 2147483648;
        UnityEngine.Vector2 val_46 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -9.924231E+32f, y = val_18}, d:  val_44);
        UnityEngine.Vector2 val_47 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -9.924225E+32f, y = val_12}, b:  new UnityEngine.Vector2() {x = val_13, y = val_20});
        val_60.anchoredPosition = new UnityEngine.Vector2() {x = val_23, y = val_24};
        if(viewportSettings == 0)
        {
                return;
        }
        
        UnityEngine.Camera val_48 = SLCWindowManager<WGWindowManager>.monolithPopupCamera;
        val_59 = public static UnityEngine.Camera SLCWindowManager<WGWindowManager>::get_monolithPopupCamera();
        if(topTT == true)
        {
                val_60 = this.topToolTipBox;
        }
        
        if(topTT == false)
        {
                val_60 = this.bottomToolTipBox;
        }
        
        UnityEngine.Transform val_49 = val_60.transform;
        UnityEngine.Vector3 val_50 = position;
        UnityEngine.Vector3 val_54 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = -2.323061E+20f, y = val_51, z = val_52});
        val_61 = val_53;
        val_60 = val_51;
        float val_56 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.Clamp(value:  val_54.x, min:  val_54.y, max:  val_54.z), min:  val_54.y, max:  val_54.z);
        val_62 = val_52;
        if(topTT == false)
        {
                viewportSettings = this.bottomToolTipBox;
        }
        
        if(topTT == true)
        {
                viewportSettings = this.topToolTipBox;
        }
        
        UnityEngine.Transform val_57 = viewportSettings.transform;
        UnityEngine.Vector3 val_58 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = -2.323061E+20f, y = val_60, z = val_62});
        viewportSettings.position = new UnityEngine.Vector3() {x = val_51, y = val_52, z = val_53};
    }
    private void DestroyMe()
    {
        if(this.onDestroyAction != 0)
        {
                this.onDestroyAction.Invoke();
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -163156656);
    }
    private void HandleGotItClicked()
    {
        if(this.GotItButtonAction == 0)
        {
                return;
        }
        
        this.GotItButtonAction.Invoke();
    }
    public DynamicToolTip()
    {
    
    }

}
