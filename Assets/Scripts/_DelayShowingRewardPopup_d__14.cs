using UnityEngine;
private sealed class TRVStarChampionshipEventPopup.<DelayShowingRewardPopup>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVStarChampionshipEventPopup <>4__this;
    public TRVStarChampionshipRewardUIParam param;
    private TRVStarChampionshipEventPopup.<>c__DisplayClass14_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVStarChampionshipEventPopup.<DelayShowingRewardPopup>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        object val_11;
        if((this.<>1__state) != 1)
        {
                val_10 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
            this.<>1__state = 0;
            this.<>8__1 = new System.Object();
            typeof(TRVStarChampionshipEventPopup.<>c__DisplayClass14_0).__il2cppRuntimeField_8 = this.<>4__this;
            this.<>8__1.param = this.param;
            this.<>4__this.popupHolder.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.<>4__this.gemAnim.gameObject;
            this.<>4__this.gemAnim.SetActive(value:  false);
            UnityEngine.WaitForSeconds val_3 = null;
            val_11 = val_3;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_10 = 1;
            this.<>1__state = val_10;
            this.<>2__current = val_11;
            return (bool)val_10;
        }
        
        this.<>1__state = 0;
        UnityEngine.GameObject val_4 = this.<>4__this.description_bottom.gameObject;
        this.<>4__this.description_bottom.SetActive(value:  false);
        this.<>4__this.progressBar.UpdateProgressBar(progress:  null, tier:  S16);
        string val_5 = this.<>8__1.param.reward.ToString();
        this.<>4__this.rewardGroup.SetActive(value:  true);
        string val_6 = Localization.Localize(key:  -1827401648, defaultValue:  -1827401552, useSingularKey:  false);
        val_11 = this.<>8__1;
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  val_11, method:  new IntPtr(3885399904));
        this.<>4__this.button.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_8 = this.<>4__this.closeButton.gameObject;
        this.<>4__this.closeButton.SetActive(value:  false);
        UnityEngine.GameObject val_9 = this.<>4__this.gemAnim.gameObject;
        val_10 = 0;
        this.<>4__this.gemAnim.SetActive(value:  true);
        this.<>4__this.popupHolder.SetActive(value:  true);
        return (bool)val_10;
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
