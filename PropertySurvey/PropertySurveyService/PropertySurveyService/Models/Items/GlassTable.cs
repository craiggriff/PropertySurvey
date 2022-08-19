using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class GlassTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public int units_required { get; set; }
        public string? glass_width { get; set; }
        public string? glass_height { get; set; }
        public string? glass_width2 { get; set; }
        public string? glass_height2 { get; set; }
        public string? glass_width3 { get; set; }
        public string? glass_height3 { get; set; }
        public string? glass_width4 { get; set; }
        public string? glass_height4 { get; set; }
        public string? glass_width5 { get; set; }
        public string? glass_height5 { get; set; }
        public string? glass_width6 { get; set; }
        public string? glass_height6 { get; set; }
        public string? glass_width7 { get; set; }
        public string? glass_height7 { get; set; }
        public string? glass_width8 { get; set; }
        public string? glass_height8 { get; set; }
        public int stepped_unit { get; set; }
        public string? int_width { get; set; }
        public string? int_height { get; set; }
        public int single_or_double { get; set; }
        public string? glass_type { get; set; }
        public string? sizeA { get; set; }
        public string? sizeB { get; set; }
        public string? sizeC { get; set; }
        public string? sizeD { get; set; }
        public string? lead_CWidth { get; set; }
        public string? lead_CHeight { get; set; }
        public int lead_anti_rattle { get; set; }
        public string? lead_thickness { get; set; }
        public string? lead_sod { get; set; }
        public string? lead_type { get; set; }
        public bool lead_bDiamondComplete { get; set; }
        public bool lead_bGeorgianComplete { get; set; }
        public bool lead_bBarComplete { get; set; }
        public string? glass_pattern { get; set; }
        public string? spacer_color { get; set; }
        public string? spacer_thickness { get; set; }
        public string? special_glass { get; set; }
        public int no_of_pics { get; set; }
        public string? docl_old { get; set; }
        public int no_of_photos { get; set; }
        public int gb_trim { get; set; }
        public string? docl { get; set; }
        public string? room_location { get; set; }
        public int no_of_vids { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public string? ProductInto { get; set; }
        public string? glazing_type { get; set; }
        public string? long_comments { get; set; }
        public float lead_posX { get; set; }
        public float lead_posY { get; set; }
        public string? TapeorGasket { get; set; }
        public int glaze { get; set; }
        public string? lead_comments { get; set; }
        public int collect_and_copy { get; set; }
        public int temporary { get; set; }
        public string? parts_to_order { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public string? back_to_back_spacer_width { get; set; }
        public string? back_to_back_spacer_height { get; set; }
        public float lead_CWidthf { get; set; }
        public float lead_CHeightf { get; set; }
        public float sizeAf { get; set; }
        public float sizeBf { get; set; }
        public float sizeCf { get; set; }
        public float sizeDf { get; set; }
        public string? lead_CWidths { get; set; }
        public string? lead_CHeights { get; set; }
        public int parent_item { get; set; }

        GlassTable() { }
        GlassTable(GlassTableDTO tItem) =>
        (HeaderId,
 udi_cont,
 item_number,
 isComplete,
 cause_of_damage,
 cause_of_damage_reason_different,
 units_required,
 glass_width,
 glass_height,
 glass_width2,
 glass_height2,
 glass_width3,
 glass_height3,
 glass_width4,
 glass_height4,
 glass_width5,
 glass_height5,
 glass_width6,
 glass_height6,
 glass_width7,
 glass_height7,
 glass_width8,
 glass_height8,
 stepped_unit,
 int_width,
 int_height,
 single_or_double,
 glass_type,
 sizeA,
 sizeB,
 sizeC,
 sizeD,
 lead_CWidth,
 lead_CHeight,
 lead_anti_rattle,
 lead_thickness,
 lead_sod,
 lead_type,
 lead_bDiamondComplete,
 lead_bGeorgianComplete,
 lead_bBarComplete,
 glass_pattern,
 spacer_color,
 spacer_thickness,
 special_glass,
 no_of_pics,
 docl_old,
 no_of_photos,
 gb_trim,
 docl,
 room_location,
 no_of_vids,
 bDifferentFromOriginal,
 ChangeItemTo,
 print_name,
 ProductInto,
 glazing_type,
 long_comments,
 lead_posX,
 lead_posY,
 TapeorGasket,
 glaze,
 lead_comments,
 collect_and_copy,
 temporary,
 parts_to_order,
 point_of_entry,
 type_of_lockng_system_required,
 was_it_locked,
 back_to_back_spacer_width,
 back_to_back_spacer_height,
 lead_CWidthf,
 lead_CHeightf,
 sizeAf,
 sizeBf,
 sizeCf,
 sizeDf,
 lead_CWidths,
 lead_CHeights,
 parent_item) =
            (tItem.RecID,
tItem.udi_cont,
tItem.item_number,
tItem.isComplete,
tItem.cause_of_damage,
tItem.cause_of_damage_reason_different,
tItem.units_required,
tItem.glass_width,
tItem.glass_height,
tItem.glass_width2,
tItem.glass_height2,
tItem.glass_width3,
tItem.glass_height3,
tItem.glass_width4,
tItem.glass_height4,
tItem.glass_width5,
tItem.glass_height5,
tItem.glass_width6,
tItem.glass_height6,
tItem.glass_width7,
tItem.glass_height7,
tItem.glass_width8,
tItem.glass_height8,
tItem.stepped_unit,
tItem.int_width,
tItem.int_height,
tItem.single_or_double,
tItem.glass_type,
tItem.sizeA,
tItem.sizeB,
tItem.sizeC,
tItem.sizeD,
tItem.lead_CWidth,
tItem.lead_CHeight,
tItem.lead_anti_rattle,
tItem.lead_thickness,
tItem.lead_sod,
tItem.lead_type,
tItem.lead_bDiamondComplete,
tItem.lead_bGeorgianComplete,
tItem.lead_bBarComplete,
tItem.glass_pattern,
tItem.spacer_color,
tItem.spacer_thickness,
tItem.special_glass,
tItem.no_of_pics,
tItem.docl_old,
tItem.no_of_photos,
tItem.gb_trim,
tItem.docl,
tItem.room_location,
tItem.no_of_vids,
tItem.bDifferentFromOriginal,
tItem.ChangeItemTo,
tItem.print_name,
tItem.ProductInto,
tItem.glazing_type,
tItem.long_comments,
tItem.lead_posX,
tItem.lead_posY,
tItem.TapeorGasket,
tItem.glaze,
tItem.lead_comments,
tItem.collect_and_copy,
tItem.temporary,
tItem.parts_to_order,
tItem.point_of_entry,
tItem.type_of_lockng_system_required,
tItem.was_it_locked,
tItem.back_to_back_spacer_width,
tItem.back_to_back_spacer_height,
tItem.lead_CWidthf,
tItem.lead_CHeightf,
tItem.sizeAf,
tItem.sizeBf,
tItem.sizeCf,
tItem.sizeDf,
tItem.lead_CWidths,
tItem.lead_CHeights,
tItem.parent_item);
    }





    public class GlassTableDTO
    {
        public int RecID { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public int units_required { get; set; }
        public string? glass_width { get; set; }
        public string? glass_height { get; set; }
        public string? glass_width2 { get; set; }
        public string? glass_height2 { get; set; }
        public string? glass_width3 { get; set; }
        public string? glass_height3 { get; set; }
        public string? glass_width4 { get; set; }
        public string? glass_height4 { get; set; }
        public string? glass_width5 { get; set; }
        public string? glass_height5 { get; set; }
        public string? glass_width6 { get; set; }
        public string? glass_height6 { get; set; }
        public string? glass_width7 { get; set; }
        public string? glass_height7 { get; set; }
        public string? glass_width8 { get; set; }
        public string? glass_height8 { get; set; }
        public int stepped_unit { get; set; }
        public string? int_width { get; set; }
        public string? int_height { get; set; }
        public int single_or_double { get; set; }
        public string? glass_type { get; set; }
        public string? sizeA { get; set; }
        public string? sizeB { get; set; }
        public string? sizeC { get; set; }
        public string? sizeD { get; set; }
        public string? lead_CWidth { get; set; }
        public string? lead_CHeight { get; set; }
        public int lead_anti_rattle { get; set; }
        public string? lead_thickness { get; set; }
        public string? lead_sod { get; set; }
        public string? lead_type { get; set; }
        public bool lead_bDiamondComplete { get; set; }
        public bool lead_bGeorgianComplete { get; set; }
        public bool lead_bBarComplete { get; set; }
        public string? glass_pattern { get; set; }
        public string? spacer_color { get; set; }
        public string? spacer_thickness { get; set; }
        public string? special_glass { get; set; }
        public int no_of_pics { get; set; }
        public string? docl_old { get; set; }
        public int no_of_photos { get; set; }
        public int gb_trim { get; set; }
        public string? docl { get; set; }
        public string? room_location { get; set; }
        public int no_of_vids { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public string? ProductInto { get; set; }
        public string? glazing_type { get; set; }
        public string? long_comments { get; set; }
        public float lead_posX { get; set; }
        public float lead_posY { get; set; }
        public string? TapeorGasket { get; set; }
        public int glaze { get; set; }
        public string? lead_comments { get; set; }
        public int collect_and_copy { get; set; }
        public int temporary { get; set; }
        public string? parts_to_order { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public string? back_to_back_spacer_width { get; set; }
        public string? back_to_back_spacer_height { get; set; }
        public float lead_CWidthf { get; set; }
        public float lead_CHeightf { get; set; }
        public float sizeAf { get; set; }
        public float sizeBf { get; set; }
        public float sizeCf { get; set; }
        public float sizeDf { get; set; }
        public string? lead_CWidths { get; set; }
        public string? lead_CHeights { get; set; }
        public int parent_item { get; set; }
    }

}
