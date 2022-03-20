using UnityEngine;

namespace WordPets
{
    public class WPTPetTile : WPTGameTile
    {
        // Fields
        public const WordPets.WordPetType UNDEFINED_PET_TYPE = -1;
        private WordPets.WordPet <myPet>k__BackingField;
        private int <myMoveTime>k__BackingField;
        private UnityEngine.UI.Text myText;
        private UnityEngine.Transform petTransform;
        private UnityEngine.ParticleSystem particle;
        private float runningSpeed;
        private float fallingSpeed;
        
        // Properties
        public WordPets.WordPet myPet { get; set; }
        public int myMoveTime { get; set; }
        
        // Methods
        public WordPets.WordPet get_myPet()
        {
        
        }
        protected void set_myPet(WordPets.WordPet value)
        {
            this.<myPet>k__BackingField = value;
        }
        public int get_myMoveTime()
        {
            return (int)this.<myMoveTime>k__BackingField;
        }
        protected void set_myMoveTime(int value)
        {
            this.<myMoveTime>k__BackingField = value;
        }
        public override bool IsLetter()
        {
            return false;
        }
        public void DisplayPet(WordPets.WordPet thisPet, int moveCounter = -1)
        {
            int val_15;
            WordPets.WordPet val_16;
            int val_17;
            val_15 = moveCounter;
            UnityEngine.GameObject val_1 = thisPet.gameObject;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  thisPet, parent:  this.petTransform);
            object val_3 = thisPet.GetComponent<System.Object>();
            this.<myPet>k__BackingField = thisPet;
            UnityEngine.Transform val_4 = thisPet.transform;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            thisPet.localPosition = new UnityEngine.Vector3();
            this.<myPet>k__BackingField.AnimateIdle();
            if(val_15 <= 1)
            {
                    twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_15 = GetMovesBeforeEscape(rarity:  this.<myPet>k__BackingField.rarity);
            }
            
            this.<myMoveTime>k__BackingField = val_15;
            if((this.<myPet>k__BackingField) == 0)
            {
                goto label_15;
            }
            
            this.runningSpeed = this.<myPet>k__BackingField.runSpeed;
            val_16 = this.<myPet>k__BackingField;
            goto label_16;
            label_15:
            val_16 = this.<myPet>k__BackingField;
            this.runningSpeed = this.<myPet>k__BackingField.runSpeed;
            if(val_16 == 0)
            {
                goto label_17;
            }
            
            label_16:
            this.fallingSpeed = this.<myPet>k__BackingField.fallSpeed;
            mem2[0] = 1;
            mem2[0] = this.<myPet>k__BackingField.type;
            val_17 = this.<myMoveTime>k__BackingField;
            mem2[0] = val_17;
            if(this.myText == 0)
            {
                    return;
            }
            
            string val_9 = this.<myMoveTime>k__BackingField.ToString();
            val_17;
            UnityEngine.Transform val_10 = this.myText.transform;
            UnityEngine.Transform val_11 = this.myText.parent;
            this.myText.SetAsLastSibling();
            if((this.<myMoveTime>k__BackingField) > 1)
            {
                    return;
            }
            
            UnityEngine.Transform val_12 = this.myText.transform;
            UnityEngine.Transform val_13 = this.myText.parent;
            UnityEngine.GameObject val_14 = this.myText.gameObject;
            this.myText.SetActive(value:  false);
            return;
            label_17:
        }
        public override void SetDimension(UnityEngine.Vector2 size)
        {
            var val_2;
            var val_4;
            this.SetDimension(size:  new UnityEngine.Vector2() {x = size.x, y = size.y});
            UnityEngine.Vector2 val_1 = Value;
            UnityEngine.Vector2 val_3 = Value;
            float val_6 = size.x;
            float val_7 = size.y;
            val_6 = val_6 / val_2;
            val_7 = val_7 / val_4;
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_6, y:  val_3.y, z:  val_7);
            this.petTransform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void SavePet()
        {
        
        }
        public System.Collections.IEnumerator RunAway()
        {
            object val_1 = new System.Object();
            typeof(WPTPetTile.<RunAway>d__18).__il2cppRuntimeField_8 = 0;
            typeof(WPTPetTile.<RunAway>d__18).__il2cppRuntimeField_10 = this;
        }
        public System.Collections.IEnumerator FlyAway()
        {
            object val_1 = new System.Object();
            typeof(WPTPetTile.<FlyAway>d__19).__il2cppRuntimeField_8 = 0;
            typeof(WPTPetTile.<FlyAway>d__19).__il2cppRuntimeField_10 = this;
        }
        public System.Collections.IEnumerator AnimateCapture(UnityEngine.Vector3 targetFlyToPos)
        {
            typeof(WPTPetTile.<AnimateCapture>d__20).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WPTPetTile.<AnimateCapture>d__20).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(WPTPetTile.<AnimateCapture>d__20).__il2cppRuntimeField_14 = targetFlyToPos.x;
            typeof(WPTPetTile.<AnimateCapture>d__20).__il2cppRuntimeField_18 = targetFlyToPos.y;
            typeof(WPTPetTile.<AnimateCapture>d__20).__il2cppRuntimeField_1C = targetFlyToPos.z;
        }
        private void Reset()
        {
            this.StopAllCoroutines();
            UnityEngine.Transform val_1 = this.transform;
            int val_2 = DG.Tweening.ShortcutExtensions.DOKill(target:  198047856, complete:  false);
            this.<myPet>k__BackingField.SetLooping(loop:  true);
            mem2[0] = 0;
            mem2[0] = 0;
            mem[1152921513394829448] = 0;
        }
        public WPTPetTile()
        {
            this.runningSpeed = 900f;
            this.fallingSpeed = 1400f;
            mem[1152921513394949628] = 1157234688;
            mem[1152921513394949632] = 1056964608;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
