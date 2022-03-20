using UnityEngine;
public class LimitedTimeBundlesHeader : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text text_description;
    private UnityEngine.UI.Text text_time_remaining;
    private bool showTimer;
    private System.DateTime offerEndTime;
    private FrameSkipper _FrameSkipper;
    
    // Properties
    private FrameSkipper FrameSkipper { get; }
    
    // Methods
    private FrameSkipper get_FrameSkipper()
    {
        if(this._FrameSkipper != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.WUTAutopilotGameplay val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  -1164977312);
        this._FrameSkipper = this;
    }
    private void Awake()
    {
        if(this.showTimer == false)
        {
                return;
        }
        
        FrameSkipper val_1 = this.FrameSkipper;
        System.Action val_2 = new System.Action(object:  -1164856096, method:  new IntPtr(3130086176));
        this.offerEndTime = null;
    }
    public void Setup(string freeAmount, System.DateTime endTime)
    {
        long val_6;
        System.DateTime val_12;
        var val_13;
        val_12 = endTime.dateData;
        if(this.text_description != 0)
        {
                string val_2 = Localization.Localize(key:  -1164759792, defaultValue:  -1164759904, useSingularKey:  false);
            string val_3 = System.String.Format(format:  -1164759792, arg0:  freeAmount);
        }
        
        val_13 = this;
        this.offerEndTime = endTime;
        mem[1152921512032058220] = R3;
        if(this.text_time_remaining == 0)
        {
                return;
        }
        
        val_12 = this.offerEndTime;
        val_13 = 0;
        System.DateTime val_5 = DateTimeCheat.Now;
        System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512032046136}, d2:  new System.DateTime() {dateData = val_12});
        string val_11 = val_8._ticks.FormatTime(timeSpan:  new System.TimeSpan() {_ticks = val_6});
    }
    private void UpdateLogic()
    {
        long val_3;
        if(this.text_time_remaining == 0)
        {
                return;
        }
        
        System.DateTime val_2 = DateTimeCheat.Now;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512032186824}, d2:  new System.DateTime() {dateData = this.offerEndTime});
        string val_8 = val_5._ticks.FormatTime(timeSpan:  new System.TimeSpan() {_ticks = val_3});
    }
    private string FormatTime(System.TimeSpan timeSpan)
    {
        int val_1 = ???.Days;
        int val_2 = ???.Hours;
        val_2 = val_2 + ((val_1 + (val_1 << 1)) << 3);
        int val_4 = ???.Minutes;
        int val_5 = ???.Seconds;
        string val_6 = System.String.Format(format:  -1662255760, arg0:  13152256, arg1:  13152256, arg2:  13152256);
    }
    public LimitedTimeBundlesHeader()
    {
        this.showTimer = true;
    }

}
