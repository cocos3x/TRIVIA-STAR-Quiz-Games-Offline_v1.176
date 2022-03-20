using UnityEngine;
private sealed class IslandParadiseEventHandler.<PlayPointCollectionSequence>d__80 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventButtonV2_IslandParadise islandParadiseButton;
    public IslandParadiseEventHandler <>4__this;
    public WGEventButtonV2 eventProgressUI;
    public int startValue;
    public int points;
    private IslandParadiseEventHandler.<>c__DisplayClass80_0 <>8__1;
    public WGLevelClearPopup popup;
    private int <pointsToFly>5__2;
    private float <pointFlyInterval>5__3;
    private float <pointFlyDuration>5__4;
    private float <scale>5__5;
    private int <i>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public IslandParadiseEventHandler.<PlayPointCollectionSequence>d__80(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_13;
        float val_16;
        bool val_34;
        int val_45;
        int val_46;
        var val_47;
        int val_48;
        IslandParadiseEventHandler.<>c__DisplayClass80_0 val_49;
        int val_50;
        var val_51;
        object val_52;
        var val_53;
        val_45 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_45;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        typeof(IslandParadiseEventHandler.<>c__DisplayClass80_0).__il2cppRuntimeField_C = this.islandParadiseButton;
        this.<>8__1.<>4__this = this.<>4__this;
        this.<>8__1.eventProgressUI = this.eventProgressUI;
        this.<>8__1.startValue = this.startValue;
        this.<>8__1.points = this.points;
        val_46 = this;
        this.<pointsToFly>5__2 = UnityEngine.Mathf.Min(a:  this.<>8__1.points, b:  10);
        if((this.<>8__1) == 0)
        {
            goto label_11;
        }
        
        goto label_12;
        label_1:
        val_46 = this.<pointsToFly>5__2;
        val_48 = (this.<i>5__6) + 1;
        this.<>1__state = 0;
        this.<i>5__6 = val_48;
        goto label_13;
        label_11:
        val_47 = 52;
        label_12:
        typeof(IslandParadiseEventHandler.<>c__DisplayClass80_0).__il2cppRuntimeField_8 = 52f;
        this.<>8__1.initialProgressLabelPoints = this.<>4__this.<ProgressLabelPoints>k__BackingField;
        DG.Tweening.Core.DOSetter<System.Single> val_3 = new DG.Tweening.Core.DOSetter<System.Single>(object:  this.<>8__1, method:  new IntPtr(2925488416));
        val_49 = this.<>8__1;
        if(val_49 == 0)
        {
            goto label_16;
        }
        
        val_50 = this.<>8__1.startValue;
        goto label_17;
        label_16:
        val_50 = this.<>8__1.startValue;
        val_49 = this.<>8__1;
        if(val_49 == 0)
        {
            goto label_18;
        }
        
        label_17:
        label_65:
        int val_4 = (this.<>8__1.points) + (this.<>8__1.startValue);
        DG.Tweening.Tweener val_5 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  (float)this.<pointsToFly>5__2, endValue:  null, duration:  (float)val_50);
        object val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  1);
        val_51 = 1152921504797581312;
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  new IntPtr(2925501728));
        object val_8 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198881280, action:  190734336);
        DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  new IntPtr(2925506848));
        object val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198881280, action:  190734336);
        val_45 = 0;
        object val_11 = this.<>8__1.GetComponent<System.Object>();
        UnityEngine.Vector2 val_12 = sizeDelta;
        object val_14 = this.<>8__1.eventProgressUI.icon.GetComponent<System.Object>();
        val_52 = this.<>8__1.eventProgressUI.icon;
        val_48 = 0;
        UnityEngine.Vector2 val_15 = sizeDelta;
        float val_44 = val_16;
        this.<i>5__6 = val_48;
        val_44 = val_13 / val_44;
        this.<scale>5__5 = val_44;
        label_13:
        if(val_48 >= (this.<pointsToFly>5__2))
        {
                return (bool)val_45;
        }
        
        object val_17 = null;
        val_46 = val_17;
        val_17 = new System.Object();
        if(val_46 != 0)
        {
                val_53 = val_46;
            typeof(IslandParadiseEventHandler.<>c__DisplayClass80_1).__il2cppRuntimeField_C = this.<>8__1;
        }
        else
        {
                val_53 = 12;
            mem[12] = this.<>8__1;
        }
        
        UnityEngine.GameObject val_18 = this.<>8__1 + 20 + 16.gameObject;
        UnityEngine.Transform val_19 = this.popup.transform;
        object val_20 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>8__1 + 20 + 16, parent:  this.popup);
        if(val_46 != 0)
        {
                val_50 = val_46;
            typeof(IslandParadiseEventHandler.<>c__DisplayClass80_1).__il2cppRuntimeField_8 = this.<>8__1 + 20 + 16;
        }
        else
        {
                val_50 = 8;
            mem[8] = this.<>8__1 + 20 + 16;
        }
        
        UnityEngine.Transform val_21 = val_50.transform;
        UnityEngine.Transform val_22 = this.<>8__1 + 20 + 16.transform;
        UnityEngine.Vector3 val_23 = position;
        val_50.position = new UnityEngine.Vector3();
        DG.Tweening.Sequence val_24 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_25 = mem[8].transform;
        UnityEngine.Transform val_26 = this.<>8__1 + 12 + 16.transform;
        UnityEngine.Vector3 val_27 = position;
        DG.Tweening.Tweener val_28 = DG.Tweening.ShortcutExtensions.DOMoveX(target:  mem[8], endValue:  val_27.x, duration:  val_27.y, snapping:  val_16);
        object val_29 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[8], ease:  3);
        DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[8]);
        UnityEngine.Transform val_31 = mem[8].transform;
        val_51 = 0;
        UnityEngine.Transform val_32 = this.<>8__1 + 12 + 16.transform;
        UnityEngine.Vector3 val_33 = position;
        DG.Tweening.Tweener val_35 = DG.Tweening.ShortcutExtensions.DOMoveY(target:  mem[8], endValue:  val_33.x, duration:  val_33.y, snapping:  val_34);
        object val_36 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[8], ease:  mem[8]);
        DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[8]);
        UnityEngine.Transform val_38 = mem[8].transform;
        DG.Tweening.Tweener val_39 = DG.Tweening.ShortcutExtensions.DOScale(target:  mem[8], endValue:  val_33.x, duration:  val_33.y);
        DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[8]);
        DG.Tweening.TweenCallback val_41 = new DG.Tweening.TweenCallback(object:  318369792, method:  new IntPtr(2925536544));
        object val_42 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        UnityEngine.WaitForSeconds val_43 = null;
        val_52 = val_43;
        val_43 = new UnityEngine.WaitForSeconds(seconds:  val_33.x);
        val_45 = 1;
        this.<>1__state = val_45;
        this.<>2__current = val_52;
        return (bool)val_45;
        label_18:
        if((this.<>8__1) != 0)
        {
            goto label_65;
        }
    
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
