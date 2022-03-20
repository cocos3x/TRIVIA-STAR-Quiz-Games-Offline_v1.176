using UnityEngine;
public class ImageLoadingController
{
    // Methods
    public static UnityEngine.Sprite GetSprite(string path)
    {
        float val_5;
        float val_6;
        var val_8;
        UnityEngine.Texture2D val_1 = ImageLoadingController.GetTexture2D(path:  path);
        val_8 = 0;
        if(path == 0)
        {
                return;
        }
        
        UnityEngine.Rect val_3 = new UnityEngine.Rect(x:  (float)path, y:  null, width:  null, height:  null);
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        UnityEngine.Sprite val_7 = UnityEngine.Sprite.Create(texture:  path, rect:  new UnityEngine.Rect() {m_XMin = val_3.m_XMin, m_YMin = val_3.m_YMin, m_Width = val_3.m_Width, m_Height = val_3.m_Height}, pivot:  new UnityEngine.Vector2() {x = val_5, y = val_6});
        val_8 = path;
    }
    public static UnityEngine.Texture2D GetTexture2D(string path)
    {
        var val_5;
        if((System.IO.File.Exists(path:  path)) != false)
        {
                UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  1, height:  1);
            name = path;
            System.Byte[] val_3 = System.IO.File.ReadAllBytes(path:  path);
            if((UnityEngine.ImageConversion.LoadImage(tex:  154206208, data:  path)) == false)
        {
                val_5 = 0;
        }
        
            return;
        }
        
        val_5 = 0;
    }
    public ImageLoadingController()
    {
    
    }

}
