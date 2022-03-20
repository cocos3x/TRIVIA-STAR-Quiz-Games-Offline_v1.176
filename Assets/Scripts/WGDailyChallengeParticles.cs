using UnityEngine;
public class WGDailyChallengeParticles : MonoBehaviour
{
    // Fields
    private UnityEngine.ParticleSystem trailParticles;
    private UnityEngine.ParticleSystem burstParticles;
    private UnityEngine.Transform trailDestination;
    
    // Methods
    public void PlayParticles(UnityEngine.Vector3 destinationPosition)
    {
        this.trailDestination.position = new UnityEngine.Vector3() {x = destinationPosition.x, y = destinationPosition.y, z = destinationPosition.z};
        this.trailParticles.Emit(count:  1);
        this.burstParticles.Play();
    }
    public WGDailyChallengeParticles()
    {
    
    }

}
