using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class Header
    {
        [Key]
        public int Id { get; set; }
        public bool bDone { get; set; }
        public bool bSent { get; set; }
        public int iRecordType { get; set; }
        public string typeA { get; set; }
        public string typeB { get; set; }
        public string fit_diary { get; set; }
        public string fitters_instructions { get; set; }
        public string fit_start { get; set; }
        public string fit_fin { get; set; }
        public string fitter_work { get; set; }
        public string parts_used { get; set; }
        public string claim_ref { get; set; }
        public string fitter_comments { get; set; }
        public string udi_cont { get; set; }
        public string sn_name { get; set; }
        public string uc_laname { get; set; }
        public string uc_name { get; set; }
        public string uc_add1 { get; set; }
        public string uc_add2 { get; set; }
        public string uc_add3 { get; set; }
        public string uc_add4 { get; set; }
        public string uc_postcode { get; set; }
        public string uc_h_phone { get; set; }
        public bool uc_goahead { get; set; }
        public string uc_inceden { get; set; }
        public string spare2 { get; set; }
        public double uc_excess { get; set; }
        public int bExcessCollected { get; set; }
        public int udi_tlight { get; set; }
        public int si_numitem { get; set; }
        public string udi_inst { get; set; }
        public int alarm_cont { get; set; }
        public int ladder_req { get; set; }
        public int height_res { get; set; }
        public int sand_cemen { get; set; }
        public int plaster { get; set; }
        public int doorbell { get; set; }
        public int genreq { get; set; }
        public int architreq { get; set; }
        public int acroreq { get; set; }
        public int acrosboy { get; set; }
        public string acc_text { get; set; }
        public int obs_wires { get; set; }
        public string obs_wires_text { get; set; }
        public int loose_brick { get; set; }
        public string loose_brick_text { get; set; }
        public int easy_park { get; set; }
        public int access_rear { get; set; }
        public string rep_text { get; set; }
        public string mop { get; set; }
        public string card_cheq { get; set; }
        public string expiry { get; set; }
        public int issue_no { get; set; }
        public string reason_excess_not_collected { get; set; }
        public string paych { get; set; }
        public string summ_text { get; set; }
        public string code_text { get; set; }
        public int imchup { get; set; }
        public string job_grade { get; set; }
        public string njs { get; set; }
        public int photo { get; set; }
        public int booked { get; set; }
        public string nsn { get; set; }
        public string udi_start { get; set; }
        public string udi_fin { get; set; }
        public bool si_done { get; set; }
        public string udi_date { get; set; }
        public string si_bday1 { get; set; }
        public string si_mpay { get; set; }
        public string si_cnum { get; set; }
        public string si_inum { get; set; }
        public string udi_jobtext { get; set; }
        public string udi_staff { get; set; }
        public string type { get; set; }
        public string sub_type { get; set; }
        public string old_date { get; set; }
        public string cover_instructions { get; set; }
        public string old_start { get; set; }
        public string old_finish { get; set; }
        public string add_comm { get; set; }
        public string udi_estrem { get; set; }
        public string r_fault { get; set; }
        public int r_excess { get; set; }
        public string rexcedit { get; set; }
        public int r_comp { get; set; }
        public string rno_hours { get; set; }
        public string r_work_txt { get; set; }
        public bool readditimage { get; set; }
        public string readdtxt { get; set; }
        public bool r_sigimage { get; set; }
        public string f_add_txt { get; set; }
        public string fmclrf { get; set; }
        public string fmdate { get; set; }
        public string funfincode { get; set; }
        public string funfinoth { get; set; }
        public string freuntxt { get; set; }
        public string fpartreq { get; set; }
        public bool fjobfin { get; set; }
        public string fname1 { get; set; }
        public string fname2 { get; set; }
        public bool fexcess { get; set; }
        public string fexcessoth { get; set; }
        public bool fmand { get; set; }
        public string fmandoth { get; set; }
        public string ftimearr { get; set; }
        public string ftimeleft { get; set; }
        public bool faddpaid { get; set; }
        public double faddmuch { get; set; }
        public string commtxt { get; set; }
        public string wkcartxt { get; set; }
        public string parttxt { get; set; }
        public bool faddimage { get; set; }
        public bool fmanimage { get; set; }
        public bool fsigimage { get; set; }
        public int bWorkInside { get; set; }
        public string inst_height { get; set; }
        public int bBothHands { get; set; }
        public string ground_surface { get; set; }
        public string type_of_equipment { get; set; }
        public string risks_and_dangers { get; set; }
        public string uc_desc { get; set; }
        public int work_at_height { get; set; }
        public int no_ladders { get; set; }
        public string funfinished_code { get; set; }
        public string freason_unfinished { get; set; }
        public string fparts_required { get; set; }
        public string ffitter_name1 { get; set; }
        public string ffitter_name2 { get; set; }
        public int fbexcess_paid { get; set; }
        public string freason_excess_not_paid { get; set; }
        public int fbmandate_signed { get; set; }
        public string freason_mandate_not_signed { get; set; }
        public string ftime_arrived { get; set; }
        public string ftime_left { get; set; }
        public int fbadditional_paid { get; set; }
        public string fhow_mutch_additional_paid { get; set; }
        public int bfitter_complete { get; set; }
        public int fitter_info_done { get; set; }
        public string fbunfinother { get; set; }
        public bool bcompletion_signed { get; set; }
        public bool bad_image_complete { get; set; }
        public string remedial_number { get; set; }
        public bool r_bsigned { get; set; }
        public string r_bcomp { get; set; }
        public string r_sign_date { get; set; }
        public string stimea { get; set; }
        public string f1_or_s2 { get; set; }
        public string f_sign_date { get; set; }
        public long distance { get; set; }
        public long duration { get; set; }
        public int no_of_photos { get; set; }
        public string bClosest { get; set; }
        public string Group { get; set; }
        public string bProcessed { get; set; }
        public int ind { get; set; }
        public string inevitable_damage { get; set; }
        public bool fbstockusagecomplete { get; set; }
        public string uc_h_phone2 { get; set; }
        public string uc_h_phone3 { get; set; }
        public bool bSecuring { get; set; }
        public int ins_board { get; set; }
        public int ins_lock { get; set; }
        public int ins_temp { get; set; }
        public int ins_perm { get; set; }
        public int int_num_of_locks { get; set; }
        public string int_type_of_lock { get; set; }
        public int parking_at_rear { get; set; }
        public int work_on_public_footpath { get; set; }
        public string add_long { get; set; }
        public bool b_mrk { get; set; }
        public bool bSurvey { get; set; }
        public int items_above_roof { get; set; }
        public bool added_to_otherrisks { get; set; }
        public bool bMSFJob { get; set; }
        public int securing_surveyor_required { get; set; }
        public string policy_number { get; set; }
        public bool photo_front_of_house { get; set; }
        public int asbestos_visible { get; set; }
        public string asvizex { get; set; }
        public string refmessage { get; set; }
        public string uspot_fitter { get; set; }
        public string uspot_trainee { get; set; }
        public string uspot_date { get; set; }
        public string uspot_customer { get; set; }
        public string uspot_postcode { get; set; }
        public string uspot_insuranceco { get; set; }
        public string uspot_branch { get; set; }
        public bool uspot_repair { get; set; }
        public bool uspot_repair_arrived { get; set; }
        public bool uspot_repair_setup { get; set; }
        public bool uspot_repair_ongoing { get; set; }
        public bool uspot_repair_completed { get; set; }
        public bool uspot_replace { get; set; }
        public bool uspot_replace_arrived { get; set; }
        public bool uspot_replace_setup { get; set; }
        public bool uspot_replace_unitmoved { get; set; }
        public bool uspot_replace_completed { get; set; }
        public bool uspot_rev_door { get; set; }
        public bool uspot_rev_window { get; set; }
        public bool uspot_rev_garagedoor { get; set; }
        public bool uspot_rev_glass { get; set; }
        public bool uspot_rev_locks { get; set; }
        public bool uspot_rev_other { get; set; }
        public bool uspot_revb_upvc { get; set; }
        public bool uspot_revb_ali { get; set; }
        public bool uspot_revb_timber { get; set; }
        public bool uspot_revb_other { get; set; }
        public int uspot_appearence { get; set; }
        public string doc_l_compliant_reason { get; set; }
        public int lintel_present { get; set; }
        public string lintel_present_text { get; set; }
        public int uspot_customersatisfaction { get; set; }
        public string uspot_customersatisfaction_improvementsOld { get; set; }
        public string uspot_otherobservationsOld { get; set; }
        public bool uspot_signed { get; set; }
        public string uspot_signeddate { get; set; }
        public bool bSpotCheck { get; set; }
        public bool uspot_replace_fit { get; set; }
        public int uspot_p1 { get; set; }
        public int uspot_p2 { get; set; }
        public int uspot_p3 { get; set; }
        public int uspot_p4 { get; set; }
        public string uspot_appearence_improvements { get; set; }
        public string uspot_qualityofworks_improvements { get; set; }
        public string uspot_customersatisfaction_improvements { get; set; }
        public string uspot_otherobservations { get; set; }
        public bool idampassword_entered { get; set; }
        public int fit_no_of_videos { get; set; }
        public int doc_l_compliant { get; set; }
        public int shop_front_work { get; set; }
        public int fitter_videos { get; set; }
        public bool is_halifax { get; set; }
        public string messagetoinsurer { get; set; }
        public string COD_Code { get; set; }
        public string COD_String { get; set; }
        public bool bDamTicked { get; set; }
        public bool bSSTicked { get; set; }
        public int SSRequired { get; set; }
        public string old_cover_instructions { get; set; }
        public string rcodchanged { get; set; }
        public bool bcodchanged { get; set; }
        public string goaheadstr { get; set; }
        public int b_subcontract { get; set; }
        public string subcontracttext { get; set; }
        public bool truecomm { get; set; }
        public bool truecommconf { get; set; }
        public string reason_not_booked_in { get; set; }
        public bool bSurveyRequiredOnSecuring { get; set; }
        public bool requiring_load_bearing_jacks { get; set; }
        public bool bSRFin { get; set; }
        public bool bMOPFin { get; set; }
        public bool bRepFin { get; set; }
        public bool bSumFin { get; set; }
        public bool bHazFin { get; set; }
        public bool bAllPictures { get; set; }
        public bool bSubFin { get; set; }
        public int total_upvc { get; set; }
        public int total_panels { get; set; }
        public int total_glass { get; set; }
        public int total_alum { get; set; }
        public int total_garage { get; set; }
        public int total_timber { get; set; }
        public int total_cons { get; set; }
        public int total_lock { get; set; }
        public int total_comp { get; set; }
        public int total_green { get; set; }
        public int total_bifold { get; set; }
        public int incomplete_upvc { get; set; }
        public int incomplete_panels { get; set; }
        public int incomplete_glass { get; set; }
        public int incomplete_alum { get; set; }
        public int incomplete_garage { get; set; }
        public int incomplete_timber { get; set; }
        public int incomplete_cons { get; set; }
        public int incomplete_lock { get; set; }
        public int incomplete_comp { get; set; }
        public int incomplete_green { get; set; }
        public int incomplete_bifold { get; set; }
        public int front_house_photos { get; set; }
        public string time_to_complete { get; set; }
        public int current_item_number { get; set; }
        public int survey_complete { get; set; }
        public string reason_not_complete { get; set; }
        public string add_phone_1 { get; set; }
        public string add_phone_2 { get; set; }
        public int no_of_fitters { get; set; }
        public string fname3 { get; set; }
        public string fname4 { get; set; }
        public string fname5 { get; set; }
        public string fname6 { get; set; }
        public string fname7 { get; set; }
        public string fname8 { get; set; }
        public int ownquote { get; set; }
        public int survey_on_fit { get; set; }
        public int i_spare1 { get; set; }
        public int i_spare2 { get; set; }
        public int i_spare3 { get; set; }
        public string s_spare1 { get; set; }
        public string s_spare2 { get; set; }
        public string s_spare3 { get; set; }
        public int new_ispare1 { get; set; }
        public int new_ispare2 { get; set; }
        public int new_ispare3 { get; set; }
        public int new_ispare4 { get; set; }
        public int new_ispare5 { get; set; }
        public int new_ispare6 { get; set; }
        public int new_ispare7 { get; set; }
        public int new_ispare8 { get; set; }
        public int new_ispare9 { get; set; }
        public int is_messagetoinsurer { get; set; }
        public string new_sspare1 { get; set; }
        public string new_sspare2 { get; set; }
        public string new_sspare3 { get; set; }
        public string new_sspare4 { get; set; }
        public string new_sspare5 { get; set; }
        public string new_sspare6 { get; set; }
        public string new_sspare7 { get; set; }
        public string new_sspare8 { get; set; }
        public string new_sspare9 { get; set; }
        public string new_sspare10 { get; set; }

        public bool bInfoSeen { get; set; }

        public int ss_bIsSecuritySurvey { get; set; }
        public int ss_bIsComplete { get; set; }
        public string ss_nowindows { get; set; }
        public string ss_nodoors { get; set; }
        public string ss_gencondition { get; set; }
        public string ss_gencondition_other { get; set; }
        public string ss_matwindows { get; set; }
        public string ss_matwindows_other { get; set; }
        public string ss_matdoors { get; set; }
        public string ss_matdoors_other { get; set; }
        public string ss_lockwindows { get; set; }
        public string ss_lockwindows_other { get; set; }
        public string ss_lockdoors { get; set; }
        public string ss_lockdoors_other { get; set; }
        public int ss_add_window_security { get; set; }
        public string ss_location_windows_other { get; set; }
        public string ss_secwindows_other { get; set; }
        public int ss_add_door_security { get; set; }
        public string ss_location_doors_other { get; set; }
        public string ss_secdoors_other { get; set; }
        public string ss_time_required { get; set; }

        public int ss_no_of_photos { get; set; }
        public string door_type { get; set; }
        public string model_type { get; set; }
        public string unique_serial { get; set; }
        public string door_size { get; set; }
        public string door_manufacturer { get; set; }
        public string powerered_operator_type { get; set; }
        public string operator_manufacturer { get; set; }
        public string site_address { get; set; }
        public string decleration_by { get; set; }
        public string on_behalf_of_person { get; set; }
        public string on_behalf_of_company { get; set; }
        public string decleration_received_by { get; set; }
        public string date { get; set; }
        public string print_name { get; set; }
        public string date_cust { get; set; }
        public int i_signed { get; set; }
        public int i_signed_cust { get; set; }

        public int directive_complete { get; set; }

        public string branch { get; set; }
        public string name { get; set; }
        public string job { get; set; }
        public string name1 { get; set; }
        public int safety_boots_worn1 { get; set; }
        public int safety_gloves_worn1 { get; set; }
        public int safety_googles_worn1 { get; set; }
        public int safety_helmet_worn1 { get; set; }
        public int wristguards_worn1 { get; set; }
        public int uniform_worn_complete1 { get; set; }
        public int id_card_available1 { get; set; }
        public string name2 { get; set; }
        public int safety_boots_worn2 { get; set; }
        public int safety_gloves_worn2 { get; set; }
        public int safety_googles_worn2 { get; set; }
        public int safety_helmet_worn2 { get; set; }
        public int wristguards_worn2 { get; set; }
        public int uniform_worn_complete2 { get; set; }
        public int id_card_available2 { get; set; }
        public int chemicals_stored_correctly { get; set; }
        public int are_sheets_available { get; set; }
        public int area_above_been_checked { get; set; }
        public int obstructions_checked { get; set; }
        public int lintel_ok { get; set; }
        public int ladders_secure { get; set; }
        public int safe_work_at_height { get; set; }
        public int condition_of_ladders { get; set; }
        public int tools_set_out_safely { get; set; }
        public int fire_extinguisher_on_van { get; set; }
        public int first_aid_kit_on_van { get; set; }
        public int electrical_equipment_tested { get; set; }
        public string safety_boots_worn1_s { get; set; }
        public string safety_gloves_worn1_s { get; set; }
        public string safety_googles_worn1_s { get; set; }
        public string safety_helmet_worn1_s { get; set; }
        public string wristguards_worn1_s { get; set; }
        public string uniform_worn_complete1_s { get; set; }
        public string id_card_available1_s { get; set; }
        public string safety_boots_worn2_s { get; set; }
        public string safety_gloves_worn2_s { get; set; }
        public string safety_googles_worn2_s { get; set; }
        public string safety_helmet_worn2_s { get; set; }
        public string wristguards_worn2_s { get; set; }
        public string uniform_worn_complete2_s { get; set; }
        public string id_card_available2_s { get; set; }
        public string chemicals_stored_correctly_s { get; set; }
        public string are_sheets_available_s { get; set; }
        public string area_above_been_checked_s { get; set; }
        public string obstructions_checked_s { get; set; }
        public string lintel_ok_s { get; set; }
        public string ladders_secure_s { get; set; }
        public string safe_work_at_height_s { get; set; }
        public string condition_of_ladders_s { get; set; }
        public string tools_set_out_safely_s { get; set; }
        public string fire_extinguisher_on_van_s { get; set; }
        public string first_aid_kit_on_van_s { get; set; }
        public string electrical_equipment_tested_s { get; set; }
        public string comments { get; set; }
        public int uspot_qualityofworks { get; set; }
        public int current_summary_num { get; set; }

        public int uspot_replacement { get; set; }

        public int garage_door_motor { get; set; }

        public int isTowerScaff { get; set; }

        Header() { }
        Header(HeaderDTO tItem) =>
        (
 bDone,
 bSent,
 iRecordType,
 typeA,
 typeB,
 fit_diary,
 fitters_instructions,
 fit_start,
 fit_fin,
 fitter_work,
 parts_used,
 claim_ref,
 fitter_comments,
 udi_cont,
 sn_name,
 uc_laname,
 uc_name,
 uc_add1,
 uc_add2,
 uc_add3,
 uc_add4,
 uc_postcode,
 uc_h_phone,
 uc_goahead,
 uc_inceden,
 spare2,
 uc_excess,
 bExcessCollected,
 udi_tlight,
 si_numitem,
 udi_inst,
 alarm_cont,
 ladder_req,
 height_res,
 sand_cemen,
 plaster,
 doorbell,
 genreq,
 architreq,
 acroreq,
 acrosboy,
 acc_text,
 obs_wires,
 obs_wires_text,
 loose_brick,
 loose_brick_text,
 easy_park,
 access_rear,
 rep_text,
 mop,
 card_cheq,
 expiry,
 issue_no,
 reason_excess_not_collected,
 paych,
 summ_text,
 code_text,
 imchup,
 job_grade,
 njs,
 photo,
 booked,
 nsn,
 udi_start,
 udi_fin,
 si_done,
 udi_date,
 si_bday1,
 si_mpay,
 si_cnum,
 si_inum,
 udi_jobtext,
 udi_staff,
 type,
 sub_type,
 old_date,
 cover_instructions,
 old_start,
 old_finish,
 add_comm,
 udi_estrem,
 r_fault,
 r_excess,
 rexcedit,
 r_comp,
 rno_hours,
 r_work_txt,
 readditimage,
 readdtxt,
 r_sigimage,
 f_add_txt,
 fmclrf,
 fmdate,
 funfincode,
 funfinoth,
 freuntxt,
 fpartreq,
 fjobfin,
 fname1,
 fname2,
 fexcess,
 fexcessoth,
 fmand,
 fmandoth,
 ftimearr,
 ftimeleft,
 faddpaid,
 faddmuch,
 commtxt,
 wkcartxt,
 parttxt,
 faddimage,
 fmanimage,
 fsigimage,
 bWorkInside,
 inst_height,
 bBothHands,
 ground_surface,
 type_of_equipment,
 risks_and_dangers,
 uc_desc,
 work_at_height,
 no_ladders,
 funfinished_code,
 freason_unfinished,
 fparts_required,
 ffitter_name1,
 ffitter_name2,
 fbexcess_paid,
 freason_excess_not_paid,
 fbmandate_signed,
 freason_mandate_not_signed,
 ftime_arrived,
 ftime_left,
 fbadditional_paid,
 fhow_mutch_additional_paid,
 bfitter_complete,
 fitter_info_done,
 fbunfinother,
 bcompletion_signed,
 bad_image_complete,
 remedial_number,
 r_bsigned,
 r_bcomp,
 r_sign_date,
 stimea,
 f1_or_s2,
 f_sign_date,
 distance,
 duration,
 no_of_photos,
 bClosest,
 Group,
 bProcessed,
 ind,
 inevitable_damage,
 fbstockusagecomplete,
 uc_h_phone2,
 uc_h_phone3,
 bSecuring,
 ins_board,
 ins_lock,
 ins_temp,
 ins_perm,
 int_num_of_locks,
 int_type_of_lock,
 parking_at_rear,
 work_on_public_footpath,
 add_long,
 b_mrk,
 bSurvey,
 items_above_roof,
 added_to_otherrisks,
 bMSFJob,
 securing_surveyor_required,
 policy_number,
 photo_front_of_house,
 asbestos_visible,
 asvizex,
 refmessage,
 uspot_fitter,
 uspot_trainee,
 uspot_date,
 uspot_customer,
 uspot_postcode,
 uspot_insuranceco,
 uspot_branch,
 uspot_repair,
 uspot_repair_arrived,
 uspot_repair_setup,
 uspot_repair_ongoing,
 uspot_repair_completed,
 uspot_replace,
 uspot_replace_arrived,
 uspot_replace_setup,
 uspot_replace_unitmoved,
 uspot_replace_completed,
 uspot_rev_door,
 uspot_rev_window,
 uspot_rev_garagedoor,
 uspot_rev_glass,
 uspot_rev_locks,
 uspot_rev_other,
 uspot_revb_upvc,
 uspot_revb_ali,
 uspot_revb_timber,
 uspot_revb_other,
 uspot_appearence,
 doc_l_compliant_reason,
 lintel_present,
 lintel_present_text,
 uspot_customersatisfaction,
 uspot_customersatisfaction_improvementsOld,
 uspot_otherobservationsOld,
 uspot_signed,
 uspot_signeddate,
 bSpotCheck,
 uspot_replace_fit,
 uspot_p1,
 uspot_p2,
 uspot_p3,
 uspot_p4,
 uspot_appearence_improvements,
 uspot_qualityofworks_improvements,
 uspot_customersatisfaction_improvements,
 uspot_otherobservations,
 idampassword_entered,
 fit_no_of_videos,
 doc_l_compliant,
 shop_front_work,
 fitter_videos,
 is_halifax,
 messagetoinsurer,
 COD_Code,
 COD_String,
 bDamTicked,
 bSSTicked,
 SSRequired,
 old_cover_instructions,
 rcodchanged,
 bcodchanged,
 goaheadstr,
 b_subcontract,
 subcontracttext,
 truecomm,
 truecommconf,
 reason_not_booked_in,
 bSurveyRequiredOnSecuring,
 requiring_load_bearing_jacks,
 bSRFin,
 bMOPFin,
 bRepFin,
 bSumFin,
 bHazFin,
 bAllPictures,
 bSubFin,
 total_upvc,
 total_panels,
 total_glass,
 total_alum,
 total_garage,
 total_timber,
 total_cons,
 total_lock,
 total_comp,
 total_green,
 total_bifold,
 incomplete_upvc,
 incomplete_panels,
 incomplete_glass,
 incomplete_alum,
 incomplete_garage,
 incomplete_timber,
 incomplete_cons,
 incomplete_lock,
 incomplete_comp,
 incomplete_green,
 incomplete_bifold,
 front_house_photos,
 time_to_complete,
 current_item_number,
 survey_complete,
 reason_not_complete,
 add_phone_1,
 add_phone_2,
 no_of_fitters,
 fname3,
 fname4,
 fname5,
 fname6,
 fname7,
 fname8,
 ownquote,
 survey_on_fit,
 i_spare1,
 i_spare2,
 i_spare3,
 s_spare1,
 s_spare2,
 s_spare3,
 new_ispare1,
 new_ispare2,
 new_ispare3,
 new_ispare4,
 new_ispare5,
 new_ispare6,
 new_ispare7,
 new_ispare8,
 new_ispare9,
 is_messagetoinsurer,
 new_sspare1,
 new_sspare2,
 new_sspare3,
 new_sspare4,
 new_sspare5,
 new_sspare6,
 new_sspare7,
 new_sspare8,
 new_sspare9,
 new_sspare10,
 bInfoSeen,
 ss_bIsSecuritySurvey,
 ss_bIsComplete,
 ss_nowindows,
 ss_nodoors,
 ss_gencondition,
 ss_gencondition_other,
 ss_matwindows,
 ss_matwindows_other,
 ss_matdoors,
 ss_matdoors_other,
 ss_lockwindows,
 ss_lockwindows_other,
 ss_lockdoors,
 ss_lockdoors_other,
 ss_add_window_security,
 ss_location_windows_other,
 ss_secwindows_other,
 ss_add_door_security,
 ss_location_doors_other,
 ss_secdoors_other,
 ss_time_required,
 ss_no_of_photos,
 door_type,
 model_type,
 unique_serial,
 door_size,
 door_manufacturer,
 powerered_operator_type,
 operator_manufacturer,
 site_address,
 decleration_by,
 on_behalf_of_person,
 on_behalf_of_company,
 decleration_received_by,
 date,
 print_name,
 date_cust,
 i_signed,
 i_signed_cust,
 directive_complete,
 branch,
 name,
 job,
 name1,
 safety_boots_worn1,
 safety_gloves_worn1,
 safety_googles_worn1,
 safety_helmet_worn1,
 wristguards_worn1,
 uniform_worn_complete1,
 id_card_available1,
 name2,
 safety_boots_worn2,
 safety_gloves_worn2,
 safety_googles_worn2,
 safety_helmet_worn2,
 wristguards_worn2,
 uniform_worn_complete2,
 id_card_available2,
 chemicals_stored_correctly,
 are_sheets_available,
 area_above_been_checked,
 obstructions_checked,
 lintel_ok,
 ladders_secure,
 safe_work_at_height,
 condition_of_ladders,
 tools_set_out_safely,
 fire_extinguisher_on_van,
 first_aid_kit_on_van,
 electrical_equipment_tested,
 safety_boots_worn1_s,
 safety_gloves_worn1_s,
 safety_googles_worn1_s,
 safety_helmet_worn1_s,
 wristguards_worn1_s,
 uniform_worn_complete1_s,
 id_card_available1_s,
 safety_boots_worn2_s,
 safety_gloves_worn2_s,
 safety_googles_worn2_s,
 safety_helmet_worn2_s,
 wristguards_worn2_s,
 uniform_worn_complete2_s,
 id_card_available2_s,
 chemicals_stored_correctly_s,
 are_sheets_available_s,
 area_above_been_checked_s,
 obstructions_checked_s,
 lintel_ok_s,
 ladders_secure_s,
 safe_work_at_height_s,
 condition_of_ladders_s,
 tools_set_out_safely_s,
 fire_extinguisher_on_van_s,
 first_aid_kit_on_van_s,
 electrical_equipment_tested_s,
 comments,
 uspot_qualityofworks,
 current_summary_num,
 uspot_replacement,
 garage_door_motor,
 isTowerScaff) =
            (
tItem.bDone,
tItem.bSent,
tItem.iRecordType,
tItem.typeA,
tItem.typeB,
tItem.fit_diary,
tItem.fitters_instructions,
tItem.fit_start,
tItem.fit_fin,
tItem.fitter_work,
tItem.parts_used,
tItem.claim_ref,
tItem.fitter_comments,
tItem.udi_cont,
tItem.sn_name,
tItem.uc_laname,
tItem.uc_name,
tItem.uc_add1,
tItem.uc_add2,
tItem.uc_add3,
tItem.uc_add4,
tItem.uc_postcode,
tItem.uc_h_phone,
tItem.uc_goahead,
tItem.uc_inceden,
tItem.spare2,
tItem.uc_excess,
tItem.bExcessCollected,
tItem.udi_tlight,
tItem.si_numitem,
tItem.udi_inst,
tItem.alarm_cont,
tItem.ladder_req,
tItem.height_res,
tItem.sand_cemen,
tItem.plaster,
tItem.doorbell,
tItem.genreq,
tItem.architreq,
tItem.acroreq,
tItem.acrosboy,
tItem.acc_text,
tItem.obs_wires,
tItem.obs_wires_text,
tItem.loose_brick,
tItem.loose_brick_text,
tItem.easy_park,
tItem.access_rear,
tItem.rep_text,
tItem.mop,
tItem.card_cheq,
tItem.expiry,
tItem.issue_no,
tItem.reason_excess_not_collected,
tItem.paych,
tItem.summ_text,
tItem.code_text,
tItem.imchup,
tItem.job_grade,
tItem.njs,
tItem.photo,
tItem.booked,
tItem.nsn,
tItem.udi_start,
tItem.udi_fin,
tItem.si_done,
tItem.udi_date,
tItem.si_bday1,
tItem.si_mpay,
tItem.si_cnum,
tItem.si_inum,
tItem.udi_jobtext,
tItem.udi_staff,
tItem.type,
tItem.sub_type,
tItem.old_date,
tItem.cover_instructions,
tItem.old_start,
tItem.old_finish,
tItem.add_comm,
tItem.udi_estrem,
tItem.r_fault,
tItem.r_excess,
tItem.rexcedit,
tItem.r_comp,
tItem.rno_hours,
tItem.r_work_txt,
tItem.readditimage,
tItem.readdtxt,
tItem.r_sigimage,
tItem.f_add_txt,
tItem.fmclrf,
tItem.fmdate,
tItem.funfincode,
tItem.funfinoth,
tItem.freuntxt,
tItem.fpartreq,
tItem.fjobfin,
tItem.fname1,
tItem.fname2,
tItem.fexcess,
tItem.fexcessoth,
tItem.fmand,
tItem.fmandoth,
tItem.ftimearr,
tItem.ftimeleft,
tItem.faddpaid,
tItem.faddmuch,
tItem.commtxt,
tItem.wkcartxt,
tItem.parttxt,
tItem.faddimage,
tItem.fmanimage,
tItem.fsigimage,
tItem.bWorkInside,
tItem.inst_height,
tItem.bBothHands,
tItem.ground_surface,
tItem.type_of_equipment,
tItem.risks_and_dangers,
tItem.uc_desc,
tItem.work_at_height,
tItem.no_ladders,
tItem.funfinished_code,
tItem.freason_unfinished,
tItem.fparts_required,
tItem.ffitter_name1,
tItem.ffitter_name2,
tItem.fbexcess_paid,
tItem.freason_excess_not_paid,
tItem.fbmandate_signed,
tItem.freason_mandate_not_signed,
tItem.ftime_arrived,
tItem.ftime_left,
tItem.fbadditional_paid,
tItem.fhow_mutch_additional_paid,
tItem.bfitter_complete,
tItem.fitter_info_done,
tItem.fbunfinother,
tItem.bcompletion_signed,
tItem.bad_image_complete,
tItem.remedial_number,
tItem.r_bsigned,
tItem.r_bcomp,
tItem.r_sign_date,
tItem.stimea,
tItem.f1_or_s2,
tItem.f_sign_date,
tItem.distance,
tItem.duration,
tItem.no_of_photos,
tItem.bClosest,
tItem.Group,
tItem.bProcessed,
tItem.ind,
tItem.inevitable_damage,
tItem.fbstockusagecomplete,
tItem.uc_h_phone2,
tItem.uc_h_phone3,
tItem.bSecuring,
tItem.ins_board,
tItem.ins_lock,
tItem.ins_temp,
tItem.ins_perm,
tItem.int_num_of_locks,
tItem.int_type_of_lock,
tItem.parking_at_rear,
tItem.work_on_public_footpath,
tItem.add_long,
tItem.b_mrk,
tItem.bSurvey,
tItem.items_above_roof,
tItem.added_to_otherrisks,
tItem.bMSFJob,
tItem.securing_surveyor_required,
tItem.policy_number,
tItem.photo_front_of_house,
tItem.asbestos_visible,
tItem.asvizex,
tItem.refmessage,
tItem.uspot_fitter,
tItem.uspot_trainee,
tItem.uspot_date,
tItem.uspot_customer,
tItem.uspot_postcode,
tItem.uspot_insuranceco,
tItem.uspot_branch,
tItem.uspot_repair,
tItem.uspot_repair_arrived,
tItem.uspot_repair_setup,
tItem.uspot_repair_ongoing,
tItem.uspot_repair_completed,
tItem.uspot_replace,
tItem.uspot_replace_arrived,
tItem.uspot_replace_setup,
tItem.uspot_replace_unitmoved,
tItem.uspot_replace_completed,
tItem.uspot_rev_door,
tItem.uspot_rev_window,
tItem.uspot_rev_garagedoor,
tItem.uspot_rev_glass,
tItem.uspot_rev_locks,
tItem.uspot_rev_other,
tItem.uspot_revb_upvc,
tItem.uspot_revb_ali,
tItem.uspot_revb_timber,
tItem.uspot_revb_other,
tItem.uspot_appearence,
tItem.doc_l_compliant_reason,
tItem.lintel_present,
tItem.lintel_present_text,
tItem.uspot_customersatisfaction,
tItem.uspot_customersatisfaction_improvementsOld,
tItem.uspot_otherobservationsOld,
tItem.uspot_signed,
tItem.uspot_signeddate,
tItem.bSpotCheck,
tItem.uspot_replace_fit,
tItem.uspot_p1,
tItem.uspot_p2,
tItem.uspot_p3,
tItem.uspot_p4,
tItem.uspot_appearence_improvements,
tItem.uspot_qualityofworks_improvements,
tItem.uspot_customersatisfaction_improvements,
tItem.uspot_otherobservations,
tItem.idampassword_entered,
tItem.fit_no_of_videos,
tItem.doc_l_compliant,
tItem.shop_front_work,
tItem.fitter_videos,
tItem.is_halifax,
tItem.messagetoinsurer,
tItem.COD_Code,
tItem.COD_String,
tItem.bDamTicked,
tItem.bSSTicked,
tItem.SSRequired,
tItem.old_cover_instructions,
tItem.rcodchanged,
tItem.bcodchanged,
tItem.goaheadstr,
tItem.b_subcontract,
tItem.subcontracttext,
tItem.truecomm,
tItem.truecommconf,
tItem.reason_not_booked_in,
tItem.bSurveyRequiredOnSecuring,
tItem.requiring_load_bearing_jacks,
tItem.bSRFin,
tItem.bMOPFin,
tItem.bRepFin,
tItem.bSumFin,
tItem.bHazFin,
tItem.bAllPictures,
tItem.bSubFin,
tItem.total_upvc,
tItem.total_panels,
tItem.total_glass,
tItem.total_alum,
tItem.total_garage,
tItem.total_timber,
tItem.total_cons,
tItem.total_lock,
tItem.total_comp,
tItem.total_green,
tItem.total_bifold,
tItem.incomplete_upvc,
tItem.incomplete_panels,
tItem.incomplete_glass,
tItem.incomplete_alum,
tItem.incomplete_garage,
tItem.incomplete_timber,
tItem.incomplete_cons,
tItem.incomplete_lock,
tItem.incomplete_comp,
tItem.incomplete_green,
tItem.incomplete_bifold,
tItem.front_house_photos,
tItem.time_to_complete,
tItem.current_item_number,
tItem.survey_complete,
tItem.reason_not_complete,
tItem.add_phone_1,
tItem.add_phone_2,
tItem.no_of_fitters,
tItem.fname3,
tItem.fname4,
tItem.fname5,
tItem.fname6,
tItem.fname7,
tItem.fname8,
tItem.ownquote,
tItem.survey_on_fit,
tItem.i_spare1,
tItem.i_spare2,
tItem.i_spare3,
tItem.s_spare1,
tItem.s_spare2,
tItem.s_spare3,
tItem.new_ispare1,
tItem.new_ispare2,
tItem.new_ispare3,
tItem.new_ispare4,
tItem.new_ispare5,
tItem.new_ispare6,
tItem.new_ispare7,
tItem.new_ispare8,
tItem.new_ispare9,
tItem.is_messagetoinsurer,
tItem.new_sspare1,
tItem.new_sspare2,
tItem.new_sspare3,
tItem.new_sspare4,
tItem.new_sspare5,
tItem.new_sspare6,
tItem.new_sspare7,
tItem.new_sspare8,
tItem.new_sspare9,
tItem.new_sspare10,
tItem.bInfoSeen,
tItem.ss_bIsSecuritySurvey,
tItem.ss_bIsComplete,
tItem.ss_nowindows,
tItem.ss_nodoors,
tItem.ss_gencondition,
tItem.ss_gencondition_other,
tItem.ss_matwindows,
tItem.ss_matwindows_other,
tItem.ss_matdoors,
tItem.ss_matdoors_other,
tItem.ss_lockwindows,
tItem.ss_lockwindows_other,
tItem.ss_lockdoors,
tItem.ss_lockdoors_other,
tItem.ss_add_window_security,
tItem.ss_location_windows_other,
tItem.ss_secwindows_other,
tItem.ss_add_door_security,
tItem.ss_location_doors_other,
tItem.ss_secdoors_other,
tItem.ss_time_required,
tItem.ss_no_of_photos,
tItem.door_type,
tItem.model_type,
tItem.unique_serial,
tItem.door_size,
tItem.door_manufacturer,
tItem.powerered_operator_type,
tItem.operator_manufacturer,
tItem.site_address,
tItem.decleration_by,
tItem.on_behalf_of_person,
tItem.on_behalf_of_company,
tItem.decleration_received_by,
tItem.date,
tItem.print_name,
tItem.date_cust,
tItem.i_signed,
tItem.i_signed_cust,
tItem.directive_complete,
tItem.branch,
tItem.name,
tItem.job,
tItem.name1,
tItem.safety_boots_worn1,
tItem.safety_gloves_worn1,
tItem.safety_googles_worn1,
tItem.safety_helmet_worn1,
tItem.wristguards_worn1,
tItem.uniform_worn_complete1,
tItem.id_card_available1,
tItem.name2,
tItem.safety_boots_worn2,
tItem.safety_gloves_worn2,
tItem.safety_googles_worn2,
tItem.safety_helmet_worn2,
tItem.wristguards_worn2,
tItem.uniform_worn_complete2,
tItem.id_card_available2,
tItem.chemicals_stored_correctly,
tItem.are_sheets_available,
tItem.area_above_been_checked,
tItem.obstructions_checked,
tItem.lintel_ok,
tItem.ladders_secure,
tItem.safe_work_at_height,
tItem.condition_of_ladders,
tItem.tools_set_out_safely,
tItem.fire_extinguisher_on_van,
tItem.first_aid_kit_on_van,
tItem.electrical_equipment_tested,
tItem.safety_boots_worn1_s,
tItem.safety_gloves_worn1_s,
tItem.safety_googles_worn1_s,
tItem.safety_helmet_worn1_s,
tItem.wristguards_worn1_s,
tItem.uniform_worn_complete1_s,
tItem.id_card_available1_s,
tItem.safety_boots_worn2_s,
tItem.safety_gloves_worn2_s,
tItem.safety_googles_worn2_s,
tItem.safety_helmet_worn2_s,
tItem.wristguards_worn2_s,
tItem.uniform_worn_complete2_s,
tItem.id_card_available2_s,
tItem.chemicals_stored_correctly_s,
tItem.are_sheets_available_s,
tItem.area_above_been_checked_s,
tItem.obstructions_checked_s,
tItem.lintel_ok_s,
tItem.ladders_secure_s,
tItem.safe_work_at_height_s,
tItem.condition_of_ladders_s,
tItem.tools_set_out_safely_s,
tItem.fire_extinguisher_on_van_s,
tItem.first_aid_kit_on_van_s,
tItem.electrical_equipment_tested_s,
tItem.comments,
tItem.uspot_qualityofworks,
tItem.current_summary_num,
tItem.uspot_replacement,
tItem.garage_door_motor,
tItem.isTowerScaff);

    }





    public class HeaderDTO
    {
        public int RecID { get; set; }
        public bool bDone { get; set; }
        public bool bSent { get; set; }
        public int iRecordType { get; set; }
        public string typeA { get; set; }
        public string typeB { get; set; }
        public string fit_diary { get; set; }
        public string fitters_instructions { get; set; }
        public string fit_start { get; set; }
        public string fit_fin { get; set; }
        public string fitter_work { get; set; }
        public string parts_used { get; set; }
        public string claim_ref { get; set; }
        public string fitter_comments { get; set; }
        public string udi_cont { get; set; }
        public string sn_name { get; set; }
        public string uc_laname { get; set; }
        public string uc_name { get; set; }
        public string uc_add1 { get; set; }
        public string uc_add2 { get; set; }
        public string uc_add3 { get; set; }
        public string uc_add4 { get; set; }
        public string uc_postcode { get; set; }
        public string uc_h_phone { get; set; }
        public bool uc_goahead { get; set; }
        public string uc_inceden { get; set; }
        public string spare2 { get; set; }
        public double uc_excess { get; set; }
        public int bExcessCollected { get; set; }
        public int udi_tlight { get; set; }
        public int si_numitem { get; set; }
        public string udi_inst { get; set; }
        public int alarm_cont { get; set; }
        public int ladder_req { get; set; }
        public int height_res { get; set; }
        public int sand_cemen { get; set; }
        public int plaster { get; set; }
        public int doorbell { get; set; }
        public int genreq { get; set; }
        public int architreq { get; set; }
        public int acroreq { get; set; }
        public int acrosboy { get; set; }
        public string acc_text { get; set; }
        public int obs_wires { get; set; }
        public string obs_wires_text { get; set; }
        public int loose_brick { get; set; }
        public string loose_brick_text { get; set; }
        public int easy_park { get; set; }
        public int access_rear { get; set; }
        public string rep_text { get; set; }
        public string mop { get; set; }
        public string card_cheq { get; set; }
        public string expiry { get; set; }
        public int issue_no { get; set; }
        public string reason_excess_not_collected { get; set; }
        public string paych { get; set; }
        public string summ_text { get; set; }
        public string code_text { get; set; }
        public int imchup { get; set; }
        public string job_grade { get; set; }
        public string njs { get; set; }
        public int photo { get; set; }
        public int booked { get; set; }
        public string nsn { get; set; }
        public string udi_start { get; set; }
        public string udi_fin { get; set; }
        public bool si_done { get; set; }
        public string udi_date { get; set; }
        public string si_bday1 { get; set; }
        public string si_mpay { get; set; }
        public string si_cnum { get; set; }
        public string si_inum { get; set; }
        public string udi_jobtext { get; set; }
        public string udi_staff { get; set; }
        public string type { get; set; }
        public string sub_type { get; set; }
        public string old_date { get; set; }
        public string cover_instructions { get; set; }
        public string old_start { get; set; }
        public string old_finish { get; set; }
        public string add_comm { get; set; }
        public string udi_estrem { get; set; }
        public string r_fault { get; set; }
        public int r_excess { get; set; }
        public string rexcedit { get; set; }
        public int r_comp { get; set; }
        public string rno_hours { get; set; }
        public string r_work_txt { get; set; }
        public bool readditimage { get; set; }
        public string readdtxt { get; set; }
        public bool r_sigimage { get; set; }
        public string f_add_txt { get; set; }
        public string fmclrf { get; set; }
        public string fmdate { get; set; }
        public string funfincode { get; set; }
        public string funfinoth { get; set; }
        public string freuntxt { get; set; }
        public string fpartreq { get; set; }
        public bool fjobfin { get; set; }
        public string fname1 { get; set; }
        public string fname2 { get; set; }
        public bool fexcess { get; set; }
        public string fexcessoth { get; set; }
        public bool fmand { get; set; }
        public string fmandoth { get; set; }
        public string ftimearr { get; set; }
        public string ftimeleft { get; set; }
        public bool faddpaid { get; set; }
        public double faddmuch { get; set; }
        public string commtxt { get; set; }
        public string wkcartxt { get; set; }
        public string parttxt { get; set; }
        public bool faddimage { get; set; }
        public bool fmanimage { get; set; }
        public bool fsigimage { get; set; }
        public int bWorkInside { get; set; }
        public string inst_height { get; set; }
        public int bBothHands { get; set; }
        public string ground_surface { get; set; }
        public string type_of_equipment { get; set; }
        public string risks_and_dangers { get; set; }
        public string uc_desc { get; set; }
        public int work_at_height { get; set; }
        public int no_ladders { get; set; }
        public string funfinished_code { get; set; }
        public string freason_unfinished { get; set; }
        public string fparts_required { get; set; }
        public string ffitter_name1 { get; set; }
        public string ffitter_name2 { get; set; }
        public int fbexcess_paid { get; set; }
        public string freason_excess_not_paid { get; set; }
        public int fbmandate_signed { get; set; }
        public string freason_mandate_not_signed { get; set; }
        public string ftime_arrived { get; set; }
        public string ftime_left { get; set; }
        public int fbadditional_paid { get; set; }
        public string fhow_mutch_additional_paid { get; set; }
        public int bfitter_complete { get; set; }
        public int fitter_info_done { get; set; }
        public string fbunfinother { get; set; }
        public bool bcompletion_signed { get; set; }
        public bool bad_image_complete { get; set; }
        public string remedial_number { get; set; }
        public bool r_bsigned { get; set; }
        public string r_bcomp { get; set; }
        public string r_sign_date { get; set; }
        public string stimea { get; set; }
        public string f1_or_s2 { get; set; }
        public string f_sign_date { get; set; }
        public long distance { get; set; }
        public long duration { get; set; }
        public int no_of_photos { get; set; }
        public string bClosest { get; set; }
        public string Group { get; set; }
        public string bProcessed { get; set; }
        public int ind { get; set; }
        public string inevitable_damage { get; set; }
        public bool fbstockusagecomplete { get; set; }
        public string uc_h_phone2 { get; set; }
        public string uc_h_phone3 { get; set; }
        public bool bSecuring { get; set; }
        public int ins_board { get; set; }
        public int ins_lock { get; set; }
        public int ins_temp { get; set; }
        public int ins_perm { get; set; }
        public int int_num_of_locks { get; set; }
        public string int_type_of_lock { get; set; }
        public int parking_at_rear { get; set; }
        public int work_on_public_footpath { get; set; }
        public string add_long { get; set; }
        public bool b_mrk { get; set; }
        public bool bSurvey { get; set; }
        public int items_above_roof { get; set; }
        public bool added_to_otherrisks { get; set; }
        public bool bMSFJob { get; set; }
        public int securing_surveyor_required { get; set; }
        public string policy_number { get; set; }
        public bool photo_front_of_house { get; set; }
        public int asbestos_visible { get; set; }
        public string asvizex { get; set; }
        public string refmessage { get; set; }
        public string uspot_fitter { get; set; }
        public string uspot_trainee { get; set; }
        public string uspot_date { get; set; }
        public string uspot_customer { get; set; }
        public string uspot_postcode { get; set; }
        public string uspot_insuranceco { get; set; }
        public string uspot_branch { get; set; }
        public bool uspot_repair { get; set; }
        public bool uspot_repair_arrived { get; set; }
        public bool uspot_repair_setup { get; set; }
        public bool uspot_repair_ongoing { get; set; }
        public bool uspot_repair_completed { get; set; }
        public bool uspot_replace { get; set; }
        public bool uspot_replace_arrived { get; set; }
        public bool uspot_replace_setup { get; set; }
        public bool uspot_replace_unitmoved { get; set; }
        public bool uspot_replace_completed { get; set; }
        public bool uspot_rev_door { get; set; }
        public bool uspot_rev_window { get; set; }
        public bool uspot_rev_garagedoor { get; set; }
        public bool uspot_rev_glass { get; set; }
        public bool uspot_rev_locks { get; set; }
        public bool uspot_rev_other { get; set; }
        public bool uspot_revb_upvc { get; set; }
        public bool uspot_revb_ali { get; set; }
        public bool uspot_revb_timber { get; set; }
        public bool uspot_revb_other { get; set; }
        public int uspot_appearence { get; set; }
        public string doc_l_compliant_reason { get; set; }
        public int lintel_present { get; set; }
        public string lintel_present_text { get; set; }
        public int uspot_customersatisfaction { get; set; }
        public string uspot_customersatisfaction_improvementsOld { get; set; }
        public string uspot_otherobservationsOld { get; set; }
        public bool uspot_signed { get; set; }
        public string uspot_signeddate { get; set; }
        public bool bSpotCheck { get; set; }
        public bool uspot_replace_fit { get; set; }
        public int uspot_p1 { get; set; }
        public int uspot_p2 { get; set; }
        public int uspot_p3 { get; set; }
        public int uspot_p4 { get; set; }
        public string uspot_appearence_improvements { get; set; }
        public string uspot_qualityofworks_improvements { get; set; }
        public string uspot_customersatisfaction_improvements { get; set; }
        public string uspot_otherobservations { get; set; }
        public bool idampassword_entered { get; set; }
        public int fit_no_of_videos { get; set; }
        public int doc_l_compliant { get; set; }
        public int shop_front_work { get; set; }
        public int fitter_videos { get; set; }
        public bool is_halifax { get; set; }
        public string messagetoinsurer { get; set; }
        public string COD_Code { get; set; }
        public string COD_String { get; set; }
        public bool bDamTicked { get; set; }
        public bool bSSTicked { get; set; }
        public int SSRequired { get; set; }
        public string old_cover_instructions { get; set; }
        public string rcodchanged { get; set; }
        public bool bcodchanged { get; set; }
        public string goaheadstr { get; set; }
        public int b_subcontract { get; set; }
        public string subcontracttext { get; set; }
        public bool truecomm { get; set; }
        public bool truecommconf { get; set; }
        public string reason_not_booked_in { get; set; }
        public bool bSurveyRequiredOnSecuring { get; set; }
        public bool requiring_load_bearing_jacks { get; set; }
        public bool bSRFin { get; set; }
        public bool bMOPFin { get; set; }
        public bool bRepFin { get; set; }
        public bool bSumFin { get; set; }
        public bool bHazFin { get; set; }
        public bool bAllPictures { get; set; }
        public bool bSubFin { get; set; }
        public int total_upvc { get; set; }
        public int total_panels { get; set; }
        public int total_glass { get; set; }
        public int total_alum { get; set; }
        public int total_garage { get; set; }
        public int total_timber { get; set; }
        public int total_cons { get; set; }
        public int total_lock { get; set; }
        public int total_comp { get; set; }
        public int total_green { get; set; }
        public int total_bifold { get; set; }
        public int incomplete_upvc { get; set; }
        public int incomplete_panels { get; set; }
        public int incomplete_glass { get; set; }
        public int incomplete_alum { get; set; }
        public int incomplete_garage { get; set; }
        public int incomplete_timber { get; set; }
        public int incomplete_cons { get; set; }
        public int incomplete_lock { get; set; }
        public int incomplete_comp { get; set; }
        public int incomplete_green { get; set; }
        public int incomplete_bifold { get; set; }
        public int front_house_photos { get; set; }
        public string time_to_complete { get; set; }
        public int current_item_number { get; set; }
        public int survey_complete { get; set; }
        public string reason_not_complete { get; set; }
        public string add_phone_1 { get; set; }
        public string add_phone_2 { get; set; }
        public int no_of_fitters { get; set; }
        public string fname3 { get; set; }
        public string fname4 { get; set; }
        public string fname5 { get; set; }
        public string fname6 { get; set; }
        public string fname7 { get; set; }
        public string fname8 { get; set; }
        public int ownquote { get; set; }
        public int survey_on_fit { get; set; }
        public int i_spare1 { get; set; }
        public int i_spare2 { get; set; }
        public int i_spare3 { get; set; }
        public string s_spare1 { get; set; }
        public string s_spare2 { get; set; }
        public string s_spare3 { get; set; }
        public int new_ispare1 { get; set; }
        public int new_ispare2 { get; set; }
        public int new_ispare3 { get; set; }
        public int new_ispare4 { get; set; }
        public int new_ispare5 { get; set; }
        public int new_ispare6 { get; set; }
        public int new_ispare7 { get; set; }
        public int new_ispare8 { get; set; }
        public int new_ispare9 { get; set; }
        public int is_messagetoinsurer { get; set; }
        public string new_sspare1 { get; set; }
        public string new_sspare2 { get; set; }
        public string new_sspare3 { get; set; }
        public string new_sspare4 { get; set; }
        public string new_sspare5 { get; set; }
        public string new_sspare6 { get; set; }
        public string new_sspare7 { get; set; }
        public string new_sspare8 { get; set; }
        public string new_sspare9 { get; set; }
        public string new_sspare10 { get; set; }

        public bool bInfoSeen { get; set; }

        public int ss_bIsSecuritySurvey { get; set; }
        public int ss_bIsComplete { get; set; }
        public string ss_nowindows { get; set; }
        public string ss_nodoors { get; set; }
        public string ss_gencondition { get; set; }
        public string ss_gencondition_other { get; set; }
        public string ss_matwindows { get; set; }
        public string ss_matwindows_other { get; set; }
        public string ss_matdoors { get; set; }
        public string ss_matdoors_other { get; set; }
        public string ss_lockwindows { get; set; }
        public string ss_lockwindows_other { get; set; }
        public string ss_lockdoors { get; set; }
        public string ss_lockdoors_other { get; set; }
        public int ss_add_window_security { get; set; }
        public string ss_location_windows_other { get; set; }
        public string ss_secwindows_other { get; set; }
        public int ss_add_door_security { get; set; }
        public string ss_location_doors_other { get; set; }
        public string ss_secdoors_other { get; set; }
        public string ss_time_required { get; set; }

        public int ss_no_of_photos { get; set; }
        public string door_type { get; set; }
        public string model_type { get; set; }
        public string unique_serial { get; set; }
        public string door_size { get; set; }
        public string door_manufacturer { get; set; }
        public string powerered_operator_type { get; set; }
        public string operator_manufacturer { get; set; }
        public string site_address { get; set; }
        public string decleration_by { get; set; }
        public string on_behalf_of_person { get; set; }
        public string on_behalf_of_company { get; set; }
        public string decleration_received_by { get; set; }
        public string date { get; set; }
        public string print_name { get; set; }
        public string date_cust { get; set; }
        public int i_signed { get; set; }
        public int i_signed_cust { get; set; }

        public int directive_complete { get; set; }

        public string branch { get; set; }
        public string name { get; set; }
        public string job { get; set; }
        public string name1 { get; set; }
        public int safety_boots_worn1 { get; set; }
        public int safety_gloves_worn1 { get; set; }
        public int safety_googles_worn1 { get; set; }
        public int safety_helmet_worn1 { get; set; }
        public int wristguards_worn1 { get; set; }
        public int uniform_worn_complete1 { get; set; }
        public int id_card_available1 { get; set; }
        public string name2 { get; set; }
        public int safety_boots_worn2 { get; set; }
        public int safety_gloves_worn2 { get; set; }
        public int safety_googles_worn2 { get; set; }
        public int safety_helmet_worn2 { get; set; }
        public int wristguards_worn2 { get; set; }
        public int uniform_worn_complete2 { get; set; }
        public int id_card_available2 { get; set; }
        public int chemicals_stored_correctly { get; set; }
        public int are_sheets_available { get; set; }
        public int area_above_been_checked { get; set; }
        public int obstructions_checked { get; set; }
        public int lintel_ok { get; set; }
        public int ladders_secure { get; set; }
        public int safe_work_at_height { get; set; }
        public int condition_of_ladders { get; set; }
        public int tools_set_out_safely { get; set; }
        public int fire_extinguisher_on_van { get; set; }
        public int first_aid_kit_on_van { get; set; }
        public int electrical_equipment_tested { get; set; }
        public string safety_boots_worn1_s { get; set; }
        public string safety_gloves_worn1_s { get; set; }
        public string safety_googles_worn1_s { get; set; }
        public string safety_helmet_worn1_s { get; set; }
        public string wristguards_worn1_s { get; set; }
        public string uniform_worn_complete1_s { get; set; }
        public string id_card_available1_s { get; set; }
        public string safety_boots_worn2_s { get; set; }
        public string safety_gloves_worn2_s { get; set; }
        public string safety_googles_worn2_s { get; set; }
        public string safety_helmet_worn2_s { get; set; }
        public string wristguards_worn2_s { get; set; }
        public string uniform_worn_complete2_s { get; set; }
        public string id_card_available2_s { get; set; }
        public string chemicals_stored_correctly_s { get; set; }
        public string are_sheets_available_s { get; set; }
        public string area_above_been_checked_s { get; set; }
        public string obstructions_checked_s { get; set; }
        public string lintel_ok_s { get; set; }
        public string ladders_secure_s { get; set; }
        public string safe_work_at_height_s { get; set; }
        public string condition_of_ladders_s { get; set; }
        public string tools_set_out_safely_s { get; set; }
        public string fire_extinguisher_on_van_s { get; set; }
        public string first_aid_kit_on_van_s { get; set; }
        public string electrical_equipment_tested_s { get; set; }
        public string comments { get; set; }
        public int uspot_qualityofworks { get; set; }
        public int current_summary_num { get; set; }

        public int uspot_replacement { get; set; }

        public int garage_door_motor { get; set; }

        public int isTowerScaff { get; set; }

    }

}
