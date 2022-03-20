using UnityEngine;
public class LineDrawerParticles : MonoBehaviour
{
    // Fields
    private UnityEngine.ParticleSystem particleSystem;
    
    // Methods
    private void Start()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.particleSystem = this;
    }
    public void Play(System.Collections.Generic.List<UnityEngine.Vector3> selectedPositions)
    {
        System.Collections.IEnumerator val_1 = this.PlayInSequence(selectedPositions:  selectedPositions);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -168490544);
    }
    private System.Collections.IEnumerator PlayInSequence(System.Collections.Generic.List<UnityEngine.Vector3> selectedPositions)
    {
        typeof(LineDrawerParticles.<PlayInSequence>d__3).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(LineDrawerParticles.<PlayInSequence>d__3).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(LineDrawerParticles.<PlayInSequence>d__3).__il2cppRuntimeField_14 = selectedPositions;
    }
    public LineDrawerParticles()
    {
    
    }

}
