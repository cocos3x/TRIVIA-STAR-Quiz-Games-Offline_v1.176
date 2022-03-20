using UnityEngine;
public class Request
{
    // Fields
    private string url;
    public string method;
    public System.Collections.Generic.Dictionary<string, string> parameters;
    
    // Methods
    public Request(string url, string method, System.Collections.Generic.Dictionary<string, string> parameters)
    {
        val_1 = new System.Object();
        this.url = url;
        this.method = val_1;
        this.parameters = parameters;
    }
    public string getFullUrl()
    {
        return this.url + this.method;
    }

}
