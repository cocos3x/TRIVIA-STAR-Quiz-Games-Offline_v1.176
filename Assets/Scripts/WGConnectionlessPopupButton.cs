using UnityEngine;
public class WGConnectionlessPopupButton : MyButton
{
    // Fields
    private System.Collections.Generic.Dictionary<WGConnectionlessType, System.Action> ConnectionlessPopupActions;
    public WGConnectionlessType ConnectionlessType;
    
    // Methods
    public override void OnButtonClick()
    {
        System.Action val_1 = this.ConnectionlessPopupActions.Item[this.ConnectionlessType];
        this.ConnectionlessPopupActions.Invoke();
        this.OnButtonClick();
    }
    public static bool EmptyDub()
    {
        return true;
    }
    public WGConnectionlessPopupButton()
    {
        WGConnectionlessPopupButton.<>c val_22;
        var val_23;
        System.Action val_25;
        var val_26;
        System.Action val_28;
        var val_29;
        System.Action val_31;
        var val_32;
        System.Action val_34;
        var val_35;
        System.Action val_37;
        var val_38;
        System.Action val_40;
        var val_41;
        System.Action val_43;
        var val_44;
        System.Action val_46;
        var val_47;
        System.Action val_49;
        var val_50;
        System.Action val_52;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        if((WGConnectionlessPopupButton.<>c.<>9__4_0) == 0)
        {
                val_22 = WGConnectionlessPopupButton.<>c.<>9;
            System.Action val_2 = new System.Action(object:  val_22, method:  new IntPtr(4177790448));
            WGConnectionlessPopupButton.<>c.<>9__4_0 = null;
        }
        
        Add(key:  0, value:  7454720);
        if((WGConnectionlessPopupButton.<>c.<>9__4_1) == 0)
        {
                val_22 = WGConnectionlessPopupButton.<>c.<>9;
            System.Action val_3 = new System.Action(object:  val_22, method:  new IntPtr(4177792496));
            WGConnectionlessPopupButton.<>c.<>9__4_1 = null;
        }
        
        Add(key:  8, value:  7454720);
        if((WGConnectionlessPopupButton.<>c.<>9__4_2) == 0)
        {
                val_22 = WGConnectionlessPopupButton.<>c.<>9;
            System.Action val_4 = new System.Action(object:  val_22, method:  new IntPtr(4177793520));
            WGConnectionlessPopupButton.<>c.<>9__4_2 = null;
        }
        
        Add(key:  1, value:  7454720);
        if((WGConnectionlessPopupButton.<>c.<>9__4_3) == 0)
        {
                val_22 = WGConnectionlessPopupButton.<>c.<>9;
            System.Action val_5 = new System.Action(object:  val_22, method:  new IntPtr(4177794544));
            WGConnectionlessPopupButton.<>c.<>9__4_3 = null;
        }
        
        Add(key:  19, value:  7454720);
        if((WGConnectionlessPopupButton.<>c.<>9__4_4) == 0)
        {
                val_22 = WGConnectionlessPopupButton.<>c.<>9;
            System.Action val_6 = new System.Action(object:  val_22, method:  new IntPtr(4177795568));
            WGConnectionlessPopupButton.<>c.<>9__4_4 = null;
        }
        
        Add(key:  17, value:  7454720);
        if((WGConnectionlessPopupButton.<>c.<>9__4_5) == 0)
        {
                val_22 = WGConnectionlessPopupButton.<>c.<>9;
            System.Action val_7 = new System.Action(object:  val_22, method:  new IntPtr(4177796592));
            WGConnectionlessPopupButton.<>c.<>9__4_5 = null;
        }
        
        Add(key:  2, value:  7454720);
        if((WGConnectionlessPopupButton.<>c.<>9__4_6) == 0)
        {
                val_22 = WGConnectionlessPopupButton.<>c.<>9;
            System.Action val_8 = new System.Action(object:  val_22, method:  new IntPtr(4177797616));
            WGConnectionlessPopupButton.<>c.<>9__4_6 = null;
        }
        
        Add(key:  15, value:  7454720);
        if((WGConnectionlessPopupButton.<>c.<>9__4_7) == 0)
        {
                val_22 = WGConnectionlessPopupButton.<>c.<>9;
            System.Action val_9 = new System.Action(object:  val_22, method:  new IntPtr(4177798640));
            WGConnectionlessPopupButton.<>c.<>9__4_7 = null;
        }
        
        Add(key:  3, value:  7454720);
        if((WGConnectionlessPopupButton.<>c.<>9__4_8) == 0)
        {
                val_22 = WGConnectionlessPopupButton.<>c.<>9;
            System.Action val_10 = new System.Action(object:  val_22, method:  new IntPtr(4177799664));
            WGConnectionlessPopupButton.<>c.<>9__4_8 = null;
        }
        
        Add(key:  4, value:  7454720);
        if((WGConnectionlessPopupButton.<>c.<>9__4_9) == 0)
        {
                val_22 = WGConnectionlessPopupButton.<>c.<>9;
            System.Action val_11 = new System.Action(object:  val_22, method:  new IntPtr(4177800688));
            WGConnectionlessPopupButton.<>c.<>9__4_9 = null;
        }
        
        Add(key:  5, value:  7454720);
        val_23 = null;
        val_23 = null;
        val_25 = WGConnectionlessPopupButton.<>c.<>9__4_10;
        if(val_25 == 0)
        {
                val_25 = null;
            val_25 = new System.Action(object:  WGConnectionlessPopupButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4177801712));
            WGConnectionlessPopupButton.<>c.<>9__4_10 = val_25;
        }
        
