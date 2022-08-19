using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class BifoldTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public string? ernal_width { get; set; }
        public string? ernal_height { get; set; }
        public string? overall_width { get; set; }
        public string? overall_height { get; set; }
        public int opens { get; set; }
        public int trickle_vents { get; set; }
        public string? hardware { get; set; }
        public string? color_ernal { get; set; }
        public string? color_external { get; set; }
        public string? threshold_type { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public int no_of_vids { get; set; }
        public int isComplete { get; set; }
        public string? comments { get; set; }
        public int bifold_signed { get; set; }
        public int number_of_doors { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public string? door_type { get; set; }
        public string? glazing_options { get; set; }
        public string? number_of_doors_text { get; set; }
        public string? colour_of_doors { get; set; }
        public string? handle_colour { get; set; }
        public string? cill_type { get; set; }
        public string? knock_on { get; set; }
        public string? ernal_door_colour { get; set; }
        public string? s_spare12 { get; set; }
        public string? parts_to_order { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public int point_of_entry { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? pr_name { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public bool glass_complete { get; set; }
        public int replace_glass { get; set; }
        public string? reason_not_repaired { get; set; }
        public bool bRepair { get; set; }
        public bool fensa { get; set; }
        public string? WER_rating { get; set; }
        public int gaskets { get; set; }
        public string? gaskets_text { get; set; }
        public int handles_req { get; set; }
        public bool bHandleDrawingComplete { get; set; }
        public string? handles_text { get; set; }
        public int addons { get; set; }
        public string? addon_width { get; set; }
        public string? addon_height { get; set; }

        BifoldTable() { }
        BifoldTable (BifoldTableDTO tItem) =>
        (HeaderId,
        udi_cont,
        item_number,
        ernal_width,
        ernal_height,
        overall_width,
        overall_height,
        opens,
        trickle_vents,
        hardware,
        color_ernal,
        color_external,
        threshold_type,
        no_of_pics,
        no_of_photos,
        no_of_vids,
        isComplete,
        comments,
        bifold_signed,
        number_of_doors,
        cause_of_damage,
        cause_of_damage_reason_different,
        door_type,
        glazing_options,
        number_of_doors_text,
        colour_of_doors,
        handle_colour,
        cill_type,
        knock_on,
        ernal_door_colour,
        s_spare12,
        parts_to_order,
        type_of_lockng_system_required,
        was_it_locked,
        point_of_entry,
        ChangeItemTo,
        pr_name,
        bDifferentFromOriginal,
        glass_complete,
        replace_glass,
        reason_not_repaired,
        bRepair,
        fensa,
        WER_rating,
        gaskets,
        gaskets_text,
        handles_req,
        bHandleDrawingComplete,
        handles_text,
        addons,
        addon_width,
        addon_height) =

        (tItem.RecID,
        tItem.udi_cont,
        tItem.item_number,
        tItem.ernal_width,
        tItem.ernal_height,
        tItem.overall_width,
        tItem.overall_height,
        tItem.opens,
        tItem.trickle_vents,
        tItem.hardware,
        tItem.color_ernal,
        tItem.color_external,
        tItem.threshold_type,
        tItem.no_of_pics,
        tItem.no_of_photos,
        tItem.no_of_vids,
        tItem.isComplete,
        tItem.comments,
        tItem.bifold_signed,
        tItem.number_of_doors,
        tItem.cause_of_damage,
        tItem.cause_of_damage_reason_different,
        tItem.door_type,
        tItem.glazing_options,
        tItem.number_of_doors_text,
        tItem.colour_of_doors,
        tItem.handle_colour,
        tItem.cill_type,
        tItem.knock_on,
        tItem.ernal_door_colour,
        tItem.s_spare12,
        tItem.parts_to_order,
        tItem.type_of_lockng_system_required,
        tItem.was_it_locked,
        tItem.point_of_entry,
        tItem.ChangeItemTo,
        tItem.pr_name,
        tItem.bDifferentFromOriginal,
        tItem.glass_complete,
        tItem.replace_glass,
        tItem.reason_not_repaired,
        tItem.bRepair,
        tItem.fensa,
        tItem.WER_rating,
        tItem.gaskets,
        tItem.gaskets_text,
        tItem.handles_req,
        tItem.bHandleDrawingComplete,
        tItem.handles_text,
        tItem.addons,
        tItem.addon_width,
        tItem.addon_height);

    }


    public class BifoldTableDTO
    {
        public int RecID { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public string? ernal_width { get; set; }
        public string? ernal_height { get; set; }
        public string? overall_width { get; set; }
        public string? overall_height { get; set; }
        public int opens { get; set; }
        public int trickle_vents { get; set; }
        public string? hardware { get; set; }
        public string? color_ernal { get; set; }
        public string? color_external { get; set; }
        public string? threshold_type { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public int no_of_vids { get; set; }
        public int isComplete { get; set; }
        public string? comments { get; set; }
        public int bifold_signed { get; set; }
        public int number_of_doors { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public string? door_type { get; set; }
        public string? glazing_options { get; set; }
        public string? number_of_doors_text { get; set; }
        public string? colour_of_doors { get; set; }
        public string? handle_colour { get; set; }
        public string? cill_type { get; set; }
        public string? knock_on { get; set; }
        public string? ernal_door_colour { get; set; }
        public string? s_spare12 { get; set; }
        public string? parts_to_order { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public int point_of_entry { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? pr_name { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public bool glass_complete { get; set; }
        public int replace_glass { get; set; }
        public string? reason_not_repaired { get; set; }
        public bool bRepair { get; set; }
        public bool fensa { get; set; }
        public string? WER_rating { get; set; }
        public int gaskets { get; set; }
        public string? gaskets_text { get; set; }
        public int handles_req { get; set; }
        public bool bHandleDrawingComplete { get; set; }
        public string? handles_text { get; set; }
        public int addons { get; set; }
        public string? addon_width { get; set; }
        public string? addon_height { get; set; }

    }
}
