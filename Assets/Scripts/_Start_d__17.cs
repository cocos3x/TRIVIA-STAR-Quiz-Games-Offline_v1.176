using UnityEngine;
private sealed class TRVLossAversionPopup.<Start>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVLossAversionPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVLossAversionPopup.<Start>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        var val_13;
        UnityEngine.GameObject val_14;
        object val_15;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_12 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_12;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this.SetChestSprite();
        goto label_4;
        label_1:
        this.<>1__state = 0;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.<>4__this.streakStatViewInstantiator, y:  0);
        if((val_1 == false) || (val_1 == false))
        {
            goto label_13;
        }
        
        val_13 = null;
        if((this.<>4__this.streakStatViewInstantiator) == 0)
        {
                val_13 = null;
        }
        
        if((this.<>4__this.streakStatViewInstantiator) == 0)
        {
            goto label_15;
        }
        
        val_13 = null;
        if(((CurrencyStatViewInstantiator.__il2cppRuntimeField_typeHierarchy + (TRVStreakStatView.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_13)
        {
                this.<>4__this.streakStatViewInstantiator = 0;
        }
        
        goto label_19;
        label_3:
        0.SetChestSprite();
        label_4:
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  this.<>4__this, method:  new IntPtr(3798060432));
        this.<>4__this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  this.<>4__this, method:  new IntPtr(3798069648));
        this.<>4__this.exitQuizButton.m_OnClick.AddListener(call:  162246656);
        WordForest.WFOGameEcon val_4 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_5 = ToString();
        val_14 = this.<>4__this.mainGroup;
        val_12 = 1;
        val_15 = 0;
        val_14.SetActive(value:  true);
        this.<>4__this.streakBrokenGroup.SetActive(value:  false);
        this.<>1__state = val_12;
        this.<>2__current = val_15;
        return (bool)val_12;
        label_15:
        label_19:
        0.SetTextCrossout();
        label_13:
        val_14 = this.<>4__this.gcAnim;
        if((this.<>4__this.gcAnim) == 0)
        {
                val_14 = this.<>4__this.gcAnim;
        }
        
        if(0 != 0)
        {
                object val_6 = R8.GetComponent<System.Object>();
            if(R8 != 0)
        {
                object val_8 = R8.GetComponent<System.Object>();
            UnityEngine.Object.Destroy(obj:  R8);
        }
        
            R8 + 172.RemoveAllListeners();
            val_14 = mem[R8 + 172];
            val_14 = R8 + 172;
            UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  this.<>4__this, method:  new IntPtr(3797582736));
            val_12 = 0;
            val_14.AddListener(call:  162246656);
            UnityEngine.GameObject val_10 = R8.gameObject;
            R8.SetActive(value:  true);
            return (bool)val_12;
        }
        
        val_12 = 0;
        System.Action val_11 = new System.Action(object:  this.<>4__this, method:  new IntPtr(3798091152));
        mem2[0] = null;
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
