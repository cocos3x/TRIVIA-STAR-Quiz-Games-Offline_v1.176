using UnityEngine;
public class CompanyDevices : ScriptableObject
{
    // Fields
    public static bool TrackingAllowed;
    public System.Collections.Generic.List<AllowedDevice> allowedAddresses;
    public System.Collections.Generic.List<AllowedDevice> allowedIDFAs;
    public System.Collections.Generic.List<AllowedDevice> allowedDeviceId;
    public System.Collections.Generic.List<AllowedDevice> deviceIds;
    public System.Collections.Generic.List<string> lowEndDevices;
    private static CompanyDevices _instance;
    
    // Properties
    public static string AllowedId { get; }
    public static CompanyDevices Instance { get; }
    
    // Methods
    public static void SwitchDevice()
    {
        null = null;
        bool val_1 = CompanyDevices.TrackingAllowed;
        val_1 = val_1 ^ 1;
        CompanyDevices.TrackingAllowed = val_1;
    }
    public bool CompanyDevice()
    {
        var val_9;
        var val_11;
        System.Collections.Generic.List<AllowedDevice> val_12;
        object val_1 = new System.Object();
        val_9 = null;
        val_9 = null;
        if(CompanyDevicesHelper.cached != false)
        {
                return (bool)CompanyDevicesHelper.cachedValue;
        }
        
        val_11 = 1152921504896356352;
        string val_2 = DeviceIdPlugin.GetDeviceId();
        typeof(CompanyDevices.<>c__DisplayClass7_0).__il2cppRuntimeField_8 = 0;
        val_12 = this.deviceIds;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_3 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  285515776, method:  new IntPtr(2324448352));
        object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  val_12, predicate:  7720960);
        if(val_12 == 0)
        {
                string val_5 = DeviceIdPlugin.GetMacAddress();
            val_11 = 1152921511226264672;
            string val_6 = 0.ToUpper();
            typeof(CompanyDevices.<>c__DisplayClass7_0).__il2cppRuntimeField_8 = 0;
            val_12 = null;
            val_12 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  285515776, method:  new IntPtr(2324455520));
            object val_8 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.allowedAddresses, predicate:  7720960);
            if(this.allowedAddresses == 0)
        {
                return this.allowedAddresses.ReturnType(value:  true);
        }
        
        }
        
        return this.allowedAddresses.ReturnType(value:  true);
    }
    public bool isLowEndDevice()
    {
        CompanyDevices val_1 = CompanyDevices.Instance;
        string val_2 = DeviceProperties.DeviceModel;
        return typeof(CompanyDevices).__il2cppRuntimeField_1C.Contains(item:  0);
    }
    public bool isRunningOutOfMemory()
    {
        return false;
    }
    private bool ReturnType(bool value)
    {
        null = null;
        CompanyDevicesHelper.cachedValue = value;
        CompanyDevicesHelper.cached = true;
        return (bool)CompanyDevicesHelper.cachedValue;
    }
    public static string get_AllowedId()
    {
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(CompanyDevice() == false)
        {
                return;
        }
        
        string val_3 = DeviceIdPlugin.GetMacAddress();
        string val_4 = 0.ToUpper();
        return System.String.Format(format:  -1970054560, arg0:  0);
    }
    private static void LoadInstance()
    {
        CompanyDevices val_2;
        var val_3;
        val_2 = 0;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  -1969942336);
        val_3 = null;
        val_3 = null;
        if(("data/Company_Devices") != 0)
        {
                if(null != val_3)
        {
            
        }
        else
        {
                val_2 = "data/Company_Devices";
        }
        
        }
        
        CompanyDevices._instance = val_2;
    }
    public static CompanyDevices get_Instance()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(CompanyDevices._instance == 0)
        {
                CompanyDevices.LoadInstance();
        }
        
        val_3 = null;
        val_3 = null;
    }
    public CompanyDevices()
    {
    
    }
    private static CompanyDevices()
    {
    
    }

}
