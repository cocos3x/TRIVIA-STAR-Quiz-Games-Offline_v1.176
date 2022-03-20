using UnityEngine;

namespace RestaurantRivals
{
    public class RESMapListItem : MonoBehaviour, ICell
    {
        // Fields
        private UnityEngine.Transform contentTransform;
        private UnityEngine.UI.Button button;
        private UnityEngine.UI.Text restaurantTitleText;
        private UnityEngine.UI.RawImage restaurantImage;
        private UnityEngine.UI.Image lockImage;
        private UnityEngine.Transform dotsTransform;
        private UnityEngine.Transform glow;
        private UnityEngine.ParticleSystem burstParticles;
        private UnityEngine.UI.Image[] dots;
        public RestaurantRivals.RESLevelDef LevelData;
        private System.Action OnItemClicked;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  572230144, method:  new IntPtr(572201024));
            this.button.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.glow.localScale = new UnityEngine.Vector3();
        }
        public void SetForestInfo(RestaurantRivals.RESLevelDef levelData)
        {
            var val_5;
            int val_20;
            var val_21;
            System.Delegate val_22;
            var val_23;
            if(levelData != 0)
            {
                    val_20 = levelData.levelNumber;
                string val_1 = val_20.ToString();
                val_21 = val_20;
            }
            else
            {
                    val_20 = 12;
                string val_2 = 12.ToString();
                val_21 = 12;
            }
            
            string val_3 = System.String.Format(format:  291109824, arg0:  12, arg1:  levelData.restaurantName);
            this.LevelData = levelData;
            if(this.restaurantTitleText != 0)
            {
                    11722068 = 11722072;
            }
            
            UnityEngine.Vector3 val_4 = localPosition;
            UnityEngine.Vector3 val_6 = localPosition;
            UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  val_6.x, y:  val_6.y, z:  val_6.z);
            this.contentTransform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            val_5 = 0;
            UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  -1f = 1f, y:  val_6.y, z:  1f);
            this.dotsTransform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Texture val_11 = GetLevelTexture(level:  0);
            this.restaurantImage.texture = 572359104;
            if(0 == 1)
            {
                    UnityEngine.GameObject val_12 = this.dotsTransform.gameObject;
                this.dotsTransform.SetActive(value:  false);
            }
            
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_14 = new System.Action(object:  572359104, method:  new IntPtr(572368320));
            val_22 = this.OnItemClicked;
            System.Delegate val_15 = System.Delegate.Combine(a:  val_22, b:  7454720);
            if(val_22 != 0)
            {
                    if(null == null)
            {
                goto label_18;
            }
            
            }
            
            val_22 = 0;
            label_18:
            this.OnItemClicked = val_22;
            val_23 = 0;
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(0 < CurrentRestaurantID)
            {
                    this.SetCompleted();
                return;
            }
            
            val_23 = 0;
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(0 == CurrentRestaurantID)
            {
                    this.SetCurrent();
                return;
            }
            
            this.SetLocked();
        }
        public void SetLocked()
        {
            this.ToggleDots(active:  false);
            this.button.transition = 0;
            this.button.interactable = false;
            UnityEngine.Color val_1 = UnityEngine.Color.gray;
            this.restaurantImage.color = new UnityEngine.Color() {a = ???};
            UnityEngine.GameObject val_2 = this.lockImage.gameObject;
            this.lockImage.SetActive(value:  true);
        }
        public void SetCompleted()
        {
            this.ToggleDots(active:  true);
            this.button.transition = 0;
            this.button.interactable = false;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.restaurantImage.color = new UnityEngine.Color() {a = ???};
            UnityEngine.GameObject val_2 = this.lockImage.gameObject;
            this.lockImage.SetActive(value:  false);
        }
        public void SetCurrent()
        {
            this.ToggleDots(active:  true);
            this.button.transition = 1;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.restaurantImage.color = new UnityEngine.Color() {a = ???};
            UnityEngine.GameObject val_2 = this.lockImage.gameObject;
            this.lockImage.SetActive(value:  false);
            this.button.interactable = true;
        }
        public DG.Tweening.Sequence DoCompleteSequence()
        {
            float val_6;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  572981632, method:  new IntPtr(572952512));
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            UnityEngine.Color val_5 = UnityEngine.Color.gray;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.restaurantImage, endValue:  new UnityEngine.Color() {a = val_6}, duration:  val_5.r);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.restaurantImage, ease:  5);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.restaurantImage);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_5.r);
        }
        public DG.Tweening.Sequence DoUnlockSequence()
        {
            float val_4;
            var val_20;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            val_20 = 0;
            goto label_3;
            label_7:
            UnityEngine.UI.Image val_20 = this.dots[val_20];
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOColor(target:  val_20, endValue:  new UnityEngine.Color() {a = val_4}, duration:  val_3.r);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  val_20);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_3.r);
            val_20 = 1;
            label_3:
            if(val_20 < 0)
            {
                goto label_7;
            }
            
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.glow, endValue:  val_3.r, duration:  val_3.g);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.glow);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_3.r);
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.lockImage, endValue:  val_3.r, duration:  val_3.g);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.lockImage);
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.glow, endValue:  val_3.r, duration:  val_3.g);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.glow);
            UnityEngine.Color val_15 = UnityEngine.Color.white;
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.restaurantImage, endValue:  new UnityEngine.Color() {a = val_4}, duration:  val_15.r);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.restaurantImage);
            DG.Tweening.TweenCallback val_18 = new DG.Tweening.TweenCallback(object:  573192960, method:  new IntPtr(573167936));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        }
        public int GetId()
        {
            int val_1 = this.LevelData.levelNumber;
            val_1 = val_1 - 1;
            return (int)val_1;
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
                    UnityEngine.Color val_2 = UnityEngine.Color.grey;
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
        public RESMapListItem()
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
        private void <DoCompleteSequence>b__16_0()
        {
            this.burstParticles.Play();
        }
    
    }

}
