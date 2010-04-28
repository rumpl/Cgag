using System;

namespace Cgag.Attributes.Team
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
  public class Blame : Attribute
  {
    public string Person { get; set; }
    public string Reason { get; set; }
  }
}