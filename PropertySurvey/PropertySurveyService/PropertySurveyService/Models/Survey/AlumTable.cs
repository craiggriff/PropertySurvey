﻿
using System.ComponentModel.DataAnnotations;

// Regular expression to remove comments  (\t+|\s+|\r\n)((/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/)|(//.*))

namespace PropertySurveyService.Models
{
    public class AluminiumTable
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

        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.alum); }

    }



}
