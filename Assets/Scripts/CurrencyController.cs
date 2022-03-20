using UnityEngine;
public class CurrencyController
{
    // Fields
    public const string CURRENCY = "ruby";
    public const int DEFAULT_CURRENCY = 10;
    private static System.Collections.Generic.Dictionary<CurrencyType, System.Action> onBalanceChanged;
    public static System.Action<System.Decimal> onBalanceIncreased;
    
    // Methods
    public static void AddCurrencyListener(System.Action onChangeAction, CurrencyType type)
    {
        var val_5;
        if(CurrencyController.onBalanceChanged == 0)
        {
                System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
            CurrencyController.onBalanceChanged = null;
        }
        
        if((0.ContainsKey(key:  type)) == false)
        {
            goto label_4;
        }
        
        object val_3 = Item[type];
        System.Delegate val_4 = System.Delegate.Combine(a:  78753792, b:  onChangeAction);
        val_5 = CurrencyController.onBalanceChanged;
        if(val_5 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_5 = 0;
        label_7:
        set_Item(key:  type, value:  0);
        return;
        label_4:
        Add(key:  type, value:  onChangeAction);
    }
    public static void RemoveCurrencyListener(System.Action onChangeAction, CurrencyType type)
    {
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_5;
        var val_6;
        val_5 = 35641142;
        if(CurrencyController.onBalanceChanged == 0)
        {
                val_5 = null;
            val_5 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
            CurrencyController.onBalanceChanged = val_5;
        }
        
        if((0.ContainsKey(key:  type)) == false)
        {
                return;
        }
        
        object val_3 = Item[type];
        System.Delegate val_4 = System.Delegate.Remove(source:  78753792, value:  onChangeAction);
        val_6 = CurrencyController.onBalanceChanged;
        if(val_6 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_6 = 0;
        label_7:
        set_Item(key:  type, value:  0);
    }
    public static decimal GetBalance()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return new System.Decimal() {flags = 60, hi = App.__il2cppRuntimeField_cctor_finished};
        }
        
        return new System.Decimal() {flags = 60, hi = App.__il2cppRuntimeField_cctor_finished};
    }
    public static void Debug_SetBalance(decimal value)
    {
        Player val_1 = App.Player;
        0.SetCredits(amount:  new System.Decimal() {flags = value.flags, hi = value.hi, lo = value.lo, mid = value.mid});
    }
    public static void CreditBalance(decimal value, string source = "UnknownSource", System.Collections.Generic.Dictionary<string, object> externalParams, bool animated = False)
    {
        string val_7 = 0;
        Player val_1 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = value.flags, hi = value.hi, lo = value.lo, mid = value.mid}, source:  source, subSource:  val_7 = 0, externalParams:  externalParams, doTrack:  true);
        if((CurrencyController.onBalanceChanged.ContainsKey(key:  0)) != false)
        {
                val_7 = 1152921511052152864;
            System.Action val_3 = CurrencyController.onBalanceChanged.Item[0];
            if(CurrencyController.onBalanceChanged != 0)
        {
                System.Action val_4 = CurrencyController.onBalanceChanged.Item[0];
            CurrencyController.onBalanceChanged.Invoke();
        }
        
        }
        
        if(CurrencyController.onBalanceIncreased != 0)
        {
                CurrencyController.onBalanceIncreased.Invoke(obj:  new System.Decimal() {flags = value.flags, hi = value.hi, lo = value.lo, mid = value.mid});
        }
        
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        System.Collections.Hashtable val_6 = CurrencyStatView.GetAnimHT(shouldAnimate:  animated);
        0.PostNotification(aSender:  0, aName:  -2144143840, aData:  animated);
    }
    public static bool DebitBalance(decimal value, string source = "UnknownSource", System.Collections.Generic.Dictionary<string, object> externalParams, bool animated = False)
    {
        int val_5;
        int val_11;
        int val_12;
        float val_13;
        var val_15;
        val_11 = value.flags;
        val_12 = value.mid;
        decimal val_1 = CurrencyController.GetBalance();
        val_13 = 1152921504617017344;
        val_15 = 0;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_11, hi = value.hi, lo = value.lo, mid = val_12})) == true)
        {
                return (bool)val_15;
        }
        
        Player val_3 = App.Player;
        val_13 = source;
        decimal val_4 = System.Decimal.op_UnaryNegation(d:  new System.Decimal() {flags = -2144003396, hi = val_11, lo = value.hi, mid = value.lo});
        val_12 = 0;
        val_11 = 1;
        0.AddCredits(amount:  new System.Decimal() {mid = val_5}, source:  val_13, subSource:  val_12, externalParams:  externalParams, doTrack:  true);
        if((CurrencyController.onBalanceChanged != 0) && ((CurrencyController.onBalanceChanged.ContainsKey(key:  0)) != false))
        {
                val_11 = 1152921511052152864;
            System.Action val_7 = CurrencyController.onBalanceChanged.Item[0];
            if(CurrencyController.onBalanceChanged != 0)
        {
                System.Action val_8 = CurrencyController.onBalanceChanged.Item[0];
            CurrencyController.onBalanceChanged.Invoke();
        }
        
        }
        
        NotificationCenter val_9 = NotificationCenter.DefaultCenter;
        System.Collections.Hashtable val_10 = CurrencyStatView.GetAnimHT(shouldAnimate:  animated);
        0.PostNotification(aSender:  0, aName:  -2144143840, aData:  animated);
        val_15 = 1;
        return (bool)val_15;
    }
    public static void HandleBalanceChanged(CurrencyType type)
    {
        if((CurrencyController.onBalanceChanged != 0) && ((CurrencyController.onBalanceChanged.ContainsKey(key:  type)) != false))
        {
                System.Action val_2 = CurrencyController.onBalanceChanged.Item[type];
            if(CurrencyController.onBalanceChanged != 0)
        {
                System.Action val_3 = CurrencyController.onBalanceChanged.Item[type];
            CurrencyController.onBalanceChanged.Invoke();
        }
        
        }
        
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        System.Collections.Hashtable val_5 = CurrencyStatView.GetAnimHT(shouldAnimate:  false);
        0.PostNotification(aSender:  0, aName:  -2144143840, aData:  0);
    }
    public CurrencyController()
    {
    
    }

}
