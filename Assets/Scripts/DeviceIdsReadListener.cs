using UnityEngine;
private class AdjustAndroid.DeviceIdsReadListener : AndroidJavaProxy
{
    // Fields
    private System.Action<string> onPlayAdIdReadCallback;
    
    // Methods
    public AdjustAndroid.DeviceIdsReadListener(System.Action<string> pCallback)
    {
        this.onPlayAdIdReadCallback = pCallback;
    }
    public void onGoogleAdIdRead(string playAdId)
    {
        if(this.onPlayAdIdReadCallback == 0)
        {
                return;
        }
        
        this.onPlayAdIdReadCallback.Invoke(obj:  playAdId);
    }
    public void onGoogleAdIdRead(UnityEngine.AndroidJavaObject ajoAdId)
    {
        var val_2;
        if(ajoAdId != 0)
        {
                val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_2 == 1)
        {
                val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_1 = ajoAdId.Call<UnityEngine.AndroidJavaObject>(methodName:  1288748368, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            this.onGoogleAdIdRead(playAdId:  ajoAdId);
            return;
        }
        
        this.onGoogleAdIdRead(playAdId:  null);
    }

}
