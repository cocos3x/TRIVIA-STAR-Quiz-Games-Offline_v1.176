using UnityEngine;

namespace SRDebugger.Services
{
    public class ConsoleEntry
    {
        // Fields
        private const int MessagePreviewLength = 180;
        private const int StackTracePreviewLength = 120;
        private string _messagePreview;
        private string _stackTracePreview;
        public int Count;
        public UnityEngine.LogType LogType;
        public string Message;
        public string StackTrace;
        
        // Properties
        public string MessagePreview { get; }
        public string StackTracePreview { get; }
        
        // Methods
        public ConsoleEntry()
        {
            this.Count = 1;
        }
        public ConsoleEntry(SRDebugger.Services.ConsoleEntry other)
        {
            this.Count = 1;
            if(other != 0)
            {
                    this.Message = other.Message;
                this.StackTrace = other.StackTrace;
                this.LogType = other.LogType;
            }
            else
            {
                    this.Message = 0;
                this.StackTrace = 52;
                this.LogType = 1;
            }
            
            this.Count = other.Count;
        }
        public string get_MessagePreview()
        {
            if(this._messagePreview != null)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.Message)) != false)
            {
                    return;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
            System.String[] val_2 = this.Message.Split(separator:  478563824);
            this._messagePreview = this.Message;
            string val_4 = this.Message.Substring(startIndex:  0, length:  UnityEngine.Mathf.Min(a:  this.Message.m_stringLength, b:  180));
            this._messagePreview = this.Message;
        }
        public string get_StackTracePreview()
        {
            if(this._stackTracePreview != null)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.StackTrace)) != false)
            {
                    return;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
            System.String[] val_2 = this.StackTrace.Split(separator:  478563824);
            this._stackTracePreview = this.StackTrace;
            string val_4 = this.StackTrace.Substring(startIndex:  0, length:  UnityEngine.Mathf.Min(a:  this.StackTrace.m_stringLength, b:  120));
            this._stackTracePreview = this.StackTrace;
        }
        public bool Matches(SRDebugger.Services.ConsoleEntry other)
        {
            var val_4;
            if(other == 0)
            {
                goto label_0;
            }
            
            if(this == other)
            {
                goto label_1;
            }
            
            val_4 = 0;
            if((System.String.Equals(a:  this.Message, b:  other.Message)) == false)
            {
                    return (bool)val_4;
            }
            
            val_4 = 0;
            if((System.String.Equals(a:  this.StackTrace, b:  other.StackTrace)) == false)
            {
                    return (bool)val_4;
            }
            
            UnityEngine.LogType val_3 = other.LogType;
            val_3 = this.LogType - val_3;
            val_4 = val_3 >> 5;
            return (bool)val_4;
            label_0:
            val_4 = 0;
            return (bool)val_4;
            label_1:
            val_4 = 1;
            return (bool)val_4;
        }
    
    }

}
