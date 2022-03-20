using UnityEngine;
public class DebugWindowManager : MonoSingleton<DebugWindowManager>
{
    // Fields
    private PrefabsFromFolder prefabsFromFolder;
    private System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> loadedWindows;
    
    // Methods
    private void Start()
    {
    
    }
    public T ShowWindow<T>()
    {
        if((UnityEngine.Object.op_Implicit(exists:  -910689952)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  true);
    }
    private T GetWindow<T>()
    {
        PrefabsFromFolder val_11;
        var val_12;
        float val_13;
        var val_14;
        val_11 = this;
        val_12 = __RuntimeMethodHiddenParam;
        val_13 = 1152921504765685760;
        if(this.prefabsFromFolder == 0)
        {
                object val_2 = this.GetComponent<System.Object>();
            this.prefabsFromFolder = val_11;
        }
        
        val_14 = 1152921504623353856;
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
        if((this.loadedWindows.ContainsKey(key:  __RuntimeMethodHiddenParam + 24)) == false)
        {
            goto label_15;
        }
        
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
        UnityEngine.GameObject val_6 = this.loadedWindows.Item[__RuntimeMethodHiddenParam + 24];
        if(this.loadedWindows == 0)
        {
            goto label_15;
        }
        
        if(this.loadedWindows != 0)
        {
            goto __RuntimeMethodHiddenParam + 24 + 4;
        }
        
        goto __RuntimeMethodHiddenParam + 24 + 4;
        label_15:
        System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = R4 + 24});
        UnityEngine.GameObject val_9 = R5 + 12.gameObject;
        R5 + 16.Add(key:  R4 + 24, value:  R5 + 12);
    }
    public DebugWindowManager()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.loadedWindows = null;
    }

}
