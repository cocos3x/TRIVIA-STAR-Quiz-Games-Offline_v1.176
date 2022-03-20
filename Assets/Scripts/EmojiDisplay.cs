using UnityEngine;
public class EmojiDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject existingEmoji;
    
    // Methods
    public void DisplayEmoji(string emojiID, bool addOutline = False)
    {
        UnityEngine.GameObject val_8;
        UnityEngine.GameObject val_9;
        if((UnityEngine.Object.op_Implicit(exists:  this.existingEmoji)) != false)
        {
                UnityEngine.Object.Destroy(obj:  this.existingEmoji);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = public static EmojiManagerMinigames MonoSingleton<EmojiManagerMinigames>::get_Instance();
        UnityEngine.GameObject val_3 = GetEmojiPrefab(key:  emojiID);
        if((-1750167760) != 0)
        {
                UnityEngine.Transform val_5 = this.transform;
            val_8 = this;
            object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  -1750167760, parent:  -1750138640);
            val_9 = val_8;
            this.existingEmoji = val_8;
        }
        else
        {
                val_9 = this.existingEmoji;
        }
        
        bool val_7 = UnityEngine.Object.op_Implicit(exists:  val_9);
    }
    public EmojiDisplay()
    {
    
    }

}
