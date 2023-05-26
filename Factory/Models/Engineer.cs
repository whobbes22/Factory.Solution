using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId {get;set;}
    [Required(ErrorMessage = "The Enginners Name is unable to be left blank")]
    public string EngineerName {get;set;}
    public string EngineerDescription {get;set;}

    public List<MachineEngineer> JoinEntities {get;}
  }
}