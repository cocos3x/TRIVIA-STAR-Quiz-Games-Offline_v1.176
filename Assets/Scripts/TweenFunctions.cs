using UnityEngine;
private static class SRMath.TweenFunctions
{
    // Methods
    public static float Linear(float t, float b, float c, float d)
    {
        var val_1 = R2;
        val_1 = 0 * val_1;
        val_1 = val_1 / R3;
        val_1 = val_1 + R1;
        return (float)val_1;
    }
    public static float ExpoEaseOut(float t, float b, float c, float d)
    {
        var val_1 = R2;
        float val_1 = -10f;
        val_1 = 0 * val_1;
        val_1 = val_1 / R3;
        float val_2 = 1f;
        val_2 = val_2 - val_1;
        val_1 = val_2 * val_1;
        val_2 = val_1 + R1;
        return (float)val_2;
    }
    public static float ExpoEaseIn(float t, float b, float c, float d)
    {
        var val_2 = R1;
        float val_1 = 0 / R3;
        val_1 = val_1 + (-1f);
        val_1 = val_1 * 10f;
        return (float)val_1;
    }
    public static float ExpoEaseInOut(float t, float b, float c, float d)
    {
        var val_3;
        var val_4;
        uint val_2 = 0;
        val_3 = R1;
        val_4 = R3;
        val_3 = val_3 + R2;
        return (float);
    }
    public static float ExpoEaseOutIn(float t, float b, float c, float d)
    {
        float val_6 = 0.5f;
        float val_7 = R3;
        float val_2 = val_7 * val_6;
        val_6 = R2 * val_6;
        if()
        {
                return (float)SRMath.TweenFunctions.ExpoEaseOut(t:  val_6, b:  b, c:  val_7, d:  d);
        }
        
        val_7 = (0 + 0) - val_7;
        float val_4 = val_6 + R1;
        return (float)SRMath.TweenFunctions.ExpoEaseIn(t:  val_6, b:  b, c:  val_7, d:  d);
    }
    public static float CircEaseOut(float t, float b, float c, float d)
    {
        float val_3;
        float val_2 = (0 / R3) + (-1f);
        val_3 = 1f;
        return val_3;
    }
    public static float CircEaseIn(float t, float b, float c, float d)
    {
        float val_2;
        float val_1 = 0 / R3;
        val_2 = 1f;
        return 0f;
    }
    public static float CircEaseInOut(float t, float b, float c, float d)
    {
        float val_5;
        float val_6;
        var val_7;
        var val_8;
        val_5 = 0.5f;
        val_6 = -1f;
        val_5 = -0.5f;
        val_7 = (0 / (R3 * val_5)) * (0 / (R3 * val_5));
        val_8 = 1f - ;
        val_8 = val_8 + ;
        float val_4 = val_5 * R2;
        return (float)val_8;
    }
    public static float CircEaseOutIn(float t, float b, float c, float d)
    {
        float val_6 = 0.5f;
        float val_7 = R3;
        float val_2 = val_7 * val_6;
        val_6 = R2 * val_6;
        if()
        {
                return (float)SRMath.TweenFunctions.CircEaseOut(t:  val_6, b:  b, c:  val_7, d:  d);
        }
        
        val_7 = (0 + 0) - val_7;
        float val_4 = val_6 + R1;
        return (float)SRMath.TweenFunctions.CircEaseIn(t:  val_6, b:  b, c:  val_7, d:  d);
    }
    public static float QuadEaseOut(float t, float b, float c, float d)
    {
        var val_1 = R3;
        val_1 = 0 / val_1;
        float val_2 = -2f;
        val_2 = val_1 + val_2;
        val_1 = val_1 * R2;
        return (float)val_1;
    }
    public static float QuadEaseIn(float t, float b, float c, float d)
    {
        var val_1 = R3;
        val_1 = 0 / val_1;
        var val_2 = R2;
        val_2 = val_1 * val_2;
        return (float)val_1;
    }
    public static float QuadEaseInOut(float t, float b, float c, float d)
    {
        var val_2;
        var val_1 = R3;
        uint val_2 = 0;
        var val_3 = R2;
        val_1 = val_1 * 0.5f;
        val_2 = val_2 / val_1;
        var val_5 = R1;
        if(<0)
        {
                val_3 = val_3 * 0.5f;
            val_3 = val_3 * val_2;
            val_2 = val_2 * val_3;
        }
        else
        {
                float val_4 = -2f;
            val_2 = val_2 + (-1f);
            val_3 = val_3 * (-0.5f);
            val_4 = val_2 + val_4;
            val_2 = val_3 * (-1f);
        }
        
        val_5 = val_2 + val_5;
        return (float)val_5;
    }
    public static float QuadEaseOutIn(float t, float b, float c, float d)
    {
        float val_5 = 0.5f;
        var val_6 = R3;
        var val_7 = R2;
        float val_1 = 0 + 0;
        var val_8 = R1;
        float val_2 = val_6 * val_5;
        if()
        {
                float val_3 = val_1 / val_6;
            float val_4 = -0.5f;
            val_4 = val_7 * val_4;
            val_4 = val_4 * val_3;
            val_3 = val_3 + (-2f);
            return (float)val_8;
        }
        
        val_1 = val_1 - val_6;
        val_5 = val_7 * val_5;
        val_6 = val_1 / val_6;
        val_7 = val_5 * val_6;
        val_8 = val_5 + val_8;
        return (float)val_8;
    }
    public static float SineEaseOut(float t, float b, float c, float d)
    {
        float val_1 = 0 / R3;
        val_1 = val_1 * 1.570796f;
        return (float)val_1;
    }
    public static float SineEaseIn(float t, float b, float c, float d)
    {
        float val_1 = 0 / R3;
        val_1 = val_1 * 1.570796f;
        return (float)R2 + R1;
    }
    public static float SineEaseInOut(float t, float b, float c, float d)
    {
        var val_3;
        var val_4;
        uint val_2 = 0;
        val_2 = val_2 / (R3 * 0.5f);
        float val_3 = 3.141593f;
        val_3 = val_2 * val_3;
        val_3 = val_3 * 0.5f;
        val_3 = R2 * 0.5f;
        val_4 = val_3;
         =  * ;
         =  + R1;
        return (float);
    }
    public static float SineEaseOutIn(float t, float b, float c, float d)
    {
        float val_6 = 0.5f;
        float val_7 = R3;
        float val_2 = val_7 * val_6;
        val_6 = R2 * val_6;
        if()
        {
                return (float)SRMath.TweenFunctions.SineEaseOut(t:  val_6, b:  b, c:  val_7, d:  d);
        }
        
        val_7 = (0 + 0) - val_7;
        float val_4 = val_6 + R1;
        return (float)SRMath.TweenFunctions.SineEaseIn(t:  val_6, b:  b, c:  val_7, d:  d);
    }
    public static float CubicEaseOut(float t, float b, float c, float d)
    {
        var val_1 = R3;
        val_1 = 0 / val_1;
        float val_2 = -1f;
        val_1 = val_1 + val_2;
        val_2 = val_1 * val_1;
        return (float)R2;
    }
    public static float CubicEaseIn(float t, float b, float c, float d)
    {
        var val_1 = R3;
        val_1 = 0 / val_1;
        var val_2 = R2;
        val_2 = val_1 * val_2;
        val_2 = val_1 * val_2;
        return (float)val_1;
    }
    public static float CubicEaseInOut(float t, float b, float c, float d)
    {
        var val_1;
        float val_3 = 0.5f;
        var val_1 = R3;
        uint val_2 = 0;
        val_1 = val_1 * val_3;
        val_2 = val_2 / val_1;
        var val_5 = R1;
        if(<0)
        {
                val_3 = R2 * val_3;
            val_3 = val_3 * val_2;
            val_3 = val_2 * val_3;
            val_1 = val_2 * val_3;
        }
        else
        {
                float val_4 = -2f;
            val_3 = R2 * val_3;
            val_2 = val_2 + val_4;
            val_4 = val_2 * val_2;
            val_1 = val_3 * 2f;
        }
        
        val_5 = val_1 + val_5;
        return (float)val_5;
    }
    public static float CubicEaseOutIn(float t, float b, float c, float d)
    {
        var val_4;
        var val_5;
        float val_4 = 0.5f;
        var val_3 = R3;
        var val_6 = R2;
        float val_1 = 0 + 0;
        val_4 = R1;
        float val_2 = val_3 * val_4;
        if()
        {
                val_3 = val_1 / val_3;
            float val_5 = -1f;
            val_4 = val_6 * val_4;
            val_3 = val_3 + val_5;
            val_5 = val_3 * val_3;
            val_5 = val_4 * 1f;
        }
        else
        {
                val_1 = val_1 - val_3;
            val_4 = val_6 * val_4;
            val_3 = val_1 / val_3;
            val_6 = val_4 * val_3;
            val_5 = val_4 + val_4;
            val_6 = val_3 * val_6;
            val_4 = val_3 * val_6;
        }
        
        val_4 = val_5 + val_4;
        return (float)val_4;
    }
    public static float QuartEaseOut(float t, float b, float c, float d)
    {
        var val_2 = R3;
        val_2 = 0 / val_2;
        val_2 = val_2 + (-1f);
        float val_1 = val_2 * val_2;
        val_1 = val_2 * val_1;
        return (float)R2;
    }
    public static float QuartEaseIn(float t, float b, float c, float d)
    {
        var val_1 = R3;
        val_1 = 0 / val_1;
        var val_2 = R2;
        val_2 = val_1 * val_2;
        val_2 = val_1 * val_2;
        val_2 = val_1 * val_2;
        return (float)val_1;
    }
    public static float QuartEaseInOut(float t, float b, float c, float d)
    {
        var val_3;
        var val_2 = R3;
        uint val_3 = 0;
        var val_4 = R2;
        val_2 = val_2 * 0.5f;
        val_3 = val_3 / val_2;
        var val_5 = R1;
        if(<0)
        {
                val_4 = val_4 * 0.5f;
            val_4 = val_4 * val_3;
            val_4 = val_3 * val_4;
            val_4 = val_3 * val_4;
            val_3 = val_3 * val_4;
        }
        else
        {
                val_3 = val_3 + (-2f);
            val_4 = val_4 * (-0.5f);
            float val_1 = val_3 * val_3;
            val_1 = val_3 * val_1;
            val_3 = val_4 * (-2f);
        }
        
        val_5 = val_3 + val_5;
        return (float)val_5;
    }
    public static float QuartEaseOutIn(float t, float b, float c, float d)
    {
        float val_6 = 0.5f;
        var val_5 = R3;
        var val_4 = R2;
        float val_1 = 0 + 0;
        var val_7 = R1;
        float val_2 = val_5 * val_6;
        if()
        {
                float val_3 = val_1 / val_5;
            val_3 = val_3 + (-1f);
            val_4 = val_4 * (-0.5f);
            val_1 = val_3 * val_3;
            val_1 = val_3 * val_1;
            return (float)val_7;
        }
        
        val_1 = val_1 - val_5;
        val_4 = val_4 * val_6;
        val_5 = val_1 / val_5;
        val_6 = val_4 * val_5;
        val_7 = val_4 + val_7;
        val_6 = val_5 * val_6;
        val_6 = val_5 * val_6;
        return (float)val_7;
    }
    public static float QuintEaseOut(float t, float b, float c, float d)
    {
        var val_1 = R3;
        val_1 = 0 / val_1;
        float val_2 = -1f;
        val_1 = val_1 + val_2;
        val_2 = val_1 * val_1;
        val_2 = val_1 * val_2;
        val_2 = val_1 * val_2;
        return (float)R2;
    }
    public static float QuintEaseIn(float t, float b, float c, float d)
    {
        var val_1 = R3;
        val_1 = 0 / val_1;
        var val_2 = R2;
        val_2 = val_1 * val_2;
        val_2 = val_1 * val_2;
        val_2 = val_1 * val_2;
        val_2 = val_1 * val_2;
        return (float)val_1;
    }
    public static float QuintEaseInOut(float t, float b, float c, float d)
    {
        var val_1;
        float val_3 = 0.5f;
        var val_1 = R3;
        uint val_2 = 0;
        val_1 = val_1 * val_3;
        val_2 = val_2 / val_1;
        var val_5 = R1;
        if(<0)
        {
                val_3 = R2 * val_3;
            val_3 = val_3 * val_2;
            val_3 = val_2 * val_3;
            val_3 = val_2 * val_3;
            val_3 = val_2 * val_3;
            val_1 = val_2 * val_3;
        }
        else
        {
                float val_4 = -2f;
            val_3 = R2 * val_3;
            val_2 = val_2 + val_4;
            val_4 = val_2 * val_2;
            val_4 = val_2 * val_4;
            val_4 = val_2 * val_4;
            val_1 = val_3 * 2f;
        }
        
        val_5 = val_1 + val_5;
        return (float)val_5;
    }
    public static float QuintEaseOutIn(float t, float b, float c, float d)
    {
        var val_4;
        var val_5;
        float val_4 = 0.5f;
        var val_3 = R3;
        var val_6 = R2;
        float val_1 = 0 + 0;
        val_4 = R1;
        float val_2 = val_3 * val_4;
        if()
        {
                val_3 = val_1 / val_3;
            float val_5 = -1f;
            val_4 = val_6 * val_4;
            val_3 = val_3 + val_5;
            val_5 = val_3 * val_3;
            val_5 = val_3 * val_5;
            val_5 = val_3 * val_5;
            val_5 = val_4 * 1f;
        }
        else
        {
                val_1 = val_1 - val_3;
            val_4 = val_6 * val_4;
            val_3 = val_1 / val_3;
            val_6 = val_4 * val_3;
            val_5 = val_4 + val_4;
            val_6 = val_3 * val_6;
            val_6 = val_3 * val_6;
            val_6 = val_3 * val_6;
            val_4 = val_3 * val_6;
        }
        
        val_4 = val_5 + val_4;
        return (float)val_4;
    }
    public static float ElasticEaseOut(float t, float b, float c, float d)
    {
        var val_5;
        uint val_3 = 0;
        val_3 = val_3 / R3;
        val_5 = R1 + R2;
        return (float);
    }
    public static float ElasticEaseIn(float t, float b, float c, float d)
    {
        var val_5;
        float val_1 = 0 / R3;
        val_5 = R1 + R2;
        return (float);
    }
    public static float ElasticEaseInOut(float t, float b, float c, float d)
    {
        var val_6;
        float val_1 = R3 * 0.5f;
        val_1 = 0 / val_1;
        val_6 = R1 + R2;
        return (float);
    }
    public static float ElasticEaseOutIn(float t, float b, float c, float d)
    {
        float val_6 = 0.5f;
        float val_7 = R3;
        float val_2 = val_7 * val_6;
        val_6 = R2 * val_6;
        if()
        {
                return (float)SRMath.TweenFunctions.ElasticEaseOut(t:  val_6, b:  b, c:  val_7, d:  d);
        }
        
        val_7 = (0 + 0) - val_7;
        float val_4 = val_6 + R1;
        return (float)SRMath.TweenFunctions.ElasticEaseIn(t:  val_6, b:  b, c:  val_7, d:  d);
    }
    public static float BounceEaseOut(float t, float b, float c, float d)
    {
        var val_5;
        var val_6;
        var val_7;
        float val_1 = 0 / R3;
        if(<0)
        {
                float val_2 = 7.5625f;
            val_2 = val_1 * val_2;
            val_5 = val_1 * val_2;
            return (float)R2;
        }
        
        if(<0)
        {
                val_6 = val_1 + (-0.5454546f);
            val_7 = val_6 * 7.5625f;
            return (float)R2;
        }
        
        if(<0)
        {
                val_6 = val_1 + (-0.8181818f);
            val_7 = val_6 * 7.5625f;
            return (float)R2;
        }
        
        val_6 = val_1 + (-0.9545454f);
        val_7 = val_6 * 7.5625f;
        return (float)R2;
    }
    public static float BounceEaseIn(float t, float b, float c, float d)
    {
        uint val_2 = 0;
        val_2 = R3 - val_2;
        float val_1 = SRMath.TweenFunctions.BounceEaseOut(t:  val_2, b:  b, c:  R3, d:  d);
        var val_3 = R2;
        val_3 = val_3 - val_2;
        val_3 = val_3 + R1;
        return (float)val_3;
    }
    public static float BounceEaseInOut(float t, float b, float c, float d)
    {
        var val_5;
        float val_5 = R3;
        float val_1 = 0 + 0;
        float val_2 = val_5 * 0.5f;
        if()
        {
                val_5 = val_5 - val_1;
            float val_3 = SRMath.TweenFunctions.BounceEaseOut(t:  val_5, b:  b, c:  val_1, d:  d);
            var val_6 = val_5;
            val_6 = R2 - val_6;
            val_6 = val_6 + 0f;
            val_5 = val_6 * 0.5f;
        }
        else
        {
                val_5 = val_1 - val_5;
            float val_4 = SRMath.TweenFunctions.BounceEaseOut(t:  val_5, b:  b, c:  val_1, d:  d);
            var val_7 = val_5;
            val_7 = val_7 * 0.5f;
        }
        
        val_7 = val_7 + R1;
        return (float)val_7;
    }
    public static float BounceEaseOutIn(float t, float b, float c, float d)
    {
        var val_8;
        float val_8 = 0.5f;
        float val_1 = 0 + 0;
        float val_2 = R3 * val_8;
        if()
        {
                val_8 = R2 * val_8;
            float val_3 = SRMath.TweenFunctions.BounceEaseOut(t:  val_8, b:  b, c:  R3, d:  d);
            return (float)val_8;
        }
        
        val_1 = val_1 - R3;
        float val_4 = R2 * val_8;
        float val_5 = R3 - val_1;
        float val_6 = SRMath.TweenFunctions.BounceEaseOut(t:  val_5, b:  b, c:  R3, d:  d);
        var val_9 = val_5;
        val_9 = val_4 - val_9;
        val_8 = (val_4 + R1) + val_9;
        return (float)val_8;
    }
    public static float BackEaseOut(float t, float b, float c, float d)
    {
        var val_1 = R3;
        val_1 = 0 / val_1;
        val_1 = val_1 + (-1f);
        val_1 = val_1 * val_1;
        return (float)R2;
    }
    public static float BackEaseIn(float t, float b, float c, float d)
    {
        var val_1 = R3;
        val_1 = 0 / val_1;
        var val_2 = R2;
        val_2 = val_1 * val_2;
        val_1 = val_1 * val_2;
        return (float)val_1;
    }
    public static float BackEaseInOut(float t, float b, float c, float d)
    {
        var val_4;
        float val_5 = 0.5f;
        var val_4 = R3;
        val_4 = val_4 * val_5;
        float val_1 = 0 / val_4;
        var val_6 = R1;
        if(<0)
        {
                val_5 = R2 * val_5;
            val_4 = val_5 * ((val_1 * val_1) * (-2.594909f));
        }
        else
        {
                val_5 = R2 * val_5;
            val_1 = val_1 + (-2f);
            val_1 = val_1 * val_1;
            val_4 = val_5 * 2f;
        }
        
        val_6 = val_4 + val_6;
        return (float)val_6;
    }
    public static float BackEaseOutIn(float t, float b, float c, float d)
    {
        var val_4;
        var val_5;
        float val_4 = 0.5f;
        var val_3 = R3;
        var val_5 = R2;
        float val_1 = 0 + 0;
        val_4 = R1;
        float val_2 = val_3 * val_4;
        if()
        {
                val_3 = val_1 / val_3;
            val_4 = val_5 * val_4;
            val_3 = val_3 + (-1f);
            val_3 = val_3 * val_3;
            val_5 = val_4 * 1f;
        }
        else
        {
                val_1 = val_1 - val_3;
            val_4 = val_5 * val_4;
            val_3 = val_1 / val_3;
            val_5 = val_4 * val_3;
            val_5 = val_4 + val_4;
            val_5 = val_3 * val_5;
            val_4 = val_5 * (-1.70158f);
        }
        
        val_4 = val_5 + val_4;
        return (float)val_4;
    }

}
