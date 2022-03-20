using UnityEngine;
public class TRVExpertCategoryDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text titleText;
    private System.Collections.Generic.Dictionary<TRVExpert, TRVExpertDisplay> <myDisplays>k__BackingField;
    private TRVCategoryExpertEcon myEcon;
    
    // Properties
    public System.Collections.Generic.Dictionary<TRVExpert, TRVExpertDisplay> myDisplays { get; set; }
    
    // Methods
    public System.Collections.Generic.Dictionary<TRVExpert, TRVExpertDisplay> get_myDisplays()
    {
    
    }
    private void set_myDisplays(System.Collections.Generic.Dictionary<TRVExpert, TRVExpertDisplay> value)
    {
        this.<myDisplays>k__BackingField = value;
    }
    public void Init(TRVExpertDisplay displayPrefab, TRVCategoryExpertEcon incEcon, TRVExpertsCollectionPopup myPopup)
    {
        TRVExpert val_13;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_27;
        var val_28;
        System.Func<TRVExpert, System.String> val_30;
        var val_31;
        System.Func<TRVExpert, System.Int32> val_33;
        TRVExpert val_34;
        var val_35;
        float val_36;
        TRVExpertProgressData val_37;
        object val_1 = new System.Object();
        typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = myPopup;
        this.myEcon = incEcon;
        val_27 = null;
        val_27 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.<myDisplays>k__BackingField = val_27;
        string val_3 = this.myEcon.GetLocalizedName;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_0).__il2cppRuntimeField_C = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18;
        val_28 = null;
        val_28 = null;
        val_30 = TRVExpertCategoryDisplay.<>c.<>9__6_0;
        if(val_30 == 0)
        {
                val_30 = null;
            val_30 = new System.Func<ZooTile, System.String>(object:  TRVExpertCategoryDisplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3674167376));
            TRVExpertCategoryDisplay.<>c.<>9__6_0 = val_30;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_6 = System.Linq.Enumerable.OrderBy<System.Object, System.Object>(source:  this.myEcon.experts, keySelector:  7720960);
        val_31 = null;
        val_31 = null;
        val_33 = TRVExpertCategoryDisplay.<>c.<>9__6_1;
        if(val_33 == 0)
        {
                val_33 = null;
            val_33 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVExpertCategoryDisplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3674170448));
            TRVExpertCategoryDisplay.<>c.<>9__6_1 = val_33;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_8 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this.myEcon.experts, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<System.Object>(source:  this.myEcon.experts);
        List.Enumerator<T> val_10 = GetEnumerator();
        label_49:
        if(MoveNext() == false)
        {
            goto label_19;
        }
        
        object val_12 = new System.Object();
        if(val_12 != 0)
        {
                typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_1).__il2cppRuntimeField_C = val_1;
            val_34 = val_13;
        }
        else
        {
                mem[12] = val_1;
            val_34 = val_13;
        }
        
        typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_1).__il2cppRuntimeField_8 = val_34;
        object val_14 = new System.Object();
        typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_2).__il2cppRuntimeField_C = val_12;
        UnityEngine.Transform val_15 = this.transform;
        object val_16 = UnityEngine.Object.Instantiate<System.Object>(original:  displayPrefab, parent:  -620754416);
        val_35 = typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_2).__il2cppRuntimeField_C;
        typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_2).__il2cppRuntimeField_8 = displayPrefab;
        if(val_35 != 0)
        {
                val_36 = typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_1).__il2cppRuntimeField_8;
        }
        else
        {
                val_36 = typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_1).__il2cppRuntimeField_8;
            val_35 = typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_2).__il2cppRuntimeField_C;
            if(val_35 == 0)
        {
                val_35 = 0;
        }
        
        }
        
        val_37 = 0;
        if((typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_0).__il2cppRuntimeField_C.ContainsKey(key:  val_13 + 8)) != false)
        {
                string val_18 = typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_0).__il2cppRuntimeField_C.Item[val_13 + 8];
            val_37 = typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_0).__il2cppRuntimeField_C;
        }
        
        displayPrefab.Init(me:  val_36, progress:  val_37, upgraded:  false, showName:  false);
        this.<myDisplays>k__BackingField.Add(key:  typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_1).__il2cppRuntimeField_8, value:  typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_2).__il2cppRuntimeField_8);
        if((typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_0).__il2cppRuntimeField_C.ContainsKey(key:  val_13 + 8)) == false)
        {
            goto label_49;
        }
        
        twelvegigs.Autopilot.WUTAutopilotGameplay val_20 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  typeof(TRVExpertCategoryDisplay.<>c__DisplayClass6_2).__il2cppRuntimeField_8);
        UnityEngine.Events.UnityAction val_21 = new UnityEngine.Events.UnityAction(object:  351277056, method:  new IntPtr(3674178640));
        displayPrefab + 172.AddListener(call:  162246656);
        goto label_49;
        label_19:
        Dispose();
        if(this.myEcon.upgradeOnlyEcon == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_22 = this.gameObject;
        object val_23 = this.GetComponent<System.Object>();
        if((-620754416) == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_25 = this.gameObject;
        object val_26 = this.GetComponent<System.Object>();
        this.titleText.left = 15;
        this.childAlignment = 0;
        this.startCorner = 0;
    }
    public void RefreshDisplay()
    {
        TRVExpert val_5;
        var val_22;
        var val_24;
        System.Func<System.Collections.Generic.KeyValuePair<TRVExpert, TRVExpertDisplay>, System.Boolean> val_26;
        if((mem[1152921512576188324] + 16) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Dictionary.KeyCollection<TKey, TValue> val_2 = mem[1152921512576188320].Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        val_22 = 1152921512576158160;
        label_34:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.ContainsKey(key:  val_5 + 8)) == false)
        {
            goto label_34;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_8 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.Item[val_5 + 8];
        ExpertLevelReq val_9 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C.getReqFromExpert(exp:  val_5, prog:  public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18);
        string val_10 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.Item[val_5 + 8];
        string val_11 = mem[1152921512576188320].Item[val_5];
        UnityEngine.GameObject val_12 = mem[1152921512576188320].gameObject;
        mem[1152921512576188320].SetActive(value:  false);
        goto label_34;
        label_8:
        Dispose();
        val_24 = null;
        val_24 = null;
        val_26 = TRVExpertCategoryDisplay.<>c.<>9__7_0;
        if(val_26 == 0)
        {
                val_26 = null;
            val_26 = new System.Func<System.Collections.Generic.KeyValuePair<TRVExpert, TRVExpertDisplay>, System.Boolean>(object:  TRVExpertCategoryDisplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3674346960));
            TRVExpertCategoryDisplay.<>c.<>9__7_0 = val_26;
        }
        
        if((System.Linq.Enumerable.All<System.Collections.Generic.KeyValuePair<TRVExpert, TRVExpertDisplay>>(source:  mem[1152921512576188320], predicate:  7720960)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_20 = this.gameObject;
        this.SetActive(value:  false);
    }
    public TRVExpertCategoryDisplay()
    {
    
    }

}
