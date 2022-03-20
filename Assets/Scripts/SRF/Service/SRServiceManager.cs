using UnityEngine;

namespace SRF.Service
{
    public class SRServiceManager : SRAutoSingleton<SRF.Service.SRServiceManager>
    {
        // Fields
        public const bool EnableLogging = False;
        public static int LoadingCount;
        private readonly SRF.SRList<SRF.Service.SRServiceManager.Service> _services;
        private System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> _serviceStubs;
        private static bool _hasQuit;
        
        // Properties
        public static bool IsLoading { get; }
        
        // Methods
        public static bool get_IsLoading()
        {
            null = null;
            if(SRF.Service.SRServiceManager.LoadingCount > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static T GetService<T>()
        {
            var val_5;
            var val_6;
            var val_7;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            object val_2 = SRF.Service.SRServiceManager.GetServiceInternal(t:  __RuntimeMethodHiddenParam + 24);
            if((__RuntimeMethodHiddenParam + 24) != 0)
            {
                    val_5 = __RuntimeMethodHiddenParam + 24;
                if((__RuntimeMethodHiddenParam + 24) != 0)
            {
                    return;
            }
            
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = 0;
            if(SRF.Service.SRServiceManager._hasQuit == true)
            {
                    return;
            }
            
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            typeof(System.Object[]).__il2cppRuntimeField_10 = __RuntimeMethodHiddenParam + 24;
            val_7 = null;
            val_7 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            val_5 = 0;
            string val_4 = SRF.SRFStringExtensions.Fmt(formatString:  403252720, args:  472754880);
            UnityEngine.Debug.LogWarning(message:  403252720);
        }
        public static object GetService(System.Type t)
        {
            System.Type val_3;
            var val_4;
            var val_5;
            val_3 = t;
            object val_1 = SRF.Service.SRServiceManager.GetServiceInternal(t:  val_3);
            if(val_3 != 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if(SRF.Service.SRServiceManager._hasQuit == true)
            {
                    return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
            val_5 = null;
            val_5 = null;
            val_3 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = val_3;
            string val_2 = System.String.Format(format:  403252720, args:  472754880);
            UnityEngine.Debug.LogWarning(message:  403252720);
        }
        private static object GetServiceInternal(System.Type t)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            val_6 = 0;
            if(SRF.Service.SRServiceManager._hasQuit == true)
            {
                    return;
            }
            
            val_6 = 0;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            object val_2 = SRF.Components.SRAutoSingleton<System.Object>.Instance;
            val_7 = 0;
            do
            {
                object val_3 = public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24.Item[0];
                val_7 = val_7 + 1;
            }
            while(t == 0);
            
            val_6 = mem[public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24 + 8];
            val_6 = public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24 + 8;
            if(val_6 != 0)
            {
                    return;
            }
            
            SRF.Service.SRServiceManager.UnRegisterService(t:  t);
            object val_4 = SRF.Components.SRAutoSingleton<System.Object>.Instance;
            if((public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance()) != 0)
            {
                    return AutoCreateService(t:  t);
            }
            
            return AutoCreateService(t:  t);
        }
        public static bool HasService<T>()
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            return SRF.Service.SRServiceManager.HasService(t:  __RuntimeMethodHiddenParam + 24);
        }
        public static bool HasService(System.Type t)
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            val_5 = 0;
            if(SRF.Service.SRServiceManager._hasQuit == true)
            {
                    return (bool);
            }
            
            val_5 = 0;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (bool);
            }
            
            object val_2 = SRF.Components.SRAutoSingleton<System.Object>.Instance;
            val_6 = 0;
            do
            {
                object val_3 = public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24.Item[0];
                val_6 = val_6 + 1;
            }
            while(t == 0);
            
            if((public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24 + 8) != 0)
            {
                    val_5 = 1;
            }
            
            return (bool);
        }
        public static void RegisterService<T>(object service)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            SRF.Service.SRServiceManager.RegisterService(t:  __RuntimeMethodHiddenParam + 24, service:  service);
        }
        private static void RegisterService(System.Type t, object service)
        {
            System.Type val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_12 = t;
            val_13 = service;
            val_14 = null;
            val_14 = null;
            if(SRF.Service.SRServiceManager._hasQuit != false)
            {
                    return;
            }
            
            val_15 = null;
            if((SRF.Service.SRServiceManager.HasService(t:  val_12)) == false)
            {
                goto label_6;
            }
            
            object val_2 = SRF.Service.SRServiceManager.GetServiceInternal(t:  val_12);
            if(val_12 == val_13)
            {
                    return;
            }
            
            string val_3 = 403967872 + R4;
            val_12 = "Service already registered for type ";
            System.Exception val_4 = null;
            val_16 = 0;
            val_13 = val_4;
            val_4 = new System.Exception(message:  403967872);
            label_17:
            val_15 = val_13;
            label_6:
            SRF.Service.SRServiceManager.UnRegisterService(t:  403967872);
            if(val_12 != 0)
            {
                    object val_5 = SRF.Components.SRAutoSingleton<System.Object>.Instance;
                if(new System.Object() != 0)
            {
                    typeof(SRServiceManager.Service).__il2cppRuntimeField_8 = val_13;
            }
            else
            {
                    mem[8] = val_13;
            }
            
                typeof(SRServiceManager.Service).__il2cppRuntimeField_C = val_12;
                public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24.Add(item:  414109696);
                return;
            }
            
            System.Type val_7 = GetType();
            string val_8 = SRF.SRFStringExtensions.Fmt(formatString:  403970064, args:  472754880);
            System.ArgumentException val_9 = new System.ArgumentException(message:  403970064);
            goto label_17;
        }
        public static void UnRegisterService<T>()
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            SRF.Service.SRServiceManager.UnRegisterService(t:  __RuntimeMethodHiddenParam + 24);
        }
        private static void UnRegisterService(System.Type t)
        {
            var val_8 = null;
            if(SRF.Service.SRServiceManager._hasQuit == true)
            {
                    return;
            }
            
            if((SRF.Components.SRAutoSingleton<System.Object>.HasInstance) == false)
            {
                    return;
            }
            
            if((SRF.Service.SRServiceManager.HasService(t:  t)) == false)
            {
                    return;
            }
            
            object val_3 = SRF.Components.SRAutoSingleton<System.Object>.Instance;
            object val_4 = public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24.Item[(public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24 + 12 - 1)];
            if((System.Type.op_Equality(left:  public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24 + 12, right:  t)) == false)
            {
                    return;
            }
            
            public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24.RemoveAt(index:  (public static SRF.Service.SRServiceManager SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>::get_Instance().__il2cppRuntimeField_24 + 12 - 1));
        }
        protected override void Awake()
        {
            null = null;
            SRF.Service.SRServiceManager._hasQuit = false;
            this.Awake();
            UnityEngine.GameObject val_1 = this.CachedGameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  404349680);
            UnityEngine.GameObject val_2 = this.CachedGameObject;
            this.hideFlags = 8;
        }
        protected void UpdateStubs()
        {
            System.Type val_6;
            if(this._serviceStubs != 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._serviceStubs = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(414056448)});
            AddRange(collection:  414056448);
            List.Enumerator<T> val_4 = GetEnumerator();
            label_9:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            this.ScanType(type:  val_6);
            goto label_9;
            label_8:
            Dispose();
        }
        protected object AutoCreateService(System.Type t)
        {
            var val_3;
            System.Collections.Generic.List<ServiceStub> val_10;
            var val_11;
            System.Type val_12;
            object val_13;
            System.Type val_14;
            this.UpdateStubs();
            val_10 = this._serviceStubs;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_11 = val_3;
            val_10 = mem[val_3 + 12];
            val_10 = val_3 + 12;
            if((System.Type.op_Inequality(left:  val_10, right:  t)) == true)
            {
                goto label_6;
            }
            
            val_12 = mem[val_3 + 8];
            val_12 = val_3 + 8;
            if(val_12 == 0)
            {
                goto label_7;
            }
            
            System.Security.Cryptography.HashAlgorithm val_5 = val_12.Invoke();
            goto label_8;
            label_2:
            val_13 = 0;
            goto label_18;
            label_7:
            val_14 = mem[val_3 + 20];
            val_14 = val_3 + 20;
            if((System.Type.op_Equality(left:  val_14, right:  0)) != false)
            {
                    System.Security.Cryptography.HashAlgorithm val_7 = val_3 + 16.Invoke();
                val_14 = val_3 + 16;
            }
            
            val_12 = t;
            object val_8 = SRF.Service.SRServiceManager.DefaultServiceConstructor(serviceIntType:  val_12, implType:  val_14);
            label_8:
            val_13 = val_12;
            if((SRF.Service.SRServiceManager.HasService(t:  t)) != true)
            {
                    SRF.Service.SRServiceManager.RegisterService(t:  t, service:  val_13);
            }
            
            label_18:
            Dispose();
        }
        protected void OnApplicationQuit()
        {
            null = null;
            SRF.Service.SRServiceManager._hasQuit = true;
        }
        private static object DefaultServiceConstructor(System.Type serviceIntType, System.Type implType)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(157880320)});
            if(null != 0)
            {
                    string val_2 = 404812592 + serviceIntType;
                UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  404812592);
                UnityEngine.Component val_4 = AddComponent(componentType:  implType);
                return;
            }
            
            System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(158146560)});
            if(null == 0)
            {
                    return System.Activator.CreateInstance(type:  implType);
            }
            
            UnityEngine.ScriptableObject val_6 = UnityEngine.ScriptableObject.CreateInstance(type:  implType);
        }
        private void ScanType(System.Type type)
        {
            object val_1 = SRF.Helpers.SRReflection.GetAttribute<System.Object>(t:  type);
            if(type != 0)
            {
                    object val_2 = new System.Object();
                typeof(SRServiceManager.ServiceStub).__il2cppRuntimeField_14 = type;
                typeof(SRServiceManager.ServiceStub).__il2cppRuntimeField_C = type._impl;
                this._serviceStubs.Add(item:  414162944);
            }
            
            SRF.Service.SRServiceManager.ScanTypeForConstructors(t:  type, stubs:  this._serviceStubs);
            SRF.Service.SRServiceManager.ScanTypeForSelectors(t:  type, stubs:  this._serviceStubs);
        }
        private static void ScanTypeForSelectors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            System.Type val_11 = t;
            val_11 = val_11 + 16;
            val_11 = 0;
            label_35:
            if(val_11 >= val_11)
            {
                    return;
            }
            
            object val_1 = new System.Object();
            object val_2 = SRF.Helpers.SRReflection.GetAttribute<System.Object>(t:  (t + 16) + 0);
            val_12 = (t + 16) + 0;
            if(val_1 != 0)
            {
                    val_13 = val_1;
                typeof(SRServiceManager.<>c__DisplayClass24_0).__il2cppRuntimeField_8 = val_12;
            }
            else
            {
                    val_13 = 8;
                mem[8] = val_12;
                val_12 = mem[8];
            }
            
            if(val_12 == 0)
            {
                goto label_45;
            }
            
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16506880)});
            if((System.Type.op_Inequality(left:  (t + 16) + 0, right:  16506880)) == false)
            {
                goto label_13;
            }
            
            val_14 = null;
            val_11 = val_11;
            typeof(System.Object[]).__il2cppRuntimeField_10 = t;
            typeof(System.Object[]).__il2cppRuntimeField_14 = (t + 16) + 0;
            val_15 = "ServiceSelector must have return type of Type ({0}.{1}())";
            goto label_22;
            label_13:
            if(((t + 16) + 0 + 12) == 0)
            {
                goto label_24;
            }
            
            val_11 = val_11;
            val_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = t;
            typeof(System.Object[]).__il2cppRuntimeField_14 = (t + 16) + 0;
            val_15 = "ServiceSelector must have no parameters ({0}.{1}())";
            label_22:
            string val_5 = System.String.Format(format:  405089088, args:  472754880);
            UnityEngine.Debug.LogError(message:  405089088);
            label_45:
            val_11 = val_11 + 1;
            goto label_35;
            label_24:
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_6 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  414269440, method:  new IntPtr(405089264));
            object val_7 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  stubs, predicate:  7720960);
            val_16 = stubs;
            if(stubs == 0)
            {
                    object val_8 = null;
                val_16 = val_8;
                val_8 = new System.Object();
                typeof(SRServiceManager.ServiceStub).__il2cppRuntimeField_C = (t + 16) + 0 + 8;
                stubs.Add(item:  414162944);
            }
            
            val_17 = null;
            System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(7667712)});
            System.Delegate val_10 = System.Delegate.CreateDelegate(type:  7667712, method:  (t + 16) + 0);
            if(val_17 != 0)
            {
                    if(null == null)
            {
                goto label_44;
            }
            
            }
            
            val_17 = 0;
            label_44:
            typeof(SRServiceManager.ServiceStub).__il2cppRuntimeField_10 = val_17;
            goto label_45;
        }
        private static void ScanTypeForConstructors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs)
        {
            System.Type val_9;
            var val_10;
            var val_11;
            System.Type val_12;
            var val_13;
            var val_14;
            System.Type val_15;
            var val_16;
            val_9 = t;
            val_9 = val_9;
            val_9 = val_9;
            if(val_9 == 0)
            {
                    val_9 = val_9;
            }
            
            System.Type val_9 = val_9;
            val_9 = val_9 + 16;
            var val_10 = 0;
            label_42:
            if(val_10 >= (t + 12))
            {
                    return;
            }
            
            object val_1 = new System.Object();
            object val_2 = SRF.Helpers.SRReflection.GetAttribute<System.Object>(t:  (t + 16) + 0);
            val_10 = (t + 16) + 0;
            if(val_1 != 0)
            {
                    val_11 = val_1;
                typeof(SRServiceManager.<>c__DisplayClass25_0).__il2cppRuntimeField_8 = val_10;
            }
            else
            {
                    val_11 = 8;
                mem[8] = val_10;
                val_10 = mem[8];
            }
            
            if(val_10 == 0)
            {
                goto label_49;
            }
            
            if((System.Type.op_Inequality(left:  (t + 16) + 0, right:  (t + 16) + 0 + 8)) == false)
            {
                goto label_15;
            }
            
            val_12 = val_9;
            if(val_12 == 0)
            {
                    val_12 = val_9;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_12;
            typeof(System.Object[]).__il2cppRuntimeField_14 = (t + 16) + 0;
            typeof(System.Object[]).__il2cppRuntimeField_18 = (t + 16) + 0 + 8;
            val_13 = null;
            val_14 = "ServiceConstructor must have return type of {2} ({0}.{1}())";
            goto label_29;
            label_15:
            if(((t + 16) + 0 + 12) == 0)
            {
                goto label_31;
            }
            
            val_15 = val_9;
            if(val_15 == 0)
            {
                    val_15 = val_9;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_15;
            typeof(System.Object[]).__il2cppRuntimeField_14 = (t + 16) + 0;
            val_13 = null;
            val_14 = "ServiceConstructor must have no parameters ({0}.{1}())";
            label_29:
            string val_4 = System.String.Format(format:  405221936, args:  472754880);
            UnityEngine.Debug.LogError(message:  405221936);
            label_49:
            val_10 = val_10 + 1;
            goto label_42;
            label_31:
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_5 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  414322688, method:  new IntPtr(405222112));
            object val_6 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  stubs, predicate:  7720960);
            val_16 = stubs;
            if(stubs == 0)
            {
                    object val_7 = null;
                val_16 = val_7;
                val_7 = new System.Object();
                typeof(SRServiceManager.ServiceStub).__il2cppRuntimeField_C = (t + 16) + 0 + 8;
                stubs.Add(item:  414162944);
            }
            
            typeof(SRServiceManager.<>c__DisplayClass25_0).__il2cppRuntimeField_C = (t + 16) + 0;
            System.Func<TRVQuizProgress> val_8 = new System.Func<TRVQuizProgress>(object:  414322688, method:  new IntPtr(405223136));
            typeof(SRServiceManager.ServiceStub).__il2cppRuntimeField_8 = null;
            goto label_49;
        }
        private static System.Reflection.MethodInfo[] GetStaticMethods(System.Type t)
        {
            if(t == 0)
            {
                
            }
        
        }
        public SRServiceManager()
        {
            SRF.SRList<System.Object> val_1 = new SRF.SRList<System.Object>();
            this._services = null;
        }
        private static SRServiceManager()
        {
        
        }
    
    }

}
