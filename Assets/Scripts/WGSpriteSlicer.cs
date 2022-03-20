using UnityEngine;
public class WGSpriteSlicer
{
    // Fields
    private static WGSpriteSlicer _Instance;
    
    // Properties
    public static WGSpriteSlicer Instance { get; }
    
    // Methods
    private WGSpriteSlicer()
    {
    
    }
    public static WGSpriteSlicer get_Instance()
    {
        WGSpriteSlicer val_2;
        object val_1 = null;
        val_2 = WGSpriteSlicer._Instance;
        if(val_2 != 0)
        {
                return;
        }
        
        val_1 = new System.Object();
        WGSpriteSlicer._Instance = val_1;
        val_2 = WGSpriteSlicer._Instance;
    }
    public UnityEngine.Sprite GetSlicedSprite(UnityEngine.Sprite sprite, UnityEngine.Vector4 border)
    {
        UnityEngine.Texture2D val_1 = sprite.texture;
        UnityEngine.Texture2D val_2 = sprite.texture;
        UnityEngine.Rect val_3 = new UnityEngine.Rect(x:  (float)sprite, y:  null, width:  null, height:  null);
        UnityEngine.Texture2D val_4 = sprite.texture;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  (float)sprite, y:  null);
        UnityEngine.Sprite val_6 = UnityEngine.Sprite.Create(texture:  sprite, rect:  new UnityEngine.Rect() {m_XMin = val_3.m_XMin, m_YMin = val_3.m_YMin, m_Width = val_3.m_Width, m_Height = val_3.m_Height}, pivot:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, pixelsPerUnit:  (float)sprite, extrude:  1120403456, meshType:  1, border:  new UnityEngine.Vector4() {x = 0f, y = border.x, z = border.y, w = border.z});
    }

}
