using UnityEngine;

namespace WordPets
{
    public class ColData
    {
        // Fields
        public const char TILE_PROP_NULL = '\x2d';
        public const char TILE_PROP_ON = '\x78';
        private int <Id>k__BackingField;
        private int <maxHeight>k__BackingField;
        private bool <initialPet>k__BackingField;
        private WordPets.WordPetType <petType>k__BackingField;
        private int <petTimerCount>k__BackingField;
        private string <letterData>k__BackingField;
        private string tileCrateData;
        private string tileBalloonData;
        private string tileSpiderwebData;
        private string tileButterflyData;
        private string <letters>k__BackingField;
        
        // Properties
        public int Id { get; set; }
        public int maxHeight { get; set; }
        public bool initialPet { get; set; }
        public WordPets.WordPetType petType { get; set; }
        public int petTimerCount { get; set; }
        public string letterData { get; set; }
        public string letters { get; set; }
        public string initialLetters { get; set; }
        
        // Methods
        public int get_Id()
        {
            return (int)this.<Id>k__BackingField;
        }
        public void set_Id(int value)
        {
            this.<Id>k__BackingField = value;
        }
        public int get_maxHeight()
        {
            return (int)this.<maxHeight>k__BackingField;
        }
        public void set_maxHeight(int value)
        {
            this.<maxHeight>k__BackingField = value;
        }
        public bool get_initialPet()
        {
            return (bool)this.<initialPet>k__BackingField;
        }
        public void set_initialPet(bool value)
        {
            this.<initialPet>k__BackingField = value;
        }
        public WordPets.WordPetType get_petType()
        {
        
        }
        public void set_petType(WordPets.WordPetType value)
        {
            this.<petType>k__BackingField = value;
        }
        public int get_petTimerCount()
        {
            return (int)this.<petTimerCount>k__BackingField;
        }
        public void set_petTimerCount(int value)
        {
            this.<petTimerCount>k__BackingField = value;
        }
        public string get_letterData()
        {
        
        }
        public void set_letterData(string value)
        {
            this.<letterData>k__BackingField = value;
        }
        public string get_letters()
        {
        
        }
        protected void set_letters(string value)
        {
            this.<letters>k__BackingField = value;
        }
        public string get_initialLetters()
        {
        
        }
        public void set_initialLetters(string value)
        {
            this.<letters>k__BackingField = value;
        }
        public ColData(int columnId, System.Collections.Generic.Dictionary<string, object> myData)
        {
            string val_53;
            val_1 = new System.Object();
            this.<Id>k__BackingField = columnId;
            this.<petType>k__BackingField = 0;
            this.<petTimerCount>k__BackingField = 0;
            if((val_1.ContainsKey(key:  149070544)) != false)
            {
                    object val_3 = val_1.Item[149070544];
                string val_4 = val_1.ToString();
                string val_5 = 1.ToString();
                bool val_6 = System.String.op_Equality(a:  System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = myData, b:  151075295);
                this.<initialPet>k__BackingField = val_6;
                if(val_6 != false)
            {
                    if((val_1.ContainsKey(key:  151046304)) != false)
            {
                    object val_8 = val_1.Item[151046304];
                string val_9 = val_1.ToString();
                bool val_11 = System.Int32.TryParse(s:  val_1, result: out  int val_10 = 151075288);
            }
            
                if((val_1.ContainsKey(key:  151046384)) != false)
            {
                    object val_13 = val_1.Item[151046384];
                string val_14 = val_1.ToString();
                bool val_16 = System.Int32.TryParse(s:  val_1, result: out  int val_15 = 151075284);
            }
            
                this.<petType>k__BackingField = 0;
                this.<petTimerCount>k__BackingField = 0;
            }
            
            }
            
            if((val_1.ContainsKey(key:  149070464)) != false)
            {
                    object val_18 = val_1.Item[149070464];
                string val_19 = val_1.ToString();
                this.<maxHeight>k__BackingField = System.Int32.Parse(s:  val_1);
            }
            
            if((val_1.ContainsKey(key:  151046464)) != false)
            {
                    object val_22 = val_1.Item[151046464];
                if(val_1 != 0)
            {
                    object val_23 = val_1.Item[151046464];
                string val_24 = val_1.ToString();
                this.<letters>k__BackingField = val_1;
            }
            
            }
            
            val_53 = "ldt";
            if((val_1.ContainsKey(key:  151046544)) != false)
            {
                    object val_26 = val_1.Item[151046544];
                if(val_1 != 0)
            {
                    object val_27 = val_1.Item[151046544];
                val_53 = val_1;
                string val_28 = val_53.ToString();
                this.<letterData>k__BackingField = val_53;
            }
            
            }
            
            if((val_1.ContainsKey(key:  151046624)) != false)
            {
                    val_53 = 1152921510385703632;
                object val_30 = val_1.Item[151046624];
                if(val_1 != 0)
            {
                    object val_31 = val_1.Item[151046624];
                string val_32 = val_1.ToString();
                this.tileCrateData = val_1;
            }
            
            }
            
            bool val_33 = System.String.IsNullOrEmpty(value:  this.tileCrateData);
            if(val_33 != false)
            {
                    val_33.InitializeTilePropertyData(colHeight:  this.<maxHeight>k__BackingField, tilePropData: out  string val_34 = 151087360);
            }
            
            if((val_1.ContainsKey(key:  151050800)) != false)
            {
                    val_53 = 1152921510385703632;
                object val_36 = val_1.Item[151050800];
                if(val_1 != 0)
            {
                    object val_37 = val_1.Item[151050800];
                string val_38 = val_1.ToString();
                this.tileSpiderwebData = val_1;
            }
            
            }
            
            bool val_39 = System.String.IsNullOrEmpty(value:  this.tileSpiderwebData);
            if(val_39 != false)
            {
                    val_39.InitializeTilePropertyData(colHeight:  this.<maxHeight>k__BackingField, tilePropData: out  string val_40 = 151087368);
            }
            
            if((val_1.ContainsKey(key:  151054976)) != false)
            {
                    val_53 = 1152921510385703632;
                object val_42 = val_1.Item[151054976];
                if(val_1 != 0)
            {
                    object val_43 = val_1.Item[151054976];
                string val_44 = val_1.ToString();
                this.tileBalloonData = val_1;
            }
            
            }
            
            bool val_45 = System.String.IsNullOrEmpty(value:  this.tileBalloonData);
            if(val_45 != false)
            {
                    val_45.InitializeTilePropertyData(colHeight:  this.<maxHeight>k__BackingField, tilePropData: out  string val_46 = 151087364);
            }
            
            if((val_1.ContainsKey(key:  151059152)) != false)
            {
                    val_53 = 1152921510385703632;
                object val_48 = val_1.Item[151059152];
                if(val_1 != 0)
            {
                    object val_49 = val_1.Item[151059152];
                string val_50 = val_1.ToString();
                this.tileButterflyData = val_1;
            }
            
            }
            
            bool val_51 = System.String.IsNullOrEmpty(value:  this.tileButterflyData);
            if(val_51 == false)
            {
                    return;
            }
            
            val_51.InitializeTilePropertyData(colHeight:  this.<maxHeight>k__BackingField, tilePropData: out  string val_52 = 151087372);
        }
        public void InitializeTilePropertyData(int colHeight, out string tilePropData)
        {
            var val_2;
            int val_2 = colHeight;
            val_2 = 35636621;
            tilePropData = System.String.alignConst;
            if(val_2 < 1)
            {
                    return;
            }
            
            val_2 = "-";
            do
            {
                string val_1 = System.String.alignConst + 1359327184;
                val_2 = val_2 - 1;
                tilePropData = System.String.alignConst;
            }
            while(val_2 != 1);
        
        }
        public ColData(WordPets.ColData copyData)
        {
            if(copyData != 0)
            {
                    this.<Id>k__BackingField = copyData.<Id>k__BackingField;
                this.<maxHeight>k__BackingField = copyData.<maxHeight>k__BackingField;
                this.<letters>k__BackingField = copyData.<letters>k__BackingField;
                this.<letterData>k__BackingField = copyData.<letterData>k__BackingField;
                this.<initialPet>k__BackingField = copyData.<initialPet>k__BackingField;
                this.<petType>k__BackingField = copyData.<petType>k__BackingField;
                this.<petTimerCount>k__BackingField = copyData.<petTimerCount>k__BackingField;
                this.tileCrateData = copyData.tileCrateData;
                this.tileSpiderwebData = copyData.tileSpiderwebData;
                this.tileBalloonData = copyData.tileBalloonData;
            }
            else
            {
                    this.<Id>k__BackingField = 0;
                this.<maxHeight>k__BackingField = 0;
                this.<letters>k__BackingField = 1835037;
                this.<letterData>k__BackingField = 52;
                this.<initialPet>k__BackingField = true;
                this.<petType>k__BackingField = 1;
                this.<petTimerCount>k__BackingField = 0;
                this.tileCrateData = 35615780;
                this.tileSpiderwebData = 2097204;
                this.tileBalloonData = 83886592;
            }
            
            this.tileButterflyData = copyData.tileButterflyData;
        }
        public System.Collections.Generic.Dictionary<string, object> ToSerializableDictionary()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  149070544, value:  8945664);
            Add(key:  151046304, value:  13152256);
            Add(key:  151046384, value:  13152256);
            Add(key:  149070464, value:  13152256);
            Add(key:  151046464, value:  this.<letters>k__BackingField);
            Add(key:  151046544, value:  this.<letterData>k__BackingField);
            Add(key:  151046624, value:  this.tileCrateData);
            Add(key:  151050800, value:  this.tileSpiderwebData);
            Add(key:  151054976, value:  this.tileBalloonData);
            Add(key:  151059152, value:  this.tileButterflyData);
        }
        public void SetPet(bool hasPet)
        {
            this.<initialPet>k__BackingField = hasPet;
        }
        private bool GetTileStatusFlag(string statusString, int charIndex)
        {
            if((System.String.IsNullOrEmpty(value:  statusString)) == true)
            {
                    return (bool)0;
            }
            
            if(statusString.m_stringLength <= charIndex)
            {
                    return (bool)0;
            }
            
            char val_2 = statusString.Chars[charIndex];
            val_2 = val_2 - 120;
            0 = val_2 >> 5;
            return (bool)0;
        }
        private string SetTileStatusFlag(string statusString, int charIndex, bool isOn)
        {
            var val_4;
            var val_5;
            val_4 = isOn;
            if((charIndex >= 0) && (statusString.m_stringLength > charIndex))
            {
                    if(val_4 == true)
            {
                    45 = 120;
            }
            
                val_5 = "";
                if(statusString.m_stringLength < 1)
            {
                    return;
            }
            
                do
            {
                if(charIndex == 0)
            {
                    statusString.Chars[0] = 120;
            }
            
                string val_2 = statusString.Chars[0].ToString();
                string val_3 = 1098586544 + 151910974;
                val_5 = val_5;
                val_4 = 0 + 1;
            }
            while(val_4 < statusString.m_stringLength);
            
                return;
            }
            
            val_5 = statusString;
        }
        public bool IsTileCrate(int rowIndex)
        {
            return this.GetTileStatusFlag(statusString:  this.tileCrateData, charIndex:  rowIndex);
        }
        public bool IsTileBalloon(int rowIndex)
        {
            return this.GetTileStatusFlag(statusString:  this.tileBalloonData, charIndex:  rowIndex);
        }
        public bool IsTileSpiderweb(int rowIndex)
        {
            return this.GetTileStatusFlag(statusString:  this.tileSpiderwebData, charIndex:  rowIndex);
        }
        public bool IsTileButterfly(int rowIndex)
        {
            return this.GetTileStatusFlag(statusString:  this.tileButterflyData, charIndex:  rowIndex);
        }
        public void SetTileCrate(int rowIndex, bool isOn)
        {
            string val_1 = this.SetTileStatusFlag(statusString:  this.tileCrateData, charIndex:  rowIndex, isOn:  isOn);
            this.tileCrateData = this;
        }
        public void SetTileBalloon(int rowIndex, bool isOn)
        {
            string val_1 = this.SetTileStatusFlag(statusString:  this.tileBalloonData, charIndex:  rowIndex, isOn:  isOn);
            this.tileBalloonData = this;
        }
        public void SetTileSpiderweb(int rowIndex, bool isOn)
        {
            string val_1 = this.SetTileStatusFlag(statusString:  this.tileSpiderwebData, charIndex:  rowIndex, isOn:  isOn);
            this.tileSpiderwebData = this;
        }
        public void SetTileButterfly(int rowIndex, bool isOn)
        {
            string val_1 = this.SetTileStatusFlag(statusString:  this.tileButterflyData, charIndex:  rowIndex, isOn:  isOn);
            this.tileButterflyData = this;
        }
        public void AddTile(char letter, bool fromBottom = False)
        {
            var val_10;
            var val_11;
            object val_12;
            string val_13;
            val_10 = 35636624;
            if(fromBottom != false)
            {
                    val_11 = 1152921504616005632;
                string val_1 = 9158656 + this.<letterData>k__BackingField(this.<letterData>k__BackingField);
                this.<letterData>k__BackingField = null;
                string val_2 = 9158656 + this.tileCrateData;
                this.tileCrateData = null;
                string val_3 = 9158656 + this.tileSpiderwebData;
                this.tileSpiderwebData = null;
                string val_4 = 9158656 + this.tileBalloonData;
                this.tileBalloonData = null;
                val_12 = null;
                val_13 = this.tileButterflyData;
            }
            else
            {
                    val_10 = 1152921504616005632;
                string val_5 = this.<letterData>k__BackingField(this.<letterData>k__BackingField) + 9158656;
                this.<letterData>k__BackingField = this.<letterData>k__BackingField;
                val_11 = 45;
                string val_6 = this.tileCrateData + 9158656;
                this.tileCrateData = this.tileCrateData;
                string val_7 = this.tileSpiderwebData + 9158656;
                this.tileSpiderwebData = this.tileSpiderwebData;
                string val_8 = this.tileBalloonData + 9158656;
                this.tileBalloonData = this.tileBalloonData;
                val_13 = null;
                val_12 = this.tileButterflyData;
            }
            
            string val_9 = val_12 + 9158656;
            this.tileButterflyData = val_12;
        }
        public void RemoveTile(int rowIndex)
        {
            string val_22;
            string val_23;
            string val_24;
            int val_25;
            string val_26;
            int val_27;
            int val_28;
            int val_29;
            if(rowIndex < 0)
            {
                    return;
            }
            
            val_22 = this.<letterData>k__BackingField;
            if((this.<letterData>k__BackingField.m_stringLength) <= rowIndex)
            {
                    return;
            }
            
            val_23 = this.<letterData>k__BackingField;
            val_24 = val_23;
            if(val_23 == null)
            {
                    val_24 = this.<letterData>k__BackingField;
            }
            
            int val_22 = this.<letterData>k__BackingField.m_stringLength;
            val_22 = val_22 - 1;
            if(val_22 != rowIndex)
            {
                goto label_4;
            }
            
            if(val_24 == null)
            {
                goto label_5;
            }
            
            val_25 = this.<letterData>k__BackingField.m_stringLength;
            goto label_6;
            label_4:
            string val_1 = val_24.Substring(startIndex:  0, length:  rowIndex);
            int val_2 = rowIndex + 1;
            string val_3 = this.<letterData>k__BackingField.Substring(startIndex:  val_2);
            string val_4 = val_24 + this.<letterData>k__BackingField(this.<letterData>k__BackingField);
            this.<letterData>k__BackingField = val_24;
            string val_5 = this.tileCrateData.Substring(startIndex:  0, length:  rowIndex);
            string val_6 = this.tileCrateData.Substring(startIndex:  val_2);
            string val_7 = this.tileCrateData + this.tileCrateData;
            this.tileCrateData = this.tileCrateData;
            string val_8 = this.tileSpiderwebData.Substring(startIndex:  0, length:  rowIndex);
            string val_9 = this.tileSpiderwebData.Substring(startIndex:  val_2);
            string val_10 = this.tileSpiderwebData + this.tileSpiderwebData;
            this.tileSpiderwebData = this.tileSpiderwebData;
            string val_11 = this.tileBalloonData.Substring(startIndex:  0, length:  rowIndex);
            val_23 = this.tileBalloonData;
            string val_12 = this.tileBalloonData.Substring(startIndex:  val_2);
            string val_13 = val_23 + this.tileBalloonData;
            this.tileBalloonData = val_23;
            string val_14 = this.tileButterflyData.Substring(startIndex:  0, length:  rowIndex);
            val_22 = this.tileButterflyData;
            string val_15 = val_22.Substring(startIndex:  val_2);
            val_26 = this.tileButterflyData;
            string val_16 = val_26 + val_22;
            goto label_17;
            label_5:
            val_25 = 0;
            label_6:
            string val_17 = val_24.Substring(startIndex:  0, length:  -1);
            this.<letterData>k__BackingField = val_24;
            if(this.tileCrateData != null)
            {
                    val_27 = this.tileCrateData.m_stringLength;
            }
            else
            {
                    val_27 = 0;
            }
            
            string val_18 = this.tileCrateData.Substring(startIndex:  0, length:  -1);
            this.tileCrateData = this.tileCrateData;
            if(this.tileSpiderwebData != null)
            {
                    val_28 = this.tileSpiderwebData.m_stringLength;
            }
            else
            {
                    val_28 = 0;
            }
            
            string val_19 = this.tileSpiderwebData.Substring(startIndex:  0, length:  -1);
            this.tileSpiderwebData = this.tileSpiderwebData;
            if(this.tileBalloonData != null)
            {
                    val_29 = this.tileBalloonData.m_stringLength;
            }
            else
            {
                    val_29 = 0;
            }
            
            string val_20 = this.tileBalloonData.Substring(startIndex:  0, length:  -1);
            this.tileBalloonData = this.tileBalloonData;
            if(this.tileButterflyData != null)
            {
                    val_22 = this.tileButterflyData.m_stringLength;
            }
            else
            {
                    val_22 = 0;
            }
            
            val_26 = this.tileButterflyData;
            string val_21 = val_26.Substring(startIndex:  0, length:  -1);
            label_17:
            this.tileButterflyData = val_26;
        }
        public void ModifyTileLetter(int tileIndex, char letter)
        {
            if(tileIndex < 0)
            {
                    return;
            }
            
            if((this.<letterData>k__BackingField.m_stringLength) <= tileIndex)
            {
                    return;
            }
            
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(value:  this.<letterData>k__BackingField);
            if(val_1 != 0)
            {
                    set_Chars(index:  tileIndex, value:  letter);
            }
            else
            {
                    set_Chars(index:  tileIndex, value:  letter);
            }
            
            this.<letterData>k__BackingField = val_1;
        }
    
    }

}
