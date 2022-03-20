using UnityEngine;

namespace WordPets
{
    public class WPTGameUIController : MonoSingleton<WordPets.WPTGameUIController>
    {
        // Fields
        private const int MAX_LETTERS = 9;
        private const int MIN_LETTERS = 3;
        public const int MAX_COLUMNS = 7;
        public static bool HACK_InstantFailEscape;
        private UnityEngine.GameObject WPTColumn;
        private UnityEngine.GameObject WPTTile;
        private UnityEngine.GameObject WPTPetTile;
        private UnityEngine.Transform columnParent;
        private UnityEngine.CanvasGroup topUICG;
        private UnityEngine.CanvasGroup hintCG;
        private UnityEngine.CanvasGroup progressCG;
        private UnityEngine.GameObject freeCoinsButton;
        private UnityEngine.GameObject howToPlayButton;
        private UnityEngine.UI.Image levelProgressBar;
        private UnityEngine.UI.Text levelProgressText;
        private UnityEngine.UI.Image levelProgressRefillIcon;
        private UnityEngine.UI.Button levelProgressButton;
        private UnityEngine.GameObject levelProgressObject;
        private UnityEngine.GameObject levelProgressRays;
        private UnityEngine.UI.Text petsRemainingText;
        private UnityEngine.Transform petEscapeTransform;
        private UnityEngine.Transform petCaptureTransform;
        private UnityEngine.Transform petAnimationTransform;
        private WordPets.WPTMessageBanner messageBanner;
        private UnityEngine.GameObject tutorialLevelTwoDescription;
        private UnityEngine.Sprite[] tileSprites;
        private UnityEngine.Font[] tileFonts;
        private WordPets.WPTButterfly butterflyPrefab;
        private UnityEngine.Transform butterflySpawnTransform;
        private System.Collections.Generic.List<WordPets.WPTGameColumn> <currentColumns>k__BackingField;
        private System.Collections.Generic.List<WordPets.WPTLetterTile> currentSelectedTiles;
        private System.Collections.Generic.List<WordPets.WPTButterfly> freeButterflies;
        private int[] butterflyCharCount;
        private WordPets.WPTWordDisplay myDisplay;
        private UnityEngine.UI.Button submitButton;
        private UnityEngine.GameObject submitTick;
        private UnityEngine.GameObject submitButterfly;
        private WordPets.WPTBoulderActor prefabBoulder;
        private UnityEngine.CanvasGroup mainLayoutCanvasGroup;
        private MultiGraphicButton buttonRetry;
        private UnityEngine.UI.Text buttonRetryLabel;
        private MultiGraphicButton buttonRefresh;
        private UnityEngine.GameObject buttonRefreshCoinIcon;
        private UnityEngine.UI.Text buttonRefreshLabel;
        private MultiGraphicButton buttonAddColumn;
        private UnityEngine.GameObject buttonAddColumnCoinIcon;
        private UnityEngine.UI.Text buttonAddColumnLabel;
        private MultiGraphicButton buttonWordHint;
        private UnityEngine.GameObject buttonWordHintCoinIcon;
        private UnityEngine.UI.Text buttonWordHintLabel;
        private WordPets.WPTLevelData <currentData>k__BackingField;
        private bool <initilizing>k__BackingField;
        private WordPets.WPTGameMode gamemode;
        private bool inFTUX;
        private bool processingPetAnimation;
        private bool isPlaying;
        private bool isValidWordSelected;
        private bool <isTileRefillActive>k__BackingField;
        private DG.Tweening.Tween delayShowFtuxTween;
        private System.Collections.Generic.List<char> vowls;
        private char[] vowl;
        public System.Action OnLevelCreated;
        public System.Action OnPlayerTurnComplete;
        public System.Action<bool> OnTileRefillStateChanged;
        private bool doneItBefore;
        
        // Properties
        public UnityEngine.GameObject LevelProgressObject { get; }
        public UnityEngine.Transform EscapeTransform { get; }
        public UnityEngine.Transform CaptureTransform { get; }
        public UnityEngine.Sprite[] TileSprites { get; }
        public UnityEngine.Font[] TileFonts { get; }
        public System.Collections.Generic.List<WordPets.WPTGameColumn> currentColumns { get; set; }
        public WordPets.WPTWordDisplay WordDisplay { get; }
        public UnityEngine.UI.Button SubmitButton { get; }
        public WordPets.WPTLevelData currentData { get; set; }
        public WordPets.WPTLevelData backupData { get; }
        public bool initilizing { get; set; }
        public bool isTileRefillActive { get; set; }
        public static int HintsUsed { get; set; }
        public static int NewColumnsUsed { get; set; }
        public static int ShufflesUsed { get; set; }
        private static int EasyLettersMaxLevel { get; }
        public static bool UseEasyLetters { get; }
        
