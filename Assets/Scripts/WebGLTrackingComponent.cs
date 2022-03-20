using UnityEngine;
public class WebGLTrackingComponent : AppComponent
{
    // Fields
    private string _gameObjectName;
    protected AmplitudePlugin amplitude;
    protected WebGLFacebookTracker facebook;
    private static System.DateTime started;
    
    // Properties
    public override bool RunInMainThread { get; }
    
    // Methods
    public override bool get_RunInMainThread()
    {
        return true;
    }
    public WebGLTrackingComponent(string gameName, string gameObjectName)
    {
        mem[1152921511253992592] = "TrackingComponent";
        this._gameObjectName = gameObjectName;
    }
    public override void initializeOnMainThread()
    {
        var val_1;
        var val_2;
        this.initializeTrackers();
        this.initializeGeneralEvents();
        this.addTrackers();
        var val_1 = 29504414;
        val_1 = 6121124 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        val_2 = null;
        val_2 = null;
        App.trackerManager.track(eventName:  Events.APP_LAUNCHED);
        WebGLTrackingComponent.TrackSession(sessionEnded:  false, forceShutdown:  false);
        this.TrackLogin(fromPause:  false, hasReward:  false);
    }
    private void initializeTrackers()
    {
        this.amplitude = new AmplitudePlugin();
        typeof(WebGLFacebookTracker).__il2cppRuntimeField_25 = 1;
        this.facebook = new Tracker();
    }
    private void addTrackers()
    {
        var val_1;
        var val_2;
        var val_1 = 29503114;
        val_1 = 6122424 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        App.trackerManager.addTracker(t:  this.amplitude);
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        App.trackerManager.addTracker(t:  this.facebook);
    }
    private void initializeGeneralEvents()
    {
        null = null;
        this.amplitude.AddEvent(eventName:  Events.LOGIN, propertyName:  null);
        this.amplitude.AddEvent(eventName:  -1946611776, propertyName:  null);
        this.amplitude.AddEvent(eventName:  -1946611872, propertyName:  null);
        this.amplitude.AddEvent(eventName:  Events.TRANSACTION, propertyName:  null);
        this.amplitude.AddEvent(eventName:  -1942319936, propertyName:  null);
        this.amplitude.AddEvent(eventName:  Events.OUT_OF_CREDITS, propertyName:  null);
        this.amplitude.AddEvent(eventName:  Events.LEVEL_UP, propertyName:  null);
        this.amplitude.AddEvent(eventName:  -2100698896, propertyName:  null);
        this.amplitude.AddEvent(eventName:  -1942303456, propertyName:  null);
        this.amplitude.AddEvent(eventName:  -1942299264, propertyName:  null);
        this.amplitude.AddEvent(eventName:  -1942295072, propertyName:  null);
        this.amplitude.AddEvent(eventName:  -1952660976, propertyName:  null);
        this.amplitude.AddEvent(eventName:  -1942286784, propertyName:  null);
        this.amplitude.AddEvent(eventName:  -1942282592, propertyName:  null);
    }
    public override void onInitialServerUpdate()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        Player val_1 = App.Player;
        if(0 != 0)
        {
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1946947968, value:  -1946948048);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1947645120, value:  1633189168);
            var val_8 = 29500658;
            val_8 = 6124880 + val_8;
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            GameBehavior val_4 = App.getBehavior;
            string val_5 = 0.ToString();
            App.trackerManager.superProperty(propertyName:  Events.CURRENT_LEVEL, propertyValue:  -1942101172);
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_10 = null;
            val_10 = null;
            GameBehavior val_6 = App.getBehavior;
            string val_7 = 0.ToString();
            App.trackerManager.peopleProperty(propertyName:  Events.CURRENT_LEVEL, propertyValue:  -1942101172);
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_11 = null;
            val_11 = null;
            App.trackerManager.flush();
            return;
        }
        
        var val_9 = 29500058;
        val_9 = 6125480 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        App.trackerManager.clearCache();
    }
    public override void onServerUpdate()
    {
        var val_1;
        var val_1 = 29499778;
        val_1 = 6125760 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        App.trackerManager.flush();
    }
    public override void onApplicationPause(bool pauseStatus)
    {
        var val_1;
        this.onApplicationPause(pauseStatus:  pauseStatus);
        if(pauseStatus != false)
        {
                WebGLTrackingComponent.TrackSession(sessionEnded:  pauseStatus, forceShutdown:  false);
            return;
        }
        
        this.TrackLogin(fromPause:  false, hasReward:  false);
        var val_1 = 29499446;
        val_1 = 6126092 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        App.trackerManager.flush();
    }
    public static void TrackSession(bool sessionEnded, bool forceShutdown = False)
    {
        ulong val_4;
        var val_7;
        TrackerManager val_12;
        var val_13;
        var val_15;
        var val_16;
        val_12 = "End Session";
        if(sessionEnded == true)
        {
                "Start Session" = val_12;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if((System.String.op_Equality(a:  -1946611872, b:  -1946611872)) != false)
        {
                Add(key:  -1946611584, value:  8945664);
            System.DateTime val_3 = System.DateTime.UtcNow;
            val_13 = null;
            val_13 = null;
            System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511255016360}, d2:  new System.DateTime() {dateData = val_4});
            double val_9 = val_7.TotalSeconds;
            string val_10 = val_7.ToString(format:  -1946611488);
            Add(key:  -1946611408, value:  -1941765184);
            var val_12 = 29502326;
            val_12 = 6123212 + val_12;
            if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
            val_15 = null;
            val_15 = null;
            val_12 = App.trackerManager;
            val_12.track(eventName:  -1946611872, data:  78753792);
            return;
        }
        
        System.DateTime val_11 = System.DateTime.UtcNow;
        val_16 = null;
        val_16 = null;
        WebGLTrackingComponent.started = val_4;
    }
    protected void TrackLogin(bool fromPause = False, bool hasReward = False)
    {
        var val_3;
        var val_8;
        var val_9;
        var val_10;
        if(hasReward == true)
        {
                1 = 3;
        }
        
        var val_8 = 29501882;
        val_8 = 6123656 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.DateTime val_2 = System.DateTime.Now;
        string val_5 = val_3.ToString();
        Add(key:  -1946490928, value:  -1941652976);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        Add(key:  -1946490832, value:  286580736);
        if( == 3)
        {
                val_9 = "Currency_Reward";
        }
        
        Add(key:  -1946490736, value:  System.String.__il2cppRuntimeField_static_fields);
        val_10 = null;
        val_10 = null;
        string val_6 = ToString();
        Add(key:  -1946490624, value:  286531584);
        Add(key:  -1941665024, value:  System.String.alignConst);
        App.trackerManager.track(eventName:  -1946611776, data:  78753792);
        System.DateTime val_7 = System.DateTime.UtcNow;
        WebGLTrackingComponent.started = new System.DateTime();
    }
    protected WebGLTrackingComponent.AppLaunchTriggers ChooseTrigger(bool hasReward = False)
    {
        if(hasReward == true)
        {
                1 = 3;
        }
    
    }
    protected string ChooseTriggerValue(WebGLTrackingComponent.AppLaunchTriggers trigger = 1)
    {
        var val_1;
        if(trigger != 3)
        {
                return;
        }
        
        val_1 = "Currency_Reward";
    }
    protected string ChooseReferal()
    {
    
    }
    private static WebGLTrackingComponent()
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        WebGLTrackingComponent.started = new System.DateTime();
    }

}
