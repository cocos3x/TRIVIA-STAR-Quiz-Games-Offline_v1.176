using UnityEngine;
public class DisableOnNonCompanyDevice : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == true)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = R4.gameObject;
        R4.SetActive(value:  false);
    }
    public DisableOnNonCompanyDevice()
    {
    
    }

}
