using UnityEngine;
public class ReadOnlyInInspector : MonoBehaviour
{
    // Fields
    public string hoge;
    public int fuga;
    public UnityEngine.AudioType audioType;
    
    // Methods
    public ReadOnlyInInspector()
    {
        this.hoge = "hoge";
        this.fuga = 1;
        this.audioType = 1;
    }

}
