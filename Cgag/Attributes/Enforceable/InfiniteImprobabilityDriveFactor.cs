using System;

namespace Cgag.Attributes.Enforceable
{
  [AttributeUsage(AttributeTargets.Method)]
  public class InfiniteImprobabilityDriveFactor : Attribute
  {
    public int Base { get; set; }
    public double Power { get; set; }
  }
}