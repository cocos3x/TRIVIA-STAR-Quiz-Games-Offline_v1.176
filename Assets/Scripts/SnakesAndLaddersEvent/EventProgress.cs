using UnityEngine;

namespace SnakesAndLaddersEvent
{
    public class EventProgress : EventProgression
    {
        // Fields
        private const string EVENT_PROGRESS = "snl_evt_prg";
        private const string DICE_BALANCE = "dice_balance";
        private const string BOARDS_STATUS = "boards";
        private const string EVENT_TIMESTAMP = "timestamp";
        private const string LAST_PRG_TIMESTAMP = "last_prg_timestamp";
        private const string STARTER_PACK_STATUS = "starter_pack_status";
        private const string DICE_PROGRESS = "dice_progress";
        private const string DICE_ROLLED = "dice_rolled";
        public int DiceBalance;
        public int DiceRolled;
        public int Timestamp;
        public int LastProgressTimestamp;
        public System.Collections.Generic.List<SnakesAndLaddersEvent.Board> Boards;
        public SnakesAndLaddersEvent.StarterDicePackStatus StarterPackStatus;
        public SnakesAndLaddersEvent.MovingDiceRollProgress DiceRollProgress;
        
        // Methods
        public EventProgress()
        {
            typeof(SnakesAndLaddersEvent.StarterDicePackStatus).__il2cppRuntimeField_14 = 0;
            typeof(SnakesAndLaddersEvent.StarterDicePackStatus).__il2cppRuntimeField_10 = 0;
            typeof(SnakesAndLaddersEvent.StarterDicePackStatus).__il2cppRuntimeField_8 = 0;
            this.StarterPackStatus = new System.Object();
            this.DiceRollProgress = new System.Object();
        }
        public void Initialize()
        {
            null = null;
            this.DiceBalance = SnakesAndLaddersEvent.Econ.DefaultDiceRolls;
            this.DiceRolled = 0;
            this.InitBoards();
        }
        public override void LoadFromJSON()
        {
            SnakesAndLaddersEvent.MovingDiceRollProgress val_29;
            SnakesAndLaddersEvent.StarterDicePackStatus val_30;
            var val_31;
            var val_32;
            string val_1 = CPlayerPrefs.GetString(key:  681470464);
            val_29 = "snl_evt_prg";
            if((System.String.IsNullOrEmpty(value:  681470464)) == true)
            {
                    return;
            }
            
            object val_3 = MiniJSON.Json.Deserialize(json:  681470464);
            if(val_29 != 0)
            {
                    if(null == null)
            {
                goto label_44;
            }
            
            }
            
            label_44:
            val_30 = 1152921510392296080;
            if((0.ContainsKey(key:  681470560)) != false)
            {
                    string val_5 = 0.Item[681470560];
                val_29 = 0;
                bool val_7 = System.Int32.TryParse(s:  null, result: out  this.DiceBalance);
            }
            
            if((0.ContainsKey(key:  681470656)) != false)
            {
                    string val_9 = 0.Item[681470656];
                val_29 = 0;
                bool val_11 = System.Int32.TryParse(s:  null, result: out  this.DiceRolled);
            }
            
            if((0.ContainsKey(key:  1470901296)) != false)
            {
                    string val_13 = 0.Item[1470901296];
                val_29 = 0;
                bool val_15 = System.Int32.TryParse(s:  null, result: out  this.Timestamp);
            }
            
            if((0.ContainsKey(key:  -1176570720)) != false)
            {
                    string val_17 = 0.Item[-1176570720];
                val_29 = 0;
                bool val_19 = System.Int32.TryParse(s:  null, result: out  this.LastProgressTimestamp);
            }
            
            if((0.ContainsKey(key:  681470752)) == false)
            {
                goto label_23;
            }
            
            string val_21 = 0.Item[681470752];
            val_29 = 0;
            val_31 = 0;
            object val_22 = MiniJSON.Json.Deserialize(json:  null);
            if(val_29 != 0)
            {
                    if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_29 = 0;
            }
            
                val_31 = val_29;
            }
            
            val_32 = 4;
            goto label_28;
            label_35:
            if(val_29 <= mem[1179403827])
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_29 = 2621443;
            if(false <= mem[1179403827])
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_29.LoadProgress(data:  2621443);
            val_32 = 5;
            label_28:
            val_30 = val_32 - 4;
            if(val_30 < 0)
            {
                goto label_35;
            }
            
            label_23:
            if((0.ContainsKey(key:  681474928)) != false)
            {
                    string val_24 = 0.Item[681474928];
                val_29 = 0;
                SnakesAndLaddersEvent.StarterDicePackStatus val_25 = null;
                val_30 = val_25;
                val_25 = new SnakesAndLaddersEvent.StarterDicePackStatus(data:  null);
                this.StarterPackStatus = val_30;
            }
            
            if((0.ContainsKey(key:  681475040)) == false)
            {
                    return;
            }
            
            string val_27 = 0.Item[681475040];
            SnakesAndLaddersEvent.MovingDiceRollProgress val_28 = null;
            val_29 = val_28;
            val_28 = new SnakesAndLaddersEvent.MovingDiceRollProgress(data:  null);
            this.DiceRollProgress = val_29;
        }
        public override void SaveToJSON()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  681470560, value:  13152256);
            Add(key:  681470656, value:  13152256);
            Add(key:  1470901296, value:  13152256);
            Add(key:  -1176570720, value:  13152256);
            string val_2 = MiniJSON.Json.Serialize(obj:  this.Boards);
            Add(key:  681470752, value:  this.Boards);
            Add(key:  681474928, value:  this.StarterPackStatus);
            Add(key:  681475040, value:  this.DiceRollProgress);
            string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
            CPlayerPrefs.SetString(key:  681470464, val:  78753792);
            bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public override void Delete()
        {
            CPlayerPrefs.DeleteKey(key:  681470464);
        }
        public void ResetBoardProgress()
        {
            var val_2;
            List.Enumerator<T> val_1 = GetEnumerator();
            goto label_2;
            label_5:
            if(val_2 != 0)
            {
                    mem2[0] = 0;
            }
            else
            {
                    mem[12] = 0;
            }
            
            mem2[0] = 0;
            label_2:
            if(MoveNext() == true)
            {
                goto label_5;
            }
            
            Dispose();
        }
        private void InitBoards()
        {
            var val_3;
            var val_4;
            var val_5;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.Boards = null;
            val_3 = 0;
            goto label_1;
            label_10:
            val_4 = null;
            val_4 = null;
            if((SnakesAndLaddersEvent.Econ.BoardDefinitions + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = SnakesAndLaddersEvent.Econ.BoardDefinitions + 8;
            val_3 = val_3 + 0;
            object val_2 = new System.Object();
            typeof(SnakesAndLaddersEvent.Board).__il2cppRuntimeField_8 = (SnakesAndLaddersEvent.Econ.BoardDefinitions + 8 + 0) + 16;
            typeof(SnakesAndLaddersEvent.Board).__il2cppRuntimeField_C = 0;
            typeof(SnakesAndLaddersEvent.Board).__il2cppRuntimeField_10 = 0;
            this.Boards.Add(item:  432480256);
            val_3 = 1;
            label_1:
            val_5 = null;
            val_5 = null;
            if(val_3 < (SnakesAndLaddersEvent.Econ.BoardDefinitions + 12))
            {
                goto label_10;
            }
        
        }
    
    }

}
