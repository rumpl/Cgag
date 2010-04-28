using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  public class LOL : Attribute
  {
    public string Value { get; set; }

    public LOL()
      : this("")
    { }

    public LOL(string value)
    {
      Value = value;
    }
  }
}