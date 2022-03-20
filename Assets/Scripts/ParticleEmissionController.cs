using UnityEngine;
public class ParticleEmissionController : MonoBehaviour
{
    // Fields
    private UnityEngine.ParticleSystem particles;
    
    // Methods
    public void PlayEffects()
    {
        this.particles.Play();
    }
    public void StopEffects()
    {
        this.particles.Stop();
    }
    public ParticleEmissionController()
    {
    
    }

}
