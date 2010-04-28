using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  public class WTF : Attribute
  {
    public string Value { get; set; }

    public WTF()
      : this("")
    { }

    public WTF(string value)
    {
      Value = value;
    }
  }
}