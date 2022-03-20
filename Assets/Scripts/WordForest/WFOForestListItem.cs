using UnityEngine;

namespace WordForest
{
    public class WFOForestListItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform contentTransform;
        private UnityEngine.UI.Button button;
        private UnityEngine.UI.Text forestTitleText;
        private UnityEngine.UI.RawImage forestTexture;
        private UnityEngine.UI.RawImage maskTexture;
        private UnityEngine.UI.Image currentForestGlow;
        private UnityEngine.UI.Image lockImage;
        private UnityEngine.Transform dotsTransform;
        private UnityEngine.ParticleSystem particleSystem;
        private UnityEngine.UI.Image[] dots;
        private System.Action OnItemClicked;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  291001344, method:  new IntPtr(290976320));
            this.button.m_OnClick.AddListener(call:  162246656);
        }
        public void SetForestInfo(int forestIndex, WordForest.WFOForestData forestData, System.Action onItemClicked, UnityEngine.Texture forestTexture)
        {
            System.Action val_8;
            string val_1 = forestData.level.ToString();
            string val_2 = System.String.Format(format:  291109824, arg0:  291146440, arg1:  forestData.forestName);
            int val_3 = forestIndex & 1;
            if(this.forestTitleText == 0)
            {
                    14001320 = 14001324;
            }
            
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            this.contentTransform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  -1f = 1f, y:  null, z:  1f);
            this.dotsTransform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.forestTexture.texture = forestTexture;
            this.maskTexture.texture = forestTexture;
            if(forestIndex == 0)
            {
                    UnityEngine.GameObject val_6 = this.dotsTransform.gameObject;
                this.dotsTransform.SetActive(value:  false);
            }
            
            val_8 = this.OnItemClicked;
            System.Delegate val_7 = System.Delegate.Combine(a:  val_8, b:  onItemClicked);
            if(val_8 != 0)
            {
                    if(null == null)
            {
                goto label_10;
            }
            
            }
            
            val_8 = 0;
            label_10:
            this.OnItemClicked = val_8;
        }
        public void SetLocked()
        {
            this.ToggleDots(active:  false);
            this.button.transition = 0;
            this.button.interactable = false;
            UnityEngine.Color val_1 = UnityEngine.Color.gray;
            this.forestTexture.color = new UnityEngine.Color() {a = ???};
            UnityEngine.GameObject val_2 = this.lockImage.gameObject;
            this.lockImage.SetActive(value:  true);
            this.currentForestGlow.enabled = false;
            this.particleSystem.Stop();
        }
        public void SetCompleted()
        {
            this.ToggleDots(active:  true);
            this.button.transition = 0;
            this.button.interactable = false;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.forestTexture.color = new UnityEngine.Color() {a = ???};
            UnityEngine.GameObject val_2 = this.lockImage.gameObject;
            this.lockImage.SetActive(value:  false);
            this.currentForestGlow.enabled = false;
            this.particleSystem.Stop();
        }
        public void SetCurrent()
        {
            this.ToggleDots(active:  true);
            this.button.transition = 1;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.forestTexture.color = new UnityEngine.Color() {a = ???};
            UnityEngine.GameObject val_2 = this.lockImage.gameObject;
            this.lockImage.SetActive(value:  false);
            this.currentForestGlow.enabled = true;
            this.button.interactable = true;
            this.particleSystem.Play();
        }
        public DG.Tweening.Sequence DoUnlockSequence()
        {
            float val_4;
            var val_21;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            val_21 = 0;
            goto label_3;
            label_7:
            UnityEngine.UI.Image val_21 = this.dots[val_21];
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOColor(target:  val_21, endValue:  new UnityEngine.Color() {a = val_4}, duration:  val_3.r);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  val_21);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_3.r);
            val_21 = 1;
            label_3:
            if(val_21 < 0)
            {
                goto label_7;
            }
            
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.lockImage, endValue:  val_3.r, duration:  val_3.g);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.lockImage);
            DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  291884000, method:  new IntPtr(291848736));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  291884000, method:  new IntPtr(291849760));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            UnityEngine.Color val_14 = UnityEngine.Color.white;
            DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.forestTexture, endValue:  new UnityEngine.Color() {a = val_4}, duration:  val_14.r);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.forestTexture);
            DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.currentForestGlow, endValue:  val_14.r, duration:  val_14.g);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.currentForestGlow);
            DG.Tweening.TweenCallback val_19 = new DG.Tweening.TweenCallback(object:  291884000, method:  new IntPtr(291858976));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        }
        private void ToggleDots(bool active)
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            var val_7;
            if(active != false)
            {
                    UnityEngine.Color val_1 = UnityEngine.Color.white;
            }
            else
            {
                    UnityEngine.Color val_2 = UnityEngine.Color.black;
            }
            
            val_7 = 0;
            goto label_2;
            label_7:
            UnityEngine.UI.Image val_7 = this.dots[val_7];
            val_7.color = new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = val_6};
            val_7 = 1;
            label_2:
            if(val_7 < val_7)
            {
                goto label_7;
            }
        
        }
        public WFOForestListItem()
        {
        
        }
        private void <Start>b__11_0()
        {
            if(this.OnItemClicked == 0)
            {
                    return;
            }
            
            this.OnItemClicked.Invoke();
        }
        private void <DoUnlockSequence>b__16_0()
        {
            this.currentForestGlow.enabled = true;
        }
        private void <DoUnlockSequence>b__16_1()
        {
            PluginExtension.SetColorAlpha(graphic:  this.currentForestGlow, a:  null);
        }
    
    }

}
