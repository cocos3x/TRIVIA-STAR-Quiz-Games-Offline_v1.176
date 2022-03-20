using UnityEngine;
public class WordDropManager : MonoSingleton<WordDropManager>
{
    // Fields
    public UnityEngine.UI.Button failButton;
    public UnityEngine.UI.Button addLifeButton;
    private WordDropController wordDropController;
    private SLC.Minigames.WordDrop.IceCreamController iceCreamController;
    private int playerLives;
    private System.Collections.Generic.List<string[]> parsedWordData;
    private RandomSet randomSet;
    private float levelSpeed;
    private bool init;
    private bool isPaused;
    private int playerScoops;
    
    // Properties
    public WordDropController GetWordDropController { get; }
    public SLC.Minigames.WordDrop.IceCreamController GetIceCreamController { get; }
    public bool IsPaused { get; }
    public int PlayerScoops { get; }
    public float LevelSpeed { get; }
    
    // Methods
    public WordDropController get_GetWordDropController()
    {
    
    }
    public SLC.Minigames.WordDrop.IceCreamController get_GetIceCreamController()
    {
    
    }
    public bool get_IsPaused()
    {
        return (bool)this.isPaused;
    }
    public int get_PlayerScoops()
    {
        return (int)this.playerScoops;
    }
    public void AddScoop()
    {
        int val_2 = this.playerScoops;
        val_2 = val_2 + 1;
        this.playerScoops = val_2;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateScoopsDisplay(updatedScoops:  this.playerScoops);
    }
    public float get_LevelSpeed()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_2 = 5.5f;
        val_2 = 1065346600 * val_2;
        return (float)val_2;
    }
    public override void InitMonoSingleton()
    {
        this.Initialize();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1737192144, method:  new IntPtr(2557740912));
        this.failButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1737192144, method:  new IntPtr(2557750128));
        this.addLifeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void Initialize()
    {
        var val_10;
        var val_11;
        var val_12;
        if(this.init != false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_2 = new System.Action(object:  -1737060688, method:  new IntPtr(2557879536));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
        val_10 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_7;
        }
        
        }
        
        val_10 = 0;
        label_7:
        public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_10;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_5 = new System.Action(object:  -1737060688, method:  new IntPtr(2557880560));
        System.Delegate val_6 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, b:  7454720);
        val_11 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
        if(val_11 != 0)
        {
                if(val_11 == null)
        {
            goto label_11;
        }
        
        }
        
        val_11 = 0;
        label_11:
        public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_11;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_8 = new System.Action(object:  -1737060688, method:  new IntPtr(2557881584));
        System.Delegate val_9 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C, b:  7454720);
        val_12 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C;
        if(val_12 != 0)
        {
                if(val_12 == null)
        {
            goto label_15;
        }
        
        }
        
        val_12 = 0;
        label_15:
        public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C = val_12;
        this.init = true;
    }
    private void Start()
    {
        var val_7;
        twelvegigs.sweepstakes.Distribution val_11;
        WordDropManager val_15;
        var val_16;
        var val_17;
        var val_18;
        val_15 = this;
        this.isPaused = false;
        object val_1 = UnityEngine.Resources.Load<System.Object>(path:  -1736971664);
        string val_2 = text;
        object val_3 = MiniJSON.Json.Deserialize(json:  -1736971664);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.parsedWordData = null;
        if(("minigames/worddrop/word_data") != 0)
        {
                if(null == null)
        {
            goto label_35;
        }
        
        }
        
        if(("minigames/worddrop/word_data") != 0)
        {
                label_35:
        }
        
        val_16 = 0;
        List.Enumerator<T> val_5 = GetEnumerator();
        var val_15 = 0;
        label_24:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_7 != 0)
        {
                val_17 = null;
        }
        
        if(val_7 != 0)
        {
                val_17 = null;
            val_18 = 0;
            val_15 = val_15;
            if(((val_7 + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_17)
        {
                val_7 = 0;
        }
        
            val_18 = val_7;
        }
        else
        {
                val_18 = 0;
        }
        
        List.Enumerator<T> val_9 = GetEnumerator();
        label_18:
        if(MoveNext() == false)
        {
            goto label_15;
        }
        
        Add(item:  val_11);
        goto label_18;
        label_15:
        val_15 = val_15 + 1;
        mem2[0] = 122;
        Dispose();
        if(val_15 != 1)
        {
                if(val_15 > 1)
        {
                0 = 1;
        }
        
            var val_16 = -1736941208 + ((0 + 1)) << 2;
            val_16 = val_16 - 122;
            val_16 = val_16 >> 5;
            val_16 = 1 & val_16;
            val_15 = val_15 - val_16;
        }
        
        T[] val_12 = ToArray();
        this.parsedWordData.Add(item:  80883712);
        goto label_24;
        label_8:
        Dispose();
        this.randomSet.addIntRange(lowest:  0, highest:  this.parsedWordData - 1);
        this.isPaused = false;
        this.iceCreamController.Init(reset:  true);
        this.playerLives = 3;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateLivesDisplay(updatedLives:  this.playerLives);
    }
    public string[] GetNextLevelData()
    {
        if(this.randomSet.remainingCount() == 0)
        {
                this.randomSet.reset();
        }
        
        int val_2 = this.randomSet.roll(unweighted:  false);
        if(val_2 <= val_2)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (val_2 << 2);
    }
    private void ResetLevel()
    {
        this.isPaused = false;
    }
    private void AddLife()
    {
        int val_2 = this.playerLives;
        val_2 = val_2 + 1;
        this.playerLives = val_2;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateLivesDisplay(updatedLives:  this.playerLives);
    }
    private void OnContinue()
    {
        this.iceCreamController.DeleteWordScoops();
        this.playerLives = 3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateLivesDisplay(updatedLives:  this.playerLives);
        this.isPaused = false;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WordDropUIController MonoSingleton<WordDropUIController>::get_Instance().__il2cppRuntimeField_C.enabled = true;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WordDropFTUXManager MonoSingleton<WordDropFTUXManager>::get_Instance().__il2cppRuntimeField_20) != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        R6.RestartFTUX();
    }
    private void OnCheckpointRankContinue()
    {
        this.isPaused = false;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WordDropUIController MonoSingleton<WordDropUIController>::get_Instance().__il2cppRuntimeField_C.enabled = true;
    }
    public void HandleFail()
    {
        int val_6 = this.playerLives;
        val_6 = val_6 - 1;
        this.playerLives = val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateScoopsDisplay(updatedScoops:  this.playerScoops);
        this.iceCreamController.DeleteWordScoops();
        if(this.playerLives > 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateLivesDisplay(updatedLives:  this.playerLives);
            return;
        }
        
        this.isPaused = true;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_4 = HandleLevelFailed();
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WordDropUIController MonoSingleton<WordDropUIController>::get_Instance().__il2cppRuntimeField_C.enabled = false;
    }
    public void HandlePause()
    {
        bool val_1 = this.isPaused;
        val_1 = val_1 ^ 1;
        this.isPaused = val_1;
    }
    public void HandleLevelComplete()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = HandleLevelComplete();
        if(val_2 == true)
        {
                val_2 = true;
            this.isPaused = val_2;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateUI();
    }
    public WordDropManager()
    {
        this.randomSet = new RandomSet();
    }

}
