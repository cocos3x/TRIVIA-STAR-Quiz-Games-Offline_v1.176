using UnityEngine;
private sealed class MPIBoardController.<SetTilesPositions>d__70 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool shuffle;
    public SLC.MatchyPics.MPIBoardController <>4__this;
    public bool setActive;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MPIBoardController.<SetTilesPositions>d__70(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        MPIBoardController.<SetTilesPositions>d__70 val_15;
        int val_16;
        SLC.MatchyPics.MPIBoardController val_17;
        var val_18;
        var val_19;
        System.Action<SLC.MatchyPics.MPIGridTile> val_21;
        object val_22;
        var val_23;
        var val_24;
        val_15 = this;
        val_16 = 0;
        val_17 = this.<>4__this;
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
                return (bool)val_16;
        }
        
        this.<>1__state = 0;
        if(this.shuffle == false)
        {
            goto label_4;
        }
        
        val_18 = 1152921505043959808;
        val_19 = null;
        val_19 = null;
        val_21 = MPIBoardController.<>c.<>9__70_0;
        if(val_21 == 0)
        {
                val_21 = null;
            val_21 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  MPIBoardController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(758761520));
            MPIBoardController.<>c.<>9__70_0 = val_21;
        }
        
        this.<>4__this.tiles.ForEach(action:  7401472);
        UnityEngine.WaitForSeconds val_2 = null;
        val_22 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_16 = 1;
        this.<>1__state = val_16;
        goto label_12;
        label_1:
        this.<>1__state = 0;
        goto label_13;
        label_2:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  10, oneshot:  true, pitch:  null, vol:  null);
        label_13:
        val_23 = 4;
        goto label_18;
        label_48:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_21 = 0;
        if(0 <= 35633409)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(val_21 != 0)
        {
                UnityEngine.GameObject val_4 = 2621443.gameObject;
            val_24 = 0;
        }
        else
        {
                UnityEngine.Vector2Int val_5 = Location;
            if(val_6 <= 35633409)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Transform val_8 = 2621443.transform;
            int val_9 = val_6.x;
            int val_10 = val_6.y;
            val_10 = val_10 + (val_10 << 1);
            2621443.localPosition = new UnityEngine.Vector3() {x = mem[this.<>4__this.nodesPositions[((val_10 + (val_10) << 1)) << 2][0x10] + (0)], y = mem[this.<>4__this.nodesPositions[((val_10 + (val_10) << 1)) << 2][0x10] + (4)], z = mem[this.<>4__this.nodesPositions[((val_10 + (val_10) << 1)) << 2][0x10] + (8)]};
            val_17 = val_17;
            val_15 = val_15;
            if((this.<>4__this + 56 + 12) <= 35633409)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Transform val_11 = this.<>4__this + 56 + 8 + 16.transform;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            this.<>4__this + 56 + 8 + 16.localScale = new UnityEngine.Vector3();
            if((this.<>4__this + 56 + 12) <= 35633409)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.GameObject val_13 = this.<>4__this + 56 + 8 + 16.gameObject;
            if(mem[1152921513955617288] == true)
        {
                val_21 = 1;
        }
        
            val_24 = 1;
        }
        
        this.<>4__this + 56 + 8 + 16.SetActive(value:  true);
        val_23 = 5;
        label_18:
        if((val_23 - 4) < (this.<>4__this + 56 + 12))
        {
            goto label_48;
        }
        
        val_16 = 0;
        mem2[0] = val_16;
        return (bool)val_16;
        label_4:
        UnityEngine.WaitForEndOfFrame val_15 = null;
        val_22 = val_15;
        val_15 = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = 2;
        val_16 = 1;
        label_12:
        this.<>2__current = val_22;
        return (bool)val_16;
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
