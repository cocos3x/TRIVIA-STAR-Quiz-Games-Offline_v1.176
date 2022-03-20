using UnityEngine;
public class EventListItem : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text titleText;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.UI.Text viewEventButtonText;
    private UGUINetworkedButton button;
    private PrefabsFromFolder prefabs;
    private WGEventHandler myHandler;
    
    // Methods
    public void InitWithEventHandler(WGEventHandler handler)
    {
        WGEventHandler val_16;
        System.Delegate val_17;
        object val_18;
        UnityEngine.Events.UnityAction val_20;
        var val_21;
        System.Delegate val_22;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_16 = val_1;
            typeof(EventListItem.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = handler;
        }
        else
        {
                val_16 = 8;
            mem[8] = handler;
        }
        
        this.myHandler = val_16;
        if(SceneDictator.IsInGameScene() == false)
        {
            goto label_7;
        }
        
        System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  mem[8], method:  handler + 344);
        val_17 = this.button.OnConnectionClick;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_17, b:  7401472);
        if(val_17 != 0)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        val_17 = 0;
        label_10:
        this.button.OnConnectionClick = val_17;
        val_18 = val_16;
        val_20 = null;
        val_21 = 1152921511781622144;
        goto label_12;
        label_7:
        System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  mem[8], method:  handler + 336);
        val_22 = this.button.OnConnectionClick;
        System.Delegate val_6 = System.Delegate.Combine(a:  val_22, b:  7401472);
        if(val_22 != 0)
        {
                if(null == null)
        {
            goto label_15;
        }
        
        }
        
        val_22 = 0;
        label_15:
        this.button.OnConnectionClick = val_22;
        val_18 = val_16;
        val_20 = null;
        val_21 = 1152921511781627264;
        label_12:
        val_20 = new UnityEngine.Events.UnityAction(object:  315760640, method:  new IntPtr(2879812992));
        this.button.AddListener(call:  162246656);
        GameEcon val_8 = App.getGameEcon;
        string val_9 = 0.titleFormat;
        string val_10 = System.String.Format(format:  null, arg0:  val_18);
        bool val_11 = UnityEngine.Object.op_Implicit(exists:  this.viewEventButtonText);
        this.SetTimerText(timeEnd:  new System.DateTime() {dateData = mem[8]});
        System.Collections.IEnumerator val_14 = this.UpdateItem();
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  -1415112896);
    }
    private System.Collections.IEnumerator UpdateItem()
    {
        object val_1 = new System.Object();
        typeof(EventListItem.<UpdateItem>d__7).__il2cppRuntimeField_8 = 0;
        typeof(EventListItem.<UpdateItem>d__7).__il2cppRuntimeField_10 = this;
    }
    private void SetTimerText(System.DateTime timeEnd)
    {
        var val_3;
        ulong val_14;
        WGEventHandler val_15;
        var val_16;
        val_14 = R2;
        val_15 = this.myHandler;
        if((System.String.IsNullOrEmpty(value:  val_15)) == false)
        {
            goto label_2;
        }
        
        val_15 = 1152921504616751104;
        val_16 = null;
        val_16 = null;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_14}, d2:  new System.DateTime() {dateData = System.DateTime.MaxValue})) == false)
        {
            goto label_5;
        }
        
        if(this.timerText != 0)
        {
                return;
        }
        
        return;
        label_2:
        if(this.timerText != 0)
        {
                return;
        }
        
        return;
        label_5:
        val_15 = "0";
        string val_6 = val_3.Days.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        string val_8 = val_3.Hours.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        string val_10 = val_3.Minutes.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        string val_12 = val_3.Seconds.ToString(format:  1254115712);
        val_14;
        typeof(System.Object[]).__il2cppRuntimeField_1C = val_14;
        string val_13 = System.String.Format(format:  -1414851456, args:  472754880);
    }
    private void OnDestroy()
    {
        this.StopAllCoroutines();
    }
    public EventListItem()
    {
    
    }

}
