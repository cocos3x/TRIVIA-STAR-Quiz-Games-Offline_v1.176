using UnityEngine;

namespace EpicToonFX
{
    public class ETFXLoopScript : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject chosenEffect;
        public float loopTimeLimit;
        public bool spawnWithoutLight;
        public bool spawnWithoutSound;
        
        // Methods
        private void Start()
        {
            this.PlayEffect();
        }
        public void PlayEffect()
        {
            UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  690240976);
        }
        private System.Collections.IEnumerator EffectLoop()
        {
            object val_1 = new System.Object();
            typeof(ETFXLoopScript.<EffectLoop>d__6).__il2cppRuntimeField_8 = 0;
            typeof(ETFXLoopScript.<EffectLoop>d__6).__il2cppRuntimeField_10 = this;
        }
        public ETFXLoopScript()
        {
            this.loopTimeLimit = 2f;
            this.spawnWithoutLight = true;
            this.spawnWithoutSound = true;
        }
    
    }

}
