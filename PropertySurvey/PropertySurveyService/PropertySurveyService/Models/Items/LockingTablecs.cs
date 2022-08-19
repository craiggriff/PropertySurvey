using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class LockingTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
        public string? comments { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public bool bMulti { get; set; }
        public string? item { get; set; }// multi choice drop down
        public string? locking_make { get; set; }
        public string? locking_codes { get; set; }
        public bool bDoorComplete { get; set; }
        public bool bWindowComplete { get; set; }
        public string? lock_colour { get; set; }
        public string? pagenum { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public string? COD_Code { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public int GearBox { get; set; }
        public int no_of_vids { get; set; }
        public int left_bolt { get; set; }
        public int right_bolt { get; set; }
        public string? parts_to_order { get; set; }
        public bool bLockComplete { get; set; }
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
        public string? long_comments { get; set; }

        LockingTable() { }
        LockingTable(LockingTableDTO tItem) =>
        (HeaderId,
 udi_cont,
 item_number,
 isComplete,
 comments,
 point_of_entry,
 type_of_lockng_system_required,
 was_it_locked,
 no_of_pics,
 no_of_photos,
 bMulti,
 item,
 locking_make,
 locking_codes,
 bDoorComplete,
 bWindowComplete,
 lock_colour,
 pagenum,
 bDifferentFromOriginal,
 ChangeItemTo,
 print_name,
 COD_Code,
 cause_of_damage,
 cause_of_damage_reason_different,
 GearBox,
 no_of_vids,
 left_bolt,
 right_bolt,
 parts_to_order,
 bLockComplete,
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
 long_comments) =
            (tItem.RecID,
tItem.udi_cont,
tItem.item_number,
tItem.isComplete,
tItem.comments,
tItem.point_of_entry,
tItem.type_of_lockng_system_required,
tItem.was_it_locked,
tItem.no_of_pics,
tItem.no_of_photos,
tItem.bMulti,
tItem.item,
tItem.locking_make,
tItem.locking_codes,
tItem.bDoorComplete,
tItem.bWindowComplete,
tItem.lock_colour,
tItem.pagenum,
tItem.bDifferentFromOriginal,
tItem.ChangeItemTo,
tItem.print_name,
tItem.COD_Code,
tItem.cause_of_damage,
tItem.cause_of_damage_reason_different,
tItem.GearBox,
tItem.no_of_vids,
tItem.left_bolt,
tItem.right_bolt,
tItem.parts_to_order,
tItem.bLockComplete,
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
tItem.long_comments);

    }


    public class LockingTableDTO
    {
        public int RecID { get; set; }
        public string? udi_cont { get; set; }
        public int item_number { get; set; }
        public int isComplete { get; set; }
        public string? comments { get; set; }
        public string? point_of_entry { get; set; }
        public string? type_of_lockng_system_required { get; set; }
        public int was_it_locked { get; set; }
        public int no_of_pics { get; set; }
        public int no_of_photos { get; set; }
        public bool bMulti { get; set; }
        public string? item { get; set; }// multi choice drop down
        public string? locking_make { get; set; }
        public string? locking_codes { get; set; }
        public bool bDoorComplete { get; set; }
        public bool bWindowComplete { get; set; }
        public string? lock_colour { get; set; }
        public string? pagenum { get; set; }
        public bool bDifferentFromOriginal { get; set; }
        public string? ChangeItemTo { get; set; }
        public string? print_name { get; set; }
        public string? COD_Code { get; set; }
        public string? cause_of_damage { get; set; }
        public string? cause_of_damage_reason_different { get; set; }
        public int GearBox { get; set; }
        public int no_of_vids { get; set; }
        public int left_bolt { get; set; }
        public int right_bolt { get; set; }
        public string? parts_to_order { get; set; }
        public bool bLockComplete { get; set; }
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
        public string? long_comments { get; set; }
    }
}
