
using System.ComponentModel.DataAnnotations;

// Regular expression to remove comments  (\t+|\s+|\r\n)((/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/)|(//.*))

namespace PropertySurveyService.Models
{
    public class AlumTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public bool bRepair { get; set; }
        public int cosmetic_damage { get; set; }
        public string? additional_locks { get; set; }
        public int gaskets { get; set; }
        public string? gaskets_text { get; set; }
        public int handles_req { get; set; }
        public string? handles_text { get; set; }
        public int replace_panel { get; set; }
        public string? replace_reason { get; set; }
        public string? replace_explain { get; set; }
        public string? type { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public int section_type { get; set; }
        public int new_timber_sub_frame { get; set; }
        public string? sub_frame_depth { get; set; }
        public string? item_frame_width { get; set; }
        public string? item_frame_height { get; set; }
        public string? brick_width { get; set; }
        public string? brick_height { get; set; }
        public string? internal_width { get; set; }
        public string? internal_height { get; set; }
        public int frame_type { get; set; }
        public int cill { get; set; }
        public int drip { get; set; }
        public int night_vent { get; set; }
        public string? midrail_type { get; set; }
        public string? item_color { get; set; }
        public string? locking_type { get; set; }
        public string? letter_box { get; set; }
        public string? letter_box_pos { get; set; }
        public string? pet_flap { get; set; }
        public string? pet_type { get; set; }
        public int pet_magnetic { get; set; }
        public int opens { get; set; }
        public string? handle_color { get; set; }
        public string? spacer_thickness { get; set; }
        public string? spacer_color { get; set; }
        public string? glass_type { get; set; }
        public string? glass_pattern { get; set; }
        public string? special_glass { get; set; }
        public string? sub_frame_color { get; set; }
        public int bNewLockingMech { get; set; }
        public int bLockComplete { get; set; }
        public bool bHandleDrawingComplete { get; set; }
        public int no_of_pics { get; set; }
        public string? midrail_height { get; set; }
        public int no_of_photos { get; set; }
        public string? docl { get; set; }
        public string? room_location { get; set; }
        public int no_of_vids { get; set; }
        public int LPHandles { get; set; }
        public string? threshold_type { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public bool bFencer { get; set; }
        public string? FecerRating { get; set; }
        public string? long_comments { get; set; }
        public bool bDoorComplete { get; set; }
        public bool bWindowComplete { get; set; }
        public int lead_sizeA { get; set; }
        public int lead_sizeB { get; set; }
        public int lead_sizeC { get; set; }
        public int lead_sizeD { get; set; }
        public int lead_CWidth { get; set; }
        public int lead_CHeight { get; set; }
        public int lead_anti_rattle { get; set; }
        public string? lead_thickness { get; set; }
        public string? lead_sod { get; set; }
        public string? lead_type { get; set; }
        public bool lead_bDiamondComplete { get; set; }
        public bool lead_bGeorgianComplete { get; set; }
        public bool lead_bBarComplete { get; set; }
        public bool lead_bSGDesignComplete { get; set; }
        public string? lock_make { get; set; }
        public string? lock_codes { get; set; }
        public bool bPanelComplete { get; set; }
        public int GearBox { get; set; }
        public int left_bolt { get; set; }
        public int right_bolt { get; set; }
        public int isComplete { get; set; }
        public int cill_on_subframe { get; set; }
        public int cill_type { get; set; }
        public int i_spare3 { get; set; }
        public int collect_and_copy { get; set; }
        public int temporary { get; set; }
        public int glazed { get; set; }
        public int bead_type { get; set; }
        public string? outer_section_width { get; set; }
        public string? outer_section_height { get; set; }
        public string? parts_to_order { get; set; }
        public string? lead_comments { get; set; }
        public int is_a_flat { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public string? back_to_back_spacer_width { get; set; }
        public string? back_to_back_spacer_height { get; set; }
        public string? l_size1 { get; set; }
        public string? l_size2 { get; set; }
        public string? l_sizeA { get; set; }
        public string? l_sizeB { get; set; }
        public string? l_sizeC { get; set; }
        public string? l_sizeD { get; set; }
        public string? l_sizeE { get; set; }
        public string? l_sizeF { get; set; }
        public string? l_sizeG { get; set; }
        public int l_num { get; set; }
        public float l_fpos1 { get; set; }
        public float l_fpos2 { get; set; }
        public float l_fpos3 { get; set; }
        public float l_fpos4 { get; set; }
        public float l_fpos5 { get; set; }
        public float l_fpos6 { get; set; }
        public float l_fpos7 { get; set; }
        public float lock_position { get; set; }
        public int l_itype1 { get; set; }
        public int l_itype2 { get; set; }
        public int l_itype3 { get; set; }
        public int l_itype4 { get; set; }
        public int l_itype5 { get; set; }
        public int l_itype6 { get; set; }
        public int l_itype7 { get; set; }
        public float lead_CWidthf { get; set; }
        public float lead_CHeightf { get; set; }
        public string? lead_CWidths { get; set; }
        public string? lead_CHeights { get; set; }
        public bool glass_complete { get; set; }
        public int replace_glass { get; set; }
        
        AlumTable() { }
        AlumTable(AlumTableDTO alumItem) =>
        (HeaderId,
     udi_cont,
     item_number,
     bRepair,
     cosmetic_damage,
     additional_locks,
     gaskets,
     gaskets_text,
     handles_req,
     handles_text,
     replace_panel,
     replace_reason,
     replace_explain,
     type,
     cause_of_damage,
     cause_of_damage_reason_different,
     section_type,
     new_timber_sub_frame,
     sub_frame_depth,
     item_frame_width,
     item_frame_height,
     brick_width,
     brick_height,
     internal_width,
     internal_height,
     frame_type,
     cill,
     drip,
     night_vent,
     midrail_type,
     item_color,
     locking_type,
     letter_box,
     letter_box_pos,
     pet_flap,
     pet_type,
     pet_magnetic,
     opens,
     handle_color,
     spacer_thickness,
     spacer_color,
     glass_type,
     glass_pattern,
     special_glass,
     sub_frame_color,
     bNewLockingMech,
     bLockComplete,
     bHandleDrawingComplete,
     no_of_pics,
     midrail_height,
     no_of_photos,
     docl,
     room_location,
     no_of_vids,
     LPHandles,
     threshold_type,
     bDifferentFromOriginal,
     ChangeItemTo,
     print_name,
     bFencer,
     FecerRating,
     long_comments,
     bDoorComplete,
     bWindowComplete,
     lead_sizeA,
     lead_sizeB,
     lead_sizeC,
     lead_sizeD,
     lead_CWidth,
     lead_CHeight,
     lead_anti_rattle,
     lead_thickness,
     lead_sod,
     lead_type,
     lead_bDiamondComplete,
     lead_bGeorgianComplete,
     lead_bBarComplete,
     lead_bSGDesignComplete,
     lock_make,
     lock_codes,
     bPanelComplete,
     GearBox,
     left_bolt,
     right_bolt,
     isComplete,
     cill_on_subframe,
     cill_type,
     i_spare3,
     collect_and_copy,
     temporary,
     glazed,
     bead_type,
     outer_section_width,
     outer_section_height,
     parts_to_order,
     lead_comments,
     is_a_flat,
     point_of_entry,
     type_of_lockng_system_required,
     was_it_locked,
     back_to_back_spacer_width,
     back_to_back_spacer_height,
     l_size1,
     l_size2,
     l_sizeA,
     l_sizeB,
     l_sizeC,
     l_sizeD,
     l_sizeE,
     l_sizeF,
     l_sizeG,
     l_num,
     l_fpos1,
     l_fpos2,
     l_fpos3,
     l_fpos4,
     l_fpos5,
     l_fpos6,
     l_fpos7,
     lock_position,
     l_itype1,
     l_itype2,
     l_itype3,
     l_itype4,
     l_itype5,
     l_itype6,
     l_itype7,
     lead_CWidthf,
     lead_CHeightf,
     lead_CWidths,
     lead_CHeights,
     glass_complete,
     replace_glass) = (alumItem.RecID,
alumItem.udi_cont,
alumItem.item_number,
alumItem.bRepair,
alumItem.cosmetic_damage,
alumItem.additional_locks,
alumItem.gaskets,
alumItem.gaskets_text,
alumItem.handles_req,
alumItem.handles_text,
alumItem.replace_panel,
alumItem.replace_reason,
alumItem.replace_explain,
alumItem.type,
alumItem.cause_of_damage,
alumItem.cause_of_damage_reason_different,
alumItem.section_type,
alumItem.new_timber_sub_frame,
alumItem.sub_frame_depth,
alumItem.item_frame_width,
alumItem.item_frame_height,
alumItem.brick_width,
alumItem.brick_height,
alumItem.internal_width,
alumItem.internal_height,
alumItem.frame_type,
alumItem.cill,
alumItem.drip,
alumItem.night_vent,
alumItem.midrail_type,
alumItem.item_color,
alumItem.locking_type,
alumItem.letter_box,
alumItem.letter_box_pos,
alumItem.pet_flap,
alumItem.pet_type,
alumItem.pet_magnetic,
alumItem.opens,
alumItem.handle_color,
alumItem.spacer_thickness,
alumItem.spacer_color,
alumItem.glass_type,
alumItem.glass_pattern,
alumItem.special_glass,
alumItem.sub_frame_color,
alumItem.bNewLockingMech,
alumItem.bLockComplete,
alumItem.bHandleDrawingComplete,
alumItem.no_of_pics,
alumItem.midrail_height,
alumItem.no_of_photos,
alumItem.docl,
alumItem.room_location,
alumItem.no_of_vids,
alumItem.LPHandles,
alumItem.threshold_type,
alumItem.bDifferentFromOriginal,
alumItem.ChangeItemTo,
alumItem.print_name,
alumItem.bFencer,
alumItem.FecerRating,
alumItem.long_comments,
alumItem.bDoorComplete,
alumItem.bWindowComplete,
alumItem.lead_sizeA,
alumItem.lead_sizeB,
alumItem.lead_sizeC,
alumItem.lead_sizeD,
alumItem.lead_CWidth,
alumItem.lead_CHeight,
alumItem.lead_anti_rattle,
alumItem.lead_thickness,
alumItem.lead_sod,
alumItem.lead_type,
alumItem.lead_bDiamondComplete,
alumItem.lead_bGeorgianComplete,
alumItem.lead_bBarComplete,
alumItem.lead_bSGDesignComplete,
alumItem.lock_make,
alumItem.lock_codes,
alumItem.bPanelComplete,
alumItem.GearBox,
alumItem.left_bolt,
alumItem.right_bolt,
alumItem.isComplete,
alumItem.cill_on_subframe,
alumItem.cill_type,
alumItem.i_spare3,
alumItem.collect_and_copy,
alumItem.temporary,
alumItem.glazed,
alumItem.bead_type,
alumItem.outer_section_width,
alumItem.outer_section_height,
alumItem.parts_to_order,
alumItem.lead_comments,
alumItem.is_a_flat,
alumItem.point_of_entry,
alumItem.type_of_lockng_system_required,
alumItem.was_it_locked,
alumItem.back_to_back_spacer_width,
alumItem.back_to_back_spacer_height,
alumItem.l_size1,
alumItem.l_size2,
alumItem.l_sizeA,
alumItem.l_sizeB,
alumItem.l_sizeC,
alumItem.l_sizeD,
alumItem.l_sizeE,
alumItem.l_sizeF,
alumItem.l_sizeG,
alumItem.l_num,
alumItem.l_fpos1,
alumItem.l_fpos2,
alumItem.l_fpos3,
alumItem.l_fpos4,
alumItem.l_fpos5,
alumItem.l_fpos6,
alumItem.l_fpos7,
alumItem.lock_position,
alumItem.l_itype1,
alumItem.l_itype2,
alumItem.l_itype3,
alumItem.l_itype4,
alumItem.l_itype5,
alumItem.l_itype6,
alumItem.l_itype7,
alumItem.lead_CWidthf,
alumItem.lead_CHeightf,
alumItem.lead_CWidths,
alumItem.lead_CHeights,
alumItem.glass_complete,
alumItem.replace_glass);
        
    }

    public class AlumTableDTO
    {
        public int RecID { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public bool bRepair { get; set; }
        public int cosmetic_damage { get; set; }
        public string? additional_locks { get; set; }
        public int gaskets { get; set; }
        public string? gaskets_text { get; set; }
        public int handles_req { get; set; }
        public string? handles_text { get; set; }
        public int replace_panel { get; set; }
        public string? replace_reason { get; set; }
        public string? replace_explain { get; set; }
        public string? type { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public int section_type { get; set; }
        public int new_timber_sub_frame { get; set; }
        public string? sub_frame_depth { get; set; }
        public string? item_frame_width { get; set; }
        public string? item_frame_height { get; set; }
        public string? brick_width { get; set; }
        public string? brick_height { get; set; }
        public string? internal_width { get; set; }
        public string? internal_height { get; set; }
        public int frame_type { get; set; }
        public int cill { get; set; }
        public int drip { get; set; }
        public int night_vent { get; set; }
        public string? midrail_type { get; set; }
        public string? item_color { get; set; }
        public string? locking_type { get; set; }
        public string? letter_box { get; set; }
        public string? letter_box_pos { get; set; }
        public string? pet_flap { get; set; }
        public string? pet_type { get; set; }
        public int pet_magnetic { get; set; }
        public int opens { get; set; }
        public string? handle_color { get; set; }
        public string? spacer_thickness { get; set; }
        public string? spacer_color { get; set; }
        public string? glass_type { get; set; }
        public string? glass_pattern { get; set; }
        public string? special_glass { get; set; }
        public string? sub_frame_color { get; set; }
        public int bNewLockingMech { get; set; }
        public int bLockComplete { get; set; }
        public bool bHandleDrawingComplete { get; set; }
        public int no_of_pics { get; set; }
        public string? midrail_height { get; set; }
        public int no_of_photos { get; set; }
        public string? docl { get; set; }
        public string? room_location { get; set; }
        public int no_of_vids { get; set; }
        public int LPHandles { get; set; }
        public string? threshold_type { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public bool bFencer { get; set; }
        public string? FecerRating { get; set; }
        public string? long_comments { get; set; }
        public bool bDoorComplete { get; set; }
        public bool bWindowComplete { get; set; }
        public int lead_sizeA { get; set; }
        public int lead_sizeB { get; set; }
        public int lead_sizeC { get; set; }
        public int lead_sizeD { get; set; }
        public int lead_CWidth { get; set; }
        public int lead_CHeight { get; set; }
        public int lead_anti_rattle { get; set; }
        public string? lead_thickness { get; set; }
        public string? lead_sod { get; set; }
        public string? lead_type { get; set; }
        public bool lead_bDiamondComplete { get; set; }
        public bool lead_bGeorgianComplete { get; set; }
        public bool lead_bBarComplete { get; set; }
        public bool lead_bSGDesignComplete { get; set; }
        public string? lock_make { get; set; }
        public string? lock_codes { get; set; }
        public bool bPanelComplete { get; set; }
        public int GearBox { get; set; }
        public int left_bolt { get; set; }
        public int right_bolt { get; set; }
        public int isComplete { get; set; }
        public int cill_on_subframe { get; set; }
        public int cill_type { get; set; }
        public int i_spare3 { get; set; }
        public int collect_and_copy { get; set; }
        public int temporary { get; set; }
        public int glazed { get; set; }
        public int bead_type { get; set; }
        public string? outer_section_width { get; set; }
        public string? outer_section_height { get; set; }
        public string? parts_to_order { get; set; }
        public string? lead_comments { get; set; }
        public int is_a_flat { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public string? back_to_back_spacer_width { get; set; }
        public string? back_to_back_spacer_height { get; set; }
        public string? l_size1 { get; set; }
        public string? l_size2 { get; set; }
        public string? l_sizeA { get; set; }
        public string? l_sizeB { get; set; }
        public string? l_sizeC { get; set; }
        public string? l_sizeD { get; set; }
        public string? l_sizeE { get; set; }
        public string? l_sizeF { get; set; }
        public string? l_sizeG { get; set; }
        public int l_num { get; set; }
        public float l_fpos1 { get; set; }
        public float l_fpos2 { get; set; }
        public float l_fpos3 { get; set; }
        public float l_fpos4 { get; set; }
        public float l_fpos5 { get; set; }
        public float l_fpos6 { get; set; }
        public float l_fpos7 { get; set; }
        public float lock_position { get; set; }
        public int l_itype1 { get; set; }
        public int l_itype2 { get; set; }
        public int l_itype3 { get; set; }
        public int l_itype4 { get; set; }
        public int l_itype5 { get; set; }
        public int l_itype6 { get; set; }
        public int l_itype7 { get; set; }
        public float lead_CWidthf { get; set; }
        public float lead_CHeightf { get; set; }
        public string? lead_CWidths { get; set; }
        public string? lead_CHeights { get; set; }
        public bool glass_complete { get; set; }
        public int replace_glass { get; set; }


    }



}
