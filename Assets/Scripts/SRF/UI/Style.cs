using UnityEngine;

namespace SRF.UI
{
    [Serializable]
    public class Style
    {
        // Fields
        public UnityEngine.Color ActiveColor;
        public UnityEngine.Color DisabledColor;
        public UnityEngine.Color HoverColor;
        public UnityEngine.Sprite Image;
        public UnityEngine.Color NormalColor;
        
        // Methods
        public SRF.UI.Style Copy()
        {
            SRF.UI.Style val_1 = new SRF.UI.Style();
            CopyFrom(style:  391994416);
        }
        public void CopyFrom(SRF.UI.Style style)
        {
            if(style != 0)
            {
                    this.Image = style.Image;
            }
            else
            {
                    this.Image = 52;
            }
            
            if(style != 0)
            {
                
            }
            
            if(style != 0)
            {
                    return;
            }
        
        }
        public Style()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            UnityEngine.Color val_4 = UnityEngine.Color.white;
        }
    
    }

}
