using UnityEngine;
public class WGSFXController : MonoSingleton<WGSFXController>
{
    // Fields
    private System.Collections.Generic.Dictionary<string, UnityEngine.ParticleSystem> loadedSFX;
    private PrefabsFromFolder prefabsFromFolder;
    private UnityEngine.ParticleSystem sfx;
    
    // Methods
    public UnityEngine.ParticleSystem PlaySFX(WGSFXController.SFXType reqType, UnityEngine.RectTransform parent, bool playImmediate = True)
    {
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        UnityEngine.ParticleSystem val_1 = this.PlaySFX(name:  374652928, parent:  parent, playImmediate:  playImmediate);
    }
    public UnityEngine.ParticleSystem PlaySFX(string name, UnityEngine.RectTransform parent, bool playImmediate = True)
    {
        UnityEngine.ParticleSystem val_1 = this.LoadSFX(name:  name);
        MainModule val_2 = this.main;
        val_2.m_ParticleSystem.playOnAwake = playImmediate;
        object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  -281266352, parent:  parent);
        UnityEngine.Transform val_4 = parent.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        parent.localPosition = new UnityEngine.Vector3();
    }
    private UnityEngine.ParticleSystem LoadSFX(string name)
    {
        UnityEngine.ParticleSystem val_8;
        if((this.loadedSFX.ContainsKey(key:  name)) != false)
        {
                UnityEngine.ParticleSystem val_2 = this.loadedSFX.Item[name];
            this.sfx = this.loadedSFX;
            if(this.loadedSFX != 0)
        {
                val_8 = this.sfx;
            return;
        }
        
            bool val_4 = this.loadedSFX.Remove(key:  name);
        }
        
        UnityEngine.ParticleSystem val_5 = this.prefabsFromFolder.LoadLooselyNamedPrefab<UnityEngine.ParticleSystem>(prefabName:  name);
        val_8 = this.prefabsFromFolder;
        if(val_8 != 0)
        {
                this.loadedSFX.Add(key:  name, value:  val_8);
            return;
        }
        
        val_8 = 0;
        string val_7 = -281136368(-281136368) + name;
        UnityEngine.Debug.LogError(message:  -281136368);
    }
    public WGSFXController()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.loadedSFX = null;
    }

}
