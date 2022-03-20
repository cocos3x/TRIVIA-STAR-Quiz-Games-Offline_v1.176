using UnityEngine;
public static class SRInstantiate
{
    // Methods
    public static T Instantiate<T>(T prefab)
    {
        goto __RuntimeMethodHiddenParam + 24;
    }
    public static UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab)
    {
        return UnityEngine.Object.Instantiate<System.Object>(original:  prefab);
    }
    public static T Instantiate<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        float val_1;
        float val_2;
        val_1 = rotation.w;
        val_2 = rotation.z;
        val_2 = rotation.z;
        val_1 = rotation.w;
    }

}
