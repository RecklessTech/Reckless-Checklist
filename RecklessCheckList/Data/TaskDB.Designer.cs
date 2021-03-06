﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("RecklessCheckListModel", "FK_TASK_TASK_VALUE", "TASK_VALUE", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(RecklessCheckList.Data.TASK_VALUE), "TASK", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(RecklessCheckList.Data.TASK), true)]

#endregion

namespace RecklessCheckList.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class RecklessCheckListEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new RecklessCheckListEntities object using the connection string found in the 'RecklessCheckListEntities' section of the application configuration file.
        /// </summary>
        public RecklessCheckListEntities() : base("name=RecklessCheckListEntities", "RecklessCheckListEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new RecklessCheckListEntities object.
        /// </summary>
        public RecklessCheckListEntities(string connectionString) : base(connectionString, "RecklessCheckListEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new RecklessCheckListEntities object.
        /// </summary>
        public RecklessCheckListEntities(EntityConnection connection) : base(connection, "RecklessCheckListEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TASK> TASKs
        {
            get
            {
                if ((_TASKs == null))
                {
                    _TASKs = base.CreateObjectSet<TASK>("TASKs");
                }
                return _TASKs;
            }
        }
        private ObjectSet<TASK> _TASKs;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TASK_VALUE> TASK_VALUE
        {
            get
            {
                if ((_TASK_VALUE == null))
                {
                    _TASK_VALUE = base.CreateObjectSet<TASK_VALUE>("TASK_VALUE");
                }
                return _TASK_VALUE;
            }
        }
        private ObjectSet<TASK_VALUE> _TASK_VALUE;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TASKs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTASKs(TASK tASK)
        {
            base.AddObject("TASKs", tASK);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TASK_VALUE EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTASK_VALUE(TASK_VALUE tASK_VALUE)
        {
            base.AddObject("TASK_VALUE", tASK_VALUE);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="RecklessCheckListModel", Name="TASK")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TASK : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TASK object.
        /// </summary>
        /// <param name="tASK_ID">Initial value of the TASK_ID property.</param>
        /// <param name="nAME">Initial value of the NAME property.</param>
        /// <param name="tASK_VALUE_ID">Initial value of the TASK_VALUE_ID property.</param>
        public static TASK CreateTASK(global::System.Int32 tASK_ID, global::System.String nAME, global::System.Int32 tASK_VALUE_ID)
        {
            TASK tASK = new TASK();
            tASK.TASK_ID = tASK_ID;
            tASK.NAME = nAME;
            tASK.TASK_VALUE_ID = tASK_VALUE_ID;
            return tASK;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TASK_ID
        {
            get
            {
                return _TASK_ID;
            }
            set
            {
                if (_TASK_ID != value)
                {
                    OnTASK_IDChanging(value);
                    ReportPropertyChanging("TASK_ID");
                    _TASK_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("TASK_ID");
                    OnTASK_IDChanged();
                }
            }
        }
        private global::System.Int32 _TASK_ID;
        partial void OnTASK_IDChanging(global::System.Int32 value);
        partial void OnTASK_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NAME
        {
            get
            {
                return _NAME;
            }
            set
            {
                OnNAMEChanging(value);
                ReportPropertyChanging("NAME");
                _NAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NAME");
                OnNAMEChanged();
            }
        }
        private global::System.String _NAME;
        partial void OnNAMEChanging(global::System.String value);
        partial void OnNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TASK_VALUE_ID
        {
            get
            {
                return _TASK_VALUE_ID;
            }
            set
            {
                OnTASK_VALUE_IDChanging(value);
                ReportPropertyChanging("TASK_VALUE_ID");
                _TASK_VALUE_ID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TASK_VALUE_ID");
                OnTASK_VALUE_IDChanged();
            }
        }
        private global::System.Int32 _TASK_VALUE_ID;
        partial void OnTASK_VALUE_IDChanging(global::System.Int32 value);
        partial void OnTASK_VALUE_IDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("RecklessCheckListModel", "FK_TASK_TASK_VALUE", "TASK_VALUE")]
        public TASK_VALUE TASK_VALUE
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TASK_VALUE>("RecklessCheckListModel.FK_TASK_TASK_VALUE", "TASK_VALUE").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TASK_VALUE>("RecklessCheckListModel.FK_TASK_TASK_VALUE", "TASK_VALUE").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TASK_VALUE> TASK_VALUEReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TASK_VALUE>("RecklessCheckListModel.FK_TASK_TASK_VALUE", "TASK_VALUE");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TASK_VALUE>("RecklessCheckListModel.FK_TASK_TASK_VALUE", "TASK_VALUE", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="RecklessCheckListModel", Name="TASK_VALUE")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TASK_VALUE : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TASK_VALUE object.
        /// </summary>
        /// <param name="tASK_VALUE_ID">Initial value of the TASK_VALUE_ID property.</param>
        /// <param name="nAME">Initial value of the NAME property.</param>
        public static TASK_VALUE CreateTASK_VALUE(global::System.Int32 tASK_VALUE_ID, global::System.String nAME)
        {
            TASK_VALUE tASK_VALUE = new TASK_VALUE();
            tASK_VALUE.TASK_VALUE_ID = tASK_VALUE_ID;
            tASK_VALUE.NAME = nAME;
            return tASK_VALUE;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TASK_VALUE_ID
        {
            get
            {
                return _TASK_VALUE_ID;
            }
            set
            {
                if (_TASK_VALUE_ID != value)
                {
                    OnTASK_VALUE_IDChanging(value);
                    ReportPropertyChanging("TASK_VALUE_ID");
                    _TASK_VALUE_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("TASK_VALUE_ID");
                    OnTASK_VALUE_IDChanged();
                }
            }
        }
        private global::System.Int32 _TASK_VALUE_ID;
        partial void OnTASK_VALUE_IDChanging(global::System.Int32 value);
        partial void OnTASK_VALUE_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NAME
        {
            get
            {
                return _NAME;
            }
            set
            {
                OnNAMEChanging(value);
                ReportPropertyChanging("NAME");
                _NAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NAME");
                OnNAMEChanged();
            }
        }
        private global::System.String _NAME;
        partial void OnNAMEChanging(global::System.String value);
        partial void OnNAMEChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("RecklessCheckListModel", "FK_TASK_TASK_VALUE", "TASK")]
        public EntityCollection<TASK> TASKs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TASK>("RecklessCheckListModel.FK_TASK_TASK_VALUE", "TASK");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TASK>("RecklessCheckListModel.FK_TASK_TASK_VALUE", "TASK", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
