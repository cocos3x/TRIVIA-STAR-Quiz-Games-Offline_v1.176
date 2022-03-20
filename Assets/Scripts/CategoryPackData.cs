using UnityEngine;
public class CategoryPackData : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<CategoryColor> colorList;
    public static System.Collections.Generic.List<CategoryPackInfo> packList;
    
    // Methods
    public CategoryPackData()
    {
    
    }
    private static CategoryPackData()
    {
        if(mem[35626804] != true)
        {
            
        }
    
    }

}
