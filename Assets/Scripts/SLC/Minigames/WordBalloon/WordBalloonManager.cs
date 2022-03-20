using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordBalloonManager : MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>
    {
        // Fields
        private const string MINIGAME_NAME = "WordBalloons";
        private int <CurrentPlayerLevel>k__BackingField;
        private SLC.Minigames.WordBalloon.GameState <MinigameState>k__BackingField;
        public System.Action OnMinigameBegin;
        public System.Action OnMinigameEnd;
        public System.Action OnLevelComplete;
        private SLC.Minigames.WordBalloon.WordBalloonLevelData <CurrentLevelData>k__BackingField;
        private System.Collections.Generic.List<string> <RemainingWords>k__BackingField;
        
        // Properties
        public int CurrentPlayerLevel { get; set; }
        public SLC.Minigames.WordBalloon.GameState MinigameState { get; set; }
        public SLC.Minigames.WordBalloon.WordBalloonLevelData CurrentLevelData { get; set; }
        public System.Collections.Generic.List<string> RemainingWords { get; set; }
        
        // Methods
        public int get_CurrentPlayerLevel()
        {
            return (int)this.<CurrentPlayerLevel>k__BackingField;
        }
        private void set_CurrentPlayerLevel(int value)
        {
            this.<CurrentPlayerLevel>k__BackingField = value;
        }
        public SLC.Minigames.WordBalloon.GameState get_MinigameState()
        {
        
        }
        private void set_MinigameState(SLC.Minigames.WordBalloon.GameState value)
        {
            this.<MinigameState>k__BackingField = value;
        }
        public SLC.Minigames.WordBalloon.WordBalloonLevelData get_CurrentLevelData()
        {
        
        }
        private void set_CurrentLevelData(SLC.Minigames.WordBalloon.WordBalloonLevelData value)
        {
            this.<CurrentLevelData>k__BackingField = value;
        }
        public System.Collections.Generic.List<string> get_RemainingWords()
        {
        
        }
        private void set_RemainingWords(System.Collections.Generic.List<string> value)
        {
            this.<RemainingWords>k__BackingField = value;
        }
        public override void InitMonoSingleton()
        {
            this.InitializeGame(existingData:  0);
            this.BeginGame();
        }
        private void Start()
        {
            this.InitializeGame(existingData:  0);
            this.BeginGame();
        }
        public void InitializeAndBeginGame()
        {
            this.InitializeGame(existingData:  0);
            this.BeginGame();
        }
        public void InitializeGame(SLC.Minigames.WordBalloon.WordBalloonLevelData existingData)
        {
            SLC.Minigames.WordBalloon.WordBalloonLevelData val_6 = existingData;
            this.<CurrentPlayerLevel>k__BackingField = 1;
            this.<MinigameState>k__BackingField = 0;
            if(val_6 == 0)
            {
                goto label_1;
            }
            
            this.<CurrentLevelData>k__BackingField = val_6;
            goto label_2;
            label_1:
            SLC.Minigames.WordBalloon.WordBalloonWordData val_2 = SLC.Minigames.WordBalloon.WordBalloonDataManager.GetWords(amountToGet:  SLC.Minigames.WordBalloon.WordBalloonEcon.GetAmountOfWords(gameLevel:  1), storeHistory:  true);
            SLC.Minigames.WordBalloon.WordBalloonGridGenerator val_3 = SLC.Minigames.WordBalloon.WordBalloonGridGenerator.Instance;
            SLC.Minigames.WordBalloon.WordBalloonLevelData val_4 = Generate(wordList:  val_1 + 12);
            this.<CurrentLevelData>k__BackingField = null;
            typeof(SLC.Minigames.WordBalloon.WordBalloonGridGenerator).__il2cppRuntimeField_10 = val_1 + 8;
            val_6 = this.<CurrentLevelData>k__BackingField;
            if(val_6 == 0)
            {
                goto label_10;
            }
            
            label_2:
            System.Collections.Generic.List<ZooTile> val_5 = new System.Collections.Generic.List<ZooTile>(collection:  this.<CurrentLevelData>k__BackingField.requiredWords);
            this.<RemainingWords>k__BackingField = null;
            return;
            label_10:
        }
        public void BeginGame()
        {
            this.<MinigameState>k__BackingField = 1;
            this.Invoke(methodName:  996551664, time:  null);
        }
        private void StartGame()
        {
            this.OnMinigameBegin.Invoke();
        }
        public void CompleteLevel()
        {
            this.OnLevelComplete.Invoke();
        }
        public void EndGame()
        {
            this.<MinigameState>k__BackingField = 2;
            this.OnMinigameEnd.Invoke();
        }
        public bool IsWordRequired(string submittedWord)
        {
            if((this.<CurrentLevelData>k__BackingField.requiredWords) != 0)
            {
                    return this.<CurrentLevelData>k__BackingField.requiredWords.Contains(item:  submittedWord);
            }
            
            return this.<CurrentLevelData>k__BackingField.requiredWords.Contains(item:  submittedWord);
        }
        public bool HasWordBeenSubmitted(string submittedWord)
        {
            bool val_1 = this.<RemainingWords>k__BackingField.Contains(item:  submittedWord);
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        public void MarkWordAsFound(string submittedWord)
        {
            bool val_1 = this.<RemainingWords>k__BackingField.Remove(item:  submittedWord);
        }
        public bool IsFTUX()
        {
            if((this.<CurrentPlayerLevel>k__BackingField) < 1)
            {
                    0 = 1;
            }
            
            return true;
        }
        private SLC.Minigames.WordBalloon.WordBalloonLevelData GetFTUXLevelData()
        {
            if(new System.Object() != 0)
            {
                    typeof(SLC.Minigames.WordBalloon.WordBalloonLevelData).__il2cppRuntimeField_10 = "Colors";
            }
            else
            {
                    mem[16] = "Colors";
            }
            
            typeof(SLC.Minigames.WordBalloon.WordBalloonLevelData).__il2cppRuntimeField_C = 7;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(null != 0)
            {
                    Add(item:  -940556144);
            }
            else
            {
                    Add(item:  -940556144);
            }
            
            Add(item:  -1729501776);
            Add(item:  -940555808);
            typeof(SLC.Minigames.WordBalloon.WordBalloonLevelData).__il2cppRuntimeField_14 = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
            if(null != 0)
            {
                    Add(item:  2);
                Add(item:  9);
                Add(item:  16);
                Add(item:  23);
            }
            else
            {
                    Add(item:  2);
                Add(item:  9);
                Add(item:  16);
                Add(item:  23);
            }
            
            Add(item:  30);
            object val_5 = new System.Object();
            typeof(SLC.Minigames.WordBalloon.WordSolutionData).__il2cppRuntimeField_8 = "GREEN";
            typeof(SLC.Minigames.WordBalloon.WordSolutionData).__il2cppRuntimeField_C = null;
            Add(item:  452075520);
            System.Collections.Generic.List<System.Int32> val_6 = new System.Collections.Generic.List<System.Int32>();
            if(null != 0)
            {
                    Add(item:  1);
                Add(item:  3);
            }
            else
            {
                    Add(item:  1);
                Add(item:  3);
            }
            
            Add(item:  4);
            object val_7 = new System.Object();
            typeof(SLC.Minigames.WordBalloon.WordSolutionData).__il2cppRuntimeField_8 = "RED";
            typeof(SLC.Minigames.WordBalloon.WordSolutionData).__il2cppRuntimeField_C = null;
            Add(item:  452075520);
            System.Collections.Generic.List<System.Int32> val_8 = new System.Collections.Generic.List<System.Int32>();
            if(null != 0)
            {
                    Add(item:  0);
                Add(item:  8);
                Add(item:  10);
                Add(item:  11);
                Add(item:  5);
            }
            else
            {
                    Add(item:  0);
                Add(item:  8);
                Add(item:  10);
                Add(item:  11);
                Add(item:  5);
            }
            
            Add(item:  6);
            object val_9 = new System.Object();
            typeof(SLC.Minigames.WordBalloon.WordSolutionData).__il2cppRuntimeField_8 = "ORANGE";
            typeof(SLC.Minigames.WordBalloon.WordSolutionData).__il2cppRuntimeField_C = null;
            Add(item:  452075520);
            typeof(SLC.Minigames.WordBalloon.WordBalloonLevelData).__il2cppRuntimeField_18 = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(null != 0)
            {
                    Add(item:  -1513226272);
            }
            else
            {
                    Add(item:  -1513226272);
            }
            
            Add(item:  1293130544);
            if(null != 0)
            {
                    Add(item:  1465011184);
            }
            else
            {
                    Add(item:  1465011184);
            }
            
            Add(item:  -1513226352);
            if(null != 0)
            {
                    Add(item:  1334339648);
            }
            else
            {
                    Add(item:  1334339648);
            }
            
            Add(item:  1465011184);
            if(null != 0)
            {
                    Add(item:  -1513226352);
            }
            else
            {
                    Add(item:  -1513226352);
            }
            
            Add(item:  1098586544);
            if(null != 0)
            {
                    Add(item:  1293130544);
            }
            else
            {
                    Add(item:  1293130544);
            }
            
            Add(item:  1293130544);
            if(null != 0)
            {
                    Add(item:  -1930531024);
            }
            else
            {
                    Add(item:  -1930531024);
            }
            
            Add(item:  -1439668112);
            if(null != 0)
            {
                    Add(item:  1098586544);
            }
            else
            {
                    Add(item:  1098586544);
            }
            
            Add(item:  1098586544);
            if(null != 0)
            {
                    Add(item:  1098586544);
            }
            else
            {
                    Add(item:  1098586544);
            }
            
            Add(item:  1098586544);
            if(null != 0)
            {
                    Add(item:  -1513226352);
            }
            else
            {
                    Add(item:  -1513226352);
            }
            
            Add(item:  1098586544);
            if(null != 0)
            {
                    Add(item:  1098586544);
            }
            else
            {
                    Add(item:  1098586544);
            }
            
            Add(item:  1098586544);
            if(null != 0)
            {
                    Add(item:  1098586544);
            }
            else
            {
                    Add(item:  1098586544);
            }
            
            Add(item:  1098586544);
            if(null != 0)
            {
                    Add(item:  1098586544);
            }
            else
            {
                    Add(item:  1098586544);
            }
            
            Add(item:  -1513226352);
            if(null != 0)
            {
                    Add(item:  1098586544);
            }
            else
            {
                    Add(item:  1098586544);
            }
            
            Add(item:  1098586544);
            if(null != 0)
            {
                    Add(item:  1098586544);
            }
            else
            {
                    Add(item:  1098586544);
            }
            
            Add(item:  1098586544);
            if(null != 0)
            {
                    Add(item:  1098586544);
            }
            else
            {
                    Add(item:  1098586544);
            }
            
            Add(item:  1098586544);
            if(null != 0)
            {
                    Add(item:  -1439668112);
            }
            else
            {
                    Add(item:  -1439668112);
            }
            
            Add(item:  1098586544);
            if(null != 0)
            {
                    Add(item:  1098586544);
            }
            else
            {
                    Add(item:  1098586544);
            }
            
            Add(item:  1098586544);
            Add(item:  1098586544);
            typeof(SLC.Minigames.WordBalloon.WordBalloonLevelData).__il2cppRuntimeField_8 = null;
        }
        public WordBalloonManager()
        {
        
        }
    
    }

}
