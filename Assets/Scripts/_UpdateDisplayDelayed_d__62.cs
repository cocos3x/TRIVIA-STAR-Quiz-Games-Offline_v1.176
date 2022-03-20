using UnityEngine;
private sealed class WGEventButton_Game.<UpdateDisplayDelayed>d__62 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventButton_Game <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGEventButton_Game.<UpdateDisplayDelayed>d__62(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_49;
        float val_50;
        var val_54;
        var val_55;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = 1;
        this.<>2__current = val_1;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this.timerCoroutine) != 0)
        {
                this.<>4__this.StopCoroutine(routine:  this.<>4__this.timerCoroutine);
            this.<>4__this.timerCoroutine = 0;
        }
        
        if(WordGameEventsController.EventsEnabled == false)
        {
            goto label_15;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGEventHandler val_6 = GetGameSceneOrderedEventHandler(dailyChallengeState:  PlayingChallenge);
        this.<>4__this.currentEventHandler = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) == 0)
        {
            goto label_15;
        }
        
        this.<>4__this.event_text.resizeTextForBestFit = true;
        this.<>4__this + 36.fontSize = 44;
        this.<>4__this + 36.resizeTextMaxSize = 48;
        UnityEngine.GameObject val_7 = this.<>4__this + 36.gameObject;
        this.<>4__this + 36.SetActive(value:  false);
        if((this.<>4__this.event_text_bg) != 0)
        {
                this.<>4__this.event_text_bg.SetActive(value:  false);
        }
        
        this.<>4__this + 36.lineSpacing = null;
        UnityEngine.GameObject val_9 = this.<>4__this.event_button.gameObject;
        this.<>4__this.event_button.SetActive(value:  true);
        val_54 = 0;
        if((this.<>4__this.opposingButton) != 0)
        {
                val_54 = 0;
            this.<>4__this.opposingButton.SetActive(value:  false);
        }
        
        UnityEngine.Transform val_11 = this.<>4__this.event_icon.transform;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
        this.<>4__this.event_icon.localPosition = new UnityEngine.Vector3();
        val_55 = 0;
        if((this.<>4__this.event_middle_root) != 0)
        {
                UnityEngine.GameObject val_14 = this.<>4__this.event_middle_root.gameObject;
            val_55 = 0;
            this.<>4__this.event_middle_root.SetActive(value:  false);
        }
        
        UnityEngine.Color val_15 = UnityEngine.Color.white;
        float val_54 = 6.50887E-38f;
        val_54 = 7238592 + val_54;
        if(val_54 == 0)
        {
                mem2[0] = 1;
        }
        
        if((this.<>4__this.currentEventHandler.myEvent) != 0)
        {
                "" = this.<>4__this.currentEventHandler.myEvent.type;
        }
        
        uint val_16 = _PrivateImplementationDetails_.ComputeStringHash(s:  mem[this.<>4__this.currentEventHandler.myEvent.type]);
        if(val_16 > 1537055809)
        {
            goto label_44;
        }
        
        if(val_16 > 697097638)
        {
            goto label_45;
        }
        
        if(val_16 > 231953039)
        {
            goto label_46;
        }
        
        if(val_16 == 54006602)
        {
            goto label_47;
        }
        
        if(val_16 == 145907821)
        {
            goto label_48;
        }
        
        if((val_16 != 231953039) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1342036480)) == false))
        {
            goto label_154;
        }
        
        this.<>4__this.event_icon.sprite = this.<>4__this.letterBankGameSprite;
        this.<>4__this + 44.preserveAspect = true;
        UnityEngine.RectTransform val_18 = this.<>4__this + 44.rectTransform;
        this.<>4__this + 44.sizeDelta = new UnityEngine.Vector2() {x = this.<>4__this.icon_size, y = 1.246431E-37f};
        UnityEngine.GameObject val_19 = this.<>4__this + 44.gameObject;
        this.<>4__this + 44.SetActive(value:  true);
        this.<>4__this + 36.fontSize = 40;
        goto label_134;
        label_15:
        UnityEngine.GameObject val_20 = this.<>4__this.event_button.gameObject;
        this.<>4__this.event_button.SetActive(value:  false);
        goto label_61;
        label_44:
        if(val_16 > 2902602938)
        {
            goto label_62;
        }
        
        if(val_16 > 2664185753)
        {
            goto label_63;
        }
        
        if(val_16 == 2337712501)
        {
            goto label_64;
        }
        
        if(val_16 == 2600860205)
        {
            goto label_65;
        }
        
        if((val_16 != 2664185753) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1306784064)) == false))
        {
            goto label_154;
        }
        
        goto label_138;
        label_45:
        if(val_16 > 1054264077)
        {
            goto label_69;
        }
        
        if(val_16 == 701935430)
        {
            goto label_70;
        }
        
        if(val_16 == 958660756)
        {
            goto label_71;
        }
        
        if((val_16 != 1054264077) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1648524352)) == false))
        {
            goto label_154;
        }
        
        this.<>4__this.event_icon.sprite = this.<>4__this.prgressiveIAPSprite;
        UnityEngine.Color val_23 = MetricSystem.HexToColor(hex:  -292593864);
        this.<>4__this + 44.preserveAspect = true;
        UnityEngine.RectTransform val_24 = this.<>4__this + 44.rectTransform;
        UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  val_23.r, y:  val_23.g);
        this.<>4__this + 44.sizeDelta = new UnityEngine.Vector2() {x = val_25.x, y = val_25.y};
        goto label_81;
        label_62:
        if(val_16 > 3275071436)
        {
            goto label_82;
        }
        
        if(val_16 > 3193092183)
        {
            goto label_83;
        }
        
        if(val_16 == 3165936380)
        {
            goto label_84;
        }
        
        if((val_16 != 3193092183) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1266462592)) == false))
        {
            goto label_154;
        }
        
        goto label_87;
        label_46:
        if(val_16 > 386644468)
        {
            goto label_88;
        }
        
        if(val_16 == 264778422)
        {
            goto label_89;
        }
        
        if((val_16 != 386644468) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1298908064)) == false))
        {
            goto label_154;
        }
        
        goto label_155;
        label_63:
        if(val_16 > 2845304644)
        {
            goto label_93;
        }
        
        if(val_16 == 2763165661)
        {
            goto label_94;
        }
        
        if((val_16 != 2845304644) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1266461696)) == false))
        {
            goto label_154;
        }
        
        this.<>4__this.event_icon.sprite = this.<>4__this.superBundleSprite;
        UnityEngine.RectTransform val_29 = this.<>4__this + 44.rectTransform;
        this.<>4__this + 44.sizeDelta = new UnityEngine.Vector2() {x = this.<>4__this.icon_size, y = 1.246431E-37f};
        UnityEngine.GameObject val_30 = this.<>4__this + 36.gameObject;
        this.<>4__this + 36.SetActive(value:  true);
        System.Collections.IEnumerator val_31 = this.<>4__this.UpdateButtonTextTimer(seconds:  5);
        UnityEngine.Coroutine val_32 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        this.<>4__this.timerCoroutine = this.<>4__this;
        goto label_154;
        label_69:
        if(val_16 > 1314484049)
        {
            goto label_103;
        }
        
        if(val_16 == 1188660454)
        {
            goto label_104;
        }
        
        if((val_16 != 1314484049) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1298908816)) == false))
        {
            goto label_154;
        }
        
        this.<>4__this.event_icon.sprite = this.<>4__this.seasonPassSprite;
        UnityEngine.RectTransform val_34 = this.<>4__this + 44.rectTransform;
        UnityEngine.Vector2 val_35 = new UnityEngine.Vector2(x:  val_15.r, y:  val_15.g);
        if((this.<>4__this + 44) != 0)
        {
            goto label_110;
        }
        
        goto label_110;
        label_82:
        if(val_16 > 3764625999)
        {
            goto label_111;
        }
        
        if(val_16 == 3531375042)
        {
            goto label_112;
        }
        
        if((val_16 != 3764625999) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1266462000)) == false))
        {
            goto label_154;
        }
        
        goto label_155;
        label_83:
        if(val_16 == 3251312870)
        {
            goto label_116;
        }
        
        if((val_16 != 3275071436) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1266462880)) == false))
        {
            goto label_154;
        }
        
        goto label_138;
        label_88:
        if(val_16 == 655166938)
        {
            goto label_120;
        }
        
        if((val_16 != 697097638) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1401622144)) == false))
        {
            goto label_154;
        }
        
        this.<>4__this.event_icon.sprite = this.<>4__this.forestFrenzySprite;
        this.<>4__this + 44.preserveAspect = true;
        UnityEngine.RectTransform val_39 = this.<>4__this + 44.rectTransform;
        this.<>4__this + 44.sizeDelta = new UnityEngine.Vector2() {x = this.<>4__this.icon_size, y = val_54};
        UnityEngine.GameObject val_40 = this.<>4__this + 44.gameObject;
        this.<>4__this + 44.SetActive(value:  true);
        this.<>4__this + 36.fontSize = 40;
        if((this.<>4__this.event_text_bg) == 0)
        {
            goto label_134;
        }
        
        this.<>4__this.event_text_bg.SetActive(value:  false);
        goto label_134;
        label_93:
        if(val_16 == 2864846394)
        {
            goto label_135;
        }
        
        if((val_16 != 2902602938) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1280644912)) == false))
        {
            goto label_154;
        }
        
        goto label_138;
        label_103:
        if(val_16 == 1399814793)
        {
            goto label_139;
        }
        
        if((val_16 != 1537055809) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1266462096)) == false))
        {
            goto label_154;
        }
        
        goto label_155;
        label_111:
        if(val_16 == 4210228650)
        {
            goto label_143;
        }
        
        if((val_16 != 4241560753) || ((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1298908160)) == false))
        {
            goto label_154;
        }
        
        this.<>4__this.event_icon.sprite = this.<>4__this.ccCvCGameSprite;
        UnityEngine.RectTransform val_45 = this.<>4__this + 44.rectTransform;
        UnityEngine.Vector3 val_46 = val_35.x.localPosition;
        UnityEngine.Vector3 val_47 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -2.218567E+28f, y = val_25.x, z = val_25.y}, d:  val_47.x);
        UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -2.218564E+28f, y = val_35.x, z = val_35.y}, b:  new UnityEngine.Vector3() {y = val_50, z = val_49});
        this.<>4__this + 44.localPosition = new UnityEngine.Vector3();
        goto label_153;
        label_47:
        if((System.String.op_Equality(a:  mem[this.<>4__this.currentEventHandler.myEvent.type], b:  -1321166448)) != false)
        {
            
        }
    
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
