using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Disclaimer
{
  [AttributeUsage(AttributeTargets.All)]
  public class AhaMoment : Attribute
  {
    public Where Value { get; set; }

    public AhaMoment()
    { }

    public AhaMoment(Where value)
    {
      Value = value;
    }
  }
}
