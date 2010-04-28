using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Disclaimer
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
  public class CarbonFootprint : Attribute
  {
    public double Value { get; set; }
    public CO2Units Units { get; set; }
  }
}