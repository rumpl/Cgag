using System;

namespace Cgag.Attributes.Team
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
  public class HonorableMention : Attribute
  {
    public string GoesTo { get; set; }
  }
}