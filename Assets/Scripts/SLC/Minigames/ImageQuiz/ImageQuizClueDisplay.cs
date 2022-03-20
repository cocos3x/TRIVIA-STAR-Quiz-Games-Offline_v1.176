using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizClueDisplay : MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup clueCanvasGroup;
        private UnityEngine.UI.RawImage clueImage;
        private UnityEngine.UI.Image correctImage;
        private UnityEngine.UI.Image wrongImage;
        private DG.Tweening.Tweener tweener;
        private System.Nullable<UnityEngine.Vector2> preferredDimension;
        
        // Methods
        private void Start()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  1050349184, method:  new IntPtr(1050324160));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14, b:  7454720);
            val_4 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14 = val_4;
        }
        private void OnDestroy()
        {
            var val_6;
            System.Action val_7;
            var val_8;
            val_6 = 1152921504901095424;
            val_7 = 1152921514247104704;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(1050323136 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = null;
            val_7 = new System.Action(object:  1050461184, method:  new IntPtr(1050324160));
            System.Delegate val_5 = System.Delegate.Remove(source:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14, value:  7454720);
            val_8 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_11;
            }
            
            }
            
            val_8 = 0;
            label_11:
            public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14 = val_8;
        }
        private void OnMinigameBegin()
        {
            this.UpdateClueDisplay();
        }
        public void UpdateClueDisplay()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.ImageQuiz.ImageQuizLevelInfo val_2 = GetCurrentQuizLevel();
            this.SetImage(imgTexture:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_10);
        }
        private void SetImage(UnityEngine.Texture imgTexture)
        {
            UnityEngine.GameObject val_1 = this.clueImage.gameObject;
            this.clueImage.SetActive(value:  true);
            UnityEngine.RectTransform val_2 = this.clueImage.rectTransform;
            UnityEngine.RectTransform val_3 = this.clueImage.rectTransform;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  null, y:  null);
            this.clueImage.anchorMax = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this.clueImage.anchorMin = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this.clueImage.texture = imgTexture;
            this.ResizeImage();
        }
        private void ResizeImage()
        {
            float val_3;
            float val_4;
            var val_13;
            var val_14;
            if(true == 0)
            {
                    UnityEngine.RectTransform val_1 = this.clueImage.rectTransform;
                UnityEngine.Vector2 val_2 = sizeDelta;
                System.Nullable<UnityEngine.Vector2> val_5 = new System.Nullable<UnityEngine.Vector2>(value:  new UnityEngine.Vector2() {x = val_3, y = val_4});
            }
            
            float val_13 = (float)this.clueImage.m_Texture;
            if(this.clueImage.m_Texture >= 1)
            {
                    UnityEngine.Vector2 val_6 = val_5.HasValue.Value;
                val_13 = val_5.HasValue / val_13;
                val_13 = 0;
                UnityEngine.RectTransform val_7 = this.clueImage.rectTransform;
                val_14 = this.clueImage;
                UnityEngine.Vector2 val_8 = Value;
            }
            else
            {
                    UnityEngine.Vector2 val_9 = val_5.HasValue.Value;
                val_13 = 0 * val_13;
                val_13 = 0;
                UnityEngine.RectTransform val_10 = this.clueImage.rectTransform;
                val_14 = this.clueImage;
                UnityEngine.Vector2 val_11 = Value;
            }
            
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_11.x, y:  val_11.y);
            val_14.sizeDelta = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
        }
        public void FadeDisplay(float alphaTo, float duration)
        {
            if(this.tweener != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.tweener, complete:  false);
            }
            
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.clueCanvasGroup, endValue:  alphaTo, duration:  duration);
            this.tweener = this.clueCanvasGroup;
        }
        public void ToggleResultOverlay(bool isVisible, bool isCorrect)
        {
            UnityEngine.UI.Image val_10;
            var val_11;
            if(isVisible == false)
            {
                goto label_1;
            }
            
            if(isCorrect == false)
            {
                goto label_2;
            }
            
            val_10 = this.correctImage;
            UnityEngine.GameObject val_1 = val_10.gameObject;
            val_10.SetActive(value:  true);
            UnityEngine.GameObject val_2 = this.wrongImage.gameObject;
            val_11 = 0;
            goto label_7;
            label_1:
            UnityEngine.GameObject val_3 = this.correctImage.gameObject;
            this.correctImage.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.wrongImage.gameObject;
            this.wrongImage.SetActive(value:  false);
            return;
            label_2:
            val_10 = this.wrongImage;
            UnityEngine.GameObject val_5 = this.correctImage.gameObject;
            this.correctImage.SetActive(value:  false);
            UnityEngine.GameObject val_6 = this.wrongImage.gameObject;
            val_11 = 1;
            label_7:
            this.wrongImage.SetActive(value:  true);
            UnityEngine.Color val_7 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            val_10.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_10, endValue:  null, duration:  null);
            object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_10, ease:  1);
        }
        public ImageQuizClueDisplay()
        {
        
        }
    
    }

}
