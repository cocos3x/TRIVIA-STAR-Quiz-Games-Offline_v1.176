using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLMainController : MonoSingleton<SLC.Wordlicious.WOLMainController>
    {
        // Fields
        private bool <isLevelCompleted>k__BackingField;
        private UnityEngine.TextAsset[] commonWordsSources;
        private UnityEngine.TextAsset[] uncommonWordsSources;
        private UnityEngine.TextAsset[] rareWordsSources;
        private UGUIGenericCoinsGainedAnim coinsGainedAnim;
        private UnityEngine.GameObject freeCoinButton;
        private UnityEngine.UI.Button hintButton;
        private System.Collections.Generic.List<SLC.Wordlicious.WOLLevel> levels;
        private System.Collections.Generic.HashSet<string> commonWords;
        private System.Collections.Generic.HashSet<string> uncommonAndRareWords;
        private System.Collections.Generic.HashSet<string> foundWords;
        private SLC.Wordlicious.WOLLevel currentLevel;
        private SLC.Wordlicious.WOLTextPreview textPreview;
        private System.Collections.Generic.List<string> availableWords;
        public System.Action OnLevelCompleted;
        public System.Action<string> OnWordSubmitted;
        public System.Action<int> OnLetterTileRemoved;
        public System.Action OnHintedUsed;
        public System.Action<string> OnExtraWordFound;
        private bool lastWordhack;
        
        // Properties
        public SLC.Wordlicious.WOLLevel CurrentLevel { get; }
        public bool isLevelCompleted { get; set; }
        
        // Methods
        public SLC.Wordlicious.WOLLevel get_CurrentLevel()
        {
        
        }
        public bool get_isLevelCompleted()
        {
            return (bool)this.<isLevelCompleted>k__BackingField;
        }
        public void set_isLevelCompleted(bool value)
        {
            this.<isLevelCompleted>k__BackingField = value;
        }
        public override void InitMonoSingleton()
        {
            this.LoadData();
        }
        public void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.textPreview = public static SLC.Wordlicious.WOLTextPreview MonoSingleton<SLC.Wordlicious.WOLTextPreview>::get_Instance();
            Player val_2 = App.Player;
            this.coinsGainedAnim.Set(instantValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256});
            UnityEngine.GameObject val_3 = this.freeCoinButton.gameObject;
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            this.freeCoinButton.SetActive(value:  VideoEnabledAndUnlocked());
            this.StartLevel();
        }
        public void CheckAnswer(string word, System.Collections.Generic.List<SLC.Wordlicious.Tile> gridPath)
        {
            SLC.Wordlicious.Tile val_13;
            SLC.Wordlicious.WOLMainController val_32;
            System.Collections.Generic.List<SLC.Wordlicious.Tile> val_33;
            System.Collections.Generic.HashSet<System.String> val_34;
            var val_35;
            SLC.Wordlicious.WOLTrackingLevelComplete val_36;
            int val_37;
            var val_38;
            var val_39;
            int val_40;
            val_32 = this;
            val_33 = gridPath;
            val_34 = this.foundWords;
            if((val_34.Contains(item:  word)) == false)
            {
                goto label_2;
            }
            
            this.textPreview.SetExistColor();
            goto label_46;
            label_2:
            if((this.commonWords.Contains(item:  word)) == true)
            {
                goto label_6;
            }
            
            val_34 = this.uncommonAndRareWords;
            if((val_34.Contains(item:  word)) == false)
            {
                goto label_8;
            }
            
            label_6:
            val_35 = null;
            val_35 = null;
            int val_4 = SLC.Wordlicious.LettersReward.GetRewardByWordLength.Item[word.m_stringLength];
            if((this.currentLevel.<words>k__BackingField.ContainsKey(key:  word)) == false)
            {
                goto label_15;
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<SLC.Wordlicious.Tile>> val_7 = this.currentLevel.<words>k__BackingField.Item[word];
            List.Enumerator<T> val_8 = GetEnumerator();
            label_30:
            if(MoveNext() == false)
            {
                goto label_19;
            }
            
            List.Enumerator<T> val_11 = GetEnumerator();
            label_27:
            if(MoveNext() == false)
            {
                goto label_21;
            }
            
            if(val_13 != 0)
            {
                    var val_32 = val_13 + 20;
                val_32 = val_32 - 1;
                mem2[0] = val_32;
            }
            else
            {
                    mem[20] = 0;
            }
            
            if((val_13 + 28.Contains(item:  word)) == false)
            {
                goto label_27;
            }
            
            bool val_15 = val_13 + 28.Remove(item:  word);
            goto label_27;
            label_21:
            var val_16 = 0 + 1;
            mem2[0] = 228;
            Dispose();
            if(val_16 == 1)
            {
                goto label_30;
            }
            
            if((714956688 + ((0 + 1)) << 2) == 228)
            {
                    val_16 = val_16 >> 31;
                val_16 = ~(val_16 >> 31);
                val_16 = val_16 + val_16;
            }
            
            goto label_30;
            label_15:
            val_36 = this.currentLevel.<progress>k__BackingField.trackingLevelComplete;
            if(val_36 == 0)
            {
                goto label_41;
            }
            
            val_37 = this.currentLevel.<progress>k__BackingField.trackingLevelComplete.extraWordsFound;
            goto label_42;
            label_19:
            var val_33 = 0;
            val_33 = val_33 + 1;
            mem2[0] = 253;
            Dispose();
            val_34 = val_32;
            if(val_33 == 1)
            {
                goto label_43;
            }
            
            if(val_33 > 1)
            {
                    0 = 1;
            }
            
            var val_34 = 714956688 + ((0 + 1)) << 2;
            val_34 = val_34 - 253;
            val_34 = val_34 >> 5;
            val_34 = 1 & val_34;
            val_34 = val_33 - val_34;
            val_38 = val_34 + 1;
            goto label_44;
            label_8:
            this.textPreview.SetWrongColor();
            goto label_46;
            label_41:
            val_36 = 12;
            val_37 = 0;
            label_42:
            mem[12] = 1;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_39 = 0;
            goto label_47;
            label_57:
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((mem[1152921513911750448] + 12) <= val_39)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_35 = mem[1152921513911750448] + 8;
            val_35 = val_35 + 0;
            LineWord val_19 = GetLineWord(answer:  (mem[1152921513911750448] + 8 + 0) + 16);
            if(HiddenCellsCount() >= 2)
            {
                    Add(item:  698321168);
            }
            
            val_39 = 1;
            label_47:
            if(val_39 < (mem[1152921513911750448] + 12))
            {
                goto label_57;
            }
            
            val_40 = 0;
            val_34 = val_32;
            this.NotifyExtraWordFound(word:  word);
            goto label_60;
            label_43:
            val_38 = 0;
            label_44:
            if(val_33 == 0)
            {
                goto label_81;
            }
            
            List.Enumerator<T> val_21 = GetEnumerator();
            label_63:
            if(MoveNext() == false)
            {
                goto label_62;
            }
            
            bool val_23 = this.CheckDispensableTile(tile:  val_13);
            goto label_63;
            label_62:
            Dispose();
            label_81:
            if((mem[1152921513911750448].Contains(item:  word)) != false)
            {
                    bool val_25 = mem[1152921513911750448].Remove(item:  word);
            }
            
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowAnswer(answer:  word);
            val_40 = this.RemovedTiles() - this.RemovedTiles();
            label_60:
            val_33 = val_34;
            this.textPreview.SetAnswerColor();
            this.WordSubmitted(word:  word);
            bool val_28 = val_34.Add(item:  word);
            this.GrantLettersReward(randomLetters:  val_4);
            this.SaveLevel();
            if(val_40 >= 1)
            {
                    val_34 = val_34;
                this.NotifyRemovedTiles(tiles:  val_4 = val_40);
            }
            
            if((mem[1152921513911750448] + 12) == 0)
            {
                    System.Collections.IEnumerator val_29 = this.LevelCompleted();
                UnityEngine.Coroutine val_30 = this.StartCoroutine(routine:  714968816);
            }
            
            val_32 = 1152921513911750444;
            label_46:
            val_32.FadeOut();
        }
        public void HintClick(bool free)
        {
            bool val_8;
            SLC.Wordlicious.WOLTrackingLevelComplete val_10;
            int val_11;
            var val_12;
            val_8 = free;
            if(true < 1)
            {
                    return;
            }
            
            decimal val_1 = CurrencyController.GetBalance();
            GameEcon val_2 = App.getGameEcon;
            bool val_3 = System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = 6, hi = 4, lo = 4, mid = 308});
            if(val_8 == false)
            {
                goto label_8;
            }
            
            if(val_8 == false)
            {
                goto label_9;
            }
            
            val_10 = this.currentLevel.<progress>k__BackingField.trackingLevelComplete;
            if(val_10 == 0)
            {
                goto label_12;
            }
            
            val_11 = this.currentLevel.<progress>k__BackingField.trackingLevelComplete.trialHintsUsed;
            goto label_27;
            label_8:
            var val_9 = 24303469;
            val_9 = 11322592 + val_9;
            if(val_9 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_12 = null;
            val_12 = null;
            PurchaseProxy.currentPurchasePoint = 6;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
            Init(outOfCredits:  true, onCloseAction:  0);
            return;
            label_9:
            bool val_6 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = 6, hi = 4, lo = 4, mid = 308}, source:  "Hint", externalParams:  0, animated:  false);
            val_10 = this.currentLevel.<progress>k__BackingField.trackingLevelComplete;
            if(val_10 == 0)
            {
                goto label_26;
            }
            
            val_11 = this.currentLevel.<progress>k__BackingField.trackingLevelComplete.hintsUsed;
            goto label_27;
            label_12:
            val_10 = 16;
            goto label_28;
            label_26:
            val_10 = 8;
            label_28:
            label_27:
            mem[8] = val_10 + 1;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowHint(free:  false, line:  0, cell:  0);
            Prefs.UsedHint(free:  val_8);
            if(this.OnHintedUsed != 0)
            {
                    this.OnHintedUsed.Invoke();
            }
            
            if((this.<isLevelCompleted>k__BackingField) == true)
            {
                    return;
            }
            
            this.SaveLevel();
        }
        public int RemovedTiles()
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = 0;
            val_3 = 0;
            goto label_0;
            label_10:
            val_4 = 0;
            goto label_1;
            label_8:
            SLC.Wordlicious.Tile val_1 = this.currentLevel.GetTile(x:  0, y:  0);
            if(this.currentLevel != 0)
            {
                    if((this.currentLevel.<width>k__BackingField) >= 1)
            {
                    if((this.currentLevel.<height>k__BackingField) != 0)
            {
                    val_3 = 1;
            }
            
            }
            else
            {
                    val_3 = 1;
            }
            
            }
            
            val_4 = 1;
            label_1:
            if(val_4 < (this.currentLevel.<width>k__BackingField))
            {
                goto label_8;
            }
            
            val_2 = 1;
            label_0:
            if(val_2 < (this.currentLevel.<height>k__BackingField))
            {
                goto label_10;
            }
            
            return (int)val_3;
        }
        public void GrantLettersReward(int randomLetters)
        {
            if(randomLetters < 1)
            {
                    return;
            }
            
            if((this.<isLevelCompleted>k__BackingField) == true)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_1 = R4.GrantReward(randomLetters:  randomLetters);
            UnityEngine.Coroutine val_2 = R4.StartCoroutine(routine:  R4);
        }
        public bool HasLongWordsInCurrentLevel()
        {
            var val_5;
            System.Predicate<System.String> val_7;
            Dictionary.KeyCollection<TKey, TValue> val_1 = this.currentLevel.<words>k__BackingField.Keys;
            System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<System.Object>(source:  this.currentLevel.<words>k__BackingField);
            val_5 = null;
            val_5 = null;
            val_7 = WOLMainController.<>c.<>9__30_0;
            if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new System.Predicate<ZooTile>(object:  WOLMainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(715548464));
                WOLMainController.<>c.<>9__30_0 = val_7;
            }
            
            object val_4 = this.currentLevel.<words>k__BackingField.Find(match:  8040448);
            if((this.currentLevel.<words>k__BackingField) != 0)
            {
                    this.currentLevel.<words>k__BackingField = 1;
            }
            
            return true;
        }
        public void Hack_GrantWord()
        {
            var val_1;
            var val_2;
            string val_3;
            if(true < 1)
            {
                    return;
            }
            
            if(this.lastWordhack == false)
            {
                goto label_3;
            }
            
            if(this.availableWords == 0)
            {
                goto label_4;
            }
            
            val_2 = this.lastWordhack;
            goto label_5;
            label_3:
            if(this.lastWordhack == true)
            {
                goto label_8;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            goto label_8;
            label_4:
            val_2 = 0;
            val_1 = 0;
            label_5:
            if(val_1 <= (-1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = 0 + 4294967292;
            label_8:
            val_3 = val_3 + 16;
            this.textPreview.SetActive(isActive:  true, useButtons:  false);
            this.textPreview.FadeIn();
            this.CheckAnswer(word:  val_3, gridPath:  0);
        }
        public void Hack_CompleteLevel()
        {
            System.Collections.IEnumerator val_1 = this.LevelCompleted();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  715854832);
        }
        private void StartLevel()
        {
            Player val_1 = App.Player;
            if(0 > 0)
            {
                    UnityEngine.Debug.LogError(message:  715946928);
                ShowMoreLevelsMessage();
                return;
            }
            
            this.<isLevelCompleted>k__BackingField = false;
            Player val_2 = App.Player;
            var val_8 = 0;
            val_8 = val_8 - 1;
            if(0 <= val_8)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + (val_8 << 2);
            this.currentLevel = (0 + ((0 - 1)) << 2) + 16;
            (0 + ((0 - 1)) << 2) + 16.LoadProgress();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Wordlicious.WOLWordRegion MonoSingleton<SLC.Wordlicious.WOLWordRegion>::get_Instance().__il2cppRuntimeField_24 = this.currentLevel;
            System.Collections.IEnumerator val_4 = LoadCoroutine();
            UnityEngine.Coroutine val_5 = StartCoroutine(routine:  698321168);
            this.CheckAvailableAndFoundWords();
            this.TrackLevelStart();
            System.Collections.IEnumerator val_6 = this.LoadLevel();
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  715979264);
        }
        private void CheckAvailableAndFoundWords()
        {
            string val_7;
            System.Collections.Generic.List<System.String> val_12;
            var val_13;
            var val_14;
            System.Func<System.Char, System.Boolean> val_16;
            Dictionary.KeyCollection<TKey, TValue> val_1 = this.currentLevel.<words>k__BackingField.Keys;
            System.Collections.Generic.List<ZooTile> val_2 = null;
            val_12 = val_2;
            val_13 = 1152921511111006592;
            val_2 = new System.Collections.Generic.List<ZooTile>(collection:  this.currentLevel.<words>k__BackingField);
            this.availableWords = val_12;
            System.Comparison<WordForest.NewsArticle> val_3 = new System.Comparison<WordForest.NewsArticle>(object:  0, method:  new IntPtr(3606944480));
            Sort(comparison:  7933952);
            this.foundWords.Clear();
            if(this.foundWords == 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<ZooTile> val_4 = new System.Collections.Generic.List<ZooTile>(collection:  this.availableWords);
            List.Enumerator<T> val_5 = GetEnumerator();
            val_12 = 0;
            val_13 = 1152921505042468864;
            label_23:
            bool val_6 = MoveNext();
            if(val_6 == false)
            {
                goto label_10;
            }
            
            if(val_6 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = null;
            val_14 = null;
            val_16 = WOLMainController.<>c.<>9__35_0;
            if(val_16 == 0)
            {
                    val_16 = null;
                val_16 = new System.Func<System.Char, System.Boolean>(object:  WOLMainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(716121536));
                WOLMainController.<>c.<>9__35_0 = val_16;
            }
            
            val_12 = val_12 + 1;
            if((System.Linq.Enumerable.Any<System.Char>(source:  public System.Boolean List.Enumerator<System.String>::MoveNext().__il2cppRuntimeField_10, predicate:  7720960)) == true)
            {
                goto label_23;
            }
            
            bool val_10 = this.availableWords.Remove(item:  val_7);
            bool val_11 = this.foundWords.Add(item:  val_7);
            goto label_23;
            label_10:
            Dispose();
        }
        private bool CheckDispensableTile(SLC.Wordlicious.Tile tile)
        {
            twelvegigs.sweepstakes.Distribution val_4;
            var val_24;
            var val_26;
            System.Func<SLC.Wordlicious.Tile, System.Boolean> val_28;
            var val_30;
            System.Func<SLC.Wordlicious.Tile, System.String> val_32;
            var val_33;
            if(716320256 != 0)
            {
                    return false;
            }
            
            if((R6 + 12) == 0)
            {
                    return false;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            label_27:
            if(0 >= 0)
            {
                goto label_7;
            }
            
            if(0 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_24 = 0;
            val_24 = val_24 + 0;
            string val_2 = mem[1152921513913114008] + 32.Item[(0 + 0) + 16];
            if((mem[1152921513913114008] + 32 + 12) == 1)
            {
                    return false;
            }
            
            List.Enumerator<T> val_3 = GetEnumerator();
            val_24 = 0;
            goto label_18;
            label_24:
            if((val_4.Contains(item:  tile)) != false)
            {
                    Add(item:  val_4);
            }
            else
            {
                    val_26 = null;
                val_26 = null;
                val_28 = WOLMainController.<>c.<>9__36_0;
                if(val_28 == 0)
            {
                    val_28 = null;
                val_28 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WOLMainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(716299072));
                val_24 = 0;
                WOLMainController.<>c.<>9__36_0 = val_28;
            }
            
                if((System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  val_4, predicate:  7720960)) == 0)
            {
                    0 = 1;
            }
            
            }
            
            label_18:
            if(MoveNext() == true)
            {
                goto label_24;
            }
            
            var val_25 = 1;
            Dispose();
            if(val_25 != 1)
            {
                    if(val_25 > 1)
            {
                    0 = 1;
            }
            
                val_25 = val_25 - 0;
            }
            
            val_24 = val_24 + 1;
            if(0 != 0)
            {
                goto label_27;
            }
            
            return false;
            label_7:
            mem2[0] = 1;
            string val_9 = 716301120 + tile;
            UnityEngine.Debug.Log(message:  716301120);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_11 = GetEnumerator();
            var val_26 = 0;
            label_50:
            if(MoveNext() == false)
            {
                goto label_43;
            }
            
            val_30 = null;
            val_30 = null;
            val_32 = WOLMainController.<>c.<>9__36_1;
            if(val_32 == 0)
            {
                    val_32 = null;
                val_32 = new System.Func<ZooTile, System.String>(object:  WOLMainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(716303264));
                WOLMainController.<>c.<>9__36_1 = val_32;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_14 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  val_4, selector:  7720960);
            TSource[] val_15 = System.Linq.Enumerable.ToArray<System.Object>(source:  val_4);
            AddRange(collection:  val_4);
            goto label_50;
            label_43:
            val_26 = val_26 + 1;
            mem2[0] = 346;
            Dispose();
            if(val_26 != 1)
            {
                    if(val_26 > 1)
            {
                    0 = 1;
            }
            
                var val_27 = 716320256 + ((0 + 1)) << 2;
                val_27 = val_27 - 346;
                val_27 = val_27 >> 5;
                val_27 = 1 & val_27;
                val_27 = val_26 - val_27;
                val_33 = val_27 + 1;
            }
            else
            {
                    val_33 = 0;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_16 = System.Linq.Enumerable.Distinct<System.Object>(source:  80883712);
            System.Collections.Generic.List<TSource> val_17 = System.Linq.Enumerable.ToList<System.Object>(source:  80883712);
            if(null != 0)
            {
                    bool val_18 = Remove(item:  tile);
            }
            else
            {
                    bool val_19 = 0.Remove(item:  tile);
            }
            
            List.Enumerator<T> val_20 = GetEnumerator();
            label_57:
            if(MoveNext() == false)
            {
                goto label_55;
            }
            
            goto label_57;
            label_55:
            Dispose();
            return false;
        }
        private System.Collections.IEnumerator LoadLevel()
        {
            object val_1 = new System.Object();
            typeof(WOLMainController.<LoadLevel>d__37).__il2cppRuntimeField_8 = 0;
            typeof(WOLMainController.<LoadLevel>d__37).__il2cppRuntimeField_10 = this;
        }
        private void SaveLevel()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Save(level:  this.currentLevel);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Save(level:  this.currentLevel);
            if((this.currentLevel.<progress>k__BackingField) == 0)
            {
                
            }
        
        }
        private void ResetProgress()
        {
            this.currentLevel.ResetProgress();
        }
        private void NotifyRemovedTiles(int tiles)
        {
            if(true != 0)
            {
                    true = this.OnLetterTileRemoved;
            }
            
            if(true == 0)
            {
                    return;
            }
            
            true.Invoke(obj:  tiles);
        }
        private void NotifyExtraWordFound(string word)
        {
            if(this.OnExtraWordFound == 0)
            {
                    return;
            }
            
            this.OnExtraWordFound.Invoke(obj:  word);
        }
        private System.Collections.IEnumerator LevelCompleted()
        {
            object val_1 = new System.Object();
            typeof(WOLMainController.<LevelCompleted>d__42).__il2cppRuntimeField_8 = 0;
            typeof(WOLMainController.<LevelCompleted>d__42).__il2cppRuntimeField_10 = this;
        }
        private void WordSubmitted(string word)
        {
            if(this.OnWordSubmitted == 0)
            {
                    return;
            }
            
            this.OnWordSubmitted.Invoke(obj:  word);
        }
        private System.Collections.IEnumerator GrantReward(int randomLetters)
        {
            typeof(WOLMainController.<GrantReward>d__44).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WOLMainController.<GrantReward>d__44).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(WOLMainController.<GrantReward>d__44).__il2cppRuntimeField_14 = randomLetters;
        }
        private bool GrantRandomLetter()
        {
            var val_13;
            Cell val_14;
            string val_15;
            System.Collections.Generic.List<System.String> val_16;
            var val_17;
            var val_18;
            var val_19;
            if(true == 0)
            {
                goto label_15;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_13 = 0;
            val_14 = 1152921511140831312;
            goto label_3;
            label_13:
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Wordlicious.WOLWordRegion MonoSingleton<SLC.Wordlicious.WOLWordRegion>::get_Instance()) <= val_13)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + 0;
            val_15 = mem[(0 + 0) + 16];
            val_15 = (0 + 0) + 16;
            LineWord val_3 = GetLineWord(answer:  val_15);
            if(HiddenCellsCount() >= 2)
            {
                    Add(item:  698321168);
            }
            
            val_13 = 1;
            label_3:
            val_16 = this.availableWords;
            if(val_13 < null)
            {
                goto label_13;
            }
            
            int val_5 = UnityEngine.Random.Range(min:  0, max:  1094062064);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.Collections.Generic.List<Cell> val_6 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16.HiddenCells();
            val_17 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16;
            val_18 = UnityEngine.Random.Range(min:  0, max:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16 + 12);
            goto label_19;
            label_15:
            val_19 = 0;
            return (bool)val_19;
            label_19:
            if( <= )
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = 1152921504901095424;
            val_14 = mem[((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16 + 8 + (val_8) << 2) + 16];
            val_14 = ((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16 + 8 + (val_8) << 2) + 16;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsExtraWordFtuxInProgress() != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_16 = public static SLC.Wordlicious.WOLFtuxController MonoSingleton<SLC.Wordlicious.WOLFtuxController>::get_Instance();
                SetupExtraWordRewardLetter(word:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16, letter:  val_14);
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_16 = public static SLC.Wordlicious.WOLWordRegion MonoSingleton<SLC.Wordlicious.WOLWordRegion>::get_Instance();
                ShowHint(free:  false, line:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16, cell:  val_14);
            }
            
            val_19 = 1;
            return (bool)val_19;
        }
        private void GrantCoins(int coins)
        {
            int val_9;
            Player val_1 = App.Player;
            Player val_2 = App.Player;
            var val_3 = 0 + 60;
            decimal val_4 = System.Decimal.op_Implicit(value:  717567420);
            decimal val_5 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 717567404, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256});
            UnityEngine.Transform val_6 = this.textPreview.transform;
            this.coinsGainedAnim.Play(startCoins:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, finalCoins:  new System.Decimal(), particleStart:  this.textPreview, forceTextTween:  false);
            Player val_7 = App.Player;
            decimal val_8 = System.Decimal.op_Implicit(value:  717567388);
            0.AddCredits(amount:  new System.Decimal() {mid = val_9}, source:  "Free Random Letter", subSource:  0, externalParams:  0, doTrack:  true);
        }
        private void ShowMoreLevelsMessage()
        {
            var val_5;
            System.Func<System.Boolean> val_7;
            var val_8;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_3 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_5 = null;
            val_5 = null;
            val_7 = WOLMainController.<>c.<>9__47_0;
            if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new System.Func<System.Boolean>(object:  WOLMainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(717675856));
                WOLMainController.<>c.<>9__47_0 = val_7;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_7;
            val_8 = null;
            val_8 = null;
            SetupMessage(titleTxt:  717675664, messageTxt:  717675760, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        }
        private void LoadData()
        {
            string val_8;
            var val_30;
            var val_31;
            var val_32;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            this.levels.Clear();
            var val_30 = 24314767;
            val_30 = 11311020 + val_30;
            if(val_30 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_30 = null;
            val_30 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_2 = -1655690384(-1655690384) + 295313408 + 137207664;
            T[] val_3 = UnityEngine.Resources.LoadAll<System.Object>(path:  -1655690384);
            val_31 = 0;
            val_32 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_6 = GetEnumerator();
            label_22:
            if(MoveNext() == false)
            {
                goto label_18;
            }
            
            val_34 = 0;
            if(val_8 != 0)
            {
                    if(((val_8 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_8 = 0;
            }
            
                val_34 = val_8;
            }
            
            SLC.Wordlicious.WOLLevel val_9 = new SLC.Wordlicious.WOLLevel(serialized:  0);
            this.levels.Add(item:  435355648);
            goto label_22;
            label_18:
            Dispose();
            this.commonWords.Clear();
            var val_32 = 0;
            label_42:
            if(0 >= this.commonWords)
            {
                goto label_25;
            }
            
            UnityEngine.TextAsset val_31 = this.commonWordsSources[0];
            string val_10 = val_31.text;
            object val_11 = MiniJSON.Json.Deserialize(json:  val_31);
            if(val_31 != 0)
            {
                    val_35 = null;
            }
            
            if(val_31 != 0)
            {
                    val_35 = null;
                val_36 = 0;
                if(((UnityEngine.TextAsset.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_35)
            {
                    val_31 = 0;
            }
            
                val_36 = val_31;
            }
            else
            {
                    val_36 = 0;
            }
            
            List.Enumerator<T> val_12 = GetEnumerator();
            label_39:
            if(MoveNext() == false)
            {
                goto label_35;
            }
            
            string val_14 = val_8.ToUpper();
            bool val_15 = this.commonWords.Add(item:  val_8);
            goto label_39;
            label_35:
            val_32 = val_32 + 1;
            mem2[0] = 273;
            Dispose();
            var val_34 = 0;
            if(val_32 != 1)
            {
                    if(val_32 > 1)
            {
                    0 = 1;
            }
            
                var val_33 = 718064968 + ((0 + 1)) << 2;
                val_33 = val_33 - 273;
                val_33 = val_33 >> 5;
                val_33 = 1 & val_33;
                val_32 = val_32 - val_33;
            }
            
            val_34 = val_34 + 1;
            goto label_42;
            label_25:
            this.uncommonAndRareWords.Clear();
            label_68:
            if(0 >= this.uncommonAndRareWords)
            {
                goto label_51;
            }
            
            UnityEngine.TextAsset val_35 = this.uncommonWordsSources[0];
            string val_17 = val_35.text;
            object val_18 = MiniJSON.Json.Deserialize(json:  val_35);
            if(val_35 != 0)
            {
                    val_37 = null;
            }
            
            if(val_35 != 0)
            {
                    val_37 = null;
                val_38 = 0;
                if(((UnityEngine.TextAsset.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_37)
            {
                    val_35 = 0;
            }
            
                val_38 = val_35;
            }
            else
            {
                    val_38 = 0;
            }
            
            List.Enumerator<T> val_19 = GetEnumerator();
            label_65:
            if(MoveNext() == false)
            {
                goto label_61;
            }
            
            string val_21 = val_8.ToUpper();
            bool val_22 = this.uncommonAndRareWords.Add(item:  val_8);
            goto label_65;
            label_61:
            val_32 = val_32 + 1;
            mem2[0] = 398;
            Dispose();
            var val_37 = 0;
            if(val_32 != 1)
            {
                    if(val_32 > 1)
            {
                    0 = 1;
            }
            
                var val_36 = 718064968 + ((0 + 1)) << 2;
                val_36 = val_36 - 398;
                val_36 = val_36 >> 5;
                val_36 = 1 & val_36;
                val_32 = val_32 - val_36;
            }
            
            val_37 = val_37 + 1;
            goto label_68;
            label_51:
            label_93:
            if(0 >= this.uncommonAndRareWords)
            {
                    return;
            }
            
            UnityEngine.TextAsset val_38 = this.rareWordsSources[0];
            string val_23 = val_38.text;
            object val_24 = MiniJSON.Json.Deserialize(json:  val_38);
            if(val_38 != 0)
            {
                    val_39 = null;
            }
            
            if(val_38 != 0)
            {
                    val_39 = null;
                val_40 = 0;
                if(((UnityEngine.TextAsset.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_39)
            {
                    val_38 = 0;
            }
            
                val_40 = val_38;
            }
            else
            {
                    val_40 = 0;
            }
            
            List.Enumerator<T> val_25 = GetEnumerator();
            label_90:
            if(MoveNext() == false)
            {
                goto label_86;
            }
            
            string val_27 = val_8.ToUpper();
            bool val_28 = this.uncommonAndRareWords.Add(item:  val_8);
            goto label_90;
            label_86:
            val_32 = val_32 + 1;
            mem2[0] = 512;
            Dispose();
            var val_40 = 0;
            if(val_32 != 1)
            {
                    if(val_32 > 1)
            {
                    0 = 1;
            }
            
                var val_39 = 718064968 + ((0 + 1)) << 2;
                val_39 = val_39 - 512;
                val_39 = val_39 >> 5;
                val_39 = 1 & val_39;
                val_32 = val_32 - val_39;
            }
            
            val_40 = val_40 + 1;
            goto label_93;
        }
        public static int CompareWords(string x, string y)
        {
            var val_3;
            if(x == null)
            {
                goto label_0;
            }
            
            if(y == null)
            {
                goto label_1;
            }
            
            if((x.m_stringLength.CompareTo(value:  y.m_stringLength)) != 0)
            {
                    return (int)val_3;
            }
            
            int val_2 = x.CompareTo(strB:  y);
            return (int)val_3;
            label_0:
            if(y != null)
            {
                    y = 0;
            }
            
            val_3 = y;
            return (int)val_3;
            label_1:
            val_3 = 1;
            return (int)val_3;
        }
        private void Find_Dispensable_tiles()
        {
            var val_3;
            SLC.Wordlicious.Tile val_4;
            val_3 = 0;
            goto label_1;
            label_8:
            val_4 = 0;
            goto label_2;
            label_6:
            SLC.Wordlicious.Tile val_1 = this.currentLevel.GetTile(x:  0, y:  0);
            if(this.currentLevel != 0)
            {
                    this.currentLevel = this;
                bool val_2 = this.CheckDispensableTile(tile:  val_4 = this.currentLevel);
            }
            
            val_4 = 1;
            label_2:
            if(val_4 < (this.currentLevel.<width>k__BackingField))
            {
                goto label_6;
            }
            
            val_3 = 1;
            label_1:
            if(val_3 < (this.currentLevel.<height>k__BackingField))
            {
                goto label_8;
            }
            
            UnityEngine.Debug.LogError(message:  718567888);
            this.WordSubmitted(word:  1098586544);
        }
        private void TrackLevelComplete()
        {
            var val_2;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            int val_2 = this.currentLevel.<level>k__BackingField;
            val_2 = val_2 + 1;
            Add(key:  -2100706208, value:  13152256);
            Add(key:  -2100067504, value:  13152256);
            Add(key:  -2100067936, value:  13152256);
            Add(key:  718733264, value:  13152256);
            var val_3 = 24292630;
            val_3 = 11332908 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_2 = null;
            val_2 = null;
            App.trackerManager.track(eventName:  -1942299264, data:  78753792);
        }
        private void TrackLevelStart()
        {
            var val_4;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_2 = App.Player;
            var val_3 = 0 + 60;
            Add(key:  -2100706000, value:  10170368);
            int val_5 = this.currentLevel.<level>k__BackingField;
            val_5 = val_5 + 1;
            Add(key:  -2100706208, value:  13152256);
            int val_4 = this.currentLevel.wordsCount;
            Add(key:  -2100705904, value:  13152256);
            val_4 = null;
            val_4 = null;
            App.trackerManager.track(eventName:  -2100698896, data:  78753792);
        }
        public WOLMainController()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.levels = null;
            this.commonWords = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            this.uncommonAndRareWords = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            this.foundWords = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
        }
    
    }

}
