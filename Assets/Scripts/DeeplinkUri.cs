using UnityEngine;
public class DeeplinkUri
{
    // Fields
    private System.Uri normalUri;
    private string scheme;
    private string host;
    private string query;
    private string absolutePath;
    
    // Properties
    public string Scheme { get; }
    public string Host { get; }
    public string Query { get; }
    public string AbsolutePath { get; }
    
    // Methods
    public string get_Scheme()
    {
        if((System.Uri.op_Inequality(uri1:  this.normalUri, uri2:  0)) == false)
        {
                return;
        }
        
        if(this.normalUri != 0)
        {
                return this.normalUri.Scheme;
        }
        
        return this.normalUri.Scheme;
    }
    public string get_Host()
    {
        if((System.Uri.op_Inequality(uri1:  this.normalUri, uri2:  0)) == false)
        {
                return;
        }
        
        if(this.normalUri != 0)
        {
                return this.normalUri.Host;
        }
        
        return this.normalUri.Host;
    }
    public string get_Query()
    {
        if((System.Uri.op_Inequality(uri1:  this.normalUri, uri2:  0)) == false)
        {
                return;
        }
        
        if(this.normalUri != 0)
        {
                return this.normalUri.Query;
        }
        
        return this.normalUri.Query;
    }
    public string get_AbsolutePath()
    {
        if((System.Uri.op_Inequality(uri1:  this.normalUri, uri2:  0)) == false)
        {
                return;
        }
        
        if(this.normalUri != 0)
        {
                return this.normalUri.AbsolutePath;
        }
        
        return this.normalUri.AbsolutePath;
    }
    public DeeplinkUri(string uri, bool useParser = False)
    {
        string val_1 = uri;
        val_1 = new System.Object();
        if(useParser != false)
        {
                this.ParseDeeplink(uri:  val_1);
            return;
        }
        
        this.normalUri = new System.Uri(uriString:  val_1);
    }
    private void ParseDeeplink(string uri)
    {
        char val_12;
        string val_2 = uri.Substring(startIndex:  0, length:  uri.IndexOf(value:  -1783934096));
        this.scheme = uri;
        string val_3 = uri + -1783934096(-1783934096);
        string val_4 = uri.Remove(startIndex:  0, count:  uri.m_stringLength);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 47;
        System.String[] val_5 = uri.Split(separator:  478563824);
        val_12 = uri.m_firstChar;
        if(val_12 == ' ')
        {
                return;
        }
        
        if(val_12 == '')
        {
                string val_6 = this.SaveAndExtractQuery(uriComponent:  478563824);
            this.host = this;
            return;
        }
        
        if(val_12 >= '')
        {
                string val_7 = uri + 16;
            var val_12 = 0;
            do
        {
            if(val_12 == 0)
        {
                this.host = uri;
            val_12 = uri.m_firstChar;
        }
        
            if(val_12 == (val_12 - 1))
        {
                string val_9 = this.SaveAndExtractQuery(uriComponent:  15388672);
            val_12 = uri.m_firstChar;
            if(val_12 <= val_12)
        {
                val_12 = uri.m_firstChar;
        }
        
            mem2[0] = this;
        }
        
            val_12 = val_12 + 1;
        }
        while(val_12 < val_12);
        
        }
        
        string val_10 = System.String.Join(separator:  1115175264, value:  uri);
        string val_11 = System.String.Format(format:  -1783934016, arg0:  1115175264);
        this.absolutePath = "/{0}/";
    }
    private string SaveAndExtractQuery(string uriComponent)
    {
        var val_5;
        int val_1 = uriComponent.IndexOf(value:  '?');
        if(val_1 == 1)
        {
            goto label_2;
        }
        
        string val_2 = uriComponent.Substring(startIndex:  0, length:  val_1);
        val_5 = uriComponent;
        if((System.String.IsNullOrEmpty(value:  uriComponent)) == false)
        {
            goto label_4;
        }
        
        this.query = uriComponent;
        val_5 = "";
        return;
        label_2:
        val_5 = uriComponent;
        return;
        label_4:
        string val_4 = uriComponent.Remove(startIndex:  0, count:  uriComponent.m_stringLength);
        this.query = uriComponent;
    }

}
