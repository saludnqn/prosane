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
namespace DalRis
{
	/// <summary>
	/// Strongly-typed collection for the EmrRegistro class.
	/// </summary>
    [Serializable]
	public partial class EmrRegistroCollection : ActiveList<EmrRegistro, EmrRegistroCollection>
	{	   
		public EmrRegistroCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmrRegistroCollection</returns>
		public EmrRegistroCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmrRegistro o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the EMR_Registro table.
	/// </summary>
	[Serializable]
	public partial class EmrRegistro : ActiveRecord<EmrRegistro>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmrRegistro()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmrRegistro(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmrRegistro(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmrRegistro(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("EMR_Registro", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdEmr = new TableSchema.TableColumn(schema);
				colvarIdEmr.ColumnName = "idEmr";
				colvarIdEmr.DataType = DbType.Int32;
				colvarIdEmr.MaxLength = 0;
				colvarIdEmr.AutoIncrement = true;
				colvarIdEmr.IsNullable = false;
				colvarIdEmr.IsPrimaryKey = true;
				colvarIdEmr.IsForeignKey = false;
				colvarIdEmr.IsReadOnly = false;
				colvarIdEmr.DefaultSetting = @"";
				colvarIdEmr.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEmr);
				
				TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
				colvarFecha.ColumnName = "fecha";
				colvarFecha.DataType = DbType.DateTime;
				colvarFecha.MaxLength = 0;
				colvarFecha.AutoIncrement = false;
				colvarFecha.IsNullable = false;
				colvarFecha.IsPrimaryKey = false;
				colvarFecha.IsForeignKey = false;
				colvarFecha.IsReadOnly = false;
				
						colvarFecha.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarFecha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFecha);
				
				TableSchema.TableColumn colvarTelefonista = new TableSchema.TableColumn(schema);
				colvarTelefonista.ColumnName = "telefonista";
				colvarTelefonista.DataType = DbType.AnsiString;
				colvarTelefonista.MaxLength = 200;
				colvarTelefonista.AutoIncrement = false;
				colvarTelefonista.IsNullable = false;
				colvarTelefonista.IsPrimaryKey = false;
				colvarTelefonista.IsForeignKey = false;
				colvarTelefonista.IsReadOnly = false;
				
						colvarTelefonista.DefaultSetting = @"('')";
				colvarTelefonista.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelefonista);
				
				TableSchema.TableColumn colvarHoraRLlamado1 = new TableSchema.TableColumn(schema);
				colvarHoraRLlamado1.ColumnName = "horaRLlamado1";
				colvarHoraRLlamado1.DataType = DbType.AnsiStringFixedLength;
				colvarHoraRLlamado1.MaxLength = 5;
				colvarHoraRLlamado1.AutoIncrement = false;
				colvarHoraRLlamado1.IsNullable = false;
				colvarHoraRLlamado1.IsPrimaryKey = false;
				colvarHoraRLlamado1.IsForeignKey = false;
				colvarHoraRLlamado1.IsReadOnly = false;
				
						colvarHoraRLlamado1.DefaultSetting = @"((0))";
				colvarHoraRLlamado1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHoraRLlamado1);
				
				TableSchema.TableColumn colvarHoraRLlamado = new TableSchema.TableColumn(schema);
				colvarHoraRLlamado.ColumnName = "horaRLlamado";
				colvarHoraRLlamado.DataType = DbType.DateTime;
				colvarHoraRLlamado.MaxLength = 0;
				colvarHoraRLlamado.AutoIncrement = false;
				colvarHoraRLlamado.IsNullable = false;
				colvarHoraRLlamado.IsPrimaryKey = false;
				colvarHoraRLlamado.IsForeignKey = false;
				colvarHoraRLlamado.IsReadOnly = false;
				
						colvarHoraRLlamado.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarHoraRLlamado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHoraRLlamado);
				
				TableSchema.TableColumn colvarHoraSAmbulacia = new TableSchema.TableColumn(schema);
				colvarHoraSAmbulacia.ColumnName = "horaSAmbulacia";
				colvarHoraSAmbulacia.DataType = DbType.AnsiStringFixedLength;
				colvarHoraSAmbulacia.MaxLength = 5;
				colvarHoraSAmbulacia.AutoIncrement = false;
				colvarHoraSAmbulacia.IsNullable = false;
				colvarHoraSAmbulacia.IsPrimaryKey = false;
				colvarHoraSAmbulacia.IsForeignKey = false;
				colvarHoraSAmbulacia.IsReadOnly = false;
				
