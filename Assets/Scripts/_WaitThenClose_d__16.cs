using UnityEngine;
private sealed class TRVGiftRewardPopup.<WaitThenClose>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVGiftRewardPopup <>4__this;
    public bool expertLeveledUp;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVGiftRewardPopup.<WaitThenClose>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        TRVGiftRewardPopup val_7;
        val_6 = 0;
        val_7 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_7 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_6 = 1;
        this.<>1__state = val_6;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if(this.expertLeveledUp == true)
        {
                this.expertLeveledUp = 1;
        }
        
        val_7.Close(expertLeveledUp:  true);
        return (bool)val_6;
        label_2:
        this.<>1__state = 0;
        UnityEngine.GameObject val_2 = val_7.gameObject;
        UnityEngine.UI.LayoutElement val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  val_7);
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_7, endValue:  null, duration:  null);
        UnityEngine.WaitForSeconds val_5 = null;
        val_7 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_6 = 1;
        this.<>1__state = 2;
        label_4:
        this.<>2__current = val_7;
        return (bool)val_6;
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
