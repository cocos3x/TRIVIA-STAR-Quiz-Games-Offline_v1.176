using UnityEngine;
public class KeyToRichesTile : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject keyGroup;
    private UnityEngine.GameObject key;
    private UnityEngine.ParticleSystem particle;
    private float flyToPreDelay;
    private float flyToDuration;
    private float flyToAfterDelay;
    private DG.Tweening.Ease easeX;
    private DG.Tweening.Ease easeY;
    private UnityEngine.GameObject flyout;
    private UnityEngine.GameObject bubble;
    private UnityEngine.UI.Text info;
    private DG.Tweening.Sequence mySequence;
    
    // Methods
    public void SetupAndShowFlyout(bool isFtux)
    {
        UnityEngine.UI.Text val_5;
        var val_6;
        if(isFtux != false)
        {
                val_5 = this.info;
            val_6 = "key_riches_ftux_tooltip";
            string val_1 = Localization.Localize(key:  -1344237408, defaultValue:  -1344237536, useSingularKey:  false);
        }
        else
        {
                var val_5 = 24092730;
            val_5 = 11536820 + val_5;
            if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            int val_2 = UnityEngine.Mathf.Max(a:  1513265907, b:  0);
            if(val_2 < 2)
        {
                "key_riches_next_plural" = "key_riches_next_single";
        }
        
            if(val_2 < 2)
        {
                "{0} Keys until next reward!" = "{0} Key until next reward!";
        }
        
            string val_3 = Localization.Localize(key:  -1344233184, defaultValue:  -1344232960, useSingularKey:  false);
            val_5 = this.info;
            val_6 = "key_riches_next_single";
            string val_4 = System.String.Format(format:  -1344233184, arg0:  13152256);
        }
        
        this.ShowFlyout();
    }
    public void HideFlyout()
    {
        if(this.flyout == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.flyout.gameObject;
        if(this.flyout == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = this.flyout.gameObject;
        object val_5 = this.flyout.GetComponent<System.Object>();
        DG.Tweening.TweenExtensions.Kill(t:  this.mySequence, complete:  false);
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.flyout, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  -1344067008, method:  new IntPtr(2950875264));
        object val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.flyout, action:  190734336);
    }
    public void ShiftToCell(Cell newParent)
    {
        if(newParent == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Transform val_3 = newParent.transform;
        this.SetParent(p:  newParent);
        object val_4 = this.GetComponent<System.Object>();
        PluginExtension.SetLocalX(transform:  -1343934528, x:  null);
        object val_5 = this.GetComponent<System.Object>();
        PluginExtension.SetLocalY(transform:  -1343934528, y:  null);
    }
    public void Collect()
    {
        System.Collections.IEnumerator val_1 = this.FlyAndHide();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1343818432);
    }
    public void Remove()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -1343706432);
    }
    private void ShowFlyout()
    {
        var val_16;
        var val_20;
        this.flyout.SetActive(value:  false);
        WordRegion val_1 = WordRegion.instance;
        UnityEngine.Transform val_2 = 0.transform;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Transform val_5 = this.bubble.transform;
        UnityEngine.Transform val_6 = this.bubble.transform;
        UnityEngine.Vector3 val_7 = position;
        UnityEngine.Transform val_9 = this.bubble.transform;
        UnityEngine.Vector3 val_10 = position;
        UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_10.x, y:  val_10.y, z:  val_10.z);
        this.bubble.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        object val_12 = this.bubble.GetComponent<System.Object>();
        WordRegion val_13 = WordRegion.instance;
        UnityEngine.Rect val_14 = getSafeAreaRect;
        UnityEngine.Vector2 val_15 = size;
        WordRegion val_17 = WordRegion.instance;
        UnityEngine.Transform val_18 = 0.transform;
        UnityEngine.Vector3 val_19 = localScale;
        object val_21 = this.bubble.GetComponent<System.Object>();
        UnityEngine.Vector2 val_22 = sizeDelta;
        float val_23 = val_16 / val_20;
        UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  val_23, y:  val_22.y);
        this.bubble.sizeDelta = new UnityEngine.Vector2() {x = val_25.x, y = val_25.y};
        this.flyout.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_27 = ShowUGUIMonolith<System.Object>(showNext:  false);
        System.Action val_28 = new System.Action(object:  -1343559616, method:  new IntPtr(2951377536));
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_10 = null;
        UnityEngine.GameObject val_29 = this.flyout.gameObject;
        object val_30 = this.flyout.GetComponent<System.Object>();
        this.flyout.alpha = val_23;
        DG.Tweening.Sequence val_31 = DG.Tweening.DOTween.Sequence();
        this.mySequence = 0;
        DG.Tweening.Tweener val_32 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.flyout, endValue:  val_23, duration:  val_22.y);
        DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.flyout);
        DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_23);
        DG.Tweening.TweenCallback val_35 = new DG.Tweening.TweenCallback(object:  -1343559616, method:  new IntPtr(2951382656));
        object val_36 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private System.Collections.IEnumerator FlyAndHide()
    {
        object val_1 = new System.Object();
        typeof(KeyToRichesTile.<FlyAndHide>d__18).__il2cppRuntimeField_8 = 0;
        typeof(KeyToRichesTile.<FlyAndHide>d__18).__il2cppRuntimeField_10 = this;
    }
    public KeyToRichesTile()
    {
        this.flyToPreDelay = 0.2f;
        this.flyToDuration = 1f;
        this.flyToAfterDelay = 0.2f;
    }
    private void <HideFlyout>b__13_0()
    {
        UnityEngine.GameObject val_1 = this.flyout.gameObject;
        this.flyout.SetActive(value:  false);
    }
    private void <ShowFlyout>b__17_0()
    {
        this.HideFlyout();
    }

}
