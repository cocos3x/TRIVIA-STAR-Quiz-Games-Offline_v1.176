using UnityEngine;
private sealed class WFOEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__37 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WFOEventPointsGainAnimator <>4__this;
    public int toQty;
    public int fromQty;
    public int maxQty;
    public System.Action onAnimationComplete;
    private int <iterAmt>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__37(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_21;
        float val_22;
        float val_24;
        float val_25;
        float val_37;
        float val_38;
        WFOEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__37 val_57;
        int val_58;
        WFOEventPointsGainAnimator val_59;
        object val_60;
        var val_63;
        int val_64;
        int val_65;
        var val_66;
        var val_67;
        var val_68;
        DG.Tweening.TweenCallback val_70;
        var val_71;
        System.Action val_73;
        val_57 = this;
        val_58 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool)val_58;
        }
        
        val_59 = this.<>4__this;
        var val_1 = 8348308 + (8348308 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                8348308 + (this.<>1__state) << 2 = (8348308 + (this.<>1__state) << 2) & ((8348308 + (this.<>1__state) << 2) << (8348308 + (this.<>1__state) << 2));
            8348308 + (this.<>1__state) << 2 = (8348308 + (this.<>1__state) << 2) & (((int)R8) >> 32);
            8348308 + (this.<>1__state) << 2 = (8348308 + (this.<>1__state) << 2) & ((IP) >> 1);
            8348308 + (this.<>1__state) << 2 = (8348308 + (this.<>1__state) << 2) * 8348308;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_2 = null;
        val_60 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_58 = 1;
        this.<>1__state = val_58;
        this.<>2__current = ;
        return (bool)val_58;
        label_72:
        object val_10 = new System.Object();
        typeof(WFOEventPointsGainAnimator.<>c__DisplayClass37_0).__il2cppRuntimeField_C = val_59;
        string val_11 = -376517824(-376517824) + 13152256;
        UnityEngine.GameObject val_12 = new UnityEngine.GameObject(name:  -376517824);
        if(val_10 != 0)
        {
                val_66 = val_10;
            typeof(WFOEventPointsGainAnimator.<>c__DisplayClass37_0).__il2cppRuntimeField_8 = val_12;
        }
        else
        {
                val_66 = 8;
            mem[8] = val_12;
        }
        
        UnityEngine.Transform val_13 = transform;
        SetParent(p:  this.<>4__this.pointsIconRootTransform);
        UnityEngine.Transform val_14 = transform;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -2.16723E+25f}, d:  this.<>4__this.symbolScale);
        localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_17 = transform;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        localPosition = new UnityEngine.Vector3();
        object val_19 = AddComponent<System.Object>();
        UnityEngine.Vector2 val_20 = UnityEngine.Vector2.zero;
        anchoredPosition = new UnityEngine.Vector2() {x = val_21, y = val_22};
        UnityEngine.Vector2 val_23 = UnityEngine.Vector2.zero;
        sizeDelta = new UnityEngine.Vector2() {x = val_24, y = val_25};
        UnityEngine.Transform val_26 = transform;
        object val_27 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this.pointIconImage, parent:  157720576);
        UnityEngine.Sprite val_28 = val_59.GetFlySprite();
        if((this.<>4__this.pointIconImage) != 0)
        {
                val_67 = 0;
            this.<>4__this.pointIconImage.sprite = val_59;
        }
        else
        {
                val_67 = 0;
            this.<>4__this.pointIconImage.sprite = val_59;
        }
        
        UnityEngine.Transform val_29 = this.<>4__this.pointIconImage.transform;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.zero;
        this.<>4__this.pointIconImage.localPosition = new UnityEngine.Vector3();
        UnityEngine.Transform val_31 = this.<>4__this.pointIconImage.transform;
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.one;
        this.<>4__this.pointIconImage.localScale = new UnityEngine.Vector3();
        UnityEngine.GameObject val_33 = this.<>4__this.pointIconImage.gameObject;
        this.<>4__this.pointIconImage.SetActive(value:  true);
        UnityEngine.RectTransform val_34 = this.<>4__this.pointIconImage.rectTransform;
        UnityEngine.RectTransform val_35 = this.<>4__this.pointIconImage.rectTransform;
        UnityEngine.Vector2 val_36 = sizeDelta;
        this.<>4__this.pointIconImage.sizeDelta = new UnityEngine.Vector2() {x = val_37, y = val_38};
        this.<>4__this.pointIconImage.preserveAspect = true;
        DG.Tweening.Sequence val_39 = DG.Tweening.DOTween.Sequence();
        val_68 = null;
        val_68 = null;
        val_70 = WFOEventPointsGainAnimator.<>c.<>9__37_0;
        if(val_70 == 0)
        {
                val_70 = null;
            val_70 = new DG.Tweening.TweenCallback(object:  WFOEventPointsGainAnimator.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3918461872));
            WFOEventPointsGainAnimator.<>c.<>9__37_0 = val_70;
        }
        
        DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_43 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.pointsIconParent, endValue:  new UnityEngine.Vector3(), duration:  val_42.x);
        DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.<>4__this.pointsIconParent);
        DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_42.x);
        DG.Tweening.Tweener val_46 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.radialRay, endValue:  val_42.x, duration:  val_42.y);
        object val_47 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.<>4__this.radialRay, delay:  val_42.x);
        DG.Tweening.Sequence val_48 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.<>4__this.radialRay);
        UnityEngine.Transform val_49 = transform;
        UnityEngine.Transform val_50 = this.<>4__this.pointIconImage.transform;
        val_71 = null;
        val_71 = null;
        val_73 = WFOEventPointsGainAnimator.<>c.<>9__37_1;
        if(val_73 == 0)
        {
                val_73 = null;
            val_73 = new System.Action(object:  WFOEventPointsGainAnimator.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3918475184));
            WFOEventPointsGainAnimator.<>c.<>9__37_1 = val_73;
        }
        
        val_59 = val_59;
        val_59.MoveSymbol(sq:  0, trans:  157720576, dest:  this.<>4__this.pointIconImage, onComplete:  val_73);
        val_57 = 1152921504797581312;
        DG.Tweening.TweenCallback val_52 = new DG.Tweening.TweenCallback(object:  367730688, method:  new IntPtr(3918476208));
        DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        val_64 = ???;
        var val_57 = val_64;
        val_57 = val_57 - 1;
        if(null != val_57)
        {
            goto label_71;
        }
        
        DG.Tweening.TweenCallback val_54 = new DG.Tweening.TweenCallback(object:  val_59, method:  new IntPtr(3918477232));
        DG.Tweening.Sequence val_55 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        val_57 = val_57;
        val_59.ShowProgressBarAnimation(fromQty:  this.fromQty, toQty:  this.toQty, maxQty:  mem[1152921512820316556], parentSeq:  0, onAnimationComplete:  mem[1152921512820316560]);
        val_65 = ;
        UnityEngine.WaitForSeconds.__error = 0;
        val_63 = mem[val_64];
        val_63 = val_64;
        if(0 < val_63)
        {
            goto label_72;
        }
        
        val_58 = 0;
        return (bool)val_58;
        label_71:
        UnityEngine.WaitForSeconds val_56 = null;
        val_56 = new UnityEngine.WaitForSeconds(seconds:  val_42.x);
        this.<>1__state = 3;
        val_58 = 1;
        mem[1152921512820316540] = val_56;
        return (bool)val_58;
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
