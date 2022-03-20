using UnityEngine;
public class TimerText : MonoBehaviour
{
    // Fields
    public bool countUp;
    public bool runOnStart;
    public int timeValue;
    public bool showHour;
    public bool showHourZeroes;
    public bool showMinute;
    public bool showSecond;
    public System.Action onCountDownComplete;
    private bool isRunning;
    
    // Methods
    private void Start()
    {
        if(this.runOnStart == false)
        {
                return;
        }
        
        this.Run();
    }
    public void Run()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeInHierarchy == false)
        {
                return;
        }
        
        if((R4 + 28) != 0)
        {
                return;
        }
        
        mem2[0] = 1;
        System.Collections.IEnumerator val_3 = R4.UpdateClockText();
        UnityEngine.Coroutine val_4 = R4.StartCoroutine(routine:  R4);
    }
    private System.Collections.IEnumerator UpdateClockText()
    {
        object val_1 = new System.Object();
        typeof(TimerText.<UpdateClockText>d__11).__il2cppRuntimeField_8 = 0;
        typeof(TimerText.<UpdateClockText>d__11).__il2cppRuntimeField_10 = this;
    }
    public void SetTime(int value)
    {
        value = value & (~(value >> 31));
        this.timeValue = value;
        goto typeof(TimerText).__il2cppRuntimeField_DC;
    }
    public void AddTime(int value)
    {
        value = this.timeValue + value;
        this.timeValue = value;
        goto typeof(TimerText).__il2cppRuntimeField_DC;
    }
    protected virtual void UpdateText()
    {
        int val_2;
        var val_16;
        var val_17;
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  null);
        if(this.showHour == false)
        {
            goto label_10;
        }
        
        if(this.showHourZeroes != true)
        {
                if(val_2.Hours < 1)
        {
            goto label_5;
        }
        
        }
        
        if(this.showMinute == true)
        {
                this.showMinute = this.showSecond;
            goto label_6;
        }
        
        label_5:
        if(this.showHour == false)
        {
            goto label_10;
        }
        
        if(this.showHourZeroes != true)
        {
                if(val_2.Hours < 1)
        {
            goto label_10;
        }
        
        }
        
        if(this.showMinute == false)
        {
            goto label_10;
        }
        
        val_16 = 1152921504619999232;
        val_2 = val_2.Hours;
        val_17 = null;
        int val_7 = val_2.Minutes;
        goto label_11;
        label_10:
        val_16 = 1152921504619999232;
        val_2 = val_2.Minutes;
        val_17 = null;
        int val_9 = val_2.Seconds;
        label_11:
        string val_10 = System.String.Format(format:  2133722016, arg0:  13152256, arg1:  13152256);
        label_12:
        UnityEngine.GameObject val_11 = this.gameObject;
        CExtension.SetText(obj:  -2117523552, value:  2133722016);
        return;
        label_6:
        val_2 = val_2.Hours;
        int val_13 = val_2.Minutes;
        int val_14 = val_2.Seconds;
        string val_15 = System.String.Format(format:  -2117547664, arg0:  13152256, arg1:  13152256, arg2:  13152256);
        goto label_12;
    }
    public void Stop()
    {
        this.StopAllCoroutines();
        this.isRunning = false;
    }
    public TimerText()
    {
        this.countUp = true;
        this.showHourZeroes = true;
        this.showMinute = true;
        this.showSecond = true;
    }

}
