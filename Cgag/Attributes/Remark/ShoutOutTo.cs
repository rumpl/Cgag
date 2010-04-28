using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All)]
  public class ShoutOutTo : Attribute
  {
    public string Value { get; set; }

    public ShoutOutTo()
      : this("")
    {
    }

    public ShoutOutTo(string value)
    {
      Value = value;
    }
  }
}