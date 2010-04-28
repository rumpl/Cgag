using System;

namespace Cgag.Attributes.Disclaimer
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
  public class IAmAwesome : Attribute
  {
    public string Value { get; set; }

    public IAmAwesome(string why)
    {
      Value = why;
    }
  }
}