using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class PanelTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public string? knockedit { get; set; }
        public string? knocoledit { get; set; }
        public string? letteredit { get; set; }
        public string? letter_box_pos { get; set; }
        public string? wedit { get; set; }
        public string? hedit { get; set; }
        public string? typeedit { get; set; }
        public string? thickedit { get; set; }
        public string? backgedit { get; set; }
        public string? coledit { get; set; }
        public string? gltext { get; set; }
        public string? spaccoloedit { get; set; }
        public string? pet_flap { get; set; }
        public string? pet_type { get; set; }
        public int pet_magnetic { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public int no_of_vids { get; set; }
        public string? room_location { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public string? long_sptext { get; set; }
        public int upvc_item_number { get; set; }
        public int alum_item_number { get; set; }
        public string? parts_to_order { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }

        PanelTable() { }
        PanelTable(PanelTableDTO tItem) =>
        (HeaderId,
 udi_cont,
 item_number,
 isComplete,
 cause_of_damage,
 cause_of_damage_reason_different,
 knockedit,
 knocoledit,
 letteredit,
 letter_box_pos,
 wedit,
 hedit,
 typeedit,
 thickedit,
 backgedit,
 coledit,
 gltext,
 spaccoloedit,
 pet_flap,
 pet_type,
 pet_magnetic,
 no_of_pics,
 no_of_photos,
 no_of_vids,
 room_location,
 bDifferentFromOriginal,
 ChangeItemTo,
 print_name,
 long_sptext,
 upvc_item_number,
 alum_item_number,
 parts_to_order,
 point_of_entry,
 type_of_lockng_system_required,
 was_it_locked) =
            (tItem.RecID,
tItem.udi_cont,
tItem.item_number,
tItem.isComplete,
tItem.cause_of_damage,
tItem.cause_of_damage_reason_different,
tItem.knockedit,
tItem.knocoledit,
tItem.letteredit,
tItem.letter_box_pos,
tItem.wedit,
tItem.hedit,
tItem.typeedit,
tItem.thickedit,
tItem.backgedit,
tItem.coledit,
tItem.gltext,
tItem.spaccoloedit,
tItem.pet_flap,
tItem.pet_type,
tItem.pet_magnetic,
tItem.no_of_pics,
tItem.no_of_photos,
tItem.no_of_vids,
tItem.room_location,
tItem.bDifferentFromOriginal,
tItem.ChangeItemTo,
tItem.print_name,
tItem.long_sptext,
tItem.upvc_item_number,
tItem.alum_item_number,
tItem.parts_to_order,
tItem.point_of_entry,
tItem.type_of_lockng_system_required,
tItem.was_it_locked);
    }














    public class PanelTableDTO
    {
        public int RecID { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public string? knockedit { get; set; }
        public string? knocoledit { get; set; }
        public string? letteredit { get; set; }
        public string? letter_box_pos { get; set; }
        public string? wedit { get; set; }
        public string? hedit { get; set; }
        public string? typeedit { get; set; }
        public string? thickedit { get; set; }
        public string? backgedit { get; set; }
        public string? coledit { get; set; }
        public string? gltext { get; set; }
        public string? spaccoloedit { get; set; }
        public string? pet_flap { get; set; }
        public string? pet_type { get; set; }
        public int pet_magnetic { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public int no_of_vids { get; set; }
        public string? room_location { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public string? long_sptext { get; set; }
        public int upvc_item_number { get; set; }
        public int alum_item_number { get; set; }
        public string? parts_to_order { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
    }
}
