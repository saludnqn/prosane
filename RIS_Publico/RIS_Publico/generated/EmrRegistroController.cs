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
    /// Controller class for EMR_Registro
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class EmrRegistroController
    {
        // Preload our schema..
        EmrRegistro thisSchemaLoad = new EmrRegistro();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public EmrRegistroCollection FetchAll()
        {
            EmrRegistroCollection coll = new EmrRegistroCollection();
            Query qry = new Query(EmrRegistro.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrRegistroCollection FetchByID(object IdEmr)
        {
            EmrRegistroCollection coll = new EmrRegistroCollection().Where("idEmr", IdEmr).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrRegistroCollection FetchByQuery(Query qry)
        {
            EmrRegistroCollection coll = new EmrRegistroCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdEmr)
        {
            return (EmrRegistro.Delete(IdEmr) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdEmr)
        {
            return (EmrRegistro.Destroy(IdEmr) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime Fecha,string Telefonista,string HoraRLlamado1,DateTime HoraRLlamado,string HoraSAmbulacia,string HoraLlHospital,string Particular,bool Com,bool Cam,bool Bomb,bool DCiv,bool Gend,bool Esc,bool Ejer,bool Otro,int EdadAnciano,int EdadJoven,int EdadNinio,int EdadAdulto,int EdadEmbarazada,bool Problema1,bool Problema2,bool Problema3,bool Problema4,bool Problema5,bool Problema6,bool Problema7,bool Problema8,bool Problema9,string Intoxicacion,bool Problema10,bool Problema11,bool Problema12,bool Problema13,bool Traumatismo,int NroAdultos,int NroNinios,bool ProbAutov,bool ProbAtrop,bool ProbCol,bool ProbDesb,bool ProbIncen,bool ProbIntox,bool ProbNoIdent,bool Acv,bool Fiebre,bool Vomito,string Dolor,bool Quemado,bool Ingestioncuerpoext,bool Agresion,bool TraumaCraneo,bool TraumaCuello,bool TraumaTorax,bool TraumaAbdomen,bool TraumaMiembros,bool TraumaPelvis,string Calle,int Numero,string EntreCalles,string Ruta,int Km,string Cercade,string Paraje,string Telefono,string Diagnostico1,string Diagnostico2,string Chofer,string Enfermero,string Camillero,string Medico,string OperadorRecepcion,string Observacion,bool Activo,int IdBase,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn)
	    {
		    EmrRegistro item = new EmrRegistro();
		    
            item.Fecha = Fecha;
            
            item.Telefonista = Telefonista;
            
            item.HoraRLlamado1 = HoraRLlamado1;
            
            item.HoraRLlamado = HoraRLlamado;
            
            item.HoraSAmbulacia = HoraSAmbulacia;
            
            item.HoraLlHospital = HoraLlHospital;
            
            item.Particular = Particular;
            
            item.Com = Com;
            
            item.Cam = Cam;
            
            item.Bomb = Bomb;
            
            item.DCiv = DCiv;
            
            item.Gend = Gend;
            
            item.Esc = Esc;
            
            item.Ejer = Ejer;
            
            item.Otro = Otro;
            
            item.EdadAnciano = EdadAnciano;
            
            item.EdadJoven = EdadJoven;
            
            item.EdadNinio = EdadNinio;
            
            item.EdadAdulto = EdadAdulto;
            
            item.EdadEmbarazada = EdadEmbarazada;
            
            item.Problema1 = Problema1;
            
            item.Problema2 = Problema2;
            
            item.Problema3 = Problema3;
            
            item.Problema4 = Problema4;
            
            item.Problema5 = Problema5;
            
            item.Problema6 = Problema6;
            
            item.Problema7 = Problema7;
            
            item.Problema8 = Problema8;
            
            item.Problema9 = Problema9;
            
            item.Intoxicacion = Intoxicacion;
            
            item.Problema10 = Problema10;
            
            item.Problema11 = Problema11;
            
            item.Problema12 = Problema12;
            
            item.Problema13 = Problema13;
            
            item.Traumatismo = Traumatismo;
            
            item.NroAdultos = NroAdultos;
            
            item.NroNinios = NroNinios;
            
            item.ProbAutov = ProbAutov;
            
            item.ProbAtrop = ProbAtrop;
            
            item.ProbCol = ProbCol;
            
            item.ProbDesb = ProbDesb;
            
            item.ProbIncen = ProbIncen;
            
            item.ProbIntox = ProbIntox;
            
            item.ProbNoIdent = ProbNoIdent;
            
            item.Acv = Acv;
            
            item.Fiebre = Fiebre;
            
            item.Vomito = Vomito;
            
            item.Dolor = Dolor;
            
            item.Quemado = Quemado;
            
            item.Ingestioncuerpoext = Ingestioncuerpoext;
            
            item.Agresion = Agresion;
            
            item.TraumaCraneo = TraumaCraneo;
            
            item.TraumaCuello = TraumaCuello;
            
            item.TraumaTorax = TraumaTorax;
            
            item.TraumaAbdomen = TraumaAbdomen;
            
            item.TraumaMiembros = TraumaMiembros;
            
            item.TraumaPelvis = TraumaPelvis;
            
            item.Calle = Calle;
            
            item.Numero = Numero;
            
            item.EntreCalles = EntreCalles;
            
            item.Ruta = Ruta;
            
            item.Km = Km;
            
            item.Cercade = Cercade;
            
            item.Paraje = Paraje;
            
            item.Telefono = Telefono;
            
            item.Diagnostico1 = Diagnostico1;
            
            item.Diagnostico2 = Diagnostico2;
            
            item.Chofer = Chofer;
            
            item.Enfermero = Enfermero;
            
            item.Camillero = Camillero;
            
            item.Medico = Medico;
            
            item.OperadorRecepcion = OperadorRecepcion;
            
            item.Observacion = Observacion;
            
            item.Activo = Activo;
            
            item.IdBase = IdBase;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdEmr,DateTime Fecha,string Telefonista,string HoraRLlamado1,DateTime HoraRLlamado,string HoraSAmbulacia,string HoraLlHospital,string Particular,bool Com,bool Cam,bool Bomb,bool DCiv,bool Gend,bool Esc,bool Ejer,bool Otro,int EdadAnciano,int EdadJoven,int EdadNinio,int EdadAdulto,int EdadEmbarazada,bool Problema1,bool Problema2,bool Problema3,bool Problema4,bool Problema5,bool Problema6,bool Problema7,bool Problema8,bool Problema9,string Intoxicacion,bool Problema10,bool Problema11,bool Problema12,bool Problema13,bool Traumatismo,int NroAdultos,int NroNinios,bool ProbAutov,bool ProbAtrop,bool ProbCol,bool ProbDesb,bool ProbIncen,bool ProbIntox,bool ProbNoIdent,bool Acv,bool Fiebre,bool Vomito,string Dolor,bool Quemado,bool Ingestioncuerpoext,bool Agresion,bool TraumaCraneo,bool TraumaCuello,bool TraumaTorax,bool TraumaAbdomen,bool TraumaMiembros,bool TraumaPelvis,string Calle,int Numero,string EntreCalles,string Ruta,int Km,string Cercade,string Paraje,string Telefono,string Diagnostico1,string Diagnostico2,string Chofer,string Enfermero,string Camillero,string Medico,string OperadorRecepcion,string Observacion,bool Activo,int IdBase,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn)
	    {
		    EmrRegistro item = new EmrRegistro();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdEmr = IdEmr;
				
			item.Fecha = Fecha;
				
			item.Telefonista = Telefonista;
				
			item.HoraRLlamado1 = HoraRLlamado1;
				
			item.HoraRLlamado = HoraRLlamado;
				
			item.HoraSAmbulacia = HoraSAmbulacia;
				
			item.HoraLlHospital = HoraLlHospital;
				
			item.Particular = Particular;
				
			item.Com = Com;
				
			item.Cam = Cam;
				
			item.Bomb = Bomb;
				
			item.DCiv = DCiv;
				
			item.Gend = Gend;
				
			item.Esc = Esc;
				
			item.Ejer = Ejer;
				
			item.Otro = Otro;
				
			item.EdadAnciano = EdadAnciano;
				
			item.EdadJoven = EdadJoven;
				
			item.EdadNinio = EdadNinio;
				
			item.EdadAdulto = EdadAdulto;
				
			item.EdadEmbarazada = EdadEmbarazada;
				
			item.Problema1 = Problema1;
				
			item.Problema2 = Problema2;
				
			item.Problema3 = Problema3;
				
			item.Problema4 = Problema4;
				
			item.Problema5 = Problema5;
				
			item.Problema6 = Problema6;
				
			item.Problema7 = Problema7;
				
			item.Problema8 = Problema8;
				
			item.Problema9 = Problema9;
				
			item.Intoxicacion = Intoxicacion;
				
			item.Problema10 = Problema10;
				
			item.Problema11 = Problema11;
				
			item.Problema12 = Problema12;
				
			item.Problema13 = Problema13;
				
			item.Traumatismo = Traumatismo;
				
			item.NroAdultos = NroAdultos;
				
			item.NroNinios = NroNinios;
				
			item.ProbAutov = ProbAutov;
				
			item.ProbAtrop = ProbAtrop;
				
			item.ProbCol = ProbCol;
				
			item.ProbDesb = ProbDesb;
				
			item.ProbIncen = ProbIncen;
				
			item.ProbIntox = ProbIntox;
				
			item.ProbNoIdent = ProbNoIdent;
				
			item.Acv = Acv;
				
			item.Fiebre = Fiebre;
				
			item.Vomito = Vomito;
				
			item.Dolor = Dolor;
				
			item.Quemado = Quemado;
				
			item.Ingestioncuerpoext = Ingestioncuerpoext;
				
			item.Agresion = Agresion;
				
			item.TraumaCraneo = TraumaCraneo;
				
			item.TraumaCuello = TraumaCuello;
				
			item.TraumaTorax = TraumaTorax;
				
			item.TraumaAbdomen = TraumaAbdomen;
				
			item.TraumaMiembros = TraumaMiembros;
				
			item.TraumaPelvis = TraumaPelvis;
				
			item.Calle = Calle;
				
			item.Numero = Numero;
				
			item.EntreCalles = EntreCalles;
				
			item.Ruta = Ruta;
				
			item.Km = Km;
				
			item.Cercade = Cercade;
				
			item.Paraje = Paraje;
				
			item.Telefono = Telefono;
				
			item.Diagnostico1 = Diagnostico1;
				
			item.Diagnostico2 = Diagnostico2;
				
			item.Chofer = Chofer;
				
			item.Enfermero = Enfermero;
				
			item.Camillero = Camillero;
				
			item.Medico = Medico;
				
			item.OperadorRecepcion = OperadorRecepcion;
				
			item.Observacion = Observacion;
				
			item.Activo = Activo;
				
			item.IdBase = IdBase;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}
