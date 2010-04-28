using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Disclaimer
{
  [AttributeUsage(AttributeTargets.All)]
  public class SafeForSpeedsNotExceeding : Attribute
  {
    public double Value { get; set; }
    public SpeedUnits Units { get; set; }
  }
}