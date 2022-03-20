using UnityEngine;
public class WFLifeIcon : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image border;
    private UnityEngine.UI.Image heart;
    
    // Methods
    private void Start()
    {
        this.SetAlive(alive:  true);
    }
    public void SetAlive(bool alive)
    {
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        UnityEngine.UI.Image val_9;
        if(alive != false)
        {
                UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.border.color = new UnityEngine.Color() {a = ???};
            val_9 = this.heart;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
        }
        else
        {
                UnityEngine.Color val_3 = UnityEngine.Color.black;
            this.border.color = new UnityEngine.Color() {a = ???};
            val_9 = this.heart;
            UnityEngine.Color val_4 = UnityEngine.Color.gray;
        }
        
        val_9.color = new UnityEngine.Color() {r = val_5, g = val_6, b = val_7, a = val_8};
    }
    public WFLifeIcon()
    {
    
    }

}
