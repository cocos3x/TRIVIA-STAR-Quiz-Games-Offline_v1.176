using UnityEngine;
public class DestroyByBoundary : MonoBehaviour
{
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        UnityEngine.GameObject val_1 = other.gameObject;
        UnityEngine.Object.Destroy(obj:  other);
    }
    public DestroyByBoundary()
    {
    
    }

}
