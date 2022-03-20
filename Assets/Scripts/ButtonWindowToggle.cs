using UnityEngine;
public class ButtonWindowToggle : MyButton
{
    // Fields
    private UnityEngine.GameObject selfWindow;
    private bool closeSelf;
    private WGWindowPool toggleWindow;
    private System.Collections.Generic.Dictionary<WGWindowPool, System.Action<bool>> ToggleActions;
    
    // Methods
    public override void OnButtonClick()
    {
        var val_3;
        System.Action<System.Boolean> val_1 = this.ToggleActions.Item[this.toggleWindow];
        val_3 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.selfWindow)) != false)
        {
                if(this.closeSelf == true)
        {
                val_3 = 1;
        }
        
        }
        
        this.ToggleActions.Invoke(obj:  true);
        if(this.closeSelf != false)
        {
                SLCWindow.CloseWindow(window:  this.selfWindow, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        
        this.OnButtonClick();
    }
    public ButtonWindowToggle()
    {
        var val_11;
        System.Action<System.Boolean> val_13;
        var val_15;
        System.Action<System.Boolean> val_17;
        var val_18;
        System.Action<System.Boolean> val_20;
        var val_21;
        System.Action<System.Boolean> val_23;
        var val_24;
        System.Action<System.Boolean> val_26;
        var val_27;
        System.Action<System.Boolean> val_29;
        var val_30;
        System.Action<System.Boolean> val_32;
        var val_33;
        System.Action<System.Boolean> val_35;
        var val_36;
        System.Action<System.Boolean> val_38;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        val_11 = null;
        val_11 = null;
        val_13 = ButtonWindowToggle.<>c.<>9__5_0;
        if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new System.Action<System.Boolean>(object:  ButtonWindowToggle.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2179426496));
            ButtonWindowToggle.<>c.<>9__5_0 = val_13;
        }
        
        Add(key:  0, value:  7401472);
        val_15 = null;
        val_15 = null;
        val_17 = ButtonWindowToggle.<>c.<>9__5_1;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Action<System.Boolean>(object:  ButtonWindowToggle.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2179428544));
            ButtonWindowToggle.<>c.<>9__5_1 = val_17;
        }
        
        Add(key:  1, value:  7401472);
        val_18 = null;
        val_18 = null;
        val_20 = ButtonWindowToggle.<>c.<>9__5_2;
        if(val_20 == 0)
        {
                val_20 = null;
            val_20 = new System.Action<System.Boolean>(object:  ButtonWindowToggle.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2179429568));
            ButtonWindowToggle.<>c.<>9__5_2 = val_20;
        }
        
        Add(key:  2, value:  7401472);
        val_21 = null;
        val_21 = null;
        val_23 = ButtonWindowToggle.<>c.<>9__5_3;
        if(val_23 == 0)
        {
                val_23 = null;
            val_23 = new System.Action<System.Boolean>(object:  ButtonWindowToggle.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2179430592));
            ButtonWindowToggle.<>c.<>9__5_3 = val_23;
        }
        
        Add(key:  3, value:  7401472);
        val_24 = null;
        val_24 = null;
        val_26 = ButtonWindowToggle.<>c.<>9__5_4;
        if(val_26 == 0)
        {
                val_26 = null;
            val_26 = new System.Action<System.Boolean>(object:  ButtonWindowToggle.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2179431616));
            ButtonWindowToggle.<>c.<>9__5_4 = val_26;
        }
        
        Add(key:  4, value:  7401472);
        val_27 = null;
        val_27 = null;
        val_29 = ButtonWindowToggle.<>c.<>9__5_5;
        if(val_29 == 0)
        {
                val_29 = null;
            val_29 = new System.Action<System.Boolean>(object:  ButtonWindowToggle.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2179432640));
            ButtonWindowToggle.<>c.<>9__5_5 = val_29;
        }
        
        Add(key:  5, value:  7401472);
        val_30 = null;
        val_30 = null;
        val_32 = ButtonWindowToggle.<>c.<>9__5_6;
        if(val_32 == 0)
        {
                val_32 = null;
            val_32 = new System.Action<System.Boolean>(object:  ButtonWindowToggle.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2179433664));
            ButtonWindowToggle.<>c.<>9__5_6 = val_32;
        }
        
        Add(key:  6, value:  7401472);
        val_33 = null;
        val_33 = null;
        val_35 = ButtonWindowToggle.<>c.<>9__5_7;
        if(val_35 == 0)
        {
                val_35 = null;
            val_35 = new System.Action<System.Boolean>(object:  ButtonWindowToggle.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2179434688));
            ButtonWindowToggle.<>c.<>9__5_7 = val_35;
        }
        
        Add(key:  7, value:  7401472);
        val_36 = null;
        val_36 = null;
        val_38 = ButtonWindowToggle.<>c.<>9__5_8;
        if(val_38 == 0)
        {
                val_38 = null;
            val_38 = new System.Action<System.Boolean>(object:  ButtonWindowToggle.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2179435712));
            ButtonWindowToggle.<>c.<>9__5_8 = val_38;
        }
        
        Add(key:  8, value:  7401472);
        this.ToggleActions = null;
    }

}
