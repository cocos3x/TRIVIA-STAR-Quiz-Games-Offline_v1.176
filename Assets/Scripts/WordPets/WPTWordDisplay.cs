using UnityEngine;

namespace WordPets
{
    public class WPTWordDisplay : MonoBehaviour
    {
        // Fields
        private const int minWordLength = 3;
        private UnityEngine.CanvasGroup content;
        private UnityEngine.GameObject minWordText;
        private UnityEngine.GameObject[] fillerTiles;
        private UnityEngine.GameObject wptWordDisplayTilePrefab;
        private System.Collections.Generic.List<WordPets.WPTWordDisplayTile> currentDisplayTiles;
        private System.Collections.Generic.List<WordPets.WPTWordDisplayTile> currentHiddenTiles;
        
        // Methods
        private void OnEnable()
        {
            this.RefreshContentAlpha();
        }
        public void AddingTile(WordPets.WPTGameTile tile, bool skipAnimation = False)
        {
            WordPets.WPTWordDisplayTile val_1 = this.GetTile(skipAnimation:  skipAnimation);
            this.SetLetter(tile:  tile);
            this.RefreshContentAlpha();
        }
        public void RemovingTile(WordPets.WPTGameTile tile, bool skipAnimation = False)
        {
            var val_2;
            System.Collections.Generic.List<WordPets.WPTWordDisplayTile> val_3;
            val_2 = 4;
            goto label_1;
            label_9:
            if(true <= R6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_1 = UnityEngine.Object.op_Equality(x:  static_value_00280017, y:  tile);
            if(val_1 == true)
            {
                goto label_7;
            }
            
            val_2 = 5;
            label_1:
            val_3 = this.currentDisplayTiles;
            if((val_2 - 4) < val_1)
            {
                goto label_9;
            }
            
            goto label_10;
            label_7:
            val_3 = this.currentDisplayTiles;
            if(val_1 <= R6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.ReturnTile(tile:  2621443, skipAnimation:  skipAnimation);
            label_10:
            this.RefreshContentAlpha();
        }
        public void DeselectAllTiles()
        {
            goto label_1;
            label_5:
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.ReturnTile(tile:  2621443, skipAnimation:  false);
            label_1:
            if(this > 0)
            {
                goto label_5;
            }
            
            this.RefreshContentAlpha();
        }
        private WordPets.WPTWordDisplayTile GetTile(bool skipAnimation = False)
        {
            WordPets.WPTWordDisplayTile val_11;
            if(true >= 1)
            {
                    if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_11 = 2621443;
                bool val_1 = this.currentHiddenTiles.Remove(item:  2621443);
            }
            else
            {
                    UnityEngine.Transform val_2 = this.transform;
                object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.wptWordDisplayTilePrefab, parent:  201065584);
                object val_4 = this.wptWordDisplayTilePrefab.GetComponent<System.Object>();
                val_11 = this.wptWordDisplayTilePrefab;
            }
            
            this.currentDisplayTiles.Add(item:  val_11);
            UnityEngine.GameObject val_5 = val_11.gameObject;
            UnityEngine.UI.LayoutElement val_6 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  val_11);
            if(skipAnimation != false)
            {
                    val_11.alpha = null;
            }
            else
            {
                    val_11.alpha = null;
                DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_11, endValue:  null, duration:  null);
                object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_11, ease:  1);
            }
            
            UnityEngine.Transform val_9 = val_11.transform;
            val_11.SetAsLastSibling();
            UnityEngine.GameObject val_10 = val_11.gameObject;
            val_11.SetActive(value:  true);
            this.SetFillerTiles();
        }
        private void ReturnTile(WordPets.WPTWordDisplayTile tile, bool skipAnimation = False)
        {
            WordPets.WPTWordDisplayTile val_10;
            UnityEngine.CanvasGroup val_11;
            System.Collections.Generic.List<WordPets.WPTWordDisplayTile> val_12;
            var val_13;
            val_10 = tile;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_11 = val_1;
                typeof(WPTWordDisplay.<>c__DisplayClass12_0).__il2cppRuntimeField_8 = val_10;
                WPTWordDisplay.<>c__DisplayClass12_0.__il2cppRuntimeField_name.__il2cppRuntimeField_4 = this;
                val_12 = this.currentDisplayTiles;
            }
            else
            {
                    val_11 = 8;
                mem[8] = val_10;
                mem[12] = this;
                val_12 = this.currentDisplayTiles;
                val_10 = mem[8];
            }
            
            bool val_2 = val_12.Remove(item:  val_10);
            System.Action val_3 = new System.Action(object:  400797696, method:  new IntPtr(201186352));
            if(val_1 != 0)
            {
                    val_13 = val_1;
                typeof(WPTWordDisplay.<>c__DisplayClass12_0).__il2cppRuntimeField_10 = null;
            }
            else
            {
                    val_13 = 16;
                mem[16] = null;
            }
            
            if(skipAnimation != false)
            {
                    Invoke();
                return;
            }
            
            UnityEngine.GameObject val_4 = val_11.gameObject;
            object val_5 = val_11.GetComponent<System.Object>();
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_11, endValue:  null, duration:  null);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_11, ease:  1);
            DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  400797696, method:  new IntPtr(201187376));
            object val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_11, action:  190734336);
        }
        private void SetFillerTiles()
        {
            var val_3;
            var val_4;
            var val_5;
            bool val_5 = true;
            val_3 = 4;
            goto label_1;
            label_14:
            if(val_5 >= 1)
            {
                    val_5 = 3 - val_5;
                if(35626089 < val_5)
            {
                    val_4 = 1;
            }
            
            }
            else
            {
                    val_4 = 0;
            }
            
            this.fillerTiles[0].SetActive(value:  false);
            UnityEngine.GameObject val_6 = this.fillerTiles[0];
            UnityEngine.Transform val_1 = val_6.transform;
            val_6.SetAsLastSibling();
            val_3 = 5;
            label_1:
            if((val_3 - 4) < val_6)
            {
                goto label_14;
            }
            
            bool val_3 = WGFTUXManager.CanShow;
            if(val_3 != false)
            {
                    return;
            }
            
            if(val_3 >= true)
            {
                    if(val_3 < true)
            {
                    val_5 = 1;
            }
            
            }
            else
            {
                    val_5 = 0;
            }
            
            this.minWordText.SetActive(value:  false);
        }
        private void RefreshContentAlpha()
        {
            if(R2 > 0)
            {
                    6312148 = 6312148 + 4;
            }
            
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.content, endValue:  null, duration:  null);
            object val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.content, ease:  1);
        }
        public WPTWordDisplay()
        {
            this.currentDisplayTiles = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.currentHiddenTiles = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
    
    }

}
