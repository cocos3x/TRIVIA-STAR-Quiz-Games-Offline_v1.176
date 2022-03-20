using UnityEngine;

namespace SLC.Minigames.TwistyArrow
{
    public class WordBow : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image bowImage;
        private UnityEngine.Sprite drawnSprite;
        private UnityEngine.Sprite releasedSprite;
        private UnityEngine.GameObject staticArrow;
        private float releaseTime;
        private float redrawTime;
        private UnityEngine.AudioSource audioSource;
        private UnityEngine.AudioClip clip;
        
        // Methods
        private void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.bowImage = this;
            object val_2 = this.GetComponent<System.Object>();
            this.audioSource = this;
            UnityEngine.AudioClip val_3 = this.clip;
            this.clip = this;
            this.staticArrow.SetActive(value:  true);
        }
        public void OnFire()
        {
            this.PlaySound();
            this.staticArrow.SetActive(value:  false);
            this.StopAllCoroutines();
            this.bowImage.sprite = this.drawnSprite;
            System.Collections.IEnumerator val_1 = this.OnRelease();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1020900416);
        }
        private System.Collections.IEnumerator OnRelease()
        {
            object val_1 = new System.Object();
            typeof(WordBow.<OnRelease>d__10).__il2cppRuntimeField_8 = 0;
            typeof(WordBow.<OnRelease>d__10).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator ReDraw()
        {
            object val_1 = new System.Object();
            typeof(WordBow.<ReDraw>d__11).__il2cppRuntimeField_8 = 0;
            typeof(WordBow.<ReDraw>d__11).__il2cppRuntimeField_10 = this;
        }
        private void PlaySound()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsSoundMuted() == true)
            {
                    return;
            }
            
            R4 + 36.PlayOneShot(clip:  R4 + 40, volumeScale:  null);
        }
        public WordBow()
        {
            this.releaseTime = 0.01f;
            this.redrawTime = 0.35f;
        }
    
    }

}
