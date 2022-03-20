using UnityEngine;
private sealed class TRVUtils.<>c__DisplayClass5_1
{
    // Fields
    public string cat;
    public System.Func<string, bool> <>9__2;
    
    // Methods
    public TRVUtils.<>c__DisplayClass5_1()
    {
    
    }
    internal bool <Init>b__0(TRVIconConfig.TRVIcon x)
    {
        string val_6;
        var val_7;
        string val_1 = x.name.ToLower();
        val_6 = x.name;
        string val_2 = this.cat.ToLower();
        val_7 = 1;
        if((System.String.op_Equality(a:  val_6, b:  this.cat)) == true)
        {
                return true;
        }
        
        val_6 = this.<>9__2;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  -441217232, method:  new IntPtr(3853725040));
            this.<>9__2 = val_6;
        }
        
        if((System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  x.translations, predicate:  7720960)) > 0)
        {
                val_7 = 1;
        }
        
        return true;
    }
    internal bool <Init>b__2(string z)
    {
        string val_1 = z.ToLower();
        string val_2 = this.cat.ToLower();
        return System.String.op_Equality(a:  z, b:  this.cat);
    }

}
