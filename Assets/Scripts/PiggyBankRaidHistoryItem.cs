using UnityEngine;
public class PiggyBankRaidHistoryItem : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image profileImage;
    private UnityEngine.UI.Text messageText;
    
    // Methods
    public void InitialiseMessage(string senderName, decimal stoleAmount, UnityEngine.Sprite avatarSprite)
    {
        GameEcon val_1 = App.getGameEcon;
        string val_2 = stoleAmount.flags.ToString(format:  null);
        string val_3 = System.String.Format(format:  -1106020816, arg0:  senderName, arg1:  -1106004632);
        this.profileImage.sprite = avatarSprite;
    }
    public PiggyBankRaidHistoryItem()
    {
    
    }

}
