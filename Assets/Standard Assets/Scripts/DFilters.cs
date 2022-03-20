using UnityEngine;
public class DFilters
{
    // Fields
    public const string ALL = "all";
    public const string DEFAULT = "default";
    public static string[] projectFilters;
    
    // Methods
    public DFilters()
    {
    
    }
    private static DFilters()
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = "UI & User Control";
        typeof(System.String[]).__il2cppRuntimeField_14 = "General APP";
        typeof(System.String[]).__il2cppRuntimeField_18 = "Data / Save & Load";
        typeof(System.String[]).__il2cppRuntimeField_1C = "Localization & Language";
        typeof(System.String[]).__il2cppRuntimeField_20 = "Scene Management";
        typeof(System.String[]).__il2cppRuntimeField_24 = "External Communication";
        typeof(System.String[]).__il2cppRuntimeField_28 = "NGUI";
        DFilters.projectFilters = null;
    }

}
