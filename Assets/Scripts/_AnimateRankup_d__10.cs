using UnityEngine;
private sealed class TRVCategoryRankPopup.<AnimateRankup>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVCategoryRankPopup <>4__this;
    private UnityEngine.CanvasGroup <cg>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVCategoryRankPopup.<AnimateRankup>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        TRVCategoryRankPopup val_8;
        object val_9;
        val_7 = 0;
        val_8 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            UnityEngine.GameObject val_1 = this.<>4__this.rank.gameObject;
            UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.rank);
            this.<cg>5__2 = this.<>4__this.rank;
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.rank, endValue:  null, duration:  null);
            UnityEngine.WaitForSeconds val_4 = null;
            val_9 = val_4;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_7 = 1;
            this.<>1__state = val_7;
            this.<>2__current = val_9;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        if(val_8 != 0)
        {
                val_9 = this.<>4__this.rank;
        }
        else
        {
                val_9 = 2621443;
        }
        
        int val_7 = this.<>4__this.currentRank;
        val_7 = 0;
        val_7 = val_7 + 1;
        string val_5 = val_7.ToString();
        val_8;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<cg>5__2, endValue:  null, duration:  null);
        return (bool)val_7;
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
