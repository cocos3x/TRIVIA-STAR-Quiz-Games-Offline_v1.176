using UnityEngine;

namespace twelvegigs.Autopilot
{
    public class AutopilotTools
    {
        // Methods
        public static bool RaycastOnButton(twelvegigs.Autopilot.AutopilotButton button, UnityEngine.Camera camera)
        {
            var val_4;
            int val_5;
            var val_6;
            System.Collections.Generic.List<UnityEngine.GameObject> val_1 = button.GetTargets();
            var val_4 = 4;
            label_7:
            val_4 = 0;
            val_5 = button.<CameraId>k__BackingField;
            if(val_4 >= val_5)
            {
                goto label_3;
            }
            
            if(val_5 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_5 = button.<CameraId>k__BackingField;
            }
            
            val_4 = 35639762;
            if(val_5 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_4 = 2621443;
            }
            
            UnityEngine.Vector3 val_2 = GetWorldCenterPos(target:  button);
            val_4 = val_4 + 1;
            if((twelvegigs.Autopilot.AutopilotTools.RaycastOnPosition(target:  static_value_021FD1D2, worldPos:  new UnityEngine.Vector3(), camera:  camera)) == false)
            {
                goto label_7;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_3:
            val_6 = 0;
            return (bool)val_6;
        }
        public static bool RaycastOnPosition(UnityEngine.GameObject target, UnityEngine.Vector3 worldPos, UnityEngine.Camera camera)
        {
            var val_6;
            var val_7;
            float val_13;
            var val_14;
            float val_15;
            var val_16;
            UnityEngine.Camera val_17;
            val_13 = worldPos.y;
            val_14 = 35639763;
            val_15 = worldPos.x;
            val_16 = 0;
            if(target == 0)
            {
                    return (bool)val_16;
            }
            
            val_17 = camera;
            UnityEngine.EventSystems.EventSystem val_2 = UnityEngine.EventSystems.EventSystem.current;
            UnityEngine.EventSystems.PointerEventData val_3 = null;
            val_14 = val_3;
            val_3 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  0);
            UnityEngine.Vector3 val_4 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_17, y = val_15, z = val_13});
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 100.4277f});
            val_15 = target;
            typeof(UnityEngine.EventSystems.PointerEventData).__il2cppRuntimeField_B0 = val_6;
            typeof(UnityEngine.EventSystems.PointerEventData).__il2cppRuntimeField_B4 = val_7;
            System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> val_8 = new System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>();
            UnityEngine.EventSystems.EventSystem val_9 = UnityEngine.EventSystems.EventSystem.current;
            val_16 = 0;
            0.RaycastAll(eventData:  210329600, raycastResults:  80883712);
            val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((List<T>.__il2cppRuntimeField_10) != val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                object val_11 = List<T>.__il2cppRuntimeField_10.GetComponent<System.Object>();
                val_16 = 0;
                if((List<T>.__il2cppRuntimeField_10) != 0)
            {
                    return (bool)val_16;
            }
            
                val_14 = val_14 + 1;
                return (bool)val_16;
            }
            
            val_16 = 1;
            return (bool)val_16;
        }
        public static UnityEngine.Camera GetCamera(UnityEngine.Transform go)
        {
            UnityEngine.Transform val_8 = go;
            goto label_0;
            label_13:
            object val_1 = val_8.GetComponentInParent<System.Object>();
            if(val_8 == 0)
            {
                    return;
            }
            
            if(val_8 == 0)
            {
                goto label_5;
            }
            
            UnityEngine.RenderMode val_3 = val_8.renderMode;
            if(val_8 != 1)
            {
                goto label_6;
            }
            
            return val_8.worldCamera;
            label_5:
            UnityEngine.RenderMode val_4 = val_8.renderMode;
            if(val_8 == 1)
            {
                    return val_8.worldCamera;
            }
            
            label_6:
            UnityEngine.Transform val_5 = val_8.transform;
            UnityEngine.Transform val_6 = val_8.parent;
            val_8 = val_8;
            label_0:
            if(val_8 != 0)
            {
                goto label_13;
            }
        
        }
        public static string GetRoute(UnityEngine.Transform transform)
        {
            if(transform == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = transform.parent;
            string val_3 = transform.name;
            return System.String.Format(format:  1629069648, arg0:  transform, arg1:  transform);
        }
        public static byte[] TakeScreenshot()
        {
            UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, textureFormat:  3, mipChain:  false);
            int val_4 = UnityEngine.Screen.width;
            UnityEngine.Rect val_6 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  null, width:  null, height:  null);
            ReadPixels(source:  new UnityEngine.Rect() {m_XMin = val_6.m_XMin, m_YMin = val_6.m_YMin, m_Width = val_6.m_Width, m_Height = val_6.m_Height}, destX:  0, destY:  0);
            Apply();
            System.Byte[] val_7 = UnityEngine.ImageConversion.EncodeToPNG(tex:  154206208);
            UnityEngine.Object.Destroy(obj:  154206208);
        }
        public static void LogFormat(string format, object[] args)
        {
            string val_1 = 1120961104 + format;
            UnityEngine.Debug.LogFormat(format:  1120961104, args:  args);
        }
        public static void Log(string message)
        {
            string val_1 = 1121118256 + message;
            UnityEngine.Debug.Log(message:  1121118256);
        }
        public static void LogErrorFormat(string format, object[] args)
        {
            string val_1 = 1121118256 + format;
            UnityEngine.Debug.LogErrorFormat(format:  1121118256, args:  args);
        }
        public static void LogError(string message)
        {
            string val_1 = 1121118256 + message;
            UnityEngine.Debug.LogError(message:  1121118256);
        }
        public AutopilotTools()
        {
        
        }
    
    }

}
