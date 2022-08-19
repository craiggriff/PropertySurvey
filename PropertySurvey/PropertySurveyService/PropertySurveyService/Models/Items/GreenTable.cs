using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class GreenTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public string? rep_reason { get; set; }
        public string? material_type { get; set; }
        public string? colour { get; set; }
        public string? glaze_type { get; set; }
        public string? base_size { get; set; }
        public string? base_size_x { get; set; }
        public string? base_size_y { get; set; }
        public string? type_of_glass { get; set; }
        public string? door_opening_type { get; set; }
        public string? window_opening_type { get; set; }
        public int roof_opening_lights { get; set; }
        public int auto_or_manual { get; set; }
        public string? overall_height { get; set; }
        public string? summary { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public int no_of_vids { get; set; }
        public string? parts_to_order { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public bool glass_complete { get; set; }
        public int replace_glass { get; set; }
        public int repair_or_replace { get; set; }

        GreenTable() { }
        GreenTable(GreenTableDTO tItem) =>
        (HeaderId,
         udi_cont,
         item_number,
         isComplete,
         bDifferentFromOriginal,
         cause_of_damage,
         cause_of_damage_reason_different,
         rep_reason,
         material_type,
         colour,
         glaze_type,
         base_size,
         base_size_x,
         base_size_y,
         type_of_glass,
         door_opening_type,
         window_opening_type,
         roof_opening_lights,
         auto_or_manual,
         overall_height,
         summary,
         no_of_pics,
         no_of_photos,
         no_of_vids,
         parts_to_order,
         point_of_entry,
         type_of_lockng_system_required,
         was_it_locked,
         ChangeItemTo,
         print_name,
         glass_complete,
         replace_glass,
         repair_or_replace) = (tItem.RecID,
        tItem.udi_cont,
        tItem.item_number,
        tItem.isComplete,
        tItem.bDifferentFromOriginal,
        tItem.cause_of_damage,
        tItem.cause_of_damage_reason_different,
        tItem.rep_reason,
        tItem.material_type,
        tItem.colour,
        tItem.glaze_type,
        tItem.base_size,
        tItem.base_size_x,
        tItem.base_size_y,
        tItem.type_of_glass,
        tItem.door_opening_type,
        tItem.window_opening_type,
        tItem.roof_opening_lights,
        tItem.auto_or_manual,
        tItem.overall_height,
        tItem.summary,
        tItem.no_of_pics,
        tItem.no_of_photos,
        tItem.no_of_vids,
        tItem.parts_to_order,
        tItem.point_of_entry,
        tItem.type_of_lockng_system_required,
        tItem.was_it_locked,
        tItem.ChangeItemTo,
        tItem.print_name,
        tItem.glass_complete,
        tItem.replace_glass,
        tItem.repair_or_replace);
    }


    public class GreenTableDTO
    {
        public int RecID { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public string? rep_reason { get; set; }
        public string? material_type { get; set; }
        public string? colour { get; set; }
        public string? glaze_type { get; set; }
        public string? base_size { get; set; }
        public string? base_size_x { get; set; }
        public string? base_size_y { get; set; }
        public string? type_of_glass { get; set; }
        public string? door_opening_type { get; set; }
        public string? window_opening_type { get; set; }
        public int roof_opening_lights { get; set; }
        public int auto_or_manual { get; set; }
        public string? overall_height { get; set; }
        public string? summary { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public int no_of_vids { get; set; }
        public string? parts_to_order { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public bool glass_complete { get; set; }
        public int replace_glass { get; set; }
        public int repair_or_replace { get; set; }
    }

}
