using System;

namespace Cgag.Attributes.Disclaimer
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
  public class LegacySucks : Attribute
  {
    public string Value { get; set; }

    public LegacySucks()
    { }

    public LegacySucks(string value)
    {
      Value = value;
    }
  }
}