using UnityEngine;
public class PreviewTextureAttribute : PropertyAttribute
{
    // Fields
    public UnityEngine.Rect lastPosition;
    public long expire;
    public UnityEngine.WWW www;
    public UnityEngine.Texture2D cached;
    
    // Methods
    public PreviewTextureAttribute()
    {
        UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
        this.expire = 6000000000;
    }
    public PreviewTextureAttribute(int expire)
    {
        UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
        this.expire = 6000000000;
        long val_3 = 10000000;
        val_3 = expire * val_3;
        int val_2 = val_3 >> 31;
        this.expire = val_3;
    }

}
