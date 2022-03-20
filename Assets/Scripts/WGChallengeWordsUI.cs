using UnityEngine;
public class WGChallengeWordsUI : MonoSingleton<WGChallengeWordsUI>
{
    // Fields
    private UnityEngine.GameObject challengeWordsTilePrefab;
    private WGChallengeWordsManager challengeWordsManager;
    private WordRegion wordRegion;
    private LineWord word;
    private System.Collections.Generic.List<UnityEngine.GameObject> coinPieces;
    
    // Methods
    public void Start()
    {
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.challengeWordsManager = public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance();
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_3 = new System.Action<Result>(object:  -1476811264, method:  new IntPtr(2818128960));
        System.Delegate val_4 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_8;
        }
        
        }
        
        val_8 = 0;
        label_8:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
        object val_5 = this.GetComponent<System.Object>();
        TheLibraryMainScreen val_6 = this.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        UnityEngine.GameObject val_7 = this.gameObject;
        this.challengeWordsTilePrefab = this;
    }
    private void OnSceneLoaded(SceneType obj)
    {
        if(WGChallengeWordsManager.IsFeatureUnlocked == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        35626999 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge != false)
        {
                return;
        }
        
        WordRegion val_4 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        this.coinPieces.Clear();
        WordRegion val_6 = WordRegion.instance;
        this.wordRegion = 0;
        System.Action val_7 = new System.Action(object:  -1476673664, method:  new IntPtr(2818253248));
        0.addOnLevelLoadCompleteAction(callback:  7454720);
        System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1476673664, method:  new IntPtr(2818258368));
        this.wordRegion.addOnWordFoundAction(callback:  7401472);
        System.Action<UnityEngine.Vector3> val_9 = new System.Action<UnityEngine.Vector3>(object:  -1476673664, method:  new IntPtr(2818263488));
        this.wordRegion.addOnHintUsedAtLocation(callback:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1476673664, method:  new IntPtr(2818268608));
        this.wordRegion.addOnLevelLoadedAction(callback:  7401472);
    }
    private void OnLevelLoaded(GameLevel gameLevel)
    {
        this.challengeWordsManager.OnLevelLoaded(gameLevel:  gameLevel);
    }
    private void OnWordRegionLoaded()
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_5;
        var val_6;
        LineWord val_7;
        if(this.challengeWordsManager.progress.inited == false)
        {
                this.challengeWordsManager.progress.inited = this.challengeWordsManager.progress;
            this.challengeWordsManager.progress.inited.InitProgress();
        }
        
        if(this.challengeWordsManager.progress._wordIndex == 1)
        {
                return;
        }
        
        if(this.challengeWordsManager.progress.inited == false)
        {
                this.challengeWordsManager.progress.inited = this.challengeWordsManager.progress;
            this.challengeWordsManager.progress.inited.InitProgress();
        }
        
        if((R6 + 12) <= this.challengeWordsManager.progress._wordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = R6 + 8;
        val_6 = 4;
        val_6 = val_6 + (this.challengeWordsManager.progress._wordIndex << 2);
        val_7 = mem[(R6 + 8 + (this.challengeWordsManager.progress._wordIndex) << 2) + 16];
        val_7 = (R6 + 8 + (this.challengeWordsManager.progress._wordIndex) << 2) + 16;
        this.word = val_7;
        goto label_9;
        label_30:
        if(val_6 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_1 = 2621443.transform;
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.challengeWordsTilePrefab, parent:  2621443);
        if(this.challengeWordsManager.progress.inited == false)
        {
                this.challengeWordsManager.progress.inited = this.challengeWordsManager.progress;
            this.challengeWordsManager.progress.inited.InitProgress();
        }
        
        if((SB + 12) <= this.challengeWordsManager.progress._wordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = SB + 8;
        val_7 = val_7 + (this.challengeWordsManager.progress._wordIndex << 2);
        if(((SB + 8 + (this.challengeWordsManager.progress._wordIndex) << 2) + 16 + 20 + 12) <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(((SB + 8 + (this.challengeWordsManager.progress._wordIndex) << 2) + 16 + 20 + 8 + 16 + 36) != 0)
        {
                this.challengeWordsTilePrefab.SetActive(value:  false);
        }
        
        val_5 = this.coinPieces;
        val_5.Add(item:  this.challengeWordsTilePrefab);
        val_7 = this.word;
        val_6 = 5;
        label_9:
        if((val_6 - 4) < val_5)
        {
            goto label_30;
        }
        
        if((this.challengeWordsManager.<hasShowChallengeFTUX>k__BackingField) != false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void OnWordRegionWordFound(string wordCompleted)
    {
        int val_6;
        WGChallengeWordsManager val_9;
        var val_10;
        var val_11;
        val_9 = this.challengeWordsManager;
        if(val_9.IsPlaying == false)
        {
                return;
        }
        
        val_9 = this.word;
        if(val_9 == 0)
        {
                return;
        }
        
        val_10 = 0;
        bool val_3 = System.String.op_Equality(a:  this.word.answer, b:  wordCompleted);
        if(val_3 == true)
        {
            goto label_7;
        }
        
        return;
        label_13:
        if(val_3 <= val_10)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + 0;
        (0 + 0) + 16.SetActive(value:  false);
        val_11 = 1;
        label_7:
        if(val_11 < ((0 + 0) + 16))
        {
            goto label_13;
        }
        
        Player val_4 = App.Player;
        decimal val_5 = System.Decimal.op_Implicit(value:  -1476151960);
        val_9 = "Challenge Word Reward";
        0.AddCredits(amount:  new System.Decimal() {mid = val_6}, source:  val_9, subSource:  0, externalParams:  0, doTrack:  true);
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2144143840);
        Player val_8 = App.Player;
        0.SaveState();
        this.challengeWordsManager.CompleteChallenge();
    }
    private void OnWordRegionHintUsed(UnityEngine.Vector3 location)
    {
        var val_6;
        bool val_1 = this.challengeWordsManager.IsPlaying;
        if(val_1 == false)
        {
                return;
        }
        
        val_6 = 4;
        goto label_3;
        label_20:
        if(val_1 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_2 = UnityEngine.Object.op_Inequality(x:  location.x + 16, y:  0);
        if(val_2 != false)
        {
                if(val_2 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Transform val_3 = 2621443.transform;
            UnityEngine.Vector3 val_4 = position;
            bool val_5 = UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3(), rhs:  new UnityEngine.Vector3() {x = location.x, y = location.y, z = location.z});
            if(val_5 != false)
        {
                if(val_5 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            2621443.SetActive(value:  false);
        }
        
        }
        
        val_6 = 5;
        label_3:
        if((val_6 - 4) < 2621443)
        {
            goto label_20;
        }
    
    }
    public WGChallengeWordsUI()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.coinPieces = null;
    }

}
