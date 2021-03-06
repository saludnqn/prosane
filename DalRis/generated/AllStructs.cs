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
// <auto-generated />
namespace DalRis
{
	#region Tables Struct
	public partial struct Tables
	{
		
		public static readonly string PsmDato = @"PSM_Datos";
        
		public static readonly string PsmDerivacione = @"PSM_Derivaciones";
        
		public static readonly string PsmDivision = @"PSM_Division";
        
		public static readonly string PsmEFisico = @"PSM_EFisico";
        
		public static readonly string PsmEscolaridad = @"PSM_Escolaridad";
        
		public static readonly string PsmGrado = @"PSM_Grado";
        
		public static readonly string RisAreaTematica = @"RIS_AreaTematica";
        
		public static readonly string RisAseguradora = @"RIS_Aseguradora";
        
		public static readonly string RisCaracteristica = @"RIS_Caracteristica";
        
		public static readonly string RisComiteEtica = @"RIS_ComiteEtica";
        
		public static readonly string RisConcentimiento = @"RIS_Concentimiento";
        
		public static readonly string RisEnmienda = @"RIS_Enmienda";
        
		public static readonly string RisEnmiendaItemDesaprobado = @"RIS_EnmiendaItemDesaprobado";
        
		public static readonly string RisEntidad = @"RIS_Entidad";
        
		public static readonly string RisEstudio = @"RIS_Estudio";
        
		public static readonly string RisEstudioAseguradora = @"RIS_EstudioAseguradora";
        
		public static readonly string RisEstudioCaracteristica = @"RIS_EstudioCaracteristica";
        
		public static readonly string RisEstudioComiteEtica = @"RIS_EstudioComiteEtica";
        
		public static readonly string RisEstudioEntidad = @"RIS_EstudioEntidad";
        
		public static readonly string RisEstudioFuenteRecoleccionDato = @"RIS_EstudioFuenteRecoleccionDatos";
        
		public static readonly string RisEstudioInvestigador = @"RIS_EstudioInvestigador";
        
		public static readonly string RisEstudioItemAprobado = @"RIS_EstudioItemAprobado";
        
		public static readonly string RisEstudioItemDesaprobado = @"RIS_EstudioItemDesaprobado";
        
		public static readonly string RisEstudioPoblacionVulnerable = @"RIS_EstudioPoblacionVulnerable";
        
		public static readonly string RisEstudioSysEfectorMulticentrico = @"RIS_EstudioSysEfectorMulticentrico";
        
		public static readonly string RisEstudioSysPaisMulticentrico = @"RIS_EstudioSysPaisMulticentrico";
        
		public static readonly string RisEstudioSysProvinciaMulticentrico = @"RIS_EstudioSysProvinciaMulticentrico";
        
		public static readonly string RisEvaluacionRechazada = @"RIS_EvaluacionRechazada";
        
		public static readonly string RisFuenteRecoleccionDato = @"RIS_FuenteRecoleccionDatos";
        
		public static readonly string RisFuncionEnElEquipo = @"RIS_FuncionEnElEquipo";
        
		public static readonly string RisInvestigadore = @"RIS_Investigadores";
        
		public static readonly string RisItemAprobado = @"RIS_ItemAprobado";
        
		public static readonly string RisItemDesaprobado = @"RIS_ItemDesaprobado";
        
		public static readonly string RisLugarRealizacion = @"RIS_LugarRealizacion";
        
		public static readonly string RisNotum = @"RIS_Nota";
        
		public static readonly string RisPoblacionVulnerable = @"RIS_PoblacionVulnerable";
        
		public static readonly string RisPresentacionInforme = @"RIS_PresentacionInforme";
        
		public static readonly string RisProfesion = @"RIS_Profesion";
        
		public static readonly string RisTipoDocumento = @"RIS_TipoDocumento";
        
		public static readonly string RisTipoTelefono = @"RIS_TipoTelefono";
        
		public static readonly string RisVigenciaPoliza = @"RIS_VigenciaPoliza";
        
		public static readonly string SysAntecedente = @"Sys_Antecedente";
        
		public static readonly string SysAntecedenteEnfermedad = @"Sys_AntecedenteEnfermedad";
        
		public static readonly string SysBarrio = @"Sys_Barrio";
        
		public static readonly string SysCepSap = @"Sys_CepSap";
        
