using UnityEngine;
public class PrefabsFromFolder : MonoBehaviour
{
    // Fields
    private bool disableByDefault;
    public bool themed;
    private bool instantiateAllOnAwake;
    private bool instantiateAsChild;
    public Themes themeType;
    private PrefabsFromFolder.SetParentMethod parentingMethod;
    public string folder;
    public string[] allowedSubFolders;
    private bool initalized;
    public PrefabsFromFolder.FilterMode tagFilterMode;
    public System.Collections.Generic.List<string> tagFilter;
    private string gc_type_to_string;
    
    // Methods
    private void Awake()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -2016788480, name:  -2016812608);
    }
    private void Start()
    {
        this.CheckThemeType();
        if(this.initalized != true)
        {
                if(this.instantiateAllOnAwake == true)
        {
                this.instantiateAllOnAwake = this;
            this.LoadAll();
        }
        
        }
        
        this.initalized = true;
    }
    private void Notification_OnThemeChanged()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        this.themeType = static_value_0028000F;
        if(static_value_0028000F == 0)
        {
                static_value_0028000F = false;
            this.themed = static_value_0028000F;
        }
    
    }
    private void CheckThemeType()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(0 != 0)
        {
                AppConfigs val_3 = App.Configuration;
            if(0 != 0)
        {
                ThemesHandler val_4 = App.ThemesHandler;
            this.themeType = static_value_0028000F;
            if(static_value_0028000F != 0)
        {
                static_value_0028000F = true;
        }
        
            if(static_value_0028000F == 0)
        {
                static_value_0028000F = false;
        }
        
            this.themed = static_value_0028000F;
            return;
        }
        
        }
        
        this.themed = false;
    }
    public void Init()
    {
        if(this.initalized == true)
        {
                return;
        }
        
        R4.LoadAll();
        mem2[0] = 1;
    }
    public bool IsComplete()
    {
        return (bool)this.initalized;
    }
    public void LoadAll()
    {
        Themes val_13;
        var val_14;
        string val_15;
        var val_16;
        this.CheckThemeType();
        string val_13 = this.folder;
        if(this.themed != false)
        {
                val_13 = this.themeType;
            val_14 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            val_15 = val_13;
            string val_1 = val_15 + 1115175264 + 346484736 + 1115175264;
        }
        else
        {
                val_15 = val_13;
            string val_2 = val_15 + 1115175264;
        }
        
        T[] val_3 = WGResources.LoadAll<UnityEngine.GameObject>(path:  val_15, extension:  -2017393776);
        val_13 = val_15 + 16;
        val_16 = 0;
        goto label_7;
        label_26:
        if((this.ShouldLoadAsset(go:  15388672)) == false)
        {
            goto label_21;
        }
        
        string val_5 = 1152921504622235648.name;
        if(this.instantiateAsChild == false)
        {
            goto label_12;
        }
        
        UnityEngine.Transform val_6 = this.transform;
        string val_7 = 1152921504622235648.name;
        val_14 = 1152921504622235648;
        UnityEngine.Transform val_8 = this.Find(n:  15388672);
        val_13 = this;
        if((UnityEngine.Object.op_Implicit(exists:  -2016111360)) == true)
        {
            goto label_21;
        }
        
        UnityEngine.GameObject val_10 = this.gameObject;
        UnityEngine.GameObject val_11 = this.InstantiateToParent(parent:  -2016111360, prefab:  15388672);
        val_13 = this;
        this.OnLoadedAsset(go:  -2016111360, prefab:  15388672, setLayer:  true);
        goto label_21;
        label_12:
        object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  15388672);
        label_21:
        val_16 = 1;
        label_7:
        if(val_16 < this.folder.m_firstChar)
        {
            goto label_26;
        }
    
    }
    public T LoadStrictlyTypeNamedPrefab<T>(bool allowMultiple = False)
    {
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_48;
        var val_49;
        var val_50;
        string val_51;
        var val_53;
        UnityEngine.GameObject val_54;
        var val_55;
        string val_56;
        var val_57;
        val_44 = this;
        val_45 = __RuntimeMethodHiddenParam;
        this.CheckThemeType();
        if(allowMultiple == false)
        {
            goto label_2;
        }
        
        val_45 = val_45 + 24;
        goto label_21;
        label_2:
        UnityEngine.Transform val_1 = this.transform;
        System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Cast<System.Object>(source:  -2015991488);
        val_46 = val_44;
        val_47 = mem[__RuntimeMethodHiddenParam + 24 + 186];
        val_47 = __RuntimeMethodHiddenParam + 24 + 186;
        if(val_47 == 1)
        {
                val_47 = mem[__RuntimeMethodHiddenParam + 24 + 186];
            val_47 = __RuntimeMethodHiddenParam + 24 + 186;
        }
        
        val_48 = mem[__RuntimeMethodHiddenParam + 24 + 92 + 4];
        val_48 = __RuntimeMethodHiddenParam + 24 + 92 + 4;
        if(val_48 == 0)
        {
                val_49 = mem[__RuntimeMethodHiddenParam + 24 + 186];
            val_49 = __RuntimeMethodHiddenParam + 24 + 186;
            if(val_49 == 1)
        {
                val_49 = mem[__RuntimeMethodHiddenParam + 24 + 186];
            val_49 = __RuntimeMethodHiddenParam + 24 + 186;
        }
        
            val_48 = null;
            val_48 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  __RuntimeMethodHiddenParam + 24 + 92, method:  __RuntimeMethodHiddenParam + 24 + 4);
            mem2[0] = val_48;
        }
        
        object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -2015991488, predicate:  7720960);
        if((-2015991488) == 0)
        {
            goto label_21;
        }
        
        if(val_46 != 0)
        {
            goto __RuntimeMethodHiddenParam + 24 + 8;
        }
        
        goto __RuntimeMethodHiddenParam + 24 + 8;
        label_21:
        System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = SL + 12});
        mem2[0] = SL + 12;
        if((SL + 12.Contains(value:  1297836480)) != false)
        {
                if((R5 + 44) != 0)
        {
                val_50 = R5 + 44.LastIndexOf(value:  1297836480);
        }
        else
        {
                val_50 = 0.LastIndexOf(value:  1297836480);
        }
        
            string val_11 = R5 + 44.Remove(startIndex:  0, count:  val_50 + 1);
            mem2[0] = R5 + 44;
        }
        
        if((R5 + 24) != 0)
        {
                "" = R5 + 24;
        }
        
        if((R5 + 13) != 0)
        {
                string val_12 = null.ToString();
            val_51 = "";
            string val_13 = val_51 + 1115175264 + -2016003480(-2016003480) + 1115175264;
        }
        else
        {
                val_51 = "";
            string val_14 = val_51 + 1115175264;
        }
        
        string val_15 = val_51 + R5 + 44(R5 + 44);
        UnityEngine.Texture val_16 = WGResources.Load<UnityEngine.Texture>(fileName:  val_51, extension:  -2017393776, errorLog:  true);
        bool val_17 = UnityEngine.Object.op_Equality(x:  val_51, y:  0);
        if(val_17 == false)
        {
            goto label_49;
        }
        
        string val_19 = -2016016192(-2016016192) + val_51 + R5 + 44(R5 + 44);
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.LogError(message:  -2016016192);
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  -2016016192);
        }
        
        if((R5 + 13) != 0)
        {
                R5 + 13 = mem[R5 + 16];
            R5 + 13 = R5 + 16;
        }
        
        if((R5 + 13) != 1)
        {
            goto label_43;
        }
        
        label_76:
        if(val_51 == 0)
        {
                "PrefabFromSlots.LoadStrictlyTypeNamedPrefab() No prefab found for type " = mem[R5 + 28];
            "PrefabFromSlots.LoadStrictlyTypeNamedPrefab() No prefab found for type " = R5 + 28;
        }
        
        if("PrefabFromSlots.LoadStrictlyTypeNamedPrefab() No prefab found for type " != 0)
        {
            goto label_46;
        }
        
        label_71:
        if(val_51 != 0)
        {
            goto label_49;
        }
        
        val_53 = 0;
        string val_23 = -2016016192(-2016016192) + val_51 + R5 + 44(R5 + 44);
        UnityEngine.Debug.LogError(message:  -2016016192);
        goto label_52;
        label_49:
        val_51.SetActive(value:  val_17 >> 5);
        UnityEngine.GameObject val_25 = R5.gameObject;
        UnityEngine.GameObject val_26 = R5.InstantiateToParent(parent:  R5, prefab:  val_51);
        val_54 = R5;
        R5.OnLoadedAsset(go:  val_54, prefab:  val_51, setLayer:  true);
        val_53 = val_54;
        label_52:
        var val_27 = FP - 28;
        return;
        label_43:
        string val_28 = null.ToString();
        string val_29 = R5 + 24(R5 + 24) + 1115175264 + -2016003480(-2016003480) + 1115175264;
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_55;
        }
        
        string val_31 = -2016015968(-2016015968) + R5 + 24(R5 + 24) + R5 + 44(R5 + 44);
        UnityEngine.Debug.LogError(message:  -2016015968);
        goto label_58;
        label_46:
        val_55 = 0;
        goto label_59;
        label_70:
        var val_32 = (R5 + 28) + 0;
        if(((R5 + 28 + 0) + 16) != 0)
        {
                "" = (R5 + 28 + 0) + 16;
        }
        
        if((R5 + 13) != 0)
        {
                string val_33 = null.ToString();
            val_56 = "";
            string val_34 = val_56 + 1115175264 + -2016003480(-2016003480) + 1115175264;
        }
        else
        {
                val_56 = "";
            string val_35 = val_56 + 1115175264;
        }
        
        string val_36 = val_56 + R5 + 44(R5 + 44);
        UnityEngine.Texture val_37 = WGResources.Load<UnityEngine.Texture>(fileName:  val_56, extension:  -2017393776, errorLog:  true);
        if(val_56 != 0)
        {
            goto label_71;
        }
        
        val_57 = mem[R5 + 28];
        val_57 = R5 + 28;
        val_55 = 1;
        label_59:
        if(val_55 < (R5 + 28 + 12))
        {
            goto label_70;
        }
        
        goto label_71;
        label_55:
        string val_39 = -2016015728(-2016015728) + R5 + 24(R5 + 24) + R5 + 44(R5 + 44);
        UnityEngine.Debug.LogWarning(message:  -2016015728);
        label_58:
        string val_40 = R5 + 24(R5 + 24) + R5 + 44(R5 + 44);
        UnityEngine.Texture val_41 = WGResources.Load<UnityEngine.Texture>(fileName:  R5 + 24, extension:  -2017393776, errorLog:  true);
        goto label_76;
    }
    public UnityEngine.Component FindStricklyTypeNamedPrefab(string prefabName)
    {
        System.Type val_5;
        UnityEngine.GameObject val_1 = this.gameObject;
        var val_5 = 20213474;
        val_5 = 9660236 + val_5;
        System.Type val_2 = System.Type.GetType(typeName:  prefabName);
        val_5 = prefabName;
        if(prefabName == null)
        {
                System.Type val_3 = System.Type.GetType(typeName:  prefabName);
            val_5 = prefabName;
        }
        
        UnityEngine.Component[] val_4 = this.GetComponentsInChildren(type:  val_5, includeInactive:  true);
        if(this != 0)
        {
                val_5 = this.disableByDefault;
        }
        
        if(val_5 == true)
        {
                0 = this.themeType;
        }
    
    }
    public UnityEngine.Component LoadStrictlyTypeNamedPrefab(string prefabName)
    {
        var val_10;
        var val_11;
        var val_12;
        UnityEngine.Component val_1 = this.FindStricklyTypeNamedPrefab(prefabName:  prefabName);
        val_10 = this;
        val_11 = 1152921504765685760;
        if((-2015742448) != 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.folder)) == true)
        {
                "/" = "";
        }
        
        string val_4 = this.folder + 1098586544 + prefabName;
        UnityEngine.Texture val_5 = WGResources.Load<UnityEngine.Texture>(fileName:  this.folder, extension:  -2017393776, errorLog:  true);
        val_11 = 0;
        if(this.folder == 0)
        {
                string val_7 = -2015766608(-2015766608) + prefabName + -2015766912(-2015766912) + prefabName;
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_12 == 1)
        {
                val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            val_10 = 0;
            D.LogClientError(developer:  -2015766608, filter:  1788750208, context:  0, strings:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return;
        }
        
        UnityEngine.GameObject val_8 = this.gameObject;
        UnityEngine.GameObject val_9 = this.InstantiateToParent(parent:  -2015742448, prefab:  this.folder);
        this.OnLoadedAsset(go:  -2015742448, prefab:  this.folder, setLayer:  true);
        if(this != 0)
        {
                return this.GetComponent(type:  prefabName);
        }
        
        return this.GetComponent(type:  prefabName);
    }
    public T LoadLooselyNamedPrefab<T>(string prefabName)
    {
        var val_9;
        if((System.String.IsNullOrEmpty(value:  this.folder)) == true)
        {
                "/" = "";
        }
        
        string val_2 = this.folder + 1098586544 + prefabName;
        if(this.folder == 0)
        {
                string val_4 = -2015638064(-2015638064) + prefabName + -2015766912(-2015766912) + prefabName;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_9 == 1)
        {
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            D.LogClientError(developer:  -2015638064, filter:  1788750208, context:  0, strings:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return;
        }
        
        UnityEngine.GameObject val_5 = this.gameObject;
        UnityEngine.GameObject val_6 = this.folder.gameObject;
        UnityEngine.GameObject val_7 = this.InstantiateToParent(parent:  -2015613904, prefab:  this.folder);
        UnityEngine.GameObject val_8 = this.folder.gameObject;
        this.OnLoadedAsset(go:  -2015613904, prefab:  this.folder, setLayer:  false);
        if(this == 0)
        {
            
        }
    
    }
    public void OnLoadedAsset(UnityEngine.GameObject go, UnityEngine.GameObject prefab, bool setLayer = True)
    {
        float val_6;
        int val_17;
        var val_18;
        var val_19;
        UnityEngine.Transform val_1 = go.transform;
        val_17 = go;
        UnityEngine.Transform val_2 = prefab.transform;
        UnityEngine.Vector3 val_3 = localPosition;
        val_17.localPosition = new UnityEngine.Vector3();
        UnityEngine.Transform val_4 = prefab.transform;
        UnityEngine.Quaternion val_5 = localRotation;
        val_17.localRotation = new UnityEngine.Quaternion() {w = val_6};
        UnityEngine.Transform val_7 = prefab.transform;
        val_18 = prefab;
        UnityEngine.Vector3 val_8 = localScale;
        val_17.localScale = new UnityEngine.Vector3();
        if(setLayer != false)
        {
                UnityEngine.Transform val_9 = this.transform;
            UnityEngine.Transform val_10 = this.parent;
            val_18 = UnityEngine.Object.op_Inequality(x:  -2015485520, y:  0);
            UnityEngine.Transform val_12 = this.transform;
            val_19 = this;
            if(val_18 != false)
        {
                UnityEngine.Transform val_13 = this.parent;
            val_19 = val_19;
        }
        
            UnityEngine.GameObject val_14 = this.gameObject;
            val_17 = prefab.layer;
            go.layer = val_17;
        }
        
        string val_16 = prefab.name;
        go.name = prefab;
    }
    public void OnSceneSave()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(this.childCount < 1)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        string val_4 = this.name;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this;
        typeof(System.Object[]).__il2cppRuntimeField_14 = " appears to have ";
        UnityEngine.Transform val_5 = this.transform;
        int val_6 = this.childCount;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = " unfinished prefab edits. Please apply any changes and finish editing. (Note this is okay if you want to save and come back to finish editing later.)";
        string val_7 = +472754880;
        UnityEngine.GameObject val_8 = this.gameObject;
        UnityEngine.Debug.LogError(message:  472754880, context:  -2015364848);
    }
    public bool ShouldLoadAsset(UnityEngine.GameObject go)
    {
        var val_6 = 0;
        if(go == 0)
        {
                return (bool)val_6;
        }
        
        if(this.tagFilterMode != 20)
        {
                val_6 = 1;
            if(this.tagFilterMode != 10)
        {
                return (bool)val_6;
        }
        
            string val_2 = go.tag;
            if(this.tagFilter != 0)
        {
                return this.tagFilter.Contains(item:  go);
        }
        
            return this.tagFilter.Contains(item:  go);
        }
        
        string val_3 = go.tag;
        val_6 = (this.tagFilter.Contains(item:  go)) ^ 1;
        return (bool)val_6;
    }
    public UnityEngine.GameObject InstantiateToParent(UnityEngine.GameObject parent, UnityEngine.GameObject prefab)
    {
        float val_8;
        var val_13;
        object val_14;
        var val_15;
        val_13 = this;
        val_14 = prefab;
        val_15 = 0;
        if(this.parentingMethod != 1)
        {
                if(this.parentingMethod != 0)
        {
                return;
        }
        
            val_13 = 1152921504765685760;
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  val_14);
            val_15 = val_14;
            if(val_14 == 0)
        {
                return;
        }
        
            if(parent == 0)
        {
                return;
        }
        
            UnityEngine.Transform val_4 = val_15.transform;
            val_14 = val_15;
            UnityEngine.Transform val_5 = parent.transform;
            val_14.SetParent(parent:  parent, worldPositionStays:  false);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_14.localPosition = new UnityEngine.Vector3();
            val_13 = 0;
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
            val_14.localRotation = new UnityEngine.Quaternion() {w = val_8};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            val_14.localScale = new UnityEngine.Vector3();
            val_15.layer = parent.layer;
            return;
        }
        
        UnityEngine.GameObject val_11 = this.gameObject;
        UnityEngine.GameObject val_12 = NGUITools.AddChild(parent:  -2015095792, prefab:  val_14);
    }
    public PrefabsFromFolder()
    {
        this.disableByDefault = true;
        this.instantiateAllOnAwake = true;
        this.instantiateAsChild = true;
    }

}
