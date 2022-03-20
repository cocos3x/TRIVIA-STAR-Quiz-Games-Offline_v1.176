using UnityEngine;

namespace WordPets
{
    public class WPTShelterInventory : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text titleText;
        private UnityEngine.Transform scrollViewContentTransform;
        private UnityEngine.GameObject petStoredPrefab;
        private System.Collections.Generic.List<WordPets.PetData> petDataList;
        private System.Collections.Generic.List<WordPets.WPTStoredPetDisplay> petDisplays;
        private WordPets.WordPetType lastPetAdded;
        
        // Methods
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  221079600, name:  218632096);
        }
        private void OnEnable()
        {
            this.ClearPets();
            this.LoadPets();
        }
        private void OnDisable()
        {
        
        }
        private void OnPetPickup()
        {
            this.ClearPets();
            this.LoadPets();
        }
        public void Refresh()
        {
            this.ClearPets();
            this.LoadPets();
        }
        public UnityEngine.Vector3 AddPet(WordPets.WordPetType type)
        {
            WordPets.WordPetType val_17;
            var val_18;
            WordPets.WPTShelterInventory val_19;
            var val_20;
            var val_21;
            WordPets.WPTShelterInventory val_22;
            val_17 = R2;
            mem2[0] = val_17;
            val_18 = 4;
            val_19 = 16;
            object val_1 =  - 4;
            val_20 = 35626076;
            WordPets.PetData val_2 = new WordPets.PetData(newType:  val_17, newAmount:  1);
            static_value_021F9C5C.Add(item:  new WordPets.PetData() {type = val_2.type, amount = val_2.amount});
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  val_1, parent:  static_value_021F9C5C);
            object val_4 = val_1.GetComponent<System.Object>();
            if(val_1 != 0)
            {
                    val_21 = 0;
                val_1.SetPet(type:  val_17);
                val_1.SetAmount(amount:  1);
            }
            else
            {
                    val_21 = 0;
                0.SetPet(type:  val_17);
                val_1.SetAmount(amount:  1);
            }
            
            val_22 = this;
            UnityEngine.Transform val_12 = val_1.transform;
            val_1.SetAsFirstSibling();
            UnityEngine.Transform val_13 = val_1.transform;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            val_1.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_15 = val_1.transform;
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  val_14.x, duration:  val_14.y);
            val_1.Add(item:  val_1);
            type.SetTitleText();
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        }
        public void RemoveLastPet()
        {
            bool val_1 = this.RemovePet(type:  this.lastPetAdded);
        }
        public bool RemovePet(WordPets.WordPetType type)
        {
            WordPets.WordPetType val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = type;
            val_4 = 0;
            val_5 = 16;
            goto label_1;
            label_6:
            if(true <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(2621443 == val_3)
            {
                goto label_4;
            }
            
            val_5 = 24;
            val_4 = 1;
            label_1:
            if(val_4 < 2621443)
            {
                goto label_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
            label_4:
            if(2621443 <= val_4)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + val_5;
            WordPets.PetData val_2 = new WordPets.PetData(newType:  val_3, newAmount:  ((0 + val_5) + 4) - 1);
            this.petDataList.set_Item(index:  0, value:  new WordPets.PetData() {type = val_2.type, amount = val_2.amount});
            if(this.petDataList <= val_4)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + val_5;
            if(val_5 <= val_4)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            if(((0 + val_5) + 4) > 0)
            {
                    val_3 = this.petDataList;
                if(val_6 <= val_4)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = val_7 + val_5;
                (0 + 0) + 16.SetAmount(amount:  (0 + val_5) + 4);
            }
            else
            {
                    UnityEngine.GameObject val_3 = (0 + 0) + 16.gameObject;
                UnityEngine.Object.Destroy(obj:  (0 + 0) + 16);
                this.petDisplays.RemoveAt(index:  0);
                val_3 = this.petDataList;
                val_3.RemoveAt(index:  0);
            }
            
            this.SetTitleText();
            val_6 = 1;
            return (bool)val_6;
        }
        private void ClearPets()
        {
            var val_2;
            System.Collections.Generic.List<WordPets.WPTStoredPetDisplay> val_3;
            if(true < 1)
            {
                    return;
            }
            
            val_2 = 0;
            goto label_3;
            label_10:
            val_3 = this.petDisplays;
            if(val_3 == 0)
            {
                    val_3 = 0;
            }
            
            if(val_2 >= R7)
            {
                goto label_5;
            }
            
            label_11:
            if(0 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = 0;
            val_2 = val_2 + 0;
            UnityEngine.GameObject val_1 = (0 + 0) + 16.gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  (0 + 0) + 16);
            val_2 = 1;
            label_3:
            val_3 = this.petDisplays;
            if(val_3 == 0)
            {
                goto label_10;
            }
            
            if(val_2 < ((0 + 0) + 16))
            {
                goto label_11;
            }
            
            label_5:
            val_3.Clear();
        }
        private void LoadPets()
        {
            System.Collections.Generic.List<WordPets.WPTStoredPetDisplay> val_5;
            var val_6;
            var val_7;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<WordPets.PetData> val_2 = new System.Collections.Generic.List<WordPets.PetData>(collection:  public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_14);
            this.petDataList = null;
            Reverse();
            val_6 = 0;
            val_7 = 16;
            goto label_5;
            label_16:
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.petStoredPrefab, parent:  this.scrollViewContentTransform);
            object val_4 = this.petStoredPrefab.GetComponent<System.Object>();
            if(this.petStoredPrefab <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 <= val_6)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + val_7;
            this.petStoredPrefab.SetPet(type:  2621443);
            this.petStoredPrefab.SetAmount(amount:  (0 + val_7) + 4);
            val_5 = this.petDisplays;
            val_5.Add(item:  this.petStoredPrefab);
            val_7 = 24;
            val_6 = 1;
            label_5:
            if(val_6 < val_5)
            {
                goto label_16;
            }
            
            this.SetTitleText();
        }
        private void SetTitleText()
        {
            int val_1 = this.GetTotalPetAmount();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_3 = ShelterCapacity;
            string val_4 = System.String.Format(format:  222349680, arg0:  13152256, arg1:  13152256);
            if(this.titleText != 0)
            {
                    return;
            }
        
        }
        private int GetTotalPetAmount()
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
        public void OnInventoryClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CloseCurrentWindow();
            GameBehavior val_2 = App.getBehavior;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  null, mode:  1);
        }
        public WPTShelterInventory()
        {
            System.Collections.Generic.List<WordPets.PetData> val_1 = new System.Collections.Generic.List<WordPets.PetData>();
            this.petDataList = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.petDisplays = null;
        }
    
    }

}