		public static readonly string SysCIE10 = @"Sys_CIE10";
        
		public static readonly string SysCIE10Capitulo = @"Sys_CIE10Capitulo";
        
		public static readonly string SysDefuncion = @"sys_Defuncion";
        
		public static readonly string SysDepartamento = @"Sys_Departamento";
        
		public static readonly string SysDireccione = @"Sys_Direcciones";
        
		public static readonly string SysEfector = @"Sys_Efector";
        
		public static readonly string SysEspecialidad = @"Sys_Especialidad";
        
		public static readonly string SysEspecialidad2 = @"Sys_Especialidad2";
        
		public static readonly string SysEstablecimiento = @"sys_Establecimiento";
        
		public static readonly string SysEstado = @"Sys_Estado";
        
		public static readonly string SysEstadoCivil = @"Sys_EstadoCivil";
        
		public static readonly string SysHistoriaClinica = @"Sys_HistoriaClinica";
        
		public static readonly string SysIdioma = @"Sys_Idioma";
        
		public static readonly string SysLocalidad = @"Sys_Localidad";
        
		public static readonly string SysMedicamento = @"Sys_Medicamento";
        
		public static readonly string SysMedicamentoRubro = @"Sys_MedicamentoRubro";
        
		public static readonly string SysMenu = @"Sys_Menu";
        
		public static readonly string SysModulo = @"Sys_Modulo";
        
		public static readonly string SysMotivoNI = @"Sys_MotivoNI";
        
		public static readonly string SysMovimientoHistoriaClinica = @"Sys_MovimientoHistoriaClinica";
        
		public static readonly string SysMunicipio = @"Sys_Municipio";
        
		public static readonly string SysNivelInstruccion = @"Sys_NivelInstruccion";
        
		public static readonly string SysObraSocial = @"Sys_ObraSocial";
        
		public static readonly string SysOcupacion = @"Sys_Ocupacion";
        
		public static readonly string SysOrganismo = @"Sys_Organismo";
        
		public static readonly string SysPaciente = @"Sys_Paciente";
        
		public static readonly string SysPacienteAntecedentesFamiliare = @"Sys_PacienteAntecedentesFamiliares";
        
		public static readonly string SysPacienteCeliaco = @"Sys_PacienteCeliaco";
        
		public static readonly string SysPai = @"Sys_Pais";
        
		public static readonly string SysParentesco = @"Sys_Parentesco";
        
		public static readonly string SysParentescoTipo = @"Sys_ParentescoTipo";
        
		public static readonly string SysPerfil = @"Sys_Perfil";
        
		public static readonly string SysPermiso = @"Sys_Permiso";
        
		public static readonly string SysPoblacion = @"Sys_Poblacion";
        
		public static readonly string SysPoblacion1 = @"Sys_Poblacion1";
        
		public static readonly string SysProfesion = @"Sys_Profesion";
        
		public static readonly string SysProfesional = @"Sys_Profesional";
        
		public static readonly string SysProvincium = @"Sys_Provincia";
        
		public static readonly string SysRelAntecedentePaciente = @"Sys_RelAntecedentePaciente";
        
		public static readonly string SysRelEspecialidadEfector = @"Sys_RelEspecialidadEfector";
        
		public static readonly string SysRelEstadoMotivoNI = @"Sys_RelEstadoMotivoNI";
        
		public static readonly string SysRelFormularioCobertura = @"Sys_RelFormularioCobertura";
        
		public static readonly string SysRelHistoriaClinicaEfector = @"Sys_RelHistoriaClinicaEfector";
        
		public static readonly string SysRelPacienteObraSocial = @"Sys_RelPacienteObraSocial";
        
		public static readonly string SysRelProfesionalEfector = @"Sys_RelProfesionalEfector";
        
		public static readonly string SysRelServicioEfector = @"Sys_RelServicioEfector";
        
		public static readonly string SysServicio = @"Sys_Servicio";
        
		public static readonly string SysSexo = @"Sys_Sexo";
        
		public static readonly string SysSituacionLaboral = @"Sys_SituacionLaboral";
        
		public static readonly string SysTipoAntecedente = @"Sys_TipoAntecedente";
        
		public static readonly string SysTipoCobertura = @"Sys_TipoCobertura";
        
		public static readonly string SysTipoDocumento = @"Sys_TipoDocumento";
        
