using UnityEngine;
public class WGStarterPackButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text timeRemainingText;
    private UnityEngine.GameObject opposingButton;
    private bool wasActive;
    private bool thisWasActive;
    
    // Methods
    private void OnEnable()
    {
        if(WGStarterPackController.featureRelavent != false)
        {
                this.thisWasActive = true;
            UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.UI.LayoutElement val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  60754528);
            System.Action val_4 = new System.Action(object:  60754528, method:  new IntPtr(60716192));
            mem[1152921513257536120] = null;
            UnityEngine.GameObject val_5 = this.gameObject;
            object val_6 = this.GetComponent<System.Object>();
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  60754528, method:  new IntPtr(60717216));
            this.AddListener(call:  162246656);
            if(this.opposingButton == 0)
        {
                return;
        }
        
            this.wasActive = this.opposingButton.activeSelf;
            if(this.opposingButton != 0)
        {
            goto label_11;
        }
        
        }
        else
        {
                UnityEngine.GameObject val_10 = this.gameObject;
        }
        
        label_11:
        this.SetActive(value:  false);
    }
    private void UpdateTimerText()
    {
        if(WGStarterPackController.featureRelavent != false)
        {
                if(this.opposingButton != 0)
        {
                this.opposingButton.SetActive(value:  false);
        }
        
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.TimeSpan val_4 = timeRemaining;
            string val_5 = GenericStringExtentions.ToString(span:  new System.TimeSpan(), formatted:  true);
            if(this.timeRemainingText != 0)
        {
                return;
        }
        
            return;
        }
        
        UnityEngine.GameObject val_6 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnApplicationPause(bool paused)
    {
        if(WGStarterPackController.featureRelavent == true)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = R4.gameObject;
        R4.SetActive(value:  false);
    }
    private void OnPurchaseCompleted()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnClick()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGStarterPackController MonoSingleton<WGStarterPackController>::get_Instance().__il2cppRuntimeField_C = 48;
    }
    private void OnDisable()
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.opposingButton, y:  0);
        if(val_1 == true)
        {
                val_1 = this.thisWasActive;
            goto label_3;
        }
        
        return;
        label_3:
        if(this.wasActive == true)
        {
                this.wasActive = 1;
        }
        
        this.opposingButton.SetActive(value:  true);
    }
    public WGStarterPackButton()
    {
    
    }

}