        // Methods
        public UnityEngine.GameObject get_LevelProgressObject()
        {
        
        }
        public UnityEngine.Transform get_EscapeTransform()
        {
        
        }
        public UnityEngine.Transform get_CaptureTransform()
        {
        
        }
        public UnityEngine.Sprite[] get_TileSprites()
        {
        
        }
        public UnityEngine.Font[] get_TileFonts()
        {
        
        }
        public System.Collections.Generic.List<WordPets.WPTGameColumn> get_currentColumns()
        {
        
        }
        protected void set_currentColumns(System.Collections.Generic.List<WordPets.WPTGameColumn> value)
        {
            this.<currentColumns>k__BackingField = value;
        }
        public WordPets.WPTWordDisplay get_WordDisplay()
        {
        
        }
        public UnityEngine.UI.Button get_SubmitButton()
        {
        
        }
        public WordPets.WPTLevelData get_currentData()
        {
        
        }
        private void set_currentData(WordPets.WPTLevelData value)
        {
            this.<currentData>k__BackingField = value;
        }
        public WordPets.WPTLevelData get_backupData()
        {
            if(this.gamemode != 0)
            {
                    return;
            }
        
        }
        public bool get_initilizing()
        {
            return (bool)this.<initilizing>k__BackingField;
        }
        public void set_initilizing(bool value)
        {
            this.<initilizing>k__BackingField = value;
        }
        public bool get_isTileRefillActive()
        {
            return (bool)this.<isTileRefillActive>k__BackingField;
        }
        private void set_isTileRefillActive(bool value)
        {
            this.<isTileRefillActive>k__BackingField = value;
        }
        public static int get_HintsUsed()
        {
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            if(0 != 0)
            {
                    return 1919184449;
            }
            
            return 1919184449;
        }
        public static void set_HintsUsed(int value)
        {
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            mem2[0] = value;
        }
        public static int get_NewColumnsUsed()
        {
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            if(0 != 0)
            {
                    return 132;
            }
            
            return 132;
        }
        public static void set_NewColumnsUsed(int value)
        {
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            mem2[0] = value;
        }
        public static int get_ShufflesUsed()
        {
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            if(0 != 0)
            {
                    return 1;
            }
            
            return 1;
        }
        public static void set_ShufflesUsed(int value)
        {
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            mem2[0] = value;
        }
        private static int get_EasyLettersMaxLevel()
        {
            GameEcon val_1 = App.getGameEcon;
            if(0 != 0)
            {
                    return 786450;
            }
            
            return 786450;
        }
        public static bool get_UseEasyLetters()
        {
            Player val_1 = App.Player;
            if(0 <= WordPets.WPTGameUIController.EasyLettersMaxLevel)
            {
                    0 = 1;
            }
            
            return true;
        }
        private void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  165487008, method:  new IntPtr(165432288));
            public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_28.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  165487008, method:  new IntPtr(165437408));
            this.buttonRetry.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  165487008, method:  new IntPtr(165442528));
            this.buttonRefresh.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  165487008, method:  new IntPtr(165447648));
            this.buttonAddColumn.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  165487008, method:  new IntPtr(165452768));
            this.buttonWordHint.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  165487008, method:  new IntPtr(165461984));
            this.levelProgressButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnDestroy()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2119322896 != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                1152921504901095424 = null;
                1152921504901095424 = new UnityEngine.Events.UnityAction(object:  165627680, method:  new IntPtr(165432288));
                public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_28.RemoveListener(call:  162246656);
            }
            
            if(this.delayShowFtuxTween == 0)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.delayShowFtuxTween, complete:  false);
            this.delayShowFtuxTween = 0;
        }
        private void OnWindowClosed()
        {
            var val_8;
            var val_9;
            DG.Tweening.TweenCallback val_11;
            if(this.isPlaying == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(GetActiveAndQueuedWindowCount() > 0)
            {
                    return;
            }
            
            if(WordPetsFTUXDemoWindow.CanShow() == false)
            {
                    return;
            }
            
            val_8 = 1152921505005568000;
            val_9 = null;
            val_9 = null;
            val_11 = WPTGameUIController.<>c.<>9__107_0;
            if(val_11 == 0)
            {
                    val_11 = null;
                val_11 = new DG.Tweening.TweenCallback(object:  WPTGameUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(165719776));
                WPTGameUIController.<>c.<>9__107_0 = val_11;
            }
            
            DG.Tweening.Tween val_5 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1036831949, ignoreTimeScale:  false);
            mem2[0] = 1036831949;
        }
        public void SkipFTUX()
        {
            var val_4;
            System.Collections.Generic.List<WordPets.WordPetType> val_5;
            val_4 = 4;
            goto label_1;
            label_13:
            if(true <= R6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_1 = 2621443.HasPet();
            if(val_1 != false)
            {
                    if(val_1 <= R6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                WordPets.WPTPetTile val_2 = 2621443.GetPetTile();
                this.gamemode.AddPetCaptured(newPet:  mem[406891540]);
            }
            
            val_4 = 5;
            label_1:
            val_5 = val_4 - 4;
            if(val_5 < this.gamemode)
            {
                goto label_13;
            }
            
            goto label_14;
            label_20:
            WordPets.WordPet val_3 = this.gamemode.GetNextPet();
            val_5 = this.gamemode.petsCapturedList;
            this.gamemode.AddPetCaptured(newPet:  val_5);
            label_14:
            if(this.gamemode > 0)
            {
                goto label_20;
            }
            
            this.OnGameEnded(didPlayerWin:  true, loseCondition:  0);
        }
        private void OnGameEnded(bool didPlayerWin, WordPets.LoseCondition loseCondition = 0)
        {
            var val_9;
            this.isPlaying = false;
            if(didPlayerWin != false)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                Add(key:  -1643554480, value:  8945664);
                WordPets.WPTPlayer val_2 = WordPets.WPTPlayer.Instance;
                Add(key:  -487709424, value:  13152256);
                WordPets.WPTPlayer val_3 = WordPets.WPTPlayer.Instance;
                Add(key:  166014432, value:  13152256);
                WordPets.WPTPlayer val_4 = WordPets.WPTPlayer.Instance;
                Add(key:  166014544, value:  13152256);
                var val_9 = 22716526;
                val_9 = 12909012 + val_9;
                if(val_9 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_9 = null;
                val_9 = null;
                App.trackerManager.track(eventName:  -1942299264, data:  78753792);
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
            Setup(loseCond:  loseCondition);
        }
        public void Init(WordPets.WPTLevelData incData)
        {
            var val_30;
            var val_31;
            var val_33;
            var val_34;
            var val_36;
            var val_37;
            var val_39;
            var val_40;
            this.<currentData>k__BackingField = incData;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WPTGameMode val_2 = currentGame;
            this.gamemode = public static WordPets.WordPetsController MonoSingleton<WordPets.WordPetsController>::get_Instance();
            if((public static WordPets.WordPetsController MonoSingleton<WordPets.WordPetsController>::get_Instance().__il2cppRuntimeField_1C + 12) > 0)
            {
                    0 = 1;
            }
            
            this.<isTileRefillActive>k__BackingField = true;
            this.StopAllCoroutines();
            this.<initilizing>k__BackingField = true;
            this.myDisplay.DeselectAllTiles();
            this.myDisplay.StopAllCoroutines();
            this.processingPetAnimation = false;
            System.Collections.IEnumerator val_3 = this.CoolInit();
            UnityEngine.Coroutine val_4 = this.myDisplay.StartCoroutine(routine:  166264576);
            if(this == 0)
            {
                    this.vowls.AddRange(collection:  this.vowl);
            }
            
            this.tutorialLevelTwoDescription.SetActive(value:  ((this.<currentData>k__BackingField.<level>k__BackingField) - 2) >> 5);
            WordPets.WPTGameEcon val_7 = WordPets.WPTGameEcon.Instance;
            WordPets.WPTDataParser val_8 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            this.freeCoinsButton.SetActive(value:  VideoEnabledAndUnlocked());
            val_30 = 0;
            Player val_10 = App.Player;
            if(0 >= 0)
            {
                    Player val_11 = App.Player;
                if(0 < 4)
            {
                    val_30 = 1;
            }
            
            }
            
            this.howToPlayButton.SetActive(value:  true);
            decimal val_12 = PowerupCostRefresh;
            val_31 = null;
            val_31 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    decimal val_14 = PowerupCostRefresh;
                string val_15 = ToString();
                val_33;
            }
            else
            {
                    val_33 = "REFRESH";
            }
            
            decimal val_16 = PowerupCostRefresh;
            val_34 = null;
            val_34 = null;
            this.buttonRefreshCoinIcon.SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
            decimal val_18 = PowerupCostAddColumn;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
            {
                    decimal val_20 = PowerupCostAddColumn;
                string val_21 = ToString();
                val_36;
            }
            else
            {
                    val_36 = "FREE";
            }
            
            decimal val_22 = PowerupCostAddColumn;
            val_37 = null;
            val_37 = null;
            this.buttonAddColumnCoinIcon.SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
            decimal val_24 = PowerupCostWordHint;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
            {
                    decimal val_26 = PowerupCostWordHint;
                string val_27 = ToString();
                val_39;
            }
            else
            {
                    val_39 = "HINT";
            }
            
            decimal val_28 = PowerupCostWordHint;
            val_40 = null;
            val_40 = null;
            this.buttonWordHintCoinIcon.SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
        }
        private System.Collections.IEnumerator CoolInit()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<CoolInit>d__111).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<CoolInit>d__111).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator ClearCurrentGrid()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<ClearCurrentGrid>d__112).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<ClearCurrentGrid>d__112).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator GenerateNewGrid()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<GenerateNewGrid>d__113).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<GenerateNewGrid>d__113).__il2cppRuntimeField_10 = this;
        }
        public WordPets.WPTGameColumn AddNewCol(WordPets.ColData data)
        {
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.WPTColumn, parent:  this.columnParent);
            object val_2 = this.WPTColumn.GetComponent<System.Object>();
            object val_3 = this.WPTTile.GetComponent<System.Object>();
            UnityEngine.Vector2 val_4 = sizeDelta;
            this.WPTColumn.Init(tileHeight:  UnityEngine.Mathf.FloorToInt(f:  val_4.x), data:  data);
            this.<currentColumns>k__BackingField.Insert(index:  data.<Id>k__BackingField, item:  this.WPTColumn);
            UnityEngine.Transform val_7 = this.WPTColumn.transform;
            this.WPTColumn.SetSiblingIndex(index:  data.<Id>k__BackingField);
        }
        public System.Collections.IEnumerator AddLettersToColumn(WordPets.WPTGameColumn column, System.Collections.Generic.List<char> characters, bool isInitialPopulation = False)
        {
            typeof(WPTGameUIController.<AddLettersToColumn>d__115).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WPTGameUIController.<AddLettersToColumn>d__115).__il2cppRuntimeField_10 = column;
                typeof(WPTGameUIController.<AddLettersToColumn>d__115).__il2cppRuntimeField_14 = this;
                typeof(WPTGameUIController.<AddLettersToColumn>d__115).__il2cppRuntimeField_1C = characters;
            }
            else
            {
                    mem[20] = this;
                mem[16] = column;
                mem[28] = characters;
            }
            
            typeof(WPTGameUIController.<AddLettersToColumn>d__115).__il2cppRuntimeField_20 = isInitialPopulation;
        }
        public System.Collections.IEnumerator AddPetToColumn(WordPets.WPTGameColumn column, WordPets.WordPetType petType, int petMoveTimer = -1)
        {
            typeof(WPTGameUIController.<AddPetToColumn>d__116).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WPTGameUIController.<AddPetToColumn>d__116).__il2cppRuntimeField_10 = petType;
                typeof(WPTGameUIController.<AddPetToColumn>d__116).__il2cppRuntimeField_14 = this;
                typeof(WPTGameUIController.<AddPetToColumn>d__116).__il2cppRuntimeField_18 = column;
            }
            else
            {
                    mem[20] = this;
                mem[24] = column;
                mem[16] = petType;
            }
            
            typeof(WPTGameUIController.<AddPetToColumn>d__116).__il2cppRuntimeField_1C = petMoveTimer;
        }
        public void ClickTile(WordPets.WPTLetterTile tile)
        {
            if(this.processingPetAnimation == false)
            {
                    this.processingPetAnimation = this.<initilizing>k__BackingField;
                goto label_1;
            }
            
            return;
            label_1:
            if(WPTHintPickerPopup.IsShowing != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                DoPowerupPreview(clickedTile:  tile);
                return;
            }
            
            if(tile.IsSelectable() == false)
            {
                    return;
            }
            
            if((this.currentSelectedTiles.Contains(item:  tile)) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayButtonSound(type:  0, pitch:  null, vol:  null);
                this.DeselectTile(tile:  tile);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayButtonSound(type:  0, pitch:  UnityEngine.Random.Range(min:  null, max:  null), vol:  null);
            this.SelectTile(tile:  tile);
        }
        private void ToggleTileSelectionVisualState(WordPets.WPTLetterTile tile, bool isSelected, bool skipAnimation = False)
        {
            if(tile != 0)
            {
                    tile.<Selected>k__BackingField = isSelected;
                tile.ToggleSelection(isSelected:  isSelected);
            }
            else
            {
                    mem[136] = isSelected;
                0.ToggleSelection(isSelected:  isSelected);
            }
            
            tile.OverrideSort(overrideSort:  isSelected);
            if(isSelected != false)
            {
                    this.myDisplay.AddingTile(tile:  tile, skipAnimation:  skipAnimation);
                return;
            }
            
            this.myDisplay.RemovingTile(tile:  tile, skipAnimation:  skipAnimation);
        }
        private void SelectTile(WordPets.WPTLetterTile tile)
        {
            char val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = tile.myCharacter;
            bool val_2 = System.Char.IsLetter(c:  val_9);
            if(val_2 == false)
            {
                    return;
            }
            
            val_9 = this.currentSelectedTiles;
            if(val_2 == true)
            {
                    return;
            }
            
            if(this.inFTUX == false)
            {
                goto label_7;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = GetWindow<System.Object>();
            val_10 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            val_11 = 0;
            UnityEngine.Transform val_5 = tile.transform;
            if(val_10 != 0)
            {
                    val_12 = null;
                val_12 = null;
                val_11 = 0;
                if(((as. 
               
               
              
            
            
            
            .__il2cppRuntimeField_64 + (WordPetsFTUXDemoWindow.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_12)
            {
                    val_10 = 0;
            }
            
                val_11 = val_10;
            }
            
            if((val_11.Proceed(target:  tile)) == false)
            {
                goto label_16;
            }
            
            label_7:
            this.currentSelectedTiles.Add(item:  tile);
            this.ToggleTileSelectionVisualState(tile:  tile, isSelected:  true, skipAnimation:  false);
            this.CheckWord();
            return;
            label_16:
            tile.Shake();
        }
        public void DeselectTile(WordPets.WPTLetterTile tile)
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<>c__DisplayClass120_0).__il2cppRuntimeField_8 = tile;
            if(this.inFTUX != false)
            {
                    tile.Shake();
                return;
            }
            
            System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  399093760, method:  new IntPtr(167602240));
            this.DeselectTile(selectionIndex:  this.currentSelectedTiles.FindIndex(match:  8040448), deselectSubsequent:  true, dontAnimate:  false);
        }
        private void DeselectTile(int selectionIndex, bool deselectSubsequent, bool dontAnimate = False)
        {
            int val_11;
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<>c__DisplayClass121_0).__il2cppRuntimeField_8 = this;
            if(val_1 <= selectionIndex)
            {
                    return;
            }
            
            this.processingPetAnimation = true;
            System.Action val_2 = new System.Action(object:  399147008, method:  new IntPtr(167729600));
            typeof(WPTGameUIController.<>c__DisplayClass121_0).__il2cppRuntimeField_C = null;
            if(dontAnimate != true)
            {
                    DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
                object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  0, ease:  7);
                DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  399147008, method:  new IntPtr(167730624));
                object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
            }
            
            val_11 = selectionIndex;
            if(deselectSubsequent == false)
            {
                goto label_7;
            }
            
            val_11 = 0 - 1;
            label_16:
            if(val_11 < selectionIndex)
            {
                goto label_9;
            }
            
            label_7:
            typeof(WPTGameUIController.<>c__DisplayClass121_1).__il2cppRuntimeField_C = val_1;
            if(new System.Object() <= val_11)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (val_11 << 2);
            typeof(WPTGameUIController.<>c__DisplayClass121_1).__il2cppRuntimeField_8 = (0 + ((0 - 1)) << 2) + 16;
            this.currentSelectedTiles.RemoveAt(index:  val_11);
            if(dontAnimate != false)
            {
                    this.ToggleTileSelectionVisualState(tile:  typeof(WPTGameUIController.<>c__DisplayClass121_1).__il2cppRuntimeField_8, isSelected:  false, skipAnimation:  true);
            }
            else
            {
                    DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  399200256, method:  new IntPtr(167744960));
                DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
                DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            }
            
            val_11 = val_11 - 1;
            goto label_16;
            label_9:
            this.isValidWordSelected = false;
            if(dontAnimate == false)
            {
                    return;
            }
            
            Invoke();
        }
        public void DeselectAllTiles()
        {
            this.DeselectTile(selectionIndex:  0, deselectSubsequent:  true, dontAnimate:  true);
        }
        private void CheckWord()
        {
            var val_8;
            if(true <= 2)
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_1 = null;
            val_8 = 0;
            val_1 = new System.Text.StringBuilder();
            goto label_3;
            label_9:
            if(val_1 <= val_8)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + 0;
            System.Text.StringBuilder val_2 = Append(value:  (0 + 0) + 16);
            val_8 = 1;
            label_3:
            if(val_8 < val_1)
            {
                goto label_9;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = ToUpper();
            bool val_5 = IsWord(wordToCheck:  24121344);
            UnityEngine.GameObject val_6 = this.submitButton.gameObject;
            this.submitButton.SetActive(value:  val_5);
            this.isValidWordSelected = val_5;
            return;
            label_2:
            UnityEngine.GameObject val_7 = this.submitButton.gameObject;
            this.submitButton.SetActive(value:  false);
        }
        public void OnSubmitButtonClicked()
        {
            this.processingPetAnimation = true;
            UnityEngine.GameObject val_1 = this.submitButton.gameObject;
            this.submitButton.SetActive(value:  false);
            System.Collections.IEnumerator val_2 = this.SubmitCoroutine();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  168167424);
            if(this.inFTUX == false)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_4 = this.inFTUX.ProceedTutorial(delay:  null);
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.inFTUX);
        }
        private System.Collections.IEnumerator ProceedTutorial(float delay)
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<ProceedTutorial>d__125).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<ProceedTutorial>d__125).__il2cppRuntimeField_10 = R1;
        }
        private System.Collections.IEnumerator SubmitCoroutine()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<SubmitCoroutine>d__126).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<SubmitCoroutine>d__126).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator DoEndOfTurnGridResolution(bool decrementPetTimer)
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<DoEndOfTurnGridResolution>d__127).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<DoEndOfTurnGridResolution>d__127).__il2cppRuntimeField_10 = this;
        }
        private void DoPlayerTurnComplete()
        {
            bool val_2 = this.GetTilesWithSelectableLetters(tilesWithProperty: out  System.Collections.Generic.List<WordPets.WPTGameTile> val_1 = 168627964);
            if(0 > 2)
            {
                    0 = 1;
            }
            
            this.buttonRefresh.interactable = true;
            if(0 > 2)
            {
                    0 = 1;
            }
            
            this.buttonWordHint.interactable = true;
            if((this.<currentColumns>k__BackingField) < 7)
            {
                    0 = 1;
            }
            
            this.buttonAddColumn.interactable = (this.HasEmptiedColumns(colIndexesEmptied: out  System.Collections.Generic.List<System.Int32> val_3 = 168627960)) | 1;
            if(this.OnPlayerTurnComplete != 0)
            {
                    this.OnPlayerTurnComplete.Invoke();
            }
            
            this.DoLevelAnswerNotification();
        }
        private void DoLevelAnswerNotification()
        {
            var val_19;
            var val_20;
            var val_21;
            System.Func<WordPets.WPTGameColumn, System.Int32> val_23;
            var val_24;
            var val_25;
            System.Func<WordPets.WPTGameColumn, System.Boolean> val_27;
            var val_28;
            var val_29;
            val_19 = this;
            WGGenericNotificationsManager.CancelLevelAnswerNotification();
            if(WGGenericNotificationsManager.levelAnswerEnabled == false)
            {
                    return;
            }
            
            val_20 = 1152921505005568000;
            val_21 = null;
            val_21 = null;
            val_23 = WPTGameUIController.<>c.<>9__129_0;
            if(val_23 == 0)
            {
                    val_23 = null;
                val_23 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WPTGameUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(168752576));
                WPTGameUIController.<>c.<>9__129_0 = val_23;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_2 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this.<currentColumns>k__BackingField, keySelector:  7720960);
            val_25 = null;
            val_25 = null;
            val_27 = WPTGameUIController.<>c.<>9__129_1;
            if(val_27 == 0)
            {
                    val_27 = null;
                val_27 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WPTGameUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(168755648));
                WPTGameUIController.<>c.<>9__129_1 = val_27;
            }
            
            object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.<currentColumns>k__BackingField, predicate:  7720960);
            if((this.<currentColumns>k__BackingField) == 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<WordPets.WPTLetterTile> val_8 = this.<currentColumns>k__BackingField.GetLetterTiles();
            AddRange(collection:  this.<currentColumns>k__BackingField);
            val_28 = 4;
            var val_12 =  - 4;
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_19 = 1152921504984215552;
            System.Int32[] val_14 = this.gamemode.GetCharCount(includeSpiderWebTiles:  false);
            val_24 = new System.Object();
            string val_15 = TryWordHint(charCountPlayerSelected:  478302960, charCountEntirePool:  this.gamemode);
            val_29 = public static WPTWordList MonoSingleton<WPTWordList>::get_Instance();
            if(val_24 != 0)
            {
                    val_20 = val_24;
                typeof(WPTGameUIController.<>c__DisplayClass129_0).__il2cppRuntimeField_8 = val_29;
            }
            else
            {
                    val_20 = 8;
                mem[8] = val_29;
                val_29 = mem[8];
            }
            
            if((System.String.IsNullOrEmpty(value:  145162912)) == true)
            {
                    return;
            }
            
            System.Collections.Generic.List<WordPets.WPTLetterTile> val_17 = this.<currentColumns>k__BackingField.GetLetterTiles();
            System.Predicate<ZooTile> val_18 = new System.Predicate<ZooTile>(object:  399413248, method:  new IntPtr(168763840));
            if((this.<currentColumns>k__BackingField.Exists(match:  8040448)) == false)
            {
                    return;
            }
            
            WGGenericNotificationsManager.SendLevelAnwserNotification(nextWord:  145162912, QAHACK_Force:  false);
        }
        private System.Collections.Generic.List<char> GetSolvableRandomLetters(int qtyOfLetters, bool ignoreExistingGridLetters = False)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_14 = this;
            if(ignoreExistingGridLetters == false)
            {
                goto label_1;
            }
            
            goto label_2;
            label_1:
            val_15 = 0;
            goto label_3;
            label_18:
            if(1152921505085149948 <= val_15)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + 0;
            System.Collections.Generic.List<WordPets.WPTLetterTile> val_1 = (0 + 0) + 16.GetLetterTiles();
            val_16 = 4;
            goto label_7;
            label_16:
            if(((0 + 0) + 16) <= R5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(((0 + 0) + 16 + 8 + 16.IsSelectable()) != false)
            {
                    if(((0 + 0) + 16 + 12) <= R5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_4 = null + ((WordPets.WPTGameMode.GetLowerCharIndex(character:  (0 + 0) + 16 + 8 + 16)) << 2);
                var val_16 = (null + (val_3) << 2) + 16;
                val_16 = val_16 + 1;
                mem2[0] = val_16;
            }
            
            val_16 = 5;
            label_7:
            if((val_16 - 4) < ((0 + 0) + 16 + 12))
            {
                goto label_16;
            }
            
            val_15 = 1;
            label_3:
            if(val_15 < ((0 + 0) + 16 + 12))
            {
                goto label_18;
            }
            
            label_2:
            System.Collections.Generic.List<System.Char> val_6 = new System.Collections.Generic.List<System.Char>(capacity:  qtyOfLetters);
            do
            {
                Clear();
                if(null != 0)
            {
                    val_17 = null;
            }
            else
            {
                    val_17 = null;
            }
            
                CopyTo(array:  478302960, index:  0);
                if(qtyOfLetters >= 1)
            {
                    if(WordPets.WPTGameUIController.UseEasyLetters != false)
            {
                    char val_9 = WordPets.LetterGetter.getRandomEasyLetter(letterOccuranceCounter:  478302960);
            }
            else
            {
                    char val_10 = WordPets.LetterGetter.getRandomLetter(letterOccuranceCounter:  478302960);
            }
            
                Add(item:  val_10);
                var val_12 = val_17 + ((WordPets.WPTGameMode.GetLowerCharIndex(character:  val_10)) << 2);
                val_14 = qtyOfLetters - 1;
                var val_17 = (val_17 + (val_11) << 2) + 16;
                val_17 = val_17 + 1;
                mem2[0] = val_17;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                string val_14 = TryFormWord(charCount:  478302960, requiredChar:  null);
                if(100 < 1)
            {
                    return;
            }
            
            }
            while((public static WPTWordList MonoSingleton<WPTWordList>::get_Instance()) == 0);
        
        }
        public bool DoAddColumnHint()
        {
            bool val_2 = this.HasEmptiedColumns(colIndexesEmptied: out  System.Collections.Generic.List<System.Int32> val_1 = 169031556);
            if(val_2 > true)
            {
                    0 = 1;
            }
            
            if((~val_2) != 1)
            {
                    return (bool)0;
            }
            
            System.Collections.IEnumerator val_3 = this.AddColumnHint();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  169043584);
            0 = 1;
            return (bool)0;
        }
        private System.Collections.IEnumerator AddColumnHint()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<AddColumnHint>d__132).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<AddColumnHint>d__132).__il2cppRuntimeField_10 = this;
        }
        private bool HasEmptiedColumns(out System.Collections.Generic.List<int> colIndexesEmptied)
        {
            System.Collections.Generic.List<System.Int32> val_2;
            var val_3;
            colIndexesEmptied = 0;
            if((0 - 1) >= 0)
            {
                    var val_2 = 0 + 3;
                do
            {
                int val_3 = val_2 - 4;
                if(0 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = mem[0 + ((0 + 3)) << 2 + 28];
                val_2 = 0 + ((0 + 3)) << 2 + 28;
                if((0 + ((0 + 3)) << 2 + 28 + 8) <= 0)
            {
                    val_2 = colIndexesEmptied;
                if(val_2 == 0)
            {
                    System.Collections.Generic.List<System.Int32> val_4 = null;
                val_2 = val_4;
                val_4 = new System.Collections.Generic.List<System.Int32>();
                colIndexesEmptied = val_2;
                if(val_2 == 0)
            {
                    val_2 = 0;
            }
            
            }
            
                val_2.Add(item:  val_3);
            }
            
                var val_5 = val_2 - 1;
            }
            while((val_2 - 5) > 1);
            
            }
            
            if(colIndexesEmptied != 0)
            {
                    if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) > 0)
            {
                    val_3 = 1;
            }
            
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        private System.Collections.IEnumerator RemoveEmptyColumns()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<RemoveEmptyColumns>d__134).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<RemoveEmptyColumns>d__134).__il2cppRuntimeField_10 = this;
        }
        public void ToggleAllUI(bool active)
        {
            this.ToggleTopUI(active:  active);
            this.ToggleHints(active:  active);
            this.ToggleProgress(active:  active);
        }
        public void ToggleTopUI(bool active)
        {
            if(active == true)
            {
                    0f = 1f;
            }
            
            this.topUICG.alpha = 1f;
            this.topUICG.interactable = active;
        }
        public void ToggleHints(bool active)
        {
            if(active == true)
            {
                    0f = 1f;
            }
            
            this.hintCG.alpha = 1f;
            this.hintCG.interactable = active;
        }
        public void ToggleProgress(bool active)
        {
            if(active == true)
            {
                    0f = 1f;
            }
            
            this.progressCG.alpha = 1f;
            this.progressCG.interactable = active;
        }
        public void DoRefreshHint()
        {
            System.Collections.IEnumerator val_1 = this.RefreshHint();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  170033632);
        }
        public System.Collections.IEnumerator RefreshHint()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<RefreshHint>d__140).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<RefreshHint>d__140).__il2cppRuntimeField_10 = this;
        }
        private void ProcessPostSubmitMechanics()
        {
            this.ClearCrateSpiderWeb();
        }
        private void ClearCrateSpiderWeb()
        {
            System.Collections.Generic.List<WordPets.WPTLetterTile> val_6;
            var val_7;
            var val_8;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<WordPets.WPTLetterTile> val_2 = this.GetAdjacentTilesUnique(originTiles:  this.currentSelectedTiles);
            val_6 = this;
            val_7 = 4;
            goto label_1;
            label_14:
            if(this <= SB)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(this.WPTColumn <= SB)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(2621443.HasSpiderWeb != false)
            {
                    2621443.HasSpiderWeb = false;
            }
            else
            {
                    if(2621443.HasCrate != false)
            {
                    if(this.WPTColumn <= SB)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                2621443.HasCrate = false;
                if(this.WPTColumn <= SB)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Add(item:  2621443);
            }
            
            }
            
            val_7 = 5;
            label_1:
            if((val_7 - 4) < this.WPTColumn)
            {
                goto label_14;
            }
            
            val_8 = 4;
            var val_7 =  - 4;
            if(null != 0)
            {
                    return;
            }
        
        }
        private System.Collections.Generic.List<WordPets.WPTLetterTile> GetAdjacentTilesUnique(System.Collections.Generic.List<WordPets.WPTLetterTile> originTiles)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            var val_37 = 0;
            label_72:
            if(val_37 >= (new System.Collections.Generic.Dictionary<System.Int32, System.Boolean>()))
            {
                    return;
            }
            
            if((new System.Collections.Generic.Dictionary<System.Int32, System.Boolean>()) <= val_37)
            {
                    var val_25 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_25 = val_25 + 0;
            var val_26 = 0;
            var val_30 = (0 + 0) + 16 + 24.Id;
            int val_4 = (0 + 0) + 16.RowIndex;
            if(val_4 >= 2)
            {
                    if(val_30 >= 1)
            {
                    int val_5 = val_30 - 1;
                if(this <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_26 = val_26 + (val_5 << 2);
                if(((0 + ((val_3 - 1)) << 2) + 16) != 0)
            {
                    if(this <= val_5)
            {
                    var val_27 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_27 = val_27 + (val_5 << 2);
                if(((0 + ((val_3 - 1)) << 2) + 16.GetLetterHeight()) > val_4)
            {
                    if(this <= val_5)
            {
                    var val_28 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_28 = val_28 + (val_5 << 2);
                if(((0 + ((val_3 - 1)) << 2) + 16 + 16 + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_29 = (0 + ((val_3 - 1)) << 2) + 16 + 16 + 8;
                val_29 = val_29 + (val_4 << 2);
                if((EnumerableExtentions.GetOrDefault<System.Int32, System.Boolean>(dic:  78753792, key:  0.GetInstanceID(), defaultValue:  false)) != true)
            {
                    Add(item:  0);
                int val_31 = 0.GetInstanceID();
                EnumerableExtentions.SetOrAdd<System.Int32, System.Boolean>(dic:  78753792, key:  val_31, newValue:  true);
            }
            
            }
            
            }
            
            }
            
                val_30 = val_30 + 1;
                if(val_30 <= 1152921504685600767)
            {
                    if(1152921504685600767 <= val_30)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_31 = val_31 + (val_30 << 2);
                bool val_11 = UnityEngine.Object.op_Inequality(x:  (val_10 + ((val_3 + 1)) << 2) + 16, y:  0);
                if(val_11 != false)
            {
                    if(val_11 <= val_30)
            {
                    var val_32 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_32 = val_32 + (val_30 << 2);
                int val_12 = (0 + ((val_3 + 1)) << 2) + 16.GetLetterHeight();
                if(val_12 > val_4)
            {
                    if(val_12 <= val_30)
            {
                    var val_33 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_33 = val_33 + (val_30 << 2);
                if(((0 + ((val_3 + 1)) << 2) + 16 + 16 + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_34 = (0 + ((val_3 + 1)) << 2) + 16 + 16 + 8;
                val_34 = val_34 + (val_4 << 2);
                if((EnumerableExtentions.GetOrDefault<System.Int32, System.Boolean>(dic:  78753792, key:  0.GetInstanceID(), defaultValue:  false)) != true)
            {
                    Add(item:  0);
                EnumerableExtentions.SetOrAdd<System.Int32, System.Boolean>(dic:  78753792, key:  0.GetInstanceID(), newValue:  true);
            }
            
            }
            
            }
            
            }
            
            }
            
            int val_16 = (0 + 0) + 16 + 24.GetLetterHeight();
            val_16 = val_16 - 1;
            if(val_4 < val_16)
            {
                    int val_17 = val_4 + 1;
                if(((0 + 0) + 16 + 24 + 16 + 12) <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_35 = (0 + 0) + 16 + 24 + 16 + 8;
                val_35 = val_35 + (val_17 << 2);
                if((EnumerableExtentions.GetOrDefault<System.Int32, System.Boolean>(dic:  78753792, key:  0.GetInstanceID(), defaultValue:  false)) != true)
            {
                    Add(item:  0);
                EnumerableExtentions.SetOrAdd<System.Int32, System.Boolean>(dic:  78753792, key:  0.GetInstanceID(), newValue:  true);
            }
            
            }
            
            if(val_4 >= 1)
            {
                    int val_21 = val_4 - 1;
                if(((0 + 0) + 16 + 24 + 16 + 12) <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_36 = (0 + 0) + 16 + 24 + 16 + 8;
                val_36 = val_36 + (val_21 << 2);
                if((EnumerableExtentions.GetOrDefault<System.Int32, System.Boolean>(dic:  78753792, key:  0.GetInstanceID(), defaultValue:  false)) != true)
            {
                    Add(item:  0);
                EnumerableExtentions.SetOrAdd<System.Int32, System.Boolean>(dic:  78753792, key:  0.GetInstanceID(), newValue:  true);
            }
            
            }
            
            val_37 = val_37 + 1;
            goto label_72;
        }
        private void UpdateProgressUI(bool skipAnimation = False)
        {
            UnityEngine.GameObject val_24;
            var val_25;
            int val_24 = this.<currentData>k__BackingField.<totalInitialPets>k__BackingField;
            float val_25 = (float)this.gamemode.PetsCaptured;
            val_24 = (this.<currentData>k__BackingField.<petsExtra>k__BackingField) + val_24;
            val_25 = val_25 / (float)val_24;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFillAmount(target:  this.levelProgressBar, endValue:  val_25, duration:  null);
            int val_3 = this.gamemode.PetsCaptured;
            int val_26 = this.<currentData>k__BackingField.<totalInitialPets>k__BackingField;
            val_26 = (this.<currentData>k__BackingField.<petsExtra>k__BackingField) + val_26;
            string val_4 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            UnityEngine.GameObject val_5 = this.levelProgressRefillIcon.gameObject;
            val_24 = this.levelProgressRefillIcon;
            if((this.<isTileRefillActive>k__BackingField) == true)
            {
                    val_25 = 1;
            }
            
            val_24.SetActive(value:  true);
            if(skipAnimation == true)
            {
                    return;
            }
            
            if(this.gamemode.PetsCaptured < 1)
            {
                    return;
            }
            
            UnityEngine.Transform val_7 = this.levelProgressObject.transform;
            UnityEngine.Transform val_8 = this.levelProgressObject.transform;
            UnityEngine.Vector3 val_9 = val_3.localPosition;
            DG.Tweening.Sequence val_10 = DG.Tweening.ShortcutExtensions.DOLocalJump(target:  this.levelProgressObject, endValue:  new UnityEngine.Vector3() {x = val_3}, jumpPower:  val_9.x, numJumps:  1097859072, duration:  val_9.y, snapping:  true);
            DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Transform val_12 = this.levelProgressRays.transform;
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelProgressRays, endValue:  val_9.x, duration:  val_9.y);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.levelProgressRays);
            val_25 = 1152921511127380480;
            object val_15 = this.levelProgressRays.GetComponent<System.Object>();
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.levelProgressRays, endValue:  val_9.x, duration:  val_9.y);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.levelProgressRays);
            val_24 = this.levelProgressRays;
            UnityEngine.Transform val_18 = val_24.transform;
            DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_24, endValue:  val_9.x, duration:  val_9.y);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_24);
            object val_21 = this.levelProgressRays.GetComponent<System.Object>();
            DG.Tweening.Tweener val_22 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.levelProgressRays, endValue:  val_9.x, duration:  val_9.y);
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.levelProgressRays);
        }
        private void UpdateRemainingPetsUI()
        {
        
        }
        private bool CheckVictory()
        {
            int val_2 = this.<currentData>k__BackingField.<totalInitialPets>k__BackingField;
            val_2 = (this.<currentData>k__BackingField.<petsExtra>k__BackingField) + val_2;
            if(this.gamemode.PetsCaptured < val_2)
            {
                    return (bool)0;
            }
            
            this.ClearPets();
            0 = 1;
            this.OnGameEnded(didPlayerWin:  true, loseCondition:  0);
            return (bool)0;
        }
        private bool CheckNoMoreWords()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Int32[] val_2 = this.gamemode.GetCharCount(includeSpiderWebTiles:  false);
            string val_3 = TryFormWord(charCount:  this.gamemode, requiredChar:  this.butterflyCharCount);
            return System.String.IsNullOrEmpty(value:  145162912);
        }
        private bool CheckNoMorePets()
        {
            var val_2;
            var val_3;
            val_2 = 0;
            if(true > 0)
            {
                    return (bool)val_2;
            }
            
            val_3 = 0;
            label_9:
            if(val_3 >= true)
            {
                goto label_5;
            }
            
            if(true <= val_3)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            val_2 = 0;
            val_3 = val_3 + 1;
            if(((0 + 0) + 16.HasPet()) == false)
            {
                goto label_9;
            }
            
            return (bool)val_2;
            label_5:
            val_2 = 1;
            this.OnGameEnded(didPlayerWin:  false, loseCondition:  1);
            return (bool)val_2;
        }
        public void ClearPets()
        {
            var val_1 = 0;
            goto label_1;
            label_6:
            if(true <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            (0 + 0) + 16.DestroyPet();
            val_1 = 1;
            label_1:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_6;
            }
        
        }
        private System.Collections.IEnumerator FlyAway(UnityEngine.Transform transformToFly)
        {
            typeof(WPTGameUIController.<FlyAway>d__150).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WPTGameUIController.<FlyAway>d__150).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(WPTGameUIController.<FlyAway>d__150).__il2cppRuntimeField_14 = transformToFly;
        }
        private System.Collections.IEnumerator ProcessBalloons()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<ProcessBalloons>d__151).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<ProcessBalloons>d__151).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator CheckPetCapture()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<CheckPetCapture>d__152).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<CheckPetCapture>d__152).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator CheckColumns()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<CheckColumns>d__154).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<CheckColumns>d__154).__il2cppRuntimeField_10 = this;
        }
        private void AddExtraLetters(System.Collections.Generic.List<char> charactersToAdd, int lettersNeeded, int[] letterOccuranceDict)
        {
            var val_24;
            var val_25;
            System.Collections.Generic.List<System.Char> val_26;
            char val_28;
            var val_30;
            val_24 = this;
            val_25 = lettersNeeded;
            val_26 = charactersToAdd;
            System.Collections.Generic.Dictionary<System.Char, System.Int32> val_1 = this.<currentData>k__BackingField.GetAllLettersCounter();
            if(val_25 < 1)
            {
                goto label_2;
            }
            
            label_42:
            float val_2 = this.GivePercentageOfCurrentVowels(generatingChar:  val_26);
            if(val_25 >= 0)
            {
                goto label_3;
            }
            
            if(WordPets.WPTGameUIController.UseEasyLetters == false)
            {
                goto label_6;
            }
            
            char val_6 = WordPets.LetterGetter.getEasyVowel();
            goto label_18;
            label_3:
            if(WordPets.WPTGameUIController.UseEasyLetters == false)
            {
                goto label_12;
            }
            
            char val_9 = WordPets.LetterGetter.getRandomEasyLetter(letterOccuranceCounter:  letterOccuranceDict);
            goto label_18;
            label_6:
            char val_10 = WordPets.LetterGetter.getVowel();
            goto label_18;
            label_12:
            label_18:
            val_28 = WordPets.LetterGetter.getRandomLetter(letterOccuranceCounter:  letterOccuranceDict);
            if((this.<currentData>k__BackingField.ContainsKey(key:  val_28)) == true)
            {
                goto label_22;
            }
            
            goto label_33;
            label_35:
            if(WordPets.WPTGameUIController.UseEasyLetters != false)
            {
                    char val_15 = WordPets.LetterGetter.getRandomEasyLetter(letterOccuranceCounter:  letterOccuranceDict);
            }
            
            val_28 = WordPets.LetterGetter.getRandomLetter(letterOccuranceCounter:  letterOccuranceDict);
            label_22:
            if((this.<currentData>k__BackingField.ContainsKey(key:  (uint)val_28 & 65535)) != false)
            {
                    if((this.<currentData>k__BackingField.Item[(uint)val_28 & 65535]) > 2)
            {
                goto label_35;
            }
            
            }
            
            label_33:
            if((this.<currentData>k__BackingField) == 0)
            {
                goto label_36;
            }
            
            if((this.<currentData>k__BackingField.ContainsKey(key:  (uint)val_28 & 65535)) == false)
            {
                goto label_39;
            }
            
            val_30 = this.<currentData>k__BackingField.Item[(uint)val_28 & 65535];
            goto label_38;
            label_36:
            val_26 = val_26;
            val_25 = val_25;
            val_24 = val_24;
            if((0.ContainsKey(key:  (uint)val_28 & 65535)) == false)
            {
                goto label_39;
            }
            
            val_30 = 0.Item[(uint)val_28 & 65535];
            label_38:
            this.<currentData>k__BackingField.set_Item(key:  (uint)val_28 & 65535, value:  val_30 + 1);
            goto label_40;
            label_39:
            this.<currentData>k__BackingField.Add(key:  (uint)val_28 & 65535, value:  1);
            label_40:
            val_26.Add(item:  (uint)val_28 & 65535);
            if(1 != val_25)
            {
                goto label_42;
            }
            
            label_2:
            PluginExtension.Shuffle<System.Char>(list:  val_26, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        private System.Collections.IEnumerator CheckAddPets()
        {
            object val_1 = new System.Object();
            typeof(WPTGameUIController.<CheckAddPets>d__156).__il2cppRuntimeField_8 = 0;
            typeof(WPTGameUIController.<CheckAddPets>d__156).__il2cppRuntimeField_10 = this;
        }
        private void UpdateTileRefillStatus(bool suppressOnscreenMessage = False)
        {
            if((this.<isTileRefillActive>k__BackingField) == false)
            {
                    return;
            }
            
            if((this.<isTileRefillActive>k__BackingField) > false)
            {
                    return;
            }
            
            mem2[0] = 0;
            R4.UpdateProgressUI(skipAnimation:  true);
            if((R4 + 236) == 0)
            {
                    return;
            }
            
            R4 + 236.Invoke(obj:  R4 + 212);
        }
        private float GivePercentageOfCurrentVowels(System.Collections.Generic.List<char> generatingChar)
        {
            var val_2;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            System.Collections.Generic.List<System.Char> val_8;
            System.Collections.Generic.List<WordPets.WPTGameColumn> val_9;
            char val_10;
            float val_11;
            val_4 = 0;
            val_5 = 0;
            val_6 = 0;
            goto label_1;
            label_16:
            val_7 = 0;
            goto label_2;
            label_14:
            if(true <= val_4)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            if(((0 + 0) + 16 + 16 + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = (0 + 0) + 16 + 16 + 8;
            val_5 = val_5 + 0;
            val_8 = this.vowls;
            bool val_1 = val_8.Contains(item:  ((0 + 0) + 16 + 16 + 8 + 0) + 16);
            val_6 = val_6 + val_1;
            val_7 = 1;
            label_2:
            if(val_1 <= val_4)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            if(val_7 < ((0 + 0) + 16 + 16 + 12))
            {
                goto label_14;
            }
            
            var val_7 = val_2;
            val_4 = 1;
            val_7 = val_7 + val_7;
            val_5 = val_7;
            label_1:
            val_9 = this.<currentColumns>k__BackingField;
            val_2 = val_5;
            if(val_4 < val_7)
            {
                goto label_16;
            }
            
            if((generatingChar != 0) && ((generatingChar + 12) >= 1))
            {
                    do
            {
                if((generatingChar + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                char val_8 = generatingChar + 8;
                val_8 = val_8 + 16;
                val_10 = mem[(generatingChar + 8 + 16)];
                val_10 = val_8;
                if(this.vowls == 0)
            {
                    val_10 = val_10;
            }
            
                val_6 = val_6 + (this.vowls.Contains(item:  val_10));
                val_8 = 0 + 1;
                val_9 = 16 + 2;
            }
            while(val_8 < (generatingChar + 12));
            
                val_5 = val_2 + val_8;
            }
            
            if(val_6 < val_5)
            {
                    val_11 = (float)val_6 / (float)val_5;
                return val_11;
            }
            
            val_11 = 1f;
            return val_11;
        }
        public void OnVoluntaryRetryClicked()
        {
            if(this.processingPetAnimation == false)
            {
                    this.processingPetAnimation = this.<initilizing>k__BackingField;
                goto label_0;
            }
            
            return;
            label_0:
            if(this.inFTUX == true)
            {
                    return;
            }
            
            this.OnGameEnded(didPlayerWin:  false, loseCondition:  3);
        }
        public void OnHintClicked()
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            WordPets.WPTLetterTile val_19;
            var val_20;
            var val_21;
            val_13 = this;
            if(this.processingPetAnimation == false)
            {
                    this.processingPetAnimation = this.<initilizing>k__BackingField;
                goto label_1;
            }
            
            return;
            label_1:
            if(this.inFTUX == false)
            {
                    this.inFTUX = this.isValidWordSelected;
            }
            
            if(this.inFTUX == true)
            {
                    return;
            }
            
            val_14 = 0;
            goto label_3;
            label_8:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_14)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + 0;
            Add(item:  (0 + 0) + 16);
            val_14 = 1;
            label_3:
            if(val_14 < null)
            {
                goto label_8;
            }
            
            val_15 = 0;
            this.DeselectTile(selectionIndex:  0, deselectSubsequent:  true, dontAnimate:  true);
            if((this.gamemode.OnHintClicked(playerSelectedCharCount:  478302960, hintedWord: out  string val_4 = 172844248)) == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  null)) == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_16 = 0;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  9, oneshot:  true, pitch:  null, vol:  null);
            val_17 = 0;
            string val_8 = val_17.ToLowerInvariant();
            goto label_25;
            label_62:
            val_18 = 4;
            goto label_26;
            label_37:
            val_18 = 5;
            label_26:
            var val_10 = val_18 - 4;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((List<T>.__il2cppRuntimeField_14.IsSelectable()) == false)
            {
                goto label_37;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            goto label_39;
            label_58:
            var val_17 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_17 = val_17 + 0;
            System.Collections.Generic.List<WordPets.WPTLetterTile> val_12 = (0 + 0) + 16.GetLetterTiles();
            val_21 = 4;
            goto label_44;
            label_55:
            val_21 = 5;
            label_44:
            var val_13 = val_21 - 4;
            if(val_13 >= ((0 + 0) + 16 + 12))
            {
                goto label_46;
            }
            
            if(((0 + 0) + 16 + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(((0 + 0) + 16 + 8 + 20 + 136) != 0)
            {
                goto label_55;
            }
            
            if(((0 + 0) + 16 + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(((0 + 0) + 16 + 8 + 20.IsSelectable()) == false)
            {
                goto label_55;
            }
            
            if(((0 + 0) + 16 + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(val_17.Chars[0] != ((0 + 0) + 16 + 8 + 20))
            {
                goto label_55;
            }
            
            goto label_56;
            label_46:
            val_20 = 1;
            val_13 = val_13;
            if(val_20 < ((0 + 0) + 16 + 12))
            {
                goto label_58;
            }
            
            goto label_59;
            label_56:
            if(((0 + 0) + 16 + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = mem[(0 + 0) + 16 + 8 + 20];
            val_19 = (0 + 0) + 16 + 8 + 20;
            val_13 = val_13;
            label_39:
            this.SelectTile(tile:  val_19);
            label_59:
            val_17 = val_17;
            val_16 = val_16 + 1;
            label_25:
            if(val_17 == 0)
            {
                    val_17 = val_17;
            }
            
            if(val_16 < 0)
            {
                goto label_62;
            }
            
            this.DoPlayerTurnComplete();
        }
        public void OnAddColumnClicked()
        {
            if(this.processingPetAnimation == true)
            {
                    return;
            }
            
            if((this.<initilizing>k__BackingField) == false)
            {
                    this.<initilizing>k__BackingField = this.inFTUX;
                goto label_2;
            }
            
            return;
            label_2:
            this.DeselectTile(selectionIndex:  0, deselectSubsequent:  true, dontAnimate:  true);
            this.gamemode.OnAddColumnClicked();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  9, oneshot:  true, pitch:  null, vol:  null);
        }
        public void OnRefreshHintClicked()
        {
            if(this.processingPetAnimation == true)
            {
                    return;
            }
            
            if((this.<initilizing>k__BackingField) == false)
            {
                    this.<initilizing>k__BackingField = this.inFTUX;
                goto label_2;
            }
            
            return;
            label_2:
            this.DeselectTile(selectionIndex:  0, deselectSubsequent:  true, dontAnimate:  true);
            this.gamemode.OnRefreshHintClicked();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  9, oneshot:  true, pitch:  null, vol:  null);
        }
        private void OnLevelProgressClicked()
        {
            int val_4 = this.<currentData>k__BackingField.<totalInitialPets>k__BackingField;
            val_4 = (this.<currentData>k__BackingField.<petsExtra>k__BackingField) + val_4;
            if(val_4 == 1)
            {
                    "Pets" = "Pet";
            }
            
            int val_1 = this.gamemode.PetsCaptured;
            int val_5 = this.<currentData>k__BackingField.<totalInitialPets>k__BackingField;
            val_5 = (this.<currentData>k__BackingField.<petsExtra>k__BackingField) + val_5;
            string val_2 = System.String.Format(format:  173221616, arg0:  13152256, arg1:  13152256, arg2:  173213344);
            string val_3 = System.String.Format(format:  -1225078832, arg0:  173221616);
            this.messageBanner.ShowMessage(message:  -1225078832);
        }
        public void BringBackPets()
        {
            this.isPlaying = true;
        }
        public void ResumePlay()
        {
            this.isPlaying = true;
        }
        public void SelectWord(string inputWord)
        {
            var val_5;
            this.DeselectTile(selectionIndex:  0, deselectSubsequent:  true, dontAnimate:  true);
            val_5 = 0;
            string val_1 = inputWord.ToLower();
            System.Char[] val_2 = inputWord.ToCharArray();
            string val_3 = inputWord + 16;
            goto label_2;
            label_5:
            WordPets.WPTLetterTile val_4 = this.FindLetterTile(targetChar:  ' ');
            this.SelectTile(tile:  173606336);
            val_5 = 1;
            label_2:
            if(val_5 < inputWord.m_firstChar)
            {
                goto label_5;
            }
            
            this.isValidWordSelected = true;
        }
        private WordPets.WPTLetterTile FindLetterTile(char targetChar)
        {
            char val_5;
            var val_6;
            var val_7;
            var val_8;
            System.Collections.Generic.List<WordPets.WPTGameColumn> val_9;
            var val_10;
            val_5 = targetChar;
            val_6 = 0;
            goto label_1;
            label_28:
            val_7 = 4;
            goto label_2;
            label_26:
            if(true <= val_6)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            if(((0 + 0) + 16 + 16 + 12) <= R8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(((0 + 0) + 16 + 16 + 8 + 16) == 0)
            {
                goto label_19;
            }
            
            if(((0 + 0) + 16 + 16 + 8 + 16) <= val_6)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 0;
            if(((0 + 0) + 16 + 16 + 12) <= R8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = mem[(0 + 0) + 16 + 16 + 8 + 16];
            val_8 = (0 + 0) + 16 + 16 + 8 + 16;
            val_8 = 0;
            if((val_8 != val_5) || (val_8.IsSelectable() == false))
            {
                goto label_19;
            }
            
            bool val_2 = this.currentSelectedTiles.Contains(item:  0);
            val_5 = val_5;
            if(val_2 == false)
            {
                goto label_21;
            }
            
            label_19:
            val_7 = 5;
            label_2:
            if(val_2 <= val_6)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + 0;
            val_9 = mem[(0 + 0) + 16 + 16];
            val_9 = (0 + 0) + 16 + 16;
            if((val_7 - 4) < ((0 + 0) + 16 + 16 + 12))
            {
                goto label_26;
            }
            
            val_6 = 1;
            label_1:
            if(val_6 < ((0 + 0) + 16 + 16 + 12))
            {
                goto label_28;
            }
            
            val_10 = 0;
            string val_4 = targetChar.ToString();
            string val_5 = 173718912 + 173735130;
            UnityEngine.Debug.LogError(message:  173718912);
            return;
            label_21:
            val_9 = this.<currentColumns>k__BackingField;
            if(val_2 <= val_6)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + 0;
            if(((0 + 0) + 16 + 16 + 12) <= R8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = 0;
            if(((0 + 0) + 16 + 16 + 8 + 16) == 0)
            {
                    return;
            }
            
            val_5 = mem[(0 + 0) + 16 + 16 + 8 + 16 + 180];
            val_5 = (0 + 0) + 16 + 16 + 8 + 16 + 180;
        }
        private bool AllowUserInput()
        {
            if(this.processingPetAnimation == false)
            {
                    false = this.<initilizing>k__BackingField;
            }
            
            if(this.processingPetAnimation == false)
            {
                    false = false >> 5;
            }
            
            return (bool)false;
        }
        public bool GetTilesWithSelectableLetters(out System.Collections.Generic.List<WordPets.WPTGameTile> tilesWithProperty)
        {
            var val_3;
            tilesWithProperty = null;
            val_3 = 0;
            goto label_1;
            label_23:
            var val_6 = 0;
            label_20:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            if(val_6 >= ((0 + 0) + 16 + 16 + 12))
            {
                goto label_6;
            }
            
            if(((0 + 0) + 16 + 16 + 12) <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            if(((0 + 0) + 16 + 16 + 12) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = (0 + 0) + 16 + 16 + 8;
            val_5 = val_5 + 0;
            if((((0 + 0) + 16 + 16 + 8 + 0) + 16) != 0)
            {
                    if(0.IsSelectable() != false)
            {
                    Add(item:  ((0 + 0) + 16 + 16 + 8 + 0) + 16);
            }
            
            }
            
            val_6 = val_6 + 1;
            goto label_20;
            label_6:
            val_3 = 1;
            label_1:
            if(val_3 < ((0 + 0) + 16 + 16 + 12))
            {
                goto label_23;
            }
            
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool GetTilesWithCrate(out System.Collections.Generic.List<WordPets.WPTGameTile> tilesWithProperty)
        {
            var val_3;
            tilesWithProperty = null;
            val_3 = 0;
            goto label_1;
            label_23:
            var val_6 = 0;
            label_20:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            if(val_6 >= ((0 + 0) + 16 + 16 + 12))
            {
                goto label_6;
            }
            
            if(((0 + 0) + 16 + 16 + 12) <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            if(((0 + 0) + 16 + 16 + 12) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = (0 + 0) + 16 + 16 + 8;
            val_5 = val_5 + 0;
            if((((0 + 0) + 16 + 16 + 8 + 0) + 16) != 0)
            {
                    if(0.HasCrate != false)
            {
                    Add(item:  ((0 + 0) + 16 + 16 + 8 + 0) + 16);
            }
            
            }
            
            val_6 = val_6 + 1;
            goto label_20;
            label_6:
            val_3 = 1;
            label_1:
            if(val_3 < ((0 + 0) + 16 + 16 + 12))
            {
                goto label_23;
            }
            
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool GetTilesWithBalloon(out System.Collections.Generic.List<WordPets.WPTGameTile> tilesWithProperty)
        {
            var val_3;
            tilesWithProperty = null;
            val_3 = 0;
            goto label_1;
            label_23:
            var val_6 = 0;
            label_20:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            if(val_6 >= ((0 + 0) + 16 + 16 + 12))
            {
                goto label_6;
            }
            
            if(((0 + 0) + 16 + 16 + 12) <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            if(((0 + 0) + 16 + 16 + 12) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = (0 + 0) + 16 + 16 + 8;
            val_5 = val_5 + 0;
            if((((0 + 0) + 16 + 16 + 8 + 0) + 16) != 0)
            {
                    if(0.HasBalloon != false)
            {
                    Add(item:  ((0 + 0) + 16 + 16 + 8 + 0) + 16);
            }
            
            }
            
            val_6 = val_6 + 1;
            goto label_20;
            label_6:
            val_3 = 1;
            label_1:
            if(val_3 < ((0 + 0) + 16 + 16 + 12))
            {
                goto label_23;
            }
            
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool GetTilesWithSpiderWeb(out System.Collections.Generic.List<WordPets.WPTGameTile> tilesWithProperty)
        {
            var val_3;
            tilesWithProperty = null;
            val_3 = 0;
            goto label_1;
            label_23:
            var val_6 = 0;
            label_20:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            if(val_6 >= ((0 + 0) + 16 + 16 + 12))
            {
                goto label_6;
            }
            
            if(((0 + 0) + 16 + 16 + 12) <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            if(((0 + 0) + 16 + 16 + 12) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = (0 + 0) + 16 + 16 + 8;
            val_5 = val_5 + 0;
            if((((0 + 0) + 16 + 16 + 8 + 0) + 16) != 0)
            {
                    if(0.HasSpiderWeb != false)
            {
                    Add(item:  ((0 + 0) + 16 + 16 + 8 + 0) + 16);
            }
            
            }
            
            val_6 = val_6 + 1;
            goto label_20;
            label_6:
            val_3 = 1;
            label_1:
            if(val_3 < ((0 + 0) + 16 + 16 + 12))
            {
                goto label_23;
            }
            
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public void QAHACK_GiveRandomPet()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WordPet val_2 = GetRandomPet();
            this.gamemode.AddPetCaptured(newPet:  public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_14);
            this.UpdateProgressUI(skipAnimation:  false);
            bool val_3 = this.CheckVictory();
        }
        public void QAHACK_ClearLevel()
        {
            goto label_1;
            label_9:
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WordPet val_2 = GetRandomPet();
            this.gamemode.AddPetCaptured(newPet:  public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_14);
            label_1:
            int val_5 = this.<currentData>k__BackingField.<totalInitialPets>k__BackingField;
            val_5 = (this.<currentData>k__BackingField.<petsExtra>k__BackingField) + val_5;
            if(this.gamemode.PetsCaptured < val_5)
            {
                goto label_9;
            }
            
            this.UpdateProgressUI(skipAnimation:  false);
            bool val_4 = this.CheckVictory();
        }
        public void QAHACK_FailLevel()
        {
            this.OnGameEnded(didPlayerWin:  false, loseCondition:  2);
        }
        public WPTGameUIController()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.currentSelectedTiles = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.freeButterflies = null;
            this.butterflyCharCount = null;
            System.Collections.Generic.List<System.Char> val_3 = new System.Collections.Generic.List<System.Char>();
            this.vowls = null;
            this.vowl = null;
        }
        private static WPTGameUIController()
        {
            WordPets.WPTGameUIController.HACK_InstantFailEscape = true;
        }
        private bool <DoEndOfTurnGridResolution>b__127_0()
        {
            var val_1;
            if(true < 1)
            {
                    return false;
            }
            
            val_1 = null;
            val_1 = null;
            if(WordPets.WPTGameUIController.HACK_InstantFailEscape == true)
            {
                    WordPets.WPTGameUIController.HACK_InstantFailEscape = 1;
            }
            
            return true;
        }
        private bool <DoEndOfTurnGridResolution>b__127_1()
        {
            if(R1 > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
    
    }

}
