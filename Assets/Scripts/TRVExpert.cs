using UnityEngine;
[Serializable]
public class TRVExpert
{
    // Fields
    public string expertName;
    public TRVExpertRarites rarity;
    public UnityEngine.Sprite mySprite;
    public int totalPotential;
    public int totalDefault;
    public System.Collections.Generic.List<TRVCategoryProficiencies> myProfs;
    
    // Properties
    public string GetLocalizedName { get; }
    
    // Methods
    public string get_GetLocalizedName()
    {
        string val_1 = this.expertName.Replace(oldValue:  1297836560, newValue:  2144339952);
        string val_2 = this.expertName.ToLower();
        string val_3 = System.String.Format(format:  -614134304, arg0:  this.expertName);
        string val_4 = this.expertName.ToUpper();
        return Localization.Localize(key:  -614134304, defaultValue:  this.expertName, useSingularKey:  false);
    }
    public TRVExpert()
    {
    
    }
    public bool SetupExpert(string data)
    {
        TRVExpert val_17;
        System.Collections.Generic.IEnumerable<T> val_18;
        var val_19;
        float val_20;
        float val_21;
        var val_22;
        var val_24;
        var val_27;
        val_17 = this;
        val_18 = data;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 9;
        val_19 = 0;
        System.String[] val_1 = val_18.Split(separator:  478563824);
        System.Collections.Generic.List<ZooTile> val_2 = new System.Collections.Generic.List<ZooTile>(collection:  val_18);
        val_19 = 0;
        this.expertName = null;
        RemoveAt(index:  0);
        val_20 = 1152921504958443520;
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(351596544)});
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        if((System.Enum.IsDefined(enumType:  351596544, value:  List<T>.__il2cppRuntimeField_10)) != false)
        {
                System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(351596544)});
            val_18 = val_17;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            object val_6 = System.Enum.Parse(enumType:  351596544, value:  List<T>.__il2cppRuntimeField_10, ignoreCase:  true);
            val_17 = null;
            val_21 = 1152921511111017856;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921512582913916] = ;
        }
        else
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_17 = 0;
            string val_7 = System.Environment.NewLine;
            val_21 = 1152921511111017856;
            string val_8 = PrettyPrint.printJSON(obj:  val_18, types:  false, singleLineOutput:  false);
            string val_9 = List<T>.__il2cppRuntimeField_10(List<T>.__il2cppRuntimeField_10) + -613893824(-613893824) + null + val_18;
            UnityEngine.Debug.LogError(message:  List<T>.__il2cppRuntimeField_10);
            val_18 = val_17;
        }
        
        val_19 = 0;
        RemoveAt(index:  0);
        val_19 = 0;
        if((System.Int32.TryParse(s:  List<T>.__il2cppRuntimeField_10, result: out  int val_10 = -613867644)) == false)
        {
                return (bool)val_19;
        }
        
        val_19 = 0;
        RemoveAt(index:  0);
        val_19 = 0;
        if((System.Int32.TryParse(s:  List<T>.__il2cppRuntimeField_10, result: out  int val_12 = -613867640)) == false)
        {
                return (bool)val_19;
        }
        
        val_22 = 0;
        RemoveAt(index:  0);
        val_20 = null;
        val_20 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_21 = 1152921504964567040;
        val_24 = null;
        val_24 = null;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        if((TRVEcon.DefaultCategoryUnlockLevels.ContainsKey(key:  List<T>.__il2cppRuntimeField_10)) != false)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_16 = val_22 + 1;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_27 = val_22 + 2;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            TRVCategoryProficiencies val_18 = null;
            val_17 = val_18;
            val_18 = new TRVCategoryProficiencies(cat:  List<T>.__il2cppRuntimeField_10, maxPot:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + ((val_22 + 1)) << 2) + 16, incDefault:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + ((val_22 + 2)) << 2) + 16);
            val_20 = val_20;
            Add(item:  351862784);
        }
        
        val_18 = val_27 + 1;
        val_19 = 1;
        mem[1152921512582913932] = val_20;
        return (bool)val_19;
    }

}
