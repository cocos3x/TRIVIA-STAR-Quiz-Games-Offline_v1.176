using UnityEngine;
public sealed class HelpshiftUser.Builder
{
    // Fields
    private string identifier;
    private string email;
    private string name;
    private string authToken;
    
    // Methods
    public HelpshiftUser.Builder(string identifier, string email)
    {
        val_1 = new System.Object();
        this.identifier = identifier;
        this.email = val_1;
    }
    public Helpshift.HelpshiftUser.Builder setName(string name)
    {
        this.name = name;
    }
    public Helpshift.HelpshiftUser.Builder setAuthToken(string authToken)
    {
        this.authToken = authToken;
    }
    public Helpshift.HelpshiftUser build()
    {
        object val_1 = new System.Object();
    }

}
