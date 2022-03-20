using UnityEngine;
public class LoadTimer : MonoSingletonSelfGenerating<LoadTimer>
{
    // Fields
    private System.Collections.Generic.List<string> loadTimes;
    private System.Collections.Generic.Dictionary<string, LoadTimer.LoadTimerData> timers;
    private bool stopOnLevelLoaded;
    private bool levelWasLoaded;
    
    // Methods
    public void StartTimer(string title, bool stopOnLevelWasLoaded = True)
    {
        System.Collections.Generic.Dictionary<System.String, LoadTimerData> val_3;
        System.Collections.Generic.Dictionary<System.String, LoadTimerData> val_4;
        val_3 = this;
        val_4 = this.timers;
        if((val_4.ContainsKey(key:  title)) == true)
        {
                return;
        }
        
        val_3 = this.timers;
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        val_4 = 0;
        val_3.Add(key:  title, value:  new LoadTimerData() {startTime = 0f, stopOnLevelLoaded = stopOnLevelWasLoaded});
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1778877872, method:  new IntPtr(2516064400));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -1778877872);
    }
    private void Update()
    {
        if(this.levelWasLoaded == false)
        {
                return;
        }
        
        this.StopTimersOnLevelWasLoaded();
        this.levelWasLoaded = false;
    }
    public void StopTimer(string stopSpecifiedTimer)
    {
        var val_5;
        string val_9;
        float val_10;
        val_9 = "error";
        val_10 = -1000f;
        if((System.String.IsNullOrEmpty(value:  stopSpecifiedTimer)) != true)
        {
                if((this.timers.ContainsKey(key:  stopSpecifiedTimer)) != false)
        {
                float val_3 = UnityEngine.Time.realtimeSinceStartup;
            uint val_9 = 0;
            LoadTimerData val_4 = Item[this.timers];
            val_9 = val_9 - val_5;
            bool val_6 = this.timers.Remove(key:  stopSpecifiedTimer);
            val_9 = stopSpecifiedTimer;
            val_10 = val_9 * 1000f;
        }
        
        }
        
        string val_7 = val_10.ToString(format:  -1778655344);
        string val_8 = val_9 + 1370307136 + -1778643220(-1778643220) + -1778655264(-1778655264);
        this.loadTimes.Add(item:  val_9);
    }
    public void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        this.levelWasLoaded = true;
    }
    private void StopTimersOnLevelWasLoaded()
    {
        var val_4;
        string val_5;
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, LoadTimerData>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, LoadTimerData>>(collection:  this.timers);
        List.Enumerator<T> val_2 = 0.GetEnumerator();
        label_4:
        if(0.MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 == false)
        {
            goto label_4;
        }
        
        this.StopTimer(stopSpecifiedTimer:  val_5);
        goto label_4;
        label_2:
        0.Dispose();
    }
    public string GetLoadTimeInfo()
    {
        var val_2;
        var val_3;
        val_2 = 0;
        val_3 = "";
        goto label_1;
        label_5:
        if("" <= val_2)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + 0;
        string val_1 = 1098586544 + (0 + 0) + 16((0 + 0) + 16) + 1269544832;
        val_2 = 1;
        val_3 = val_3;
        label_1:
        if(val_2 < val_3)
        {
            goto label_5;
        }
    
    }
    private void OnDestroy()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1778125840, method:  new IntPtr(2516064400));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  162459648);
    }
    public LoadTimer()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.loadTimes = null;
        System.Collections.Generic.Dictionary<System.String, LoadTimerData> val_2 = new System.Collections.Generic.Dictionary<System.String, LoadTimerData>();
        this.timers = null;
    }

}
