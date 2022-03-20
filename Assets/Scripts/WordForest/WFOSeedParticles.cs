using UnityEngine;

namespace WordForest
{
    public class WFOSeedParticles : MonoBehaviour
    {
        // Fields
        private UnityEngine.ParticleSystem trailParticles;
        private UnityEngine.ParticleSystem burstParticles;
        private UnityEngine.Transform trailDestination;
        private float staggerDuration;
        
        // Methods
        public void PlayParticles(UnityEngine.Vector3 destinationPosition, int particleCount)
        {
            float val_5;
            float val_6;
            var val_7;
            val_5 = destinationPosition.z;
            val_6 = destinationPosition.y;
            val_7 = 0;
            this.trailDestination.position = new UnityEngine.Vector3() {x = destinationPosition.x, y = val_6, z = val_5};
            if(particleCount >= 1)
            {
                    val_5 = 1152921504797581312;
                val_6 = 1152921513538059200;
                do
            {
                DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  341307776, method:  new IntPtr(341277632));
                float val_5 = 0f;
                val_5 = this.staggerDuration * val_5;
                DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_5, callback:  val_5, ignoreTimeScale:  false);
                val_7 = val_7 + 1;
            }
            while(particleCount != val_7);
            
            }
            
            this.burstParticles.Play();
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  341307776, method:  new IntPtr(341282752));
            DG.Tweening.Tween val_4 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_5, callback:  1082130432, ignoreTimeScale:  false);
        }
        public WFOSeedParticles()
        {
        
        }
        private void <PlayParticles>b__4_1()
        {
            this.trailParticles.Emit(count:  1);
        }
        private void <PlayParticles>b__4_0()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  341660160);
        }
    
    }

}
