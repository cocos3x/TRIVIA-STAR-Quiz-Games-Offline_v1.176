using UnityEngine;

namespace DG.Tweening
{
    public static class ShortcutExtensionsTextMeshPro
    {
        // Methods
        public static DG.Tweening.Tweener DOColor(TMPro.TextMeshPro target, UnityEngine.Color endValue, float duration)
        {
            object val_2 = new System.Object();
            typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass0_0).__il2cppRuntimeField_8 = target;
            DG.Tweening.Core.DOGetter<UnityEngine.Color> val_3 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  272629760, method:  new IntPtr(2101682016));
            DG.Tweening.Core.DOSetter<UnityEngine.Color> val_4 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  272629760, method:  new IntPtr(2101683040));
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<System.Object>(t:  198828032, target:  typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass0_0).__il2cppRuntimeField_8);
        }
        public static DG.Tweening.Tweener DOFaceColor(TMPro.TextMeshPro target, UnityEngine.Color32 endValue, float duration)
        {
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            object val_1 = new System.Object();
            typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass1_0).__il2cppRuntimeField_8 = target;
            DG.Tweening.Core.DOGetter<UnityEngine.Color> val_2 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  272683008, method:  new IntPtr(2101804256));
            DG.Tweening.Core.DOSetter<UnityEngine.Color> val_3 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  272683008, method:  new IntPtr(2101805280));
            UnityEngine.Color val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 144, g = 51, b = 71, a = 125});
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_9 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  new UnityEngine.Color() {r = val_6, g = val_7, b = val_8, a = val_5}, duration:  val_4.r);
            object val_10 = DG.Tweening.TweenSettingsExtensions.SetTarget<System.Object>(t:  198828032, target:  typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass1_0).__il2cppRuntimeField_8);
        }
        public static DG.Tweening.Tweener DOOutlineColor(TMPro.TextMeshPro target, UnityEngine.Color32 endValue, float duration)
        {
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            object val_1 = new System.Object();
            typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass2_0).__il2cppRuntimeField_8 = target;
            DG.Tweening.Core.DOGetter<UnityEngine.Color> val_2 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  272736256, method:  new IntPtr(2101926496));
            DG.Tweening.Core.DOSetter<UnityEngine.Color> val_3 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  272736256, method:  new IntPtr(2101927520));
            UnityEngine.Color val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 16, g = 17, b = 73, a = 125});
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_9 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  new UnityEngine.Color() {r = val_6, g = val_7, b = val_8, a = val_5}, duration:  val_4.r);
            object val_10 = DG.Tweening.TweenSettingsExtensions.SetTarget<System.Object>(t:  198828032, target:  typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass2_0).__il2cppRuntimeField_8);
        }
        public static DG.Tweening.Tweener DOGlowColor(TMPro.TextMeshPro target, UnityEngine.Color endValue, float duration, bool useSharedMaterial = False)
        {
            var val_1;
            UnityEngine.Material val_5;
            if(val_1 != 0)
            {
                    val_5 = target;
                UnityEngine.Material val_2 = val_5.fontSharedMaterial;
            }
            else
            {
                    val_5 = target;
                UnityEngine.Material val_3 = val_5.fontMaterial;
            }
            
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOColor(target:  val_5, endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, property:  "_GlowColor", duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<System.Object>(t:  val_5, target:  target);
        }
        public static DG.Tweening.Tweener DOFade(TMPro.TextMeshPro target, float endValue, float duration)
        {
            object val_1 = new System.Object();
            typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass4_0).__il2cppRuntimeField_8 = target;
            DG.Tweening.Core.DOGetter<UnityEngine.Color> val_2 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  272789504, method:  new IntPtr(2102169024));
            DG.Tweening.Core.DOSetter<UnityEngine.Color> val_3 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  272789504, method:  new IntPtr(2102170048));
            DG.Tweening.Tweener val_4 = DG.Tweening.DOTween.ToAlpha(getter:  198828032, setter:  198881280, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<System.Object>(t:  198828032, target:  typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass4_0).__il2cppRuntimeField_8);
        }
        public static DG.Tweening.Tweener DOFaceFade(TMPro.TextMeshPro target, float endValue, float duration)
        {
            object val_1 = new System.Object();
            typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass5_0).__il2cppRuntimeField_8 = target;
            DG.Tweening.Core.DOGetter<UnityEngine.Color> val_2 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  272842752, method:  new IntPtr(2102291264));
            DG.Tweening.Core.DOSetter<UnityEngine.Color> val_3 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  272842752, method:  new IntPtr(2102292288));
            DG.Tweening.Tweener val_4 = DG.Tweening.DOTween.ToAlpha(getter:  198828032, setter:  198881280, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<System.Object>(t:  198828032, target:  typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass5_0).__il2cppRuntimeField_8);
        }
        public static DG.Tweening.Tweener DOScale(TMPro.TextMeshPro target, float endValue, float duration)
        {
            object val_1 = new System.Object();
            UnityEngine.Transform val_2 = target.transform;
            typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = target;
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  endValue, y:  duration, z:  null);
            DG.Tweening.Core.DOGetter<UnityEngine.Vector3> val_4 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  272896000, method:  new IntPtr(2102413504));
            DG.Tweening.Core.DOSetter<UnityEngine.Vector3> val_5 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  272896000, method:  new IntPtr(2102414528));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  endValue);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<System.Object>(t:  198828032, target:  target);
        }
        public static DG.Tweening.Tweener DOFontSize(TMPro.TextMeshPro target, float endValue, float duration)
        {
            object val_1 = new System.Object();
            typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass7_0).__il2cppRuntimeField_8 = target;
            DG.Tweening.Core.DOGetter<System.Single> val_2 = new DG.Tweening.Core.DOGetter<System.Single>(object:  272949248, method:  new IntPtr(2102535744));
            DG.Tweening.Core.DOSetter<System.Single> val_3 = new DG.Tweening.Core.DOSetter<System.Single>(object:  272949248, method:  new IntPtr(2102536768));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<System.Object>(t:  198828032, target:  typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass7_0).__il2cppRuntimeField_8);
        }
        public static DG.Tweening.Tweener DOMaxVisibleCharacters(TMPro.TextMeshPro target, int endValue, float duration)
        {
            object val_1 = new System.Object();
            typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = target;
            DG.Tweening.Core.DOGetter<System.Int32> val_2 = new DG.Tweening.Core.DOGetter<System.Int32>(object:  273002496, method:  new IntPtr(2102657984));
            DG.Tweening.Core.DOSetter<System.Int32> val_3 = new DG.Tweening.Core.DOSetter<System.Int32>(object:  273002496, method:  new IntPtr(2102660032));
            DG.Tweening.Tweener val_4 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<System.Object>(t:  198828032, target:  typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass8_0).__il2cppRuntimeField_8);
        }
        public static DG.Tweening.Tweener DOText(TMPro.TextMeshPro target, string endValue, float duration, bool richTextEnabled = True, DG.Tweening.ScrambleMode scrambleMode = 0, string scrambleChars)
        {
            string val_1;
            object val_2 = new System.Object();
            typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass9_0).__il2cppRuntimeField_8 = target;
            DG.Tweening.Core.DOGetter<System.String> val_3 = new DG.Tweening.Core.DOGetter<System.String>(object:  273055744, method:  new IntPtr(2102794560));
            DG.Tweening.Core.DOSetter<System.String> val_4 = new DG.Tweening.Core.DOSetter<System.String>(object:  273055744, method:  new IntPtr(2102795584));
            DG.Tweening.Core.TweenerCore<System.String, System.String, DG.Tweening.Plugins.Options.StringOptions> val_5 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  endValue, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  198828032, richTextEnabled:  scrambleMode, scrambleMode:  scrambleChars, scrambleChars:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<System.Object>(t:  198828032, target:  typeof(ShortcutExtensionsTextMeshPro.<>c__DisplayClass9_0).__il2cppRuntimeField_8);
        }
    
    }

}
