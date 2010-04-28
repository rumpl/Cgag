using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  public class Hack : Attribute
  {
    public string Value { get; set; }

    public Hack()
      : this("")
    { }

    public Hack(string value)
    {
      Value = value;
    }
  }
}