using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Machine
  {
    
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Machine type can't be left empty")]
    public string MachineName { get; set; }
    public string MachineModel {get; set;}    
    public string MachineDescription { get; set; }
    public List<MachineEngineer> JoinEntities {get;}
    
  }
}