﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EAWSTestApp.EAWSService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.aircominternational.com/contract/EAWS/Service/2011/04", ConfigurationName="EAWSService.EAWS", CallbackContract=typeof(EAWSTestApp.EAWSService.EAWSCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface EAWS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.aircominternational.com/contract/EAWS/Service/2011/04/EAWS/SyncStartAW" +
            "Scheduler", ReplyAction="http://www.aircominternational.com/contract/EAWS/Service/2011/04/EAWS/SyncStartAW" +
            "SchedulerResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SyncStartAWScheduler();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.aircominternational.com/contract/EAWS/Service/2011/04/EAWS/SyncIsAWSch" +
            "edulerStarted", ReplyAction="http://www.aircominternational.com/contract/EAWS/Service/2011/04/EAWS/SyncIsAWSch" +
            "edulerStartedResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SyncIsAWSchedulerStarted();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.aircominternational.com/contract/EAWS/Service/2011/04/EAWS/ControlRequ" +
            "est")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EWSResponseBaseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EWSRequestBaseType))]
        void ControlRequest(EAWSTestApp.EAWSService.JobRequestType rJobRequestType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.aircominternational.com/contract/EAWS/Service/2011/04/EAWS/QueryReques" +
            "t")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EWSResponseBaseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EWSRequestBaseType))]
        void QueryRequest(EAWSTestApp.EAWSService.JobRequestType rJobRequestType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.aircominternational.com/contract/EAWS/Service/2011/04/EAWS/EditRequest" +
            "")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EWSResponseBaseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EWSRequestBaseType))]
        void EditRequest(EAWSTestApp.EAWSService.JobRequestType rJobRequestType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EAWSCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.aircominternational.com/contract/EAWS/Service/2011/04/EAWS/SendUpdate")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EWSResponseBaseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EWSRequestBaseType))]
        void SendUpdate(EAWSTestApp.EAWSService.JobResponseType resp);
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaskRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeleteTaskRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaskStatusRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EditTaskRegionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StopTaskRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EditTaskFiltersRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StartTaskRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllSchemaTaskNamesRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllSchemaNamesRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class JobRequestType : EWSRequestBaseType {
        
        private string schemaNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SchemaName {
            get {
                return this.schemaNameField;
            }
            set {
                this.schemaNameField = value;
                this.RaisePropertyChanged("SchemaName");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobRequestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaskRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeleteTaskRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaskStatusRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EditTaskRegionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StopTaskRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EditTaskFiltersRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StartTaskRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllSchemaTaskNamesRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllSchemaNamesRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/contract/EWS/2011/01")]
    public abstract partial class EWSRequestBaseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Guid itemIDField;
        
        private System.Guid masterIDField;
        
        private bool masterIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.aircominternational.com/contract/Util/2009/10", Order=0)]
        public System.Guid itemID {
            get {
                return this.itemIDField;
            }
            set {
                this.itemIDField = value;
                this.RaisePropertyChanged("itemID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.Guid masterID {
            get {
                return this.masterIDField;
            }
            set {
                this.masterIDField = value;
                this.RaisePropertyChanged("masterID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool masterIDSpecified {
            get {
                return this.masterIDFieldSpecified;
            }
            set {
                this.masterIDFieldSpecified = value;
                this.RaisePropertyChanged("masterIDSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/contract/Util/2009/10")]
    public partial class StatusType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private StatusType[] statusField;
        
        private string commentField;
        
        private StatusTypeCode codeField;
        
        private System.Guid refField;
        
        private System.Guid masterIDRefField;
        
        private bool masterIDRefFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status", Order=0)]
        public StatusType[] Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
                this.RaisePropertyChanged("comment");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StatusTypeCode code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Guid @ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
                this.RaisePropertyChanged("ref");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public System.Guid masterIDRef {
            get {
                return this.masterIDRefField;
            }
            set {
                this.masterIDRefField = value;
                this.RaisePropertyChanged("masterIDRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool masterIDRefSpecified {
            get {
                return this.masterIDRefFieldSpecified;
            }
            set {
                this.masterIDRefFieldSpecified = value;
                this.RaisePropertyChanged("masterIDRefSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.aircominternational.com/contract/Util/2009/10")]
    public enum StatusTypeCode {
        
        /// <remarks/>
        ActionNotAuthorized,
        
        /// <remarks/>
        AllReturned,
        
        /// <remarks/>
        DataTooLong,
        
        /// <remarks/>
        DoesNotExist,
        
        /// <remarks/>
        EmptyRequest,
        
        /// <remarks/>
        ExistsAlready,
        
        /// <remarks/>
        ExtensionNotSupported,
        
        /// <remarks/>
        Failed,
        
        /// <remarks/>
        FormatNotSupported,
        
        /// <remarks/>
        InvalidData,
        
        /// <remarks/>
        InvalidExpires,
        
        /// <remarks/>
        InvalidItemIDRef,
        
        /// <remarks/>
        InvalidObjectType,
        
        /// <remarks/>
        InvalidSelect,
        
        /// <remarks/>
        InvalidSetID,
        
        /// <remarks/>
        InvalidSetReq,
        
        /// <remarks/>
        ItemIDDuplicated,
        
        /// <remarks/>
        ResultQueryNotSupported,
        
        /// <remarks/>
        MissingCredentials,
        
        /// <remarks/>
        MissingDataElement,
        
        /// <remarks/>
        MissingExpiration,
        
        /// <remarks/>
        MissingItemID,
        
        /// <remarks/>
        MissingNewDataElement,
        
        /// <remarks/>
        MissingObjectType,
        
        /// <remarks/>
        MissingSelect,
        
        /// <remarks/>
        NewOrExisting,
        
        /// <remarks/>
        NoMoreObjects,
        
        /// <remarks/>
        NoMultipleAllowed,
        
        /// <remarks/>
        NoMultipleResources,
        
        /// <remarks/>
        NoSuchTest,
        
        /// <remarks/>
        ObjectTypeMismatch,
        
        /// <remarks/>
        OK,
        
        /// <remarks/>
        PaginationNotSupported,
        
        /// <remarks/>
        Partial,
        
        /// <remarks/>
        TimeOut,
        
        /// <remarks/>
        UnexpectedError,
        
        /// <remarks/>
        UnspecifiedError,
        
        /// <remarks/>
        UnsupportedObjectType,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobResponseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StopTaskResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EditTaskRegionResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllSchemaTaskNamesResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllSchemaNamesResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaskCompletionResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaskStatusResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeleteTaskResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EditTaskFiltersResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StartTaskResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/contract/Util/2009/10")]
    public abstract partial class EWSResponseBaseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private StatusType statusField;
        
        private System.Guid masterIDRefField;
        
        private bool masterIDRefFieldSpecified;
        
        private System.Guid itemIDRefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public StatusType Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public System.Guid masterIDRef {
            get {
                return this.masterIDRefField;
            }
            set {
                this.masterIDRefField = value;
                this.RaisePropertyChanged("masterIDRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool masterIDRefSpecified {
            get {
                return this.masterIDRefFieldSpecified;
            }
            set {
                this.masterIDRefFieldSpecified = value;
                this.RaisePropertyChanged("masterIDRefSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public System.Guid itemIDRef {
            get {
                return this.itemIDRefField;
            }
            set {
                this.itemIDRefField = value;
                this.RaisePropertyChanged("itemIDRef");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StopTaskResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EditTaskRegionResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllSchemaTaskNamesResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllSchemaNamesResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaskCompletionResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaskStatusResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeleteTaskResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EditTaskFiltersResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StartTaskResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class JobResponseType : EWSResponseBaseType {
        
        private bool successField;
        
        private string schemaNameField;
        
        private string taskNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Success {
            get {
                return this.successField;
            }
            set {
                this.successField = value;
                this.RaisePropertyChanged("Success");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string SchemaName {
            get {
                return this.schemaNameField;
            }
            set {
                this.schemaNameField = value;
                this.RaisePropertyChanged("SchemaName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string TaskName {
            get {
                return this.taskNameField;
            }
            set {
                this.taskNameField = value;
                this.RaisePropertyChanged("TaskName");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class StopTaskResponse : JobResponseType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class EditTaskRegionResponse : JobResponseType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class AllSchemaTaskNamesResponse : JobResponseType {
        
        private string[] allTaskNamesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllTaskNames", Order=0)]
        public string[] AllTaskNames {
            get {
                return this.allTaskNamesField;
            }
            set {
                this.allTaskNamesField = value;
                this.RaisePropertyChanged("AllTaskNames");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class AllSchemaNamesResponse : JobResponseType {
        
        private string[] allSchemaNamesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllSchemaNames", Order=0)]
        public string[] AllSchemaNames {
            get {
                return this.allSchemaNamesField;
            }
            set {
                this.allSchemaNamesField = value;
                this.RaisePropertyChanged("AllSchemaNames");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class TaskCompletionResponse : JobResponseType {
        
        private bool finishedField;
        
        private string outputLocationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Finished {
            get {
                return this.finishedField;
            }
            set {
                this.finishedField = value;
                this.RaisePropertyChanged("Finished");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string OutputLocation {
            get {
                return this.outputLocationField;
            }
            set {
                this.outputLocationField = value;
                this.RaisePropertyChanged("OutputLocation");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class TaskStatusResponse : JobResponseType {
        
        private uint numSucceededField;
        
        private uint numWarningField;
        
        private uint numErrorField;
        
        private uint numOutStandingField;
        
        private uint numAwaitingMergeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public uint NumSucceeded {
            get {
                return this.numSucceededField;
            }
            set {
                this.numSucceededField = value;
                this.RaisePropertyChanged("NumSucceeded");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public uint NumWarning {
            get {
                return this.numWarningField;
            }
            set {
                this.numWarningField = value;
                this.RaisePropertyChanged("NumWarning");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public uint NumError {
            get {
                return this.numErrorField;
            }
            set {
                this.numErrorField = value;
                this.RaisePropertyChanged("NumError");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public uint NumOutStanding {
            get {
                return this.numOutStandingField;
            }
            set {
                this.numOutStandingField = value;
                this.RaisePropertyChanged("NumOutStanding");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public uint NumAwaitingMerge {
            get {
                return this.numAwaitingMergeField;
            }
            set {
                this.numAwaitingMergeField = value;
                this.RaisePropertyChanged("NumAwaitingMerge");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class DeleteTaskResponse : JobResponseType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class EditTaskFiltersResponse : JobResponseType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class StartTaskResponse : JobResponseType {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeleteTaskRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaskStatusRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EditTaskRegionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StopTaskRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EditTaskFiltersRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StartTaskRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class TaskRequest : JobRequestType {
        
        private string taskNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string TaskName {
            get {
                return this.taskNameField;
            }
            set {
                this.taskNameField = value;
                this.RaisePropertyChanged("TaskName");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class DeleteTaskRequest : TaskRequest {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class TaskStatusRequest : TaskRequest {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class EditTaskRegionRequest : TaskRequest {
        
        private int eastMinField;
        
        private int eastMaxField;
        
        private int northMinField;
        
        private int northMaxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int EastMin {
            get {
                return this.eastMinField;
            }
            set {
                this.eastMinField = value;
                this.RaisePropertyChanged("EastMin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int EastMax {
            get {
                return this.eastMaxField;
            }
            set {
                this.eastMaxField = value;
                this.RaisePropertyChanged("EastMax");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int NorthMin {
            get {
                return this.northMinField;
            }
            set {
                this.northMinField = value;
                this.RaisePropertyChanged("NorthMin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int NorthMax {
            get {
                return this.northMaxField;
            }
            set {
                this.northMaxField = value;
                this.RaisePropertyChanged("NorthMax");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class StopTaskRequest : TaskRequest {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class EditTaskFiltersRequest : TaskRequest {
        
        private string[] planFiltersField;
        
        private string[] bestServerFiltersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlanFilters", Order=0)]
        public string[] PlanFilters {
            get {
                return this.planFiltersField;
            }
            set {
                this.planFiltersField = value;
                this.RaisePropertyChanged("PlanFilters");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BestServerFilters", Order=1)]
        public string[] BestServerFilters {
            get {
                return this.bestServerFiltersField;
            }
            set {
                this.bestServerFiltersField = value;
                this.RaisePropertyChanged("BestServerFilters");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class StartTaskRequest : TaskRequest {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class AllSchemaTaskNamesRequest : JobRequestType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aircominternational.com/data/EAWS/2011/04")]
    public partial class AllSchemaNamesRequest : JobRequestType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EAWSChannel : EAWSTestApp.EAWSService.EAWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EAWSClient : System.ServiceModel.DuplexClientBase<EAWSTestApp.EAWSService.EAWS>, EAWSTestApp.EAWSService.EAWS {
        
        public EAWSClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public EAWSClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public EAWSClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public EAWSClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public EAWSClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string SyncStartAWScheduler() {
            return base.Channel.SyncStartAWScheduler();
        }
        
        public string SyncIsAWSchedulerStarted() {
            return base.Channel.SyncIsAWSchedulerStarted();
        }
        
        public void ControlRequest(EAWSTestApp.EAWSService.JobRequestType rJobRequestType) {
            base.Channel.ControlRequest(rJobRequestType);
        }
        
        public void QueryRequest(EAWSTestApp.EAWSService.JobRequestType rJobRequestType) {
            base.Channel.QueryRequest(rJobRequestType);
        }
        
        public void EditRequest(EAWSTestApp.EAWSService.JobRequestType rJobRequestType) {
            base.Channel.EditRequest(rJobRequestType);
        }
    }
}
