using UnityEngine;
private sealed class WFOEventButton.<UpdateDisplayDelayed>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WFOEventButton <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOEventButton.<UpdateDisplayDelayed>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        GameEventV2 val_10;
        int val_30;
        var val_31;
        var val_32;
        System.Collections.Generic.List<System.String> val_33;
        var val_34;
        var val_35;
        var val_36;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        val_30 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_30;
        }
        
        this.<>1__state = 0;
        if(WordGameEventsController.EventsEnabled == false)
        {
            goto label_6;
        }
        
        if((this.<>4__this) == 0)
        {
            goto label_7;
        }
        
        this.<>4__this.isInSneakPreviewMode = false;
        goto label_8;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_9;
        }
        
        goto label_10;
        label_1:
        this.<>1__state = 0;
        val_30 = 0;
        if(WordGameEventsController.EventsEnabled == true)
        {
                return (bool)val_30;
        }
        
        UnityEngine.GameObject val_3 = R5.gameObject;
        R5.SetActive(value:  false);
        R5.SetActive(value:  false);
        GameBehavior val_4 = App.getBehavior;
        val_30 = 0;
        if(0 == 0)
        {
                return (bool)val_30;
        }
        
        GameBehavior val_5 = App.getBehavior;
        val_30 = 0;
        if(0 != 0)
        {
                return (bool)val_30;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        List.Enumerator<T> val_7 = GetEnumerator();
        label_50:
        if(MoveNext() == false)
        {
            goto label_32;
        }
        
        object val_9 = new System.Object();
        if(val_9 != 0)
        {
                val_32 = val_9;
            typeof(WFOEventButton.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = val_10;
            val_33 = this.<>4__this.eventsToSkipProcessing;
        }
        else
        {
                val_32 = 8;
            mem[8] = val_10;
            val_33 = this.<>4__this.eventsToSkipProcessing;
        }
        
        if((val_33.Contains(item:  val_10 + 56)) == true)
        {
            goto label_50;
        }
        
        GameEcon val_12 = App.getGameEcon;
        if((val_10 + 76) > 983057)
        {
            goto label_50;
        }
        
        System.Predicate<ZooTile> val_13 = new System.Predicate<ZooTile>(object:  367038464, method:  new IntPtr(3908590224));
        WGEventHandler val_14 = this.<>4__this.sneakPreviewLockedEventList.Find(match:  8040448);
        if((this.<>4__this.sneakPreviewLockedEventList) == 0)
        {
            goto label_45;
        }
        
        label_76:
        label_74:
        if((this.<>4__this.sneakPreviewLockedEventList) >= 1)
        {
                this.<>4__this.sneakPreviewLockedEventList = true;
            this.<>4__this.isInSneakPreviewMode = this.<>4__this.sneakPreviewLockedEventList;
        }
        
        goto label_50;
        label_45:
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGEventHandler val_16 = ForceInitNewHandlerForEvent(eventV2:  mem[8]);
        if(((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) == 0) || ((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) == 0))
        {
            goto label_56;
        }
        
        GameEcon val_17 = App.getGameEcon;
        val_34 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) <= 983057)
        {
            goto label_60;
        }
        
        label_56:
        this.<>4__this.eventsToSkipProcessing.Add(item:  val_10 + 56);
        val_34 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        if(val_34 != 0)
        {
            goto label_64;
        }
        
        goto label_65;
        label_60:
        this.<>4__this.sneakPreviewLockedEventList.Add(item:  -2101040096);
        label_64:
        var val_29 = 0;
        val_29 = val_29 + 1;
        val_35 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        val_36 = val_35;
        label_65:
        var val_30 = 2;
        if((val_30 == 1) || (447 != 447))
        {
            goto label_76;
        }
        
        val_30 = val_30 + 0;
        goto label_74;
        label_6:
        UnityEngine.WaitForSeconds val_19 = null;
        val_19 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_30 = 1;
        this.<>1__state = 2;
        this.<>2__current = val_19;
        return (bool)val_30;
        label_9:
        val_31 = 308;
        label_10:
        if(val_31 == 0)
        {
                return (bool)val_30;
        }
        
        val_30 = 0;
        string val_20 = val_31.EventType;
        return (bool)val_30;
        label_7:
        mem[197] = 0;
        label_8:
        System.Collections.IEnumerator val_21 = this.<>4__this.UpdateDisplayDelayed();
        val_30 = 1;
        this.<>1__state = val_30;
        this.<>2__current = this.<>4__this;
        return (bool)val_30;
        label_32:
        var val_31 = val_30;
        val_31 = 1152921512810446200 + (val_31 << 2);
        mem2[0] = 496;
        Dispose();
        if((this.<>4__this.isInSneakPreviewMode) == false)
        {
                return (bool)val_30;
        }
        
        UnityEngine.GameObject val_22 = public static GameEventsManager MonoSingleton<GameEventsManager>::get_Instance().__il2cppRuntimeField_2C.gameObject;
        public static GameEventsManager MonoSingleton<GameEventsManager>::get_Instance().__il2cppRuntimeField_2C.SetActive(value:  true);
        public static GameEventsManager MonoSingleton<GameEventsManager>::get_Instance().__il2cppRuntimeField_2C.SetActive(value:  true);
        UnityEngine.GameObject val_23 = this.<>4__this.iconLocked.gameObject;
        this.<>4__this.iconLocked.SetActive(value:  true);
        GameEcon val_24 = App.getGameEcon;
        string val_25 = System.String.Format(format:  -386355568, arg0:  13152256);
        if((this.<>4__this.lockedLabel) != 0)
        {
                string val_27 = Localization.Localize(key:  -1286775488, defaultValue:  -1286775584, useSingularKey:  false);
            string val_28 = System.String.Format(format:  -1286775488, arg0:  13152256);
        }
        
        if((this.<>4__this.lockedLabel) <= (this.<>4__this.lockedLabel))
        {
                var val_32 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_32 = val_32 + ((this.<>4__this.lockedLabel) << 2);
        this.<>4__this.SetButtonContent(evtHandler:  (0 + (this.<>4__this.lockedLabel) << 2) + 16);
        return (bool)val_30;
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
