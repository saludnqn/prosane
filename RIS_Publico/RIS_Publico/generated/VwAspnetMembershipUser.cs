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
    /// Strongly-typed collection for the VwAspnetMembershipUser class.
    /// </summary>
    [Serializable]
    public partial class VwAspnetMembershipUserCollection : ReadOnlyList<VwAspnetMembershipUser, VwAspnetMembershipUserCollection>
    {        
        public VwAspnetMembershipUserCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_aspnet_MembershipUsers view.
    /// </summary>
    [Serializable]
    public partial class VwAspnetMembershipUser : ReadOnlyRecord<VwAspnetMembershipUser>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_aspnet_MembershipUsers", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarUserId = new TableSchema.TableColumn(schema);
                colvarUserId.ColumnName = "UserId";
                colvarUserId.DataType = DbType.Guid;
                colvarUserId.MaxLength = 0;
                colvarUserId.AutoIncrement = false;
                colvarUserId.IsNullable = false;
                colvarUserId.IsPrimaryKey = false;
                colvarUserId.IsForeignKey = false;
                colvarUserId.IsReadOnly = false;
                
                schema.Columns.Add(colvarUserId);
                
                TableSchema.TableColumn colvarPasswordFormat = new TableSchema.TableColumn(schema);
                colvarPasswordFormat.ColumnName = "PasswordFormat";
                colvarPasswordFormat.DataType = DbType.Int32;
                colvarPasswordFormat.MaxLength = 0;
                colvarPasswordFormat.AutoIncrement = false;
                colvarPasswordFormat.IsNullable = false;
                colvarPasswordFormat.IsPrimaryKey = false;
                colvarPasswordFormat.IsForeignKey = false;
                colvarPasswordFormat.IsReadOnly = false;
                
                schema.Columns.Add(colvarPasswordFormat);
                
                TableSchema.TableColumn colvarMobilePIN = new TableSchema.TableColumn(schema);
                colvarMobilePIN.ColumnName = "MobilePIN";
                colvarMobilePIN.DataType = DbType.String;
                colvarMobilePIN.MaxLength = 16;
                colvarMobilePIN.AutoIncrement = false;
                colvarMobilePIN.IsNullable = true;
                colvarMobilePIN.IsPrimaryKey = false;
                colvarMobilePIN.IsForeignKey = false;
                colvarMobilePIN.IsReadOnly = false;
                
                schema.Columns.Add(colvarMobilePIN);
                
                TableSchema.TableColumn colvarEmail = new TableSchema.TableColumn(schema);
                colvarEmail.ColumnName = "Email";
                colvarEmail.DataType = DbType.String;
                colvarEmail.MaxLength = 256;
                colvarEmail.AutoIncrement = false;
                colvarEmail.IsNullable = true;
                colvarEmail.IsPrimaryKey = false;
                colvarEmail.IsForeignKey = false;
                colvarEmail.IsReadOnly = false;
                
                schema.Columns.Add(colvarEmail);
                
                TableSchema.TableColumn colvarLoweredEmail = new TableSchema.TableColumn(schema);
                colvarLoweredEmail.ColumnName = "LoweredEmail";
                colvarLoweredEmail.DataType = DbType.String;
                colvarLoweredEmail.MaxLength = 256;
                colvarLoweredEmail.AutoIncrement = false;
                colvarLoweredEmail.IsNullable = true;
                colvarLoweredEmail.IsPrimaryKey = false;
                colvarLoweredEmail.IsForeignKey = false;
                colvarLoweredEmail.IsReadOnly = false;
                
                schema.Columns.Add(colvarLoweredEmail);
                
                TableSchema.TableColumn colvarPasswordQuestion = new TableSchema.TableColumn(schema);
                colvarPasswordQuestion.ColumnName = "PasswordQuestion";
                colvarPasswordQuestion.DataType = DbType.String;
                colvarPasswordQuestion.MaxLength = 256;
                colvarPasswordQuestion.AutoIncrement = false;
                colvarPasswordQuestion.IsNullable = true;
                colvarPasswordQuestion.IsPrimaryKey = false;
                colvarPasswordQuestion.IsForeignKey = false;
                colvarPasswordQuestion.IsReadOnly = false;
                
                schema.Columns.Add(colvarPasswordQuestion);
                
                TableSchema.TableColumn colvarPasswordAnswer = new TableSchema.TableColumn(schema);
                colvarPasswordAnswer.ColumnName = "PasswordAnswer";
                colvarPasswordAnswer.DataType = DbType.String;
                colvarPasswordAnswer.MaxLength = 128;
                colvarPasswordAnswer.AutoIncrement = false;
                colvarPasswordAnswer.IsNullable = true;
                colvarPasswordAnswer.IsPrimaryKey = false;
                colvarPasswordAnswer.IsForeignKey = false;
                colvarPasswordAnswer.IsReadOnly = false;
                
                schema.Columns.Add(colvarPasswordAnswer);
                
                TableSchema.TableColumn colvarIsApproved = new TableSchema.TableColumn(schema);
                colvarIsApproved.ColumnName = "IsApproved";
                colvarIsApproved.DataType = DbType.Boolean;
                colvarIsApproved.MaxLength = 0;
                colvarIsApproved.AutoIncrement = false;
                colvarIsApproved.IsNullable = false;
                colvarIsApproved.IsPrimaryKey = false;
                colvarIsApproved.IsForeignKey = false;
                colvarIsApproved.IsReadOnly = false;
                
                schema.Columns.Add(colvarIsApproved);
                
                TableSchema.TableColumn colvarIsLockedOut = new TableSchema.TableColumn(schema);
                colvarIsLockedOut.ColumnName = "IsLockedOut";
                colvarIsLockedOut.DataType = DbType.Boolean;
                colvarIsLockedOut.MaxLength = 0;
                colvarIsLockedOut.AutoIncrement = false;
                colvarIsLockedOut.IsNullable = false;
                colvarIsLockedOut.IsPrimaryKey = false;
                colvarIsLockedOut.IsForeignKey = false;
                colvarIsLockedOut.IsReadOnly = false;
                
                schema.Columns.Add(colvarIsLockedOut);
                
                TableSchema.TableColumn colvarCreateDate = new TableSchema.TableColumn(schema);
                colvarCreateDate.ColumnName = "CreateDate";
                colvarCreateDate.DataType = DbType.DateTime;
                colvarCreateDate.MaxLength = 0;
                colvarCreateDate.AutoIncrement = false;
                colvarCreateDate.IsNullable = false;
                colvarCreateDate.IsPrimaryKey = false;
                colvarCreateDate.IsForeignKey = false;
                colvarCreateDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarCreateDate);
                
                TableSchema.TableColumn colvarLastLoginDate = new TableSchema.TableColumn(schema);
                colvarLastLoginDate.ColumnName = "LastLoginDate";
                colvarLastLoginDate.DataType = DbType.DateTime;
                colvarLastLoginDate.MaxLength = 0;
                colvarLastLoginDate.AutoIncrement = false;
                colvarLastLoginDate.IsNullable = false;
                colvarLastLoginDate.IsPrimaryKey = false;
                colvarLastLoginDate.IsForeignKey = false;
                colvarLastLoginDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarLastLoginDate);
                
                TableSchema.TableColumn colvarLastPasswordChangedDate = new TableSchema.TableColumn(schema);
                colvarLastPasswordChangedDate.ColumnName = "LastPasswordChangedDate";
                colvarLastPasswordChangedDate.DataType = DbType.DateTime;
                colvarLastPasswordChangedDate.MaxLength = 0;
                colvarLastPasswordChangedDate.AutoIncrement = false;
                colvarLastPasswordChangedDate.IsNullable = false;
                colvarLastPasswordChangedDate.IsPrimaryKey = false;
                colvarLastPasswordChangedDate.IsForeignKey = false;
                colvarLastPasswordChangedDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarLastPasswordChangedDate);
                
                TableSchema.TableColumn colvarLastLockoutDate = new TableSchema.TableColumn(schema);
                colvarLastLockoutDate.ColumnName = "LastLockoutDate";
                colvarLastLockoutDate.DataType = DbType.DateTime;
                colvarLastLockoutDate.MaxLength = 0;
                colvarLastLockoutDate.AutoIncrement = false;
                colvarLastLockoutDate.IsNullable = false;
                colvarLastLockoutDate.IsPrimaryKey = false;
                colvarLastLockoutDate.IsForeignKey = false;
                colvarLastLockoutDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarLastLockoutDate);
                
                TableSchema.TableColumn colvarFailedPasswordAttemptCount = new TableSchema.TableColumn(schema);
                colvarFailedPasswordAttemptCount.ColumnName = "FailedPasswordAttemptCount";
                colvarFailedPasswordAttemptCount.DataType = DbType.Int32;
                colvarFailedPasswordAttemptCount.MaxLength = 0;
                colvarFailedPasswordAttemptCount.AutoIncrement = false;
                colvarFailedPasswordAttemptCount.IsNullable = false;
                colvarFailedPasswordAttemptCount.IsPrimaryKey = false;
                colvarFailedPasswordAttemptCount.IsForeignKey = false;
                colvarFailedPasswordAttemptCount.IsReadOnly = false;
                
                schema.Columns.Add(colvarFailedPasswordAttemptCount);
                
                TableSchema.TableColumn colvarFailedPasswordAttemptWindowStart = new TableSchema.TableColumn(schema);
                colvarFailedPasswordAttemptWindowStart.ColumnName = "FailedPasswordAttemptWindowStart";
                colvarFailedPasswordAttemptWindowStart.DataType = DbType.DateTime;
                colvarFailedPasswordAttemptWindowStart.MaxLength = 0;
                colvarFailedPasswordAttemptWindowStart.AutoIncrement = false;
                colvarFailedPasswordAttemptWindowStart.IsNullable = false;
                colvarFailedPasswordAttemptWindowStart.IsPrimaryKey = false;
                colvarFailedPasswordAttemptWindowStart.IsForeignKey = false;
                colvarFailedPasswordAttemptWindowStart.IsReadOnly = false;
                
                schema.Columns.Add(colvarFailedPasswordAttemptWindowStart);
                
                TableSchema.TableColumn colvarFailedPasswordAnswerAttemptCount = new TableSchema.TableColumn(schema);
                colvarFailedPasswordAnswerAttemptCount.ColumnName = "FailedPasswordAnswerAttemptCount";
                colvarFailedPasswordAnswerAttemptCount.DataType = DbType.Int32;
                colvarFailedPasswordAnswerAttemptCount.MaxLength = 0;
                colvarFailedPasswordAnswerAttemptCount.AutoIncrement = false;
                colvarFailedPasswordAnswerAttemptCount.IsNullable = false;
                colvarFailedPasswordAnswerAttemptCount.IsPrimaryKey = false;
                colvarFailedPasswordAnswerAttemptCount.IsForeignKey = false;
                colvarFailedPasswordAnswerAttemptCount.IsReadOnly = false;
                
                schema.Columns.Add(colvarFailedPasswordAnswerAttemptCount);
                
                TableSchema.TableColumn colvarFailedPasswordAnswerAttemptWindowStart = new TableSchema.TableColumn(schema);
                colvarFailedPasswordAnswerAttemptWindowStart.ColumnName = "FailedPasswordAnswerAttemptWindowStart";
                colvarFailedPasswordAnswerAttemptWindowStart.DataType = DbType.DateTime;
                colvarFailedPasswordAnswerAttemptWindowStart.MaxLength = 0;
                colvarFailedPasswordAnswerAttemptWindowStart.AutoIncrement = false;
                colvarFailedPasswordAnswerAttemptWindowStart.IsNullable = false;
                colvarFailedPasswordAnswerAttemptWindowStart.IsPrimaryKey = false;
                colvarFailedPasswordAnswerAttemptWindowStart.IsForeignKey = false;
                colvarFailedPasswordAnswerAttemptWindowStart.IsReadOnly = false;
                
                schema.Columns.Add(colvarFailedPasswordAnswerAttemptWindowStart);
                
                TableSchema.TableColumn colvarComment = new TableSchema.TableColumn(schema);
                colvarComment.ColumnName = "Comment";
                colvarComment.DataType = DbType.String;
                colvarComment.MaxLength = 1073741823;
                colvarComment.AutoIncrement = false;
                colvarComment.IsNullable = true;
                colvarComment.IsPrimaryKey = false;
                colvarComment.IsForeignKey = false;
                colvarComment.IsReadOnly = false;
                
                schema.Columns.Add(colvarComment);
                
                TableSchema.TableColumn colvarApplicationId = new TableSchema.TableColumn(schema);
                colvarApplicationId.ColumnName = "ApplicationId";
                colvarApplicationId.DataType = DbType.Guid;
                colvarApplicationId.MaxLength = 0;
                colvarApplicationId.AutoIncrement = false;
                colvarApplicationId.IsNullable = false;
                colvarApplicationId.IsPrimaryKey = false;
                colvarApplicationId.IsForeignKey = false;
                colvarApplicationId.IsReadOnly = false;
                
                schema.Columns.Add(colvarApplicationId);
                
                TableSchema.TableColumn colvarUserName = new TableSchema.TableColumn(schema);
                colvarUserName.ColumnName = "UserName";
                colvarUserName.DataType = DbType.String;
                colvarUserName.MaxLength = 256;
                colvarUserName.AutoIncrement = false;
                colvarUserName.IsNullable = false;
                colvarUserName.IsPrimaryKey = false;
                colvarUserName.IsForeignKey = false;
                colvarUserName.IsReadOnly = false;
                
                schema.Columns.Add(colvarUserName);
                
                TableSchema.TableColumn colvarMobileAlias = new TableSchema.TableColumn(schema);
                colvarMobileAlias.ColumnName = "MobileAlias";
                colvarMobileAlias.DataType = DbType.String;
                colvarMobileAlias.MaxLength = 16;
                colvarMobileAlias.AutoIncrement = false;
                colvarMobileAlias.IsNullable = true;
                colvarMobileAlias.IsPrimaryKey = false;
                colvarMobileAlias.IsForeignKey = false;
                colvarMobileAlias.IsReadOnly = false;
                
                schema.Columns.Add(colvarMobileAlias);
                
                TableSchema.TableColumn colvarIsAnonymous = new TableSchema.TableColumn(schema);
                colvarIsAnonymous.ColumnName = "IsAnonymous";
                colvarIsAnonymous.DataType = DbType.Boolean;
                colvarIsAnonymous.MaxLength = 0;
                colvarIsAnonymous.AutoIncrement = false;
                colvarIsAnonymous.IsNullable = false;
                colvarIsAnonymous.IsPrimaryKey = false;
                colvarIsAnonymous.IsForeignKey = false;
                colvarIsAnonymous.IsReadOnly = false;
                
                schema.Columns.Add(colvarIsAnonymous);
                
                TableSchema.TableColumn colvarLastActivityDate = new TableSchema.TableColumn(schema);
                colvarLastActivityDate.ColumnName = "LastActivityDate";
                colvarLastActivityDate.DataType = DbType.DateTime;
                colvarLastActivityDate.MaxLength = 0;
                colvarLastActivityDate.AutoIncrement = false;
                colvarLastActivityDate.IsNullable = false;
                colvarLastActivityDate.IsPrimaryKey = false;
                colvarLastActivityDate.IsForeignKey = false;
                colvarLastActivityDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarLastActivityDate);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("vw_aspnet_MembershipUsers",schema);
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
	    public VwAspnetMembershipUser()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwAspnetMembershipUser(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwAspnetMembershipUser(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwAspnetMembershipUser(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("UserId")]
        [Bindable(true)]
        public Guid UserId 
	    {
		    get
		    {
			    return GetColumnValue<Guid>("UserId");
		    }
            set 
		    {
			    SetColumnValue("UserId", value);
            }
        }
	      
        [XmlAttribute("PasswordFormat")]
        [Bindable(true)]
        public int PasswordFormat 
	    {
		    get
		    {
			    return GetColumnValue<int>("PasswordFormat");
		    }
            set 
		    {
			    SetColumnValue("PasswordFormat", value);
            }
        }
	      
        [XmlAttribute("MobilePIN")]
        [Bindable(true)]
        public string MobilePIN 
	    {
		    get
		    {
			    return GetColumnValue<string>("MobilePIN");
		    }
            set 
		    {
			    SetColumnValue("MobilePIN", value);
            }
        }
	      
        [XmlAttribute("Email")]
        [Bindable(true)]
        public string Email 
	    {
		    get
		    {
			    return GetColumnValue<string>("Email");
		    }
            set 
		    {
			    SetColumnValue("Email", value);
            }
        }
	      
        [XmlAttribute("LoweredEmail")]
        [Bindable(true)]
        public string LoweredEmail 
	    {
		    get
		    {
			    return GetColumnValue<string>("LoweredEmail");
		    }
            set 
		    {
			    SetColumnValue("LoweredEmail", value);
            }
        }
	      
        [XmlAttribute("PasswordQuestion")]
        [Bindable(true)]
        public string PasswordQuestion 
	    {
		    get
		    {
			    return GetColumnValue<string>("PasswordQuestion");
		    }
            set 
		    {
			    SetColumnValue("PasswordQuestion", value);
            }
        }
	      
        [XmlAttribute("PasswordAnswer")]
        [Bindable(true)]
        public string PasswordAnswer 
	    {
		    get
		    {
			    return GetColumnValue<string>("PasswordAnswer");
		    }
            set 
		    {
			    SetColumnValue("PasswordAnswer", value);
            }
        }
	      
        [XmlAttribute("IsApproved")]
        [Bindable(true)]
        public bool IsApproved 
	    {
		    get
		    {
			    return GetColumnValue<bool>("IsApproved");
		    }
            set 
		    {
			    SetColumnValue("IsApproved", value);
            }
        }
	      
        [XmlAttribute("IsLockedOut")]
        [Bindable(true)]
        public bool IsLockedOut 
	    {
		    get
		    {
			    return GetColumnValue<bool>("IsLockedOut");
		    }
            set 
		    {
			    SetColumnValue("IsLockedOut", value);
            }
        }
	      
        [XmlAttribute("CreateDate")]
        [Bindable(true)]
        public DateTime CreateDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("CreateDate");
		    }
            set 
		    {
			    SetColumnValue("CreateDate", value);
            }
        }
	      
        [XmlAttribute("LastLoginDate")]
        [Bindable(true)]
        public DateTime LastLoginDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("LastLoginDate");
		    }
            set 
		    {
			    SetColumnValue("LastLoginDate", value);
            }
        }
	      
        [XmlAttribute("LastPasswordChangedDate")]
        [Bindable(true)]
        public DateTime LastPasswordChangedDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("LastPasswordChangedDate");
		    }
            set 
		    {
			    SetColumnValue("LastPasswordChangedDate", value);
            }
        }
	      
        [XmlAttribute("LastLockoutDate")]
        [Bindable(true)]
        public DateTime LastLockoutDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("LastLockoutDate");
		    }
            set 
		    {
			    SetColumnValue("LastLockoutDate", value);
            }
        }
	      
        [XmlAttribute("FailedPasswordAttemptCount")]
        [Bindable(true)]
        public int FailedPasswordAttemptCount 
	    {
		    get
		    {
			    return GetColumnValue<int>("FailedPasswordAttemptCount");
		    }
            set 
		    {
			    SetColumnValue("FailedPasswordAttemptCount", value);
            }
        }
	      
        [XmlAttribute("FailedPasswordAttemptWindowStart")]
        [Bindable(true)]
        public DateTime FailedPasswordAttemptWindowStart 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("FailedPasswordAttemptWindowStart");
		    }
            set 
		    {
			    SetColumnValue("FailedPasswordAttemptWindowStart", value);
            }
        }
	      
        [XmlAttribute("FailedPasswordAnswerAttemptCount")]
        [Bindable(true)]
        public int FailedPasswordAnswerAttemptCount 
	    {
		    get
		    {
			    return GetColumnValue<int>("FailedPasswordAnswerAttemptCount");
		    }
            set 
		    {
			    SetColumnValue("FailedPasswordAnswerAttemptCount", value);
            }
        }
	      
        [XmlAttribute("FailedPasswordAnswerAttemptWindowStart")]
        [Bindable(true)]
        public DateTime FailedPasswordAnswerAttemptWindowStart 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("FailedPasswordAnswerAttemptWindowStart");
		    }
            set 
		    {
			    SetColumnValue("FailedPasswordAnswerAttemptWindowStart", value);
            }
        }
	      
        [XmlAttribute("Comment")]
        [Bindable(true)]
        public string Comment 
	    {
		    get
		    {
			    return GetColumnValue<string>("Comment");
		    }
            set 
		    {
			    SetColumnValue("Comment", value);
            }
        }
	      
        [XmlAttribute("ApplicationId")]
        [Bindable(true)]
        public Guid ApplicationId 
	    {
		    get
		    {
			    return GetColumnValue<Guid>("ApplicationId");
		    }
            set 
		    {
			    SetColumnValue("ApplicationId", value);
            }
        }
	      
        [XmlAttribute("UserName")]
        [Bindable(true)]
        public string UserName 
	    {
		    get
		    {
			    return GetColumnValue<string>("UserName");
		    }
            set 
		    {
			    SetColumnValue("UserName", value);
            }
        }
	      
        [XmlAttribute("MobileAlias")]
        [Bindable(true)]
        public string MobileAlias 
	    {
		    get
		    {
			    return GetColumnValue<string>("MobileAlias");
		    }
            set 
		    {
			    SetColumnValue("MobileAlias", value);
            }
        }
	      
        [XmlAttribute("IsAnonymous")]
        [Bindable(true)]
        public bool IsAnonymous 
	    {
		    get
		    {
			    return GetColumnValue<bool>("IsAnonymous");
		    }
            set 
		    {
			    SetColumnValue("IsAnonymous", value);
            }
        }
	      
        [XmlAttribute("LastActivityDate")]
        [Bindable(true)]
        public DateTime LastActivityDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("LastActivityDate");
		    }
            set 
		    {
			    SetColumnValue("LastActivityDate", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string UserId = @"UserId";
            
            public static string PasswordFormat = @"PasswordFormat";
            
            public static string MobilePIN = @"MobilePIN";
            
            public static string Email = @"Email";
            
            public static string LoweredEmail = @"LoweredEmail";
            
            public static string PasswordQuestion = @"PasswordQuestion";
            
            public static string PasswordAnswer = @"PasswordAnswer";
            
            public static string IsApproved = @"IsApproved";
            
            public static string IsLockedOut = @"IsLockedOut";
            
            public static string CreateDate = @"CreateDate";
            
            public static string LastLoginDate = @"LastLoginDate";
            
            public static string LastPasswordChangedDate = @"LastPasswordChangedDate";
            
            public static string LastLockoutDate = @"LastLockoutDate";
            
            public static string FailedPasswordAttemptCount = @"FailedPasswordAttemptCount";
            
            public static string FailedPasswordAttemptWindowStart = @"FailedPasswordAttemptWindowStart";
            
            public static string FailedPasswordAnswerAttemptCount = @"FailedPasswordAnswerAttemptCount";
            
            public static string FailedPasswordAnswerAttemptWindowStart = @"FailedPasswordAnswerAttemptWindowStart";
            
            public static string Comment = @"Comment";
            
            public static string ApplicationId = @"ApplicationId";
            
            public static string UserName = @"UserName";
            
            public static string MobileAlias = @"MobileAlias";
            
            public static string IsAnonymous = @"IsAnonymous";
            
            public static string LastActivityDate = @"LastActivityDate";
            
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
