using UnityEngine;
private sealed class AttackMadnessEventHandler.<PlayPointCollectionSequence>d__73 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventButtonV2_AttackMadness attackMadnessButton;
    public AttackMadnessEventHandler <>4__this;
    public WGEventButtonV2 eventProgressUI;
    public int startValue;
    public int points;
    private AttackMadnessEventHandler.<>c__DisplayClass73_0 <>8__1;
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
    public AttackMadnessEventHandler.<PlayPointCollectionSequence>d__73(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_14;
        float val_17;
        bool val_35;
        int val_46;
        int val_47;
        var val_48;
        int val_49;
        AttackMadnessEventHandler.<>c__DisplayClass73_0 val_50;
        int val_51;
        var val_52;
        object val_53;
        val_46 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_46;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        typeof(AttackMadnessEventHandler.<>c__DisplayClass73_0).__il2cppRuntimeField_C = this.attackMadnessButton;
        this.<>8__1.<>4__this = this.<>4__this;
        this.<>8__1.eventProgressUI = this.eventProgressUI;
        this.<>8__1.startValue = this.startValue;
        this.<>8__1.points = this.points;
        val_47 = this;
        this.<pointsToFly>5__2 = UnityEngine.Mathf.Min(a:  this.<>8__1.points, b:  10);
        if((this.<>8__1) == 0)
        {
            goto label_11;
        }
        
        goto label_12;
        label_1:
        val_47 = this.<pointsToFly>5__2;
        val_49 = (this.<i>5__6) + 1;
        this.<>1__state = 0;
        this.<i>5__6 = val_49;
        goto label_13;
        label_11:
        val_48 = 52;
        label_12:
        typeof(AttackMadnessEventHandler.<>c__DisplayClass73_0).__il2cppRuntimeField_8 = 52f;
        this.<>8__1.initialProgressLabelPoints = this.<>4__this.PointsCollectedInLevel;
        DG.Tweening.Core.DOSetter<System.Single> val_4 = new DG.Tweening.Core.DOSetter<System.Single>(object:  this.<>8__1, method:  new IntPtr(2753373392));
        val_50 = this.<>8__1;
        if(val_50 == 0)
        {
            goto label_16;
        }
        
        val_51 = this.<>8__1.startValue;
        goto label_17;
        label_16:
        val_51 = this.<>8__1.startValue;
        val_50 = this.<>8__1;
        if(val_50 == 0)
        {
            goto label_18;
        }
        
        label_17:
        label_64:
        int val_5 = (this.<>8__1.points) + (this.<>8__1.startValue);
        DG.Tweening.Tweener val_6 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  (float)this.<pointsToFly>5__2, endValue:  null, duration:  (float)val_51);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  1);
        val_52 = 1152921504797581312;
        DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  new IntPtr(2753386704));
        object val_9 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198881280, action:  190734336);
        DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  new IntPtr(2753391824));
        object val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198881280, action:  190734336);
        val_46 = 0;
        object val_12 = this.<>8__1.GetComponent<System.Object>();
        UnityEngine.Vector2 val_13 = sizeDelta;
        object val_15 = this.<>8__1.eventProgressUI.icon.GetComponent<System.Object>();
        val_53 = this.<>8__1.eventProgressUI.icon;
        val_49 = 0;
        UnityEngine.Vector2 val_16 = sizeDelta;
        float val_45 = val_17;
        this.<i>5__6 = val_49;
        val_45 = val_14 / val_45;
        this.<scale>5__5 = val_45;
        label_13:
        if(val_49 >= (this.<pointsToFly>5__2))
        {
                return (bool)val_46;
        }
        
        object val_18 = new System.Object();
        if(val_18 != 0)
        {
                val_47 = val_18;
            typeof(AttackMadnessEventHandler.<>c__DisplayClass73_1).__il2cppRuntimeField_C = this.<>8__1;
        }
        else
        {
                val_47 = 12;
            mem[12] = this.<>8__1;
        }
        
        UnityEngine.GameObject val_19 = this.<>8__1 + 20 + 16.gameObject;
        UnityEngine.Transform val_20 = this.popup.transform;
        object val_21 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>8__1 + 20 + 16, parent:  this.popup);
        if(val_18 != 0)
        {
                val_51 = val_18;
            typeof(AttackMadnessEventHandler.<>c__DisplayClass73_1).__il2cppRuntimeField_8 = this.<>8__1 + 20 + 16;
        }
        else
        {
                val_51 = 8;
            mem[8] = this.<>8__1 + 20 + 16;
        }
        
        UnityEngine.Transform val_22 = val_51.transform;
        UnityEngine.Transform val_23 = this.<>8__1 + 20.transform;
        UnityEngine.Vector3 val_24 = position;
        val_51.position = new UnityEngine.Vector3();
        DG.Tweening.Sequence val_25 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_26 = mem[8].transform;
        UnityEngine.Transform val_27 = this.<>8__1 + 12 + 16.transform;
        UnityEngine.Vector3 val_28 = position;
        DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions.DOMoveX(target:  mem[8], endValue:  val_28.x, duration:  val_28.y, snapping:  val_17);
        object val_30 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[8], ease:  3);
        DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[8]);
        UnityEngine.Transform val_32 = mem[8].transform;
        val_52 = 0;
        UnityEngine.Transform val_33 = this.<>8__1 + 12 + 16.transform;
        UnityEngine.Vector3 val_34 = position;
        DG.Tweening.Tweener val_36 = DG.Tweening.ShortcutExtensions.DOMoveY(target:  mem[8], endValue:  val_34.x, duration:  val_34.y, snapping:  val_35);
        object val_37 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[8], ease:  mem[8]);
        DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[8]);
        UnityEngine.Transform val_39 = mem[8].transform;
        DG.Tweening.Tweener val_40 = DG.Tweening.ShortcutExtensions.DOScale(target:  mem[8], endValue:  val_34.x, duration:  val_34.y);
        DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[8]);
        DG.Tweening.TweenCallback val_42 = new DG.Tweening.TweenCallback(object:  308625408, method:  new IntPtr(2753421520));
        object val_43 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        UnityEngine.WaitForSeconds val_44 = null;
        val_53 = val_44;
        val_44 = new UnityEngine.WaitForSeconds(seconds:  val_34.x);
        val_46 = 1;
        this.<>1__state = val_46;
        this.<>2__current = val_53;
        return (bool)val_46;
        label_18:
        if((this.<>8__1) != 0)
        {
            goto label_64;
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
