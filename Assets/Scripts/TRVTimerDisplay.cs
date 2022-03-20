using UnityEngine;
public class TRVTimerDisplay : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text pointsText;
    public System.Action<int> OnTick;
    private System.DateTime startTime;
    private float quizDuration;
    private System.Collections.IEnumerator timeRemainingTimer;
    
    // Properties
    public bool playingGame { get; }
    
    // Methods
    public bool get_playingGame()
    {
        return this.enabled;
    }
    public void Setup()
    {
        if(this.pointsText == 0)
        {
            
        }
    
    }
    public void UpdateTime(System.DateTime incStartTime, float secondsToCompleteQuiz)
    {
        float val_2;
        if(this.enabled != true)
        {
                this.enabled = true;
        }
        
        this.quizDuration = val_2;
        this.startTime = R2;
        mem[1152921512752945932] = R3;
        if(this.timeRemainingTimer != 0)
        {
                return;
        }
        
        System.Collections.IEnumerator val_3 = this.CheckTimeRemaining();
        this.timeRemainingTimer = this;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -443835664);
    }
    public void StopTimer()
    {
        this.StopAllCoroutines();
        this.timeRemainingTimer = 0;
    }
    public string TimeRemainingText()
    {
        ulong val_2;
        var val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512753161944}, d2:  new System.DateTime() {dateData = val_2});
        float val_10 = (float)val_5.Seconds;
        val_10 = this.quizDuration - val_10;
        string val_9 = UnityEngine.Mathf.FloorToInt(f:  val_10).ToString();
    }
    public float TimeRemaining()
    {
        ulong val_2;
        var val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512753273952}, d2:  new System.DateTime() {dateData = val_2});
        float val_8 = (float)val_5.Seconds;
        val_8 = this.quizDuration - val_8;
        return (float)val_8;
    }
    private System.Collections.IEnumerator CheckTimeRemaining()
    {
        object val_1 = new System.Object();
        typeof(TRVTimerDisplay.<CheckTimeRemaining>d__12).__il2cppRuntimeField_8 = 0;
        typeof(TRVTimerDisplay.<CheckTimeRemaining>d__12).__il2cppRuntimeField_10 = this;
    }
    public TRVTimerDisplay()
    {
    
    }

}
