using UnityEngine;
public class ChallengeFriendController : MonoSingleton<ChallengeFriendController>
{
    // Fields
    private string deeplinkData;
    private string challengeToBeatUniqueId;
    private ChallengeFriendController.ChallengeFriendPacket challengeToBeat;
    private System.TimeSpan challenge_time_taken;
    private int questionIndex;
    private bool waitingForLobby;
    private ChallengeFriendController.ChallengeFriendPacket challengeToShare;
    private string sharableLinkerAppUrl;
    private bool initializedGameScene;
    private const string pref_results_key = "f_c_results";
    private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> loadedChallengeResults;
    
    // Properties
    public ChallengeFriendController.ChallengeFriendPacket ChallengeToShare { get; }
    private int unlockLevel { get; }
    private int levelsBetweenChallengeGen { get; }
    private decimal challengeVictoryReward { get; }
    private bool PlayingChallenge { get; }
    
    // Methods
    public ChallengeFriendController.ChallengeFriendPacket get_ChallengeToShare()
    {
    
    }
    private int get_unlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 786450;
        }
        
        return 786450;
    }
    private int get_levelsBetweenChallengeGen()
    {
        GameEcon val_1 = App.getGameEcon;
        return System.Math.Max(val1:  1, val2:  1190);
    }
    private decimal get_challengeVictoryReward()
    {
        GameEcon val_1 = App.getGameEcon;
        return new System.Decimal() {flags = 0 + 1252, hi = App.__il2cppRuntimeField_cctor_finished};
    }
    private bool get_PlayingChallenge()
    {
        if(this.challengeToBeat != 0)
        {
                this.challengeToBeat = 1;
        }
        
        return true;
    }
    private void Start()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1486196864, method:  new IntPtr(2808745408));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
    }
    public void HandleLinkerAppDeeplink(string linkerUrlDataSerialized)
    {
        var val_14;
        string val_1 = -1486104768(-1486104768) + linkerUrlDataSerialized;
        val_14 = "HandleLinkerAppDeeplink ";
        SLCDebug.Log(logMessage:  -1486104768, colorHash:  -1835139200, isError:  false);
        object val_2 = MiniJSON.Json.Deserialize(json:  linkerUrlDataSerialized);
        if(linkerUrlDataSerialized != null)
        {
                val_14 = linkerUrlDataSerialized;
        }
        
        bool val_3 = System.String.IsNullOrEmpty(value:  linkerUrlDataSerialized);
        string val_4 = -1486104640(-1486104640) + linkerUrlDataSerialized;
        UnityEngine.Debug.LogError(message:  -1486104640);
    }
    public void LevelCompleteClosed()
    {
        this.challengeToShare = 0;
        this.deeplinkData = "";
        this.waitingForLobby = 0;
    }
    public System.TimeSpan GetChallengeToBeatTimeSpan()
    {
        if((R1 + 20) == 0)
        {
                R1 + 20 + 16 = 0;
        }
        
        this = 0;
        return new System.TimeSpan() {_ticks = 1152921511710930528};
    }
    public System.TimeSpan GetMyTimeTakenOnChallenge()
    {
        this = R1 + 24;
        return new System.TimeSpan() {_ticks = 1152921511711042528};
    }
    public void ShareChallenge()
    {
        ChallengeFriendPacket val_5;
        string val_6;
        ChallengeFriendPacket val_7;
        string val_8;
        val_5 = this.challengeToShare;
        if(val_5 != 0)
        {
                val_6 = this.challengeToShare.subcategory;
        }
        else
        {
                val_6 = this.challengeToShare.subcategory;
            val_5 = this.challengeToShare;
            if(val_5 == 0)
        {
                val_5 = 0;
        }
        
        }
        
        double val_2 = val_5 + 16.TotalSeconds;
        string val_3 = System.String.Format(format:  -1485634656, arg0:  val_6, arg1:  10489856);
        val_7 = this.challengeToShare;
        if(val_7 != 0)
        {
                val_8 = this.challengeToShare.subcategory;
        }
        else
        {
                val_8 = this.challengeToShare.subcategory;
            val_7 = this.challengeToShare;
            if(val_7 == 0)
        {
                val_7 = 0;
        }
        
        }
        
        double val_4 = 16.TotalSeconds;
        string val_5 = System.String.Format(format:  -1485634656, arg0:  val_8, arg1:  10489856);
        twelvegigs.plugins.SharePlugin.Share(text:  -1485634656, url:  R7, subject:  -1485618064, emailBody:  -1485634656, imgPath:  0);
        TrackChallengeIssued();
    }
    private void OnApplicationPause(bool pause)
    {
        if(pause == true)
        {
                return;
        }
        
        this.DoChallengeChecks();
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode sceneMode)
    {
        this.DoChallengeChecks();
    }
    private void DoChallengeChecks()
    {
        if(this.waitingForLobby == true)
        {
            goto label_1;
        }
        
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                0 = this;
            this.CheckForChallengeResults();
        }
        
        if(this.waitingForLobby == false)
        {
            goto label_6;
        }
        
        label_1:
        GameBehavior val_2 = App.getBehavior;
        if(0 == 1)
        {
                0 = this;
            this.LoadGameScene();
        }
        
        label_6:
        this.Init();
    }
    private void Init()
    {
        bool val_18;
        var val_19;
        var val_20;
        GameBehavior val_1 = App.getBehavior;
        val_18 = 0;
        if(0 != 2)
        {
            goto label_5;
        }
        
        if(this.initializedGameScene != false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_3 = new System.Action(object:  -1485094752, method:  new IntPtr(2809838304));
        System.Delegate val_4 = System.Delegate.Combine(a:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_14, b:  7454720);
        val_19 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_14;
        if(val_19 != 0)
        {
                if(val_19 == null)
        {
            goto label_12;
        }
        
        }
        
        val_19 = 0;
        label_12:
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_14 = val_19;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean, TRVQuizProgress> val_6 = new System.Action<System.Boolean, TRVQuizProgress>(object:  -1485094752, method:  new IntPtr(2809839328));
        System.Delegate val_7 = System.Delegate.Combine(a:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_1C, b:  7507968);
        val_20 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_1C;
        if(val_20 != 0)
        {
                if(val_20 == null)
        {
            goto label_16;
        }
        
        }
        
        val_20 = 0;
        label_16:
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_1C = val_20;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_9 = new System.Func<TRVQuizProgress>(object:  -1485094752, method:  new IntPtr(2809841376));
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_20 = null;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_11 = new System.Func<TRVQuizProgress>(object:  -1485094752, method:  new IntPtr(2809843424));
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_24 = null;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<System.Boolean> val_13 = new System.Func<System.Boolean>(object:  -1485094752, method:  new IntPtr(2809845472));
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_28 = null;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<System.Boolean> val_15 = new System.Func<System.Boolean>(object:  -1485094752, method:  new IntPtr(2809846496));
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_2C = null;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<System.Boolean> val_17 = new System.Func<System.Boolean>(object:  -1485094752, method:  new IntPtr(2809847520));
        val_18 = true;
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_30 = null;
        label_5:
        this.initializedGameScene = val_18;
    }
    private void OnQuizBegin()
    {
    
    }
    private void OnQuizComplete(bool success, TRVQuizProgress completedQuizData)
    {
        var val_2;
        System.TimeSpan val_7;
        var val_22;
        float val_23;
        int val_24;
        float val_25;
        val_22 = this;
        if(this.challengeToBeat == 0)
        {
            goto label_1;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        val_23 = 0f;
        val_24 = 1152921511711900128;
        goto label_4;
        label_6:
        float val_3 = val_2.questionTimeTaken;
        val_23 = val_23 + val_2;
        label_4:
        if(MoveNext() == true)
        {
            goto label_6;
        }
        
        Dispose();
        System.TimeSpan val_5 = System.TimeSpan.FromSeconds(value:  null);
        this.challenge_time_taken = val_7;
        return;
        label_1:
        Player val_8 = App.Player;
        val_24 = this.unlockLevel;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  val_24)) == false)
        {
            goto label_15;
        }
        
        Player val_11 = App.Player;
        int val_12 = this.unlockLevel;
        val_24 = val_12;
        int val_14 = 0 - val_24;
        if(val_12.levelsBetweenChallengeGen == 0)
        {
            goto label_19;
        }
        
        label_15:
        var val_22 = 21395382;
        val_22 = 14246008 + val_22;
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        this.challengeToShare = 0;
        this.deeplinkData = "";
        this.challengeToBeat = 0;
        return;
        label_19:
        typeof(ChallengeFriendController.ChallengeFriendPacket).__il2cppRuntimeField_8 = completedQuizData.quizCategory;
        typeof(ChallengeFriendController.ChallengeFriendPacket).__il2cppRuntimeField_C = completedQuizData.<myData>k__BackingField.subCategory;
        List.Enumerator<T> val_16 = GetEnumerator();
        val_25 = 0f;
        goto label_25;
        label_32:
        if(val_2.answeredCorrectly != false)
        {
                typeof(ChallengeFriendController.ChallengeFriendPacket).__il2cppRuntimeField_1C.Add(item:  val_2 + 8);
        }
        
        float val_18 = val_2.questionTimeTaken;
        val_25 = val_25 + val_2;
        label_25:
        if(MoveNext() == true)
        {
            goto label_32;
        }
        
        Dispose();
        System.TimeSpan val_20 = System.TimeSpan.FromSeconds(value:  null);
        typeof(ChallengeFriendController.ChallengeFriendPacket).__il2cppRuntimeField_10 = val_7;
        Player val_21 = App.Player;
        typeof(ChallengeFriendController.ChallengeFriendPacket).__il2cppRuntimeField_20 = 52;
        this.challengeToShare = new ChallengeFriendController.ChallengeFriendPacket();
        this.NotifyServerChallengeGenerated();
    }
    private bool HandleShowingLevelComplete()
    {
        int val_9;
        int val_15;
        System.TimeSpan val_17;
        var val_18;
        var val_19;
        string val_20;
        var val_23;
        if(this.challengeToBeat == 0)
        {
            goto label_1;
        }
        
        val_17 = this.challenge_time_taken;
        this.NotifyServerChallengeCompleted(failedToComplete:  false);
        if((System.TimeSpan.Compare(t1:  new System.TimeSpan() {_ticks = val_17}, t2:  new System.TimeSpan() {_ticks = this.challengeToBeat.timespan})) == 1)
        {
            goto label_4;
        }
        
        GameBehavior val_3 = App.getBehavior;
        val_18 = null;
        val_18 = null;
        val_19 = 0;
        string val_5 = System.String.Format(format:  -1484713120, arg0:  this.challengeToBeat.subcategory);
        val_20 = "You Lost the {0} Challenge Against your Friend";
        val_17 = null;
        val_17 = new System.Action(object:  -1484667184, method:  new IntPtr(2810258432));
        0.Setup(reward:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, message:  val_20, windowConclusionCallback:  val_17);
        goto label_15;
        label_1:
        val_23 = 0;
        return (bool)val_23;
        label_4:
        Player val_7 = App.Player;
        decimal val_8 = challengeVictoryReward;
        0.AddCredits(amount:  new System.Decimal() {mid = val_9}, source:  "Friend Challenge", subSource:  0, externalParams:  0, doTrack:  true);
        GameBehavior val_10 = App.getBehavior;
        decimal val_12 = challengeVictoryReward;
        string val_13 = System.String.Format(format:  -1484703632, arg0:  this.challengeToBeat.subcategory);
        val_20 = null;
        val_20 = new System.Action(object:  -1484667184, method:  new IntPtr(2810258432));
        0.Setup(reward:  new System.Decimal() {mid = val_15}, message:  "You Won the {0} Challenge Against your Friend", windowConclusionCallback:  val_20);
        decimal val_16 = challengeVictoryReward;
        val_19 = 1;
        label_15:
        this.challengeToBeat.challengerSupportId.TrackChallengeConcluded(won:  true, award:  new System.Decimal() {flags = val_16.lo, hi = val_16.mid, lo = val_15, mid = "You Won the {0} Challenge Against your Friend"}, otherPlayerSupportId:  this.challengeToBeat.challengerSupportId);
        val_23 = 1;
        return (bool)val_23;
    }
    private void OnResultsConclusion()
    {
        var val_2 = 21390634;
        val_2 = 14250756 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        this.waitingForLobby = false;
        this.challengeToShare = false;
        this.deeplinkData = "";
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private bool HandleShowingLevelFailed()
    {
        var val_5;
        var val_6;
        if(this.challengeToBeat != 0)
        {
                this.NotifyServerChallengeCompleted(failedToComplete:  true);
            GameBehavior val_1 = App.getBehavior;
            val_5 = null;
            val_5 = null;
            string val_3 = System.String.Format(format:  -1484713120, arg0:  this.challengeToBeat.subcategory);
            System.Action val_4 = new System.Action(object:  -1484402224, method:  new IntPtr(2810258432));
            0.Setup(reward:  new System.Decimal() {flags = System.Decimal.Zero, hi = SL, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, message:  "You Lost the {0} Challenge Against your Friend", windowConclusionCallback:  null);
            val_6 = 1;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    private TRVQuizProgress GetChallengeFriendQuiz()
    {
        var val_7 = 0;
        if((System.String.IsNullOrEmpty(value:  this.deeplinkData)) == true)
        {
                return;
        }
        
        val_7 = 0;
        if((System.String.IsNullOrEmpty(value:  -1573634864)) == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVSubCategoryData val_5 = LoadSubCategoryData(subcategory:  -1573630768, primaryCategory:  1098586544);
        TRVQuizProgress val_6 = null;
        val_7 = val_6;
        val_6 = new TRVQuizProgress(quizCategoryData:  -1484293744);
        typeof(TRVQuizProgress).__il2cppRuntimeField_C = typeof(ChallengeFriendController.ChallengeFriendPacket).__il2cppRuntimeField_1C + 12;
        typeof(TRVQuizProgress).__il2cppRuntimeField_1C = typeof(ChallengeFriendController.ChallengeFriendPacket).__il2cppRuntimeField_1C + 12;
        typeof(TRVQuizProgress).__il2cppRuntimeField_8 = ChallengeFriendController.ChallengeFriendPacket.__il2cppRuntimeField_name;
        typeof(TRVQuizProgress).__il2cppRuntimeField_2C = ChallengeFriendController.ChallengeFriendPacket.__il2cppRuntimeField_this_arg;
        this.challengeToBeat = new ChallengeFriendController.ChallengeFriendPacket(serialized:  this.deeplinkData);
    }
    private QuestionData GetNextQuestion()
    {
        var val_4;
        System.Collections.Generic.List<System.String> val_5;
        int val_6;
        ChallengeFriendPacket val_7;
        string val_8;
        val_4 = 0;
        if(this.challengeToBeat == 0)
        {
                return;
        }
        
        val_5 = this.challengeToBeat.questionIDs;
        val_6 = this.questionIndex;
        if(val_6 >= this.challengeToBeat)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = this.challengeToBeat;
        if(val_7 == 0)
        {
            goto label_6;
        }
        
        val_8 = this.challengeToBeat.category;
        goto label_7;
        label_6:
        val_8 = this.challengeToBeat.category;
        val_7 = this.challengeToBeat;
        if(val_7 == 0)
        {
            goto label_8;
        }
        
        label_7:
        label_15:
        val_5 = this.challengeToBeat.questionIDs;
        if(val_7 <= this.questionIndex)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + (this.questionIndex << 2);
        val_6 = mem[(0 + (this.questionIndex) << 2) + 16];
        val_6 = (0 + (this.questionIndex) << 2) + 16;
        QuestionData val_2 = GetQuestionFromID(category:  val_8, subCategory:  this.challengeToBeat.subcategory, questionID:  val_6);
        val_4 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
        int val_5 = this.questionIndex;
        val_5 = val_5 + 1;
        this.questionIndex = val_5;
        string val_3 = -1484139760(-1484139760) + public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_8(public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_8);
        SLCDebug.Log(logMessage:  -1484139760, colorHash:  -1835139200, isError:  false);
        return;
        label_8:
        if(this.challengeToBeat != 0)
        {
            goto label_15;
        }
    
    }
    private bool CheckPlayingChallenge()
    {
        if(this.challengeToBeat != 0)
        {
                this.challengeToBeat = 1;
        }
        
        return true;
    }
    private void DumpCachedData()
    {
        this.challengeToShare = 0;
        this.deeplinkData = "";
        this.waitingForLobby = 0;
    }
    private void LoadGameScene()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayingChallenge = false;
        }
        
        var val_5 = 21381663;
        val_5 = 14244128 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 4;
        GameBehavior val_4 = App.getBehavior;
        this.waitingForLobby = false;
    }
    private float GenerateScoreFromTimestamp(System.TimeSpan time)
    {
        double val_1 = free_mem[].TotalSeconds;
        float val_2 = 1f;
        val_2 = val_2 / S2;
        val_2 = val_2 * 100f;
        return (float)val_2;
    }
    private void NotifyServerChallengeGenerated()
    {
        var val_6;
        UnityEngine.Debug.LogError(message:  -1483530416);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_2 = this.challengeToShare.Serialize();
        Add(key:  -1612934608, value:  this.challengeToShare);
        Player val_3 = App.Player;
        Add(key:  1618311216, value:  1835037);
        double val_4 = this.challengeToShare.timespan.TotalSeconds;
        float val_6 = 1f;
        val_6 = val_6 / S2;
        val_6 = val_6 * 100f;
        Add(key:  -1668993600, value:  15282176);
        val_6 = null;
        val_6 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1483496752, method:  new IntPtr(2811445408));
        App.networkManager.DoPost(path:  -1483520864, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    private void NotifyServerChallengeCompleted(bool failedToComplete = False)
    {
        float val_6;
        var val_7;
        var val_8;
        var val_9;
        System.Action<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_11;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1486104464, value:  this.challengeToBeatUniqueId);
        Player val_2 = App.Player;
        Add(key:  1618311216, value:  1835037);
        if(failedToComplete != false)
        {
                val_6 = 0f;
        }
        else
        {
                double val_3 = this.challenge_time_taken.TotalSeconds;
            float val_6 = 1f;
            val_6 = val_6 / S2;
            val_6 = val_6 * 100f;
        }
        
        val_7 = null;
        Add(key:  -1668993600, value:  15282176);
        var val_7 = 21376818;
        val_7 = 14249240 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        string val_4 = System.String.Format(format:  -1486104368, arg0:  this.challengeToBeatUniqueId);
        val_9 = null;
        val_9 = null;
        val_11 = ChallengeFriendController.<>c.<>9__42_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  ChallengeFriendController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2811574928));
            ChallengeFriendController.<>c.<>9__42_0 = val_11;
        }
        
        App.networkManager.DoPut(path:  -1486104368, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false);
    }
    private void CheckForChallengeResults()
    {
        var val_4;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_2 = App.Player;
        Add(key:  1618311216, value:  1835037);
        val_4 = null;
        val_4 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_3 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1483246128, method:  new IntPtr(2811696144));
        App.networkManager.DoGet(path:  -1483520864, onCompleteFunction:  7507968, destroy:  false, immediate:  false, getParams:  null, timeout:  20);
        this.ShowResults();
    }
    private void ShowResults()
    {
        int val_10;
        int val_15;
        var val_20;
        System.Action val_21;
        float val_22;
        System.Action val_23;
        string val_24;
        bool val_25;
        var val_26;
        if(this.waitingForLobby == true)
        {
                return;
        }
        
        val_20 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 1)
        {
                return;
        }
        
        this.LoadChallengeResults();
        if(this >= 1)
        {
                if(this == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_2 = 2621443.Item[-1612934608];
            ChallengeFriendController.ChallengeFriendPacket val_3 = null;
            val_21 = val_3;
            val_3 = new ChallengeFriendController.ChallengeFriendPacket(serialized:  2621443);
            string val_4 = 2621443.Item[-1483149936];
            val_22 = 2621443;
            string val_5 = 2621443.Item[-1483149824];
            bool val_6 = System.Boolean.Parse(value:  2621443);
            if(val_6 != false)
        {
                val_20 = val_6;
            Player val_8 = App.Player;
            decimal val_9 = challengeVictoryReward;
            0.AddCredits(amount:  new System.Decimal() {mid = val_10}, source:  "Friend Challenge", subSource:  0, externalParams:  0, doTrack:  true);
            GameBehavior val_11 = App.getBehavior;
            decimal val_13 = challengeVictoryReward;
            val_23 = 0;
            string val_14 = System.String.Format(format:  -1484703632, arg0:  -1573630768);
            val_24 = "You Won the {0} Challenge Against your Friend";
            0.Setup(reward:  new System.Decimal() {mid = val_15}, message:  val_24, windowConclusionCallback:  val_23);
            val_25 = val_20;
        }
        else
        {
                GameBehavior val_16 = App.getBehavior;
            val_26 = null;
            val_26 = null;
            val_21 = 0;
            string val_18 = System.String.Format(format:  -1484713120, arg0:  -1573630768);
            val_24 = "You Lost the {0} Challenge Against your Friend";
            0.Setup(reward:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, message:  val_24, windowConclusionCallback:  val_21);
            val_22 = 3.673424E-39f;
            val_25 = val_6;
        }
        
            decimal val_19 = challengeVictoryReward;
            val_19.flags.TrackChallengeConcluded(won:  val_25, award:  new System.Decimal() {flags = val_19.lo, hi = val_19.mid, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = val_24}, otherPlayerSupportId:  val_22);
            this.loadedChallengeResults.RemoveAt(index:  0);
        }
        
        this.SaveChallengeResults();
    }
    private string GenerateShareChallengeUrl(string uniqueId)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1486104464, value:  uniqueId);
        string val_2 = this.challengeToShare.Serialize();
        Add(key:  -1486103232, value:  this.challengeToShare);
        Add(key:  -1953361104, value:  78753792);
        string val_4 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  78753792);
        string val_5 = DeeplinkAction.Base64ForUrlEncode(str:  78753792);
        AppConfigs val_6 = App.Configuration;
        typeof(System.Object[]).__il2cppRuntimeField_10 = 52;
        AppConfigs val_7 = App.Configuration;
        if(0.IsProduction() == true)
        {
                "-stage" = "";
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_14 = "";
        AppConfigs val_9 = App.Configuration;
        typeof(System.Object[]).__il2cppRuntimeField_18 = 52;
        typeof(System.Object[]).__il2cppRuntimeField_1C = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        return System.String.Format(format:  -1483012128, args:  472754880);
    }
    private void HandleNewChallengeData(string data)
    {
        string val_1 = -1482887616(-1482887616) + data;
        SLCDebug.Log(logMessage:  -1482887616, colorHash:  -1835139200, isError:  false);
        GameBehavior val_2 = App.getBehavior;
        this.deeplinkData = data;
        if(0 != 0)
        {
                this.LoadGameScene();
            return;
        }
        
        this.waitingForLobby = true;
    }
    private void LoadChallengeResults()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5;
        if((this.loadedChallengeResults == 0) && ((UnityEngine.PlayerPrefs.HasKey(key:  -1482767296)) != false))
        {
                string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1482767296, defaultValue:  -2141227328);
            object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1482767296);
            val_5 = "f_c_results";
        }
        else
        {
                val_5 = null;
            val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
        
        this.loadedChallengeResults = val_5;
    }
    private void SaveChallengeResults()
    {
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_4 = this.loadedChallengeResults;
        if(val_4 == 0)
        {
                return;
        }
        
        if(true > 0)
        {
            goto label_2;
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1482767296)) == false)
        {
            goto label_3;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  -1482767296);
        goto label_4;
        label_3:
        val_4 = this.loadedChallengeResults;
        label_2:
        string val_2 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  val_4);
        UnityEngine.PlayerPrefs.SetString(key:  -1482767296, value:  val_4);
        label_4:
        this.loadedChallengeResults = 0;
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private void TrackChallengeConcluded(bool won, decimal award, string otherPlayerSupportId)
    {
        var val_3;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1482517600, value:  8945664);
        decimal val_2 = challengeVictoryReward;
        if(null != 0)
        {
                Add(key:  -1823208320, value:  10170368);
        }
        else
        {
                Add(key:  -1823208320, value:  10170368);
        }
        
        Add(key:  -1482517488, value:  otherPlayerSupportId);
        var val_3 = 21375034;
        val_3 = 14250504 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        App.trackerManager.track(eventName:  -1482517392, data:  78753792);
    }
    private void TrackChallengeIssued()
    {
        TrackingComponent.CurrentIntent = 10;
    }
    public ChallengeFriendController()
    {
        this.sharableLinkerAppUrl = "";
        this.deeplinkData = "";
    }
    private void <NotifyServerChallengeGenerated>b__41_0(string url, System.Collections.Generic.Dictionary<string, object> responseObj)
    {
        string val_11;
        string val_1 = PrettyPrint.printJSON(obj:  responseObj, types:  false, singleLineOutput:  false);
        string val_2 = -1482167968(-1482167968) + url + -1482167888(-1482167888) + responseObj;
        val_11 = "POST ";
        UnityEngine.Debug.LogError(message:  -1482167968);
        if((responseObj.ContainsKey(key:  -1486104464)) == false)
        {
                return;
        }
        
        object val_4 = responseObj.Item[-1486104464];
        val_11 = responseObj;
        string val_5 = val_11.ToString();
        if((System.String.IsNullOrEmpty(value:  val_11)) != false)
        {
                return;
        }
        
        object val_7 = responseObj.Item[-1486104464];
        string val_8 = responseObj.ToString();
        string val_9 = this.GenerateShareChallengeUrl(uniqueId:  responseObj);
        this.sharableLinkerAppUrl = this;
        string val_10 = -1482167808(-1482167808) + responseObj + -1482167696(-1482167696) + -1482143568(-1482143568);
        SLCDebug.Log(logMessage:  -1482167808, colorHash:  -1835139200, isError:  false);
    }
    private void <CheckForChallengeResults>b__43_0(string url, System.Collections.Generic.Dictionary<string, object> responseObj)
    {
        object val_14;
        string val_15;
        val_14 = responseObj;
        val_15 = url;
        string val_1 = PrettyPrint.printJSON(obj:  val_14, types:  false, singleLineOutput:  false);
        string val_2 = -1482039184(-1482039184) + val_15 + -1482167888(-1482167888) + val_14;
        SLCDebug.Log(logMessage:  -1482039184, colorHash:  -1835139200, isError:  false);
        if(val_14 == 0)
        {
                return;
        }
        
        val_15 = "unrewarded_challenges";
        if((val_14.ContainsKey(key:  -1482039104)) == false)
        {
                return;
        }
        
        object val_4 = val_14.Item[-1482039104];
        string val_5 = val_14.ToString();
        if((System.String.IsNullOrEmpty(value:  val_14)) == true)
        {
                return;
        }
        
        object val_7 = val_14.Item[-1482039104];
        if(val_14 == 0)
        {
                return;
        }
        
        val_14 = val_14;
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_14 = 0;
        }
        
        if(0 < 1)
        {
                return;
        }
        
        List.Enumerator<T> val_8 = GetEnumerator();
        label_24:
        if(MoveNext() == false)
        {
            goto label_14;
        }
        
        object val_10 = new System.Object();
        typeof(ChallengeFriendController.<>c__DisplayClass43_0).__il2cppRuntimeField_8 = 0;
        this.LoadChallengeResults();
        if(this < 1)
        {
            goto label_20;
        }
        
        System.Predicate<ZooTile> val_12 = new System.Predicate<ZooTile>(object:  312512512, method:  new IntPtr(2812937520));
        if((this.loadedChallengeResults.Exists(match:  8040448)) == true)
        {
            goto label_24;
        }
        
        label_20:
        this.loadedChallengeResults.Add(item:  0);
        goto label_24;
        label_14:
        Dispose();
        this.SaveChallengeResults();
        this.ShowResults();
    }

}
