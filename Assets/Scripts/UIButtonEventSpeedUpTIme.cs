using UnityEngine;
public class UIButtonEventSpeedUpTIme : MonoBehaviour
{
    // Fields
    public static float fastTimeScale;
    public static float slowTimeScale;
    private static float pauseTimeScale;
    public UIButtonEventSpeedUpTIme.TimeEffect timeEffect;
    
    // Methods
    public void OnPointerExit()
    {
        this.CancelInvoke();
        this.Invoke(methodName:  -784712736, time:  null);
    }
    public void OnPointerDown()
    {
        float val_1 = UnityEngine.Time.timeScale;
        UnityEngine.Time.timeScale = 0;
    }
    public void OnPointerUp()
    {
        this.CancelInvoke();
        this.Invoke(methodName:  -784712736, time:  null);
    }
    private void ResetTimeScale()
    {
        UnityEngine.Time.timeScale = null;
    }
    public UIButtonEventSpeedUpTIme()
    {
    
    }
    private static UIButtonEventSpeedUpTIme()
    {
        UIButtonEventSpeedUpTIme.fastTimeScale = 8f;
        UIButtonEventSpeedUpTIme.slowTimeScale = 0.2f;
        UIButtonEventSpeedUpTIme.pauseTimeScale = 0f;
    }

}
