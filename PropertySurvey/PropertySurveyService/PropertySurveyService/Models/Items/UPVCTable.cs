using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class UPVCTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
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
        public string? upvc_item { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public string? colour { get; set; }
        public string? cills { get; set; }
        public string? outer_section_size { get; set; }
        public string? internal_width { get; set; }
        public string? internal_height { get; set; }
        public string? brick_width { get; set; }
        public string? brick_height { get; set; }
        public int midrail { get; set; }
        public int addons { get; set; }
        public string? addon_width { get; set; }
        public string? addon_height { get; set; }
        public int head_drip { get; set; }
        public string? handle_colour { get; set; }
        public string? locking_type { get; set; }
        public string? letter_box { get; set; }
        public string? letter_box_pos { get; set; }
        public string? pet_flap { get; set; }
        public string? pet_type { get; set; }
        public int pet_magnetic { get; set; }
        public string? bead_type { get; set; }
        public int opens { get; set; }
        public int glaze { get; set; }
        public int trickle_vents { get; set; }
        public string? spacer_thickness { get; set; }
        public string? spacer_colour { get; set; }
        public string? glass_type { get; set; }
        public string? glass_pattern { get; set; }
        public string? special_glass { get; set; }
        public int double_tripple { get; set; }
        public int internal_lock { get; set; }
        public int bNewLockingMech { get; set; }
        public bool bLockComplete { get; set; }
        public bool bHandleDrawingComplete { get; set; }
        public int no_of_pics { get; set; }
        public string? midrail_height { get; set; }
        public int no_of_photos { get; set; }
        public string? frame_depth { get; set; }
        public string? docl { get; set; }
        public int profile_type { get; set; }
        public string? room_location { get; set; }
        public int no_of_vids { get; set; }
        public int LPHandles { get; set; }
        public int slide_position { get; set; }
        public string? threshold_type { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public bool fensa { get; set; }
        public string? WER_Rating { get; set; }
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
        public int left_bolt { get; set; }
        public int right_bolt { get; set; }
        public int GearBox { get; set; }
        public string? hinge_colour { get; set; }
        public string? lead_comments { get; set; }
        public int collect_and_copy { get; set; }
        public int temporary { get; set; }
        public string? parts_to_order { get; set; }
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

        UPVCTable() { }
        UPVCTable(UPVCTableDTO tItem) =>
        (HeaderId,
 udi_cont,
 item_number,
 isComplete,
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
 upvc_item,
 cause_of_damage,
 cause_of_damage_reason_different,
 colour,
 cills,
 outer_section_size,
 internal_width,
 internal_height,
 brick_width,
 brick_height,
 midrail,
 addons,
 addon_width,
 addon_height,
 head_drip,
 handle_colour,
 locking_type,
 letter_box,
 letter_box_pos,
 pet_flap,
 pet_type,
 pet_magnetic,
 bead_type,
 opens,
 glaze,
 trickle_vents,
 spacer_thickness,
 spacer_colour,
 glass_type,
 glass_pattern,
 special_glass,
 double_tripple,
 internal_lock,
 bNewLockingMech,
 bLockComplete,
 bHandleDrawingComplete,
 no_of_pics,
 midrail_height,
 no_of_photos,
 frame_depth,
 docl,
 profile_type,
 room_location,
 no_of_vids,
 LPHandles,
 slide_position,
 threshold_type,
 bDifferentFromOriginal,
 ChangeItemTo,
 print_name,
 fensa,
 WER_Rating,
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
 left_bolt,
 right_bolt,
 GearBox,
 hinge_colour,
 lead_comments,
 collect_and_copy,
 temporary,
 parts_to_order,
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
 replace_glass
) =
            (tItem.RecID,
tItem.udi_cont,
tItem.item_number,
tItem.isComplete,
tItem.bRepair,
tItem.cosmetic_damage,
tItem.additional_locks,
tItem.gaskets,
tItem.gaskets_text,
tItem.handles_req,
tItem.handles_text,
tItem.replace_panel,
tItem.replace_reason,
tItem.replace_explain,
tItem.upvc_item,
tItem.cause_of_damage,
tItem.cause_of_damage_reason_different,
tItem.colour,
tItem.cills,
tItem.outer_section_size,
tItem.internal_width,
tItem.internal_height,
tItem.brick_width,
tItem.brick_height,
tItem.midrail,
tItem.addons,
tItem.addon_width,
tItem.addon_height,
tItem.head_drip,
tItem.handle_colour,
tItem.locking_type,
tItem.letter_box,
tItem.letter_box_pos,
tItem.pet_flap,
tItem.pet_type,
tItem.pet_magnetic,
tItem.bead_type,
tItem.opens,
tItem.glaze,
tItem.trickle_vents,
tItem.spacer_thickness,
tItem.spacer_colour,
tItem.glass_type,
tItem.glass_pattern,
tItem.special_glass,
tItem.double_tripple,
tItem.internal_lock,
tItem.bNewLockingMech,
tItem.bLockComplete,
tItem.bHandleDrawingComplete,
tItem.no_of_pics,
tItem.midrail_height,
tItem.no_of_photos,
tItem.frame_depth,
tItem.docl,
tItem.profile_type,
tItem.room_location,
tItem.no_of_vids,
tItem.LPHandles,
tItem.slide_position,
tItem.threshold_type,
tItem.bDifferentFromOriginal,
tItem.ChangeItemTo,
tItem.print_name,
tItem.fensa,
tItem.WER_Rating,
tItem.long_comments,
tItem.bDoorComplete,
tItem.bWindowComplete,
tItem.lead_sizeA,
tItem.lead_sizeB,
tItem.lead_sizeC,
tItem.lead_sizeD,
tItem.lead_CWidth,
tItem.lead_CHeight,
tItem.lead_anti_rattle,
tItem.lead_thickness,
tItem.lead_sod,
tItem.lead_type,
tItem.lead_bDiamondComplete,
tItem.lead_bGeorgianComplete,
tItem.lead_bBarComplete,
tItem.lead_bSGDesignComplete,
tItem.lock_make,
tItem.lock_codes,
tItem.bPanelComplete,
tItem.left_bolt,
tItem.right_bolt,
tItem.GearBox,
tItem.hinge_colour,
tItem.lead_comments,
tItem.collect_and_copy,
tItem.temporary,
tItem.parts_to_order,
tItem.is_a_flat,
tItem.point_of_entry,
tItem.type_of_lockng_system_required,
tItem.was_it_locked,
tItem.back_to_back_spacer_width,
tItem.back_to_back_spacer_height,
tItem.l_size1,
tItem.l_size2,
tItem.l_sizeA,
tItem.l_sizeB,
tItem.l_sizeC,
tItem.l_sizeD,
tItem.l_sizeE,
tItem.l_sizeF,
tItem.l_sizeG,
tItem.l_num,
tItem.l_fpos1,
tItem.l_fpos2,
tItem.l_fpos3,
tItem.l_fpos4,
tItem.l_fpos5,
tItem.l_fpos6,
tItem.l_fpos7,
tItem.lock_position,
tItem.l_itype1,
tItem.l_itype2,
tItem.l_itype3,
tItem.l_itype4,
tItem.l_itype5,
tItem.l_itype6,
tItem.l_itype7,

tItem.lead_CWidthf,
tItem.lead_CHeightf,
tItem.lead_CWidths,
tItem.lead_CHeights,
tItem.glass_complete,
tItem.replace_glass);

    }









    public class UPVCTableDTO
    {
        public int RecID { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
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
        public string? upvc_item { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public string? colour { get; set; }
        public string? cills { get; set; }
        public string? outer_section_size { get; set; }
        public string? internal_width { get; set; }
        public string? internal_height { get; set; }
        public string? brick_width { get; set; }
        public string? brick_height { get; set; }
        public int midrail { get; set; }
        public int addons { get; set; }
        public string? addon_width { get; set; }
        public string? addon_height { get; set; }
        public int head_drip { get; set; }
        public string? handle_colour { get; set; }
        public string? locking_type { get; set; }
        public string? letter_box { get; set; }
        public string? letter_box_pos { get; set; }
        public string? pet_flap { get; set; }
        public string? pet_type { get; set; }
        public int pet_magnetic { get; set; }
        public string? bead_type { get; set; }
        public int opens { get; set; }
        public int glaze { get; set; }
        public int trickle_vents { get; set; }
        public string? spacer_thickness { get; set; }
        public string? spacer_colour { get; set; }
        public string? glass_type { get; set; }
        public string? glass_pattern { get; set; }
        public string? special_glass { get; set; }
        public int double_tripple { get; set; }
        public int internal_lock { get; set; }
        public int bNewLockingMech { get; set; }
        public bool bLockComplete { get; set; }
        public bool bHandleDrawingComplete { get; set; }
        public int no_of_pics { get; set; }
        public string? midrail_height { get; set; }
        public int no_of_photos { get; set; }
        public string? frame_depth { get; set; }
        public string? docl { get; set; }
        public int profile_type { get; set; }
        public string? room_location { get; set; }
        public int no_of_vids { get; set; }
        public int LPHandles { get; set; }
        public int slide_position { get; set; }
        public string? threshold_type { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public bool fensa { get; set; }
        public string? WER_Rating { get; set; }
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
        public int left_bolt { get; set; }
        public int right_bolt { get; set; }
        public int GearBox { get; set; }
        public string? hinge_colour { get; set; }
        public string? lead_comments { get; set; }
        public int collect_and_copy { get; set; }
        public int temporary { get; set; }
        public string? parts_to_order { get; set; }
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
