using UnityEngine;
private sealed class WADPetProfile.<ShowLevelupAnim>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WADPetProfile <>4__this;
    private WADPetProfile.<>c__DisplayClass21_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WADPetProfile.<ShowLevelupAnim>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WADPetProfile val_11;
        int val_12;
        object val_13;
        val_11 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_12 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_12;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.levelupAnim);
        typeof(WADPetProfile.<>c__DisplayClass21_0).__il2cppRuntimeField_8 = this.<>4__this.levelupAnim;
        this.<>8__1.cg.alpha = null;
        val_12 = 1;
        this.<>4__this.levelupAnim.SetActive(value:  true);
        DG.Tweening.Core.DOGetter<System.Single> val_3 = new DG.Tweening.Core.DOGetter<System.Single>(object:  this.<>8__1, method:  new IntPtr(3319541696));
        val_11 = null;
        val_11 = new DG.Tweening.Core.DOSetter<System.Single>(object:  this.<>8__1, method:  new IntPtr(3319546816));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_5 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  null, duration:  null);
        UnityEngine.WaitForSeconds val_6 = null;
        val_13 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = val_12;
        this.<>2__current = val_13;
        return (bool)val_12;
        label_1:
        this.<>1__state = 0;
        val_12 = 0;
        this.<>4__this.levelupAnim.SetActive(value:  false);
        return (bool)val_12;
        label_2:
        this.<>1__state = 0;
        DG.Tweening.Core.DOGetter<System.Single> val_7 = new DG.Tweening.Core.DOGetter<System.Single>(object:  this.<>8__1, method:  new IntPtr(3319556032));
        val_11 = this.<>8__1;
        val_13 = null;
        val_13 = new DG.Tweening.Core.DOSetter<System.Single>(object:  val_11, method:  new IntPtr(3319561152));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_9 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  null, duration:  null);
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        val_12 = 1;
        return (bool)val_12;
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
