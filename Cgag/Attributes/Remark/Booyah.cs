using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  public class Booyah : Attribute
  {
    public string Value { get; set; }

    public Booyah() : this("")
    {}

    public Booyah(string value)
    {
      Value = value;
    }
  }
}