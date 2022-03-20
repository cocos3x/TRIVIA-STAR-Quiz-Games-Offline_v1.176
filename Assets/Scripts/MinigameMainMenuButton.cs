using UnityEngine;
public class MinigameMainMenuButton : MonoBehaviour
{
    // Methods
    private void Start()
    {
        var val_11;
        System.Func<MiniGame, System.Boolean> val_13;
        var val_15;
        System.Func<MiniGame, System.Int32> val_17;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(DeeplinkedWhichMinigame > 1)
        {
                return;
        }
        
        AppConfigs val_3 = App.Configuration;
        if((mem[83886604] + 12) != 0)
        {
                AppConfigs val_4 = App.Configuration;
            val_11 = null;
            val_11 = null;
            val_13 = MinigameMainMenuButton.<>c.<>9__0_0;
            if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  MinigameMainMenuButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2548740752));
            MinigameMainMenuButton.<>c.<>9__0_0 = val_13;
        }
        
            System.Collections.Generic.IEnumerable<TSource> val_6 = System.Linq.Enumerable.Where<System.Object>(source:  mem[83886604], predicate:  7720960);
            val_15 = null;
            val_15 = null;
            val_17 = MinigameMainMenuButton.<>c.<>9__0_1;
            if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  MinigameMainMenuButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2548743824));
            MinigameMainMenuButton.<>c.<>9__0_1 = val_17;
        }
        
            Player val_9 = App.Player;
            if(0 >= (System.Linq.Enumerable.Min<System.Object>(source:  mem[83886604], selector:  7720960)))
        {
                return;
        }
        
        }
        
        UnityEngine.GameObject val_10 = this.gameObject;
        this.SetActive(value:  false);
    }
    public MinigameMainMenuButton()
    {
    
    }

}
