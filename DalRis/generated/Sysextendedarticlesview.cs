using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
namespace DalRis{
    /// <summary>
    /// Strongly-typed collection for the Sysextendedarticlesview class.
    /// </summary>
    [Serializable]
    public partial class SysextendedarticlesviewCollection : ReadOnlyList<Sysextendedarticlesview, SysextendedarticlesviewCollection>
    {        
        public SysextendedarticlesviewCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the sysextendedarticlesview view.
    /// </summary>
    [Serializable]
    public partial class Sysextendedarticlesview : ReadOnlyRecord<Sysextendedarticlesview>, IReadOnlyRecord
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }
	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }
    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("sysextendedarticlesview", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarArtid = new TableSchema.TableColumn(schema);
                colvarArtid.ColumnName = "artid";
                colvarArtid.DataType = DbType.Int32;
                colvarArtid.MaxLength = 0;
                colvarArtid.AutoIncrement = false;
                colvarArtid.IsNullable = false;
                colvarArtid.IsPrimaryKey = false;
                colvarArtid.IsForeignKey = false;
                colvarArtid.IsReadOnly = false;
                
                schema.Columns.Add(colvarArtid);
                
                TableSchema.TableColumn colvarCreationScript = new TableSchema.TableColumn(schema);
                colvarCreationScript.ColumnName = "creation_script";
                colvarCreationScript.DataType = DbType.String;
                colvarCreationScript.MaxLength = 255;
                colvarCreationScript.AutoIncrement = false;
                colvarCreationScript.IsNullable = true;
                colvarCreationScript.IsPrimaryKey = false;
                colvarCreationScript.IsForeignKey = false;
                colvarCreationScript.IsReadOnly = false;
                
                schema.Columns.Add(colvarCreationScript);
                
                TableSchema.TableColumn colvarDelCmd = new TableSchema.TableColumn(schema);
                colvarDelCmd.ColumnName = "del_cmd";
                colvarDelCmd.DataType = DbType.String;
                colvarDelCmd.MaxLength = 255;
                colvarDelCmd.AutoIncrement = false;
                colvarDelCmd.IsNullable = true;
                colvarDelCmd.IsPrimaryKey = false;
                colvarDelCmd.IsForeignKey = false;
                colvarDelCmd.IsReadOnly = false;
                
                schema.Columns.Add(colvarDelCmd);
                
                TableSchema.TableColumn colvarDescription = new TableSchema.TableColumn(schema);
                colvarDescription.ColumnName = "description";
                colvarDescription.DataType = DbType.String;
                colvarDescription.MaxLength = 255;
                colvarDescription.AutoIncrement = false;
                colvarDescription.IsNullable = true;
                colvarDescription.IsPrimaryKey = false;
                colvarDescription.IsForeignKey = false;
                colvarDescription.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescription);
                
                TableSchema.TableColumn colvarDestTable = new TableSchema.TableColumn(schema);
                colvarDestTable.ColumnName = "dest_table";
                colvarDestTable.DataType = DbType.String;
                colvarDestTable.MaxLength = 128;
                colvarDestTable.AutoIncrement = false;
                colvarDestTable.IsNullable = false;
                colvarDestTable.IsPrimaryKey = false;
                colvarDestTable.IsForeignKey = false;
                colvarDestTable.IsReadOnly = false;
                
                schema.Columns.Add(colvarDestTable);
                
                TableSchema.TableColumn colvarFilter = new TableSchema.TableColumn(schema);
                colvarFilter.ColumnName = "filter";
                colvarFilter.DataType = DbType.Int32;
                colvarFilter.MaxLength = 0;
                colvarFilter.AutoIncrement = false;
                colvarFilter.IsNullable = true;
                colvarFilter.IsPrimaryKey = false;
                colvarFilter.IsForeignKey = false;
                colvarFilter.IsReadOnly = false;
                
                schema.Columns.Add(colvarFilter);
                
                TableSchema.TableColumn colvarFilterClause = new TableSchema.TableColumn(schema);
                colvarFilterClause.ColumnName = "filter_clause";
                colvarFilterClause.DataType = DbType.String;
                colvarFilterClause.MaxLength = 1073741823;
                colvarFilterClause.AutoIncrement = false;
                colvarFilterClause.IsNullable = true;
                colvarFilterClause.IsPrimaryKey = false;
                colvarFilterClause.IsForeignKey = false;
                colvarFilterClause.IsReadOnly = false;
                
                schema.Columns.Add(colvarFilterClause);
                
                TableSchema.TableColumn colvarInsCmd = new TableSchema.TableColumn(schema);
                colvarInsCmd.ColumnName = "ins_cmd";
                colvarInsCmd.DataType = DbType.String;
                colvarInsCmd.MaxLength = 255;
                colvarInsCmd.AutoIncrement = false;
                colvarInsCmd.IsNullable = true;
                colvarInsCmd.IsPrimaryKey = false;
                colvarInsCmd.IsForeignKey = false;
                colvarInsCmd.IsReadOnly = false;
                
                schema.Columns.Add(colvarInsCmd);
                
                TableSchema.TableColumn colvarName = new TableSchema.TableColumn(schema);
                colvarName.ColumnName = "name";
                colvarName.DataType = DbType.String;
                colvarName.MaxLength = 128;
                colvarName.AutoIncrement = false;
                colvarName.IsNullable = false;
                colvarName.IsPrimaryKey = false;
                colvarName.IsForeignKey = false;
                colvarName.IsReadOnly = false;
                
                schema.Columns.Add(colvarName);
                
                TableSchema.TableColumn colvarObjid = new TableSchema.TableColumn(schema);
                colvarObjid.ColumnName = "objid";
                colvarObjid.DataType = DbType.Int32;
                colvarObjid.MaxLength = 0;
                colvarObjid.AutoIncrement = false;
                colvarObjid.IsNullable = false;
                colvarObjid.IsPrimaryKey = false;
                colvarObjid.IsForeignKey = false;
                colvarObjid.IsReadOnly = false;
                
                schema.Columns.Add(colvarObjid);
                
                TableSchema.TableColumn colvarPubid = new TableSchema.TableColumn(schema);
                colvarPubid.ColumnName = "pubid";
                colvarPubid.DataType = DbType.Int32;
                colvarPubid.MaxLength = 0;
                colvarPubid.AutoIncrement = false;
                colvarPubid.IsNullable = false;
                colvarPubid.IsPrimaryKey = false;
                colvarPubid.IsForeignKey = false;
                colvarPubid.IsReadOnly = false;
                
                schema.Columns.Add(colvarPubid);
                
                TableSchema.TableColumn colvarPreCreationCmd = new TableSchema.TableColumn(schema);
                colvarPreCreationCmd.ColumnName = "pre_creation_cmd";
                colvarPreCreationCmd.DataType = DbType.Byte;
                colvarPreCreationCmd.MaxLength = 0;
                colvarPreCreationCmd.AutoIncrement = false;
                colvarPreCreationCmd.IsNullable = false;
                colvarPreCreationCmd.IsPrimaryKey = false;
                colvarPreCreationCmd.IsForeignKey = false;
                colvarPreCreationCmd.IsReadOnly = false;
                
                schema.Columns.Add(colvarPreCreationCmd);
                
                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "status";
                colvarStatus.DataType = DbType.Int32;
                colvarStatus.MaxLength = 0;
                colvarStatus.AutoIncrement = false;
                colvarStatus.IsNullable = false;
                colvarStatus.IsPrimaryKey = false;
                colvarStatus.IsForeignKey = false;
                colvarStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatus);
                
                TableSchema.TableColumn colvarSyncObjid = new TableSchema.TableColumn(schema);
                colvarSyncObjid.ColumnName = "sync_objid";
                colvarSyncObjid.DataType = DbType.Int32;
                colvarSyncObjid.MaxLength = 0;
                colvarSyncObjid.AutoIncrement = false;
                colvarSyncObjid.IsNullable = true;
                colvarSyncObjid.IsPrimaryKey = false;
                colvarSyncObjid.IsForeignKey = false;
                colvarSyncObjid.IsReadOnly = false;
                
                schema.Columns.Add(colvarSyncObjid);
                
                TableSchema.TableColumn colvarType = new TableSchema.TableColumn(schema);
                colvarType.ColumnName = "type";
                colvarType.DataType = DbType.Byte;
                colvarType.MaxLength = 0;
                colvarType.AutoIncrement = false;
                colvarType.IsNullable = false;
                colvarType.IsPrimaryKey = false;
                colvarType.IsForeignKey = false;
                colvarType.IsReadOnly = false;
                
                schema.Columns.Add(colvarType);
                
                TableSchema.TableColumn colvarUpdCmd = new TableSchema.TableColumn(schema);
                colvarUpdCmd.ColumnName = "upd_cmd";
                colvarUpdCmd.DataType = DbType.String;
                colvarUpdCmd.MaxLength = 255;
                colvarUpdCmd.AutoIncrement = false;
                colvarUpdCmd.IsNullable = true;
                colvarUpdCmd.IsPrimaryKey = false;
                colvarUpdCmd.IsForeignKey = false;
                colvarUpdCmd.IsReadOnly = false;
                
                schema.Columns.Add(colvarUpdCmd);
                
                TableSchema.TableColumn colvarSchemaOption = new TableSchema.TableColumn(schema);
                colvarSchemaOption.ColumnName = "schema_option";
                colvarSchemaOption.DataType = DbType.Binary;
                colvarSchemaOption.MaxLength = 8;
                colvarSchemaOption.AutoIncrement = false;
                colvarSchemaOption.IsNullable = true;
                colvarSchemaOption.IsPrimaryKey = false;
                colvarSchemaOption.IsForeignKey = false;
                colvarSchemaOption.IsReadOnly = false;
                
                schema.Columns.Add(colvarSchemaOption);
                
                TableSchema.TableColumn colvarDestOwner = new TableSchema.TableColumn(schema);
                colvarDestOwner.ColumnName = "dest_owner";
                colvarDestOwner.DataType = DbType.String;
                colvarDestOwner.MaxLength = 128;
                colvarDestOwner.AutoIncrement = false;
                colvarDestOwner.IsNullable = true;
                colvarDestOwner.IsPrimaryKey = false;
                colvarDestOwner.IsForeignKey = false;
                colvarDestOwner.IsReadOnly = false;
                
                schema.Columns.Add(colvarDestOwner);
                
                TableSchema.TableColumn colvarInsScriptingProc = new TableSchema.TableColumn(schema);
                colvarInsScriptingProc.ColumnName = "ins_scripting_proc";
                colvarInsScriptingProc.DataType = DbType.Int32;
                colvarInsScriptingProc.MaxLength = 0;
                colvarInsScriptingProc.AutoIncrement = false;
                colvarInsScriptingProc.IsNullable = true;
                colvarInsScriptingProc.IsPrimaryKey = false;
                colvarInsScriptingProc.IsForeignKey = false;
                colvarInsScriptingProc.IsReadOnly = false;
                
                schema.Columns.Add(colvarInsScriptingProc);
                
                TableSchema.TableColumn colvarDelScriptingProc = new TableSchema.TableColumn(schema);
                colvarDelScriptingProc.ColumnName = "del_scripting_proc";
                colvarDelScriptingProc.DataType = DbType.Int32;
                colvarDelScriptingProc.MaxLength = 0;
                colvarDelScriptingProc.AutoIncrement = false;
                colvarDelScriptingProc.IsNullable = true;
                colvarDelScriptingProc.IsPrimaryKey = false;
                colvarDelScriptingProc.IsForeignKey = false;
                colvarDelScriptingProc.IsReadOnly = false;
                
                schema.Columns.Add(colvarDelScriptingProc);
                
                TableSchema.TableColumn colvarUpdScriptingProc = new TableSchema.TableColumn(schema);
                colvarUpdScriptingProc.ColumnName = "upd_scripting_proc";
                colvarUpdScriptingProc.DataType = DbType.Int32;
                colvarUpdScriptingProc.MaxLength = 0;
                colvarUpdScriptingProc.AutoIncrement = false;
                colvarUpdScriptingProc.IsNullable = true;
                colvarUpdScriptingProc.IsPrimaryKey = false;
                colvarUpdScriptingProc.IsForeignKey = false;
                colvarUpdScriptingProc.IsReadOnly = false;
                
                schema.Columns.Add(colvarUpdScriptingProc);
                
                TableSchema.TableColumn colvarCustomScript = new TableSchema.TableColumn(schema);
                colvarCustomScript.ColumnName = "custom_script";
                colvarCustomScript.DataType = DbType.String;
                colvarCustomScript.MaxLength = 2048;
                colvarCustomScript.AutoIncrement = false;
                colvarCustomScript.IsNullable = true;
                colvarCustomScript.IsPrimaryKey = false;
                colvarCustomScript.IsForeignKey = false;
                colvarCustomScript.IsReadOnly = false;
                
                schema.Columns.Add(colvarCustomScript);
                
                TableSchema.TableColumn colvarFireTriggersOnSnapshot = new TableSchema.TableColumn(schema);
                colvarFireTriggersOnSnapshot.ColumnName = "fire_triggers_on_snapshot";
                colvarFireTriggersOnSnapshot.DataType = DbType.Int32;
                colvarFireTriggersOnSnapshot.MaxLength = 0;
                colvarFireTriggersOnSnapshot.AutoIncrement = false;
                colvarFireTriggersOnSnapshot.IsNullable = false;
                colvarFireTriggersOnSnapshot.IsPrimaryKey = false;
                colvarFireTriggersOnSnapshot.IsForeignKey = false;
                colvarFireTriggersOnSnapshot.IsReadOnly = false;
                
                schema.Columns.Add(colvarFireTriggersOnSnapshot);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("sysextendedarticlesview",schema);
            }
        }
        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }
	    #endregion
	    
	    #region .ctors
	    public Sysextendedarticlesview()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Sysextendedarticlesview(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Sysextendedarticlesview(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Sysextendedarticlesview(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Artid")]
        [Bindable(true)]
        public int Artid 
	    {
		    get
		    {
			    return GetColumnValue<int>("artid");
		    }
            set 
		    {
			    SetColumnValue("artid", value);
            }
        }
	      
        [XmlAttribute("CreationScript")]
        [Bindable(true)]
        public string CreationScript 
	    {
		    get
		    {
			    return GetColumnValue<string>("creation_script");
		    }
            set 
		    {
			    SetColumnValue("creation_script", value);
            }
        }
	      
        [XmlAttribute("DelCmd")]
        [Bindable(true)]
        public string DelCmd 
	    {
		    get
		    {
			    return GetColumnValue<string>("del_cmd");
		    }
            set 
		    {
			    SetColumnValue("del_cmd", value);
            }
        }
	      
        [XmlAttribute("Description")]
        [Bindable(true)]
        public string Description 
	    {
		    get
		    {
			    return GetColumnValue<string>("description");
		    }
            set 
		    {
			    SetColumnValue("description", value);
            }
        }
	      
        [XmlAttribute("DestTable")]
        [Bindable(true)]
        public string DestTable 
	    {
		    get
		    {
			    return GetColumnValue<string>("dest_table");
		    }
            set 
		    {
			    SetColumnValue("dest_table", value);
            }
        }
	      
        [XmlAttribute("Filter")]
        [Bindable(true)]
        public int? Filter 
	    {
		    get
		    {
			    return GetColumnValue<int?>("filter");
		    }
            set 
		    {
			    SetColumnValue("filter", value);
            }
        }
	      
        [XmlAttribute("FilterClause")]
        [Bindable(true)]
        public string FilterClause 
	    {
		    get
		    {
			    return GetColumnValue<string>("filter_clause");
		    }
            set 
		    {
			    SetColumnValue("filter_clause", value);
            }
        }
	      
        [XmlAttribute("InsCmd")]
        [Bindable(true)]
        public string InsCmd 
	    {
		    get
		    {
			    return GetColumnValue<string>("ins_cmd");
		    }
            set 
		    {
			    SetColumnValue("ins_cmd", value);
            }
        }
	      
        [XmlAttribute("Name")]
        [Bindable(true)]
        public string Name 
	    {
		    get
		    {
			    return GetColumnValue<string>("name");
		    }
            set 
		    {
			    SetColumnValue("name", value);
            }
        }
	      
        [XmlAttribute("Objid")]
        [Bindable(true)]
        public int Objid 
	    {
		    get
		    {
			    return GetColumnValue<int>("objid");
		    }
            set 
		    {
			    SetColumnValue("objid", value);
            }
        }
	      
        [XmlAttribute("Pubid")]
        [Bindable(true)]
        public int Pubid 
	    {
		    get
		    {
			    return GetColumnValue<int>("pubid");
		    }
            set 
		    {
			    SetColumnValue("pubid", value);
            }
        }
	      
        [XmlAttribute("PreCreationCmd")]
        [Bindable(true)]
        public byte PreCreationCmd 
	    {
		    get
		    {
			    return GetColumnValue<byte>("pre_creation_cmd");
		    }
            set 
		    {
			    SetColumnValue("pre_creation_cmd", value);
            }
        }
	      
        [XmlAttribute("Status")]
        [Bindable(true)]
        public int Status 
	    {
		    get
		    {
			    return GetColumnValue<int>("status");
		    }
            set 
		    {
			    SetColumnValue("status", value);
            }
        }
	      
        [XmlAttribute("SyncObjid")]
        [Bindable(true)]
        public int? SyncObjid 
	    {
		    get
		    {
			    return GetColumnValue<int?>("sync_objid");
		    }
            set 
		    {
			    SetColumnValue("sync_objid", value);
            }
        }
	      
        [XmlAttribute("Type")]
        [Bindable(true)]
        public byte Type 
	    {
		    get
		    {
			    return GetColumnValue<byte>("type");
		    }
            set 
		    {
			    SetColumnValue("type", value);
            }
        }
	      
        [XmlAttribute("UpdCmd")]
        [Bindable(true)]
        public string UpdCmd 
	    {
		    get
		    {
			    return GetColumnValue<string>("upd_cmd");
		    }
            set 
		    {
			    SetColumnValue("upd_cmd", value);
            }
        }
	      
        [XmlAttribute("SchemaOption")]
        [Bindable(true)]
        public byte[] SchemaOption 
	    {
		    get
		    {
			    return GetColumnValue<byte[]>("schema_option");
		    }
            set 
		    {
			    SetColumnValue("schema_option", value);
            }
        }
	      
        [XmlAttribute("DestOwner")]
        [Bindable(true)]
        public string DestOwner 
	    {
		    get
		    {
			    return GetColumnValue<string>("dest_owner");
		    }
            set 
		    {
			    SetColumnValue("dest_owner", value);
            }
        }
	      
        [XmlAttribute("InsScriptingProc")]
        [Bindable(true)]
        public int? InsScriptingProc 
	    {
		    get
		    {
			    return GetColumnValue<int?>("ins_scripting_proc");
		    }
            set 
		    {
			    SetColumnValue("ins_scripting_proc", value);
            }
        }
	      
        [XmlAttribute("DelScriptingProc")]
        [Bindable(true)]
        public int? DelScriptingProc 
	    {
		    get
		    {
			    return GetColumnValue<int?>("del_scripting_proc");
		    }
            set 
		    {
			    SetColumnValue("del_scripting_proc", value);
            }
        }
	      
        [XmlAttribute("UpdScriptingProc")]
        [Bindable(true)]
        public int? UpdScriptingProc 
	    {
		    get
		    {
			    return GetColumnValue<int?>("upd_scripting_proc");
		    }
            set 
		    {
			    SetColumnValue("upd_scripting_proc", value);
            }
        }
	      
        [XmlAttribute("CustomScript")]
        [Bindable(true)]
        public string CustomScript 
	    {
		    get
		    {
			    return GetColumnValue<string>("custom_script");
		    }
            set 
		    {
			    SetColumnValue("custom_script", value);
            }
        }
	      
        [XmlAttribute("FireTriggersOnSnapshot")]
        [Bindable(true)]
        public int FireTriggersOnSnapshot 
	    {
		    get
		    {
			    return GetColumnValue<int>("fire_triggers_on_snapshot");
		    }
            set 
		    {
			    SetColumnValue("fire_triggers_on_snapshot", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Artid = @"artid";
            
            public static string CreationScript = @"creation_script";
            
            public static string DelCmd = @"del_cmd";
            
            public static string Description = @"description";
            
            public static string DestTable = @"dest_table";
            
            public static string Filter = @"filter";
            
            public static string FilterClause = @"filter_clause";
            
            public static string InsCmd = @"ins_cmd";
            
            public static string Name = @"name";
            
            public static string Objid = @"objid";
            
            public static string Pubid = @"pubid";
            
            public static string PreCreationCmd = @"pre_creation_cmd";
            
            public static string Status = @"status";
            
            public static string SyncObjid = @"sync_objid";
            
            public static string Type = @"type";
            
            public static string UpdCmd = @"upd_cmd";
            
            public static string SchemaOption = @"schema_option";
            
            public static string DestOwner = @"dest_owner";
            
            public static string InsScriptingProc = @"ins_scripting_proc";
            
            public static string DelScriptingProc = @"del_scripting_proc";
            
            public static string UpdScriptingProc = @"upd_scripting_proc";
            
            public static string CustomScript = @"custom_script";
            
            public static string FireTriggersOnSnapshot = @"fire_triggers_on_snapshot";
            
	    }
	    #endregion
	    
	    
	    #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName) {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName) {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion
	    
    }
}
