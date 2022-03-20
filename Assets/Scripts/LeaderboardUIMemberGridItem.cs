using UnityEngine;
public class LeaderboardUIMemberGridItem : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Text rank;
    protected AvatarSlotUGUI profileImage;
    protected UnityEngine.UI.Text profileName;
    protected UnityEngine.UI.Text apples;
    
    // Methods
    public virtual void UpdateUIFromMember(LeaderboardPlayerInfo info)
    {
        string val_1 = info.ToString();
        decimal val_2 = System.Decimal.op_Implicit(value:  -250116020);
        string val_3 = NumberAbbreviation.GetNumber(num:  new System.Decimal());
        SLC.Social.Profile val_4 = new SLC.Social.Profile();
        typeof(SLC.Social.Profile).__il2cppRuntimeField_24 = info;
        if((System.String.IsNullOrEmpty(value:  info)) != true)
        {
                typeof(SLC.Social.Profile).__il2cppRuntimeField_28 = info;
            typeof(SLC.Social.Profile).__il2cppRuntimeField_2C = 1;
        }
        
        UnityEngine.GameObject val_6 = this.gameObject;
        this.SetActive(value:  true);
    }
    public LeaderboardUIMemberGridItem()
    {
    
    }

}
