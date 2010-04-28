using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Disclaimer
{
  [AttributeUsage(AttributeTargets.All)]
  public class ProbablyIllegalIn : Attribute
  {
    public int Number { get; set; }
    public RegionType Region { get; set; }
  }
}