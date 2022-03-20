using UnityEngine;
public class TRVUtils : MonoSingleton<TRVUtils>
{
    // Fields
    private TRVIconConfig config;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> categoryIconData;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> eventIconData;
    private bool hasInit;
    
    // Methods
    private void OnEnable()
    {
        this.Init(forceUpdate:  false);
    }
    public void Init(bool forceUpdate = False)
    {
        string val_6;
        var val_19;
        TRVUtils val_23;
        float val_24;
        var val_25;
        var val_31;
        var val_32;
        val_23 = this;
        if(this.hasInit != false)
        {
                if(forceUpdate == false)
        {
                return;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_2 = getAllSubCategories;
        Dictionary.KeyCollection<TKey, TValue> val_3 = Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        val_24 = 1152921512754465136;
        goto label_8;
        label_25:
        object val_5 = new System.Object();
        typeof(TRVUtils.<>c__DisplayClass5_0).__il2cppRuntimeField_8 = val_6;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_8 = getAllSubCategories;
        string val_9 = Item[typeof(TRVUtils.<>c__DisplayClass5_0).__il2cppRuntimeField_8];
        val_25 = 0;
        label_8:
        if(MoveNext() == true)
        {
            goto label_25;
        }
        
        Dispose();
        List.Enumerator<T> val_17 = GetEnumerator();
        val_31 = 1152921512754491760;
        label_32:
        if(MoveNext() == false)
        {
            goto label_28;
        }
        
        if((mem[1152921512754521920].ContainsKey(key:  val_19 + 8)) == true)
        {
            goto label_32;
        }
        
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  mem[1152921512754521920], key:  val_19 + 8, newValue:  val_19 + 16);
        goto label_32;
        label_28:
        Dispose();
        List.Enumerator<T> val_21 = GetEnumerator();
        label_38:
        if(MoveNext() == false)
        {
            goto label_35;
        }
        
        if(val_19 != 0)
        {
                val_32 = mem[val_19 + 8];
            val_32 = val_19 + 8;
        }
        else
        {
                val_32 = 0;
        }
        
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  mem[1152921512754521924], key:  null, newValue:  val_19 + 16);
        goto label_38;
        label_35:
        Dispose();
        this.hasInit = true;
    }
    public UnityEngine.Sprite GetCategoryIcon(string category)
    {
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Sprite> val_6;
        if(this.hasInit != true)
        {
                this.Init(forceUpdate:  false);
        }
        
        val_6 = this.categoryIconData;
        if((val_6.ContainsKey(key:  category)) != false)
        {
                UnityEngine.Sprite val_2 = this.categoryIconData.Item[category];
            return;
        }
        
        val_6 = 1152921512589735248;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPromoCategory(subCategoryName:  category)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVSpecialCategoriesManager MonoSingleton<TRVSpecialCategoriesManager>::get_Instance()) != 0)
        {
                return GetPromoSprite(subCategoryName:  category);
        }
        
        return GetPromoSprite(subCategoryName:  category);
    }
    public UnityEngine.Sprite GetEventIcon(WGEventHandler eventHandler)
    {
        var val_3;
        if(this.hasInit != true)
        {
                this.Init(forceUpdate:  false);
        }
        
        val_3 = 0;
        if(eventHandler == 0)
        {
                return;
        }
        
        if((this.eventIconData.ContainsKey(key:  eventHandler)) == false)
        {
                return;
        }
        
        UnityEngine.Sprite val_2 = this.eventIconData.Item[eventHandler];
        val_3 = this.eventIconData;
    }
    public string GetEnglishIconNameForCategory(string cat)
    {
        typeof(TRVUtils.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = cat;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_2 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  363683840, method:  new IntPtr(3853105648));
        object val_3 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.config.icons, predicate:  7720960);
        if(this.config.icons != 0)
        {
                new System.Object() = this.config.icons;
        }
    
    }
    public TRVUtils()
    {
        this.categoryIconData = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.eventIconData = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
    }

}
