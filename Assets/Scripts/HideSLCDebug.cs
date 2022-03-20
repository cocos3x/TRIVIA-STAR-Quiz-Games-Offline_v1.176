using UnityEngine;
public class HideSLCDebug : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Image strikeThrough;
    private static bool hidden;
    public UnityEngine.UI.Button button;
    
    // Methods
    private void Awake()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.button = this;
        UnityEngine.CanvasRenderer val_2 = this.strikeThrough.canvasRenderer;
        this.strikeThrough.SetAlpha(alpha:  null);
    }
    private void Start()
    {
    
    }
    private void OnEnable()
    {
        null = null;
        if(HideSLCDebug.hidden == false)
        {
                return;
        }
        
        this.OnClick();
    }
    public void OnClick()
    {
        null = null;
        if(HideSLCDebug.hidden == false)
        {
                1f = 0;
        }
        
        this.strikeThrough.CrossFadeAlpha(alpha:  0f, duration:  null, ignoreTimeScale:  false);
        HideSLCDebug.ToggleHideButton(overrideMessage:  1098586544);
    }
    public static void ToggleHideButton(string overrideMessage = "")
    {
        var val_9;
        bool val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_9 = null;
        val_9 = null;
        bool val_9 = HideSLCDebug.hidden;
        val_9 = val_9 ^ 1;
        HideSLCDebug.hidden = val_9;
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  -909883872);
        if((UnityEngine.Object.op_Implicit(exists:  -909883872)) != false)
        {
                object val_3 = GetComponent<System.Object>();
            val_10 = "SRDebugButton";
            if((UnityEngine.Object.op_Implicit(exists:  -909883872)) != false)
        {
                UnityEngine.CanvasRenderer val_5 = canvasRenderer;
            val_10 = val_10;
            val_11 = null;
            val_11 = null;
            if(HideSLCDebug.hidden == false)
        {
                0f = 1f;
        }
        
            SetAlpha(alpha:  1f);
        }
        
            object val_6 = GetComponent<System.Object>();
            if((UnityEngine.Object.op_Implicit(exists:  -909883872)) != false)
        {
                val_12 = null;
            val_12 = null;
            val_10 = HideSLCDebug.hidden;
            enabled = true;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  overrideMessage)) != true)
        {
                DebugMessageDisplay.DisplayMessage(msgTxt:  overrideMessage, displayTime:  1f);
        }
        
        val_13 = null;
        val_13 = null;
        if(HideSLCDebug.hidden != false)
        {
                val_14 = "The 12 gigs debug tab will now be <b>hidden</b>.\n(You can still double-tap the area to open the debug panel)";
        }
        else
        {
                val_14 = "The 12 gigs debug tab will be <b>visible</b>";
        }
        
        DebugMessageDisplay.DisplayMessage(msgTxt:  -909882464, displayTime:  1f);
    }
    public HideSLCDebug()
    {
    
    }
    private static HideSLCDebug()
    {
    
    }

}
