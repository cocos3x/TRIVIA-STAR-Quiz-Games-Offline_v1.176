using UnityEngine;
public class GoalsManager : MonoSingleton<GoalsManager>
{
    // Fields
    protected System.Action<bool> OnAttackCompleted;
    protected System.Action<bool> OnRaidCompleted;
    protected System.Action OnLevelUpStructure;
    protected System.Action<int> OnEventIconCollected;
    
    // Methods
    public void AddAttackCompletedListener(System.Action<bool> listener)
    {
        System.Action<System.Boolean> val_2 = this.OnAttackCompleted;
        System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.OnAttackCompleted, b:  listener);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.OnAttackCompleted = val_2;
    }
    public void RemoveAttackCompletedListener(System.Action<bool> listener)
    {
        System.Action<System.Boolean> val_2 = this.OnAttackCompleted;
        System.Delegate val_1 = System.Delegate.Remove(source:  val_2 = this.OnAttackCompleted, value:  listener);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.OnAttackCompleted = val_2;
    }
    public void NotifyAttackCompleted(bool isAttackSuccessful)
    {
        if(this.OnAttackCompleted == 0)
        {
                return;
        }
        
        this.OnAttackCompleted.Invoke(obj:  isAttackSuccessful);
    }
    public void AddRaidCompletedListener(System.Action<bool> listener)
    {
        System.Action<System.Boolean> val_2 = this.OnRaidCompleted;
        System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.OnRaidCompleted, b:  listener);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.OnRaidCompleted = val_2;
    }
    public void RemoveRaidCompletedListener(System.Action<bool> listener)
    {
        System.Action<System.Boolean> val_2 = this.OnRaidCompleted;
        System.Delegate val_1 = System.Delegate.Remove(source:  val_2 = this.OnRaidCompleted, value:  listener);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.OnRaidCompleted = val_2;
    }
    public void NotifyRaidCompleted(bool isRaidPerfect)
    {
        if(this.OnRaidCompleted == 0)
        {
                return;
        }
        
        this.OnRaidCompleted.Invoke(obj:  isRaidPerfect);
    }
    public void AddLevelUpStructureListener(System.Action listener)
    {
        System.Action val_2 = this.OnLevelUpStructure;
        System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.OnLevelUpStructure, b:  listener);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.OnLevelUpStructure = val_2;
    }
    public void RemoveLevelUpStructureListener(System.Action listener)
    {
        System.Action val_2 = this.OnLevelUpStructure;
        System.Delegate val_1 = System.Delegate.Remove(source:  val_2 = this.OnLevelUpStructure, value:  listener);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.OnLevelUpStructure = val_2;
    }
    public void NotifyLevelUpStructure()
    {
        if(this.OnLevelUpStructure == 0)
        {
                return;
        }
        
        this.OnLevelUpStructure.Invoke();
    }
    public void AddEventIconCollectedListener(System.Action<int> listener)
    {
        System.Action<System.Int32> val_2 = this.OnEventIconCollected;
        System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.OnEventIconCollected, b:  listener);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.OnEventIconCollected = val_2;
    }
    public void RemoveEventIconCollectedListener(System.Action<int> listener)
    {
        System.Action<System.Int32> val_2 = this.OnEventIconCollected;
        System.Delegate val_1 = System.Delegate.Remove(source:  val_2 = this.OnEventIconCollected, value:  listener);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.OnEventIconCollected = val_2;
    }
    public void NotifyEventIconCollected(int amtCollected)
    {
        if(this.OnEventIconCollected == 0)
        {
                return;
        }
        
        this.OnEventIconCollected.Invoke(obj:  amtCollected);
    }
    public GoalsManager()
    {
    
    }

}
