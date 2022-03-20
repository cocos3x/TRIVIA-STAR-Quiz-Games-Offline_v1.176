using UnityEngine;
[Serializable]
public class MessageParams
{
    // Fields
    public string Message;
    public PromptType Prompt;
    public bool Localize;
    
    // Methods
    public MessageParams()
    {
        this.Message = "";
    }
    public MessageParams(string message, PromptType prompt, bool localize)
    {
        this.Message = "";
        this.Message = message;
        this.Prompt = prompt;
        this.Localize = localize;
    }
    public override string ToString()
    {
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.Prompt = ;
        string val_1 = this.Localize.ToString();
        string val_2 = System.String.Format(format:  -1824964064, arg0:  this.Message, arg1:  291106816, arg2:  this.Localize);
    }

}
