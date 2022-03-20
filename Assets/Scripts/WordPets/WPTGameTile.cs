using UnityEngine;

namespace WordPets
{
    public class WPTGameTile : MonoBehaviour
    {
        // Fields
        private float fallSpeed;
        private float fadeInTime;
        private char <myCharacter>k__BackingField;
        protected WordPets.WPTGameColumn column;
        private bool initialised;
        private float <FallAnimationDuration>k__BackingField;
        protected System.Nullable<UnityEngine.Vector2> defaultTileSize;
        
        // Properties
        public virtual char myCharacter { get; set; }
        public int RowIndex { get; }
        public WordPets.WPTGameColumn Column { get; }
        public float FallAnimationDuration { get; set; }
        
        // Methods
        public virtual char get_myCharacter()
        {
            return (char)this.<myCharacter>k__BackingField;
        }
        protected virtual void set_myCharacter(char value)
        {
            this.<myCharacter>k__BackingField = value;
        }
        public int get_RowIndex()
        {
            System.Predicate<ZooTile> val_1 = new System.Predicate<ZooTile>(object:  160912544, method:  new IntPtr(160887520));
            if((this.column.<myTiles>k__BackingField) != 0)
            {
                    return this.column.<myTiles>k__BackingField.FindIndex(match:  8040448);
            }
            
            return this.column.<myTiles>k__BackingField.FindIndex(match:  8040448);
        }
        public WordPets.WPTGameColumn get_Column()
        {
        
        }
        public float get_FallAnimationDuration()
        {
            return (float)S0;
        }
        private void set_FallAnimationDuration(float value)
        {
            this.<FallAnimationDuration>k__BackingField = ;
        }
        public void Init(float startingHeight, WordPets.WPTGameColumn myColumn, bool initial = False, bool moveUp = False)
        {
            this.column = initial;
            this.FallToPosition(yPos:  startingHeight, initial:  myColumn, moveUp:  moveUp);
        }
        public void InitBottom(WordPets.WPTGameColumn myColumn)
        {
            this.column = myColumn;
            this.ExpandToPosition();
        }
        public virtual bool IsLetter()
        {
            return true;
        }
        public virtual void SetLetter(char letter)
        {
            goto typeof(WordPets.WPTGameTile).__il2cppRuntimeField_E4;
        }
        public virtual void SetDimension(UnityEngine.Vector2 size)
        {
            float val_5;
            float val_6;
            float val_12;
            var val_14;
            var val_15;
            var val_16;
            val_12 = size.y;
            if(true != 0)
            {
                goto label_1;
            }
            
            UnityEngine.GameObject val_1 = this.gameObject;
            val_14 = 0;
            UnityEngine.Transform val_2 = this.transform;
            if(this != 0)
            {
                    if(null == null)
            {
                goto label_4;
            }
            
            }
            
            if(this != 0)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            label_5:
            if(null != null)
            {
                    val_14 = 0;
            }
            else
            {
                    val_14 = this;
            }
            
            label_8:
            UnityEngine.Rect val_3 = rect;
            UnityEngine.Vector2 val_4 = size;
            System.Nullable<UnityEngine.Vector2> val_7 = new System.Nullable<UnityEngine.Vector2>(value:  new UnityEngine.Vector2() {x = val_5, y = val_6});
            val_12 = val_12;
            label_1:
            UnityEngine.GameObject val_8 = this.gameObject;
            val_15 = 0;
            UnityEngine.Transform val_9 = this.transform;
            if(this != 0)
            {
                    if(null != null)
            {
                    val_15 = 0;
            }
            else
            {
                    val_15 = this;
            }
            
            }
            
            this.SetSizeWithCurrentAnchors(axis:  0, size:  val_4.x);
            UnityEngine.GameObject val_10 = this.gameObject;
            val_16 = 0;
            UnityEngine.Transform val_11 = this.transform;
            if(this != 0)
            {
                    if(null != null)
            {
                    val_16 = 0;
            }
            else
            {
                    val_16 = this;
            }
            
            }
            
            this.SetSizeWithCurrentAnchors(axis:  1, size:  val_4.x);
        }
        private void FallToPosition(float yPos, bool initial, bool moveUp = False)
        {
            float val_4;
            float val_5;
            float val_14;
            float val_16;
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  161954336);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            if(R3 != 0)
            {
                    val_16 = 0.35f;
            }
            else
            {
                    UnityEngine.Transform val_6 = this.transform;
                UnityEngine.Vector3 val_7 = localPosition;
                float val_8 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3(), b:  new UnityEngine.Vector3() {x = val_4, y = initial, z = val_5});
                val_14 = R0;
                val_16 = val_14 / this.fallSpeed;
            }
            
            this.<FallAnimationDuration>k__BackingField = val_16;
            if(this.initialised != true)
            {
                    this.alpha = val_14;
                DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  161954336, endValue:  val_14, duration:  val_7.y);
                this.initialised = true;
            }
            
            UnityEngine.Transform val_10 = this.transform;
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  161954336, endValue:  new UnityEngine.Vector3() {x = val_4, y = initial, z = val_5}, duration:  val_14, snapping:  val_16);
            if(moveUp == true)
            {
                    2 = 6;
            }
            
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  161954336, ease:  6);
        }
        private void ExpandToPosition()
        {
            if(this.initialised != true)
            {
                    UnityEngine.Transform val_1 = this.transform;
                UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
                this.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
                this.initialised = true;
            }
            
            UnityEngine.Transform val_3 = this.transform;
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  162066336, endValue:  null, duration:  null);
            object val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  162066336, ease:  2);
        }
        public virtual void HideTile()
        {
            this.column.RemoveTile(removeTile:  162182432);
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
        }
        public WPTGameTile()
        {
            this.fallSpeed = 2000f;
            this.fadeInTime = 0.5f;
        }
        private bool <get_RowIndex>b__7_0(WordPets.WPTGameTile node)
        {
            return UnityEngine.Object.op_Equality(x:  node, y:  162414624);
        }
    
    }

}
