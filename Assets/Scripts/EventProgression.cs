using UnityEngine;
public class EventProgression
{
    // Methods
    public virtual void LoadFromJSON()
    {
    
    }
    public virtual void SaveToJSON()
    {
    
    }
    public virtual void Delete()
    {
    
    }
    protected void DeleteKey(string key)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    public EventProgression()
    {
    
    }

}
