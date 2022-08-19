using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{ 
    public class ConsTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
        public string? type { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public int material_type { get; set; }
        public string? sizeA { get; set; }
        public string? sizeB { get; set; }
        public string? sizeC { get; set; }
        public string? sizeD { get; set; }
        public string? sizeE { get; set; }
        public string? sizeF { get; set; }
        public string? sizeG { get; set; }
        public string? angle1 { get; set; }
        public string? angle2 { get; set; }
        public string? angle3 { get; set; }
        public string? angle4 { get; set; }
        public string? pitch_height { get; set; }
        public string? profile_section_size { get; set; }
        public string? sheet_width_1 { get; set; }
        public string? sheet_height_1 { get; set; }
        public string? sheet_width_2 { get; set; }
        public string? sheet_height_2 { get; set; }
        public string? sheet_width_3 { get; set; }
        public string? sheet_height_3 { get; set; }
        public string? sheet_width_4 { get; set; }
        public string? sheet_height_4 { get; set; }
        public string? sheet_width_5 { get; set; }
        public string? sheet_height_5 { get; set; }
        public string? sheet_width_6 { get; set; }
        public string? sheet_height_6 { get; set; }
        public string? sheet_width_7 { get; set; }
        public string? sheet_height_7 { get; set; }
        public string? sheet_width_8 { get; set; }
        public string? sheet_height_8 { get; set; }
        public string? sheet_width_9 { get; set; }
        public string? sheet_height_9 { get; set; }
        public string? sheet_width_10 { get; set; }
        public string? sheet_height_10 { get; set; }
        public string? flute_size { get; set; }
        public string? color { get; set; }
        public string? roof_color { get; set; }
        public int new_firrings_req { get; set; }
        public int new_gutters_req { get; set; }
        public string? roof_glazing_thickness { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public string? room_location { get; set; }
        public int no_of_vids { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public string? wall_pos { get; set; }
        public string? pitch_degree { get; set; }
        public string? long_comments { get; set; }
        public int bDrawingsOnly { get; set; }
        public bool cons_roof_under_drawn { get; set; }
        public int does_roof_fit_under { get; set; }
        public int spars_line_up { get; set; }
        public int roof_sheets_quantity_1 { get; set; }
        public int roof_sheets_quantity_2 { get; set; }
        public int roof_sheets_quantity_3 { get; set; }
        public int roof_sheets_quantity_4 { get; set; }
        public int roof_sheets_quantity_5 { get; set; }
        public int roof_sheets_quantity_6 { get; set; }
        public int roof_sheets_quantity_7 { get; set; }
        public int roof_sheets_quantity_8 { get; set; }
        public int roof_sheets_quantity_9 { get; set; }
        public int roof_sheets_quantity_10 { get; set; }
        public int good_conditions { get; set; }
        public string? ridge_length { get; set; }
        public string? parts_to_order { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public bool glass_complete { get; set; }
        public int replace_glass { get; set; }
        public string? reason_not_repaired { get; set; }
        public bool bRepair { get; set; }
        public bool fensa { get; set; }
        public string? WER_rating { get; set; }
        public string? overall_length_of_sheet { get; set; }

        ConsTable() { }
        ConsTable(ConsTableDTO tItem) =>
        (HeaderId,
 udi_cont,
 item_number,
 isComplete,
 type,
 cause_of_damage,
 cause_of_damage_reason_different,
 material_type,
 sizeA,
 sizeB,
 sizeC,
 sizeD,
 sizeE,
 sizeF,
 sizeG,
 angle1,
 angle2,
 angle3,
 angle4,
 pitch_height,
 profile_section_size,
 sheet_width_1,
 sheet_height_1,
 sheet_width_2,
 sheet_height_2,
 sheet_width_3,
 sheet_height_3,
 sheet_width_4,
 sheet_height_4,
 sheet_width_5,
 sheet_height_5,
 sheet_width_6,
 sheet_height_6,
 sheet_width_7,
 sheet_height_7,
 sheet_width_8,
 sheet_height_8,
 sheet_width_9,
 sheet_height_9,
 sheet_width_10,
 sheet_height_10,
 flute_size,
 color,
 roof_color,
 new_firrings_req,
 new_gutters_req,
 roof_glazing_thickness,
 no_of_pics,
 no_of_photos,
 room_location,
 no_of_vids,
 bDifferentFromOriginal,
 ChangeItemTo,
 print_name,
 wall_pos,
 pitch_degree,
 long_comments,
 bDrawingsOnly,
 cons_roof_under_drawn,
 does_roof_fit_under,
 spars_line_up,
 roof_sheets_quantity_1,
 roof_sheets_quantity_2,
 roof_sheets_quantity_3,
 roof_sheets_quantity_4,
 roof_sheets_quantity_5,
 roof_sheets_quantity_6,
 roof_sheets_quantity_7,
 roof_sheets_quantity_8,
 roof_sheets_quantity_9,
 roof_sheets_quantity_10,
 good_conditions,
 ridge_length,
 parts_to_order,
 point_of_entry,
 type_of_lockng_system_required,
 was_it_locked,
 glass_complete,
 replace_glass,
 reason_not_repaired,
 bRepair,
 fensa,
 WER_rating,
 overall_length_of_sheet) = 
            (tItem.RecID,
tItem.udi_cont,
tItem.item_number,
tItem.isComplete,
tItem.type,
tItem.cause_of_damage,
tItem.cause_of_damage_reason_different,
tItem.material_type,
tItem.sizeA,
tItem.sizeB,
tItem.sizeC,
tItem.sizeD,
tItem.sizeE,
tItem.sizeF,
tItem.sizeG,
tItem.angle1,
tItem.angle2,
tItem.angle3,
tItem.angle4,
tItem.pitch_height,
tItem.profile_section_size,
tItem.sheet_width_1,
tItem.sheet_height_1,
tItem.sheet_width_2,
tItem.sheet_height_2,
tItem.sheet_width_3,
tItem.sheet_height_3,
tItem.sheet_width_4,
tItem.sheet_height_4,
tItem.sheet_width_5,
tItem.sheet_height_5,
tItem.sheet_width_6,
tItem.sheet_height_6,
tItem.sheet_width_7,
tItem.sheet_height_7,
tItem.sheet_width_8,
tItem.sheet_height_8,
tItem.sheet_width_9,
tItem.sheet_height_9,
tItem.sheet_width_10,
tItem.sheet_height_10,
tItem.flute_size,
tItem.color,
tItem.roof_color,
tItem.new_firrings_req,
tItem.new_gutters_req,
tItem.roof_glazing_thickness,
tItem.no_of_pics,
tItem.no_of_photos,
tItem.room_location,
tItem.no_of_vids,
tItem.bDifferentFromOriginal,
tItem.ChangeItemTo,
tItem.print_name,
tItem.wall_pos,
tItem.pitch_degree,
tItem.long_comments,
tItem.bDrawingsOnly,
tItem.cons_roof_under_drawn,
tItem.does_roof_fit_under,
tItem.spars_line_up,
tItem.roof_sheets_quantity_1,
tItem.roof_sheets_quantity_2,
tItem.roof_sheets_quantity_3,
tItem.roof_sheets_quantity_4,
tItem.roof_sheets_quantity_5,
tItem.roof_sheets_quantity_6,
tItem.roof_sheets_quantity_7,
tItem.roof_sheets_quantity_8,
tItem.roof_sheets_quantity_9,
tItem.roof_sheets_quantity_10,
tItem.good_conditions,
tItem.ridge_length,
tItem.parts_to_order,
tItem.point_of_entry,
tItem.type_of_lockng_system_required,
tItem.was_it_locked,
tItem.glass_complete,
tItem.replace_glass,
tItem.reason_not_repaired,
tItem.bRepair,
tItem.fensa,
tItem.WER_rating,
tItem.overall_length_of_sheet);
    }


    public class ConsTableDTO
    {
        public int RecID { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
        public string? type { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public int material_type { get; set; }
        public string? sizeA { get; set; }
        public string? sizeB { get; set; }
        public string? sizeC { get; set; }
        public string? sizeD { get; set; }
        public string? sizeE { get; set; }
        public string? sizeF { get; set; }
        public string? sizeG { get; set; }
        public string? angle1 { get; set; }
        public string? angle2 { get; set; }
        public string? angle3 { get; set; }
        public string? angle4 { get; set; }
        public string? pitch_height { get; set; }
        public string? profile_section_size { get; set; }
        public string? sheet_width_1 { get; set; }
        public string? sheet_height_1 { get; set; }
        public string? sheet_width_2 { get; set; }
        public string? sheet_height_2 { get; set; }
        public string? sheet_width_3 { get; set; }
        public string? sheet_height_3 { get; set; }
        public string? sheet_width_4 { get; set; }
        public string? sheet_height_4 { get; set; }
        public string? sheet_width_5 { get; set; }
        public string? sheet_height_5 { get; set; }
        public string? sheet_width_6 { get; set; }
        public string? sheet_height_6 { get; set; }
        public string? sheet_width_7 { get; set; }
        public string? sheet_height_7 { get; set; }
        public string? sheet_width_8 { get; set; }
        public string? sheet_height_8 { get; set; }
        public string? sheet_width_9 { get; set; }
        public string? sheet_height_9 { get; set; }
        public string? sheet_width_10 { get; set; }
        public string? sheet_height_10 { get; set; }
        public string? flute_size { get; set; }
        public string? color { get; set; }
        public string? roof_color { get; set; }
        public int new_firrings_req { get; set; }
        public int new_gutters_req { get; set; }
        public string? roof_glazing_thickness { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public string? room_location { get; set; }
        public int no_of_vids { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public string? wall_pos { get; set; }
        public string? pitch_degree { get; set; }
        public string? long_comments { get; set; }
        public int bDrawingsOnly { get; set; }
        public bool cons_roof_under_drawn { get; set; }
        public int does_roof_fit_under { get; set; }
        public int spars_line_up { get; set; }
        public int roof_sheets_quantity_1 { get; set; }
        public int roof_sheets_quantity_2 { get; set; }
        public int roof_sheets_quantity_3 { get; set; }
        public int roof_sheets_quantity_4 { get; set; }
        public int roof_sheets_quantity_5 { get; set; }
        public int roof_sheets_quantity_6 { get; set; }
        public int roof_sheets_quantity_7 { get; set; }
        public int roof_sheets_quantity_8 { get; set; }
        public int roof_sheets_quantity_9 { get; set; }
        public int roof_sheets_quantity_10 { get; set; }
        public int good_conditions { get; set; }
        public string? ridge_length { get; set; }
        public string? parts_to_order { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public bool glass_complete { get; set; }
        public int replace_glass { get; set; }
        public string? reason_not_repaired { get; set; }
        public bool bRepair { get; set; }
        public bool fensa { get; set; }
        public string? WER_rating { get; set; }
        public string? overall_length_of_sheet { get; set; }
    }

}
