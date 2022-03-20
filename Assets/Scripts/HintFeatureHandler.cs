using UnityEngine;
public class HintFeatureHandler : MonoBehaviour
{
    // Properties
    public virtual bool freeHintEligable { get; }
    public virtual bool hasFreeHintsRemaining { get; }
    
    // Methods
    public virtual void Init()
    {
    
    }
    public virtual bool get_freeHintEligable()
    {
        return false;
    }
    public virtual void DoButtonStartBehavior(WGHintButton hButton)
    {
    
    }
    public virtual void OnLevelStarted()
    {
    
    }
    public virtual void OnLevelComplete()
    {
    
    }
    public virtual void OnSceneChanged()
    {
    
    }
    public virtual bool get_hasFreeHintsRemaining()
    {
        return false;
    }
    public virtual void OnMyFreeHintUsed()
    {
    
    }
    public virtual void OnHintUsed(bool freeHint)
    {
    
    }
    public HintFeatureHandler()
    {
    
    }

}