		public static readonly string SysTipoEfector = @"Sys_TipoEfector";
        
		public static readonly string SysTipoObraSocial = @"Sys_TipoObraSocial";
        
		public static readonly string SysTipoProfesional = @"Sys_TipoProfesional";
        
		public static readonly string SysUsuario = @"Sys_Usuario";
        
		public static readonly string SysZona = @"Sys_Zona";
        
	}
	#endregion
    #region Schemas
    public partial class Schemas {
		
		public static TableSchema.Table PsmDato
		{
            get { return DataService.GetSchema("PSM_Datos", "RisProvider"); }
		}
        
		public static TableSchema.Table PsmDerivacione
		{
            get { return DataService.GetSchema("PSM_Derivaciones", "RisProvider"); }
		}
        
		public static TableSchema.Table PsmDivision
		{
            get { return DataService.GetSchema("PSM_Division", "RisProvider"); }
		}
        
		public static TableSchema.Table PsmEFisico
		{
            get { return DataService.GetSchema("PSM_EFisico", "RisProvider"); }
		}
        
		public static TableSchema.Table PsmEscolaridad
		{
            get { return DataService.GetSchema("PSM_Escolaridad", "RisProvider"); }
		}
        
		public static TableSchema.Table PsmGrado
		{
            get { return DataService.GetSchema("PSM_Grado", "RisProvider"); }
		}
        
		public static TableSchema.Table RisAreaTematica
		{
            get { return DataService.GetSchema("RIS_AreaTematica", "RisProvider"); }
		}
        
		public static TableSchema.Table RisAseguradora
		{
            get { return DataService.GetSchema("RIS_Aseguradora", "RisProvider"); }
		}
        
		public static TableSchema.Table RisCaracteristica
		{
            get { return DataService.GetSchema("RIS_Caracteristica", "RisProvider"); }
		}
        
		public static TableSchema.Table RisComiteEtica
		{
            get { return DataService.GetSchema("RIS_ComiteEtica", "RisProvider"); }
		}
        
