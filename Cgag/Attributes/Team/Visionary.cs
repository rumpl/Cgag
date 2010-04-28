using System;

namespace Cgag.Attributes.Team
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  public class Visionary : Attribute
  {
    public string Value { get; set; }
    public Visionary(string value)
    {
      Value = value;
    }
  }
}