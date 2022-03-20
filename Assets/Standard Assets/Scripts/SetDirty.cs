using UnityEngine;
public class SetDirty : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Graphic m_graphic;
    
    // Methods
    private void Reset()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.m_graphic = this;
    }
    private void Update()
    {
        if(this.m_graphic == 0)
        {
            
        }
    
    }
    public SetDirty()
    {
    
    }

}
