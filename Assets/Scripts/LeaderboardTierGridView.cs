using UnityEngine;
public class LeaderboardTierGridView : UIListViewController
{
    // Fields
    private UnityEngine.GameObject _leaderboardTierGridItemPrefab;
    
    // Properties
    private UnityEngine.GameObject leaderboardTierGridItemPrefab { get; }
    
    // Methods
    private UnityEngine.GameObject get_leaderboardTierGridItemPrefab()
    {
        if(this._leaderboardTierGridItemPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -1535358816, prefabName:  -250833888);
        this._leaderboardTierGridItemPrefab = "Events";
    }
    protected override UnityEngine.GameObject GetMemberItemPrefab()
    {
        return this.leaderboardTierGridItemPrefab;
    }
    private void OnEnable()
    {
        this.DisplayPrizeTiers();
    }
    private void DisplayPrizeTiers()
    {
        var val_1;
        var val_1 = 23792944;
        val_1 = 11834480 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        mem[1152921512946320116] = System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze;
        this.UpdateMembersGrid();
    }
    protected override void SetupGridItem(int i)
    {
        var val_2;
        if(true <= i)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (i << 2);
        object val_1 = (0 + (i) << 2) + 16.GetComponent<System.Object>();
        var val_3 = 23792600;
        val_3 = 11834824 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        (0 + (i) << 2) + 16.UpdateTier(tier:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (i) << 2) + 16);
    }
    public LeaderboardTierGridView()
    {
    
    }

}
