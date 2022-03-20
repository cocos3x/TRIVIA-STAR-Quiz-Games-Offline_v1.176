using UnityEngine;
public class TRVHintReminderPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject toolTipParent;
    private UnityEngine.RectTransform toolTipBox;
    private UnityEngine.UI.Text toolTipText;
    private System.Collections.Generic.List<UnityEngine.RectTransform> toolTipPick;
    private UnityEngine.CanvasGroup cGroup;
    public System.Action onDestroyAction;
    
    // Methods
    public void Dismiss()
    {
        int val_1 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.cGroup, complete:  false);
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.cGroup, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  -515631216, method:  new IntPtr(3779311056));
        object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.cGroup, action:  190734336);
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.layer = UnityEngine.LayerMask.NameToLayer(layerName:  1805920352);
    }
    public void ShowToolTip(System.Collections.Generic.List<UnityEngine.GameObject> objsToToolTip)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -515389808);
        this.cGroup = this;
        this.alpha = null;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.cGroup, endValue:  null, duration:  null);
        UnityEngine.GameObject val_4 = this.gameObject;
        this.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.gameObject;
        UnityEngine.UI.LayoutElement val_6 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -515389808);
        if(this != 0)
        {
                this.overrideSorting = true;
        }
        else
        {
                this.overrideSorting = true;
        }
        
        this.sortingLayerName = -2059812896;
    }
    private void PlaceToolTip(UnityEngine.GameObject objToToolTip, bool topTT, PopupViewportSettings viewportSettings, UnityEngine.Vector2 tooltipOffset)
    {
        float val_9;
        float val_12;
        float val_16;
        float val_17;
        float val_18;
        float val_20;
        float val_21;
        float val_23;
        float val_24;
        float val_30;
        float val_31;
        var val_33;
        var val_38;
        var val_39;
        var val_40;
        float val_41;
        val_38 = viewportSettings;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = objToToolTip.transform;
        this.SetParent(p:  objToToolTip);
        UnityEngine.Transform val_3 = this.transform;
        MonoExtensions.ResetLocal(trans:  -515244016);
        object val_4 = this.toolTipParent.GetComponent<System.Object>();
        val_39 = this.toolTipParent;
        UnityEngine.Vector2 val_5 = anchoredPosition;
        val_40 = 0;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.up;
        UnityEngine.Rect val_7 = rect;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -2.326779E+20f, y = val_9}, d:  height);
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = -2.326778E+20f, y = val_12}, d:  val_11.x);
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -2.326776E+20f, y = val_16}, b:  new UnityEngine.Vector2() {x = val_17, y = val_18});
        UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -2.326775E+20f, y = val_20}, b:  new UnityEngine.Vector2() {x = val_21, y = tooltipOffset.x});
        val_39.anchoredPosition = new UnityEngine.Vector2() {x = val_23, y = val_24};
        UnityEngine.Camera val_25 = SLCWindowManager<WGWindowManager>.gameplayCamera;
        if(val_38 == 0)
        {
                return;
        }
        
        UnityEngine.Camera val_26 = SLCWindowManager<WGWindowManager>.monolithPopupCamera;
        val_39 = public static UnityEngine.Camera SLCWindowManager<WGWindowManager>::get_monolithPopupCamera();
        UnityEngine.Transform val_27 = this.toolTipBox.transform;
        UnityEngine.Vector3 val_28 = position;
        UnityEngine.Vector3 val_32 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = -2.323061E+20f, y = val_30, z = val_31});
        val_40 = val_33;
        val_41 = val_16;
        float val_35 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.Clamp(value:  val_32.x, min:  val_32.y, max:  val_32.z), min:  val_32.y, max:  val_32.z);
        val_38 = 0;
        UnityEngine.Transform val_36 = this.toolTipBox.transform;
        UnityEngine.Vector3 val_37 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = -2.323061E+20f, y = val_41, z = val_17});
        this.toolTipBox.position = new UnityEngine.Vector3();
    }
    private void DestroyMe()
    {
        if(this.onDestroyAction != 0)
        {
                this.onDestroyAction.Invoke();
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -515103344);
    }
    public TRVHintReminderPopup()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.toolTipPick = null;
    }

}
