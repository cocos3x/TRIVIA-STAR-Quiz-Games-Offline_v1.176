using UnityEngine;
public class HintFeatureManager : MonoSingleton<HintFeatureManager>
{
    // Fields
    private System.Collections.Generic.List<HintFeatureHandler> freeHintManagers;
    private HintFeatureHandler lastChosen;
    private bool freeHintOnLastCheck;
    private WGHintButton <wgHbutton>k__BackingField;
    
    // Properties
    public WGHintButton wgHbutton { get; set; }
    public bool PlayerEligableFreeHint { get; }
    
    // Methods
    public WGHintButton get_wgHbutton()
    {
    
    }
    private void set_wgHbutton(WGHintButton value)
    {
        this.<wgHbutton>k__BackingField = value;
    }
    public override void InitMonoSingleton()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1418031840, method:  new IntPtr(2876910432));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
    }
    private void Start()
    {
        var val_5;
        UnityEngine.GameObject val_1 = this.gameObject;
        T[] val_2 = this.GetComponents<System.Object>();
        this.freeHintManagers.AddRange(collection:  -1417906528);
        List.Enumerator<T> val_3 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        if(val_5 == 0)
        {
            goto label_7;
        }
        
        goto label_7;
        label_4:
        Dispose();
    }
    private void OnDestroy()
    {
        this.freeHintManagers.Clear();
    }
    private void OnSceneLoaded(SceneType scene)
    {
        var val_3;
        SceneType val_12 = scene;
        if(val_12 != 2)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        if(val_3 != 0)
        {
            goto label_5;
        }
        
        goto label_5;
        label_3:
        Dispose();
        WordRegion val_4 = WordRegion.instance;
        if(0 != 0)
        {
                WordRegion val_6 = WordRegion.instance;
            System.Action val_7 = new System.Action(object:  -1417654880, method:  new IntPtr(2877286368));
            0.addOnLevelLoadCompleteAction(callback:  7454720);
        }
        
        val_12 = 1152921504885600256;
        MainController val_8 = MainController.instance;
        if(0 != 0)
        {
                MainController val_10 = MainController.instance;
            val_12 = null;
            val_12 = new UnityEngine.Events.UnityAction(object:  -1417654880, method:  new IntPtr(2877287392));
            1.AddListener(call:  162246656);
        }
        
        this.UpdateFreeHintEligable();
    }
    private void OnLevelStarted()
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_3 != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        Dispose();
    }
    private void OnLevelCompeleted()
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_3 == 0)
        {
            goto label_5;
        }
        
        goto label_5;
        label_2:
        Dispose();
    }
    public void UpdateFreeHintEligable()
    {
        var val_1;
        bool val_2;
        val_1 = 4;
        this.lastChosen = 0;
        goto label_1;
        label_11:
        if(0 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443 == 0)
        {
            goto label_5;
        }
        
        if(2621443 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443 != 0)
        {
            goto label_9;
        }
        
        label_5:
        val_1 = 5;
        label_1:
        if((val_1 - 4) < 2621443)
        {
            goto label_11;
        }
        
        val_2 = 0;
        goto label_12;
        label_9:
        if(2621443 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.lastChosen = 2621443;
        val_2 = true;
        label_12:
        this.freeHintOnLastCheck = val_2;
    }
    public void OnHintUsed(bool wasFree)
    {
        UnityEngine.Object val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_3 != this.lastChosen)
        {
            goto label_5;
        }
        
        if(val_3 != 0)
        {
            goto label_9;
        }
        
        goto label_9;
        label_5:
        if(val_3 != 0)
        {
            goto label_9;
        }
        
        goto label_9;
        label_2:
        Dispose();
        this.UpdateFreeHintEligable();
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -2101040096)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnAnyHintUsed(wasFree:  wasFree);
    }
    public bool get_PlayerEligableFreeHint()
    {
        return (bool)this.freeHintOnLastCheck;
    }
    public void DoHintButtonStartBehavior(WGHintButton button)
    {
        this.<wgHbutton>k__BackingField = button;
        if(this.lastChosen == 0)
        {
                return;
        }
        
        if(this.lastChosen == 0)
        {
            
        }
    
    }
    public HintFeatureManager()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.freeHintManagers = null;
    }

}
