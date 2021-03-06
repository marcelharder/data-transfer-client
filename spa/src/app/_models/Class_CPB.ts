export interface Class_CPB {
    Id: number;
    PROCEDURE_ID: number;
    CROSS_CLAMP_TIME: number;
    PERFUSION_TIME: number;
    LOWEST_CORE_TEMP: number;
    CARDIOPLEGIA: string;
    CARDIOPLEGIA_TYPE: string;
    INFUSION_MODE_ANTE: string;
    INFUSION_MODE_RETRO: number;
    INFUSION_DOSE_INT: number;
    INFUSION_DOSE_CONT: number;
    CARDIOPLEGIA_TEMP_WARM: number;
    CARDIOPLEGIA_TEMP_COLD: number;
    IABP: string;
    IABP_OPTIONS: string;
    IABP_IND: string;
    PACING_HARV: number;
    PACING_ATRIAL: number;
    PACING_VENTRICULAR: number;
    CARDIOVERSION: number;
    VAD: string;
    LVAD: number;
    RVAD: number;
    BVAD: string;
    TAH: string;
    INOTROPES: number;
    Antiarrhythmics: number;
    SKIN_INCISION_START_TIME: number;
    SKIN_INCISION_STOP_TIME: number;
    opcab_attempt: string;
    cpb_used: string;
    a1: string;
    a2: string;
    a3: string;
    a4: string;
    v1: string;
    v2: string;
    v3: string;
    v4: string;
    aoOCCL: string;
    long_isch: number;
    cardiopl_timing: string;
    cardiopl_temp: string;
    cns_protect: string;
    cns_time_1: number;
    cns_time_2: number;
    cns_time_3: number;
    deep_hypo: string;
    deep_hypo_rcp: string;
    acp_circ: string;
    other_cns_protect: string;
    nonCMProtect: string;
    nonCMProtect_type: number;
    IABP_DATE: Date;
    myoplasty: string;
    cpb_start_hr: number;
    cpb_start_min: number;
    cpb_stop_hr: number;
    cpb_stop_min: number;
    clamp_start_hr: number;
    clamp_start_min: number;
    clamp_stop_hr: number;
    clamp_stop_min: number;
    other_cardiac_support: string;
    cardiac_support: string;
}