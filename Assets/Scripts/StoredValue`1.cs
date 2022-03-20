using UnityEngine;
public class StoredValue<T>
{
    // Fields
    public System.Action onValueChanged;
    public string key;
    public T defaultValue;
    
    // Methods
    public StoredValue<T>(string key, T defaultValue)
    {
        val_1 = new System.Object();
        mem[1152921511078225340] = key;
        mem[1152921511078225344] = val_1;
    }
    public void ChangeValue(T delta)
    {
        System.Type val_20;
        System.Type val_21;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96});
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
        if((System.Type.op_Equality(left:  __RuntimeMethodHiddenParam + 12 + 96, right:  13152256)) != false)
        {
                int val_4 = System.Convert.ToInt32(value:  __RuntimeMethodHiddenParam + 12 + 96);
            val_20 = CPlayerPrefs.GetInt(key:  __RuntimeMethodHiddenParam, defaultValue:  val_4);
            CPlayerPrefs.SetInt(key:  val_4, val:  (System.Convert.ToInt32(value:  delta)) + val_20);
        }
        else
        {
                System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96});
            val_21 = __RuntimeMethodHiddenParam + 12 + 96;
            System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15282176)});
            if((System.Type.op_Equality(left:  val_21, right:  15282176)) != false)
        {
                val_21 = val_21;
            float val_12 = CPlayerPrefs.GetFloat(key:  __RuntimeMethodHiddenParam, defaultValue:  System.Convert.ToSingle(value:  val_21));
            float val_13 = System.Convert.ToSingle(value:  delta);
            object val_20 = delta;
            val_20 = __RuntimeMethodHiddenParam + val_20;
            CPlayerPrefs.SetFloat(key:  __RuntimeMethodHiddenParam, val:  val_20);
        }
        else
        {
                System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96});
            val_20 = __RuntimeMethodHiddenParam + 12 + 96;
            System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(10489856)});
            if((System.Type.op_Equality(left:  val_20, right:  10489856)) != false)
        {
                val_21 = val_20;
            double val_18 = CPlayerPrefs.GetDouble(key:  R8, defaultValue:  System.Convert.ToDouble(value:  val_20));
            object val_21 = delta;
            val_21 = R8 + val_21;
            CPlayerPrefs.SetDouble(key:  null, value:  System.Convert.ToDouble(value:  delta));
        }
        
        }
        
        }
        
        if(0 == 0)
        {
                return;
        }
        
        0.Invoke();
    }
    public void SetValue(T value)
    {
        System.Type val_13;
        System.Type val_14;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96});
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
        if((System.Type.op_Equality(left:  __RuntimeMethodHiddenParam + 12 + 96, right:  13152256)) != false)
        {
                CPlayerPrefs.SetInt(key:  -2118311760, val:  System.Convert.ToInt32(value:  value));
            return;
        }
        
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96});
        val_13 = __RuntimeMethodHiddenParam + 12 + 96;
        System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15282176)});
        if((System.Type.op_Equality(left:  val_13, right:  15282176)) != false)
        {
                CPlayerPrefs.SetFloat(key:  -2118311760, val:  System.Convert.ToSingle(value:  value));
            return;
        }
        
        System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96});
        val_14 = __RuntimeMethodHiddenParam + 12 + 96;
        System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(10489856)});
        if((System.Type.op_Equality(left:  val_14, right:  10489856)) == false)
        {
                return;
        }
        
        val_13 = 0;
        val_14 = 0;
        CPlayerPrefs.SetDouble(key:  -2118311760, value:  System.Convert.ToDouble(value:  value));
    }
    public T GetValue()
    {
        string val_16;
        var val_17;
        var val_18;
        var val_20;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96});
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
        if((System.Type.op_Equality(left:  __RuntimeMethodHiddenParam + 12 + 96, right:  13152256)) != false)
        {
                int val_5 = CPlayerPrefs.GetInt(key:  __RuntimeMethodHiddenParam + 12 + 96, defaultValue:  System.Convert.ToInt32(value:  -2118195664));
            val_17 = 1152921504619999232;
        }
        else
        {
                System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96});
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15282176)});
            if((System.Type.op_Equality(left:  __RuntimeMethodHiddenParam + 12 + 96, right:  15282176)) != false)
        {
                val_16 = __RuntimeMethodHiddenParam + 12 + 96;
            float val_11 = CPlayerPrefs.GetFloat(key:  val_16, defaultValue:  System.Convert.ToSingle(value:  -2118195664));
            val_17 = 1152921504622129152;
        }
        else
        {
                val_16 = __RuntimeMethodHiddenParam + 12 + 96;
            double val_13 = CPlayerPrefs.GetDouble(key:  val_16, defaultValue:  System.Convert.ToDouble(value:  -2118195664));
            val_18 = null;
        }
        
        }
        
        val_20 = 0;
        System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96});
        object val_15 = System.Convert.ChangeType(value:  10489856, conversionType:  __RuntimeMethodHiddenParam + 12 + 96);
        if(val_18 == 0)
        {
                return;
        }
        
        val_20 = val_18;
        if(val_18 != 0)
        {
                return;
        }
        
        val_20 = 0;
    }

}
