using UnityEngine;
public struct SpineAttachment.Hierarchy
{
    // Fields
    public string skin;
    public string slot;
    public string name;
    
    // Methods
    public SpineAttachment.Hierarchy(string fullPath)
    {
        typeof(System.Char[]).__il2cppRuntimeField_10 = 47;
        System.String[] val_1 = fullPath.Split(separator:  478563824, options:  1);
        if(fullPath.m_firstChar == ' ')
        {
            goto label_5;
        }
        
        if(fullPath.m_firstChar <= '')
        {
            goto label_6;
        }
        
        this = fullPath.m_firstChar;
        if(fullPath.m_firstChar < '')
        {
                return;
        }
        
        do
        {
            string val_2 = 1098586544 + null;
            this.name = "";
            var val_3 = 6 + 1;
        }
        while((6 - 3) < fullPath.m_firstChar);
        
        return;
        label_5:
        this = "";
        this.slot = "";
        this.name = "";
        return;
        label_6:
        string val_5 = 2019775568 + fullPath + 1487188992;
        System.Exception val_6 = new System.Exception(message:  2019775568);
    }

}