						colvarHoraSAmbulacia.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarHoraSAmbulacia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHoraSAmbulacia);
				
				TableSchema.TableColumn colvarHoraLlHospital = new TableSchema.TableColumn(schema);
				colvarHoraLlHospital.ColumnName = "horaLlHospital";
				colvarHoraLlHospital.DataType = DbType.AnsiStringFixedLength;
				colvarHoraLlHospital.MaxLength = 5;
				colvarHoraLlHospital.AutoIncrement = false;
				colvarHoraLlHospital.IsNullable = false;
				colvarHoraLlHospital.IsPrimaryKey = false;
				colvarHoraLlHospital.IsForeignKey = false;
				colvarHoraLlHospital.IsReadOnly = false;
				
						colvarHoraLlHospital.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarHoraLlHospital.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHoraLlHospital);
				
				TableSchema.TableColumn colvarParticular = new TableSchema.TableColumn(schema);
				colvarParticular.ColumnName = "particular";
				colvarParticular.DataType = DbType.AnsiString;
				colvarParticular.MaxLength = 200;
				colvarParticular.AutoIncrement = false;
				colvarParticular.IsNullable = false;
				colvarParticular.IsPrimaryKey = false;
				colvarParticular.IsForeignKey = false;
				colvarParticular.IsReadOnly = false;
				
						colvarParticular.DefaultSetting = @"('')";
				colvarParticular.ForeignKeyTableName = "";
				schema.Columns.Add(colvarParticular);
				
				TableSchema.TableColumn colvarCom = new TableSchema.TableColumn(schema);
				colvarCom.ColumnName = "com";
				colvarCom.DataType = DbType.Boolean;
				colvarCom.MaxLength = 0;
				colvarCom.AutoIncrement = false;
				colvarCom.IsNullable = false;
				colvarCom.IsPrimaryKey = false;
				colvarCom.IsForeignKey = false;
				colvarCom.IsReadOnly = false;
				
						colvarCom.DefaultSetting = @"((0))";
				colvarCom.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCom);
				
				TableSchema.TableColumn colvarCam = new TableSchema.TableColumn(schema);
				colvarCam.ColumnName = "cam";
				colvarCam.DataType = DbType.Boolean;
				colvarCam.MaxLength = 0;
				colvarCam.AutoIncrement = false;
				colvarCam.IsNullable = false;
				colvarCam.IsPrimaryKey = false;
				colvarCam.IsForeignKey = false;
				colvarCam.IsReadOnly = false;
				
						colvarCam.DefaultSetting = @"((0))";
				colvarCam.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCam);
				
				TableSchema.TableColumn colvarBomb = new TableSchema.TableColumn(schema);
				colvarBomb.ColumnName = "bomb";
				colvarBomb.DataType = DbType.Boolean;
				colvarBomb.MaxLength = 0;
				colvarBomb.AutoIncrement = false;
				colvarBomb.IsNullable = false;
				colvarBomb.IsPrimaryKey = false;
				colvarBomb.IsForeignKey = false;
				colvarBomb.IsReadOnly = false;
				
						colvarBomb.DefaultSetting = @"((0))";
				colvarBomb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBomb);
				
				TableSchema.TableColumn colvarDCiv = new TableSchema.TableColumn(schema);
				colvarDCiv.ColumnName = "dCiv";
				colvarDCiv.DataType = DbType.Boolean;
				colvarDCiv.MaxLength = 0;
				colvarDCiv.AutoIncrement = false;
				colvarDCiv.IsNullable = false;
				colvarDCiv.IsPrimaryKey = false;
				colvarDCiv.IsForeignKey = false;
				colvarDCiv.IsReadOnly = false;
				
						colvarDCiv.DefaultSetting = @"((0))";
				colvarDCiv.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDCiv);
				
				TableSchema.TableColumn colvarGend = new TableSchema.TableColumn(schema);
				colvarGend.ColumnName = "gend";
				colvarGend.DataType = DbType.Boolean;
				colvarGend.MaxLength = 0;
				colvarGend.AutoIncrement = false;
				colvarGend.IsNullable = false;
				colvarGend.IsPrimaryKey = false;
				colvarGend.IsForeignKey = false;
				colvarGend.IsReadOnly = false;
				
						colvarGend.DefaultSetting = @"((0))";
				colvarGend.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGend);
				
				TableSchema.TableColumn colvarEsc = new TableSchema.TableColumn(schema);
				colvarEsc.ColumnName = "esc";
				colvarEsc.DataType = DbType.Boolean;
				colvarEsc.MaxLength = 0;
				colvarEsc.AutoIncrement = false;
				colvarEsc.IsNullable = false;
				colvarEsc.IsPrimaryKey = false;
				colvarEsc.IsForeignKey = false;
				colvarEsc.IsReadOnly = false;
				
						colvarEsc.DefaultSetting = @"((0))";
				colvarEsc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEsc);
				
				TableSchema.TableColumn colvarEjer = new TableSchema.TableColumn(schema);
				colvarEjer.ColumnName = "ejer";
				colvarEjer.DataType = DbType.Boolean;
				colvarEjer.MaxLength = 0;
				colvarEjer.AutoIncrement = false;
				colvarEjer.IsNullable = false;
				colvarEjer.IsPrimaryKey = false;
				colvarEjer.IsForeignKey = false;
				colvarEjer.IsReadOnly = false;
				
						colvarEjer.DefaultSetting = @"((0))";
				colvarEjer.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEjer);
				
				TableSchema.TableColumn colvarOtro = new TableSchema.TableColumn(schema);
				colvarOtro.ColumnName = "otro";
				colvarOtro.DataType = DbType.Boolean;
				colvarOtro.MaxLength = 0;
				colvarOtro.AutoIncrement = false;
				colvarOtro.IsNullable = false;
				colvarOtro.IsPrimaryKey = false;
				colvarOtro.IsForeignKey = false;
				colvarOtro.IsReadOnly = false;
				
						colvarOtro.DefaultSetting = @"((0))";
				colvarOtro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtro);
				
				TableSchema.TableColumn colvarEdadAnciano = new TableSchema.TableColumn(schema);
				colvarEdadAnciano.ColumnName = "edadAnciano";
				colvarEdadAnciano.DataType = DbType.Int32;
				colvarEdadAnciano.MaxLength = 0;
				colvarEdadAnciano.AutoIncrement = false;
				colvarEdadAnciano.IsNullable = false;
				colvarEdadAnciano.IsPrimaryKey = false;
				colvarEdadAnciano.IsForeignKey = false;
				colvarEdadAnciano.IsReadOnly = false;
				
						colvarEdadAnciano.DefaultSetting = @"((0))";
				colvarEdadAnciano.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEdadAnciano);
				
				TableSchema.TableColumn colvarEdadJoven = new TableSchema.TableColumn(schema);
				colvarEdadJoven.ColumnName = "edadJoven";
				colvarEdadJoven.DataType = DbType.Int32;
				colvarEdadJoven.MaxLength = 0;
				colvarEdadJoven.AutoIncrement = false;
				colvarEdadJoven.IsNullable = false;
				colvarEdadJoven.IsPrimaryKey = false;
				colvarEdadJoven.IsForeignKey = false;
				colvarEdadJoven.IsReadOnly = false;
				
						colvarEdadJoven.DefaultSetting = @"((0))";
				colvarEdadJoven.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEdadJoven);
				
				TableSchema.TableColumn colvarEdadNinio = new TableSchema.TableColumn(schema);
				colvarEdadNinio.ColumnName = "edadNinio";
				colvarEdadNinio.DataType = DbType.Int32;
				colvarEdadNinio.MaxLength = 0;
				colvarEdadNinio.AutoIncrement = false;
				colvarEdadNinio.IsNullable = false;
				colvarEdadNinio.IsPrimaryKey = false;
				colvarEdadNinio.IsForeignKey = false;
				colvarEdadNinio.IsReadOnly = false;
				
						colvarEdadNinio.DefaultSetting = @"((0))";
				colvarEdadNinio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEdadNinio);
				
				TableSchema.TableColumn colvarEdadAdulto = new TableSchema.TableColumn(schema);
				colvarEdadAdulto.ColumnName = "edadAdulto";
				colvarEdadAdulto.DataType = DbType.Int32;
				colvarEdadAdulto.MaxLength = 0;
				colvarEdadAdulto.AutoIncrement = false;
				colvarEdadAdulto.IsNullable = false;
				colvarEdadAdulto.IsPrimaryKey = false;
				colvarEdadAdulto.IsForeignKey = false;
				colvarEdadAdulto.IsReadOnly = false;
				
						colvarEdadAdulto.DefaultSetting = @"((0))";
				colvarEdadAdulto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEdadAdulto);
				
				TableSchema.TableColumn colvarEdadEmbarazada = new TableSchema.TableColumn(schema);
				colvarEdadEmbarazada.ColumnName = "edadEmbarazada";
				colvarEdadEmbarazada.DataType = DbType.Int32;
				colvarEdadEmbarazada.MaxLength = 0;
				colvarEdadEmbarazada.AutoIncrement = false;
				colvarEdadEmbarazada.IsNullable = false;
				colvarEdadEmbarazada.IsPrimaryKey = false;
				colvarEdadEmbarazada.IsForeignKey = false;
				colvarEdadEmbarazada.IsReadOnly = false;
				
						colvarEdadEmbarazada.DefaultSetting = @"((0))";
				colvarEdadEmbarazada.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEdadEmbarazada);
				
				TableSchema.TableColumn colvarProblema1 = new TableSchema.TableColumn(schema);
				colvarProblema1.ColumnName = "problema1";
				colvarProblema1.DataType = DbType.Boolean;
				colvarProblema1.MaxLength = 0;
				colvarProblema1.AutoIncrement = false;
				colvarProblema1.IsNullable = false;
				colvarProblema1.IsPrimaryKey = false;
				colvarProblema1.IsForeignKey = false;
				colvarProblema1.IsReadOnly = false;
				
						colvarProblema1.DefaultSetting = @"((0))";
				colvarProblema1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema1);
				
				TableSchema.TableColumn colvarProblema2 = new TableSchema.TableColumn(schema);
				colvarProblema2.ColumnName = "problema2";
				colvarProblema2.DataType = DbType.Boolean;
				colvarProblema2.MaxLength = 0;
				colvarProblema2.AutoIncrement = false;
				colvarProblema2.IsNullable = false;
				colvarProblema2.IsPrimaryKey = false;
				colvarProblema2.IsForeignKey = false;
				colvarProblema2.IsReadOnly = false;
				
						colvarProblema2.DefaultSetting = @"((0))";
				colvarProblema2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema2);
				
				TableSchema.TableColumn colvarProblema3 = new TableSchema.TableColumn(schema);
				colvarProblema3.ColumnName = "problema3";
				colvarProblema3.DataType = DbType.Boolean;
				colvarProblema3.MaxLength = 0;
				colvarProblema3.AutoIncrement = false;
				colvarProblema3.IsNullable = false;
				colvarProblema3.IsPrimaryKey = false;
				colvarProblema3.IsForeignKey = false;
				colvarProblema3.IsReadOnly = false;
				
						colvarProblema3.DefaultSetting = @"((0))";
				colvarProblema3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema3);
				
				TableSchema.TableColumn colvarProblema4 = new TableSchema.TableColumn(schema);
				colvarProblema4.ColumnName = "problema4";
				colvarProblema4.DataType = DbType.Boolean;
				colvarProblema4.MaxLength = 0;
				colvarProblema4.AutoIncrement = false;
				colvarProblema4.IsNullable = false;
				colvarProblema4.IsPrimaryKey = false;
				colvarProblema4.IsForeignKey = false;
				colvarProblema4.IsReadOnly = false;
				
						colvarProblema4.DefaultSetting = @"((0))";
				colvarProblema4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema4);
				
				TableSchema.TableColumn colvarProblema5 = new TableSchema.TableColumn(schema);
				colvarProblema5.ColumnName = "problema5";
				colvarProblema5.DataType = DbType.Boolean;
				colvarProblema5.MaxLength = 0;
				colvarProblema5.AutoIncrement = false;
				colvarProblema5.IsNullable = false;
				colvarProblema5.IsPrimaryKey = false;
				colvarProblema5.IsForeignKey = false;
				colvarProblema5.IsReadOnly = false;
				
						colvarProblema5.DefaultSetting = @"((0))";
				colvarProblema5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema5);
				
				TableSchema.TableColumn colvarProblema6 = new TableSchema.TableColumn(schema);
				colvarProblema6.ColumnName = "problema6";
				colvarProblema6.DataType = DbType.Boolean;
				colvarProblema6.MaxLength = 0;
				colvarProblema6.AutoIncrement = false;
				colvarProblema6.IsNullable = false;
				colvarProblema6.IsPrimaryKey = false;
				colvarProblema6.IsForeignKey = false;
				colvarProblema6.IsReadOnly = false;
				
						colvarProblema6.DefaultSetting = @"((0))";
				colvarProblema6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema6);
				
				TableSchema.TableColumn colvarProblema7 = new TableSchema.TableColumn(schema);
				colvarProblema7.ColumnName = "problema7";
				colvarProblema7.DataType = DbType.Boolean;
				colvarProblema7.MaxLength = 0;
				colvarProblema7.AutoIncrement = false;
				colvarProblema7.IsNullable = false;
				colvarProblema7.IsPrimaryKey = false;
				colvarProblema7.IsForeignKey = false;
				colvarProblema7.IsReadOnly = false;
				
						colvarProblema7.DefaultSetting = @"((0))";
				colvarProblema7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema7);
				
				TableSchema.TableColumn colvarProblema8 = new TableSchema.TableColumn(schema);
				colvarProblema8.ColumnName = "problema8";
				colvarProblema8.DataType = DbType.Boolean;
				colvarProblema8.MaxLength = 0;
				colvarProblema8.AutoIncrement = false;
				colvarProblema8.IsNullable = false;
				colvarProblema8.IsPrimaryKey = false;
				colvarProblema8.IsForeignKey = false;
				colvarProblema8.IsReadOnly = false;
				
						colvarProblema8.DefaultSetting = @"((0))";
				colvarProblema8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema8);
				
				TableSchema.TableColumn colvarProblema9 = new TableSchema.TableColumn(schema);
				colvarProblema9.ColumnName = "problema9";
				colvarProblema9.DataType = DbType.Boolean;
				colvarProblema9.MaxLength = 0;
				colvarProblema9.AutoIncrement = false;
				colvarProblema9.IsNullable = false;
				colvarProblema9.IsPrimaryKey = false;
				colvarProblema9.IsForeignKey = false;
				colvarProblema9.IsReadOnly = false;
				
						colvarProblema9.DefaultSetting = @"((0))";
				colvarProblema9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema9);
				
				TableSchema.TableColumn colvarIntoxicacion = new TableSchema.TableColumn(schema);
				colvarIntoxicacion.ColumnName = "intoxicacion";
				colvarIntoxicacion.DataType = DbType.AnsiString;
				colvarIntoxicacion.MaxLength = 20;
				colvarIntoxicacion.AutoIncrement = false;
				colvarIntoxicacion.IsNullable = false;
				colvarIntoxicacion.IsPrimaryKey = false;
				colvarIntoxicacion.IsForeignKey = false;
				colvarIntoxicacion.IsReadOnly = false;
				
						colvarIntoxicacion.DefaultSetting = @"('')";
				colvarIntoxicacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIntoxicacion);
				
				TableSchema.TableColumn colvarProblema10 = new TableSchema.TableColumn(schema);
				colvarProblema10.ColumnName = "problema10";
				colvarProblema10.DataType = DbType.Boolean;
				colvarProblema10.MaxLength = 0;
				colvarProblema10.AutoIncrement = false;
				colvarProblema10.IsNullable = false;
				colvarProblema10.IsPrimaryKey = false;
				colvarProblema10.IsForeignKey = false;
				colvarProblema10.IsReadOnly = false;
				
						colvarProblema10.DefaultSetting = @"((0))";
				colvarProblema10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema10);
				
				TableSchema.TableColumn colvarProblema11 = new TableSchema.TableColumn(schema);
				colvarProblema11.ColumnName = "problema11";
				colvarProblema11.DataType = DbType.Boolean;
				colvarProblema11.MaxLength = 0;
				colvarProblema11.AutoIncrement = false;
				colvarProblema11.IsNullable = false;
				colvarProblema11.IsPrimaryKey = false;
				colvarProblema11.IsForeignKey = false;
				colvarProblema11.IsReadOnly = false;
				
						colvarProblema11.DefaultSetting = @"((0))";
				colvarProblema11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema11);
				
				TableSchema.TableColumn colvarProblema12 = new TableSchema.TableColumn(schema);
				colvarProblema12.ColumnName = "problema12";
				colvarProblema12.DataType = DbType.Boolean;
				colvarProblema12.MaxLength = 0;
				colvarProblema12.AutoIncrement = false;
				colvarProblema12.IsNullable = false;
				colvarProblema12.IsPrimaryKey = false;
				colvarProblema12.IsForeignKey = false;
				colvarProblema12.IsReadOnly = false;
				
						colvarProblema12.DefaultSetting = @"((0))";
				colvarProblema12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema12);
				
				TableSchema.TableColumn colvarProblema13 = new TableSchema.TableColumn(schema);
				colvarProblema13.ColumnName = "problema13";
				colvarProblema13.DataType = DbType.Boolean;
				colvarProblema13.MaxLength = 0;
				colvarProblema13.AutoIncrement = false;
				colvarProblema13.IsNullable = false;
				colvarProblema13.IsPrimaryKey = false;
				colvarProblema13.IsForeignKey = false;
				colvarProblema13.IsReadOnly = false;
				
						colvarProblema13.DefaultSetting = @"((0))";
				colvarProblema13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProblema13);
				
				TableSchema.TableColumn colvarTraumatismo = new TableSchema.TableColumn(schema);
				colvarTraumatismo.ColumnName = "traumatismo";
				colvarTraumatismo.DataType = DbType.Boolean;
				colvarTraumatismo.MaxLength = 0;
				colvarTraumatismo.AutoIncrement = false;
				colvarTraumatismo.IsNullable = false;
				colvarTraumatismo.IsPrimaryKey = false;
				colvarTraumatismo.IsForeignKey = false;
				colvarTraumatismo.IsReadOnly = false;
				
						colvarTraumatismo.DefaultSetting = @"((0))";
				colvarTraumatismo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTraumatismo);
				
				TableSchema.TableColumn colvarNroAdultos = new TableSchema.TableColumn(schema);
				colvarNroAdultos.ColumnName = "nroAdultos";
				colvarNroAdultos.DataType = DbType.Int32;
				colvarNroAdultos.MaxLength = 0;
				colvarNroAdultos.AutoIncrement = false;
				colvarNroAdultos.IsNullable = false;
				colvarNroAdultos.IsPrimaryKey = false;
				colvarNroAdultos.IsForeignKey = false;
				colvarNroAdultos.IsReadOnly = false;
				
						colvarNroAdultos.DefaultSetting = @"((0))";
				colvarNroAdultos.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNroAdultos);
				
				TableSchema.TableColumn colvarNroNinios = new TableSchema.TableColumn(schema);
				colvarNroNinios.ColumnName = "nroNinios";
				colvarNroNinios.DataType = DbType.Int32;
				colvarNroNinios.MaxLength = 0;
				colvarNroNinios.AutoIncrement = false;
				colvarNroNinios.IsNullable = false;
				colvarNroNinios.IsPrimaryKey = false;
				colvarNroNinios.IsForeignKey = false;
				colvarNroNinios.IsReadOnly = false;
				
						colvarNroNinios.DefaultSetting = @"((0))";
				colvarNroNinios.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNroNinios);
				
				TableSchema.TableColumn colvarProbAutov = new TableSchema.TableColumn(schema);
				colvarProbAutov.ColumnName = "probAutov";
				colvarProbAutov.DataType = DbType.Boolean;
				colvarProbAutov.MaxLength = 0;
				colvarProbAutov.AutoIncrement = false;
				colvarProbAutov.IsNullable = false;
				colvarProbAutov.IsPrimaryKey = false;
				colvarProbAutov.IsForeignKey = false;
				colvarProbAutov.IsReadOnly = false;
				
						colvarProbAutov.DefaultSetting = @"((0))";
				colvarProbAutov.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProbAutov);
				
				TableSchema.TableColumn colvarProbAtrop = new TableSchema.TableColumn(schema);
				colvarProbAtrop.ColumnName = "probAtrop";
				colvarProbAtrop.DataType = DbType.Boolean;
				colvarProbAtrop.MaxLength = 0;
				colvarProbAtrop.AutoIncrement = false;
				colvarProbAtrop.IsNullable = false;
				colvarProbAtrop.IsPrimaryKey = false;
				colvarProbAtrop.IsForeignKey = false;
				colvarProbAtrop.IsReadOnly = false;
				
						colvarProbAtrop.DefaultSetting = @"((0))";
				colvarProbAtrop.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProbAtrop);
				
				TableSchema.TableColumn colvarProbCol = new TableSchema.TableColumn(schema);
				colvarProbCol.ColumnName = "probCol";
				colvarProbCol.DataType = DbType.Boolean;
				colvarProbCol.MaxLength = 0;
				colvarProbCol.AutoIncrement = false;
				colvarProbCol.IsNullable = false;
				colvarProbCol.IsPrimaryKey = false;
				colvarProbCol.IsForeignKey = false;
				colvarProbCol.IsReadOnly = false;
				
						colvarProbCol.DefaultSetting = @"((0))";
				colvarProbCol.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProbCol);
				
				TableSchema.TableColumn colvarProbDesb = new TableSchema.TableColumn(schema);
				colvarProbDesb.ColumnName = "probDesb";
				colvarProbDesb.DataType = DbType.Boolean;
				colvarProbDesb.MaxLength = 0;
				colvarProbDesb.AutoIncrement = false;
				colvarProbDesb.IsNullable = false;
				colvarProbDesb.IsPrimaryKey = false;
				colvarProbDesb.IsForeignKey = false;
				colvarProbDesb.IsReadOnly = false;
				
						colvarProbDesb.DefaultSetting = @"((0))";
				colvarProbDesb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProbDesb);
				
				TableSchema.TableColumn colvarProbIncen = new TableSchema.TableColumn(schema);
				colvarProbIncen.ColumnName = "probIncen";
				colvarProbIncen.DataType = DbType.Boolean;
				colvarProbIncen.MaxLength = 0;
				colvarProbIncen.AutoIncrement = false;
				colvarProbIncen.IsNullable = false;
				colvarProbIncen.IsPrimaryKey = false;
				colvarProbIncen.IsForeignKey = false;
				colvarProbIncen.IsReadOnly = false;
				
						colvarProbIncen.DefaultSetting = @"((0))";
				colvarProbIncen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProbIncen);
				
				TableSchema.TableColumn colvarProbIntox = new TableSchema.TableColumn(schema);
				colvarProbIntox.ColumnName = "probIntox";
				colvarProbIntox.DataType = DbType.Boolean;
				colvarProbIntox.MaxLength = 0;
				colvarProbIntox.AutoIncrement = false;
				colvarProbIntox.IsNullable = false;
				colvarProbIntox.IsPrimaryKey = false;
				colvarProbIntox.IsForeignKey = false;
				colvarProbIntox.IsReadOnly = false;
				
						colvarProbIntox.DefaultSetting = @"((0))";
				colvarProbIntox.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProbIntox);
				
				TableSchema.TableColumn colvarProbNoIdent = new TableSchema.TableColumn(schema);
				colvarProbNoIdent.ColumnName = "probNoIdent";
				colvarProbNoIdent.DataType = DbType.Boolean;
				colvarProbNoIdent.MaxLength = 0;
				colvarProbNoIdent.AutoIncrement = false;
				colvarProbNoIdent.IsNullable = false;
				colvarProbNoIdent.IsPrimaryKey = false;
				colvarProbNoIdent.IsForeignKey = false;
				colvarProbNoIdent.IsReadOnly = false;
				
						colvarProbNoIdent.DefaultSetting = @"((0))";
				colvarProbNoIdent.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProbNoIdent);
				
				TableSchema.TableColumn colvarAcv = new TableSchema.TableColumn(schema);
				colvarAcv.ColumnName = "acv";
				colvarAcv.DataType = DbType.Boolean;
				colvarAcv.MaxLength = 0;
				colvarAcv.AutoIncrement = false;
				colvarAcv.IsNullable = false;
				colvarAcv.IsPrimaryKey = false;
				colvarAcv.IsForeignKey = false;
				colvarAcv.IsReadOnly = false;
				
						colvarAcv.DefaultSetting = @"((0))";
				colvarAcv.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAcv);
				
				TableSchema.TableColumn colvarFiebre = new TableSchema.TableColumn(schema);
				colvarFiebre.ColumnName = "fiebre";
				colvarFiebre.DataType = DbType.Boolean;
				colvarFiebre.MaxLength = 0;
				colvarFiebre.AutoIncrement = false;
				colvarFiebre.IsNullable = false;
				colvarFiebre.IsPrimaryKey = false;
				colvarFiebre.IsForeignKey = false;
				colvarFiebre.IsReadOnly = false;
				
						colvarFiebre.DefaultSetting = @"((0))";
				colvarFiebre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFiebre);
				
				TableSchema.TableColumn colvarVomito = new TableSchema.TableColumn(schema);
				colvarVomito.ColumnName = "vomito";
				colvarVomito.DataType = DbType.Boolean;
				colvarVomito.MaxLength = 0;
				colvarVomito.AutoIncrement = false;
				colvarVomito.IsNullable = false;
				colvarVomito.IsPrimaryKey = false;
				colvarVomito.IsForeignKey = false;
				colvarVomito.IsReadOnly = false;
				
						colvarVomito.DefaultSetting = @"((0))";
				colvarVomito.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVomito);
				
				TableSchema.TableColumn colvarDolor = new TableSchema.TableColumn(schema);
				colvarDolor.ColumnName = "dolor";
				colvarDolor.DataType = DbType.AnsiString;
				colvarDolor.MaxLength = 50;
				colvarDolor.AutoIncrement = false;
				colvarDolor.IsNullable = false;
				colvarDolor.IsPrimaryKey = false;
				colvarDolor.IsForeignKey = false;
				colvarDolor.IsReadOnly = false;
				
						colvarDolor.DefaultSetting = @"('')";
				colvarDolor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDolor);
				
				TableSchema.TableColumn colvarQuemado = new TableSchema.TableColumn(schema);
				colvarQuemado.ColumnName = "quemado";
				colvarQuemado.DataType = DbType.Boolean;
				colvarQuemado.MaxLength = 0;
				colvarQuemado.AutoIncrement = false;
				colvarQuemado.IsNullable = false;
				colvarQuemado.IsPrimaryKey = false;
				colvarQuemado.IsForeignKey = false;
				colvarQuemado.IsReadOnly = false;
				
						colvarQuemado.DefaultSetting = @"((0))";
				colvarQuemado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarQuemado);
				
				TableSchema.TableColumn colvarIngestioncuerpoext = new TableSchema.TableColumn(schema);
				colvarIngestioncuerpoext.ColumnName = "ingestioncuerpoext";
				colvarIngestioncuerpoext.DataType = DbType.Boolean;
				colvarIngestioncuerpoext.MaxLength = 0;
				colvarIngestioncuerpoext.AutoIncrement = false;
				colvarIngestioncuerpoext.IsNullable = false;
				colvarIngestioncuerpoext.IsPrimaryKey = false;
				colvarIngestioncuerpoext.IsForeignKey = false;
				colvarIngestioncuerpoext.IsReadOnly = false;
				
						colvarIngestioncuerpoext.DefaultSetting = @"((0))";
				colvarIngestioncuerpoext.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIngestioncuerpoext);
				
				TableSchema.TableColumn colvarAgresion = new TableSchema.TableColumn(schema);
				colvarAgresion.ColumnName = "agresion";
				colvarAgresion.DataType = DbType.Boolean;
				colvarAgresion.MaxLength = 0;
				colvarAgresion.AutoIncrement = false;
				colvarAgresion.IsNullable = false;
				colvarAgresion.IsPrimaryKey = false;
				colvarAgresion.IsForeignKey = false;
				colvarAgresion.IsReadOnly = false;
				
						colvarAgresion.DefaultSetting = @"((0))";
				colvarAgresion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAgresion);
				
				TableSchema.TableColumn colvarTraumaCraneo = new TableSchema.TableColumn(schema);
				colvarTraumaCraneo.ColumnName = "traumaCraneo";
				colvarTraumaCraneo.DataType = DbType.Boolean;
				colvarTraumaCraneo.MaxLength = 0;
				colvarTraumaCraneo.AutoIncrement = false;
				colvarTraumaCraneo.IsNullable = false;
				colvarTraumaCraneo.IsPrimaryKey = false;
				colvarTraumaCraneo.IsForeignKey = false;
				colvarTraumaCraneo.IsReadOnly = false;
				
						colvarTraumaCraneo.DefaultSetting = @"((0))";
				colvarTraumaCraneo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTraumaCraneo);
				
				TableSchema.TableColumn colvarTraumaCuello = new TableSchema.TableColumn(schema);
				colvarTraumaCuello.ColumnName = "traumaCuello";
				colvarTraumaCuello.DataType = DbType.Boolean;
				colvarTraumaCuello.MaxLength = 0;
				colvarTraumaCuello.AutoIncrement = false;
				colvarTraumaCuello.IsNullable = false;
				colvarTraumaCuello.IsPrimaryKey = false;
				colvarTraumaCuello.IsForeignKey = false;
				colvarTraumaCuello.IsReadOnly = false;
				
						colvarTraumaCuello.DefaultSetting = @"((0))";
				colvarTraumaCuello.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTraumaCuello);
				
				TableSchema.TableColumn colvarTraumaTorax = new TableSchema.TableColumn(schema);
				colvarTraumaTorax.ColumnName = "traumaTorax";
				colvarTraumaTorax.DataType = DbType.Boolean;
				colvarTraumaTorax.MaxLength = 0;
				colvarTraumaTorax.AutoIncrement = false;
				colvarTraumaTorax.IsNullable = false;
				colvarTraumaTorax.IsPrimaryKey = false;
				colvarTraumaTorax.IsForeignKey = false;
				colvarTraumaTorax.IsReadOnly = false;
				
						colvarTraumaTorax.DefaultSetting = @"((0))";
				colvarTraumaTorax.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTraumaTorax);
				
				TableSchema.TableColumn colvarTraumaAbdomen = new TableSchema.TableColumn(schema);
				colvarTraumaAbdomen.ColumnName = "traumaAbdomen";
				colvarTraumaAbdomen.DataType = DbType.Boolean;
				colvarTraumaAbdomen.MaxLength = 0;
				colvarTraumaAbdomen.AutoIncrement = false;
				colvarTraumaAbdomen.IsNullable = false;
				colvarTraumaAbdomen.IsPrimaryKey = false;
				colvarTraumaAbdomen.IsForeignKey = false;
				colvarTraumaAbdomen.IsReadOnly = false;
				
						colvarTraumaAbdomen.DefaultSetting = @"((0))";
				colvarTraumaAbdomen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTraumaAbdomen);
				
				TableSchema.TableColumn colvarTraumaMiembros = new TableSchema.TableColumn(schema);
				colvarTraumaMiembros.ColumnName = "traumaMiembros";
				colvarTraumaMiembros.DataType = DbType.Boolean;
				colvarTraumaMiembros.MaxLength = 0;
				colvarTraumaMiembros.AutoIncrement = false;
				colvarTraumaMiembros.IsNullable = false;
				colvarTraumaMiembros.IsPrimaryKey = false;
				colvarTraumaMiembros.IsForeignKey = false;
				colvarTraumaMiembros.IsReadOnly = false;
				
						colvarTraumaMiembros.DefaultSetting = @"((0))";
				colvarTraumaMiembros.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTraumaMiembros);
				
				TableSchema.TableColumn colvarTraumaPelvis = new TableSchema.TableColumn(schema);
				colvarTraumaPelvis.ColumnName = "traumaPelvis";
				colvarTraumaPelvis.DataType = DbType.Boolean;
				colvarTraumaPelvis.MaxLength = 0;
				colvarTraumaPelvis.AutoIncrement = false;
				colvarTraumaPelvis.IsNullable = false;
				colvarTraumaPelvis.IsPrimaryKey = false;
				colvarTraumaPelvis.IsForeignKey = false;
				colvarTraumaPelvis.IsReadOnly = false;
				
						colvarTraumaPelvis.DefaultSetting = @"((0))";
				colvarTraumaPelvis.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTraumaPelvis);
				
				TableSchema.TableColumn colvarCalle = new TableSchema.TableColumn(schema);
				colvarCalle.ColumnName = "calle";
				colvarCalle.DataType = DbType.AnsiString;
				colvarCalle.MaxLength = 200;
				colvarCalle.AutoIncrement = false;
				colvarCalle.IsNullable = false;
				colvarCalle.IsPrimaryKey = false;
				colvarCalle.IsForeignKey = false;
				colvarCalle.IsReadOnly = false;
				
						colvarCalle.DefaultSetting = @"('')";
				colvarCalle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCalle);
				
				TableSchema.TableColumn colvarNumero = new TableSchema.TableColumn(schema);
				colvarNumero.ColumnName = "numero";
				colvarNumero.DataType = DbType.Int32;
				colvarNumero.MaxLength = 0;
				colvarNumero.AutoIncrement = false;
				colvarNumero.IsNullable = false;
				colvarNumero.IsPrimaryKey = false;
				colvarNumero.IsForeignKey = false;
				colvarNumero.IsReadOnly = false;
				
						colvarNumero.DefaultSetting = @"((0))";
				colvarNumero.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumero);
				
				TableSchema.TableColumn colvarEntreCalles = new TableSchema.TableColumn(schema);
				colvarEntreCalles.ColumnName = "entreCalles";
				colvarEntreCalles.DataType = DbType.AnsiString;
				colvarEntreCalles.MaxLength = 200;
				colvarEntreCalles.AutoIncrement = false;
				colvarEntreCalles.IsNullable = false;
				colvarEntreCalles.IsPrimaryKey = false;
				colvarEntreCalles.IsForeignKey = false;
				colvarEntreCalles.IsReadOnly = false;
				
						colvarEntreCalles.DefaultSetting = @"('')";
				colvarEntreCalles.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEntreCalles);
				
				TableSchema.TableColumn colvarRuta = new TableSchema.TableColumn(schema);
				colvarRuta.ColumnName = "ruta";
				colvarRuta.DataType = DbType.AnsiStringFixedLength;
				colvarRuta.MaxLength = 10;
				colvarRuta.AutoIncrement = false;
				colvarRuta.IsNullable = false;
				colvarRuta.IsPrimaryKey = false;
				colvarRuta.IsForeignKey = false;
				colvarRuta.IsReadOnly = false;
				
						colvarRuta.DefaultSetting = @"('')";
				colvarRuta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRuta);
				
				TableSchema.TableColumn colvarKm = new TableSchema.TableColumn(schema);
				colvarKm.ColumnName = "km";
				colvarKm.DataType = DbType.Int32;
				colvarKm.MaxLength = 0;
				colvarKm.AutoIncrement = false;
				colvarKm.IsNullable = false;
				colvarKm.IsPrimaryKey = false;
				colvarKm.IsForeignKey = false;
				colvarKm.IsReadOnly = false;
				
						colvarKm.DefaultSetting = @"((0))";
				colvarKm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKm);
				
				TableSchema.TableColumn colvarCercade = new TableSchema.TableColumn(schema);
				colvarCercade.ColumnName = "cercade";
				colvarCercade.DataType = DbType.AnsiString;
				colvarCercade.MaxLength = 200;
				colvarCercade.AutoIncrement = false;
				colvarCercade.IsNullable = false;
				colvarCercade.IsPrimaryKey = false;
				colvarCercade.IsForeignKey = false;
				colvarCercade.IsReadOnly = false;
				
						colvarCercade.DefaultSetting = @"('')";
				colvarCercade.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCercade);
				
				TableSchema.TableColumn colvarParaje = new TableSchema.TableColumn(schema);
				colvarParaje.ColumnName = "paraje";
				colvarParaje.DataType = DbType.AnsiString;
				colvarParaje.MaxLength = 200;
				colvarParaje.AutoIncrement = false;
				colvarParaje.IsNullable = false;
				colvarParaje.IsPrimaryKey = false;
				colvarParaje.IsForeignKey = false;
				colvarParaje.IsReadOnly = false;
				
						colvarParaje.DefaultSetting = @"('')";
				colvarParaje.ForeignKeyTableName = "";
				schema.Columns.Add(colvarParaje);
				
				TableSchema.TableColumn colvarTelefono = new TableSchema.TableColumn(schema);
				colvarTelefono.ColumnName = "telefono";
				colvarTelefono.DataType = DbType.AnsiString;
				colvarTelefono.MaxLength = 50;
				colvarTelefono.AutoIncrement = false;
				colvarTelefono.IsNullable = false;
				colvarTelefono.IsPrimaryKey = false;
				colvarTelefono.IsForeignKey = false;
				colvarTelefono.IsReadOnly = false;
				
						colvarTelefono.DefaultSetting = @"('')";
				colvarTelefono.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelefono);
				
				TableSchema.TableColumn colvarDiagnostico1 = new TableSchema.TableColumn(schema);
				colvarDiagnostico1.ColumnName = "diagnostico1";
				colvarDiagnostico1.DataType = DbType.AnsiString;
				colvarDiagnostico1.MaxLength = 500;
				colvarDiagnostico1.AutoIncrement = false;
				colvarDiagnostico1.IsNullable = false;
				colvarDiagnostico1.IsPrimaryKey = false;
				colvarDiagnostico1.IsForeignKey = false;
				colvarDiagnostico1.IsReadOnly = false;
				
						colvarDiagnostico1.DefaultSetting = @"('')";
				colvarDiagnostico1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDiagnostico1);
				
				TableSchema.TableColumn colvarDiagnostico2 = new TableSchema.TableColumn(schema);
				colvarDiagnostico2.ColumnName = "diagnostico2";
				colvarDiagnostico2.DataType = DbType.AnsiString;
				colvarDiagnostico2.MaxLength = 500;
				colvarDiagnostico2.AutoIncrement = false;
				colvarDiagnostico2.IsNullable = false;
				colvarDiagnostico2.IsPrimaryKey = false;
				colvarDiagnostico2.IsForeignKey = false;
				colvarDiagnostico2.IsReadOnly = false;
				
						colvarDiagnostico2.DefaultSetting = @"('')";
				colvarDiagnostico2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDiagnostico2);
				
				TableSchema.TableColumn colvarChofer = new TableSchema.TableColumn(schema);
				colvarChofer.ColumnName = "chofer";
				colvarChofer.DataType = DbType.AnsiString;
				colvarChofer.MaxLength = 200;
				colvarChofer.AutoIncrement = false;
				colvarChofer.IsNullable = false;
				colvarChofer.IsPrimaryKey = false;
				colvarChofer.IsForeignKey = false;
				colvarChofer.IsReadOnly = false;
				
						colvarChofer.DefaultSetting = @"('')";
				colvarChofer.ForeignKeyTableName = "";
				schema.Columns.Add(colvarChofer);
				
				TableSchema.TableColumn colvarEnfermero = new TableSchema.TableColumn(schema);
				colvarEnfermero.ColumnName = "enfermero";
				colvarEnfermero.DataType = DbType.AnsiString;
				colvarEnfermero.MaxLength = 200;
				colvarEnfermero.AutoIncrement = false;
				colvarEnfermero.IsNullable = false;
				colvarEnfermero.IsPrimaryKey = false;
				colvarEnfermero.IsForeignKey = false;
				colvarEnfermero.IsReadOnly = false;
				
						colvarEnfermero.DefaultSetting = @"('')";
				colvarEnfermero.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEnfermero);
				
				TableSchema.TableColumn colvarCamillero = new TableSchema.TableColumn(schema);
				colvarCamillero.ColumnName = "camillero";
				colvarCamillero.DataType = DbType.AnsiString;
				colvarCamillero.MaxLength = 200;
				colvarCamillero.AutoIncrement = false;
				colvarCamillero.IsNullable = false;
				colvarCamillero.IsPrimaryKey = false;
				colvarCamillero.IsForeignKey = false;
				colvarCamillero.IsReadOnly = false;
				
						colvarCamillero.DefaultSetting = @"('')";
				colvarCamillero.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCamillero);
				
				TableSchema.TableColumn colvarMedico = new TableSchema.TableColumn(schema);
				colvarMedico.ColumnName = "medico";
				colvarMedico.DataType = DbType.AnsiString;
				colvarMedico.MaxLength = 200;
				colvarMedico.AutoIncrement = false;
				colvarMedico.IsNullable = false;
				colvarMedico.IsPrimaryKey = false;
				colvarMedico.IsForeignKey = false;
				colvarMedico.IsReadOnly = false;
				
						colvarMedico.DefaultSetting = @"('')";
				colvarMedico.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMedico);
				
				TableSchema.TableColumn colvarOperadorRecepcion = new TableSchema.TableColumn(schema);
				colvarOperadorRecepcion.ColumnName = "operadorRecepcion";
				colvarOperadorRecepcion.DataType = DbType.AnsiString;
				colvarOperadorRecepcion.MaxLength = 200;
				colvarOperadorRecepcion.AutoIncrement = false;
				colvarOperadorRecepcion.IsNullable = false;
				colvarOperadorRecepcion.IsPrimaryKey = false;
				colvarOperadorRecepcion.IsForeignKey = false;
				colvarOperadorRecepcion.IsReadOnly = false;
				
						colvarOperadorRecepcion.DefaultSetting = @"('')";
				colvarOperadorRecepcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOperadorRecepcion);
				
				TableSchema.TableColumn colvarObservacion = new TableSchema.TableColumn(schema);
				colvarObservacion.ColumnName = "observacion";
				colvarObservacion.DataType = DbType.AnsiString;
				colvarObservacion.MaxLength = 500;
				colvarObservacion.AutoIncrement = false;
				colvarObservacion.IsNullable = false;
				colvarObservacion.IsPrimaryKey = false;
				colvarObservacion.IsForeignKey = false;
				colvarObservacion.IsReadOnly = false;
				
						colvarObservacion.DefaultSetting = @"('')";
				colvarObservacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacion);
				
				TableSchema.TableColumn colvarActivo = new TableSchema.TableColumn(schema);
				colvarActivo.ColumnName = "activo";
				colvarActivo.DataType = DbType.Boolean;
				colvarActivo.MaxLength = 0;
				colvarActivo.AutoIncrement = false;
				colvarActivo.IsNullable = false;
				colvarActivo.IsPrimaryKey = false;
				colvarActivo.IsForeignKey = false;
				colvarActivo.IsReadOnly = false;
				
						colvarActivo.DefaultSetting = @"((1))";
				colvarActivo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActivo);
				
				TableSchema.TableColumn colvarIdBase = new TableSchema.TableColumn(schema);
				colvarIdBase.ColumnName = "idBase";
				colvarIdBase.DataType = DbType.Int32;
				colvarIdBase.MaxLength = 0;
				colvarIdBase.AutoIncrement = false;
				colvarIdBase.IsNullable = false;
				colvarIdBase.IsPrimaryKey = false;
				colvarIdBase.IsForeignKey = true;
				colvarIdBase.IsReadOnly = false;
				
						colvarIdBase.DefaultSetting = @"((0))";
				
					colvarIdBase.ForeignKeyTableName = "EMR_Base";
				schema.Columns.Add(colvarIdBase);
				
				TableSchema.TableColumn colvarCreatedBy = new TableSchema.TableColumn(schema);
				colvarCreatedBy.ColumnName = "CreatedBy";
				colvarCreatedBy.DataType = DbType.AnsiString;
				colvarCreatedBy.MaxLength = 50;
				colvarCreatedBy.AutoIncrement = false;
				colvarCreatedBy.IsNullable = false;
				colvarCreatedBy.IsPrimaryKey = false;
				colvarCreatedBy.IsForeignKey = false;
				colvarCreatedBy.IsReadOnly = false;
				
						colvarCreatedBy.DefaultSetting = @"('')";
				colvarCreatedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedBy);
				
				TableSchema.TableColumn colvarCreatedOn = new TableSchema.TableColumn(schema);
				colvarCreatedOn.ColumnName = "CreatedOn";
				colvarCreatedOn.DataType = DbType.DateTime;
				colvarCreatedOn.MaxLength = 0;
				colvarCreatedOn.AutoIncrement = false;
				colvarCreatedOn.IsNullable = false;
				colvarCreatedOn.IsPrimaryKey = false;
				colvarCreatedOn.IsForeignKey = false;
				colvarCreatedOn.IsReadOnly = false;
				
						colvarCreatedOn.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarCreatedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedOn);
				
				TableSchema.TableColumn colvarModifiedBy = new TableSchema.TableColumn(schema);
				colvarModifiedBy.ColumnName = "ModifiedBy";
				colvarModifiedBy.DataType = DbType.AnsiString;
				colvarModifiedBy.MaxLength = 50;
				colvarModifiedBy.AutoIncrement = false;
				colvarModifiedBy.IsNullable = false;
				colvarModifiedBy.IsPrimaryKey = false;
				colvarModifiedBy.IsForeignKey = false;
				colvarModifiedBy.IsReadOnly = false;
				
						colvarModifiedBy.DefaultSetting = @"('')";
				colvarModifiedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedBy);
				
				TableSchema.TableColumn colvarModifiedOn = new TableSchema.TableColumn(schema);
				colvarModifiedOn.ColumnName = "ModifiedOn";
				colvarModifiedOn.DataType = DbType.DateTime;
				colvarModifiedOn.MaxLength = 0;
				colvarModifiedOn.AutoIncrement = false;
				colvarModifiedOn.IsNullable = false;
				colvarModifiedOn.IsPrimaryKey = false;
				colvarModifiedOn.IsForeignKey = false;
				colvarModifiedOn.IsReadOnly = false;
				
						colvarModifiedOn.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarModifiedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedOn);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("EMR_Registro",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdEmr")]
		[Bindable(true)]
		public int IdEmr 
		{
			get { return GetColumnValue<int>(Columns.IdEmr); }
			set { SetColumnValue(Columns.IdEmr, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime Fecha 
		{
			get { return GetColumnValue<DateTime>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("Telefonista")]
		[Bindable(true)]
		public string Telefonista 
		{
			get { return GetColumnValue<string>(Columns.Telefonista); }
			set { SetColumnValue(Columns.Telefonista, value); }
		}
		  
		[XmlAttribute("HoraRLlamado1")]
		[Bindable(true)]
		public string HoraRLlamado1 
		{
			get { return GetColumnValue<string>(Columns.HoraRLlamado1); }
			set { SetColumnValue(Columns.HoraRLlamado1, value); }
		}
		  
		[XmlAttribute("HoraRLlamado")]
		[Bindable(true)]
		public DateTime HoraRLlamado 
		{
			get { return GetColumnValue<DateTime>(Columns.HoraRLlamado); }
			set { SetColumnValue(Columns.HoraRLlamado, value); }
		}
		  
		[XmlAttribute("HoraSAmbulacia")]
		[Bindable(true)]
		public string HoraSAmbulacia 
		{
			get { return GetColumnValue<string>(Columns.HoraSAmbulacia); }
			set { SetColumnValue(Columns.HoraSAmbulacia, value); }
		}
		  
		[XmlAttribute("HoraLlHospital")]
		[Bindable(true)]
		public string HoraLlHospital 
		{
			get { return GetColumnValue<string>(Columns.HoraLlHospital); }
			set { SetColumnValue(Columns.HoraLlHospital, value); }
		}
		  
		[XmlAttribute("Particular")]
		[Bindable(true)]
		public string Particular 
		{
			get { return GetColumnValue<string>(Columns.Particular); }
			set { SetColumnValue(Columns.Particular, value); }
		}
		  
		[XmlAttribute("Com")]
		[Bindable(true)]
		public bool Com 
		{
			get { return GetColumnValue<bool>(Columns.Com); }
			set { SetColumnValue(Columns.Com, value); }
		}
		  
		[XmlAttribute("Cam")]
		[Bindable(true)]
		public bool Cam 
		{
			get { return GetColumnValue<bool>(Columns.Cam); }
			set { SetColumnValue(Columns.Cam, value); }
		}
		  
		[XmlAttribute("Bomb")]
		[Bindable(true)]
		public bool Bomb 
		{
			get { return GetColumnValue<bool>(Columns.Bomb); }
			set { SetColumnValue(Columns.Bomb, value); }
		}
		  
		[XmlAttribute("DCiv")]
		[Bindable(true)]
		public bool DCiv 
		{
			get { return GetColumnValue<bool>(Columns.DCiv); }
			set { SetColumnValue(Columns.DCiv, value); }
		}
		  
		[XmlAttribute("Gend")]
		[Bindable(true)]
		public bool Gend 
		{
			get { return GetColumnValue<bool>(Columns.Gend); }
			set { SetColumnValue(Columns.Gend, value); }
		}
		  
		[XmlAttribute("Esc")]
		[Bindable(true)]
		public bool Esc 
		{
			get { return GetColumnValue<bool>(Columns.Esc); }
			set { SetColumnValue(Columns.Esc, value); }
		}
		  
		[XmlAttribute("Ejer")]
		[Bindable(true)]
		public bool Ejer 
		{
			get { return GetColumnValue<bool>(Columns.Ejer); }
			set { SetColumnValue(Columns.Ejer, value); }
		}
		  
		[XmlAttribute("Otro")]
		[Bindable(true)]
		public bool Otro 
		{
			get { return GetColumnValue<bool>(Columns.Otro); }
			set { SetColumnValue(Columns.Otro, value); }
		}
		  
		[XmlAttribute("EdadAnciano")]
		[Bindable(true)]
		public int EdadAnciano 
		{
			get { return GetColumnValue<int>(Columns.EdadAnciano); }
			set { SetColumnValue(Columns.EdadAnciano, value); }
		}
		  
		[XmlAttribute("EdadJoven")]
		[Bindable(true)]
		public int EdadJoven 
		{
			get { return GetColumnValue<int>(Columns.EdadJoven); }
			set { SetColumnValue(Columns.EdadJoven, value); }
		}
		  
		[XmlAttribute("EdadNinio")]
		[Bindable(true)]
		public int EdadNinio 
		{
			get { return GetColumnValue<int>(Columns.EdadNinio); }
			set { SetColumnValue(Columns.EdadNinio, value); }
		}
		  
		[XmlAttribute("EdadAdulto")]
		[Bindable(true)]
		public int EdadAdulto 
		{
			get { return GetColumnValue<int>(Columns.EdadAdulto); }
			set { SetColumnValue(Columns.EdadAdulto, value); }
		}
		  
		[XmlAttribute("EdadEmbarazada")]
		[Bindable(true)]
		public int EdadEmbarazada 
		{
			get { return GetColumnValue<int>(Columns.EdadEmbarazada); }
			set { SetColumnValue(Columns.EdadEmbarazada, value); }
		}
		  
		[XmlAttribute("Problema1")]
		[Bindable(true)]
		public bool Problema1 
		{
			get { return GetColumnValue<bool>(Columns.Problema1); }
			set { SetColumnValue(Columns.Problema1, value); }
		}
		  
		[XmlAttribute("Problema2")]
		[Bindable(true)]
		public bool Problema2 
		{
			get { return GetColumnValue<bool>(Columns.Problema2); }
			set { SetColumnValue(Columns.Problema2, value); }
		}
		  
		[XmlAttribute("Problema3")]
		[Bindable(true)]
		public bool Problema3 
		{
			get { return GetColumnValue<bool>(Columns.Problema3); }
			set { SetColumnValue(Columns.Problema3, value); }
		}
		  
		[XmlAttribute("Problema4")]
		[Bindable(true)]
		public bool Problema4 
		{
			get { return GetColumnValue<bool>(Columns.Problema4); }
			set { SetColumnValue(Columns.Problema4, value); }
		}
		  
		[XmlAttribute("Problema5")]
		[Bindable(true)]
		public bool Problema5 
		{
			get { return GetColumnValue<bool>(Columns.Problema5); }
			set { SetColumnValue(Columns.Problema5, value); }
		}
		  
		[XmlAttribute("Problema6")]
		[Bindable(true)]
		public bool Problema6 
		{
			get { return GetColumnValue<bool>(Columns.Problema6); }
			set { SetColumnValue(Columns.Problema6, value); }
		}
		  
		[XmlAttribute("Problema7")]
		[Bindable(true)]
		public bool Problema7 
		{
			get { return GetColumnValue<bool>(Columns.Problema7); }
			set { SetColumnValue(Columns.Problema7, value); }
		}
		  
		[XmlAttribute("Problema8")]
		[Bindable(true)]
		public bool Problema8 
		{
			get { return GetColumnValue<bool>(Columns.Problema8); }
			set { SetColumnValue(Columns.Problema8, value); }
		}
		  
		[XmlAttribute("Problema9")]
		[Bindable(true)]
		public bool Problema9 
		{
			get { return GetColumnValue<bool>(Columns.Problema9); }
			set { SetColumnValue(Columns.Problema9, value); }
		}
		  
		[XmlAttribute("Intoxicacion")]
		[Bindable(true)]
		public string Intoxicacion 
		{
			get { return GetColumnValue<string>(Columns.Intoxicacion); }
			set { SetColumnValue(Columns.Intoxicacion, value); }
		}
		  
		[XmlAttribute("Problema10")]
		[Bindable(true)]
		public bool Problema10 
		{
			get { return GetColumnValue<bool>(Columns.Problema10); }
			set { SetColumnValue(Columns.Problema10, value); }
		}
		  
		[XmlAttribute("Problema11")]
		[Bindable(true)]
		public bool Problema11 
		{
			get { return GetColumnValue<bool>(Columns.Problema11); }
			set { SetColumnValue(Columns.Problema11, value); }
		}
		  
		[XmlAttribute("Problema12")]
		[Bindable(true)]
		public bool Problema12 
		{
			get { return GetColumnValue<bool>(Columns.Problema12); }
			set { SetColumnValue(Columns.Problema12, value); }
		}
		  
		[XmlAttribute("Problema13")]
		[Bindable(true)]
		public bool Problema13 
		{
			get { return GetColumnValue<bool>(Columns.Problema13); }
			set { SetColumnValue(Columns.Problema13, value); }
		}
		  
		[XmlAttribute("Traumatismo")]
		[Bindable(true)]
		public bool Traumatismo 
		{
			get { return GetColumnValue<bool>(Columns.Traumatismo); }
			set { SetColumnValue(Columns.Traumatismo, value); }
		}
		  
		[XmlAttribute("NroAdultos")]
		[Bindable(true)]
		public int NroAdultos 
		{
			get { return GetColumnValue<int>(Columns.NroAdultos); }
			set { SetColumnValue(Columns.NroAdultos, value); }
		}
		  
		[XmlAttribute("NroNinios")]
		[Bindable(true)]
		public int NroNinios 
		{
			get { return GetColumnValue<int>(Columns.NroNinios); }
			set { SetColumnValue(Columns.NroNinios, value); }
		}
		  
		[XmlAttribute("ProbAutov")]
		[Bindable(true)]
		public bool ProbAutov 
		{
			get { return GetColumnValue<bool>(Columns.ProbAutov); }
			set { SetColumnValue(Columns.ProbAutov, value); }
		}
		  
		[XmlAttribute("ProbAtrop")]
		[Bindable(true)]
		public bool ProbAtrop 
		{
			get { return GetColumnValue<bool>(Columns.ProbAtrop); }
			set { SetColumnValue(Columns.ProbAtrop, value); }
		}
		  
		[XmlAttribute("ProbCol")]
		[Bindable(true)]
		public bool ProbCol 
		{
			get { return GetColumnValue<bool>(Columns.ProbCol); }
			set { SetColumnValue(Columns.ProbCol, value); }
		}
		  
		[XmlAttribute("ProbDesb")]
		[Bindable(true)]
		public bool ProbDesb 
		{
			get { return GetColumnValue<bool>(Columns.ProbDesb); }
			set { SetColumnValue(Columns.ProbDesb, value); }
		}
		  
		[XmlAttribute("ProbIncen")]
		[Bindable(true)]
		public bool ProbIncen 
		{
			get { return GetColumnValue<bool>(Columns.ProbIncen); }
			set { SetColumnValue(Columns.ProbIncen, value); }
		}
		  
		[XmlAttribute("ProbIntox")]
		[Bindable(true)]
		public bool ProbIntox 
		{
			get { return GetColumnValue<bool>(Columns.ProbIntox); }
			set { SetColumnValue(Columns.ProbIntox, value); }
		}
		  
		[XmlAttribute("ProbNoIdent")]
		[Bindable(true)]
		public bool ProbNoIdent 
		{
			get { return GetColumnValue<bool>(Columns.ProbNoIdent); }
			set { SetColumnValue(Columns.ProbNoIdent, value); }
		}
		  
		[XmlAttribute("Acv")]
		[Bindable(true)]
		public bool Acv 
		{
			get { return GetColumnValue<bool>(Columns.Acv); }
			set { SetColumnValue(Columns.Acv, value); }
		}
		  
		[XmlAttribute("Fiebre")]
		[Bindable(true)]
		public bool Fiebre 
		{
			get { return GetColumnValue<bool>(Columns.Fiebre); }
			set { SetColumnValue(Columns.Fiebre, value); }
		}
		  
		[XmlAttribute("Vomito")]
		[Bindable(true)]
		public bool Vomito 
		{
			get { return GetColumnValue<bool>(Columns.Vomito); }
			set { SetColumnValue(Columns.Vomito, value); }
		}
		  
		[XmlAttribute("Dolor")]
		[Bindable(true)]
		public string Dolor 
		{
			get { return GetColumnValue<string>(Columns.Dolor); }
			set { SetColumnValue(Columns.Dolor, value); }
		}
		  
		[XmlAttribute("Quemado")]
		[Bindable(true)]
		public bool Quemado 
		{
			get { return GetColumnValue<bool>(Columns.Quemado); }
			set { SetColumnValue(Columns.Quemado, value); }
		}
		  
		[XmlAttribute("Ingestioncuerpoext")]
		[Bindable(true)]
		public bool Ingestioncuerpoext 
		{
			get { return GetColumnValue<bool>(Columns.Ingestioncuerpoext); }
			set { SetColumnValue(Columns.Ingestioncuerpoext, value); }
		}
		  
		[XmlAttribute("Agresion")]
		[Bindable(true)]
		public bool Agresion 
		{
			get { return GetColumnValue<bool>(Columns.Agresion); }
			set { SetColumnValue(Columns.Agresion, value); }
		}
		  
		[XmlAttribute("TraumaCraneo")]
		[Bindable(true)]
		public bool TraumaCraneo 
		{
			get { return GetColumnValue<bool>(Columns.TraumaCraneo); }
			set { SetColumnValue(Columns.TraumaCraneo, value); }
		}
		  
		[XmlAttribute("TraumaCuello")]
		[Bindable(true)]
		public bool TraumaCuello 
		{
			get { return GetColumnValue<bool>(Columns.TraumaCuello); }
			set { SetColumnValue(Columns.TraumaCuello, value); }
		}
		  
		[XmlAttribute("TraumaTorax")]
		[Bindable(true)]
		public bool TraumaTorax 
		{
			get { return GetColumnValue<bool>(Columns.TraumaTorax); }
			set { SetColumnValue(Columns.TraumaTorax, value); }
		}
		  
		[XmlAttribute("TraumaAbdomen")]
		[Bindable(true)]
		public bool TraumaAbdomen 
		{
			get { return GetColumnValue<bool>(Columns.TraumaAbdomen); }
			set { SetColumnValue(Columns.TraumaAbdomen, value); }
		}
		  
		[XmlAttribute("TraumaMiembros")]
		[Bindable(true)]
		public bool TraumaMiembros 
		{
			get { return GetColumnValue<bool>(Columns.TraumaMiembros); }
			set { SetColumnValue(Columns.TraumaMiembros, value); }
		}
		  
		[XmlAttribute("TraumaPelvis")]
		[Bindable(true)]
		public bool TraumaPelvis 
		{
			get { return GetColumnValue<bool>(Columns.TraumaPelvis); }
			set { SetColumnValue(Columns.TraumaPelvis, value); }
		}
		  
		[XmlAttribute("Calle")]
		[Bindable(true)]
		public string Calle 
		{
			get { return GetColumnValue<string>(Columns.Calle); }
			set { SetColumnValue(Columns.Calle, value); }
		}
		  
		[XmlAttribute("Numero")]
		[Bindable(true)]
		public int Numero 
		{
			get { return GetColumnValue<int>(Columns.Numero); }
			set { SetColumnValue(Columns.Numero, value); }
		}
		  
		[XmlAttribute("EntreCalles")]
		[Bindable(true)]
		public string EntreCalles 
		{
			get { return GetColumnValue<string>(Columns.EntreCalles); }
			set { SetColumnValue(Columns.EntreCalles, value); }
		}
		  
		[XmlAttribute("Ruta")]
		[Bindable(true)]
		public string Ruta 
		{
			get { return GetColumnValue<string>(Columns.Ruta); }
			set { SetColumnValue(Columns.Ruta, value); }
		}
		  
		[XmlAttribute("Km")]
		[Bindable(true)]
		public int Km 
		{
			get { return GetColumnValue<int>(Columns.Km); }
			set { SetColumnValue(Columns.Km, value); }
		}
		  
		[XmlAttribute("Cercade")]
		[Bindable(true)]
		public string Cercade 
		{
			get { return GetColumnValue<string>(Columns.Cercade); }
			set { SetColumnValue(Columns.Cercade, value); }
		}
		  
		[XmlAttribute("Paraje")]
		[Bindable(true)]
		public string Paraje 
		{
			get { return GetColumnValue<string>(Columns.Paraje); }
			set { SetColumnValue(Columns.Paraje, value); }
		}
		  
		[XmlAttribute("Telefono")]
		[Bindable(true)]
		public string Telefono 
		{
			get { return GetColumnValue<string>(Columns.Telefono); }
			set { SetColumnValue(Columns.Telefono, value); }
		}
		  
		[XmlAttribute("Diagnostico1")]
		[Bindable(true)]
		public string Diagnostico1 
		{
			get { return GetColumnValue<string>(Columns.Diagnostico1); }
			set { SetColumnValue(Columns.Diagnostico1, value); }
		}
		  
		[XmlAttribute("Diagnostico2")]
		[Bindable(true)]
		public string Diagnostico2 
		{
			get { return GetColumnValue<string>(Columns.Diagnostico2); }
			set { SetColumnValue(Columns.Diagnostico2, value); }
		}
		  
		[XmlAttribute("Chofer")]
		[Bindable(true)]
		public string Chofer 
		{
			get { return GetColumnValue<string>(Columns.Chofer); }
			set { SetColumnValue(Columns.Chofer, value); }
		}
		  
		[XmlAttribute("Enfermero")]
		[Bindable(true)]
		public string Enfermero 
		{
			get { return GetColumnValue<string>(Columns.Enfermero); }
			set { SetColumnValue(Columns.Enfermero, value); }
		}
		  
		[XmlAttribute("Camillero")]
		[Bindable(true)]
		public string Camillero 
		{
			get { return GetColumnValue<string>(Columns.Camillero); }
			set { SetColumnValue(Columns.Camillero, value); }
		}
		  
		[XmlAttribute("Medico")]
		[Bindable(true)]
		public string Medico 
		{
			get { return GetColumnValue<string>(Columns.Medico); }
			set { SetColumnValue(Columns.Medico, value); }
		}
		  
		[XmlAttribute("OperadorRecepcion")]
		[Bindable(true)]
		public string OperadorRecepcion 
		{
			get { return GetColumnValue<string>(Columns.OperadorRecepcion); }
			set { SetColumnValue(Columns.OperadorRecepcion, value); }
		}
		  
		[XmlAttribute("Observacion")]
		[Bindable(true)]
		public string Observacion 
		{
			get { return GetColumnValue<string>(Columns.Observacion); }
			set { SetColumnValue(Columns.Observacion, value); }
		}
		  
		[XmlAttribute("Activo")]
		[Bindable(true)]
		public bool Activo 
		{
			get { return GetColumnValue<bool>(Columns.Activo); }
			set { SetColumnValue(Columns.Activo, value); }
		}
		  
		[XmlAttribute("IdBase")]
		[Bindable(true)]
		public int IdBase 
		{
			get { return GetColumnValue<int>(Columns.IdBase); }
			set { SetColumnValue(Columns.IdBase, value); }
		}
		  
		[XmlAttribute("CreatedBy")]
		[Bindable(true)]
		public string CreatedBy 
		{
			get { return GetColumnValue<string>(Columns.CreatedBy); }
			set { SetColumnValue(Columns.CreatedBy, value); }
		}
		  
		[XmlAttribute("CreatedOn")]
		[Bindable(true)]
		public DateTime CreatedOn 
		{
			get { return GetColumnValue<DateTime>(Columns.CreatedOn); }
			set { SetColumnValue(Columns.CreatedOn, value); }
		}
		  
		[XmlAttribute("ModifiedBy")]
		[Bindable(true)]
		public string ModifiedBy 
		{
			get { return GetColumnValue<string>(Columns.ModifiedBy); }
			set { SetColumnValue(Columns.ModifiedBy, value); }
		}
		  
		[XmlAttribute("ModifiedOn")]
		[Bindable(true)]
		public DateTime ModifiedOn 
		{
			get { return GetColumnValue<DateTime>(Columns.ModifiedOn); }
			set { SetColumnValue(Columns.ModifiedOn, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a EmrBase ActiveRecord object related to this EmrRegistro
		/// 
		/// </summary>
		public DalRis.EmrBase EmrBase
		{
			get { return DalRis.EmrBase.FetchByID(this.IdBase); }
			set { SetColumnValue("idBase", value.IdBase); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime varFecha,string varTelefonista,string varHoraRLlamado1,DateTime varHoraRLlamado,string varHoraSAmbulacia,string varHoraLlHospital,string varParticular,bool varCom,bool varCam,bool varBomb,bool varDCiv,bool varGend,bool varEsc,bool varEjer,bool varOtro,int varEdadAnciano,int varEdadJoven,int varEdadNinio,int varEdadAdulto,int varEdadEmbarazada,bool varProblema1,bool varProblema2,bool varProblema3,bool varProblema4,bool varProblema5,bool varProblema6,bool varProblema7,bool varProblema8,bool varProblema9,string varIntoxicacion,bool varProblema10,bool varProblema11,bool varProblema12,bool varProblema13,bool varTraumatismo,int varNroAdultos,int varNroNinios,bool varProbAutov,bool varProbAtrop,bool varProbCol,bool varProbDesb,bool varProbIncen,bool varProbIntox,bool varProbNoIdent,bool varAcv,bool varFiebre,bool varVomito,string varDolor,bool varQuemado,bool varIngestioncuerpoext,bool varAgresion,bool varTraumaCraneo,bool varTraumaCuello,bool varTraumaTorax,bool varTraumaAbdomen,bool varTraumaMiembros,bool varTraumaPelvis,string varCalle,int varNumero,string varEntreCalles,string varRuta,int varKm,string varCercade,string varParaje,string varTelefono,string varDiagnostico1,string varDiagnostico2,string varChofer,string varEnfermero,string varCamillero,string varMedico,string varOperadorRecepcion,string varObservacion,bool varActivo,int varIdBase,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn)
		{
			EmrRegistro item = new EmrRegistro();
			
			item.Fecha = varFecha;
			
			item.Telefonista = varTelefonista;
			
			item.HoraRLlamado1 = varHoraRLlamado1;
			
			item.HoraRLlamado = varHoraRLlamado;
			
			item.HoraSAmbulacia = varHoraSAmbulacia;
			
			item.HoraLlHospital = varHoraLlHospital;
			
			item.Particular = varParticular;
			
			item.Com = varCom;
			
			item.Cam = varCam;
			
			item.Bomb = varBomb;
			
			item.DCiv = varDCiv;
			
			item.Gend = varGend;
			
			item.Esc = varEsc;
			
			item.Ejer = varEjer;
			
			item.Otro = varOtro;
			
			item.EdadAnciano = varEdadAnciano;
			
			item.EdadJoven = varEdadJoven;
			
			item.EdadNinio = varEdadNinio;
			
			item.EdadAdulto = varEdadAdulto;
			
			item.EdadEmbarazada = varEdadEmbarazada;
			
			item.Problema1 = varProblema1;
			
			item.Problema2 = varProblema2;
			
			item.Problema3 = varProblema3;
			
			item.Problema4 = varProblema4;
			
			item.Problema5 = varProblema5;
			
			item.Problema6 = varProblema6;
			
			item.Problema7 = varProblema7;
			
			item.Problema8 = varProblema8;
			
			item.Problema9 = varProblema9;
			
			item.Intoxicacion = varIntoxicacion;
			
			item.Problema10 = varProblema10;
			
			item.Problema11 = varProblema11;
			
			item.Problema12 = varProblema12;
			
			item.Problema13 = varProblema13;
			
			item.Traumatismo = varTraumatismo;
			
			item.NroAdultos = varNroAdultos;
			
			item.NroNinios = varNroNinios;
			
			item.ProbAutov = varProbAutov;
			
			item.ProbAtrop = varProbAtrop;
			
			item.ProbCol = varProbCol;
			
			item.ProbDesb = varProbDesb;
			
			item.ProbIncen = varProbIncen;
			
			item.ProbIntox = varProbIntox;
			
			item.ProbNoIdent = varProbNoIdent;
			
			item.Acv = varAcv;
			
			item.Fiebre = varFiebre;
			
			item.Vomito = varVomito;
			
			item.Dolor = varDolor;
			
			item.Quemado = varQuemado;
			
			item.Ingestioncuerpoext = varIngestioncuerpoext;
			
			item.Agresion = varAgresion;
			
			item.TraumaCraneo = varTraumaCraneo;
			
			item.TraumaCuello = varTraumaCuello;
			
			item.TraumaTorax = varTraumaTorax;
			
			item.TraumaAbdomen = varTraumaAbdomen;
			
			item.TraumaMiembros = varTraumaMiembros;
			
			item.TraumaPelvis = varTraumaPelvis;
			
			item.Calle = varCalle;
			
			item.Numero = varNumero;
			
			item.EntreCalles = varEntreCalles;
			
			item.Ruta = varRuta;
			
			item.Km = varKm;
			
			item.Cercade = varCercade;
			
			item.Paraje = varParaje;
			
			item.Telefono = varTelefono;
			
			item.Diagnostico1 = varDiagnostico1;
			
			item.Diagnostico2 = varDiagnostico2;
			
			item.Chofer = varChofer;
			
			item.Enfermero = varEnfermero;
			
			item.Camillero = varCamillero;
			
			item.Medico = varMedico;
			
			item.OperadorRecepcion = varOperadorRecepcion;
			
			item.Observacion = varObservacion;
			
			item.Activo = varActivo;
			
			item.IdBase = varIdBase;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdEmr,DateTime varFecha,string varTelefonista,string varHoraRLlamado1,DateTime varHoraRLlamado,string varHoraSAmbulacia,string varHoraLlHospital,string varParticular,bool varCom,bool varCam,bool varBomb,bool varDCiv,bool varGend,bool varEsc,bool varEjer,bool varOtro,int varEdadAnciano,int varEdadJoven,int varEdadNinio,int varEdadAdulto,int varEdadEmbarazada,bool varProblema1,bool varProblema2,bool varProblema3,bool varProblema4,bool varProblema5,bool varProblema6,bool varProblema7,bool varProblema8,bool varProblema9,string varIntoxicacion,bool varProblema10,bool varProblema11,bool varProblema12,bool varProblema13,bool varTraumatismo,int varNroAdultos,int varNroNinios,bool varProbAutov,bool varProbAtrop,bool varProbCol,bool varProbDesb,bool varProbIncen,bool varProbIntox,bool varProbNoIdent,bool varAcv,bool varFiebre,bool varVomito,string varDolor,bool varQuemado,bool varIngestioncuerpoext,bool varAgresion,bool varTraumaCraneo,bool varTraumaCuello,bool varTraumaTorax,bool varTraumaAbdomen,bool varTraumaMiembros,bool varTraumaPelvis,string varCalle,int varNumero,string varEntreCalles,string varRuta,int varKm,string varCercade,string varParaje,string varTelefono,string varDiagnostico1,string varDiagnostico2,string varChofer,string varEnfermero,string varCamillero,string varMedico,string varOperadorRecepcion,string varObservacion,bool varActivo,int varIdBase,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn)
		{
			EmrRegistro item = new EmrRegistro();
			
				item.IdEmr = varIdEmr;
			
				item.Fecha = varFecha;
			
				item.Telefonista = varTelefonista;
			
				item.HoraRLlamado1 = varHoraRLlamado1;
			
				item.HoraRLlamado = varHoraRLlamado;
			
				item.HoraSAmbulacia = varHoraSAmbulacia;
			
				item.HoraLlHospital = varHoraLlHospital;
			
				item.Particular = varParticular;
			
				item.Com = varCom;
			
				item.Cam = varCam;
			
				item.Bomb = varBomb;
			
				item.DCiv = varDCiv;
			
				item.Gend = varGend;
			
				item.Esc = varEsc;
			
				item.Ejer = varEjer;
			
				item.Otro = varOtro;
			
				item.EdadAnciano = varEdadAnciano;
			
				item.EdadJoven = varEdadJoven;
			
				item.EdadNinio = varEdadNinio;
			
				item.EdadAdulto = varEdadAdulto;
			
				item.EdadEmbarazada = varEdadEmbarazada;
			
				item.Problema1 = varProblema1;
			
				item.Problema2 = varProblema2;
			
				item.Problema3 = varProblema3;
			
				item.Problema4 = varProblema4;
			
				item.Problema5 = varProblema5;
			
				item.Problema6 = varProblema6;
			
				item.Problema7 = varProblema7;
			
				item.Problema8 = varProblema8;
			
				item.Problema9 = varProblema9;
			
				item.Intoxicacion = varIntoxicacion;
			
				item.Problema10 = varProblema10;
			
				item.Problema11 = varProblema11;
			
				item.Problema12 = varProblema12;
			
				item.Problema13 = varProblema13;
			
				item.Traumatismo = varTraumatismo;
			
				item.NroAdultos = varNroAdultos;
			
				item.NroNinios = varNroNinios;
			
				item.ProbAutov = varProbAutov;
			
				item.ProbAtrop = varProbAtrop;
			
				item.ProbCol = varProbCol;
			
				item.ProbDesb = varProbDesb;
			
				item.ProbIncen = varProbIncen;
			
				item.ProbIntox = varProbIntox;
			
				item.ProbNoIdent = varProbNoIdent;
			
				item.Acv = varAcv;
			
				item.Fiebre = varFiebre;
			
				item.Vomito = varVomito;
			
				item.Dolor = varDolor;
			
				item.Quemado = varQuemado;
			
				item.Ingestioncuerpoext = varIngestioncuerpoext;
			
				item.Agresion = varAgresion;
			
				item.TraumaCraneo = varTraumaCraneo;
			
				item.TraumaCuello = varTraumaCuello;
			
				item.TraumaTorax = varTraumaTorax;
			
				item.TraumaAbdomen = varTraumaAbdomen;
			
				item.TraumaMiembros = varTraumaMiembros;
			
				item.TraumaPelvis = varTraumaPelvis;
			
				item.Calle = varCalle;
			
				item.Numero = varNumero;
			
				item.EntreCalles = varEntreCalles;
			
				item.Ruta = varRuta;
			
				item.Km = varKm;
			
				item.Cercade = varCercade;
			
				item.Paraje = varParaje;
			
				item.Telefono = varTelefono;
			
				item.Diagnostico1 = varDiagnostico1;
			
				item.Diagnostico2 = varDiagnostico2;
			
				item.Chofer = varChofer;
			
				item.Enfermero = varEnfermero;
			
				item.Camillero = varCamillero;
			
				item.Medico = varMedico;
			
				item.OperadorRecepcion = varOperadorRecepcion;
			
				item.Observacion = varObservacion;
			
				item.Activo = varActivo;
			
				item.IdBase = varIdBase;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdEmrColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn TelefonistaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn HoraRLlamado1Column
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn HoraRLlamadoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn HoraSAmbulaciaColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn HoraLlHospitalColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ParticularColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ComColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn CamColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn BombColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn DCivColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn GendColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn EscColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn EjerColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn OtroColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn EdadAncianoColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn EdadJovenColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn EdadNinioColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn EdadAdultoColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn EdadEmbarazadaColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema1Column
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema2Column
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema3Column
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema4Column
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema5Column
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema6Column
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema7Column
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema8Column
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema9Column
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn IntoxicacionColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema10Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema11Column
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema12Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn Problema13Column
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn TraumatismoColumn
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn NroAdultosColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn NroNiniosColumn
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn ProbAutovColumn
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn ProbAtropColumn
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn ProbColColumn
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn ProbDesbColumn
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn ProbIncenColumn
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn ProbIntoxColumn
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn ProbNoIdentColumn
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn AcvColumn
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn FiebreColumn
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn VomitoColumn
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn DolorColumn
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn QuemadoColumn
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        public static TableSchema.TableColumn IngestioncuerpoextColumn
        {
            get { return Schema.Columns[50]; }
        }
        
        
        
        public static TableSchema.TableColumn AgresionColumn
        {
            get { return Schema.Columns[51]; }
        }
        
        
        
        public static TableSchema.TableColumn TraumaCraneoColumn
        {
            get { return Schema.Columns[52]; }
        }
        
        
        
        public static TableSchema.TableColumn TraumaCuelloColumn
        {
            get { return Schema.Columns[53]; }
        }
        
        
        
        public static TableSchema.TableColumn TraumaToraxColumn
        {
            get { return Schema.Columns[54]; }
        }
        
        
        
        public static TableSchema.TableColumn TraumaAbdomenColumn
        {
            get { return Schema.Columns[55]; }
        }
        
        
        
        public static TableSchema.TableColumn TraumaMiembrosColumn
        {
            get { return Schema.Columns[56]; }
        }
        
        
        
        public static TableSchema.TableColumn TraumaPelvisColumn
        {
            get { return Schema.Columns[57]; }
        }
        
        
        
        public static TableSchema.TableColumn CalleColumn
        {
            get { return Schema.Columns[58]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroColumn
        {
            get { return Schema.Columns[59]; }
        }
        
        
        
        public static TableSchema.TableColumn EntreCallesColumn
        {
            get { return Schema.Columns[60]; }
        }
        
        
        
        public static TableSchema.TableColumn RutaColumn
        {
            get { return Schema.Columns[61]; }
        }
        
        
        
        public static TableSchema.TableColumn KmColumn
        {
            get { return Schema.Columns[62]; }
        }
        
        
        
        public static TableSchema.TableColumn CercadeColumn
        {
            get { return Schema.Columns[63]; }
        }
        
        
        
        public static TableSchema.TableColumn ParajeColumn
        {
            get { return Schema.Columns[64]; }
        }
        
        
        
        public static TableSchema.TableColumn TelefonoColumn
        {
            get { return Schema.Columns[65]; }
        }
        
        
        
        public static TableSchema.TableColumn Diagnostico1Column
        {
            get { return Schema.Columns[66]; }
        }
        
        
        
        public static TableSchema.TableColumn Diagnostico2Column
        {
            get { return Schema.Columns[67]; }
        }
        
        
        
        public static TableSchema.TableColumn ChoferColumn
        {
            get { return Schema.Columns[68]; }
        }
        
        
        
        public static TableSchema.TableColumn EnfermeroColumn
        {
            get { return Schema.Columns[69]; }
        }
        
        
        
        public static TableSchema.TableColumn CamilleroColumn
        {
            get { return Schema.Columns[70]; }
        }
        
        
        
        public static TableSchema.TableColumn MedicoColumn
        {
            get { return Schema.Columns[71]; }
        }
        
        
        
        public static TableSchema.TableColumn OperadorRecepcionColumn
        {
            get { return Schema.Columns[72]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionColumn
        {
            get { return Schema.Columns[73]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[74]; }
        }
        
        
        
        public static TableSchema.TableColumn IdBaseColumn
        {
            get { return Schema.Columns[75]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[76]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[77]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[78]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[79]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdEmr = @"idEmr";
			 public static string Fecha = @"fecha";
			 public static string Telefonista = @"telefonista";
			 public static string HoraRLlamado1 = @"horaRLlamado1";
			 public static string HoraRLlamado = @"horaRLlamado";
			 public static string HoraSAmbulacia = @"horaSAmbulacia";
			 public static string HoraLlHospital = @"horaLlHospital";
			 public static string Particular = @"particular";
			 public static string Com = @"com";
			 public static string Cam = @"cam";
			 public static string Bomb = @"bomb";
			 public static string DCiv = @"dCiv";
			 public static string Gend = @"gend";
			 public static string Esc = @"esc";
			 public static string Ejer = @"ejer";
			 public static string Otro = @"otro";
			 public static string EdadAnciano = @"edadAnciano";
			 public static string EdadJoven = @"edadJoven";
			 public static string EdadNinio = @"edadNinio";
			 public static string EdadAdulto = @"edadAdulto";
			 public static string EdadEmbarazada = @"edadEmbarazada";
			 public static string Problema1 = @"problema1";
			 public static string Problema2 = @"problema2";
			 public static string Problema3 = @"problema3";
			 public static string Problema4 = @"problema4";
			 public static string Problema5 = @"problema5";
			 public static string Problema6 = @"problema6";
			 public static string Problema7 = @"problema7";
			 public static string Problema8 = @"problema8";
			 public static string Problema9 = @"problema9";
			 public static string Intoxicacion = @"intoxicacion";
			 public static string Problema10 = @"problema10";
			 public static string Problema11 = @"problema11";
			 public static string Problema12 = @"problema12";
			 public static string Problema13 = @"problema13";
			 public static string Traumatismo = @"traumatismo";
			 public static string NroAdultos = @"nroAdultos";
			 public static string NroNinios = @"nroNinios";
			 public static string ProbAutov = @"probAutov";
			 public static string ProbAtrop = @"probAtrop";
			 public static string ProbCol = @"probCol";
			 public static string ProbDesb = @"probDesb";
			 public static string ProbIncen = @"probIncen";
			 public static string ProbIntox = @"probIntox";
			 public static string ProbNoIdent = @"probNoIdent";
			 public static string Acv = @"acv";
			 public static string Fiebre = @"fiebre";
			 public static string Vomito = @"vomito";
			 public static string Dolor = @"dolor";
			 public static string Quemado = @"quemado";
			 public static string Ingestioncuerpoext = @"ingestioncuerpoext";
			 public static string Agresion = @"agresion";
			 public static string TraumaCraneo = @"traumaCraneo";
			 public static string TraumaCuello = @"traumaCuello";
			 public static string TraumaTorax = @"traumaTorax";
			 public static string TraumaAbdomen = @"traumaAbdomen";
			 public static string TraumaMiembros = @"traumaMiembros";
			 public static string TraumaPelvis = @"traumaPelvis";
			 public static string Calle = @"calle";
			 public static string Numero = @"numero";
			 public static string EntreCalles = @"entreCalles";
			 public static string Ruta = @"ruta";
			 public static string Km = @"km";
			 public static string Cercade = @"cercade";
			 public static string Paraje = @"paraje";
			 public static string Telefono = @"telefono";
			 public static string Diagnostico1 = @"diagnostico1";
			 public static string Diagnostico2 = @"diagnostico2";
			 public static string Chofer = @"chofer";
			 public static string Enfermero = @"enfermero";
			 public static string Camillero = @"camillero";
			 public static string Medico = @"medico";
			 public static string OperadorRecepcion = @"operadorRecepcion";
			 public static string Observacion = @"observacion";
			 public static string Activo = @"activo";
			 public static string IdBase = @"idBase";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
