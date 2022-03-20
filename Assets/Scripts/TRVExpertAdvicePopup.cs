using UnityEngine;
public class TRVExpertAdvicePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image expertImage;
    private UnityEngine.UI.Text expertAdvice;
    private UnityEngine.UI.Button continueButton;
    public System.Action onCloseAction;
    private UnityEngine.UI.Text timerText;
    
    // Methods
    public void Init(TRVExpert exp, TRVExpertOutcomes outcome, bool wasFree)
    {
        UnityEngine.Material val_21;
        float val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        this.expertImage.sprite = exp.mySprite;
        val_23 = 1152921511548963376;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -621767152, method:  new IntPtr(3673171264));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(outcome == 2)
        {
            goto label_9;
        }
        
        if(outcome == 1)
        {
            goto label_10;
        }
        
        val_24 = 1152921504901095424;
        if(outcome != 0)
        {
            goto label_35;
        }
        
        AddRange(collection:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 28);
        Add(item:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 24);
        val_25 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 28;
        val_26 = UnityEngine.Random.Range(min:  0, max:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 28 + 12);
        goto label_16;
        label_10:
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 24);
        val_27 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 28;
        val_28 = UnityEngine.Random.Range(min:  0, max:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 28 + 12);
        goto label_20;
        label_9:
        string val_7 = Localization.Localize(key:  -621794864, defaultValue:  -621795008, useSingularKey:  false);
        string val_8 = System.String.Format(format:  -621794864, arg0:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 24);
        val_24 = 1152921504901095424;
        val_29 = mem[public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 24];
        val_29 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 24;
        val_30 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
        goto label_24;
        label_20:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        Add(item:  (public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 28 + 8 + (val_9) << 2) + 16);
        PluginExtension.Shuffle<UnityEngine.Sprite>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        string val_10 = Localization.Localize(key:  -621794608, defaultValue:  -621794752, useSingularKey:  false);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        string val_11 = System.String.Format(format:  -621794608, arg0:  List<T>.__il2cppRuntimeField_10, arg1:  List<T>.__il2cppRuntimeField_14);
        val_24 = 1152921504901095424;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_23 = 1152921511548963376;
        Add(item:  List<T>.__il2cppRuntimeField_10);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_30 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
        label_24:
        Add(item:  List<T>.__il2cppRuntimeField_14);
        goto label_35;
        label_16:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        bool val_13 = Remove(item:  (public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 28 + 8 + (val_12) << 2) + 16);
        string val_14 = Localization.Localize(key:  -621794496, defaultValue:  -621794384, useSingularKey:  false);
        string val_15 = System.String.Format(format:  -621794496, arg0:  (public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 28 + 8 + (val_12) << 2) + 16);
        label_35:
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_17 = public static TRVGameplayUI MonoSingleton<TRVGameplayUI>::get_Instance().__il2cppRuntimeField_10.TimeRemainingText();
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        List.Enumerator<T> val_19 = GetEnumerator();
        label_56:
        if(MoveNext() == false)
        {
            goto label_49;
        }
        
        if((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 16 + 52.ContainsKey(key:  val_21)) == false)
        {
            goto label_52;
        }
        
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 16 + 52.set_Item(key:  val_21, value:  exp);
        goto label_56;
        label_52:
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 16 + 52.Add(key:  val_21, value:  exp);
        goto label_56;
        label_49:
        Dispose();
        if(wasFree == false)
        {
                return;
        }
        
        mem2[0] = 1;
    }
    private void FixedUpdate()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_2 = public static TRVGameplayUI MonoSingleton<TRVGameplayUI>::get_Instance().__il2cppRuntimeField_10.TimeRemainingText();
        if(this.timerText == 0)
        {
            
        }
    
    }
    private void OnContinuePress()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateGameState(incData:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -621506288, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(this.onCloseAction == 0)
        {
                return;
        }
        
        this.onCloseAction.Invoke();
    }
    public TRVExpertAdvicePopup()
    {
    
    }

}
