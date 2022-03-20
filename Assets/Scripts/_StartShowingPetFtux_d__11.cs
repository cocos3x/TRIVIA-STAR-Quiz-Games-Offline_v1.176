using UnityEngine;
private sealed class LevelCompleteGoldenApplesUI.<StartShowingPetFtux>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LevelCompleteGoldenApplesUI <>4__this;
    public WADPets.WADPet pet;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelCompleteGoldenApplesUI.<StartShowingPetFtux>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_3;
        string val_4;
        var val_24;
        int val_25;
        var val_26;
        var val_27;
        var val_28;
        val_24 = this;
        if((this.<>1__state) != 1)
        {
                val_25 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_25;
        }
        
            this.<>1__state = 0;
            val_25 = 1;
            this.<>1__state = val_25;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_25;
        }
        
        this.<>1__state = 0;
        val_26 = null;
        val_26 = null;
        System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_2 = Item[WADPets.LocTexts.FtuxDescription];
        string val_5 = Localization.Localize(key:  -1050416848, defaultValue:  -710979360, useSingularKey:  false);
        val_27 = "golden_apples_cap_first";
        var val_24 = 23725811;
        val_24 = 11899976 + val_24;
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_28 = null;
        val_28 = null;
        if(App.game == 4)
        {
                string val_6 = Localization.Localize(key:  -247984864, defaultValue:  -702174096, useSingularKey:  false);
            val_27 = "acorns_cap_first";
        }
        
        string val_7 = Localization.Localize(key:  val_3, defaultValue:  val_4, useSingularKey:  false);
        string val_8 = this.pet.GetPrettyName();
        string val_9 = System.String.Format(format:  val_3, arg0:  this.pet, arg1:  -247984864);
        this.<>4__this.petFtuxGroup.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_10 = new UnityEngine.Events.UnityAction(object:  this.<>4__this, method:  new IntPtr(4047003024));
        this.<>4__this.petFtuxOkButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_13 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        val_3 = 0;
        System.Nullable<UnityEngine.Color> val_14 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_14.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Interactable = true;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_19 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.Transform val_20 = this.<>4__this.petFtuxGroup.transform;
        Add(item:  this.<>4__this.petFtuxGroup);
        UnityEngine.Transform val_21 = this.<>4__this.goldenApplesGroup_pets.transform;
        Add(item:  this.<>4__this.goldenApplesGroup_pets);
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_23 = ToArray();
        val_24 = null;
        val_25 = 0;
        ShowOverlay(contentToOverlay:  80883712);
        return (bool)val_25;
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
