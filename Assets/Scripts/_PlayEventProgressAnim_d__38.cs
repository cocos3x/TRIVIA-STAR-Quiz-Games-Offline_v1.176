using UnityEngine;
private sealed class WFOLevelClearPopup.<PlayEventProgressAnim>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WFOLevelClearPopup <>4__this;
    private WGEventButtonV2 <evt02_Button>5__2;
    private WGEventButtonV2 <evt02_ProgressUI>5__3;
    private bool <isSlotTwoEmpty>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOLevelClearPopup.<PlayEventProgressAnim>d__38(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_18;
        UnityEngine.Object val_19;
        WGEventButtonV2 val_20;
        WGEventButtonV2 val_21;
        bool val_22;
        WGEventButtonV2 val_23;
        WGEventHandler val_24;
        bool val_25;
        bool val_26;
        WGEventButtonV2 val_27;
        object val_28;
        val_18 = 0;
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
                return (bool)val_18;
        }
        
        this.<>1__state = 0;
        val_19 = 0;
        if((this.<>4__this.eventButtonPanel) != 0)
        {
                WGEventButtonV2 val_2 = this.<>4__this.eventButtonPanel.GetEventButton(slotIndex:  0);
            val_19 = this.<>4__this.eventButtonPanel;
        }
        
        if((this.<>4__this.eventProgressPanel) != 0)
        {
                WGEventButtonV2 val_4 = this.<>4__this.eventProgressPanel.GetEventButton(slotIndex:  0);
        }
        
        val_20 = 0;
        if((this.<>4__this.eventButtonPanel) != 0)
        {
                WGEventButtonV2 val_6 = this.<>4__this.eventButtonPanel.GetEventButton(slotIndex:  1);
            val_20 = this.<>4__this.eventButtonPanel;
        }
        
        this.<evt02_Button>5__2 = val_20;
        val_21 = 0;
        if((this.<>4__this.eventProgressPanel) != 0)
        {
                WGEventButtonV2 val_8 = this.<>4__this.eventProgressPanel.GetEventButton(slotIndex:  1);
            val_21 = this.<>4__this.eventProgressPanel;
        }
        
        this.<evt02_ProgressUI>5__3 = val_21;
        val_22 = 0;
        if(val_19 == 0)
        {
                val_22 = UnityEngine.Object.op_Equality(x:  this.<>4__this.eventProgressPanel, y:  0);
        }
        
        val_23 = this.<evt02_Button>5__2;
        val_24 = val_19;
        val_25 = 0;
        if(val_23 == 0)
        {
                val_23 = this.<evt02_ProgressUI>5__3;
            val_25 = UnityEngine.Object.op_Equality(x:  val_23, y:  0);
        }
        
        val_26 = this;
        this.<isSlotTwoEmpty>5__4 = val_25;
        if((val_22 & val_25) != 0)
        {
            goto label_31;
        }
        
        this.<>4__this.PlayChapterProgressAnim();
        val_18 = 0;
        return (bool)val_18;
        label_2:
        val_26 = this.<isSlotTwoEmpty>5__4;
        this.<>1__state = 0;
        label_56:
        if(val_26 == true)
        {
            goto label_33;
        }
        
        bool val_13 = UnityEngine.Object.op_Inequality(x:  this.<evt02_Button>5__2, y:  0);
        if(val_13 == false)
        {
                val_13 = this.<evt02_ProgressUI>5__3;
        }
        
        if(val_13 == true)
        {
                val_27 = this.<evt02_Button>5__2;
        }
        
        if(val_27 == 0)
        {
            goto label_60;
        }
        
        val_24 = this.<evt02_Button>5__2.eventHandler;
        val_25 = this.<evt02_Button>5__2;
        val_28 = val_24;
        val_18 = 1;
        this.<>1__state = 2;
        goto label_38;
        label_1:
        this.<>1__state = 0;
        label_33:
        this.<>4__this.PlayChapterProgressAnim();
        return (bool)val_18;
        label_31:
        val_25 = val_24;
        if(val_24 != 0)
        {
                this.<>4__this.eventButtonPanel.layout.alpha = null;
        }
        
        if((this.<evt02_Button>5__2) != 0)
        {
                this.<evt02_Button>5__2.canvasGroup.alpha = null;
        }
        
        if((this.<>4__this.eventButtonPanel) != 0)
        {
                this.<>4__this.eventButtonPanel.rootCanvasGroup.alpha = null;
        }
        
        if(val_22 == true)
        {
            goto label_56;
        }
        
        if(val_25 == 0)
        {
            goto label_59;
        }
        
        val_27 = val_25;
        if(val_25 == 0)
        {
            goto label_60;
        }
        
        label_62:
        val_24 = this.<>4__this.eventButtonPanel.onEnableDelay;
        val_28 = val_24;
        val_18 = 1;
        this.<>1__state = val_18;
        label_38:
        this.<>2__current = val_28;
        return (bool)val_18;
        label_59:
        val_27 = this.<>4__this.eventProgressPanel;
        if(val_27 != 0)
        {
            goto label_62;
        }
        
        label_60:
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
