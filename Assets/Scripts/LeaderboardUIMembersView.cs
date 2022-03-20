using UnityEngine;
public class LeaderboardUIMembersView : UIListViewController
{
    // Fields
    private UnityEngine.GameObject _leaderboardUIMemberGridItemPrefab;
    
    // Properties
    private UnityEngine.GameObject leaderboardUIMemberGridItemPrefab { get; }
    
    // Methods
    private UnityEngine.GameObject get_leaderboardUIMemberGridItemPrefab()
    {
        if(this._leaderboardUIMemberGridItemPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -1535358816, prefabName:  -249879392);
        this._leaderboardUIMemberGridItemPrefab = "Events";
    }
    protected override UnityEngine.GameObject GetMemberItemPrefab()
    {
        return this.leaderboardUIMemberGridItemPrefab;
    }
    private void OnEnable()
    {
        this.DisplayMembers();
    }
    private void DisplayMembers()
    {
        var val_1;
        var val_1 = 23791432;
        val_1 = 11835992 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        mem[1152921512947274612] = System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze;
        this.UpdateMembersGrid();
    }
    protected override void SetupGridItem(int i)
    {
        var val_4;
        var val_5;
        var val_6;
        float val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_4 = this;
        val_5 = i;
        var val_3 = 23789535;
        val_3 = 11836252 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(App.game != 17)
        {
            goto label_27;
        }
        
        val_7 = 1152921504983203840;
        val_8 = 11836388 + 23791036;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        var val_4 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_4 = val_4 + (val_5 << 2);
        object val_1 = (0 + (i) << 2) + 16.GetComponent<System.Object>();
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        if(((0 + (i) << 2) + 16) != 0)
        {
            goto (0 + (i) << 2) + 16 + 220;
        }
        
        goto (0 + (i) << 2) + 16 + 220;
        label_27:
        if((R5 + 28 + 12) <= R4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = R5 + 28 + 8;
        val_5 = val_5 + ((R4) << 2);
        object val_2 = (R5 + 28 + 8 + (R4) << 2) + 16.GetComponent<System.Object>();
        var val_6 = 23790248;
        val_6 = 11837176 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        if(((R5 + 28 + 8 + (R4) << 2) + 16) == 0)
        {
            
        }
    
    }
    public LeaderboardUIMembersView()
    {
    
    }

}
