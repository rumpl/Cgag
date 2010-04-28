using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  public class Doh : Attribute
  {
    public string Value { get; set; }

    public Doh()
      : this("")
    { }

    public Doh(string value)
    {
      Value = value;
    }
  }
}