using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class GarageTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int opening_direction { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public int door_fits_into { get; set; }
        public int new_subframe_req { get; set; }
        public int obstruction_outside_b { get; set; }
        public string? obstruction_outside { get; set; }
        public int obstruction_inside_b { get; set; }
        public string? obstruction_inside { get; set; }
        public string? actual_door_width { get; set; }
        public string? actual_door_height { get; set; }
        public int frame_fix_type { get; set; }
        public string? type_of_garage { get; set; }
        public string? new_electric_operator_req { get; set; }
        public string? side_size_A { get; set; }
        public string? side_size_B { get; set; }
        public string? side_size_C { get; set; }
        public string? side_size_D { get; set; }
        public string? side_size_E { get; set; }
        public string? side_size_F { get; set; }
        public string? side_size_G { get; set; }
        public string? side_timber_1 { get; set; }
        public string? side_timber_2 { get; set; }
        public string? plan_size_A { get; set; }
        public string? plan_size_B { get; set; }
        public string? plan_size_C1 { get; set; }
        public string? plan_size_C2 { get; set; }
        public string? plan_size_D { get; set; }
        public string? plan_timber_1 { get; set; }
        public string? plan_timber_2 { get; set; }
        public string? color { get; set; }
        public string? opening_type { get; set; }
        public string? finish { get; set; }
        public int power_points { get; set; }
        public int electric_door { get; set; }
        public int handle_outside { get; set; }
        public int other_access { get; set; }
        public int need_safety_release { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public int insulated { get; set; }
        public int door_stuck_shut { get; set; }
        public int motor_position { get; set; }
        public int no_of_vids { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public string? long_comments { get; set; }
        public int isComplete { get; set; }
        public int door_within_perimeter { get; set; }
        public int socket_within_1m { get; set; }
        public string? wire_type { get; set; }
        public int colour_match_roll_box { get; set; }
        public bool additional_drawn { get; set; }
        public string? roller_door_type { get; set; }
        public string? roller_box_type { get; set; }
        public string? parts_to_order { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public string? where_is_garage { get; set; }

        GarageTable() { }
        GarageTable(GarageTableDTO tItem) =>
        (HeaderId,
 udi_cont,
 item_number,
 opening_direction,
 cause_of_damage,
 cause_of_damage_reason_different,
 door_fits_into,
 new_subframe_req,
 obstruction_outside_b,
 obstruction_outside,
 obstruction_inside_b,
 obstruction_inside,
 actual_door_width,
 actual_door_height,
 frame_fix_type,
 type_of_garage,
 new_electric_operator_req,
 side_size_A,
 side_size_B,
 side_size_C,
 side_size_D,
 side_size_E,
 side_size_F,
 side_size_G,
 side_timber_1,
 side_timber_2,
 plan_size_A,
 plan_size_B,
 plan_size_C1,
 plan_size_C2,
 plan_size_D,
 plan_timber_1,
 plan_timber_2,
 color,
 opening_type,
 finish,
 power_points,
 electric_door,
 handle_outside,
 other_access,
 need_safety_release,
 no_of_pics,
 no_of_photos,
 insulated,
 door_stuck_shut,
 motor_position,
 no_of_vids,
 bDifferentFromOriginal,
 ChangeItemTo,
 print_name,
 long_comments,
 isComplete,
 door_within_perimeter,
 socket_within_1m,
 wire_type,
 colour_match_roll_box,
 additional_drawn,
 roller_door_type,
 roller_box_type,
 parts_to_order,
 point_of_entry,
 type_of_lockng_system_required,
 was_it_locked,
 where_is_garage) = 
(tItem.RecID,
tItem.udi_cont,
tItem.item_number,
tItem.opening_direction,
tItem.cause_of_damage,
tItem.cause_of_damage_reason_different,
tItem.door_fits_into,
tItem.new_subframe_req,
tItem.obstruction_outside_b,
tItem.obstruction_outside,
tItem.obstruction_inside_b,
tItem.obstruction_inside,
tItem.actual_door_width,
tItem.actual_door_height,
tItem.frame_fix_type,
tItem.type_of_garage,
tItem.new_electric_operator_req,
tItem.side_size_A,
tItem.side_size_B,
tItem.side_size_C,
tItem.side_size_D,
tItem.side_size_E,
tItem.side_size_F,
tItem.side_size_G,
tItem.side_timber_1,
tItem.side_timber_2,
tItem.plan_size_A,
tItem.plan_size_B,
tItem.plan_size_C1,
tItem.plan_size_C2,
tItem.plan_size_D,
tItem.plan_timber_1,
tItem.plan_timber_2,
tItem.color,
tItem.opening_type,
tItem.finish,
tItem.power_points,
tItem.electric_door,
tItem.handle_outside,
tItem.other_access,
tItem.need_safety_release,
tItem.no_of_pics,
tItem.no_of_photos,
tItem.insulated,
tItem.door_stuck_shut,
tItem.motor_position,
tItem.no_of_vids,
tItem.bDifferentFromOriginal,
tItem.ChangeItemTo,
tItem.print_name,
tItem.long_comments,
tItem.isComplete,
tItem.door_within_perimeter,
tItem.socket_within_1m,
tItem.wire_type,
tItem.colour_match_roll_box,
tItem.additional_drawn,
tItem.roller_door_type,
tItem.roller_box_type,
tItem.parts_to_order,
tItem.point_of_entry,
tItem.type_of_lockng_system_required,
tItem.was_it_locked,
tItem.where_is_garage);
    }










    public class GarageTableDTO
    {
        public int RecID { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int opening_direction { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public int door_fits_into { get; set; }
        public int new_subframe_req { get; set; }
        public int obstruction_outside_b { get; set; }
        public string? obstruction_outside { get; set; }
        public int obstruction_inside_b { get; set; }
        public string? obstruction_inside { get; set; }
        public string? actual_door_width { get; set; }
        public string? actual_door_height { get; set; }
        public int frame_fix_type { get; set; }
        public string? type_of_garage { get; set; }
        public string? new_electric_operator_req { get; set; }
        public string? side_size_A { get; set; }
        public string? side_size_B { get; set; }
        public string? side_size_C { get; set; }
        public string? side_size_D { get; set; }
        public string? side_size_E { get; set; }
        public string? side_size_F { get; set; }
        public string? side_size_G { get; set; }
        public string? side_timber_1 { get; set; }
        public string? side_timber_2 { get; set; }
        public string? plan_size_A { get; set; }
        public string? plan_size_B { get; set; }
        public string? plan_size_C1 { get; set; }
        public string? plan_size_C2 { get; set; }
        public string? plan_size_D { get; set; }
        public string? plan_timber_1 { get; set; }
        public string? plan_timber_2 { get; set; }
        public string? color { get; set; }
        public string? opening_type { get; set; }
        public string? finish { get; set; }
        public int power_points { get; set; }
        public int electric_door { get; set; }
        public int handle_outside { get; set; }
        public int other_access { get; set; }
        public int need_safety_release { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public int insulated { get; set; }
        public int door_stuck_shut { get; set; }
        public int motor_position { get; set; }
        public int no_of_vids { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public string? long_comments { get; set; }
        public int isComplete { get; set; }
        public int door_within_perimeter { get; set; }
        public int socket_within_1m { get; set; }
        public string? wire_type { get; set; }
        public int colour_match_roll_box { get; set; }
        public bool additional_drawn { get; set; }
        public string? roller_door_type { get; set; }
        public string? roller_box_type { get; set; }
        public string? parts_to_order { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public string? where_is_garage { get; set; }
    }

}
