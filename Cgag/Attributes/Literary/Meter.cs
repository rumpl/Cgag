using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Literary
{
  [AttributeUsage(AttributeTargets.All)]
  public class Meter : Attribute
  {
    public Feet Feet { get; set; }
    public Measure Measure { get; set; }

    public Meter()
    {
      Measure = Measure.UNSPECIFIED;
    }
  }
}