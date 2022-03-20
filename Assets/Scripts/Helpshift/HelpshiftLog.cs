using UnityEngine;

namespace Helpshift
{
    public class HelpshiftLog
    {
        // Methods
        public static int v(string tag, string log)
        {
            return Helpshift.HelpshiftAndroidLog.v(tag:  tag, log:  log);
        }
        public static int d(string tag, string log)
        {
            return Helpshift.HelpshiftAndroidLog.d(tag:  tag, log:  log);
        }
        public static int i(string tag, string log)
        {
            return Helpshift.HelpshiftAndroidLog.i(tag:  tag, log:  log);
        }
        public static int w(string tag, string log)
        {
            return Helpshift.HelpshiftAndroidLog.w(tag:  tag, log:  log);
        }
        public static int e(string tag, string log)
        {
            return Helpshift.HelpshiftAndroidLog.e(tag:  tag, log:  log);
        }
        public HelpshiftLog()
        {
        
        }
    
    }

}
