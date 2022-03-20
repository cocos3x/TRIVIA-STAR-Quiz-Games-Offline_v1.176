using UnityEngine;
public class PersistentGameObject : MonoBehaviour
{
    // Fields
    public static System.Collections.Generic.List<string> persistentObjects;
    public bool makeRootPersistent;
    public bool unparentFromRootOnStart;
    private string superName;
    
    // Methods
    protected virtual void Awake()
    {
        var val_10;
        string val_11;
        var val_12;
        var val_13;
        if(this.makeRootPersistent == false)
        {
            goto label_1;
        }
        
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.root;
        val_10 = this;
        if(this != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_1:
        val_10 = this;
        label_4:
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.GameObject val_4 = this.gameObject;
        string val_5 = NGUITools.GetHierarchy(obj:  -2029240768);
        this.superName = this;
        val_11 = this;
        val_12 = null;
        val_11 = this.superName;
        val_12 = null;
        if((PersistentGameObject.persistentObjects.Contains(item:  val_11)) != false)
        {
                UnityEngine.Object.Destroy(obj:  -2029240768);
            return;
        }
        
        val_13 = null;
        val_13 = null;
        PersistentGameObject.persistentObjects.Add(item:  this.superName);
        UnityEngine.Object.DontDestroyOnLoad(target:  -2029240768);
        string val_7 = this.name;
        string val_8 = -2029240768(-2029240768) + -2029264864(-2029264864);
        this.name = -2029240768;
        if(this.unparentFromRootOnStart == false)
        {
                return;
        }
        
        UnityEngine.Transform val_9 = this.transform;
        this.parent = 0;
    }
    private void OnDestroy()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((PersistentGameObject.persistentObjects.Contains(item:  this.superName)) == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        bool val_2 = PersistentGameObject.persistentObjects.Remove(item:  this.superName);
    }
    public PersistentGameObject()
    {
        this.superName = "";
    }
    private static PersistentGameObject()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        PersistentGameObject.persistentObjects = null;
    }

}