        Add(key:  6, value:  7454720);
        val_26 = null;
        val_26 = null;
        val_28 = WGConnectionlessPopupButton.<>c.<>9__4_11;
        if(val_28 == 0)
        {
                val_28 = null;
            val_28 = new System.Action(object:  WGConnectionlessPopupButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4177802736));
            WGConnectionlessPopupButton.<>c.<>9__4_11 = val_28;
        }
        
        Add(key:  7, value:  7454720);
        val_29 = null;
        val_29 = null;
        val_31 = WGConnectionlessPopupButton.<>c.<>9__4_12;
        if(val_31 == 0)
        {
                val_31 = null;
            val_31 = new System.Action(object:  WGConnectionlessPopupButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4177803760));
            WGConnectionlessPopupButton.<>c.<>9__4_12 = val_31;
        }
        
        Add(key:  9, value:  7454720);
        val_32 = null;
        val_32 = null;
        val_34 = WGConnectionlessPopupButton.<>c.<>9__4_13;
        if(val_34 == 0)
        {
                val_34 = null;
            val_34 = new System.Action(object:  WGConnectionlessPopupButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4177804784));
            WGConnectionlessPopupButton.<>c.<>9__4_13 = val_34;
        }
        
        Add(key:  11, value:  7454720);
        val_35 = null;
        val_35 = null;
        val_37 = WGConnectionlessPopupButton.<>c.<>9__4_14;
        if(val_37 == 0)
        {
                val_37 = null;
            val_37 = new System.Action(object:  WGConnectionlessPopupButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4177805808));
            WGConnectionlessPopupButton.<>c.<>9__4_14 = val_37;
        }
        
        Add(key:  12, value:  7454720);
        val_38 = null;
        val_38 = null;
        val_40 = WGConnectionlessPopupButton.<>c.<>9__4_15;
        if(val_40 == 0)
        {
                val_40 = null;
            val_40 = new System.Action(object:  WGConnectionlessPopupButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4177806832));
            WGConnectionlessPopupButton.<>c.<>9__4_15 = val_40;
        }
        
        Add(key:  13, value:  7454720);
        val_41 = null;
        val_41 = null;
        val_43 = WGConnectionlessPopupButton.<>c.<>9__4_16;
        if(val_43 == 0)
        {
                val_43 = null;
            val_43 = new System.Action(object:  WGConnectionlessPopupButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4177807856));
            WGConnectionlessPopupButton.<>c.<>9__4_16 = val_43;
        }
        
        Add(key:  14, value:  7454720);
        val_44 = null;
        val_44 = null;
        val_46 = WGConnectionlessPopupButton.<>c.<>9__4_17;
        if(val_46 == 0)
        {
                val_46 = null;
            val_46 = new System.Action(object:  WGConnectionlessPopupButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4177808880));
            WGConnectionlessPopupButton.<>c.<>9__4_17 = val_46;
        }
        
        Add(key:  16, value:  7454720);
        val_47 = null;
        val_47 = null;
        val_49 = WGConnectionlessPopupButton.<>c.<>9__4_18;
        if(val_49 == 0)
        {
                val_49 = null;
            val_49 = new System.Action(object:  WGConnectionlessPopupButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4177809904));
            WGConnectionlessPopupButton.<>c.<>9__4_18 = val_49;
        }
        
        Add(key:  18, value:  7454720);
        val_50 = null;
        val_50 = null;
        val_52 = WGConnectionlessPopupButton.<>c.<>9__4_19;
        if(val_52 == 0)
        {
                val_52 = null;
            val_52 = new System.Action(object:  WGConnectionlessPopupButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4177810928));
            WGConnectionlessPopupButton.<>c.<>9__4_19 = val_52;
        }
        
        Add(key:  20, value:  7454720);
        this.ConnectionlessPopupActions = null;
    }

}
