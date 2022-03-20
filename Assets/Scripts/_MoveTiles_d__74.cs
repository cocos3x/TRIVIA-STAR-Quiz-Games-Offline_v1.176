using UnityEngine;
private sealed class MPIBoardController.<MoveTiles>d__74 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.MatchyPics.MPIBoardController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MPIBoardController.<MoveTiles>d__74(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_21;
        float val_22;
        var val_23;
        float val_28;
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
        val_21 = 1;
        this.<>1__state = val_21;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        return (bool)val_21;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_5;
        }
        
        this.<>4__this.needsMovementUpdate = false;
        this.<>4__this.LoadPathdFindingAndValidateBoard();
        goto label_6;
        label_2:
        val_22 = 0f;
        val_23 = 4;
        this.<>1__state = 0;
        goto label_7;
        label_40:
        if(0 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_2 = 2621443.gameObject;
        bool val_3 = 2621443.activeSelf;
        if(val_3 != false)
        {
                if(val_3 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Vector2Int val_4 = Location;
            int val_7 = val_5.x;
            int val_8 = val_5.y;
            val_8 = val_8 + (val_8 << 1);
            UnityEngine.Vector3 val_22 = this.<>4__this.nodesPositions[val_8 << 2];
            UnityEngine.Vector3 val_23 = this.<>4__this.nodesPositions[val_8 << 2];
            UnityEngine.Vector3 val_24 = this.<>4__this.nodesPositions[val_8 << 2];
            if(val_24 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Transform val_9 = 2621443.transform;
            UnityEngine.Vector3 val_10 = localPosition;
            bool val_11 = UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3(), rhs:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24});
            if(val_11 != false)
        {
                if(val_11 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Transform val_12 = 2621443.transform;
            UnityEngine.Vector3 val_13 = localPosition;
            float val_14 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3(), b:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24});
            UnityEngine.Vector3 val_15 = R0 / (this.<>4__this.tileSize);
            val_15 = val_15 / 25f;
            val_28 = val_15;
            float val_16 = UnityEngine.Mathf.Max(a:  val_15, b:  val_13.y);
            if(0 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_22 = 0;
            UnityEngine.Transform val_17 = 2621443.transform;
            DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  2621443, endValue:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24}, duration:  val_16, snapping:  val_28);
            object val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  2621443, ease:  17);
        }
        
        }
        
        val_23 = 5;
        label_7:
        if((val_23 - 4) < 2621443)
        {
            goto label_40;
        }
        
        val_21 = 1;
        this.<>1__state = 2;
        mem[1152921513957135356] = new UnityEngine.WaitForSeconds(seconds:  val_16);
        return (bool)val_21;
        label_5:
        mem[88] = 0;
        0.LoadPathdFindingAndValidateBoard();
        label_6:
        this.<>4__this.OnRemoveTilesFinish();
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
