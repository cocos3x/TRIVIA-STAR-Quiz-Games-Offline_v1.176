using UnityEngine;
public class WGBuyAVowelEventVowelButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button;
    private UnityEngine.UI.Text costText;
    private UnityEngine.GameObject coinIcon;
    
    // Methods
    public void Setup(string letter, decimal cost, System.Action<string> callback)
    {
        int val_14;
        var val_15;
        var val_16;
        var val_17;
        val_14 = cost.lo;
        if(new System.Object() != 0)
        {
                typeof(WGBuyAVowelEventVowelButton.<>c__DisplayClass3_0).__il2cppRuntimeField_8 = callback;
            val_14 = val_14;
        }
        else
        {
                mem[8] = callback;
        }
        
        typeof(WGBuyAVowelEventVowelButton.<>c__DisplayClass3_0).__il2cppRuntimeField_C = letter;
        val_15 = null;
        val_15 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = cost.flags, hi = cost.hi, lo = val_14, mid = cost.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                GameEcon val_3 = App.getGameEcon;
            string val_4 = cost.flags.ToString(format:  mem[8]);
        }
        else
        {
                val_16 = "free_upper";
            string val_5 = Localization.Localize(key:  -1510799952, defaultValue:  -1510800032, useSingularKey:  false);
        }
        
        val_17 = null;
        val_17 = null;
        mem[1152921511686006756].SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = cost.flags, hi = cost.hi, lo = val_14, mid = cost.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  310702080, method:  new IntPtr(2784167440));
        mem[1152921511686006748] + 172.AddListener(call:  162246656);
        mem[1152921511686006748].interactable = System.Decimal.op_Inequality(d1:  new System.Decimal() {flags = cost.flags, hi = cost.hi, lo = val_14, mid = cost.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        UnityEngine.GameObject val_9 = mem[1152921511686006752].gameObject;
        UnityEngine.Transform val_10 = mem[1152921511686006752].transform;
        UnityEngine.Transform val_11 = mem[1152921511686006752].parent;
        UnityEngine.GameObject val_12 = mem[1152921511686006752].gameObject;
        mem[1152921511686006752].SetActive(value:  System.Decimal.op_Inequality(d1:  new System.Decimal() {flags = cost.flags, hi = cost.hi, lo = val_14, mid = cost.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
    }
    public WGBuyAVowelEventVowelButton()
    {
    
    }

}
