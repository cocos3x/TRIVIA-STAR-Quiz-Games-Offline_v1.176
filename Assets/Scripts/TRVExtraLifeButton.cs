using UnityEngine;
public class TRVExtraLifeButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image freeLifeCooldownOverlay;
    private UnityEngine.UI.Text timeRemainingText;
    private UnityEngine.GameObject labelOverlayObject;
    public System.Action<bool> ExtraLifeStateChange;
    private bool _ExtraLifeAvailable;
    
    // Properties
    public UnityEngine.UI.Button.ButtonClickedEvent onClick { get; }
    private bool ExtraLifeAvailable { get; set; }
    
    // Methods
    public UnityEngine.UI.Button.ButtonClickedEvent get_onClick()
    {
        object val_1 = this.GetComponent<System.Object>();
        if(this != 0)
        {
                return;
        }
    
    }
    private bool get_ExtraLifeAvailable()
    {
        return (bool)this._ExtraLifeAvailable;
    }
    private void set_ExtraLifeAvailable(bool value)
    {
        if(this._ExtraLifeAvailable == true)
        {
                this._ExtraLifeAvailable = 1;
        }
        
        if((1 ^ value == true) && (this.ExtraLifeStateChange != 0))
        {
                this.ExtraLifeStateChange.Invoke(obj:  value);
        }
        
        this._ExtraLifeAvailable = value;
    }
    private void OnEnable()
    {
        twelvegigs.Autopilot.WUTAutopilotGameplay val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  -525747824);
        System.Action val_2 = new System.Action(object:  -525747824, method:  new IntPtr(3769194448));
        if(this != 0)
        {
                this.ExtraLifeStateChange = null;
        }
        else
        {
                mem[24] = null;
        }
        
        this.labelOverlayObject = 10;
        object val_3 = this.GetComponentInChildren<System.Object>();
        this.timeRemainingText = this;
    }
    public void Init()
    {
        this.UpdateCoolDown();
    }
    private void UpdateCoolDown()
    {
        long val_13;
        var val_25;
        var val_27;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(freeLifeAvailable != false)
        {
                UnityEngine.GameObject val_3 = this.freeLifeCooldownOverlay.gameObject;
            this.freeLifeCooldownOverlay.SetActive(value:  true);
            UnityEngine.GameObject val_4 = this.gameObject;
            object val_5 = this.GetComponent<System.Object>();
            this.interactable = true;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_8 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.TotalFreeLivesAvailable().ToString();
            val_25;
            this.labelOverlayObject.SetActive(value:  false);
            this.ExtraLifeAvailable = true;
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_10 = freeLifeAvailableAt;
        System.DateTime val_11 = ServerHandler.ServerTime;
        System.TimeSpan val_12 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512671278440}, d2:  new System.DateTime());
        double val_15 = val_13.TotalSeconds;
        WordForest.WFOGameEcon val_16 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(mem[1152921512476916280] != false)
        {
                string val_17 = Localization.Localize(key:  -1510799952, defaultValue:  -1510800032, useSingularKey:  false);
            val_25 = "free_upper";
            this.labelOverlayObject.SetActive(value:  false);
            this.ExtraLifeAvailable = true;
            UnityEngine.GameObject val_18 = this.freeLifeCooldownOverlay.gameObject;
            val_27 = 1;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.DateTime val_20 = freeLifeAvailableAt;
            System.DateTime val_21 = ServerHandler.ServerTime;
            System.TimeSpan val_22 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512671278440}, d2:  new System.DateTime());
            string val_23 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_13}, formatted:  true);
            val_25 = val_13;
            this.labelOverlayObject.SetActive(value:  true);
            this.ExtraLifeAvailable = false;
            UnityEngine.GameObject val_24 = this.freeLifeCooldownOverlay.gameObject;
            val_27 = 0;
        }
        
        this.freeLifeCooldownOverlay.SetActive(value:  false);
    }
    public TRVExtraLifeButton()
    {
    
    }

}
