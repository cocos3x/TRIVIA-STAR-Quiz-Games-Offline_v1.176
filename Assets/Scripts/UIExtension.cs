using UnityEngine;
public static class UIExtension
{
    // Methods
    public static UnityEngine.Vector3[] GetCorners(UnityEngine.RectTransform rectTransform)
    {
        rectTransform.GetWorldCorners(fourCornersArray:  533912224);
    }
    public static float MaxY(UnityEngine.RectTransform rectTransform)
    {
        UnityEngine.Vector3[] val_1 = UIExtension.GetCorners(rectTransform:  rectTransform);
        if(rectTransform > 1)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public static float MinY(UnityEngine.RectTransform rectTransform)
    {
        UnityEngine.Vector3[] val_1 = UIExtension.GetCorners(rectTransform:  rectTransform);
        if(rectTransform != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public static float MaxX(UnityEngine.RectTransform rectTransform)
    {
        UnityEngine.Vector3[] val_1 = UIExtension.GetCorners(rectTransform:  rectTransform);
        if(rectTransform > 2)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public static float MinX(UnityEngine.RectTransform rectTransform)
    {
        UnityEngine.Vector3[] val_1 = UIExtension.GetCorners(rectTransform:  rectTransform);
        if(rectTransform != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }

}
