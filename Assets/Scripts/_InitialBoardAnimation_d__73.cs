using UnityEngine;
private sealed class MPIBoardController.<InitialBoardAnimation>d__73 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.MatchyPics.MPIBoardController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MPIBoardController.<InitialBoardAnimation>d__73(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Transform val_3;
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        MPIBoardController.<InitialBoardAnimation>d__73 val_20;
        var val_21;
        var val_22;
        int val_23;
        System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> val_24;
        var val_25;
        float val_26;
        float val_27;
        val_20 = this;
        val_21 = 0;
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
                return (bool)val_21;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_22 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_23 = 1;
        goto label_4;
        label_2:
        this.<>1__state = 0;
        val_24 = this.<>4__this.tiles;
        List.Enumerator<T> val_2 = GetEnumerator();
        val_26 = 0f;
        val_27 = 1152921504762384384;
        goto label_10;
        label_17:
        val_24 = mem[val_3 + 44];
        val_24 = val_3 + 44;
        if((val_3 + 44 + 20) == 0)
        {
                UnityEngine.Vector2Int val_4 = UnityEngine.Vector2Int.zero;
            UnityEngine.Vector2Int val_5 = Location;
            float val_10 = UnityEngine.Vector2Int.Distance(a:  new UnityEngine.Vector2Int() {m_X = val_6, m_Y = val_7}, b:  new UnityEngine.Vector2Int() {m_X = val_8, m_Y = val_9});
            float val_20 = val_6;
            val_20 = val_20 * 0.05f;
            float val_11 = UnityEngine.Mathf.Max(a:  val_20, b:  null);
            val_26 = 0;
            UnityEngine.GameObject val_12 = val_3.gameObject;
            val_24 = val_3;
            val_24.SetActive(value:  true);
            UnityEngine.Transform val_13 = val_3.transform;
            UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_11, y:  null);
            val_3.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            UnityEngine.Transform val_15 = val_3.transform;
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_3, endValue:  val_11, duration:  null);
            val_25 = ;
            object val_17 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  val_3, delay:  val_11);
            val_27 = 1152921504762384384;
            val_20 = val_20;
        }
        
        label_10:
        if(MoveNext() == true)
        {
            goto label_17;
        }
        
        Dispose();
        val_26 = val_26 + 0.3f;
        UnityEngine.WaitForSeconds val_19 = null;
        val_22 = val_19;
        val_19 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        val_23 = 2;
        label_4:
        val_21 = 1;
        mem[1152921513956372220] = val_22;
        goto label_18;
        label_1:
        val_23 = 0;
        label_18:
        this.<>1__state = val_23;
        return (bool)val_21;
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
