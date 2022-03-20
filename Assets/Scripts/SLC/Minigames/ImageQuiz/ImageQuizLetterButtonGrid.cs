using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizLetterButtonGrid : MonoBehaviour
    {
        // Fields
        private SLC.Minigames.ImageQuiz.ImageQuizLetterButton letterButtonPrefab;
        private UnityEngine.UI.GridLayoutGroup gridLayoutGroup;
        private UnityEngine.CanvasGroup buttonsCanvasGroup;
        private SLC.Minigames.ImageQuiz.ImageQuizLetterButton[] letterButtons;
        private int gridRowCount;
        private int gridColumnCount;
        private UnityEngine.Vector2 IdealCellSize;
        
        // Properties
        public SLC.Minigames.ImageQuiz.ImageQuizLetterButton[] LetterButtons { get; }
        
        // Methods
        public SLC.Minigames.ImageQuiz.ImageQuizLetterButton[] get_LetterButtons()
        {
        
        }
        public void Initialize(string letters)
        {
            int val_8;
            int val_9;
            var val_12;
            var val_13;
            UnityEngine.Object val_14;
            SLC.Minigames.ImageQuiz.ImageQuizLetterButtonGrid val_15;
            var val_16;
            var val_17;
            var val_18;
            UnityEngine.Transform val_1 = this.gridLayoutGroup.transform;
            System.Collections.IEnumerator val_2 = this.gridLayoutGroup.GetEnumerator();
            label_24:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_12 = this.gridLayoutGroup;
            if(this.gridLayoutGroup == 0)
            {
                goto label_8;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_13 = this.gridLayoutGroup;
            if(this.gridLayoutGroup != 0)
            {
                    val_14 = 0;
            }
            else
            {
                    val_14 = 0;
            }
            
            UnityEngine.GameObject val_5 = gameObject;
            UnityEngine.Object.Destroy(obj:  null);
            goto label_24;
            label_8:
            val_15 = this;
            val_16 = null;
            if(this.gridLayoutGroup != 0)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_17 = this.gridLayoutGroup;
                val_16 = mem[(1152921504812650496 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3) + 4];
            }
            
            if(0 != 0)
            {
                    val_16 = 0;
            }
            
            UnityEngine.Vector2 val_7 = GetInputGridSize(totalButtons:  0);
            this.InitializeObjects(_gridRowCount:  val_9, _gridColCount:  val_8);
            System.Collections.Generic.List<TSource> val_10 = System.Linq.Enumerable.ToList<System.Char>(source:  letters);
            PluginExtension.Shuffle<System.Char>(list:  letters, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            val_18 = 4;
            goto label_32;
            label_40:
            if((letters + 12) <= letters)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_16 = letters + 8;
            val_16 = val_16 + 16;
            string val_11 = val_16.ToString();
            mem2[0] = ;
            val_15 = this;
            val_18 = 5;
            label_32:
            if((val_18 - 4) < (mem[1152921514268637208] + 12))
            {
                goto label_40;
            }
        
        }
        private void InitializeObjects(int _gridRowCount, int _gridColCount)
        {
            float val_21;
            float val_22;
            int val_22;
            var val_23;
            this.gridRowCount = _gridRowCount;
            _gridRowCount = _gridColCount * _gridRowCount;
            this.gridColumnCount = _gridColCount;
            this.letterButtons = null;
            this.gridLayoutGroup.constraint = 1;
            val_22 = this.gridColumnCount;
            this.gridLayoutGroup.constraintCount = val_22;
            int val_25 = this.gridRowCount;
            val_25 = this.gridColumnCount * val_25;
            if(val_25 < 1)
            {
                goto label_3;
            }
            
            label_48:
            var val_1 = 4 - 4;
            string val_2 = 1071960000 + 13152256;
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(160436224)});
            typeof(System.Type[]).__il2cppRuntimeField_10 = null;
            UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  1071960000, components:  473824320);
            UnityEngine.Transform val_5 = transform;
            UnityEngine.Transform val_6 = this.gridLayoutGroup.transform;
            SetParent(p:  this.gridLayoutGroup);
            UnityEngine.Transform val_7 = transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_9 = transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_11 = transform;
            object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  this.letterButtonPrefab, parent:  157720576);
            this.letterButtons[0] = this.letterButtonPrefab;
            string val_13 = this.letterButtonPrefab.name;
            string val_14 = this.letterButtonPrefab + 2144339952 + 13152256;
            this.letterButtons[0].name = this.letterButtonPrefab;
            SLC.Minigames.ImageQuiz.ImageQuizLetterButton val_27 = this.letterButtons[0];
            UnityEngine.Transform val_15 = val_27.transform;
            UnityEngine.Transform val_16 = transform;
            val_27.SetParent(p:  157720576);
            val_22 = 4;
            SLC.Minigames.ImageQuiz.ImageQuizLetterButton val_28 = this.letterButtons[0];
            UnityEngine.Transform val_17 = val_28.transform;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            val_28.localScale = new UnityEngine.Vector3();
            SLC.Minigames.ImageQuiz.ImageQuizLetterButton val_29 = this.letterButtons[0];
            UnityEngine.Transform val_19 = val_29.transform;
            val_23 = val_29;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.zero;
            if(val_23 == 0)
            {
                goto label_44;
            }
            
            if(null == null)
            {
                goto label_46;
            }
            
            goto label_47;
            label_44:
            label_47:
            val_23 = 0;
            label_46:
            val_23.anchoredPosition = new UnityEngine.Vector2() {x = val_21, y = val_22};
            int val_30 = this.gridColumnCount;
            val_30 = val_30 * this.gridRowCount;
            var val_24 = val_22 + 1;
            if((val_22 - 3) < val_30)
            {
                goto label_48;
            }
            
            label_3:
            this.OnRectTransformDimensionsChange();
        }
        protected void OnRectTransformDimensionsChange()
        {
            UnityEngine.Vector2 val_1 = DetermineCellSize();
            this.gridLayoutGroup.cellSize = new UnityEngine.Vector2();
        }
        private UnityEngine.Vector2 DetermineCellSize()
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            float val_17;
            float val_18;
            val_13 = 0;
            UnityEngine.Transform val_1 = R1 + 16.transform;
            if((R1 + 16) != 0)
            {
                    if((R1 + 16) != null)
            {
                
            }
            else
            {
                    val_13 = R1 + 16;
            }
            
            }
            
            UnityEngine.Rect val_2 = rect;
            float val_3 = width;
            val_14 = R1 + 32;
            if((R1 + 16) == 0)
            {
                    val_14 = mem[R1 + 32];
                val_14 = R1 + 32;
            }
            
            var val_6 = (R1 + 32) - 1;
            float val_13 = (float)R1 + 16 + 12.left;
            float val_14 = (float)R1 + 16 + 12.right;
            float val_15 = (float)val_14;
            UnityEngine.Rect val_7 = rect;
            float val_8 = height;
            val_13 = 1072639416 - val_13;
            val_14 = val_13 - val_14;
            val_15 = val_14 / val_15;
            uint val_17 = 1072639416;
            val_15 = R1 + 28;
            if((R1 + 16) == 0)
            {
                    val_15 = mem[R1 + 28];
                val_15 = R1 + 28;
            }
            
            var val_11 = (R1 + 28) - 1;
            float val_16 = (float)R1 + 16 + 12.top;
            val_16 = val_17 - val_16;
            val_16 = val_16 - ((float)R1 + 16 + 12.bottom);
            val_16 = R1 + 36;
            val_17 = R1 + 40;
            val_17 = val_16 / (float)val_15;
            if((R1 + 16) >= 0)
            {
                    return new UnityEngine.Vector2() {x = UnityEngine.Mathf.Min(a:  val_18 = val_17, b:  val_7.m_YMin), y = val_7.m_YMin};
            }
            
            val_16 = val_15;
            val_17 = val_16;
            return new UnityEngine.Vector2() {x = UnityEngine.Mathf.Min(a:  val_18, b:  val_7.m_YMin), y = val_7.m_YMin};
        }
        private UnityEngine.Vector2 GetInputGridSize(int totalButtons)
        {
            var val_1 = R2 - 8;
            if(val_1 <= 13)
            {
                    var val_2 = 13786608 + (13786608 + ((R2 - 8)) << 2);
                if(val_1 == 13)
            {
                    13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & 0;
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & ((R8) >> (13786608 + ((R2 - 8)) << 2 & 0));
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & (this >> (13786608 + ((R2 - 8)) << 2));
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & ((R8) >> (((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))));
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & (((((((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))) & (R8) >> (((13786608 + ) << (32-as. 
                
            
            
            
            
            
               
            )) | ((((((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))) & (R8) >> (((13786608 + ) << as. 
                
            
            
            
            
            
               
            ));
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & ((R8) >> (((((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))) & (R8) >> (((13786608 +);
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) * (13786608 + ((R2 - 8)) << 2);
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & ((R8) >> (((((((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))) & (R8) >> (((13786608);
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & (((IP) << (32-as. 
                
            
            
            
            
            
               
            )) | ((IP) << as. 
                
            
            
            
            
            
               
            ));
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & ((R8) >> (((((((((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))) & (R8) >> (((137866);
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & (((R8) << (32-((((((((((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))) & (R8) >> (((13786)) | ((R8) << ((((((((((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))) & (R8) >> (((13786));
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & ((R8) >> (((((((((((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))) & (R8) >> (((1378);
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & ((R8) >> ((((((((((((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))) & (R8) >> (((137);
                13786608 + ((R2 - 8)) << 2 = (13786608 + ((R2 - 8)) << 2) & ((R8) >> (((((((((((((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0)) & ((int)this) >> ((13786608 + ((R2 - 8)) << 2 & 0) & (R8) >> (13786608 + ((R2 - 8)) << 2 & 0))) & (R8) >> (((13);
            }
            
            }
            
             = new UnityEngine.Vector2(x:  null, y:  null);
            return new UnityEngine.Vector2();
        }
        public void SetVisible(bool state, bool isAnimated = False)
        {
            this.buttonsCanvasGroup.interactable = state;
            if(state == true)
            {
                    0f = 1f;
            }
            
            if(isAnimated != false)
            {
                    DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.buttonsCanvasGroup, endValue:  1f, duration:  null);
                return;
            }
            
            this.buttonsCanvasGroup.alpha = 1f;
        }
        public SLC.Minigames.ImageQuiz.ImageQuizLetterButton GetButton(string letter, bool getOnlyUnusedButtons)
        {
            var val_4;
            string val_5;
            val_4 = 4;
            goto label_0;
            label_13:
            SLC.Minigames.ImageQuiz.ImageQuizLetterButton val_5 = this.letterButtons[0];
            string val_1 = this.letterButtons[0]._letter.ToLowerInvariant();
            val_5 = this.letterButtons[0]._letter;
            string val_2 = letter.ToLowerInvariant();
            if((System.String.op_Equality(a:  val_5, b:  letter)) == false)
            {
                goto label_6;
            }
            
            if(getOnlyUnusedButtons == false)
            {
                goto label_11;
            }
            
            val_5 = this.letterButtons[0];
            if((this.letterButtons[0].<IsUsed>k__BackingField) == false)
            {
                goto label_11;
            }
            
            label_6:
            val_4 = 5;
            label_0:
            if((val_4 - 4) < (this.letterButtons[0].<IsUsed>k__BackingField))
            {
                goto label_13;
            }
            
            return;
            label_11:
            SLC.Minigames.ImageQuiz.ImageQuizLetterButton val_6 = this.letterButtons[0];
        }
        public ImageQuizLetterButtonGrid()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
            this.IdealCellSize = val_1.x;
            mem[1152921514270233336] = val_1.y;
        }
    
    }

}
