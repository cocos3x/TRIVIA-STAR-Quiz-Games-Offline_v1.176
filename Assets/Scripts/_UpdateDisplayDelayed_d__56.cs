using UnityEngine;
private sealed class WGEventButton.<UpdateDisplayDelayed>d__56 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventButton <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGEventButton.<UpdateDisplayDelayed>d__56(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_34;
        int val_35;
        var val_36;
        val_34 = this;
        val_35 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_35;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_35 = 1;
            this.<>1__state = val_35;
            this.<>2__current = val_1;
            return (bool)val_35;
        }
        
        this.<>1__state = 0;
        if(WordGameEventsController.EventsEnabled == false)
        {
            goto label_7;
        }
        
        UnityEngine.GameObject val_3 = this.<>4__this.event_text.gameObject;
        this.<>4__this.event_text.SetActive(value:  true);
        val_36 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((GetCurrentEventsCount >= 2) && ((this.<>4__this.LeftButton) != 0))
        {
                if((this.<>4__this.RightButton) != 0)
        {
                UnityEngine.GameObject val_8 = this.<>4__this.LeftButton.gameObject;
            this.<>4__this.LeftButton.SetActive(value:  true);
            UnityEngine.GameObject val_9 = this.<>4__this.RightButton.gameObject;
            this.<>4__this.RightButton.SetActive(value:  true);
        }
        
        }
        
        if((this.<>4__this.showingAllEventsButton) == true)
        {
            goto label_24;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGEventHandler val_11 = GetOrderedEventHandlersByIndex(index:  this.<>4__this.CurrentEventIndex);
        this.<>4__this.currentEventHandler = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) == 0)
        {
                public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance() = this.<>4__this.CurrentEventIndex;
        }
        
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) == 0)
        {
            goto label_28;
        }
        
        label_24:
        UnityEngine.GameObject val_12 = this.<>4__this.event_button.gameObject;
        this.<>4__this.event_button.SetActive(value:  true);
        val_34 = 1152921504765685760;
        if((this.<>4__this.eventsCointainer) != 0)
        {
                this.<>4__this.eventsCointainer.SetActive(value:  true);
        }
        
        if((this.<>4__this.opposingButton) != 0)
        {
                this.<>4__this.opposingButton.SetActive(value:  false);
        }
        
        if((this.<>4__this.eventsCounter) != 0)
        {
                string val_16 = Localization.Localize(key:  -1286775488, defaultValue:  -1286775584, useSingularKey:  false);
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_36 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
            string val_19 = GetCurrentEventsCount.ToString();
            string val_20 = System.String.Format(format:  -1286775488, arg0:  -296019380);
            val_34 = "events_x_upper";
        }
        
        if((this.<>4__this.currentEventHandler) == 0)
        {
            goto label_46;
        }
        
        if((this.<>4__this.showingAllEventsButton) == true)
        {
            goto label_47;
        }
        
        this.<>4__this.SetButtonContent(evtHandler:  this.<>4__this.currentEventHandler);
        val_35 = 0;
        return (bool)val_35;
        label_7:
        UnityEngine.GameObject val_21 = this.<>4__this.event_button.gameObject;
        val_34 = this.<>4__this.event_button;
        val_35 = 0;
        val_34.SetActive(value:  false);
        label_69:
        this.<>4__this.eventsCointainer.SetActive(value:  false);
        return (bool)val_35;
        label_46:
        this.<>4__this.showingAllEventsButton = true;
        label_47:
        UnityEngine.GameObject val_22 = this.<>4__this.button_prefix.gameObject;
        this.<>4__this.button_prefix.SetActive(value:  false);
        UnityEngine.RectTransform val_23 = this.<>4__this.button_prefix.rectTransform;
        UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  null, y:  null);
        this.<>4__this.button_prefix.sizeDelta = new UnityEngine.Vector2() {x = val_24.x, y = val_24.y};
        string val_25 = Localization.Localize(key:  -1648606576, defaultValue:  -1648606688, useSingularKey:  false);
        this.<>4__this.event_text.resizeTextMaxSize = 44;
        UnityEngine.RectTransform val_26 = this.<>4__this.event_text.rectTransform;
        val_34 = this.<>4__this.event_text;
        UnityEngine.RectTransform val_27 = this.<>4__this.event_text.rectTransform;
        UnityEngine.Vector2 val_28 = sizeDelta;
        UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  (this.<>4__this.defaultTextWidth) + (this.<>4__this.defaultIconWidth), y:  val_28.y);
        val_35 = 0;
        val_34.sizeDelta = new UnityEngine.Vector2() {x = val_31.x, y = val_31.y};
        return (bool)val_35;
        label_28:
        UnityEngine.GameObject val_32 = this.<>4__this.event_button.gameObject;
        this.<>4__this.event_button.SetActive(value:  false);
        if((this.<>4__this.eventsCointainer) == 0)
        {
                return (bool)val_35;
        }
        
        if((this.<>4__this.eventsCointainer) != 0)
        {
            goto label_69;
        }
        
        goto label_69;
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
