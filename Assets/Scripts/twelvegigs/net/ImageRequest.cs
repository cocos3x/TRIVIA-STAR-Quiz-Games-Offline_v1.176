using UnityEngine;

namespace twelvegigs.net
{
    public class ImageRequest : JsonRequest
    {
        // Fields
        private string pathToLocalImage;
        private static string storagePath;
        private string _url;
        private string _path;
        private string _filename;
        private bool _showErrors;
        public UnityEngine.Texture2D imageTexture;
        public bool error;
        private byte[] lnBuffer;
        private byte[] lnFile;
        private System.Action<string, UnityEngine.Texture2D> _imgOnComplete;
        private System.Action onImageError;
        private bool _cached;
        private bool _save;
        private System.Collections.Generic.List<string> ValidImageContentTypes;
        
        // Properties
        public string PathToDownloadedImage { get; }
        
        // Methods
        public string get_PathToDownloadedImage()
        {
        
        }
        private static string StoragePath()
        {
            return UnityEngine.Application.persistentDataPath;
        }
        public static bool ImageInLocal(string imgPath)
        {
            string val_1 = UnityEngine.Application.persistentDataPath;
            string val_2 = null + 1152433872 + imgPath;
            return System.IO.File.Exists(path:  null);
        }
        public static UnityEngine.Texture2D LoadLocally(string remoteURL, string fileName)
        {
            UnityEngine.Texture2D val_1 = new UnityEngine.Texture2D(width:  256, height:  256);
            string val_2 = UnityEngine.Application.persistentDataPath;
            string val_3 = null + 1152433872 + fileName;
            System.Byte[] val_4 = System.IO.File.ReadAllBytes(path:  null);
            bool val_5 = UnityEngine.ImageConversion.LoadImage(tex:  154206208, data:  null);
        }
        public static bool LoadFromPreCache(string filename, out UnityEngine.Texture2D textureToSet)
        {
            string val_9 = filename;
            textureToSet = 0;
            string val_1 = val_9.Replace(oldValue:  1975550080, newValue:  1098586544);
            string val_2 = 1152686560 + val_9;
            object val_3 = UnityEngine.Resources.Load<System.Object>(path:  1152686560);
            textureToSet = "data/umbrella/precached/";
            CompanyDevices val_4 = CompanyDevices.Instance;
            if(0.CompanyDevice() == false)
            {
                    return UnityEngine.Object.op_Inequality(x:  1152686560, y:  0);
            }
            
            if(1152686560 != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  1152686560, y:  0);
            }
            
            string val_7 = val_9.Replace(oldValue:  1975550080, newValue:  1098586544);
            string val_8 = 1152686560 + val_9;
            typeof(System.Object[]).__il2cppRuntimeField_10 = "data/umbrella/precached/";
            val_9 = "not found!";
            typeof(System.Object[]).__il2cppRuntimeField_14 = val_9;
            UnityEngine.Debug.LogErrorFormat(format:  1152686784, args:  472754880);
            return UnityEngine.Object.op_Inequality(x:  1152686560, y:  0);
        }
        public ImageRequest(string url, string filename, System.Action<string, UnityEngine.Texture2D> imgComplete, System.Action imgError, bool showErrors = True, bool destroy = False, bool cached = True, bool save = True)
        {
            this._showErrors = true;
            this.pathToLocalImage = "";
            this._cached = true;
            this._save = true;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(null != 0)
            {
                    Add(item:  1152823408);
            }
            else
            {
                    Add(item:  1152823408);
            }
            
            Add(item:  1152823504);
            Add(item:  1119379600);
            this.ValidImageContentTypes = null;
            string val_2 = UnityEngine.Application.persistentDataPath;
            string val_3 = null + 1152433872 + filename;
            this.pathToLocalImage = 0;
            string val_4 = UnityEngine.Application.persistentDataPath;
            string val_5 = null + 1152433872;
            this._url = url;
            this._path = 0;
            this._filename = filename;
            this._imgOnComplete = imgComplete;
            this.onImageError = imgError;
            this._showErrors = showErrors;
            mem[1152921514349630284] = destroy;
            this._cached = cached;
            this._save = save;
            System.Action val_6 = new System.Action(object:  1152848624, method:  new IntPtr(1152823600));
            mem[1152921514349630276] = null;
            this.loadFromServer();
        }
        private void loadFromServer()
        {
            string val_4;
            var val_5;
            val_4 = 13497352 + 22128706;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            if(App.networkManager.Reachable() == false)
            {
                goto label_7;
            }
            
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject();
            val_4 = this._url;
            if(val_2 == 0)
            {
                goto label_8;
            }
            
            name = val_4;
            goto label_9;
            label_7:
            this.error = true;
            if(this.onImageError == 0)
            {
                    return;
            }
            
            this.onImageError.Invoke();
            return;
            label_8:
            0.name = val_4;
            label_9:
            object val_3 = AddComponent<System.Object>();
            typeof(UnityEngine.GameObject).__il2cppRuntimeField_C = this;
            mem[1152921514349766864] = val_2;
        }
        public override void execute()
        {
            R4.Invoke();
        }
        protected void wwwExecute()
        {
            System.Collections.IEnumerator val_1 = this.downloadRemote(url:  this._url);
            UnityEngine.Coroutine val_2 = R4.StartCoroutine(routine:  1153221488);
        }
        private System.Collections.IEnumerator downloadRemote(string url)
        {
            typeof(ImageRequest.<downloadRemote>d__25).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(ImageRequest.<downloadRemote>d__25).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            typeof(ImageRequest.<downloadRemote>d__25).__il2cppRuntimeField_10 = url;
        }
        public override void Cleanup()
        {
            this.Cleanup();
            this._imgOnComplete = 0;
        }
        public override void fireCallback()
        {
            var val_3;
            if(this._cached == false)
            {
                    this._cached = 0;
                this.imageTexture = this._cached;
            }
            
            if(this.error != false)
            {
                    mem[1152921514350400512] = 1;
                this.fireOnComplete();
                if(this.onImageError == 0)
            {
                    return;
            }
            
                this.onImageError.Invoke();
                return;
            }
            
            if(this._save != false)
            {
                    val_3 = mem[null + 264];
                if((new System.IO.DirectoryInfo(path:  this._path)) == 0)
            {
                    val_3 = 0;
                Create();
            }
            
                string val_2 = this._path + null;
                System.IO.File.WriteAllBytes(path:  this._path, bytes:  this.lnFile);
            }
            
            this.fireOnComplete();
        }
        private void fireOnComplete()
        {
            if(this._imgOnComplete != 0)
            {
                    this._imgOnComplete.Invoke(arg1:  this._filename, arg2:  this.imageTexture);
            }
            
            this._imgOnComplete = 0;
        }
        private static ImageRequest()
        {
        
        }
    
    }

}
