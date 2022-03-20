using UnityEngine;

namespace WordPets
{
    public class WPTBackground : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image bgLayer1;
        private UnityEngine.UI.Image bgLayer2;
        private UnityEngine.Sprite imgHome;
        private UnityEngine.Sprite imgGameDay;
        private UnityEngine.Sprite imgGameDusk;
        private SceneType currentSceneType;
        private DG.Tweening.Tweener tweenSeq;
        
        // Methods
        private void Start()
        {
            var val_11;
            GameBehavior val_1 = App.getBehavior;
            this.currentSceneType = 0;
            if(0 != 2)
            {
                goto label_10;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-803395920) == 0)
            {
                goto label_10;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  204312944, method:  new IntPtr(204267440));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_EC, b:  7401472);
            val_11 = public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_EC;
            if(val_11 != 0)
            {
                    if(val_11 == null)
            {
                goto label_16;
            }
            
            }
            
            val_11 = 0;
            label_16:
            public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_EC = val_11;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.OnTileRefillStateChanged(isRefillable:  public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_D4>>0&0xFF);
            return;
            label_10:
            this.bgLayer1.sprite = this.imgHome;
            UnityEngine.Color val_8 = UnityEngine.Color.white;
            this.bgLayer1.color = new UnityEngine.Color() {a = ???};
            UnityEngine.GameObject val_9 = this.bgLayer1.gameObject;
            this.bgLayer1.SetActive(value:  true);
            UnityEngine.GameObject val_10 = this.bgLayer2.gameObject;
            this.bgLayer2.SetActive(value:  false);
        }
        private void OnDestroy()
        {
            var val_6;
            System.Action<System.Boolean> val_7;
            var val_8;
            if(this.currentSceneType != 2)
            {
                    return;
            }
            
            val_6 = 1152921504901095424;
            val_7 = 1152921512393385648;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-803395920) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = null;
            val_7 = new System.Action<System.Boolean>(object:  204449520, method:  new IntPtr(204267440));
            System.Delegate val_5 = System.Delegate.Remove(source:  public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_EC, value:  7401472);
            val_8 = public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_EC;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_12;
            }
            
            }
            
            val_8 = 0;
            label_12:
            public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_EC = val_8;
        }
        private void OnTileRefillStateChanged(bool isRefillable)
        {
            if(this.tweenSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.tweenSeq, complete:  false);
            }
            
            if(isRefillable == true)
            {
                    28 = 24;
            }
            
            this.bgLayer2.sprite = this.bgLayer1.m_Sprite;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.bgLayer2.color = new UnityEngine.Color() {a = ???};
            UnityEngine.GameObject val_2 = this.bgLayer2.gameObject;
            this.bgLayer2.SetActive(value:  true);
            this.bgLayer1.sprite = this.imgGameDay;
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            this.bgLayer1.color = new UnityEngine.Color() {a = ???};
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bgLayer2, endValue:  val_3.r, duration:  val_3.g);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  204607600, method:  new IntPtr(204582576));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.bgLayer2, action:  190734336);
            this.tweenSeq = this.bgLayer2;
        }
        public WPTBackground()
        {
        
        }
        private void <OnTileRefillStateChanged>b__9_0()
        {
            UnityEngine.GameObject val_1 = this.bgLayer2.gameObject;
            this.bgLayer2.SetActive(value:  false);
        }
    
    }

}
