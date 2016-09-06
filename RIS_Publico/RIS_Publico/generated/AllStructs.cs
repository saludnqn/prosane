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
	#region Tables Struct
	public partial struct Tables
	{
		
		public static string AfiliadosParaSip = @"AFILIADOS_PARA_SIPS";
        
		public static string AprAborto = @"APR_Aborto";
        
		public static string AprAcompañante = @"APR_Acompañante";
        
		public static string AprActividad = @"APR_Actividad";
        
		public static string AprActividadControlPerinatal = @"APR_ActividadControlPerinatal";
        
		public static string AprActividadEmbarazo = @"APR_ActividadEmbarazo";
        
		public static string AprActividadFisica = @"APR_ActividadFisica";
        
		public static string AprActualPatologiaEmbarazo = @"APR_ActualPatologiaEmbarazo";
        
		public static string AprAlertaControlMenor = @"APR_AlertaControlMenor";
        
		public static string AprAlimentacionRecienNacido = @"APR_AlimentacionRecienNacido";
        
		public static string AprAlturaUterina = @"APR_AlturaUterina";
        
		public static string AprAmbienteProcedimiento = @"APR_AmbienteProcedimiento";
        
		public static string AprAntecedentePatologiaEmbarazo = @"APR_AntecedentePatologiaEmbarazo";
        
		public static string AprAntecedentePerinatal = @"APR_AntecedentePerinatal";
        
		public static string AprAntecedentePerinatalNacimiento = @"APR_AntecedentePerinatalNacimiento";
        
		public static string AprAplicacionVacuna = @"APR_AplicacionVacuna";
        
		public static string AprAreaDesarrollo = @"APR_AreaDesarrollo";
        
		public static string AprCalendarioVacuna = @"APR_CalendarioVacuna";
        
		public static string AprCalendarioVisita = @"APR_CalendarioVisitas";
        
		public static string AprCategoriaPesoNacimiento = @"APR_CategoriaPesoNacimiento";
        
		public static string AprCentilesIMCEdadGestacional = @"APR_CentilesIMCEdadGestacional";
        
		public static string AprCMOtrosDato = @"APR_CMOtrosDatos";
        
		public static string AprComplicacionAborto = @"APR_ComplicacionAborto";
        
		public static string AprComplicacionIntraoperatorium = @"APR_ComplicacionIntraoperatoria";
        
		public static string AprConcejerium = @"APR_Concejeria";
        
		public static string AprCondicionesVivienda = @"APR_CondicionesVivienda";
        
		public static string AprCondicionIngreso = @"APR_CondicionIngreso";
        
		public static string AprConsultaAntenatal = @"APR_ConsultaAntenatal";
        
		public static string AprControlNiñoSano = @"APR_ControlNiñoSano";
        
		public static string AprControlNiñoSanoConsultorio = @"APR_ControlNiñoSanoConsultorio";
        
		public static string AprControlNiñoSanoEnfermerium = @"APR_ControlNiñoSanoEnfermeria";
        
		public static string AprControlNiñoSanoHemoglobina = @"APR_ControlNiñoSanoHemoglobina";
        
		public static string AprControlNiñoSanoOdontologico = @"APR_ControlNiñoSanoOdontologico";
        
		public static string AprControlOdontologico = @"APR_ControlOdontologico";
        
		public static string AprDefectoCongenito = @"APR_DefectoCongenito";
        
		public static string AprDiagnosticoControlOdontologico = @"APR_DiagnosticoControlOdontologico";
        
		public static string AprEgresoMaterno = @"APR_EgresoMaterno";
        
		public static string AprEgresoPorAborto = @"APR_EgresoPorAborto";
        
		public static string AprEmbarazo = @"APR_Embarazo";
        
		public static string AprEstadoNacimiento = @"APR_EstadoNacimiento";
        
		public static string AprEstadoNutricional = @"APR_EstadoNutricional";
        
		public static string AprEstiloVida = @"APR_EstiloVida";
        
		public static string AprEtnium = @"APR_Etnia";
        
		public static string AprFactorProtector = @"APR_FactorProtector";
        
		public static string AprFactorRiesgo = @"APR_FactorRiesgo";
        
		public static string AprFactorRiesgoEstiloVida = @"APR_FactorRiesgoEstiloVida";
        
		public static string AprFactorRiesgoPsicosocial = @"APR_FactorRiesgoPsicosocial";
        
		public static string AprFormaConcejerium = @"APR_FormaConcejeria";
        
		public static string AprHistoriaClinicaPerinatal = @"APR_HistoriaClinicaPerinatal";
        
		public static string AprHistoriaClinicaPerinatalDetalle = @"APR_HistoriaClinicaPerinatalDetalle";
        
		public static string AprInicioEmbarazo = @"APR_InicioEmbarazo";
        
		public static string AprInterconsultum = @"APR_Interconsulta";
        
		public static string AprIntervencion = @"APR_Intervencion";
        
		public static string AprIntervencionProfesional = @"APR_IntervencionProfesional";
        
		public static string AprMomentoNacimiento = @"APR_MomentoNacimiento";
        
		public static string AprMotivoVisitaDomiciliarium = @"APR_MotivoVisitaDomiciliaria";
        
		public static string AprNumeroDosi = @"APR_NumeroDosis";
        
		public static string AprPartoProvisorio = @"APR_PartoProvisorio";
        
		public static string AprPercentilesIMCEdad = @"APR_PercentilesIMCEdad";
        
		public static string AprPercentilesLongitudEstaturaEdad = @"APR_PercentilesLongitudEstaturaEdad";
        
		public static string AprPercentilesPerimetroCefalicoEdad = @"APR_PercentilesPerimetroCefalicoEdad";
        
		public static string AprPercentilesPesoEdad = @"APR_PercentilesPesoEdad";
        
		public static string AprPercentilesPesoEstatura = @"APR_PercentilesPesoEstatura";
        
		public static string AprPercentilesPesoLongitud = @"APR_PercentilesPesoLongitud";
        
		public static string AprProblemasMenor = @"APR_ProblemasMenor";
        
		public static string AprRecienNacido = @"APR_RecienNacido";
        
		public static string AprRelControlNiñoSanoAreaDesarrollo = @"APR_RelControlNiñoSanoAreaDesarrollo";
        
		public static string AprRelControlNiñoSanoFactorRiesgo = @"APR_RelControlNiñoSanoFactorRiesgo";
        
		public static string AprRelControNiñoSanoFactorProtector = @"APR_RelControNiñoSanoFactorProtector";
        
		public static string AprRelPersonaFactorRiesgoInicial = @"APR_RelPersonaFactorRiesgoInicial";
        
		public static string AprRelRecienNacidoDefectoCongenito = @"APR_RelRecienNacidoDefectoCongenito";
        
		public static string AprRelRecienNacidoEnfermedad = @"APR_RelRecienNacidoEnfermedad";
        
		public static string AprTallaEdad = @"APR_TallaEdad";
        
		public static string AprTerminacionParto = @"APR_TerminacionParto";
        
		public static string AprTipoActividadEmbarazo = @"APR_TipoActividadEmbarazo";
        
		public static string AprTipoLactancium = @"APR_TipoLactancia";
        
		public static string AprTipoParto = @"APR_TipoParto";
        
		public static string AprTipoProfesional = @"APR_TipoProfesional";
        
		public static string AprVisitaDomiciliarium = @"APR_VisitaDomiciliaria";
        
		public static string AprZScoreIMCEdad = @"APR_ZScoreIMCEdad";
        
		public static string AprZScoreLongitudEstaturaEdad = @"APR_ZScoreLongitudEstaturaEdad";
        
		public static string AprZScorePerimetroCefalicoEdad = @"APR_ZScorePerimetroCefalicoEdad";
        
		public static string AprZScorePesoEdad = @"APR_ZScorePesoEdad";
        
		public static string AprZScorePesoEstatura = @"APR_ZScorePesoEstatura";
        
		public static string AprZScorePesoLongitud = @"APR_ZScorePesoLongitud";
        
		public static string AutAccidente = @"AUT_Accidente";
        
		public static string AutChofCurso = @"Aut_ChofCursos";
        
		public static string AutChofer = @"AUT_Chofer";
        
		public static string AutCurso = @"Aut_Cursos";
        
		public static string AutDireccione = @"AUT_Direcciones";
        
		public static string AutEntidad = @"AUT_Entidad";
        
		public static string AutEstadosMov = @"AUT_EstadosMov";
        
		public static string AutHistoricoVehiculoPmp = @"AUT_Historico_Vehiculo_PMP";
        
		public static string AutItemMovimiento = @"AUT_ItemMovimiento";
        
		public static string AutMarca = @"AUT_Marca";
        
		public static string AutModelo = @"AUT_Modelo";
        
		public static string AutMovimiento = @"AUT_Movimiento";
        
		public static string AutMovimientoItemMovimiento = @"AUT_Movimiento_ItemMovimiento";
        
		public static string AutNotaPedido = @"Aut_NotaPedido";
        
		public static string AutOrdenReparacion = @"Aut_OrdenReparacion";
        
		public static string AutOrdenRepItem = @"Aut_OrdenRepItem";
        
		public static string AutOrigenDestino = @"AUT_OrigenDestino";
        
		public static string AutPmp = @"AUT_PMP";
        
		public static string AutPmpItemMovimiento = @"AUT_PMP_ItemMovimiento";
        
		public static string AutPresupuesto = @"Aut_Presupuesto";
        
		public static string AutProveedor = @"AUT_Proveedor";
        
		public static string AutTipoEntidad = @"AUT_TipoEntidad";
        
		public static string AutTipoMovimiento = @"AUT_TipoMovimiento";
        
		public static string AutTipoPNP = @"Aut_TipoPNP";
        
		public static string AutTipoProveedor = @"Aut_TipoProveedor";
        
		public static string AutTipoTraslado = @"Aut_TipoTraslado";
        
		public static string AutTipoVehiculo = @"AUT_TipoVehiculo";
        
		public static string AutTraslado = @"Aut_Traslado";
        
		public static string AutVehiculo = @"AUT_Vehiculo";
        
		public static string AutVehiculoPmp = @"AUT_Vehiculo_PMP";
        
		public static string AutViaje = @"AUT_Viaje";
        
		public static string BdsAdmision = @"BDS_Admision";
        
		public static string BdsDonante = @"BDS_Donante";
        
		public static string BdsHematologium = @"BDS_Hematologia";
        
		public static string BdsHemocomponente = @"BDS_Hemocomponente";
        
		public static string BdsIncidenciaExtraccion = @"BDS_IncidenciaExtraccion";
        
		public static string BdsProductoAdmision = @"BDS_ProductoAdmision";
        
		public static string BdsSerologium = @"BDS_Serologia";
        
		public static string BdsTipoDonante = @"BDS_TipoDonante";
        
		public static string BdsTipoExclusion = @"BDS_TipoExclusion";
        
		public static string BdsUsoHemocomponente = @"BDS_UsoHemocomponente";
        
		public static string BkpOdoNomenclador = @"bkp_ODO_Nomenclador";
        
		public static string BorrarPrueba = @"BorrarPrueba";
        
		public static string CamEstado = @"CAM_Estado";
        
		public static string CamServicio = @"CAM_Servicios";
        
		public static string CIE10 = @"CIE10";
        
		public static string CIE10Heller = @"CIE10_Heller";
        
		public static string Clasificado = @"Clasificados";
        
		public static string ConAgenda = @"CON_Agenda";
        
		public static string ConAgendaAuditorium = @"CON_AgendaAuditoria";
        
		public static string ConAgendaBloqueo = @"CON_AgendaBloqueo";
        
		public static string ConAgendaEstado = @"CON_AgendaEstado";
        
		public static string ConAgendaGrupal = @"CON_AgendaGrupal";
        
		public static string ConAgendaGrupalOrganismo = @"CON_AgendaGrupalOrganismo";
        
		public static string ConAgendaGrupalPaciente = @"CON_AgendaGrupalPaciente";
        
		public static string ConAgendaGrupalProfesional = @"CON_AgendaGrupalProfesional";
        
		public static string ConAgendaProfesional = @"CON_AgendaProfesional";
        
		public static string ConConsultum = @"CON_Consulta";
        
		public static string ConConsultaDiagnostico = @"CON_ConsultaDiagnostico";
        
		public static string ConConsultaMedicamento = @"CON_ConsultaMedicamento";
        
		public static string ConConsultaOdontologium = @"CON_ConsultaOdontologia";
        
		public static string ConConsultorio = @"CON_Consultorio";
        
		public static string ConConsultorioTipo = @"CON_ConsultorioTipo";
        
		public static string ConDemanda = @"CON_Demanda";
        
		public static string ConDemandaRechazada = @"CON_DemandaRechazada";
        
		public static string ConEquipo = @"CON_Equipo";
        
		public static string ConLugarActividadGrupal = @"CON_LugarActividadGrupal";
        
		public static string ConMotivoBaja = @"CON_MotivoBaja";
        
		public static string ConMotivoInactivacionAgenda = @"CON_MotivoInactivacionAgenda";
        
		public static string ConMotivosDeBloqueo = @"CON_MotivosDeBloqueo";
        
		public static string ConMotivosRechazo = @"CON_MotivosRechazo";
        
		public static string ConNivelDeAbordaje = @"CON_NivelDeAbordaje";
        
		public static string ConTematica = @"CON_Tematica";
        
		public static string ConTiempoInsumido = @"CON_TiempoInsumido";
        
		public static string ConTipoActividadGrupal = @"CON_TipoActividadGrupal";
        
		public static string ConTipoDePrestacionSaludMental = @"CON_TipoDePrestacionSaludMental";
        
		public static string ConTipoPrestacion = @"CON_TipoPrestacion";
        
		public static string ConTurno = @"CON_Turno";
        
		public static string ConTurnoAsistencium = @"CON_TurnoAsistencia";
        
		public static string ConTurnoAuditorium = @"CON_TurnoAuditoria";
        
		public static string ConTurnoBloqueo = @"CON_TurnoBloqueo";
        
		public static string ConTurnoEstado = @"CON_TurnoEstado";
        
		public static string ConTurnoRecitum = @"CON_TurnoRecita";
        
		public static string ConTurnoReserva = @"CON_TurnoReserva";
        
		public static string ConTurnoReservaInterconsultum = @"CON_TurnoReservaInterconsulta";
        
		public static string Duration = @"Duration";
        
		public static string EmrBase = @"EMR_Base";
        
		public static string EmrGlasgowMotor = @"EMR_GlasgowMotor";
        
		public static string EmrGlasgowOcular = @"EMR_GlasgowOcular";
        
		public static string EmrGlasgowVerbal = @"EMR_GlasgowVerbal";
        
		public static string EmrPrehospitalarium = @"EMR_Prehospitalaria";
        
		public static string EmrPupila = @"EMR_Pupilas";
        
		public static string EmrRegistro = @"EMR_Registro";
        
		public static string EmrRelAntecedentePaciente = @"EMR_RelAntecedentePaciente";
        
		public static string EmrRelTraumaPrehospitalarium = @"EMR_RelTraumaPrehospitalaria";
        
		public static string EmrTipoTrauma = @"EMR_TipoTrauma";
        
		public static string EmrTrauma = @"EMR_Trauma";
        
		public static string FacCapitulo = @"FAC_Capitulo";
        
		public static string FacContratoObraSocial = @"FAC_ContratoObraSocial";
        
		public static string FacExtOrden = @"FAC_EXT_Orden";
        
		public static string FacExtOrdenDetalle = @"FAC_EXT_OrdenDetalle";
        
		public static string FacExtPaciente = @"FAC_EXT_Paciente";
        
		public static string FacFactura = @"FAC_Factura";
        
		public static string FacFacturaDetalle = @"FAC_FacturaDetalle";
        
		public static string FacJefeLaboratorio = @"FAC_JefeLaboratorio";
        
		public static string FacNomenclador = @"FAC_Nomenclador";
        
		public static string FacNomencladorOrig = @"FAC_Nomenclador_orig";
        
		public static string FacNomenclador2012 = @"FAC_Nomenclador2012";
        
		public static string FacNomenclador2015 = @"FAC_Nomenclador2015";
        
		public static string FacNomencladorExclusion = @"FAC_NomencladorExclusion";
        
		public static string FacOrden = @"FAC_Orden";
        
		public static string FacOrdenDetalle = @"FAC_OrdenDetalle";
        
		public static string FacOrdenDocumentacion = @"FAC_OrdenDocumentacion";
        
		public static string FacOrdenLaboratorio = @"FAC_OrdenLaboratorio";
        
		public static string FacOrdenPaciente = @"FAC_OrdenPaciente";
        
		public static string FacOrdenTurno = @"FAC_OrdenTurno";
        
		public static string FacPadron = @"FAC_Padron";
        
		public static string FacPrecioNaftum = @"FAC_PrecioNafta";
        
		public static string FacPreFactura = @"FAC_PreFactura";
        
		public static string FacRelEspecialidadNomenclador = @"FAC_RelEspecialidadNomenclador";
        
		public static string FacRelPerfilPaginaPrincipal = @"FAC_RelPerfilPaginaPrincipal";
        
		public static string FacTipoFactura = @"FAC_TipoFactura";
        
		public static string FacTipoIva = @"FAC_TipoIva";
        
		public static string FacTipoNomenclador = @"FAC_TipoNomenclador";
        
		public static string FacTipoPractica = @"FAC_TipoPractica";
        
		public static string FacUnidad = @"FAC_Unidad";
        
		public static string GuardiaAntecedente = @"Guardia_Antecedentes";
        
		public static string GuardiaC2 = @"Guardia_C2";
        
		public static string GuardiaMedicosFuncione = @"Guardia_Medicos_Funciones";
        
		public static string GuardiaMedicosRegistroIngreso = @"Guardia_Medicos_registroIngreso";
        
		public static string GuardiaMedicosTiposFuncione = @"Guardia_Medicos_TiposFunciones";
        
		public static string GuardiaMensaje = @"Guardia_Mensajes";
        
		public static string GuardiaPracticasClase = @"Guardia_Practicas_Clases";
        
		public static string GuardiaPracticasEstado = @"Guardia_Practicas_Estados";
        
		public static string GuardiaPracticasPrioridade = @"Guardia_Practicas_Prioridades";
        
		public static string GuardiaPrescripcione = @"Guardia_Prescripciones";
        
		public static string GuardiaRegistro = @"Guardia_Registros";
        
		public static string GuardiaRegistrosClasificacione = @"Guardia_Registros_Clasificaciones";
        
		public static string GuardiaRegistrosDiagnostico = @"Guardia_Registros_Diagnosticos";
        
		public static string GuardiaRegistrosDiagnosticosCie10 = @"Guardia_Registros_Diagnosticos_Cie10";
        
		public static string GuardiaRegistrosEstado = @"Guardia_Registros_Estados";
        
		public static string GuardiaRegistrosHistorial = @"Guardia_Registros_Historial";
        
		public static string GuardiaRegistrosMedicosResponsable = @"Guardia_Registros_MedicosResponsables";
        
		public static string GuardiaRegistrosPractica = @"Guardia_Registros_Practicas";
        
		public static string GuardiaRegistrosPracticasLaboratorio = @"Guardia_Registros_Practicas_Laboratorio";
        
		public static string GuardiaTipoPractica = @"Guardia_TipoPracticas";
        
		public static string GuardiaTiposEgreso = @"Guardia_TiposEgresos";
        
		public static string GuardiaTiposIngreso = @"Guardia_TiposIngreso";
        
		public static string GuardiaTriage = @"Guardia_Triage";
        
		public static string GuardiaTurnero = @"Guardia_Turnero";
        
		public static string HidHidatidosi = @"Hid_Hidatidosis";
        
		public static string HidHidatidosisParcial = @"Hid_HidatidosisParcial";
        
		public static string IcoDestinatarioInterconsultum = @"ICO_DestinatarioInterconsulta";
        
		public static string IcoDialogoInterconsultum = @"ICO_DialogoInterconsulta";
        
		public static string IcoInterconsultum = @"ICO_Interconsulta";
        
		public static string IcoTiposUsuario = @"ICO_TiposUsuario";
        
		public static string IcoUbicacionArchivo = @"ICO_UbicacionArchivos";
        
		public static string InsAlarma = @"INS_Alarma";
        
		public static string InsDatoFarmaceutico = @"INS_DatoFarmaceutico";
        
		public static string InsDeposito = @"INS_Deposito";
        
		public static string InsDosi = @"INS_Dosis";
        
		public static string InsEstadoPedido = @"INS_EstadoPedido";
        
		public static string InsFoo = @"INS_Foo";
        
		public static string InsInsumo = @"INS_Insumo";
        
		public static string InsInsumoOld = @"INS_Insumo_old";
        
		public static string InsInsumosEquivalente = @"INS_InsumosEquivalentes";
        
		public static string InsInternacionPedido = @"INS_InternacionPedido";
        
		public static string InsMotivosRechazo = @"INS_MotivosRechazo";
        
		public static string InsMovimiento = @"INS_Movimiento";
        
		public static string InsMovimientoDetalle = @"INS_MovimientoDetalle";
        
		public static string InsOrdenCompra = @"INS_OrdenCompra";
        
		public static string InsPedido = @"INS_Pedido";
        
		public static string InsPedidoDetalle = @"INS_PedidoDetalle";
        
		public static string InsPrescripcion = @"INS_Prescripcion";
        
		public static string InsPrescripcionDetalle = @"INS_PrescripcionDetalle";
        
		public static string InsPrescripcionEntrega = @"INS_PrescripcionEntrega";
        
		public static string InsPrograma = @"INS_Programa";
        
		public static string InsProveedor = @"INS_Proveedor";
        
		public static string InsRelInsumoEfector = @"INS_RelInsumoEfector";
        
		public static string InsRelInsumoPrograma = @"INS_RelInsumoPrograma";
        
		public static string InsRubro = @"INS_Rubro";
        
		public static string InsTipoComprobante = @"INS_TipoComprobante";
        
		public static string JmCargo = @"JM_Cargo";
        
		public static string JmCertificadoMedico = @"JM_CertificadoMedico";
        
		public static string JmDato = @"JM_Datos";
        
		public static string JmDetalle = @"JM_Detalle";
        
		public static string JmLPago = @"JM_LPago";
        
		public static string JmNacionalidad = @"JM_Nacionalidad";
        
		public static string JmParte = @"JM_Partes";
        
		public static string JmPersonal = @"JM_Personal";
        
		public static string JmProfesional = @"JM_Profesional";
        
		public static string JmResponsable = @"JM_Responsables";
        
		public static string LabAcceso = @"LAB_Acceso";
        
		public static string LabAccesoResultado = @"LAB_AccesoResultado";
        
		public static string LabAlarmaScreening = @"LAB_AlarmaScreening";
        
		public static string LabDetalleSolicitudScreening = @"LAB_DetalleSolicitudScreening";
        
		public static string LabItemRepeticionScreening = @"LAB_ItemRepeticionScreening";
        
		public static string LabItemScreening = @"LAB_ItemScreening";
        
		public static string LabItemScreeningResultado = @"LAB_ItemScreeningResultado";
        
		public static string LabMetodoScreening = @"LAB_MetodoScreening";
        
		public static string LabMotivoRechazoScreening = @"LAB_MotivoRechazoScreening";
        
		public static string LabMotivoRepeticionScreening = @"LAB_MotivoRepeticionScreening";
        
		public static string LabProtocoloScreening = @"LAB_ProtocoloScreening";
        
		public static string LabProtocoloScreeningDetalle = @"LAB_ProtocoloScreeningDetalle";
        
		public static string LabReactivo = @"LAB_Reactivo";
        
		public static string LabResultadoDetalle = @"LAB_ResultadoDetalle";
        
		public static string LabResultadoEncabezado = @"LAB_ResultadoEncabezado";
        
		public static string LabResultadoScreening = @"LAB_ResultadoScreening";
        
		public static string LabSolicitudScreening = @"LAB_SolicitudScreening";
        
		public static string LabSolicitudScreeningEstado = @"Lab_SolicitudScreeningEstados";
        
		public static string LabSolicitudScreeningRepeticion = @"LAB_SolicitudScreeningRepeticion";
        
		public static string LabTempResultadoDetalle = @"LAB_Temp_ResultadoDetalle";
        
		public static string LabTempResultadoEncabezado = @"LAB_Temp_ResultadoEncabezado";
        
		public static string LabTempSolicitudScreening20131209 = @"Lab_temp_SolicitudScreening20131209";
        
		public static string LabTempResultadoTarjetasScreening = @"Lab_TempResultadoTarjetasScreening";
        
		public static string Localidad = @"Localidad";
        
		public static string MamAnatomiaPatologica = @"MAM_AnatomiaPatologica";
        
		public static string MamAntecedente = @"MAM_Antecedentes";
        
		public static string MamBirad = @"MAM_Birads";
        
		public static string MamCirugium = @"MAM_Cirugia";
        
		public static string MamDiagnosticoCitologico = @"MAM_DiagnosticoCitologico";
        
		public static string MamDiagnoticoHistologico = @"MAM_DiagnoticoHistologico";
        
		public static string MamEcografium = @"MAM_Ecografia";
        
		public static string MamEstudiosAdicionale = @"MAM_EstudiosAdicionales";
        
		public static string MamEstudiosHospitalProvincial = @"MAM_EstudiosHospitalProvincial";
        
		public static string MamExamenFisico = @"MAM_ExamenFisico";
        
		public static string MamMaterial = @"MAM_Material";
        
		public static string MamMotivo = @"MAM_Motivo";
        
		public static string MamMotivoConsultum = @"MAM_MotivoConsulta";
        
		public static string MamPiezaQuirurgica = @"MAM_PiezaQuirurgica";
        
		public static string MamRegistro = @"MAM_Registro";
        
		public static string MamResultadoExFisico = @"MAM_ResultadoExFisico";
        
		public static string MamTipoCirugium = @"MAM_TipoCirugia";
        
		public static string MamTipoEquipo = @"MAM_TipoEquipo";
        
		public static string MamTipoEstudio = @"MAM_TipoEstudio";
        
		public static string MamTipoMotivoConsultum = @"MAM_TipoMotivoConsulta";
        
		public static string MamTratamiento = @"MAM_Tratamientos";
        
		public static string Nomivac = @"Nomivac";
        
		public static string OdoNomenclador = @"ODO_Nomenclador";
        
		public static string OdoPrograma = @"ODO_Programa";
        
		public static string PacientesVillaFarrel = @"Pacientes_VillaFarrel";
        
		public static string PhpssAccount = @"phpss_account";
        
		public static string PhpssAccountGroup = @"phpss_account_group";
        
		public static string PhpssBruteforceAccount = @"phpss_bruteforce_account";
        
		public static string PhpssBruteforceAccountFail = @"phpss_bruteforce_account_fail";
        
		public static string PhpssBruteforceAccountLock = @"phpss_bruteforce_account_lock";
        
		public static string PhpssBruteforceIp = @"phpss_bruteforce_ip";
        
		public static string PhpssBruteforceIpFail = @"phpss_bruteforce_ip_fail";
        
		public static string PhpssBruteforceIpLock = @"phpss_bruteforce_ip_lock";
        
		public static string PhpssGroup = @"phpss_group";
        
		public static string PhpssIp = @"phpss_ip";
        
		public static string PhpssIpaccess = @"phpss_ipaccess";
        
		public static string PhpssIpaccessAccount = @"phpss_ipaccess_account";
        
		public static string PhpssIpaccessGroup = @"phpss_ipaccess_group";
        
		public static string PhpssLog = @"phpss_log";
        
		public static string PhpssSession = @"phpss_session";
        
		public static string PhpssSvar = @"phpss_svars";
        
		public static string PhpssUsertrackReq = @"phpss_usertrack_req";
        
		public static string PhpssUsertrackUrl = @"phpss_usertrack_url";
        
		public static string PnAccidentesLab = @"PN_accidentes_lab";
        
		public static string PnAfjp = @"PN_afjp";
        
		public static string PnAgenteInscriptor = @"PN_agente_inscriptor";
        
		public static string PnAltum = @"PN_alta";
        
		public static string PnAnexo = @"PN_anexo";
        
		public static string PnArbol = @"PN_arbol";
        
		public static string PnArchivoManual = @"PN_archivo_manual";
        
		public static string PnArchivosCaso = @"PN_archivos_casos";
        
		public static string PnArchivosEnviado = @"PN_archivos_enviados";
        
		public static string PnArchivosRecibido = @"PN_archivos_recibidos";
        
		public static string PnArea = @"PN_areas";
        
		public static string PnAsistencium = @"PN_asistencia";
        
		public static string PnAusentismo = @"PN_ausentismo";
        
		public static string PnBarrio = @"PN_barrios";
        
		public static string PnBeneficiario = @"PN_beneficiarios";
        
		public static string PnBorrar = @"PN_Borrar";
        
		public static string PnCalculaPrecio = @"PN_calcula_precio";
        
		public static string PnCalificacion = @"PN_calificacion";
        
		public static string PnCapacitacione = @"PN_capacitaciones";
        
		public static string PnCapacitado = @"PN_capacitados";
        
		public static string PnCapsHacenParto = @"PN_caps_hacen_partos";
        
		public static string PnCategoria = @"PN_categorias";
        
		public static string PnClasificacionManual = @"PN_clasificacion_manual";
        
		public static string PnComprobante = @"PN_comprobante";
        
		public static string PnCredito = @"PN_credito";
        
		public static string PnCurriculumIdioma = @"PN_curriculum_idiomas";
        
		public static string PnCurriculumReferencium = @"PN_curriculum_referencia";
        
		public static string PnDatMinObl = @"PN_dat_min_obl";
        
		public static string PnDatosReportable = @"PN_datos_reportables";
        
		public static string PnDebito = @"PN_debito";
        
		public static string PnDepartamento = @"PN_departamentos";
        
		public static string PnDescIndicadorIn = @"PN_desc_indicador_ins";
        
		public static string PnDiasSemana = @"PN_dias_semana";
        
		public static string PnDirectoriosArchivo = @"PN_directorios_archivos";
        
		public static string PnDistrito = @"PN_distrito";
        
		public static string PnDosisApli = @"PN_dosis_apli";
        
		public static string PnDpto = @"PN_dpto";
        
		public static string PnEfeConv = @"PN_efe_conv";
        
		public static string PnEfecNom = @"PN_efec_nom";
        
		public static string PnEgreso = @"PN_egreso";
        
		public static string PnEmbarazada = @"PN_embarazadas";
        
		public static string PnEnfermedade = @"PN_enfermedades";
        
		public static string PnEntrega = @"PN_entrega";
        
		public static string PnEvaluadore = @"PN_evaluadores";
        
		public static string PnEvento = @"PN_evento";
        
		public static string PnExpediente = @"PN_expediente";
        
		public static string PnFactura = @"PN_factura";
        
		public static string PnFamilium = @"PN_familia";
        
		public static string PnFeriado = @"PN_feriados";
        
		public static string PnGrupoPrestacion = @"PN_grupo_prestacion";
        
		public static string PnGrupo = @"PN_grupos";
        
		public static string PnGruposUsuario = @"PN_grupos_usuarios";
        
		public static string PnHistoricotemp = @"PN_historicotemp";
        
		public static string PnHorariosTrabajo = @"PN_horarios_trabajo";
        
		public static string PnInasistencium = @"PN_inasistencia";
        
		public static string PnInciso = @"PN_inciso";
        
		public static string PnIncisoItemGasto = @"PN_inciso_item_gasto";
        
		public static string PnIndicadoresGlobale = @"PN_indicadores_globales";
        
		public static string PnIndicadoresIn = @"PN_indicadores_ins";
        
		public static string PnIngreso = @"PN_ingreso";
        
		public static string PnItemGasto = @"PN_item_gasto";
        
		public static string PnLegajo = @"PN_legajos";
        
		public static string PnLegajosExt = @"PN_legajos_ext";
        
		public static string PnLengua = @"PN_lenguas";
        
		public static string PnLocalidade = @"PN_localidades";
        
		public static string PnLogComprobante = @"PN_log_comprobante";
        
		public static string PnLogEvento = @"PN_log_evento";
        
		public static string PnLogFactura = @"PN_log_factura";
        
		public static string PnLogManual = @"PN_log_manual";
        
		public static string PnLogPacPap = @"PN_log_pac_pap";
        
		public static string PnLogPlanilla = @"PN_log_planilla";
        
		public static string PnLogPrestacion = @"PN_log_prestacion";
        
		public static string PnMailEfeConv = @"PN_mail_efe_conv";
        
		public static string PnManual = @"PN_manual";
        
		public static string PnMensaje = @"PN_mensajes";
        
		public static string PnMotivoD = @"PN_motivo_d";
        
		public static string PnMu = @"PN_mu";
        
		public static string PnMunicipio = @"PN_municipios";
        
		public static string PnNino = @"PN_nino";
        
		public static string PnNinoNew = @"PN_nino_new";
        
		public static string PnNoConformidad = @"PN_no_conformidad";
        
		public static string PnNomenclador = @"PN_nomenclador";
        
		public static string PnNomencladorDetalle = @"PN_nomenclador_detalle";
        
		public static string PnNomencladorXPatologium = @"PN_NomencladorXPatologia";
        
		public static string PnObrasSociale = @"PN_obras_sociales";
        
		public static string PnOri = @"PN_ori";
        
		public static string PnPacPap = @"PN_pac_pap";
        
		public static string PnPai = @"PN_pais";
        
		public static string PnParametro = @"PN_parametros";
        
		public static string PnParto = @"PN_partos";
        
		public static string PnPatologia = @"PN_patologias";
        
		public static string PnPatologiasFrecuente = @"PN_patologias_frecuentes";
        
		public static string PnPeriodo = @"PN_periodo";
        
		public static string PnPermiso = @"PN_permisos";
        
		public static string PnPermisosActuale = @"PN_permisos_actuales";
        
		public static string PnPermisosGrupo = @"PN_permisos_grupos";
        
		public static string PnPermisosSesion = @"PN_permisos_sesion";
        
		public static string PnPermisosUsuario = @"PN_permisos_usuarios";
        
		public static string PnPlanilla = @"PN_planillas";
        
		public static string PnPrestacion = @"PN_prestacion";
        
		public static string PnPrestacionesNOp = @"PN_prestaciones_n_op";
        
		public static string PnPrestacionesNueva = @"PN_PrestacionesNuevas";
        
		public static string PnPromocione = @"PN_promociones";
        
		public static string PnProvincia = @"PN_provincias";
        
		public static string PnPuco = @"PN_puco";
        
		public static string PnRecibe = @"PN_recibe";
        
		public static string PnRelNomencladorXDatoReportable = @"PN_Rel_NomencladorXDatoReportable";
        
		public static string PnRelPrestacionXDatoReportable = @"PN_Rel_PrestacionXDatoReportable";
        
		public static string PnRelPacienteAfiliado = @"PN_RelPacienteAfiliado";
        
		public static string PnReporteHipoacustium = @"PN_reporte_hipoacustia";
        
		public static string PnResponsable = @"PN_responsables";
        
		public static string PnServicio = @"PN_servicio";
        
		public static string PnSmiafiliado = @"PN_smiafiliados";
        
		public static string PnSmiafiliadosaux = @"PN_smiafiliadosaux";
        
		public static string PnSmiefectore = @"PN_smiefectores";
        
		public static string PnSmiprocesoafiliado = @"PN_smiprocesoafiliados";
        
		public static string PnSmitiposcategoria = @"PN_smitiposcategorias";
        
		public static string PnSubirArchivo = @"PN_subir_archivos";
        
		public static string PnSumariosPersonal = @"PN_sumarios_personal";
        
		public static string PnSuspensione = @"PN_suspensiones";
        
		public static string PnTareasDesemp = @"PN_tareas_desemp";
        
		public static string PnTipoDeMensaje = @"PN_tipo_de_mensaje";
        
		public static string PnTipoDocumento = @"PN_tipo_documento";
        
		public static string PnTipoEvento = @"PN_tipo_evento";
        
		public static string PnTipoPermiso = @"PN_tipo_permiso";
        
		public static string PnTipoDePrestacion = @"PN_TipoDePrestacion";
        
		public static string PnTransaccion = @"PN_transaccion";
        
		public static string PnTransaccionCertificado = @"PN_transaccion_certificado";
        
		public static string PnTribu = @"PN_tribus";
        
		public static string PnTrzPre = @"PN_trz_pres";
        
		public static string PnUadParametro = @"PN_uad_parametros";
        
		public static string PnUsuario = @"PN_usuarios";
        
		public static string PnVacApli = @"PN_vac_apli";
        
		public static string PnVacuna = @"PN_vacunas";
        
		public static string PnValidacionPrestacion = @"PN_validacion_prestacion";
        
		public static string PnZonaSani = @"PN_zona_sani";
        
		public static string PsmDato = @"PSM_Datos";
        
		public static string PsmDerivacione = @"PSM_Derivaciones";
        
		public static string PsmEFisico = @"PSM_EFisico";
        
		public static string RegParte = @"RegPartes";
        
		public static string RemActividadFisica = @"Rem_ActividadFisica";
        
		public static string RemAgente = @"Rem_Agente";
        
		public static string RemClasificacion = @"Rem_Clasificacion";
        
		public static string RemComplicacione = @"Rem_Complicaciones";
        
		public static string RemEstudioOcular = @"Rem_EstudioOcular";
        
		public static string RemExamenPie = @"Rem_ExamenPie";
        
		public static string RemFormulario = @"Rem_Formulario";
        
		public static string RemInternacion = @"Rem_Internacion";
        
		public static string RemMedicamentoCronico = @"Rem_MedicamentoCronico";
        
		public static string RemRelMedicamentoClasificacion = @"Rem_RelMedicamentoClasificacion";
        
		public static string RemRelMedicamentoSeguimiento = @"Rem_RelMedicamentoSeguimiento";
        
		public static string RemSeguimiento = @"Rem_Seguimiento";
        
		public static string RemTablaExaman = @"Rem_TablaExamen";
        
		public static string RemTipoCobertura = @"Rem_TipoCobertura";
        
		public static string RisAreaTematica = @"RIS_AreaTematica";
        
		public static string RisAseguradora = @"RIS_Aseguradora";
        
		public static string RisCaracteristica = @"RIS_Caracteristica";
        
		public static string RisComiteEtica = @"RIS_ComiteEtica";
        
		public static string RisConcentimiento = @"RIS_Concentimiento";
        
		public static string RisEnmienda = @"RIS_Enmienda";
        
		public static string RisEnmiendaItemDesaprobado = @"RIS_EnmiendaItemDesaprobado";
        
		public static string RisEntidad = @"RIS_Entidad";
        
		public static string RisEstudio = @"RIS_Estudio";
        
		public static string RisEstudioAseguradora = @"RIS_EstudioAseguradora";
        
		public static string RisEstudioCaracteristica = @"RIS_EstudioCaracteristica";
        
		public static string RisEstudioComiteEtica = @"RIS_EstudioComiteEtica";
        
		public static string RisEstudioEntidad = @"RIS_EstudioEntidad";
        
		public static string RisEstudioFuenteRecoleccionDato = @"RIS_EstudioFuenteRecoleccionDatos";
        
		public static string RisEstudioInvestigador = @"RIS_EstudioInvestigador";
        
		public static string RisEstudioItemAprobado = @"RIS_EstudioItemAprobado";
        
		public static string RisEstudioItemDesaprobado = @"RIS_EstudioItemDesaprobado";
        
		public static string RisEstudioPoblacionVulnerable = @"RIS_EstudioPoblacionVulnerable";
        
		public static string RisEstudioSysEfectorMulticentrico = @"RIS_EstudioSysEfectorMulticentrico";
        
		public static string RisEstudioSysPaisMulticentrico = @"RIS_EstudioSysPaisMulticentrico";
        
		public static string RisEstudioSysProvinciaMulticentrico = @"RIS_EstudioSysProvinciaMulticentrico";
        
		public static string RisEvaluacionRechazada = @"RIS_EvaluacionRechazada";
        
		public static string RisFuenteRecoleccionDato = @"RIS_FuenteRecoleccionDatos";
        
		public static string RisFuncionEnElEquipo = @"RIS_FuncionEnElEquipo";
        
		public static string RisInvestigadore = @"RIS_Investigadores";
        
		public static string RisItemAprobado = @"RIS_ItemAprobado";
        
		public static string RisItemDesaprobado = @"RIS_ItemDesaprobado";
        
		public static string RisLugarRealizacion = @"RIS_LugarRealizacion";
        
		public static string RisNotum = @"RIS_Nota";
        
		public static string RisPoblacionVulnerable = @"RIS_PoblacionVulnerable";
        
		public static string RisPresentacionInforme = @"RIS_PresentacionInforme";
        
		public static string RisProfesion = @"RIS_Profesion";
        
		public static string RisTipoDocumento = @"RIS_TipoDocumento";
        
		public static string RisTipoTelefono = @"RIS_TipoTelefono";
        
		public static string RisVigenciaPoliza = @"RIS_VigenciaPoliza";
        
		public static string SisaReport = @"SISA_Report";
        
		public static string SysAntecedente = @"Sys_Antecedente";
        
		public static string SysAntecedenteEnfermedad = @"Sys_AntecedenteEnfermedad";
        
		public static string SysBarrio = @"Sys_Barrio";
        
		public static string SysCepSap = @"Sys_CepSap";
        
		public static string SysCIE10 = @"Sys_CIE10";
        
		public static string SysCIE10Capitulo = @"Sys_CIE10Capitulo";
        
		public static string SysDepartamento = @"Sys_Departamento";
        
		public static string SysDireccione = @"Sys_Direcciones";
        
		public static string SysEfector = @"Sys_Efector";
        
		public static string SysEspecialidad = @"Sys_Especialidad";
        
		public static string SysEspecialidad2 = @"Sys_Especialidad2";
        
		public static string SysEstablecimiento = @"sys_Establecimiento";
        
		public static string SysEstado = @"Sys_Estado";
        
		public static string SysEstadoCivil = @"Sys_EstadoCivil";
        
		public static string SysHistoriaClinica = @"Sys_HistoriaClinica";
        
		public static string SysIdioma = @"Sys_Idioma";
        
		public static string SysLocalidad = @"Sys_Localidad";
        
		public static string SysMedicamento = @"Sys_Medicamento";
        
		public static string SysMedicamentoRubro = @"Sys_MedicamentoRubro";
        
		public static string SysMenu = @"Sys_Menu";
        
		public static string SysModulo = @"Sys_Modulo";
        
		public static string SysMotivoNI = @"Sys_MotivoNI";
        
		public static string SysMovimientoHistoriaClinica = @"Sys_MovimientoHistoriaClinica";
        
		public static string SysMunicipio = @"Sys_Municipio";
        
		public static string SysNivelInstruccion = @"Sys_NivelInstruccion";
        
		public static string SysObraSocial = @"Sys_ObraSocial";
        
		public static string SysOcupacion = @"Sys_Ocupacion";
        
		public static string SysOrganismo = @"Sys_Organismo";
        
		public static string SysPaciente = @"Sys_Paciente";
        
		public static string SysPacienteAntecedentesFamiliare = @"Sys_PacienteAntecedentesFamiliares";
        
		public static string SysPacienteCeliaco = @"Sys_PacienteCeliaco";
        
		public static string SysPai = @"Sys_Pais";
        
		public static string SysParentesco = @"Sys_Parentesco";
        
		public static string SysParentescoTipo = @"Sys_ParentescoTipo";
        
		public static string SysPerfil = @"Sys_Perfil";
        
		public static string SysPermiso = @"Sys_Permiso";
        
		public static string SysPoblacion = @"Sys_Poblacion";
        
		public static string SysPoblacion1 = @"Sys_Poblacion1";
        
		public static string SysProfesion = @"Sys_Profesion";
        
		public static string SysProfesional = @"Sys_Profesional";
        
		public static string SysProvincium = @"Sys_Provincia";
        
		public static string SysRelAntecedentePaciente = @"Sys_RelAntecedentePaciente";
        
		public static string SysRelEspecialidadEfector = @"Sys_RelEspecialidadEfector";
        
		public static string SysRelEstadoMotivoNI = @"Sys_RelEstadoMotivoNI";
        
		public static string SysRelFormularioCobertura = @"Sys_RelFormularioCobertura";
        
		public static string SysRelHistoriaClinicaEfector = @"Sys_RelHistoriaClinicaEfector";
        
		public static string SysRelPacienteObraSocial = @"Sys_RelPacienteObraSocial";
        
		public static string SysRelProfesionalEfector = @"Sys_RelProfesionalEfector";
        
		public static string SysRelServicioEfector = @"Sys_RelServicioEfector";
        
		public static string SysServicio = @"Sys_Servicio";
        
		public static string SysSexo = @"Sys_Sexo";
        
		public static string SysSituacionLaboral = @"Sys_SituacionLaboral";
        
		public static string SysTipoAntecedente = @"Sys_TipoAntecedente";
        
		public static string SysTipoCobertura = @"Sys_TipoCobertura";
        
		public static string SysTipoDocumento = @"Sys_TipoDocumento";
        
		public static string SysTipoEfector = @"Sys_TipoEfector";
        
		public static string SysTipoObraSocial = @"Sys_TipoObraSocial";
        
		public static string SysTipoProfesional = @"Sys_TipoProfesional";
        
		public static string SysUsuario = @"Sys_Usuario";
        
		public static string SysZona = @"Sys_Zona";
        
		public static string TabControl = @"TAB_Control";
        
		public static string TabMedicamentoTabaquismo = @"TAB_MedicamentoTabaquismo";
        
		public static string TabRelMedicamentoTab = @"TAB_RelMedicamentoTab";
        
		public static string TamBiopsium = @"TAM_Biopsia";
        
		public static string TamCalidadMuestra = @"TAM_CalidadMuestra";
        
		public static string TamCelulasEscamosa = @"TAM_CelulasEscamosas";
        
		public static string TamCelulasGlandulare = @"TAM_CelulasGlandulares";
        
		public static string TamColposcopium = @"TAM_Colposcopia";
        
		public static string TamDiagnostico = @"TAM_Diagnostico";
        
		public static string TamEfectore = @"TAM_Efectores";
        
		public static string TamEstadio = @"TAM_Estadio";
        
		public static string TamHallazgosColposcopico = @"TAM_HallazgosColposcopicos";
        
		public static string TamHpv = @"TAM_Hpv";
        
		public static string TamHpvHP = @"TAM_HpvHP";
        
		public static string TamLocalidade = @"TAM_Localidades";
        
		public static string TamMetodoAnticonceptivo = @"TAM_MetodoAnticonceptivo";
        
		public static string TamMicrorganismo = @"TAM_Microrganismo";
        
		public static string TamObservacionPap = @"TAM_ObservacionPap";
        
		public static string TamOtrosHallazgo = @"TAM_OtrosHallazgos";
        
		public static string TamPap = @"TAM_Pap";
        
		public static string TamPapHospitalProvincial = @"TAM_PapHospitalProvincial";
        
		public static string TamPapHP = @"TAM_PapHP";
        
		public static string TamProfesionale = @"TAM_Profesionales";
        
		public static string TamRegistro = @"TAM_Registro";
        
		public static string TamRelTipoMaterialBiopsium = @"TAM_RelTipoMaterialBiopsia";
        
		public static string TamResultadoColpo = @"TAM_ResultadoColpos";
        
		public static string TamResultadoHpv = @"TAM_ResultadoHpv";
        
		public static string TamResultadoPap = @"TAM_ResultadoPap";
        
		public static string TamTipoCirugium = @"TAM_TipoCirugia";
        
		public static string TamTipoHpv = @"TAM_TipoHpv";
        
		public static string TamTipoMaterialBiopsium = @"TAM_TipoMaterialBiopsia";
        
		public static string TamTipoMuestra = @"TAM_TipoMuestra";
        
		public static string TamTipoPapPrevio = @"TAM_TipoPapPrevio";
        
		public static string TamTipoTratamiento = @"TAM_TipoTratamiento";
        
		public static string TamTipoTratamientoPap = @"TAM_TipoTratamientoPap";
        
		public static string TamTratamiento = @"TAM_Tratamientos";
        
		public static string TmpEgreso = @"TMP_Egresos";
        
		public static string TmpFacturasACerrar = @"TMP_FacturasACerrar";
        
		public static string TstAfiliadosIOSE = @"TST_AfiliadosIOSE";
        
		public static string TstAfiliadosISSN = @"TST_AfiliadosISSN";
        
		public static string TstPaciente = @"TST_Paciente";
        
		public static string TstProfe = @"TST_Profe";
        
		public static string TupEfectoresHabilitado = @"TUP_EfectoresHabilitados";
        
		public static string TupTurnosProtegido = @"TUP_TurnosProtegidos";
        
		public static string Ubicacione = @"Ubicaciones";
        
		public static string UbicacionesDato = @"Ubicaciones_Datos";
        
		public static string UbicacionesSubtipo = @"Ubicaciones_Subtipos";
        
		public static string UbicacionesTipo = @"Ubicaciones_Tipos";
        
		public static string VgiAClinicosDet = @"VGI_AClinicosDet";
        
		public static string VgiCInterconsultaItem = @"VGI_CInterconsultaItems";
        
		public static string VgiCriterio = @"vgi_Criterios";
        
		public static string VgiDato = @"VGI_Datos";
        
		public static string VgiItem = @"vgi_Items";
        
		public static string VgiItemsDato = @"vgi_ItemsDatos";
        
		public static string ViewMujeresPap = @"View_MujeresPaps";
        
	}
	#endregion
    #region Schemas
    public partial class Schemas {
		
		public static TableSchema.Table AfiliadosParaSip{
            get { return DataService.GetSchema("AFILIADOS_PARA_SIPS","RisProvider"); }
		}
        
		public static TableSchema.Table AprAborto{
            get { return DataService.GetSchema("APR_Aborto","RisProvider"); }
		}
        
		public static TableSchema.Table AprAcompañante{
            get { return DataService.GetSchema("APR_Acompañante","RisProvider"); }
		}
        
		public static TableSchema.Table AprActividad{
            get { return DataService.GetSchema("APR_Actividad","RisProvider"); }
		}
        
		public static TableSchema.Table AprActividadControlPerinatal{
            get { return DataService.GetSchema("APR_ActividadControlPerinatal","RisProvider"); }
		}
        
		public static TableSchema.Table AprActividadEmbarazo{
            get { return DataService.GetSchema("APR_ActividadEmbarazo","RisProvider"); }
		}
        
		public static TableSchema.Table AprActividadFisica{
            get { return DataService.GetSchema("APR_ActividadFisica","RisProvider"); }
		}
        
		public static TableSchema.Table AprActualPatologiaEmbarazo{
            get { return DataService.GetSchema("APR_ActualPatologiaEmbarazo","RisProvider"); }
		}
        
		public static TableSchema.Table AprAlertaControlMenor{
            get { return DataService.GetSchema("APR_AlertaControlMenor","RisProvider"); }
		}
        
		public static TableSchema.Table AprAlimentacionRecienNacido{
            get { return DataService.GetSchema("APR_AlimentacionRecienNacido","RisProvider"); }
		}
        
		public static TableSchema.Table AprAlturaUterina{
            get { return DataService.GetSchema("APR_AlturaUterina","RisProvider"); }
		}
        
		public static TableSchema.Table AprAmbienteProcedimiento{
            get { return DataService.GetSchema("APR_AmbienteProcedimiento","RisProvider"); }
		}
        
		public static TableSchema.Table AprAntecedentePatologiaEmbarazo{
            get { return DataService.GetSchema("APR_AntecedentePatologiaEmbarazo","RisProvider"); }
		}
        
		public static TableSchema.Table AprAntecedentePerinatal{
            get { return DataService.GetSchema("APR_AntecedentePerinatal","RisProvider"); }
		}
        
		public static TableSchema.Table AprAntecedentePerinatalNacimiento{
            get { return DataService.GetSchema("APR_AntecedentePerinatalNacimiento","RisProvider"); }
		}
        
		public static TableSchema.Table AprAplicacionVacuna{
            get { return DataService.GetSchema("APR_AplicacionVacuna","RisProvider"); }
		}
        
		public static TableSchema.Table AprAreaDesarrollo{
            get { return DataService.GetSchema("APR_AreaDesarrollo","RisProvider"); }
		}
        
		public static TableSchema.Table AprCalendarioVacuna{
            get { return DataService.GetSchema("APR_CalendarioVacuna","RisProvider"); }
		}
        
		public static TableSchema.Table AprCalendarioVisita{
            get { return DataService.GetSchema("APR_CalendarioVisitas","RisProvider"); }
		}
        
		public static TableSchema.Table AprCategoriaPesoNacimiento{
            get { return DataService.GetSchema("APR_CategoriaPesoNacimiento","RisProvider"); }
		}
        
		public static TableSchema.Table AprCentilesIMCEdadGestacional{
            get { return DataService.GetSchema("APR_CentilesIMCEdadGestacional","RisProvider"); }
		}
        
		public static TableSchema.Table AprCMOtrosDato{
            get { return DataService.GetSchema("APR_CMOtrosDatos","RisProvider"); }
		}
        
		public static TableSchema.Table AprComplicacionAborto{
            get { return DataService.GetSchema("APR_ComplicacionAborto","RisProvider"); }
		}
        
		public static TableSchema.Table AprComplicacionIntraoperatorium{
            get { return DataService.GetSchema("APR_ComplicacionIntraoperatoria","RisProvider"); }
		}
        
		public static TableSchema.Table AprConcejerium{
            get { return DataService.GetSchema("APR_Concejeria","RisProvider"); }
		}
        
		public static TableSchema.Table AprCondicionesVivienda{
            get { return DataService.GetSchema("APR_CondicionesVivienda","RisProvider"); }
		}
        
		public static TableSchema.Table AprCondicionIngreso{
            get { return DataService.GetSchema("APR_CondicionIngreso","RisProvider"); }
		}
        
		public static TableSchema.Table AprConsultaAntenatal{
            get { return DataService.GetSchema("APR_ConsultaAntenatal","RisProvider"); }
		}
        
		public static TableSchema.Table AprControlNiñoSano{
            get { return DataService.GetSchema("APR_ControlNiñoSano","RisProvider"); }
		}
        
		public static TableSchema.Table AprControlNiñoSanoConsultorio{
            get { return DataService.GetSchema("APR_ControlNiñoSanoConsultorio","RisProvider"); }
		}
        
		public static TableSchema.Table AprControlNiñoSanoEnfermerium{
            get { return DataService.GetSchema("APR_ControlNiñoSanoEnfermeria","RisProvider"); }
		}
        
		public static TableSchema.Table AprControlNiñoSanoHemoglobina{
            get { return DataService.GetSchema("APR_ControlNiñoSanoHemoglobina","RisProvider"); }
		}
        
		public static TableSchema.Table AprControlNiñoSanoOdontologico{
            get { return DataService.GetSchema("APR_ControlNiñoSanoOdontologico","RisProvider"); }
		}
        
		public static TableSchema.Table AprControlOdontologico{
            get { return DataService.GetSchema("APR_ControlOdontologico","RisProvider"); }
		}
        
		public static TableSchema.Table AprDefectoCongenito{
            get { return DataService.GetSchema("APR_DefectoCongenito","RisProvider"); }
		}
        
		public static TableSchema.Table AprDiagnosticoControlOdontologico{
            get { return DataService.GetSchema("APR_DiagnosticoControlOdontologico","RisProvider"); }
		}
        
		public static TableSchema.Table AprEgresoMaterno{
            get { return DataService.GetSchema("APR_EgresoMaterno","RisProvider"); }
		}
        
		public static TableSchema.Table AprEgresoPorAborto{
            get { return DataService.GetSchema("APR_EgresoPorAborto","RisProvider"); }
		}
        
		public static TableSchema.Table AprEmbarazo{
            get { return DataService.GetSchema("APR_Embarazo","RisProvider"); }
		}
        
		public static TableSchema.Table AprEstadoNacimiento{
            get { return DataService.GetSchema("APR_EstadoNacimiento","RisProvider"); }
		}
        
		public static TableSchema.Table AprEstadoNutricional{
            get { return DataService.GetSchema("APR_EstadoNutricional","RisProvider"); }
		}
        
		public static TableSchema.Table AprEstiloVida{
            get { return DataService.GetSchema("APR_EstiloVida","RisProvider"); }
		}
        
		public static TableSchema.Table AprEtnium{
            get { return DataService.GetSchema("APR_Etnia","RisProvider"); }
		}
        
		public static TableSchema.Table AprFactorProtector{
            get { return DataService.GetSchema("APR_FactorProtector","RisProvider"); }
		}
        
		public static TableSchema.Table AprFactorRiesgo{
            get { return DataService.GetSchema("APR_FactorRiesgo","RisProvider"); }
		}
        
		public static TableSchema.Table AprFactorRiesgoEstiloVida{
            get { return DataService.GetSchema("APR_FactorRiesgoEstiloVida","RisProvider"); }
		}
        
		public static TableSchema.Table AprFactorRiesgoPsicosocial{
            get { return DataService.GetSchema("APR_FactorRiesgoPsicosocial","RisProvider"); }
		}
        
		public static TableSchema.Table AprFormaConcejerium{
            get { return DataService.GetSchema("APR_FormaConcejeria","RisProvider"); }
		}
        
		public static TableSchema.Table AprHistoriaClinicaPerinatal{
            get { return DataService.GetSchema("APR_HistoriaClinicaPerinatal","RisProvider"); }
		}
        
		public static TableSchema.Table AprHistoriaClinicaPerinatalDetalle{
            get { return DataService.GetSchema("APR_HistoriaClinicaPerinatalDetalle","RisProvider"); }
		}
        
		public static TableSchema.Table AprInicioEmbarazo{
            get { return DataService.GetSchema("APR_InicioEmbarazo","RisProvider"); }
		}
        
		public static TableSchema.Table AprInterconsultum{
            get { return DataService.GetSchema("APR_Interconsulta","RisProvider"); }
		}
        
		public static TableSchema.Table AprIntervencion{
            get { return DataService.GetSchema("APR_Intervencion","RisProvider"); }
		}
        
		public static TableSchema.Table AprIntervencionProfesional{
            get { return DataService.GetSchema("APR_IntervencionProfesional","RisProvider"); }
		}
        
		public static TableSchema.Table AprMomentoNacimiento{
            get { return DataService.GetSchema("APR_MomentoNacimiento","RisProvider"); }
		}
        
		public static TableSchema.Table AprMotivoVisitaDomiciliarium{
            get { return DataService.GetSchema("APR_MotivoVisitaDomiciliaria","RisProvider"); }
		}
        
		public static TableSchema.Table AprNumeroDosi{
            get { return DataService.GetSchema("APR_NumeroDosis","RisProvider"); }
		}
        
		public static TableSchema.Table AprPartoProvisorio{
            get { return DataService.GetSchema("APR_PartoProvisorio","RisProvider"); }
		}
        
		public static TableSchema.Table AprPercentilesIMCEdad{
            get { return DataService.GetSchema("APR_PercentilesIMCEdad","RisProvider"); }
		}
        
		public static TableSchema.Table AprPercentilesLongitudEstaturaEdad{
            get { return DataService.GetSchema("APR_PercentilesLongitudEstaturaEdad","RisProvider"); }
		}
        
		public static TableSchema.Table AprPercentilesPerimetroCefalicoEdad{
            get { return DataService.GetSchema("APR_PercentilesPerimetroCefalicoEdad","RisProvider"); }
		}
        
		public static TableSchema.Table AprPercentilesPesoEdad{
            get { return DataService.GetSchema("APR_PercentilesPesoEdad","RisProvider"); }
		}
        
		public static TableSchema.Table AprPercentilesPesoEstatura{
            get { return DataService.GetSchema("APR_PercentilesPesoEstatura","RisProvider"); }
		}
        
		public static TableSchema.Table AprPercentilesPesoLongitud{
            get { return DataService.GetSchema("APR_PercentilesPesoLongitud","RisProvider"); }
		}
        
		public static TableSchema.Table AprProblemasMenor{
            get { return DataService.GetSchema("APR_ProblemasMenor","RisProvider"); }
		}
        
		public static TableSchema.Table AprRecienNacido{
            get { return DataService.GetSchema("APR_RecienNacido","RisProvider"); }
		}
        
		public static TableSchema.Table AprRelControlNiñoSanoAreaDesarrollo{
            get { return DataService.GetSchema("APR_RelControlNiñoSanoAreaDesarrollo","RisProvider"); }
		}
        
		public static TableSchema.Table AprRelControlNiñoSanoFactorRiesgo{
            get { return DataService.GetSchema("APR_RelControlNiñoSanoFactorRiesgo","RisProvider"); }
		}
        
		public static TableSchema.Table AprRelControNiñoSanoFactorProtector{
            get { return DataService.GetSchema("APR_RelControNiñoSanoFactorProtector","RisProvider"); }
		}
        
		public static TableSchema.Table AprRelPersonaFactorRiesgoInicial{
            get { return DataService.GetSchema("APR_RelPersonaFactorRiesgoInicial","RisProvider"); }
		}
        
		public static TableSchema.Table AprRelRecienNacidoDefectoCongenito{
            get { return DataService.GetSchema("APR_RelRecienNacidoDefectoCongenito","RisProvider"); }
		}
        
		public static TableSchema.Table AprRelRecienNacidoEnfermedad{
            get { return DataService.GetSchema("APR_RelRecienNacidoEnfermedad","RisProvider"); }
		}
        
		public static TableSchema.Table AprTallaEdad{
            get { return DataService.GetSchema("APR_TallaEdad","RisProvider"); }
		}
        
		public static TableSchema.Table AprTerminacionParto{
            get { return DataService.GetSchema("APR_TerminacionParto","RisProvider"); }
		}
        
		public static TableSchema.Table AprTipoActividadEmbarazo{
            get { return DataService.GetSchema("APR_TipoActividadEmbarazo","RisProvider"); }
		}
        
		public static TableSchema.Table AprTipoLactancium{
            get { return DataService.GetSchema("APR_TipoLactancia","RisProvider"); }
		}
        
		public static TableSchema.Table AprTipoParto{
            get { return DataService.GetSchema("APR_TipoParto","RisProvider"); }
		}
        
		public static TableSchema.Table AprTipoProfesional{
            get { return DataService.GetSchema("APR_TipoProfesional","RisProvider"); }
		}
        
		public static TableSchema.Table AprVisitaDomiciliarium{
            get { return DataService.GetSchema("APR_VisitaDomiciliaria","RisProvider"); }
		}
        
		public static TableSchema.Table AprZScoreIMCEdad{
            get { return DataService.GetSchema("APR_ZScoreIMCEdad","RisProvider"); }
		}
        
		public static TableSchema.Table AprZScoreLongitudEstaturaEdad{
            get { return DataService.GetSchema("APR_ZScoreLongitudEstaturaEdad","RisProvider"); }
		}
        
		public static TableSchema.Table AprZScorePerimetroCefalicoEdad{
            get { return DataService.GetSchema("APR_ZScorePerimetroCefalicoEdad","RisProvider"); }
		}
        
		public static TableSchema.Table AprZScorePesoEdad{
            get { return DataService.GetSchema("APR_ZScorePesoEdad","RisProvider"); }
		}
        
		public static TableSchema.Table AprZScorePesoEstatura{
            get { return DataService.GetSchema("APR_ZScorePesoEstatura","RisProvider"); }
		}
        
		public static TableSchema.Table AprZScorePesoLongitud{
            get { return DataService.GetSchema("APR_ZScorePesoLongitud","RisProvider"); }
		}
        
		public static TableSchema.Table AutAccidente{
            get { return DataService.GetSchema("AUT_Accidente","RisProvider"); }
		}
        
		public static TableSchema.Table AutChofCurso{
            get { return DataService.GetSchema("Aut_ChofCursos","RisProvider"); }
		}
        
		public static TableSchema.Table AutChofer{
            get { return DataService.GetSchema("AUT_Chofer","RisProvider"); }
		}
        
		public static TableSchema.Table AutCurso{
            get { return DataService.GetSchema("Aut_Cursos","RisProvider"); }
		}
        
		public static TableSchema.Table AutDireccione{
            get { return DataService.GetSchema("AUT_Direcciones","RisProvider"); }
		}
        
		public static TableSchema.Table AutEntidad{
            get { return DataService.GetSchema("AUT_Entidad","RisProvider"); }
		}
        
		public static TableSchema.Table AutEstadosMov{
            get { return DataService.GetSchema("AUT_EstadosMov","RisProvider"); }
		}
        
		public static TableSchema.Table AutHistoricoVehiculoPmp{
            get { return DataService.GetSchema("AUT_Historico_Vehiculo_PMP","RisProvider"); }
		}
        
		public static TableSchema.Table AutItemMovimiento{
            get { return DataService.GetSchema("AUT_ItemMovimiento","RisProvider"); }
		}
        
		public static TableSchema.Table AutMarca{
            get { return DataService.GetSchema("AUT_Marca","RisProvider"); }
		}
        
		public static TableSchema.Table AutModelo{
            get { return DataService.GetSchema("AUT_Modelo","RisProvider"); }
		}
        
		public static TableSchema.Table AutMovimiento{
            get { return DataService.GetSchema("AUT_Movimiento","RisProvider"); }
		}
        
		public static TableSchema.Table AutMovimientoItemMovimiento{
            get { return DataService.GetSchema("AUT_Movimiento_ItemMovimiento","RisProvider"); }
		}
        
		public static TableSchema.Table AutNotaPedido{
            get { return DataService.GetSchema("Aut_NotaPedido","RisProvider"); }
		}
        
		public static TableSchema.Table AutOrdenReparacion{
            get { return DataService.GetSchema("Aut_OrdenReparacion","RisProvider"); }
		}
        
		public static TableSchema.Table AutOrdenRepItem{
            get { return DataService.GetSchema("Aut_OrdenRepItem","RisProvider"); }
		}
        
		public static TableSchema.Table AutOrigenDestino{
            get { return DataService.GetSchema("AUT_OrigenDestino","RisProvider"); }
		}
        
		public static TableSchema.Table AutPmp{
            get { return DataService.GetSchema("AUT_PMP","RisProvider"); }
		}
        
		public static TableSchema.Table AutPmpItemMovimiento{
            get { return DataService.GetSchema("AUT_PMP_ItemMovimiento","RisProvider"); }
		}
        
		public static TableSchema.Table AutPresupuesto{
            get { return DataService.GetSchema("Aut_Presupuesto","RisProvider"); }
		}
        
		public static TableSchema.Table AutProveedor{
            get { return DataService.GetSchema("AUT_Proveedor","RisProvider"); }
		}
        
		public static TableSchema.Table AutTipoEntidad{
            get { return DataService.GetSchema("AUT_TipoEntidad","RisProvider"); }
		}
        
		public static TableSchema.Table AutTipoMovimiento{
            get { return DataService.GetSchema("AUT_TipoMovimiento","RisProvider"); }
		}
        
		public static TableSchema.Table AutTipoPNP{
            get { return DataService.GetSchema("Aut_TipoPNP","RisProvider"); }
		}
        
		public static TableSchema.Table AutTipoProveedor{
            get { return DataService.GetSchema("Aut_TipoProveedor","RisProvider"); }
		}
        
		public static TableSchema.Table AutTipoTraslado{
            get { return DataService.GetSchema("Aut_TipoTraslado","RisProvider"); }
		}
        
		public static TableSchema.Table AutTipoVehiculo{
            get { return DataService.GetSchema("AUT_TipoVehiculo","RisProvider"); }
		}
        
		public static TableSchema.Table AutTraslado{
            get { return DataService.GetSchema("Aut_Traslado","RisProvider"); }
		}
        
		public static TableSchema.Table AutVehiculo{
            get { return DataService.GetSchema("AUT_Vehiculo","RisProvider"); }
		}
        
		public static TableSchema.Table AutVehiculoPmp{
            get { return DataService.GetSchema("AUT_Vehiculo_PMP","RisProvider"); }
		}
        
		public static TableSchema.Table AutViaje{
            get { return DataService.GetSchema("AUT_Viaje","RisProvider"); }
		}
        
		public static TableSchema.Table BdsAdmision{
            get { return DataService.GetSchema("BDS_Admision","RisProvider"); }
		}
        
		public static TableSchema.Table BdsDonante{
            get { return DataService.GetSchema("BDS_Donante","RisProvider"); }
		}
        
		public static TableSchema.Table BdsHematologium{
            get { return DataService.GetSchema("BDS_Hematologia","RisProvider"); }
		}
        
		public static TableSchema.Table BdsHemocomponente{
            get { return DataService.GetSchema("BDS_Hemocomponente","RisProvider"); }
		}
        
		public static TableSchema.Table BdsIncidenciaExtraccion{
            get { return DataService.GetSchema("BDS_IncidenciaExtraccion","RisProvider"); }
		}
        
		public static TableSchema.Table BdsProductoAdmision{
            get { return DataService.GetSchema("BDS_ProductoAdmision","RisProvider"); }
		}
        
		public static TableSchema.Table BdsSerologium{
            get { return DataService.GetSchema("BDS_Serologia","RisProvider"); }
		}
        
		public static TableSchema.Table BdsTipoDonante{
            get { return DataService.GetSchema("BDS_TipoDonante","RisProvider"); }
		}
        
		public static TableSchema.Table BdsTipoExclusion{
            get { return DataService.GetSchema("BDS_TipoExclusion","RisProvider"); }
		}
        
		public static TableSchema.Table BdsUsoHemocomponente{
            get { return DataService.GetSchema("BDS_UsoHemocomponente","RisProvider"); }
		}
        
		public static TableSchema.Table BkpOdoNomenclador{
            get { return DataService.GetSchema("bkp_ODO_Nomenclador","RisProvider"); }
		}
        
		public static TableSchema.Table BorrarPrueba{
            get { return DataService.GetSchema("BorrarPrueba","RisProvider"); }
		}
        
		public static TableSchema.Table CamEstado{
            get { return DataService.GetSchema("CAM_Estado","RisProvider"); }
		}
        
		public static TableSchema.Table CamServicio{
            get { return DataService.GetSchema("CAM_Servicios","RisProvider"); }
		}
        
		public static TableSchema.Table CIE10{
            get { return DataService.GetSchema("CIE10","RisProvider"); }
		}
        
		public static TableSchema.Table CIE10Heller{
            get { return DataService.GetSchema("CIE10_Heller","RisProvider"); }
		}
        
		public static TableSchema.Table Clasificado{
            get { return DataService.GetSchema("Clasificados","RisProvider"); }
		}
        
		public static TableSchema.Table ConAgenda{
            get { return DataService.GetSchema("CON_Agenda","RisProvider"); }
		}
        
		public static TableSchema.Table ConAgendaAuditorium{
            get { return DataService.GetSchema("CON_AgendaAuditoria","RisProvider"); }
		}
        
		public static TableSchema.Table ConAgendaBloqueo{
            get { return DataService.GetSchema("CON_AgendaBloqueo","RisProvider"); }
		}
        
		public static TableSchema.Table ConAgendaEstado{
            get { return DataService.GetSchema("CON_AgendaEstado","RisProvider"); }
		}
        
		public static TableSchema.Table ConAgendaGrupal{
            get { return DataService.GetSchema("CON_AgendaGrupal","RisProvider"); }
		}
        
		public static TableSchema.Table ConAgendaGrupalOrganismo{
            get { return DataService.GetSchema("CON_AgendaGrupalOrganismo","RisProvider"); }
		}
        
		public static TableSchema.Table ConAgendaGrupalPaciente{
            get { return DataService.GetSchema("CON_AgendaGrupalPaciente","RisProvider"); }
		}
        
		public static TableSchema.Table ConAgendaGrupalProfesional{
            get { return DataService.GetSchema("CON_AgendaGrupalProfesional","RisProvider"); }
		}
        
		public static TableSchema.Table ConAgendaProfesional{
            get { return DataService.GetSchema("CON_AgendaProfesional","RisProvider"); }
		}
        
		public static TableSchema.Table ConConsultum{
            get { return DataService.GetSchema("CON_Consulta","RisProvider"); }
		}
        
		public static TableSchema.Table ConConsultaDiagnostico{
            get { return DataService.GetSchema("CON_ConsultaDiagnostico","RisProvider"); }
		}
        
		public static TableSchema.Table ConConsultaMedicamento{
            get { return DataService.GetSchema("CON_ConsultaMedicamento","RisProvider"); }
		}
        
		public static TableSchema.Table ConConsultaOdontologium{
            get { return DataService.GetSchema("CON_ConsultaOdontologia","RisProvider"); }
		}
        
		public static TableSchema.Table ConConsultorio{
            get { return DataService.GetSchema("CON_Consultorio","RisProvider"); }
		}
        
		public static TableSchema.Table ConConsultorioTipo{
            get { return DataService.GetSchema("CON_ConsultorioTipo","RisProvider"); }
		}
        
		public static TableSchema.Table ConDemanda{
            get { return DataService.GetSchema("CON_Demanda","RisProvider"); }
		}
        
		public static TableSchema.Table ConDemandaRechazada{
            get { return DataService.GetSchema("CON_DemandaRechazada","RisProvider"); }
		}
        
		public static TableSchema.Table ConEquipo{
            get { return DataService.GetSchema("CON_Equipo","RisProvider"); }
		}
        
		public static TableSchema.Table ConLugarActividadGrupal{
            get { return DataService.GetSchema("CON_LugarActividadGrupal","RisProvider"); }
		}
        
		public static TableSchema.Table ConMotivoBaja{
            get { return DataService.GetSchema("CON_MotivoBaja","RisProvider"); }
		}
        
		public static TableSchema.Table ConMotivoInactivacionAgenda{
            get { return DataService.GetSchema("CON_MotivoInactivacionAgenda","RisProvider"); }
		}
        
		public static TableSchema.Table ConMotivosDeBloqueo{
            get { return DataService.GetSchema("CON_MotivosDeBloqueo","RisProvider"); }
		}
        
		public static TableSchema.Table ConMotivosRechazo{
            get { return DataService.GetSchema("CON_MotivosRechazo","RisProvider"); }
		}
        
		public static TableSchema.Table ConNivelDeAbordaje{
            get { return DataService.GetSchema("CON_NivelDeAbordaje","RisProvider"); }
		}
        
		public static TableSchema.Table ConTematica{
            get { return DataService.GetSchema("CON_Tematica","RisProvider"); }
		}
        
		public static TableSchema.Table ConTiempoInsumido{
            get { return DataService.GetSchema("CON_TiempoInsumido","RisProvider"); }
		}
        
		public static TableSchema.Table ConTipoActividadGrupal{
            get { return DataService.GetSchema("CON_TipoActividadGrupal","RisProvider"); }
		}
        
		public static TableSchema.Table ConTipoDePrestacionSaludMental{
            get { return DataService.GetSchema("CON_TipoDePrestacionSaludMental","RisProvider"); }
		}
        
		public static TableSchema.Table ConTipoPrestacion{
            get { return DataService.GetSchema("CON_TipoPrestacion","RisProvider"); }
		}
        
		public static TableSchema.Table ConTurno{
            get { return DataService.GetSchema("CON_Turno","RisProvider"); }
		}
        
		public static TableSchema.Table ConTurnoAsistencium{
            get { return DataService.GetSchema("CON_TurnoAsistencia","RisProvider"); }
		}
        
		public static TableSchema.Table ConTurnoAuditorium{
            get { return DataService.GetSchema("CON_TurnoAuditoria","RisProvider"); }
		}
        
		public static TableSchema.Table ConTurnoBloqueo{
            get { return DataService.GetSchema("CON_TurnoBloqueo","RisProvider"); }
		}
        
		public static TableSchema.Table ConTurnoEstado{
            get { return DataService.GetSchema("CON_TurnoEstado","RisProvider"); }
		}
        
		public static TableSchema.Table ConTurnoRecitum{
            get { return DataService.GetSchema("CON_TurnoRecita","RisProvider"); }
		}
        
		public static TableSchema.Table ConTurnoReserva{
            get { return DataService.GetSchema("CON_TurnoReserva","RisProvider"); }
		}
        
		public static TableSchema.Table ConTurnoReservaInterconsultum{
            get { return DataService.GetSchema("CON_TurnoReservaInterconsulta","RisProvider"); }
		}
        
		public static TableSchema.Table Duration{
            get { return DataService.GetSchema("Duration","RisProvider"); }
		}
        
		public static TableSchema.Table EmrBase{
            get { return DataService.GetSchema("EMR_Base","RisProvider"); }
		}
        
		public static TableSchema.Table EmrGlasgowMotor{
            get { return DataService.GetSchema("EMR_GlasgowMotor","RisProvider"); }
		}
        
		public static TableSchema.Table EmrGlasgowOcular{
            get { return DataService.GetSchema("EMR_GlasgowOcular","RisProvider"); }
		}
        
		public static TableSchema.Table EmrGlasgowVerbal{
            get { return DataService.GetSchema("EMR_GlasgowVerbal","RisProvider"); }
		}
        
		public static TableSchema.Table EmrPrehospitalarium{
            get { return DataService.GetSchema("EMR_Prehospitalaria","RisProvider"); }
		}
        
		public static TableSchema.Table EmrPupila{
            get { return DataService.GetSchema("EMR_Pupilas","RisProvider"); }
		}
        
		public static TableSchema.Table EmrRegistro{
            get { return DataService.GetSchema("EMR_Registro","RisProvider"); }
		}
        
		public static TableSchema.Table EmrRelAntecedentePaciente{
            get { return DataService.GetSchema("EMR_RelAntecedentePaciente","RisProvider"); }
		}
        
		public static TableSchema.Table EmrRelTraumaPrehospitalarium{
            get { return DataService.GetSchema("EMR_RelTraumaPrehospitalaria","RisProvider"); }
		}
        
		public static TableSchema.Table EmrTipoTrauma{
            get { return DataService.GetSchema("EMR_TipoTrauma","RisProvider"); }
		}
        
		public static TableSchema.Table EmrTrauma{
            get { return DataService.GetSchema("EMR_Trauma","RisProvider"); }
		}
        
		public static TableSchema.Table FacCapitulo{
            get { return DataService.GetSchema("FAC_Capitulo","RisProvider"); }
		}
        
		public static TableSchema.Table FacContratoObraSocial{
            get { return DataService.GetSchema("FAC_ContratoObraSocial","RisProvider"); }
		}
        
		public static TableSchema.Table FacExtOrden{
            get { return DataService.GetSchema("FAC_EXT_Orden","RisProvider"); }
		}
        
		public static TableSchema.Table FacExtOrdenDetalle{
            get { return DataService.GetSchema("FAC_EXT_OrdenDetalle","RisProvider"); }
		}
        
		public static TableSchema.Table FacExtPaciente{
            get { return DataService.GetSchema("FAC_EXT_Paciente","RisProvider"); }
		}
        
		public static TableSchema.Table FacFactura{
            get { return DataService.GetSchema("FAC_Factura","RisProvider"); }
		}
        
		public static TableSchema.Table FacFacturaDetalle{
            get { return DataService.GetSchema("FAC_FacturaDetalle","RisProvider"); }
		}
        
		public static TableSchema.Table FacJefeLaboratorio{
            get { return DataService.GetSchema("FAC_JefeLaboratorio","RisProvider"); }
		}
        
		public static TableSchema.Table FacNomenclador{
            get { return DataService.GetSchema("FAC_Nomenclador","RisProvider"); }
		}
        
		public static TableSchema.Table FacNomencladorOrig{
            get { return DataService.GetSchema("FAC_Nomenclador_orig","RisProvider"); }
		}
        
		public static TableSchema.Table FacNomenclador2012{
            get { return DataService.GetSchema("FAC_Nomenclador2012","RisProvider"); }
		}
        
		public static TableSchema.Table FacNomenclador2015{
            get { return DataService.GetSchema("FAC_Nomenclador2015","RisProvider"); }
		}
        
		public static TableSchema.Table FacNomencladorExclusion{
            get { return DataService.GetSchema("FAC_NomencladorExclusion","RisProvider"); }
		}
        
		public static TableSchema.Table FacOrden{
            get { return DataService.GetSchema("FAC_Orden","RisProvider"); }
		}
        
		public static TableSchema.Table FacOrdenDetalle{
            get { return DataService.GetSchema("FAC_OrdenDetalle","RisProvider"); }
		}
        
		public static TableSchema.Table FacOrdenDocumentacion{
            get { return DataService.GetSchema("FAC_OrdenDocumentacion","RisProvider"); }
		}
        
		public static TableSchema.Table FacOrdenLaboratorio{
            get { return DataService.GetSchema("FAC_OrdenLaboratorio","RisProvider"); }
		}
        
		public static TableSchema.Table FacOrdenPaciente{
            get { return DataService.GetSchema("FAC_OrdenPaciente","RisProvider"); }
		}
        
		public static TableSchema.Table FacOrdenTurno{
            get { return DataService.GetSchema("FAC_OrdenTurno","RisProvider"); }
		}
        
		public static TableSchema.Table FacPadron{
            get { return DataService.GetSchema("FAC_Padron","RisProvider"); }
		}
        
		public static TableSchema.Table FacPrecioNaftum{
            get { return DataService.GetSchema("FAC_PrecioNafta","RisProvider"); }
		}
        
		public static TableSchema.Table FacPreFactura{
            get { return DataService.GetSchema("FAC_PreFactura","RisProvider"); }
		}
        
		public static TableSchema.Table FacRelEspecialidadNomenclador{
            get { return DataService.GetSchema("FAC_RelEspecialidadNomenclador","RisProvider"); }
		}
        
		public static TableSchema.Table FacRelPerfilPaginaPrincipal{
            get { return DataService.GetSchema("FAC_RelPerfilPaginaPrincipal","RisProvider"); }
		}
        
		public static TableSchema.Table FacTipoFactura{
            get { return DataService.GetSchema("FAC_TipoFactura","RisProvider"); }
		}
        
		public static TableSchema.Table FacTipoIva{
            get { return DataService.GetSchema("FAC_TipoIva","RisProvider"); }
		}
        
		public static TableSchema.Table FacTipoNomenclador{
            get { return DataService.GetSchema("FAC_TipoNomenclador","RisProvider"); }
		}
        
		public static TableSchema.Table FacTipoPractica{
            get { return DataService.GetSchema("FAC_TipoPractica","RisProvider"); }
		}
        
		public static TableSchema.Table FacUnidad{
            get { return DataService.GetSchema("FAC_Unidad","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaAntecedente{
            get { return DataService.GetSchema("Guardia_Antecedentes","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaC2{
            get { return DataService.GetSchema("Guardia_C2","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaMedicosFuncione{
            get { return DataService.GetSchema("Guardia_Medicos_Funciones","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaMedicosRegistroIngreso{
            get { return DataService.GetSchema("Guardia_Medicos_registroIngreso","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaMedicosTiposFuncione{
            get { return DataService.GetSchema("Guardia_Medicos_TiposFunciones","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaMensaje{
            get { return DataService.GetSchema("Guardia_Mensajes","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaPracticasClase{
            get { return DataService.GetSchema("Guardia_Practicas_Clases","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaPracticasEstado{
            get { return DataService.GetSchema("Guardia_Practicas_Estados","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaPracticasPrioridade{
            get { return DataService.GetSchema("Guardia_Practicas_Prioridades","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaPrescripcione{
            get { return DataService.GetSchema("Guardia_Prescripciones","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaRegistro{
            get { return DataService.GetSchema("Guardia_Registros","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaRegistrosClasificacione{
            get { return DataService.GetSchema("Guardia_Registros_Clasificaciones","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaRegistrosDiagnostico{
            get { return DataService.GetSchema("Guardia_Registros_Diagnosticos","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaRegistrosDiagnosticosCie10{
            get { return DataService.GetSchema("Guardia_Registros_Diagnosticos_Cie10","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaRegistrosEstado{
            get { return DataService.GetSchema("Guardia_Registros_Estados","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaRegistrosHistorial{
            get { return DataService.GetSchema("Guardia_Registros_Historial","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaRegistrosMedicosResponsable{
            get { return DataService.GetSchema("Guardia_Registros_MedicosResponsables","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaRegistrosPractica{
            get { return DataService.GetSchema("Guardia_Registros_Practicas","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaRegistrosPracticasLaboratorio{
            get { return DataService.GetSchema("Guardia_Registros_Practicas_Laboratorio","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaTipoPractica{
            get { return DataService.GetSchema("Guardia_TipoPracticas","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaTiposEgreso{
            get { return DataService.GetSchema("Guardia_TiposEgresos","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaTiposIngreso{
            get { return DataService.GetSchema("Guardia_TiposIngreso","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaTriage{
            get { return DataService.GetSchema("Guardia_Triage","RisProvider"); }
		}
        
		public static TableSchema.Table GuardiaTurnero{
            get { return DataService.GetSchema("Guardia_Turnero","RisProvider"); }
		}
        
		public static TableSchema.Table HidHidatidosi{
            get { return DataService.GetSchema("Hid_Hidatidosis","RisProvider"); }
		}
        
		public static TableSchema.Table HidHidatidosisParcial{
            get { return DataService.GetSchema("Hid_HidatidosisParcial","RisProvider"); }
		}
        
		public static TableSchema.Table IcoDestinatarioInterconsultum{
            get { return DataService.GetSchema("ICO_DestinatarioInterconsulta","RisProvider"); }
		}
        
		public static TableSchema.Table IcoDialogoInterconsultum{
            get { return DataService.GetSchema("ICO_DialogoInterconsulta","RisProvider"); }
		}
        
		public static TableSchema.Table IcoInterconsultum{
            get { return DataService.GetSchema("ICO_Interconsulta","RisProvider"); }
		}
        
		public static TableSchema.Table IcoTiposUsuario{
            get { return DataService.GetSchema("ICO_TiposUsuario","RisProvider"); }
		}
        
		public static TableSchema.Table IcoUbicacionArchivo{
            get { return DataService.GetSchema("ICO_UbicacionArchivos","RisProvider"); }
		}
        
		public static TableSchema.Table InsAlarma{
            get { return DataService.GetSchema("INS_Alarma","RisProvider"); }
		}
        
		public static TableSchema.Table InsDatoFarmaceutico{
            get { return DataService.GetSchema("INS_DatoFarmaceutico","RisProvider"); }
		}
        
		public static TableSchema.Table InsDeposito{
            get { return DataService.GetSchema("INS_Deposito","RisProvider"); }
		}
        
		public static TableSchema.Table InsDosi{
            get { return DataService.GetSchema("INS_Dosis","RisProvider"); }
		}
        
		public static TableSchema.Table InsEstadoPedido{
            get { return DataService.GetSchema("INS_EstadoPedido","RisProvider"); }
		}
        
		public static TableSchema.Table InsFoo{
            get { return DataService.GetSchema("INS_Foo","RisProvider"); }
		}
        
		public static TableSchema.Table InsInsumo{
            get { return DataService.GetSchema("INS_Insumo","RisProvider"); }
		}
        
		public static TableSchema.Table InsInsumoOld{
            get { return DataService.GetSchema("INS_Insumo_old","RisProvider"); }
		}
        
		public static TableSchema.Table InsInsumosEquivalente{
            get { return DataService.GetSchema("INS_InsumosEquivalentes","RisProvider"); }
		}
        
		public static TableSchema.Table InsInternacionPedido{
            get { return DataService.GetSchema("INS_InternacionPedido","RisProvider"); }
		}
        
		public static TableSchema.Table InsMotivosRechazo{
            get { return DataService.GetSchema("INS_MotivosRechazo","RisProvider"); }
		}
        
		public static TableSchema.Table InsMovimiento{
            get { return DataService.GetSchema("INS_Movimiento","RisProvider"); }
		}
        
		public static TableSchema.Table InsMovimientoDetalle{
            get { return DataService.GetSchema("INS_MovimientoDetalle","RisProvider"); }
		}
        
		public static TableSchema.Table InsOrdenCompra{
            get { return DataService.GetSchema("INS_OrdenCompra","RisProvider"); }
		}
        
		public static TableSchema.Table InsPedido{
            get { return DataService.GetSchema("INS_Pedido","RisProvider"); }
		}
        
		public static TableSchema.Table InsPedidoDetalle{
            get { return DataService.GetSchema("INS_PedidoDetalle","RisProvider"); }
		}
        
		public static TableSchema.Table InsPrescripcion{
            get { return DataService.GetSchema("INS_Prescripcion","RisProvider"); }
		}
        
		public static TableSchema.Table InsPrescripcionDetalle{
            get { return DataService.GetSchema("INS_PrescripcionDetalle","RisProvider"); }
		}
        
		public static TableSchema.Table InsPrescripcionEntrega{
            get { return DataService.GetSchema("INS_PrescripcionEntrega","RisProvider"); }
		}
        
		public static TableSchema.Table InsPrograma{
            get { return DataService.GetSchema("INS_Programa","RisProvider"); }
		}
        
		public static TableSchema.Table InsProveedor{
            get { return DataService.GetSchema("INS_Proveedor","RisProvider"); }
		}
        
		public static TableSchema.Table InsRelInsumoEfector{
            get { return DataService.GetSchema("INS_RelInsumoEfector","RisProvider"); }
		}
        
		public static TableSchema.Table InsRelInsumoPrograma{
            get { return DataService.GetSchema("INS_RelInsumoPrograma","RisProvider"); }
		}
        
		public static TableSchema.Table InsRubro{
            get { return DataService.GetSchema("INS_Rubro","RisProvider"); }
		}
        
		public static TableSchema.Table InsTipoComprobante{
            get { return DataService.GetSchema("INS_TipoComprobante","RisProvider"); }
		}
        
		public static TableSchema.Table JmCargo{
            get { return DataService.GetSchema("JM_Cargo","RisProvider"); }
		}
        
		public static TableSchema.Table JmCertificadoMedico{
            get { return DataService.GetSchema("JM_CertificadoMedico","RisProvider"); }
		}
        
		public static TableSchema.Table JmDato{
            get { return DataService.GetSchema("JM_Datos","RisProvider"); }
		}
        
		public static TableSchema.Table JmDetalle{
            get { return DataService.GetSchema("JM_Detalle","RisProvider"); }
		}
        
		public static TableSchema.Table JmLPago{
            get { return DataService.GetSchema("JM_LPago","RisProvider"); }
		}
        
		public static TableSchema.Table JmNacionalidad{
            get { return DataService.GetSchema("JM_Nacionalidad","RisProvider"); }
		}
        
		public static TableSchema.Table JmParte{
            get { return DataService.GetSchema("JM_Partes","RisProvider"); }
		}
        
		public static TableSchema.Table JmPersonal{
            get { return DataService.GetSchema("JM_Personal","RisProvider"); }
		}
        
		public static TableSchema.Table JmProfesional{
            get { return DataService.GetSchema("JM_Profesional","RisProvider"); }
		}
        
		public static TableSchema.Table JmResponsable{
            get { return DataService.GetSchema("JM_Responsables","RisProvider"); }
		}
        
		public static TableSchema.Table LabAcceso{
            get { return DataService.GetSchema("LAB_Acceso","RisProvider"); }
		}
        
		public static TableSchema.Table LabAccesoResultado{
            get { return DataService.GetSchema("LAB_AccesoResultado","RisProvider"); }
		}
        
		public static TableSchema.Table LabAlarmaScreening{
            get { return DataService.GetSchema("LAB_AlarmaScreening","RisProvider"); }
		}
        
		public static TableSchema.Table LabDetalleSolicitudScreening{
            get { return DataService.GetSchema("LAB_DetalleSolicitudScreening","RisProvider"); }
		}
        
		public static TableSchema.Table LabItemRepeticionScreening{
            get { return DataService.GetSchema("LAB_ItemRepeticionScreening","RisProvider"); }
		}
        
		public static TableSchema.Table LabItemScreening{
            get { return DataService.GetSchema("LAB_ItemScreening","RisProvider"); }
		}
        
		public static TableSchema.Table LabItemScreeningResultado{
            get { return DataService.GetSchema("LAB_ItemScreeningResultado","RisProvider"); }
		}
        
		public static TableSchema.Table LabMetodoScreening{
            get { return DataService.GetSchema("LAB_MetodoScreening","RisProvider"); }
		}
        
		public static TableSchema.Table LabMotivoRechazoScreening{
            get { return DataService.GetSchema("LAB_MotivoRechazoScreening","RisProvider"); }
		}
        
		public static TableSchema.Table LabMotivoRepeticionScreening{
            get { return DataService.GetSchema("LAB_MotivoRepeticionScreening","RisProvider"); }
		}
        
		public static TableSchema.Table LabProtocoloScreening{
            get { return DataService.GetSchema("LAB_ProtocoloScreening","RisProvider"); }
		}
        
		public static TableSchema.Table LabProtocoloScreeningDetalle{
            get { return DataService.GetSchema("LAB_ProtocoloScreeningDetalle","RisProvider"); }
		}
        
		public static TableSchema.Table LabReactivo{
            get { return DataService.GetSchema("LAB_Reactivo","RisProvider"); }
		}
        
		public static TableSchema.Table LabResultadoDetalle{
            get { return DataService.GetSchema("LAB_ResultadoDetalle","RisProvider"); }
		}
        
		public static TableSchema.Table LabResultadoEncabezado{
            get { return DataService.GetSchema("LAB_ResultadoEncabezado","RisProvider"); }
		}
        
		public static TableSchema.Table LabResultadoScreening{
            get { return DataService.GetSchema("LAB_ResultadoScreening","RisProvider"); }
		}
        
		public static TableSchema.Table LabSolicitudScreening{
            get { return DataService.GetSchema("LAB_SolicitudScreening","RisProvider"); }
		}
        
		public static TableSchema.Table LabSolicitudScreeningEstado{
            get { return DataService.GetSchema("Lab_SolicitudScreeningEstados","RisProvider"); }
		}
        
		public static TableSchema.Table LabSolicitudScreeningRepeticion{
            get { return DataService.GetSchema("LAB_SolicitudScreeningRepeticion","RisProvider"); }
		}
        
		public static TableSchema.Table LabTempResultadoDetalle{
            get { return DataService.GetSchema("LAB_Temp_ResultadoDetalle","RisProvider"); }
		}
        
		public static TableSchema.Table LabTempResultadoEncabezado{
            get { return DataService.GetSchema("LAB_Temp_ResultadoEncabezado","RisProvider"); }
		}
        
		public static TableSchema.Table LabTempSolicitudScreening20131209{
            get { return DataService.GetSchema("Lab_temp_SolicitudScreening20131209","RisProvider"); }
		}
        
		public static TableSchema.Table LabTempResultadoTarjetasScreening{
            get { return DataService.GetSchema("Lab_TempResultadoTarjetasScreening","RisProvider"); }
		}
        
		public static TableSchema.Table Localidad{
            get { return DataService.GetSchema("Localidad","RisProvider"); }
		}
        
		public static TableSchema.Table MamAnatomiaPatologica{
            get { return DataService.GetSchema("MAM_AnatomiaPatologica","RisProvider"); }
		}
        
		public static TableSchema.Table MamAntecedente{
            get { return DataService.GetSchema("MAM_Antecedentes","RisProvider"); }
		}
        
		public static TableSchema.Table MamBirad{
            get { return DataService.GetSchema("MAM_Birads","RisProvider"); }
		}
        
		public static TableSchema.Table MamCirugium{
            get { return DataService.GetSchema("MAM_Cirugia","RisProvider"); }
		}
        
		public static TableSchema.Table MamDiagnosticoCitologico{
            get { return DataService.GetSchema("MAM_DiagnosticoCitologico","RisProvider"); }
		}
        
		public static TableSchema.Table MamDiagnoticoHistologico{
            get { return DataService.GetSchema("MAM_DiagnoticoHistologico","RisProvider"); }
		}
        
		public static TableSchema.Table MamEcografium{
            get { return DataService.GetSchema("MAM_Ecografia","RisProvider"); }
		}
        
		public static TableSchema.Table MamEstudiosAdicionale{
            get { return DataService.GetSchema("MAM_EstudiosAdicionales","RisProvider"); }
		}
        
		public static TableSchema.Table MamEstudiosHospitalProvincial{
            get { return DataService.GetSchema("MAM_EstudiosHospitalProvincial","RisProvider"); }
		}
        
		public static TableSchema.Table MamExamenFisico{
            get { return DataService.GetSchema("MAM_ExamenFisico","RisProvider"); }
		}
        
		public static TableSchema.Table MamMaterial{
            get { return DataService.GetSchema("MAM_Material","RisProvider"); }
		}
        
		public static TableSchema.Table MamMotivo{
            get { return DataService.GetSchema("MAM_Motivo","RisProvider"); }
		}
        
		public static TableSchema.Table MamMotivoConsultum{
            get { return DataService.GetSchema("MAM_MotivoConsulta","RisProvider"); }
		}
        
		public static TableSchema.Table MamPiezaQuirurgica{
            get { return DataService.GetSchema("MAM_PiezaQuirurgica","RisProvider"); }
		}
        
		public static TableSchema.Table MamRegistro{
            get { return DataService.GetSchema("MAM_Registro","RisProvider"); }
		}
        
		public static TableSchema.Table MamResultadoExFisico{
            get { return DataService.GetSchema("MAM_ResultadoExFisico","RisProvider"); }
		}
        
		public static TableSchema.Table MamTipoCirugium{
            get { return DataService.GetSchema("MAM_TipoCirugia","RisProvider"); }
		}
        
		public static TableSchema.Table MamTipoEquipo{
            get { return DataService.GetSchema("MAM_TipoEquipo","RisProvider"); }
		}
        
		public static TableSchema.Table MamTipoEstudio{
            get { return DataService.GetSchema("MAM_TipoEstudio","RisProvider"); }
		}
        
		public static TableSchema.Table MamTipoMotivoConsultum{
            get { return DataService.GetSchema("MAM_TipoMotivoConsulta","RisProvider"); }
		}
        
		public static TableSchema.Table MamTratamiento{
            get { return DataService.GetSchema("MAM_Tratamientos","RisProvider"); }
		}
        
		public static TableSchema.Table Nomivac{
            get { return DataService.GetSchema("Nomivac","RisProvider"); }
		}
        
		public static TableSchema.Table OdoNomenclador{
            get { return DataService.GetSchema("ODO_Nomenclador","RisProvider"); }
		}
        
		public static TableSchema.Table OdoPrograma{
            get { return DataService.GetSchema("ODO_Programa","RisProvider"); }
		}
        
		public static TableSchema.Table PacientesVillaFarrel{
            get { return DataService.GetSchema("Pacientes_VillaFarrel","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssAccount{
            get { return DataService.GetSchema("phpss_account","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssAccountGroup{
            get { return DataService.GetSchema("phpss_account_group","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssBruteforceAccount{
            get { return DataService.GetSchema("phpss_bruteforce_account","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssBruteforceAccountFail{
            get { return DataService.GetSchema("phpss_bruteforce_account_fail","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssBruteforceAccountLock{
            get { return DataService.GetSchema("phpss_bruteforce_account_lock","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssBruteforceIp{
            get { return DataService.GetSchema("phpss_bruteforce_ip","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssBruteforceIpFail{
            get { return DataService.GetSchema("phpss_bruteforce_ip_fail","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssBruteforceIpLock{
            get { return DataService.GetSchema("phpss_bruteforce_ip_lock","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssGroup{
            get { return DataService.GetSchema("phpss_group","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssIp{
            get { return DataService.GetSchema("phpss_ip","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssIpaccess{
            get { return DataService.GetSchema("phpss_ipaccess","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssIpaccessAccount{
            get { return DataService.GetSchema("phpss_ipaccess_account","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssIpaccessGroup{
            get { return DataService.GetSchema("phpss_ipaccess_group","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssLog{
            get { return DataService.GetSchema("phpss_log","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssSession{
            get { return DataService.GetSchema("phpss_session","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssSvar{
            get { return DataService.GetSchema("phpss_svars","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssUsertrackReq{
            get { return DataService.GetSchema("phpss_usertrack_req","RisProvider"); }
		}
        
		public static TableSchema.Table PhpssUsertrackUrl{
            get { return DataService.GetSchema("phpss_usertrack_url","RisProvider"); }
		}
        
		public static TableSchema.Table PnAccidentesLab{
            get { return DataService.GetSchema("PN_accidentes_lab","RisProvider"); }
		}
        
		public static TableSchema.Table PnAfjp{
            get { return DataService.GetSchema("PN_afjp","RisProvider"); }
		}
        
		public static TableSchema.Table PnAgenteInscriptor{
            get { return DataService.GetSchema("PN_agente_inscriptor","RisProvider"); }
		}
        
		public static TableSchema.Table PnAltum{
            get { return DataService.GetSchema("PN_alta","RisProvider"); }
		}
        
		public static TableSchema.Table PnAnexo{
            get { return DataService.GetSchema("PN_anexo","RisProvider"); }
		}
        
		public static TableSchema.Table PnArbol{
            get { return DataService.GetSchema("PN_arbol","RisProvider"); }
		}
        
		public static TableSchema.Table PnArchivoManual{
            get { return DataService.GetSchema("PN_archivo_manual","RisProvider"); }
		}
        
		public static TableSchema.Table PnArchivosCaso{
            get { return DataService.GetSchema("PN_archivos_casos","RisProvider"); }
		}
        
		public static TableSchema.Table PnArchivosEnviado{
            get { return DataService.GetSchema("PN_archivos_enviados","RisProvider"); }
		}
        
		public static TableSchema.Table PnArchivosRecibido{
            get { return DataService.GetSchema("PN_archivos_recibidos","RisProvider"); }
		}
        
		public static TableSchema.Table PnArea{
            get { return DataService.GetSchema("PN_areas","RisProvider"); }
		}
        
		public static TableSchema.Table PnAsistencium{
            get { return DataService.GetSchema("PN_asistencia","RisProvider"); }
		}
        
		public static TableSchema.Table PnAusentismo{
            get { return DataService.GetSchema("PN_ausentismo","RisProvider"); }
		}
        
		public static TableSchema.Table PnBarrio{
            get { return DataService.GetSchema("PN_barrios","RisProvider"); }
		}
        
		public static TableSchema.Table PnBeneficiario{
            get { return DataService.GetSchema("PN_beneficiarios","RisProvider"); }
		}
        
		public static TableSchema.Table PnBorrar{
            get { return DataService.GetSchema("PN_Borrar","RisProvider"); }
		}
        
		public static TableSchema.Table PnCalculaPrecio{
            get { return DataService.GetSchema("PN_calcula_precio","RisProvider"); }
		}
        
		public static TableSchema.Table PnCalificacion{
            get { return DataService.GetSchema("PN_calificacion","RisProvider"); }
		}
        
		public static TableSchema.Table PnCapacitacione{
            get { return DataService.GetSchema("PN_capacitaciones","RisProvider"); }
		}
        
		public static TableSchema.Table PnCapacitado{
            get { return DataService.GetSchema("PN_capacitados","RisProvider"); }
		}
        
		public static TableSchema.Table PnCapsHacenParto{
            get { return DataService.GetSchema("PN_caps_hacen_partos","RisProvider"); }
		}
        
		public static TableSchema.Table PnCategoria{
            get { return DataService.GetSchema("PN_categorias","RisProvider"); }
		}
        
		public static TableSchema.Table PnClasificacionManual{
            get { return DataService.GetSchema("PN_clasificacion_manual","RisProvider"); }
		}
        
		public static TableSchema.Table PnComprobante{
            get { return DataService.GetSchema("PN_comprobante","RisProvider"); }
		}
        
		public static TableSchema.Table PnCredito{
            get { return DataService.GetSchema("PN_credito","RisProvider"); }
		}
        
		public static TableSchema.Table PnCurriculumIdioma{
            get { return DataService.GetSchema("PN_curriculum_idiomas","RisProvider"); }
		}
        
		public static TableSchema.Table PnCurriculumReferencium{
            get { return DataService.GetSchema("PN_curriculum_referencia","RisProvider"); }
		}
        
		public static TableSchema.Table PnDatMinObl{
            get { return DataService.GetSchema("PN_dat_min_obl","RisProvider"); }
		}
        
		public static TableSchema.Table PnDatosReportable{
            get { return DataService.GetSchema("PN_datos_reportables","RisProvider"); }
		}
        
		public static TableSchema.Table PnDebito{
            get { return DataService.GetSchema("PN_debito","RisProvider"); }
		}
        
		public static TableSchema.Table PnDepartamento{
            get { return DataService.GetSchema("PN_departamentos","RisProvider"); }
		}
        
		public static TableSchema.Table PnDescIndicadorIn{
            get { return DataService.GetSchema("PN_desc_indicador_ins","RisProvider"); }
		}
        
		public static TableSchema.Table PnDiasSemana{
            get { return DataService.GetSchema("PN_dias_semana","RisProvider"); }
		}
        
		public static TableSchema.Table PnDirectoriosArchivo{
            get { return DataService.GetSchema("PN_directorios_archivos","RisProvider"); }
		}
        
		public static TableSchema.Table PnDistrito{
            get { return DataService.GetSchema("PN_distrito","RisProvider"); }
		}
        
		public static TableSchema.Table PnDosisApli{
            get { return DataService.GetSchema("PN_dosis_apli","RisProvider"); }
		}
        
		public static TableSchema.Table PnDpto{
            get { return DataService.GetSchema("PN_dpto","RisProvider"); }
		}
        
		public static TableSchema.Table PnEfeConv{
            get { return DataService.GetSchema("PN_efe_conv","RisProvider"); }
		}
        
		public static TableSchema.Table PnEfecNom{
            get { return DataService.GetSchema("PN_efec_nom","RisProvider"); }
		}
        
		public static TableSchema.Table PnEgreso{
            get { return DataService.GetSchema("PN_egreso","RisProvider"); }
		}
        
		public static TableSchema.Table PnEmbarazada{
            get { return DataService.GetSchema("PN_embarazadas","RisProvider"); }
		}
        
		public static TableSchema.Table PnEnfermedade{
            get { return DataService.GetSchema("PN_enfermedades","RisProvider"); }
		}
        
		public static TableSchema.Table PnEntrega{
            get { return DataService.GetSchema("PN_entrega","RisProvider"); }
		}
        
		public static TableSchema.Table PnEvaluadore{
            get { return DataService.GetSchema("PN_evaluadores","RisProvider"); }
		}
        
		public static TableSchema.Table PnEvento{
            get { return DataService.GetSchema("PN_evento","RisProvider"); }
		}
        
		public static TableSchema.Table PnExpediente{
            get { return DataService.GetSchema("PN_expediente","RisProvider"); }
		}
        
		public static TableSchema.Table PnFactura{
            get { return DataService.GetSchema("PN_factura","RisProvider"); }
		}
        
		public static TableSchema.Table PnFamilium{
            get { return DataService.GetSchema("PN_familia","RisProvider"); }
		}
        
		public static TableSchema.Table PnFeriado{
            get { return DataService.GetSchema("PN_feriados","RisProvider"); }
		}
        
		public static TableSchema.Table PnGrupoPrestacion{
            get { return DataService.GetSchema("PN_grupo_prestacion","RisProvider"); }
		}
        
		public static TableSchema.Table PnGrupo{
            get { return DataService.GetSchema("PN_grupos","RisProvider"); }
		}
        
		public static TableSchema.Table PnGruposUsuario{
            get { return DataService.GetSchema("PN_grupos_usuarios","RisProvider"); }
		}
        
		public static TableSchema.Table PnHistoricotemp{
            get { return DataService.GetSchema("PN_historicotemp","RisProvider"); }
		}
        
		public static TableSchema.Table PnHorariosTrabajo{
            get { return DataService.GetSchema("PN_horarios_trabajo","RisProvider"); }
		}
        
		public static TableSchema.Table PnInasistencium{
            get { return DataService.GetSchema("PN_inasistencia","RisProvider"); }
		}
        
		public static TableSchema.Table PnInciso{
            get { return DataService.GetSchema("PN_inciso","RisProvider"); }
		}
        
		public static TableSchema.Table PnIncisoItemGasto{
            get { return DataService.GetSchema("PN_inciso_item_gasto","RisProvider"); }
		}
        
		public static TableSchema.Table PnIndicadoresGlobale{
            get { return DataService.GetSchema("PN_indicadores_globales","RisProvider"); }
		}
        
		public static TableSchema.Table PnIndicadoresIn{
            get { return DataService.GetSchema("PN_indicadores_ins","RisProvider"); }
		}
        
		public static TableSchema.Table PnIngreso{
            get { return DataService.GetSchema("PN_ingreso","RisProvider"); }
		}
        
		public static TableSchema.Table PnItemGasto{
            get { return DataService.GetSchema("PN_item_gasto","RisProvider"); }
		}
        
		public static TableSchema.Table PnLegajo{
            get { return DataService.GetSchema("PN_legajos","RisProvider"); }
		}
        
		public static TableSchema.Table PnLegajosExt{
            get { return DataService.GetSchema("PN_legajos_ext","RisProvider"); }
		}
        
		public static TableSchema.Table PnLengua{
            get { return DataService.GetSchema("PN_lenguas","RisProvider"); }
		}
        
		public static TableSchema.Table PnLocalidade{
            get { return DataService.GetSchema("PN_localidades","RisProvider"); }
		}
        
		public static TableSchema.Table PnLogComprobante{
            get { return DataService.GetSchema("PN_log_comprobante","RisProvider"); }
		}
        
		public static TableSchema.Table PnLogEvento{
            get { return DataService.GetSchema("PN_log_evento","RisProvider"); }
		}
        
		public static TableSchema.Table PnLogFactura{
            get { return DataService.GetSchema("PN_log_factura","RisProvider"); }
		}
        
		public static TableSchema.Table PnLogManual{
            get { return DataService.GetSchema("PN_log_manual","RisProvider"); }
		}
        
		public static TableSchema.Table PnLogPacPap{
            get { return DataService.GetSchema("PN_log_pac_pap","RisProvider"); }
		}
        
		public static TableSchema.Table PnLogPlanilla{
            get { return DataService.GetSchema("PN_log_planilla","RisProvider"); }
		}
        
		public static TableSchema.Table PnLogPrestacion{
            get { return DataService.GetSchema("PN_log_prestacion","RisProvider"); }
		}
        
		public static TableSchema.Table PnMailEfeConv{
            get { return DataService.GetSchema("PN_mail_efe_conv","RisProvider"); }
		}
        
		public static TableSchema.Table PnManual{
            get { return DataService.GetSchema("PN_manual","RisProvider"); }
		}
        
		public static TableSchema.Table PnMensaje{
            get { return DataService.GetSchema("PN_mensajes","RisProvider"); }
		}
        
		public static TableSchema.Table PnMotivoD{
            get { return DataService.GetSchema("PN_motivo_d","RisProvider"); }
		}
        
		public static TableSchema.Table PnMu{
            get { return DataService.GetSchema("PN_mu","RisProvider"); }
		}
        
		public static TableSchema.Table PnMunicipio{
            get { return DataService.GetSchema("PN_municipios","RisProvider"); }
		}
        
		public static TableSchema.Table PnNino{
            get { return DataService.GetSchema("PN_nino","RisProvider"); }
		}
        
		public static TableSchema.Table PnNinoNew{
            get { return DataService.GetSchema("PN_nino_new","RisProvider"); }
		}
        
		public static TableSchema.Table PnNoConformidad{
            get { return DataService.GetSchema("PN_no_conformidad","RisProvider"); }
		}
        
		public static TableSchema.Table PnNomenclador{
            get { return DataService.GetSchema("PN_nomenclador","RisProvider"); }
		}
        
		public static TableSchema.Table PnNomencladorDetalle{
            get { return DataService.GetSchema("PN_nomenclador_detalle","RisProvider"); }
		}
        
		public static TableSchema.Table PnNomencladorXPatologium{
            get { return DataService.GetSchema("PN_NomencladorXPatologia","RisProvider"); }
		}
        
		public static TableSchema.Table PnObrasSociale{
            get { return DataService.GetSchema("PN_obras_sociales","RisProvider"); }
		}
        
		public static TableSchema.Table PnOri{
            get { return DataService.GetSchema("PN_ori","RisProvider"); }
		}
        
		public static TableSchema.Table PnPacPap{
            get { return DataService.GetSchema("PN_pac_pap","RisProvider"); }
		}
        
		public static TableSchema.Table PnPai{
            get { return DataService.GetSchema("PN_pais","RisProvider"); }
		}
        
		public static TableSchema.Table PnParametro{
            get { return DataService.GetSchema("PN_parametros","RisProvider"); }
		}
        
		public static TableSchema.Table PnParto{
            get { return DataService.GetSchema("PN_partos","RisProvider"); }
		}
        
		public static TableSchema.Table PnPatologia{
            get { return DataService.GetSchema("PN_patologias","RisProvider"); }
		}
        
		public static TableSchema.Table PnPatologiasFrecuente{
            get { return DataService.GetSchema("PN_patologias_frecuentes","RisProvider"); }
		}
        
		public static TableSchema.Table PnPeriodo{
            get { return DataService.GetSchema("PN_periodo","RisProvider"); }
		}
        
		public static TableSchema.Table PnPermiso{
            get { return DataService.GetSchema("PN_permisos","RisProvider"); }
		}
        
		public static TableSchema.Table PnPermisosActuale{
            get { return DataService.GetSchema("PN_permisos_actuales","RisProvider"); }
		}
        
		public static TableSchema.Table PnPermisosGrupo{
            get { return DataService.GetSchema("PN_permisos_grupos","RisProvider"); }
		}
        
		public static TableSchema.Table PnPermisosSesion{
            get { return DataService.GetSchema("PN_permisos_sesion","RisProvider"); }
		}
        
		public static TableSchema.Table PnPermisosUsuario{
            get { return DataService.GetSchema("PN_permisos_usuarios","RisProvider"); }
		}
        
		public static TableSchema.Table PnPlanilla{
            get { return DataService.GetSchema("PN_planillas","RisProvider"); }
		}
        
		public static TableSchema.Table PnPrestacion{
            get { return DataService.GetSchema("PN_prestacion","RisProvider"); }
		}
        
		public static TableSchema.Table PnPrestacionesNOp{
            get { return DataService.GetSchema("PN_prestaciones_n_op","RisProvider"); }
		}
        
		public static TableSchema.Table PnPrestacionesNueva{
            get { return DataService.GetSchema("PN_PrestacionesNuevas","RisProvider"); }
		}
        
		public static TableSchema.Table PnPromocione{
            get { return DataService.GetSchema("PN_promociones","RisProvider"); }
		}
        
		public static TableSchema.Table PnProvincia{
            get { return DataService.GetSchema("PN_provincias","RisProvider"); }
		}
        
		public static TableSchema.Table PnPuco{
            get { return DataService.GetSchema("PN_puco","RisProvider"); }
		}
        
		public static TableSchema.Table PnRecibe{
            get { return DataService.GetSchema("PN_recibe","RisProvider"); }
		}
        
		public static TableSchema.Table PnRelNomencladorXDatoReportable{
            get { return DataService.GetSchema("PN_Rel_NomencladorXDatoReportable","RisProvider"); }
		}
        
		public static TableSchema.Table PnRelPrestacionXDatoReportable{
            get { return DataService.GetSchema("PN_Rel_PrestacionXDatoReportable","RisProvider"); }
		}
        
		public static TableSchema.Table PnRelPacienteAfiliado{
            get { return DataService.GetSchema("PN_RelPacienteAfiliado","RisProvider"); }
		}
        
		public static TableSchema.Table PnReporteHipoacustium{
            get { return DataService.GetSchema("PN_reporte_hipoacustia","RisProvider"); }
		}
        
		public static TableSchema.Table PnResponsable{
            get { return DataService.GetSchema("PN_responsables","RisProvider"); }
		}
        
		public static TableSchema.Table PnServicio{
            get { return DataService.GetSchema("PN_servicio","RisProvider"); }
		}
        
		public static TableSchema.Table PnSmiafiliado{
            get { return DataService.GetSchema("PN_smiafiliados","RisProvider"); }
		}
        
		public static TableSchema.Table PnSmiafiliadosaux{
            get { return DataService.GetSchema("PN_smiafiliadosaux","RisProvider"); }
		}
        
		public static TableSchema.Table PnSmiefectore{
            get { return DataService.GetSchema("PN_smiefectores","RisProvider"); }
		}
        
		public static TableSchema.Table PnSmiprocesoafiliado{
            get { return DataService.GetSchema("PN_smiprocesoafiliados","RisProvider"); }
		}
        
		public static TableSchema.Table PnSmitiposcategoria{
            get { return DataService.GetSchema("PN_smitiposcategorias","RisProvider"); }
		}
        
		public static TableSchema.Table PnSubirArchivo{
            get { return DataService.GetSchema("PN_subir_archivos","RisProvider"); }
		}
        
		public static TableSchema.Table PnSumariosPersonal{
            get { return DataService.GetSchema("PN_sumarios_personal","RisProvider"); }
		}
        
		public static TableSchema.Table PnSuspensione{
            get { return DataService.GetSchema("PN_suspensiones","RisProvider"); }
		}
        
		public static TableSchema.Table PnTareasDesemp{
            get { return DataService.GetSchema("PN_tareas_desemp","RisProvider"); }
		}
        
		public static TableSchema.Table PnTipoDeMensaje{
            get { return DataService.GetSchema("PN_tipo_de_mensaje","RisProvider"); }
		}
        
		public static TableSchema.Table PnTipoDocumento{
            get { return DataService.GetSchema("PN_tipo_documento","RisProvider"); }
		}
        
		public static TableSchema.Table PnTipoEvento{
            get { return DataService.GetSchema("PN_tipo_evento","RisProvider"); }
		}
        
		public static TableSchema.Table PnTipoPermiso{
            get { return DataService.GetSchema("PN_tipo_permiso","RisProvider"); }
		}
        
		public static TableSchema.Table PnTipoDePrestacion{
            get { return DataService.GetSchema("PN_TipoDePrestacion","RisProvider"); }
		}
        
		public static TableSchema.Table PnTransaccion{
            get { return DataService.GetSchema("PN_transaccion","RisProvider"); }
		}
        
		public static TableSchema.Table PnTransaccionCertificado{
            get { return DataService.GetSchema("PN_transaccion_certificado","RisProvider"); }
		}
        
		public static TableSchema.Table PnTribu{
            get { return DataService.GetSchema("PN_tribus","RisProvider"); }
		}
        
		public static TableSchema.Table PnTrzPre{
            get { return DataService.GetSchema("PN_trz_pres","RisProvider"); }
		}
        
		public static TableSchema.Table PnUadParametro{
            get { return DataService.GetSchema("PN_uad_parametros","RisProvider"); }
		}
        
		public static TableSchema.Table PnUsuario{
            get { return DataService.GetSchema("PN_usuarios","RisProvider"); }
		}
        
		public static TableSchema.Table PnVacApli{
            get { return DataService.GetSchema("PN_vac_apli","RisProvider"); }
		}
        
		public static TableSchema.Table PnVacuna{
            get { return DataService.GetSchema("PN_vacunas","RisProvider"); }
		}
        
		public static TableSchema.Table PnValidacionPrestacion{
            get { return DataService.GetSchema("PN_validacion_prestacion","RisProvider"); }
		}
        
		public static TableSchema.Table PnZonaSani{
            get { return DataService.GetSchema("PN_zona_sani","RisProvider"); }
		}
        
		public static TableSchema.Table PsmDato{
            get { return DataService.GetSchema("PSM_Datos","RisProvider"); }
		}
        
		public static TableSchema.Table PsmDerivacione{
            get { return DataService.GetSchema("PSM_Derivaciones","RisProvider"); }
		}
        
		public static TableSchema.Table PsmEFisico{
            get { return DataService.GetSchema("PSM_EFisico","RisProvider"); }
		}
        
		public static TableSchema.Table RegParte{
            get { return DataService.GetSchema("RegPartes","RisProvider"); }
		}
        
		public static TableSchema.Table RemActividadFisica{
            get { return DataService.GetSchema("Rem_ActividadFisica","RisProvider"); }
		}
        
		public static TableSchema.Table RemAgente{
            get { return DataService.GetSchema("Rem_Agente","RisProvider"); }
		}
        
		public static TableSchema.Table RemClasificacion{
            get { return DataService.GetSchema("Rem_Clasificacion","RisProvider"); }
		}
        
		public static TableSchema.Table RemComplicacione{
            get { return DataService.GetSchema("Rem_Complicaciones","RisProvider"); }
		}
        
		public static TableSchema.Table RemEstudioOcular{
            get { return DataService.GetSchema("Rem_EstudioOcular","RisProvider"); }
		}
        
		public static TableSchema.Table RemExamenPie{
            get { return DataService.GetSchema("Rem_ExamenPie","RisProvider"); }
		}
        
		public static TableSchema.Table RemFormulario{
            get { return DataService.GetSchema("Rem_Formulario","RisProvider"); }
		}
        
		public static TableSchema.Table RemInternacion{
            get { return DataService.GetSchema("Rem_Internacion","RisProvider"); }
		}
        
		public static TableSchema.Table RemMedicamentoCronico{
            get { return DataService.GetSchema("Rem_MedicamentoCronico","RisProvider"); }
		}
        
		public static TableSchema.Table RemRelMedicamentoClasificacion{
            get { return DataService.GetSchema("Rem_RelMedicamentoClasificacion","RisProvider"); }
		}
        
		public static TableSchema.Table RemRelMedicamentoSeguimiento{
            get { return DataService.GetSchema("Rem_RelMedicamentoSeguimiento","RisProvider"); }
		}
        
		public static TableSchema.Table RemSeguimiento{
            get { return DataService.GetSchema("Rem_Seguimiento","RisProvider"); }
		}
        
		public static TableSchema.Table RemTablaExaman{
            get { return DataService.GetSchema("Rem_TablaExamen","RisProvider"); }
		}
        
		public static TableSchema.Table RemTipoCobertura{
            get { return DataService.GetSchema("Rem_TipoCobertura","RisProvider"); }
		}
        
		public static TableSchema.Table RisAreaTematica{
            get { return DataService.GetSchema("RIS_AreaTematica","RisProvider"); }
		}
        
		public static TableSchema.Table RisAseguradora{
            get { return DataService.GetSchema("RIS_Aseguradora","RisProvider"); }
		}
        
		public static TableSchema.Table RisCaracteristica{
            get { return DataService.GetSchema("RIS_Caracteristica","RisProvider"); }
		}
        
		public static TableSchema.Table RisComiteEtica{
            get { return DataService.GetSchema("RIS_ComiteEtica","RisProvider"); }
		}
        
		public static TableSchema.Table RisConcentimiento{
            get { return DataService.GetSchema("RIS_Concentimiento","RisProvider"); }
		}
        
		public static TableSchema.Table RisEnmienda{
            get { return DataService.GetSchema("RIS_Enmienda","RisProvider"); }
		}
        
		public static TableSchema.Table RisEnmiendaItemDesaprobado{
            get { return DataService.GetSchema("RIS_EnmiendaItemDesaprobado","RisProvider"); }
		}
        
		public static TableSchema.Table RisEntidad{
            get { return DataService.GetSchema("RIS_Entidad","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudio{
            get { return DataService.GetSchema("RIS_Estudio","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioAseguradora{
            get { return DataService.GetSchema("RIS_EstudioAseguradora","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioCaracteristica{
            get { return DataService.GetSchema("RIS_EstudioCaracteristica","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioComiteEtica{
            get { return DataService.GetSchema("RIS_EstudioComiteEtica","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioEntidad{
            get { return DataService.GetSchema("RIS_EstudioEntidad","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioFuenteRecoleccionDato{
            get { return DataService.GetSchema("RIS_EstudioFuenteRecoleccionDatos","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioInvestigador{
            get { return DataService.GetSchema("RIS_EstudioInvestigador","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioItemAprobado{
            get { return DataService.GetSchema("RIS_EstudioItemAprobado","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioItemDesaprobado{
            get { return DataService.GetSchema("RIS_EstudioItemDesaprobado","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioPoblacionVulnerable{
            get { return DataService.GetSchema("RIS_EstudioPoblacionVulnerable","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioSysEfectorMulticentrico{
            get { return DataService.GetSchema("RIS_EstudioSysEfectorMulticentrico","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioSysPaisMulticentrico{
            get { return DataService.GetSchema("RIS_EstudioSysPaisMulticentrico","RisProvider"); }
		}
        
		public static TableSchema.Table RisEstudioSysProvinciaMulticentrico{
            get { return DataService.GetSchema("RIS_EstudioSysProvinciaMulticentrico","RisProvider"); }
		}
        
		public static TableSchema.Table RisEvaluacionRechazada{
            get { return DataService.GetSchema("RIS_EvaluacionRechazada","RisProvider"); }
		}
        
		public static TableSchema.Table RisFuenteRecoleccionDato{
            get { return DataService.GetSchema("RIS_FuenteRecoleccionDatos","RisProvider"); }
		}
        
		public static TableSchema.Table RisFuncionEnElEquipo{
            get { return DataService.GetSchema("RIS_FuncionEnElEquipo","RisProvider"); }
		}
        
		public static TableSchema.Table RisInvestigadore{
            get { return DataService.GetSchema("RIS_Investigadores","RisProvider"); }
		}
        
		public static TableSchema.Table RisItemAprobado{
            get { return DataService.GetSchema("RIS_ItemAprobado","RisProvider"); }
		}
        
		public static TableSchema.Table RisItemDesaprobado{
            get { return DataService.GetSchema("RIS_ItemDesaprobado","RisProvider"); }
		}
        
		public static TableSchema.Table RisLugarRealizacion{
            get { return DataService.GetSchema("RIS_LugarRealizacion","RisProvider"); }
		}
        
		public static TableSchema.Table RisNotum{
            get { return DataService.GetSchema("RIS_Nota","RisProvider"); }
		}
        
		public static TableSchema.Table RisPoblacionVulnerable{
            get { return DataService.GetSchema("RIS_PoblacionVulnerable","RisProvider"); }
		}
        
		public static TableSchema.Table RisPresentacionInforme{
            get { return DataService.GetSchema("RIS_PresentacionInforme","RisProvider"); }
		}
        
		public static TableSchema.Table RisProfesion{
            get { return DataService.GetSchema("RIS_Profesion","RisProvider"); }
		}
        
		public static TableSchema.Table RisTipoDocumento{
            get { return DataService.GetSchema("RIS_TipoDocumento","RisProvider"); }
		}
        
		public static TableSchema.Table RisTipoTelefono{
            get { return DataService.GetSchema("RIS_TipoTelefono","RisProvider"); }
		}
        
		public static TableSchema.Table RisVigenciaPoliza{
            get { return DataService.GetSchema("RIS_VigenciaPoliza","RisProvider"); }
		}
        
		public static TableSchema.Table SisaReport{
            get { return DataService.GetSchema("SISA_Report","RisProvider"); }
		}
        
		public static TableSchema.Table SysAntecedente{
            get { return DataService.GetSchema("Sys_Antecedente","RisProvider"); }
		}
        
		public static TableSchema.Table SysAntecedenteEnfermedad{
            get { return DataService.GetSchema("Sys_AntecedenteEnfermedad","RisProvider"); }
		}
        
		public static TableSchema.Table SysBarrio{
            get { return DataService.GetSchema("Sys_Barrio","RisProvider"); }
		}
        
		public static TableSchema.Table SysCepSap{
            get { return DataService.GetSchema("Sys_CepSap","RisProvider"); }
		}
        
		public static TableSchema.Table SysCIE10{
            get { return DataService.GetSchema("Sys_CIE10","RisProvider"); }
		}
        
		public static TableSchema.Table SysCIE10Capitulo{
            get { return DataService.GetSchema("Sys_CIE10Capitulo","RisProvider"); }
		}
        
		public static TableSchema.Table SysDepartamento{
            get { return DataService.GetSchema("Sys_Departamento","RisProvider"); }
		}
        
		public static TableSchema.Table SysDireccione{
            get { return DataService.GetSchema("Sys_Direcciones","RisProvider"); }
		}
        
		public static TableSchema.Table SysEfector{
            get { return DataService.GetSchema("Sys_Efector","RisProvider"); }
		}
        
		public static TableSchema.Table SysEspecialidad{
            get { return DataService.GetSchema("Sys_Especialidad","RisProvider"); }
		}
        
		public static TableSchema.Table SysEspecialidad2{
            get { return DataService.GetSchema("Sys_Especialidad2","RisProvider"); }
		}
        
		public static TableSchema.Table SysEstablecimiento{
            get { return DataService.GetSchema("sys_Establecimiento","RisProvider"); }
		}
        
		public static TableSchema.Table SysEstado{
            get { return DataService.GetSchema("Sys_Estado","RisProvider"); }
		}
        
		public static TableSchema.Table SysEstadoCivil{
            get { return DataService.GetSchema("Sys_EstadoCivil","RisProvider"); }
		}
        
		public static TableSchema.Table SysHistoriaClinica{
            get { return DataService.GetSchema("Sys_HistoriaClinica","RisProvider"); }
		}
        
		public static TableSchema.Table SysIdioma{
            get { return DataService.GetSchema("Sys_Idioma","RisProvider"); }
		}
        
		public static TableSchema.Table SysLocalidad{
            get { return DataService.GetSchema("Sys_Localidad","RisProvider"); }
		}
        
		public static TableSchema.Table SysMedicamento{
            get { return DataService.GetSchema("Sys_Medicamento","RisProvider"); }
		}
        
		public static TableSchema.Table SysMedicamentoRubro{
            get { return DataService.GetSchema("Sys_MedicamentoRubro","RisProvider"); }
		}
        
		public static TableSchema.Table SysMenu{
            get { return DataService.GetSchema("Sys_Menu","RisProvider"); }
		}
        
		public static TableSchema.Table SysModulo{
            get { return DataService.GetSchema("Sys_Modulo","RisProvider"); }
		}
        
		public static TableSchema.Table SysMotivoNI{
            get { return DataService.GetSchema("Sys_MotivoNI","RisProvider"); }
		}
        
		public static TableSchema.Table SysMovimientoHistoriaClinica{
            get { return DataService.GetSchema("Sys_MovimientoHistoriaClinica","RisProvider"); }
		}
        
		public static TableSchema.Table SysMunicipio{
            get { return DataService.GetSchema("Sys_Municipio","RisProvider"); }
		}
        
		public static TableSchema.Table SysNivelInstruccion{
            get { return DataService.GetSchema("Sys_NivelInstruccion","RisProvider"); }
		}
        
		public static TableSchema.Table SysObraSocial{
            get { return DataService.GetSchema("Sys_ObraSocial","RisProvider"); }
		}
        
		public static TableSchema.Table SysOcupacion{
            get { return DataService.GetSchema("Sys_Ocupacion","RisProvider"); }
		}
        
		public static TableSchema.Table SysOrganismo{
            get { return DataService.GetSchema("Sys_Organismo","RisProvider"); }
		}
        
		public static TableSchema.Table SysPaciente{
            get { return DataService.GetSchema("Sys_Paciente","RisProvider"); }
		}
        
		public static TableSchema.Table SysPacienteAntecedentesFamiliare{
            get { return DataService.GetSchema("Sys_PacienteAntecedentesFamiliares","RisProvider"); }
		}
        
		public static TableSchema.Table SysPacienteCeliaco{
            get { return DataService.GetSchema("Sys_PacienteCeliaco","RisProvider"); }
		}
        
		public static TableSchema.Table SysPai{
            get { return DataService.GetSchema("Sys_Pais","RisProvider"); }
		}
        
		public static TableSchema.Table SysParentesco{
            get { return DataService.GetSchema("Sys_Parentesco","RisProvider"); }
		}
        
		public static TableSchema.Table SysParentescoTipo{
            get { return DataService.GetSchema("Sys_ParentescoTipo","RisProvider"); }
		}
        
		public static TableSchema.Table SysPerfil{
            get { return DataService.GetSchema("Sys_Perfil","RisProvider"); }
		}
        
		public static TableSchema.Table SysPermiso{
            get { return DataService.GetSchema("Sys_Permiso","RisProvider"); }
		}
        
		public static TableSchema.Table SysPoblacion{
            get { return DataService.GetSchema("Sys_Poblacion","RisProvider"); }
		}
        
		public static TableSchema.Table SysPoblacion1{
            get { return DataService.GetSchema("Sys_Poblacion1","RisProvider"); }
		}
        
		public static TableSchema.Table SysProfesion{
            get { return DataService.GetSchema("Sys_Profesion","RisProvider"); }
		}
        
		public static TableSchema.Table SysProfesional{
            get { return DataService.GetSchema("Sys_Profesional","RisProvider"); }
		}
        
		public static TableSchema.Table SysProvincium{
            get { return DataService.GetSchema("Sys_Provincia","RisProvider"); }
		}
        
		public static TableSchema.Table SysRelAntecedentePaciente{
            get { return DataService.GetSchema("Sys_RelAntecedentePaciente","RisProvider"); }
		}
        
		public static TableSchema.Table SysRelEspecialidadEfector{
            get { return DataService.GetSchema("Sys_RelEspecialidadEfector","RisProvider"); }
		}
        
		public static TableSchema.Table SysRelEstadoMotivoNI{
            get { return DataService.GetSchema("Sys_RelEstadoMotivoNI","RisProvider"); }
		}
        
		public static TableSchema.Table SysRelFormularioCobertura{
            get { return DataService.GetSchema("Sys_RelFormularioCobertura","RisProvider"); }
		}
        
		public static TableSchema.Table SysRelHistoriaClinicaEfector{
            get { return DataService.GetSchema("Sys_RelHistoriaClinicaEfector","RisProvider"); }
		}
        
		public static TableSchema.Table SysRelPacienteObraSocial{
            get { return DataService.GetSchema("Sys_RelPacienteObraSocial","RisProvider"); }
		}
        
		public static TableSchema.Table SysRelProfesionalEfector{
            get { return DataService.GetSchema("Sys_RelProfesionalEfector","RisProvider"); }
		}
        
		public static TableSchema.Table SysRelServicioEfector{
            get { return DataService.GetSchema("Sys_RelServicioEfector","RisProvider"); }
		}
        
		public static TableSchema.Table SysServicio{
            get { return DataService.GetSchema("Sys_Servicio","RisProvider"); }
		}
        
		public static TableSchema.Table SysSexo{
            get { return DataService.GetSchema("Sys_Sexo","RisProvider"); }
		}
        
		public static TableSchema.Table SysSituacionLaboral{
            get { return DataService.GetSchema("Sys_SituacionLaboral","RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoAntecedente{
            get { return DataService.GetSchema("Sys_TipoAntecedente","RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoCobertura{
            get { return DataService.GetSchema("Sys_TipoCobertura","RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoDocumento{
            get { return DataService.GetSchema("Sys_TipoDocumento","RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoEfector{
            get { return DataService.GetSchema("Sys_TipoEfector","RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoObraSocial{
            get { return DataService.GetSchema("Sys_TipoObraSocial","RisProvider"); }
		}
        
		public static TableSchema.Table SysTipoProfesional{
            get { return DataService.GetSchema("Sys_TipoProfesional","RisProvider"); }
		}
        
		public static TableSchema.Table SysUsuario{
            get { return DataService.GetSchema("Sys_Usuario","RisProvider"); }
		}
        
		public static TableSchema.Table SysZona{
            get { return DataService.GetSchema("Sys_Zona","RisProvider"); }
		}
        
		public static TableSchema.Table TabControl{
            get { return DataService.GetSchema("TAB_Control","RisProvider"); }
		}
        
		public static TableSchema.Table TabMedicamentoTabaquismo{
            get { return DataService.GetSchema("TAB_MedicamentoTabaquismo","RisProvider"); }
		}
        
		public static TableSchema.Table TabRelMedicamentoTab{
            get { return DataService.GetSchema("TAB_RelMedicamentoTab","RisProvider"); }
		}
        
		public static TableSchema.Table TamBiopsium{
            get { return DataService.GetSchema("TAM_Biopsia","RisProvider"); }
		}
        
		public static TableSchema.Table TamCalidadMuestra{
            get { return DataService.GetSchema("TAM_CalidadMuestra","RisProvider"); }
		}
        
		public static TableSchema.Table TamCelulasEscamosa{
            get { return DataService.GetSchema("TAM_CelulasEscamosas","RisProvider"); }
		}
        
		public static TableSchema.Table TamCelulasGlandulare{
            get { return DataService.GetSchema("TAM_CelulasGlandulares","RisProvider"); }
		}
        
		public static TableSchema.Table TamColposcopium{
            get { return DataService.GetSchema("TAM_Colposcopia","RisProvider"); }
		}
        
		public static TableSchema.Table TamDiagnostico{
            get { return DataService.GetSchema("TAM_Diagnostico","RisProvider"); }
		}
        
		public static TableSchema.Table TamEfectore{
            get { return DataService.GetSchema("TAM_Efectores","RisProvider"); }
		}
        
		public static TableSchema.Table TamEstadio{
            get { return DataService.GetSchema("TAM_Estadio","RisProvider"); }
		}
        
		public static TableSchema.Table TamHallazgosColposcopico{
            get { return DataService.GetSchema("TAM_HallazgosColposcopicos","RisProvider"); }
		}
        
		public static TableSchema.Table TamHpv{
            get { return DataService.GetSchema("TAM_Hpv","RisProvider"); }
		}
        
		public static TableSchema.Table TamHpvHP{
            get { return DataService.GetSchema("TAM_HpvHP","RisProvider"); }
		}
        
		public static TableSchema.Table TamLocalidade{
            get { return DataService.GetSchema("TAM_Localidades","RisProvider"); }
		}
        
		public static TableSchema.Table TamMetodoAnticonceptivo{
            get { return DataService.GetSchema("TAM_MetodoAnticonceptivo","RisProvider"); }
		}
        
		public static TableSchema.Table TamMicrorganismo{
            get { return DataService.GetSchema("TAM_Microrganismo","RisProvider"); }
		}
        
		public static TableSchema.Table TamObservacionPap{
            get { return DataService.GetSchema("TAM_ObservacionPap","RisProvider"); }
		}
        
		public static TableSchema.Table TamOtrosHallazgo{
            get { return DataService.GetSchema("TAM_OtrosHallazgos","RisProvider"); }
		}
        
		public static TableSchema.Table TamPap{
            get { return DataService.GetSchema("TAM_Pap","RisProvider"); }
		}
        
		public static TableSchema.Table TamPapHospitalProvincial{
            get { return DataService.GetSchema("TAM_PapHospitalProvincial","RisProvider"); }
		}
        
		public static TableSchema.Table TamPapHP{
            get { return DataService.GetSchema("TAM_PapHP","RisProvider"); }
		}
        
		public static TableSchema.Table TamProfesionale{
            get { return DataService.GetSchema("TAM_Profesionales","RisProvider"); }
		}
        
		public static TableSchema.Table TamRegistro{
            get { return DataService.GetSchema("TAM_Registro","RisProvider"); }
		}
        
		public static TableSchema.Table TamRelTipoMaterialBiopsium{
            get { return DataService.GetSchema("TAM_RelTipoMaterialBiopsia","RisProvider"); }
		}
        
		public static TableSchema.Table TamResultadoColpo{
            get { return DataService.GetSchema("TAM_ResultadoColpos","RisProvider"); }
		}
        
		public static TableSchema.Table TamResultadoHpv{
            get { return DataService.GetSchema("TAM_ResultadoHpv","RisProvider"); }
		}
        
		public static TableSchema.Table TamResultadoPap{
            get { return DataService.GetSchema("TAM_ResultadoPap","RisProvider"); }
		}
        
		public static TableSchema.Table TamTipoCirugium{
            get { return DataService.GetSchema("TAM_TipoCirugia","RisProvider"); }
		}
        
		public static TableSchema.Table TamTipoHpv{
            get { return DataService.GetSchema("TAM_TipoHpv","RisProvider"); }
		}
        
		public static TableSchema.Table TamTipoMaterialBiopsium{
            get { return DataService.GetSchema("TAM_TipoMaterialBiopsia","RisProvider"); }
		}
        
		public static TableSchema.Table TamTipoMuestra{
            get { return DataService.GetSchema("TAM_TipoMuestra","RisProvider"); }
		}
        
		public static TableSchema.Table TamTipoPapPrevio{
            get { return DataService.GetSchema("TAM_TipoPapPrevio","RisProvider"); }
		}
        
		public static TableSchema.Table TamTipoTratamiento{
            get { return DataService.GetSchema("TAM_TipoTratamiento","RisProvider"); }
		}
        
		public static TableSchema.Table TamTipoTratamientoPap{
            get { return DataService.GetSchema("TAM_TipoTratamientoPap","RisProvider"); }
		}
        
		public static TableSchema.Table TamTratamiento{
            get { return DataService.GetSchema("TAM_Tratamientos","RisProvider"); }
		}
        
		public static TableSchema.Table TmpEgreso{
            get { return DataService.GetSchema("TMP_Egresos","RisProvider"); }
		}
        
		public static TableSchema.Table TmpFacturasACerrar{
            get { return DataService.GetSchema("TMP_FacturasACerrar","RisProvider"); }
		}
        
		public static TableSchema.Table TstAfiliadosIOSE{
            get { return DataService.GetSchema("TST_AfiliadosIOSE","RisProvider"); }
		}
        
		public static TableSchema.Table TstAfiliadosISSN{
            get { return DataService.GetSchema("TST_AfiliadosISSN","RisProvider"); }
		}
        
		public static TableSchema.Table TstPaciente{
            get { return DataService.GetSchema("TST_Paciente","RisProvider"); }
		}
        
		public static TableSchema.Table TstProfe{
            get { return DataService.GetSchema("TST_Profe","RisProvider"); }
		}
        
		public static TableSchema.Table TupEfectoresHabilitado{
            get { return DataService.GetSchema("TUP_EfectoresHabilitados","RisProvider"); }
		}
        
		public static TableSchema.Table TupTurnosProtegido{
            get { return DataService.GetSchema("TUP_TurnosProtegidos","RisProvider"); }
		}
        
		public static TableSchema.Table Ubicacione{
            get { return DataService.GetSchema("Ubicaciones","RisProvider"); }
		}
        
		public static TableSchema.Table UbicacionesDato{
            get { return DataService.GetSchema("Ubicaciones_Datos","RisProvider"); }
		}
        
		public static TableSchema.Table UbicacionesSubtipo{
            get { return DataService.GetSchema("Ubicaciones_Subtipos","RisProvider"); }
		}
        
		public static TableSchema.Table UbicacionesTipo{
            get { return DataService.GetSchema("Ubicaciones_Tipos","RisProvider"); }
		}
        
		public static TableSchema.Table VgiAClinicosDet{
            get { return DataService.GetSchema("VGI_AClinicosDet","RisProvider"); }
		}
        
		public static TableSchema.Table VgiCInterconsultaItem{
            get { return DataService.GetSchema("VGI_CInterconsultaItems","RisProvider"); }
		}
        
		public static TableSchema.Table VgiCriterio{
            get { return DataService.GetSchema("vgi_Criterios","RisProvider"); }
		}
        
		public static TableSchema.Table VgiDato{
            get { return DataService.GetSchema("VGI_Datos","RisProvider"); }
		}
        
		public static TableSchema.Table VgiItem{
            get { return DataService.GetSchema("vgi_Items","RisProvider"); }
		}
        
		public static TableSchema.Table VgiItemsDato{
            get { return DataService.GetSchema("vgi_ItemsDatos","RisProvider"); }
		}
        
		public static TableSchema.Table ViewMujeresPap{
            get { return DataService.GetSchema("View_MujeresPaps","RisProvider"); }
		}
        
	
    }
    #endregion
    #region View Struct
    public partial struct Views 
    {
		
		public static string AprVwCondicionesVivienda = @"APR_VwCondicionesVivienda";
        
		public static string AprVwOtrosDato = @"APR_VwOtrosDatos";
        
		public static string AutAlerta = @"AUT_Alertas";
        
		public static string AutFechaMaximaHistoricoPMP = @"AUT_FechaMaximaHistoricoPMP";
        
		public static string ConCantidadSobreTurno = @"CON_CantidadSobreTurnos";
        
		public static string ConCantidadTipoTurnosEspecialidad = @"CON_CantidadTipoTurnosEspecialidad";
        
		public static string ConCantidadTurnosAusente = @"CON_CantidadTurnosAusentes";
        
		public static string ConCantidadTurnosBloqueado = @"CON_CantidadTurnosBloqueados";
        
		public static string ConCantidadTurnosCodificado = @"CON_CantidadTurnosCodificados";
        
		public static string ConCantidadTurnosDado = @"CON_CantidadTurnosDados";
        
		public static string ConCantidadTurnosDadosAnticipado = @"CON_CantidadTurnosDadosAnticipados";
        
		public static string ConCantidadTurnosDadosDium = @"CON_CantidadTurnosDadosDia";
        
		public static string ConCantidadTurnosEspecialidad = @"CON_CantidadTurnosEspecialidad";
        
		public static string ConCantidadTurnosGenerado = @"CON_CantidadTurnosGenerados";
        
		public static string ConCantidadTurnosPresente = @"CON_CantidadTurnosPresentes";
        
		public static string ConCantidadTurnosPrestacion = @"CON_CantidadTurnosPrestacion";
        
		public static string ConDiagPrincipalTurno = @"CON_DiagPrincipalTurnos";
        
		public static string ConLauraPacientesNutricion2012 = @"CON_laura_pacientesNutricion2012";
        
		public static string ConLauraPacientesNutricion2013 = @"CON_laura_pacientesNutricion2013";
        
		public static string ConLauraTurnosDadosAnticipadosMedicinaGeneral = @"CON_laura_turnosDadosAnticipadosMedicinaGeneral";
        
		public static string ConLauraTurnosGeneradosClinicaMedica = @"CON_laura_turnosGeneradosClinicaMedica";
        
		public static string ConSobreTurno = @"CON_SobreTurnos";
        
		public static string ConTurnoGrupoEtareo = @"Con_TurnoGrupoEtareo";
        
		public static string ConTurnoGrupoEtareoC2 = @"CON_TurnoGrupoEtareoC2";
        
		public static string ConTurnosAnticipadosAusente = @"CON_TurnosAnticipadosAusentes";
        
		public static string ConTurnosCantidadDemandaRechazada = @"CON_TurnosCantidadDemandaRechazada";
        
		public static string ConTurnosDelDiaConAsistencium = @"CON_TurnosDelDiaConAsistencia";
        
		public static string ConTurnosDelDiaSinAsistencium = @"CON_TurnosDelDiaSinAsistencia";
        
		public static string ConTurnosProgramadosConAsistencium = @"CON_TurnosProgramadosConAsistencia";
        
		public static string ConTurnosProgramadosSinAsistencium = @"CON_TurnosProgramadosSinAsistencia";
        
		public static string ConVistaAgenda = @"CON_VistaAgendas";
        
		public static string ConVwConsulta = @"CON_VwConsultas";
        
		public static string ConsultaInterconsulta = @"ConsultaInterconsultas";
        
		public static string FacListaOrdene = @"FAC_ListaOrdenes";
        
		public static string FacListaPaciente = @"FAC_ListaPacientes";
        
		public static string FacOrdene = @"FAC_Ordenes";
        
		public static string FacOrdenesDetalle = @"FAC_OrdenesDetalles";
        
		public static string FacPacientesConObraSocial = @"FAC_PacientesConObraSocial";
        
		public static string GuardiaGrupoEtareoC2 = @"GUARDIA_GrupoEtareoC2";
        
		public static string GuardiaUltimoTriage = @"Guardia_Ultimo_Triage";
        
		public static string HhhNomenclador = @"HHH_Nomenclador";
        
		public static string HhhObraSocial = @"HHH_ObraSocial";
        
		public static string HhhTipoNomenclador = @"HHH_TipoNomenclador";
        
		public static string HhhTipoPractica = @"HHH_TipoPractica";
        
		public static string LabConsultasxAño = @"LAB_ConsultasxAño";
        
		public static string LabImprimeResultado = @"LAB_ImprimeResultado";
        
		public static string PnCantidadEmb = @"PN_CantidadEmb";
        
		public static string PnCantidadNin = @"PN_CantidadNin";
        
		public static string PnCantidadOrdenesAfiliado = @"PN_CantidadOrdenesAfiliados";
        
		public static string PnCantidadPar = @"PN_CantidadPar";
        
		public static string PnCantidadTrazadorasAfiliado = @"PN_CantidadTrazadorasAfiliados";
        
		public static string PnListaOrdene = @"PN_ListaOrdenes";
        
		public static string RemClasificado = @"REM_Clasificados";
        
		public static string SsVwDepartamento = @"SS_VwDepartamentos";
        
		public static string SsVwEdad = @"SS_VwEdad";
        
		public static string SsVwEfectoresAgenda = @"SS_VwEfectoresAgendas";
        
		public static string SsVwEfectoresRecupero = @"SS_VwEfectoresRecupero";
        
		public static string SsVwEspecialidadesEfectore = @"SS_VwEspecialidadesEfectores";
        
		public static string SsVwLocalidad = @"SS_VwLocalidad";
        
		public static string SsVwZona = @"SS_VwZona";
        
		public static string SysPerfilEfector = @"SYS_PerfilEfector";
        
		public static string ViewRubrosMedicamento = @"View_RubrosMedicamentos";
        
		public static string VtaSmiAfiliadosCategoriaEdad = @"vta_SmiAfiliados_Categoria_Edad";
        
		public static string VwAspnetApplication = @"vw_aspnet_Applications";
        
		public static string VwAspnetMembershipUser = @"vw_aspnet_MembershipUsers";
        
		public static string VwAspnetProfile = @"vw_aspnet_Profiles";
        
		public static string VwAspnetRole = @"vw_aspnet_Roles";
        
		public static string VwAspnetUser = @"vw_aspnet_Users";
        
		public static string VwAspnetUsersInRole = @"vw_aspnet_UsersInRoles";
        
		public static string VwAspnetWebPartStatePath = @"vw_aspnet_WebPartState_Paths";
        
		public static string VwAspnetWebPartStateShared = @"vw_aspnet_WebPartState_Shared";
        
		public static string VwAspnetWebPartStateUser = @"vw_aspnet_WebPartState_User";
        
		public static string VwLabScreeningHojaTrabajo = @"vw_LAB_ScreeningHojaTrabajo";
        
    }
    #endregion
    
    #region Query Factories
	public static partial class DB
	{
        public static DataProvider _provider = DataService.Providers["RisProvider"];
        static ISubSonicRepository _repository;
        public static ISubSonicRepository Repository {
            get {
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
	
	public static string RisProvider = @"RisProvider";
    
}
#endregion