using UnityEngine;

namespace WordPets
{
    public class WPTShelterController : MonoSingleton<WordPets.WPTShelterController>
    {
        // Fields
        private const string shelterDataKey = "wpt_shelter_data";
        private const string pickupTimeKey = "wpt_pickup_time";
        public static int HACK_PetTimerModifier;
        private WordPets.WordPet[] wordPets;
        private System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> petDictionary;
        private System.Collections.Generic.List<WordPets.PetData> petDataList;
        private System.DateTime pickUpTime;
        private WordPets.WordPetType lastAddedPet;
        private WordPets.WPTGameEcon gameEcon;
        
        // Properties
        public WordPets.WordPet[] getPetPrefabs { get; }
        public System.Collections.Generic.List<WordPets.PetData> PetDataList { get; }
        public System.DateTime PickUpTime { get; }
        public int ShelterCapacity { get; }
        
        // Methods
        public WordPets.WordPet[] get_getPetPrefabs()
        {
        
        }
        public System.Collections.Generic.List<WordPets.PetData> get_PetDataList()
        {
        
        }
        public System.DateTime get_PickUpTime()
        {
            this = R1 + 24;
            return new System.DateTime() {dateData = 1152921513412215344};
        }
        public int get_ShelterCapacity()
        {
            if(this.gameEcon != 0)
            {
                    return (int)this.gameEcon.shelterCapacity;
            }
            
            return (int)this.gameEcon.shelterCapacity;
        }
        public override void InitMonoSingleton()
        {
            WordPets.WPTGameEcon val_2;
            this.BuildPetDictionary();
            this.LoadShelterData();
            val_2 = 0;
            GameEcon val_1 = App.getGameEcon;
            if(0 != 0)
            {
                    if(((mem[1179403747] + (WordPets.WPTGameEcon.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    0 = 0;
            }
            
                val_2 = 0;
            }
            
            this.gameEcon = val_2;
        }
        public void AddPet(WordPets.WordPetType type)
        {
            int val_3;
            System.Collections.Generic.List<WordPets.PetData> val_4;
            System.Collections.Generic.List<WordPets.PetData> val_5;
            WordPets.WordPetType val_6;
            int val_7;
            var val_8;
            val_3 = 0;
            this.lastAddedPet = type;
            goto label_1;
            label_6:
            if((R5 + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((R5 + 8 + 16) == type)
            {
                goto label_4;
            }
            
            val_3 = 1;
            label_1:
            val_4 = this.petDataList;
            val_5 = val_4;
            if(val_4 == 0)
            {
                    val_5 = this.petDataList;
            }
            
            if(val_3 < (R5 + 8 + 16))
            {
                goto label_6;
            }
            
            WordPets.PetData val_1 = new WordPets.PetData(newType:  type, newAmount:  1);
            val_8 = public System.Void System.Collections.Generic.List<WordPets.PetData>::Add(WordPets.PetData item);
            goto label_8;
            label_4:
            if((R5 + 8 + 16) <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 16;
            WordPets.PetData val_3 = new WordPets.PetData(newType:  type, newAmount:  ((0 + 16) + 4) + 1);
            this.petDataList.RemoveAt(index:  0);
            val_4 = this.petDataList;
            val_3 = val_3.amount;
            val_6 = val_3.type;
            val_7 = val_3;
            val_8 = public System.Void System.Collections.Generic.List<WordPets.PetData>::Add(WordPets.PetData item);
            label_8:
            val_4.Add(item:  new WordPets.PetData() {type = val_6, amount = val_7});
            this.SaveShelterData();
        }
        public void RemoveLastAddedPet()
        {
            this.RemovePet(petType:  this.lastAddedPet);
        }
        public void RemovePet(WordPets.WordPetType petType)
        {
            var val_3;
            var val_4;
            System.Collections.Generic.List<WordPets.PetData> val_5;
            val_3 = 0;
            val_4 = 16;
            goto label_1;
            label_6:
            if(true <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(2621443 == petType)
            {
                goto label_4;
            }
            
            val_4 = 24;
            val_3 = 1;
            label_1:
            val_5 = this.petDataList;
            if(val_3 < 2621443)
            {
                goto label_6;
            }
            
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_1 = 216049648 + 402341888 + 216049760;
            UnityEngine.Debug.LogError(message:  216049648);
            return;
            label_4:
            if(2621443 <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + val_4;
            WordPets.PetData val_3 = new WordPets.PetData(newType:  petType, newAmount:  ((0 + val_4) + 4) - 1);
            this.petDataList.set_Item(index:  0, value:  new WordPets.PetData() {type = val_3.type, amount = val_3.amount});
            val_5 = this.petDataList;
            if(this.petDataList <= val_3)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + val_4;
            if(((0 + val_4) + 4) <= 0)
            {
                    val_5 = this.petDataList;
                val_5.RemoveAt(index:  0);
            }
            
            this.SaveShelterData();
        }
        public bool IsShelterFull()
        {
            if(this.GetPetCount() >= this.gameEcon.shelterCapacity)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool CanRetryAddPet()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= 16)
            {
                    return false;
            }
            
                if(16 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_1 = 16 + 8;
                val_2 = val_2 + 1;
            }
            while(this.lastAddedPet != (R1 + 16));
            
            return true;
        }
        public int GetPetCount()
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = 0;
            val_2 = 16;
            val_3 = 0;
            goto label_1;
            label_5:
            if(true <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = 1;
            val_1 = val_1 + val_2;
            val_2 = 24;
            val_3 = val_3 + ((0 + val_2) + 4);
            label_1:
            if(val_1 < ((0 + val_2) + 4))
            {
                goto label_5;
            }
            
            return (int)val_3;
        }
        public bool IsPickupReady()
        {
            ulong val_2;
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = this.pickUpTime});
        }
        private void SetPickupTime()
        {
            long val_5;
            System.DateTime val_9;
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            System.TimeSpan val_2 = PickupInterval;
            System.DateTime val_7 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921513413494544}, t:  new System.TimeSpan() {_ticks = val_5});
            this.pickUpTime = val_9;
        }
        public System.TimeSpan GetTimeTillPickup()
        {
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513413622688}, d2:  new System.DateTime() {dateData = R1 + 24});
            return new System.TimeSpan() {_ticks = val_4._ticks};
        }
        public string GetTimeTillPickupString()
        {
            System.TimeSpan val_1 = GetTimeTillPickup();
            string val_4 = val_1._ticks.FormatTime(timeSpan:  new System.TimeSpan() {_ticks = 1152921513413734688});
        }
        public void DoPetPickup(bool fullPickup)
        {
        
        }
        public WordPets.WordPet GetPet(WordPets.WordPetType petType)
        {
            goto label_1;
            label_7:
            WordPets.WordPet val_3 = this.wordPets[0];
            if(this.wordPets[0].type == petType)
            {
                goto label_5;
            }
            
            4 = 5;
            label_1:
            if((4 - 4) < this.wordPets[0].type)
            {
                goto label_7;
            }
            
            string val_2 = System.String.Format(format:  217239136, arg0:  402341888);
            SLCDebug.Log(logMessage:  217239136, colorHash:  -1835139200, isError:  true);
            WordPets.WordPet val_4 = this.wordPets[0];
            return;
            label_5:
            WordPets.WordPet val_5 = this.wordPets[0];
        }
        public WordPets.WordPet GetRandomPet()
        {
            WordPets.WPTGameEcon val_6;
            int val_7;
            val_6 = this.gameEcon;
            if(val_6 == 0)
            {
                goto label_1;
            }
            
            val_7 = this.gameEcon.commonPetChance;
            goto label_2;
            label_1:
            val_7 = this.gameEcon.commonPetChance;
            val_6 = this.gameEcon;
            if(val_6 == 0)
            {
                goto label_3;
            }
            
            label_2:
            int val_6 = this.gameEcon.uncommonPetChance;
            label_11:
            label_12:
            int val_7 = this.gameEcon.rarePetChance;
            int val_1 = val_6 + val_7;
            val_6 = val_7 + val_1;
            val_7 = this.gameEcon.ultraRarePetChance + val_6;
            int val_2 = UnityEngine.Random.Range(min:  0, max:  val_7);
            if(val_2 >= val_7)
            {
                    0 = 1;
            }
            
            if(val_2 >= val_1)
            {
                goto label_4;
            }
            
            label_10:
            System.Collections.Generic.List<WordPets.WordPet> val_3 = this.petDictionary.Item[1];
            System.Collections.Generic.List<WordPets.WordPet> val_4 = this.petDictionary.Item[1];
            int val_5 = UnityEngine.Random.Range(min:  0, max:  1);
            if(val_5 <= val_5)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (val_5 << 2);
            return;
            label_4:
            if(val_2 < val_6)
            {
                    3 = 2;
            }
            
            goto label_10;
            label_3:
            if(this.gameEcon != 0)
            {
                goto label_11;
            }
            
            if(this.gameEcon != 0)
            {
                goto label_12;
            }
        
        }
        public int GetMovesBeforeEscape(WordPets.WordPetRarity rarity)
        {
            WordPets.WPTGameEcon val_3;
            var val_4;
            int val_5;
            var val_6;
            if(rarity > 3)
            {
                goto label_2;
            }
            
            var val_1 = 12958364 + (12958364 + (rarity) << 2);
            if(rarity == 3)
            {
                    12958364 = 12958364;
                12958364 = 12958364 & 217803712;
                12958364 = 12958364 & (((int)IP) >> 32);
                12958364 = 12958364 & (((this) << (32-as. 
                
            
            
            
            
            
               
            )) | ((this) << as. 
                
            
            
            
            
            
               
            ));
            }
            
            val_3 = this.gameEcon;
            val_4 = 1356;
            goto label_9;
            label_2:
            val_5 = this.gameEcon.commonMoveTime;
            goto label_7;
            label_9:
            val_5 = this.gameEcon.ultraRareMoveTime;
            label_7:
            val_6 = null;
            val_6 = null;
            return UnityEngine.Mathf.Max(a:  1, b:  WordPets.WPTShelterController.HACK_PetTimerModifier + val_5);
        }
        private void SaveShelterData()
        {
            string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.petDataList);
            UnityEngine.PlayerPrefs.SetString(key:  217912192, value:  this.petDataList);
            string val_2 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  9904128);
            UnityEngine.PlayerPrefs.SetString(key:  217912304, value:  9904128);
            bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        }
        private void LoadShelterData()
        {
            System.DateTime val_9;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  217912192, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  217912192)) != true)
            {
                    object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  217912192);
                this.petDataList = "wpt_shelter_data";
            }
            
            string val_4 = UnityEngine.PlayerPrefs.GetString(key:  217912304, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  217912304)) != false)
            {
                    System.DateTime val_6 = DateTimeCheat.UtcNow;
            }
            else
            {
                    System.DateTime val_7 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.DateTime>(value:  218041512);
            }
            
            this.pickUpTime = val_9;
        }
        private void BuildPetDictionary()
        {
            var val_7;
            var val_8;
            System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
            this.petDictionary = null;
            val_7 = 0;
            goto label_1;
            label_19:
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.petDictionary.set_Item(key:  0, value:  80883712);
            val_8 = 4;
            goto label_3;
            label_13:
            WordPets.WordPet val_8 = this.wordPets[0];
            if(this.wordPets[0].rarity == val_7)
            {
                    System.Collections.Generic.List<WordPets.WordPet> val_3 = this.petDictionary.Item[0];
                this.petDictionary.Add(item:  this.wordPets[0]);
            }
            
            val_8 = 5;
            label_3:
            if((val_8 - 4) < this.petDictionary)
            {
                goto label_13;
            }
            
            val_7 = 1;
            label_1:
            System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(402288640)});
            System.Array val_6 = System.Enum.GetValues(enumType:  402288640);
            if(val_7 < Length)
            {
                goto label_19;
            }
        
        }
        public string FormatTime(System.TimeSpan timeSpan)
        {
            var val_18;
            if((???.Days) >= 1)
            {
                    int val_2 = ???.Days;
                val_18 = 1152921504619999232;
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                int val_3 = ???.Hours;
                typeof(System.Object[]).__il2cppRuntimeField_14 = null;
                int val_4 = ???.Minutes;
                typeof(System.Object[]).__il2cppRuntimeField_18 = null;
                int val_5 = ???.Seconds;
                typeof(System.Object[]).__il2cppRuntimeField_1C = null;
                string val_6 = System.String.Format(format:  218519776, args:  472754880);
                return;
            }
            
            if((???.Hours) >= 1)
            {
                    int val_8 = ???.Hours;
                int val_9 = ???.Minutes;
                val_18 = null;
                int val_10 = ???.Seconds;
                string val_11 = System.String.Format(format:  218519888, arg0:  13152256, arg1:  13152256, arg2:  13152256);
                return;
            }
            
            if((???.Minutes) >= 1)
            {
                    int val_13 = ???.Minutes;
                val_18 = 1152921504619999232;
                int val_14 = ???.Seconds;
                string val_15 = System.String.Format(format:  218520000, arg0:  13152256, arg1:  13152256);
                return;
            }
            
            string val_17 = ???.Seconds.ToString();
        }
        public void QAHACK_GiveRandomPet()
        {
            this.AddPet(type:  UnityEngine.Random.Range(min:  0, max:  35));
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  218656192, aName:  218632096);
        }
        public void QAHACK_MaxOutShelter()
        {
            goto label_1;
            label_5:
            this.AddPet(type:  UnityEngine.Random.Range(min:  0, max:  35));
            label_1:
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsShelterFull() == false)
            {
                goto label_5;
            }
            
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  218768192, aName:  218632096);
        }
        public void QAHACK_EmptyShelter()
        {
            this.petDataList.Clear();
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  218885312, aName:  218632096);
        }
        public void QAHACK_ResetPickupTIme()
        {
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            this.pickUpTime = new System.DateTime();
        }
        public WPTShelterController()
        {
            System.Collections.Generic.List<WordPets.PetData> val_1 = new System.Collections.Generic.List<WordPets.PetData>();
            this.petDataList = null;
        }
        private static WPTShelterController()
        {
        
        }
    
    }

}
