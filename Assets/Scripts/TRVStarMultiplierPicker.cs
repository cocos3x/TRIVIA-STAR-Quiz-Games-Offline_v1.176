using UnityEngine;
public class TRVStarMultiplierPicker : MonoBehaviour
{
    // Fields
    private TRVStarMultiplierButton buttonPrefab;
    private UnityEngine.UI.HorizontalLayoutGroup buttonParent;
    private System.Collections.Generic.List<TRVStarMultiplierButton> myButtons;
    private bool hasSetup;
    
    // Methods
    private void OnEnable()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -446589408, name:  -1898880160);
        Player val_2 = App.Player;
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  mem[1152921512476916256])) != false)
        {
                this.Setup();
            return;
        }
        
        UnityEngine.GameObject val_5 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnServerSync()
    {
        Player val_1 = App.Player;
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  mem[1152921512476916256])) != false)
        {
                this.Refresh();
            return;
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void Setup()
    {
        if(this.hasSetup != false)
        {
                return;
        }
        
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<System.Int32>(source:  mem[1152921512476916288]);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  false);
        UnityEngine.Debug.LogError(message:  -446389408);
    }
    private void Refresh()
    {
        int val_8;
        var val_9;
        Player val_1 = App.Player;
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_8 = mem[1152921512476916256];
        int val_8 = val_8;
        val_9 = 0;
        bool val_3 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  val_8);
        if(val_3 == false)
        {
            goto label_7;
        }
        
        goto label_8;
        label_15:
        if(val_3 <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + 0;
        int val_4 = TRVMainController.currentMultiplier;
        val_8 = val_4;
        val_4 = val_9 - val_8;
        (mem[1152921512476916256] + 0) + 16.SetSelectedUI(selected:  val_4 >> 5);
        val_9 = 1;
        label_8:
        if(val_9 < ((mem[1152921512476916256] + 0) + 16))
        {
            goto label_15;
        }
        
        NotificationCenter val_6 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -446235840, aName:  -474472640);
        return;
        label_7:
        UnityEngine.GameObject val_7 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnDisable()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -446115648, name:  -1898880160);
    }
    public TRVStarMultiplierPicker()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.myButtons = null;
    }

}
