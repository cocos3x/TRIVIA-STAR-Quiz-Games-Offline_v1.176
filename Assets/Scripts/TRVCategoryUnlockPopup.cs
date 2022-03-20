using UnityEngine;
public class TRVCategoryUnlockPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button unlockButton;
    private UnityEngine.UI.Text newCategoryText;
    private UnityEngine.UI.Text continueText;
    private UnityEngine.ParticleSystem revealFlourish;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -544286176, method:  new IntPtr(3750647808));
        this.unlockButton.m_OnClick.AddListener(call:  162246656);
        if(this.continueText == 0)
        {
            
        }
    
    }
    private void UnlockCategory()
    {
        var val_7;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Boolean> val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_2 = CategoryUnlockLevels;
        val_7 = null;
        val_7 = null;
        val_9 = TRVCategoryUnlockPopup.<>c.<>9__5_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Func<System.Collections.Generic.KeyValuePair<TRVPickerGameButton, System.Int32>, System.Boolean>(object:  TRVCategoryUnlockPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3750785504));
            TRVCategoryUnlockPopup.<>c.<>9__5_0 = val_9;
        }
        
        System.Collections.Generic.KeyValuePair<System.Object, System.Int32> val_4 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<System.Object, System.Int32>>(source:  -544139000, predicate:  -1484293744);
        this.revealFlourish.Play();
        this.unlockButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -544126960, method:  new IntPtr(3750811104));
        this.unlockButton.m_OnClick.AddListener(call:  162246656);
        if(this.continueText != 0)
        {
                return;
        }
    
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_3 = ShowInterstitial(context:  2);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Init(currentlySelectedCategores:  0, fromReroll:  false);
    }
    public TRVCategoryUnlockPopup()
    {
    
    }

}