		public static TableSchema.Table RisConcentimiento
		{
            get { return DataService.GetSchema("RIS_Concentimiento", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEnmienda
		{
            get { return DataService.GetSchema("RIS_Enmienda", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEnmiendaItemDesaprobado
		{
            get { return DataService.GetSchema("RIS_EnmiendaItemDesaprobado", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEntidad
		{
            get { return DataService.GetSchema("RIS_Entidad", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudio
		{
            get { return DataService.GetSchema("RIS_Estudio", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioAseguradora
		{
            get { return DataService.GetSchema("RIS_EstudioAseguradora", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioCaracteristica
		{
            get { return DataService.GetSchema("RIS_EstudioCaracteristica", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioComiteEtica
		{
            get { return DataService.GetSchema("RIS_EstudioComiteEtica", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioEntidad
		{
            get { return DataService.GetSchema("RIS_EstudioEntidad", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioFuenteRecoleccionDato
		{
            get { return DataService.GetSchema("RIS_EstudioFuenteRecoleccionDatos", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioInvestigador
		{
            get { return DataService.GetSchema("RIS_EstudioInvestigador", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioItemAprobado
		{
            get { return DataService.GetSchema("RIS_EstudioItemAprobado", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioItemDesaprobado
		{
            get { return DataService.GetSchema("RIS_EstudioItemDesaprobado", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioPoblacionVulnerable
		{
            get { return DataService.GetSchema("RIS_EstudioPoblacionVulnerable", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioSysEfectorMulticentrico
		{
            get { return DataService.GetSchema("RIS_EstudioSysEfectorMulticentrico", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioSysPaisMulticentrico
		{
            get { return DataService.GetSchema("RIS_EstudioSysPaisMulticentrico", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioSysProvinciaMulticentrico
		{
            get { return DataService.GetSchema("RIS_EstudioSysProvinciaMulticentrico", "RisProvider"); }
		}
        
		public static TableSchema.Table RisEvaluacionRechazada
		{
            get { return DataService.GetSchema("RIS_EvaluacionRechazada", "RisProvider"); }
		}
        
		public static TableSchema.Table RisFuenteRecoleccionDato
		{
            get { return DataService.GetSchema("RIS_FuenteRecoleccionDatos", "RisProvider"); }
		}
        
		public static TableSchema.Table RisFuncionEnElEquipo
		{
            get { return DataService.GetSchema("RIS_FuncionEnElEquipo", "RisProvider"); }
		}
        
		public static TableSchema.Table RisInvestigadore
		{
            get { return DataService.GetSchema("RIS_Investigadores", "RisProvider"); }
		}
        
		public static TableSchema.Table RisItemAprobado
		{
            get { return DataService.GetSchema("RIS_ItemAprobado", "RisProvider"); }
		}
        
		public static TableSchema.Table RisItemDesaprobado
		{
            get { return DataService.GetSchema("RIS_ItemDesaprobado", "RisProvider"); }
		}
        
		public static TableSchema.Table RisLugarRealizacion
		{
            get { return DataService.GetSchema("RIS_LugarRealizacion", "RisProvider"); }
		}
        
		public static TableSchema.Table RisNotum
		{
            get { return DataService.GetSchema("RIS_Nota", "RisProvider"); }
		}
        
		public static TableSchema.Table RisPoblacionVulnerable
		{
            get { return DataService.GetSchema("RIS_PoblacionVulnerable", "RisProvider"); }
		}
        
		public static TableSchema.Table RisPresentacionInforme
		{
            get { return DataService.GetSchema("RIS_PresentacionInforme", "RisProvider"); }
		}
        
		public static TableSchema.Table RisProfesion
		{
            get { return DataService.GetSchema("RIS_Profesion", "RisProvider"); }
		}
        
		public static TableSchema.Table RisTipoDocumento
		{
            get { return DataService.GetSchema("RIS_TipoDocumento", "RisProvider"); }
		}
        
		public static TableSchema.Table RisTipoTelefono
		{
            get { return DataService.GetSchema("RIS_TipoTelefono", "RisProvider"); }
		}
        
		public static TableSchema.Table RisVigenciaPoliza
		{
            get { return DataService.GetSchema("RIS_VigenciaPoliza", "RisProvider"); }
		}
        
		public static TableSchema.Table SysAntecedente
		{
            get { return DataService.GetSchema("Sys_Antecedente", "RisProvider"); }
		}
        
		public static TableSchema.Table SysAntecedenteEnfermedad
		{
            get { return DataService.GetSchema("Sys_AntecedenteEnfermedad", "RisProvider"); }
		}
        
		public static TableSchema.Table SysBarrio
		{
            get { return DataService.GetSchema("Sys_Barrio", "RisProvider"); }
		}
        
		public static TableSchema.Table SysCepSap
		{
            get { return DataService.GetSchema("Sys_CepSap", "RisProvider"); }
		}
        
		public static TableSchema.Table SysCIE10
		{
            get { return DataService.GetSchema("Sys_CIE10", "RisProvider"); }
		}
        
		public static TableSchema.Table SysCIE10Capitulo
		{
            get { return DataService.GetSchema("Sys_CIE10Capitulo", "RisProvider"); }
		}
        
		public static TableSchema.Table SysDefuncion
		{
            get { return DataService.GetSchema("sys_Defuncion", "RisProvider"); }
		}
        
		public static TableSchema.Table SysDepartamento
		{
            get { return DataService.GetSchema("Sys_Departamento", "RisProvider"); }
		}
        
		public static TableSchema.Table SysDireccione
		{
            get { return DataService.GetSchema("Sys_Direcciones", "RisProvider"); }
		}
        
		public static TableSchema.Table SysEfector
		{
            get { return DataService.GetSchema("Sys_Efector", "RisProvider"); }
		}
        
		public static TableSchema.Table SysEspecialidad
		{
            get { return DataService.GetSchema("Sys_Especialidad", "RisProvider"); }
		}
        
		public static TableSchema.Table SysEspecialidad2
		{
            get { return DataService.GetSchema("Sys_Especialidad2", "RisProvider"); }
		}
        
		public static TableSchema.Table SysEstablecimiento
		{
            get { return DataService.GetSchema("sys_Establecimiento", "RisProvider"); }
		}
        
		public static TableSchema.Table SysEstado
		{
            get { return DataService.GetSchema("Sys_Estado", "RisProvider"); }
		}
        
		public static TableSchema.Table SysEstadoCivil
		{
            get { return DataService.GetSchema("Sys_EstadoCivil", "RisProvider"); }
		}
        
		public static TableSchema.Table SysHistoriaClinica
		{
            get { return DataService.GetSchema("Sys_HistoriaClinica", "RisProvider"); }
		}
        
		public static TableSchema.Table SysIdioma
		{
            get { return DataService.GetSchema("Sys_Idioma", "RisProvider"); }
		}
        
		public static TableSchema.Table SysLocalidad
		{
            get { return DataService.GetSchema("Sys_Localidad", "RisProvider"); }
		}
        
		public static TableSchema.Table SysMedicamento
		{
            get { return DataService.GetSchema("Sys_Medicamento", "RisProvider"); }
		}
        
		public static TableSchema.Table SysMedicamentoRubro
		{
            get { return DataService.GetSchema("Sys_MedicamentoRubro", "RisProvider"); }
		}
        
		public static TableSchema.Table SysMenu
		{
            get { return DataService.GetSchema("Sys_Menu", "RisProvider"); }
		}
        
		public static TableSchema.Table SysModulo
		{
            get { return DataService.GetSchema("Sys_Modulo", "RisProvider"); }
		}
        
		public static TableSchema.Table SysMotivoNI
		{
            get { return DataService.GetSchema("Sys_MotivoNI", "RisProvider"); }
		}
        
		public static TableSchema.Table SysMovimientoHistoriaClinica
		{
            get { return DataService.GetSchema("Sys_MovimientoHistoriaClinica", "RisProvider"); }
		}
        
		public static TableSchema.Table SysMunicipio
		{
            get { return DataService.GetSchema("Sys_Municipio", "RisProvider"); }
		}
        
		public static TableSchema.Table SysNivelInstruccion
		{
            get { return DataService.GetSchema("Sys_NivelInstruccion", "RisProvider"); }
		}
        
		public static TableSchema.Table SysObraSocial
		{
            get { return DataService.GetSchema("Sys_ObraSocial", "RisProvider"); }
		}
        
		public static TableSchema.Table SysOcupacion
		{
            get { return DataService.GetSchema("Sys_Ocupacion", "RisProvider"); }
		}
        
		public static TableSchema.Table SysOrganismo
		{
            get { return DataService.GetSchema("Sys_Organismo", "RisProvider"); }
		}
        
		public static TableSchema.Table SysPaciente
		{
            get { return DataService.GetSchema("Sys_Paciente", "RisProvider"); }
		}
        
		public static TableSchema.Table SysPacienteAntecedentesFamiliare
		{
            get { return DataService.GetSchema("Sys_PacienteAntecedentesFamiliares", "RisProvider"); }
		}
        
		public static TableSchema.Table SysPacienteCeliaco
		{
            get { return DataService.GetSchema("Sys_PacienteCeliaco", "RisProvider"); }
		}
        
		public static TableSchema.Table SysPai
		{
            get { return DataService.GetSchema("Sys_Pais", "RisProvider"); }
		}
        
		public static TableSchema.Table SysParentesco
		{
            get { return DataService.GetSchema("Sys_Parentesco", "RisProvider"); }
		}
        
		public static TableSchema.Table SysParentescoTipo
		{
            get { return DataService.GetSchema("Sys_ParentescoTipo", "RisProvider"); }
		}
        
		public static TableSchema.Table SysPerfil
		{
            get { return DataService.GetSchema("Sys_Perfil", "RisProvider"); }
		}
        
		public static TableSchema.Table SysPermiso
		{
            get { return DataService.GetSchema("Sys_Permiso", "RisProvider"); }
		}
        
		public static TableSchema.Table SysPoblacion
		{
            get { return DataService.GetSchema("Sys_Poblacion", "RisProvider"); }
		}
        
		public static TableSchema.Table SysPoblacion1
		{
            get { return DataService.GetSchema("Sys_Poblacion1", "RisProvider"); }
		}
        
		public static TableSchema.Table SysProfesion
		{
            get { return DataService.GetSchema("Sys_Profesion", "RisProvider"); }
		}
        
		public static TableSchema.Table SysProfesional
		{
            get { return DataService.GetSchema("Sys_Profesional", "RisProvider"); }
		}
        
		public static TableSchema.Table SysProvincium
		{
            get { return DataService.GetSchema("Sys_Provincia", "RisProvider"); }
		}
        
		public static TableSchema.Table SysRelAntecedentePaciente
		{
            get { return DataService.GetSchema("Sys_RelAntecedentePaciente", "RisProvider"); }
		}
        
		public static TableSchema.Table SysRelEspecialidadEfector
		{
            get { return DataService.GetSchema("Sys_RelEspecialidadEfector", "RisProvider"); }
		}
        
		public static TableSchema.Table SysRelEstadoMotivoNI
		{
            get { return DataService.GetSchema("Sys_RelEstadoMotivoNI", "RisProvider"); }
		}
        
		public static TableSchema.Table SysRelFormularioCobertura
		{
            get { return DataService.GetSchema("Sys_RelFormularioCobertura", "RisProvider"); }
		}
        
		public static TableSchema.Table SysRelHistoriaClinicaEfector
		{
            get { return DataService.GetSchema("Sys_RelHistoriaClinicaEfector", "RisProvider"); }
		}
        
		public static TableSchema.Table SysRelPacienteObraSocial
		{
            get { return DataService.GetSchema("Sys_RelPacienteObraSocial", "RisProvider"); }
		}
        
		public static TableSchema.Table SysRelProfesionalEfector
		{
            get { return DataService.GetSchema("Sys_RelProfesionalEfector", "RisProvider"); }
		}
        
		public static TableSchema.Table SysRelServicioEfector
		{
            get { return DataService.GetSchema("Sys_RelServicioEfector", "RisProvider"); }
		}
        
		public static TableSchema.Table SysServicio
		{
            get { return DataService.GetSchema("Sys_Servicio", "RisProvider"); }
		}
        
		public static TableSchema.Table SysSexo
		{
            get { return DataService.GetSchema("Sys_Sexo", "RisProvider"); }
		}
        
		public static TableSchema.Table SysSituacionLaboral
		{
            get { return DataService.GetSchema("Sys_SituacionLaboral", "RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoAntecedente
		{
            get { return DataService.GetSchema("Sys_TipoAntecedente", "RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoCobertura
		{
            get { return DataService.GetSchema("Sys_TipoCobertura", "RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoDocumento
		{
            get { return DataService.GetSchema("Sys_TipoDocumento", "RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoEfector
		{
            get { return DataService.GetSchema("Sys_TipoEfector", "RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoObraSocial
		{
            get { return DataService.GetSchema("Sys_TipoObraSocial", "RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoProfesional
		{
            get { return DataService.GetSchema("Sys_TipoProfesional", "RisProvider"); }
		}
        
		public static TableSchema.Table SysUsuario
		{
            get { return DataService.GetSchema("Sys_Usuario", "RisProvider"); }
		}
        
		public static TableSchema.Table SysZona
		{
            get { return DataService.GetSchema("Sys_Zona", "RisProvider"); }
		}
        
	
    }
    #endregion
    #region View Struct
    public partial struct Views 
    {
		
		public static readonly string SysPerfilEfector = @"SYS_PerfilEfector";
        
    }
    #endregion
    
    #region Query Factories
	public static partial class DB
	{
        public static DataProvider _provider = DataService.Providers["RisProvider"];
        static ISubSonicRepository _repository;
        public static ISubSonicRepository Repository 
        {
            get 
            {
                if (_repository == null)
                    return new SubSonicRepository(_provider);
                return _repository; 
            }
            set { _repository = value; }
        }
        public static Select SelectAllColumnsFrom<T>() where T : RecordBase<T>, new()
	    {
            return Repository.SelectAllColumnsFrom<T>();
	    }
	    public static Select Select()
	    {
            return Repository.Select();
	    }
	    
		public static Select Select(params string[] columns)
		{
            return Repository.Select(columns);
        }
	    
		public static Select Select(params Aggregate[] aggregates)
		{
            return Repository.Select(aggregates);
        }
   
	    public static Update Update<T>() where T : RecordBase<T>, new()
	    {
            return Repository.Update<T>();
	    }
	    
	    public static Insert Insert()
	    {
            return Repository.Insert();
	    }
	    
	    public static Delete Delete()
	    {
            return Repository.Delete();
	    }
	    
	    public static InlineQuery Query()
	    {
            return Repository.Query();
	    }
	    	    
	    
	}
    #endregion
    
}
#region Databases
public partial struct Databases 
{
	
	public static readonly string RisProvider = @"RisProvider";
    
}
#endregion