using UnityEngine;
[Serializable]
private class SRServiceManager.ServiceStub
{
    // Fields
    public System.Func<object> Constructor;
    public System.Type InterfaceType;
    public System.Func<System.Type> Selector;
    public System.Type Type;
    
    // Methods
    public override string ToString()
    {
        object val_4;
        var val_5;
        System.Type val_6;
        string val_1 = this.InterfaceType + -1774063808(-1774063808);
        val_4 = this.InterfaceType;
        if((System.Type.op_Inequality(left:  this.Type, right:  0)) != false)
        {
                val_5 = "Type: ";
            val_6 = this.Type;
        }
        else
        {
                val_6 = this.Selector;
            if(val_6 != 0)
        {
                val_5 = "Selector: ";
        }
        else
        {
                val_6 = this.Constructor;
            if(val_6 == 0)
        {
                return val_4 + 1009293344;
        }
        
            val_5 = "Constructor: ";
        }
        
        }
        
        string val_3 = val_4 + 405823248 + val_6;
        val_4 = val_4;
        return val_4 + 1009293344;
    }
    public SRServiceManager.ServiceStub()
    {
    
    }

}
