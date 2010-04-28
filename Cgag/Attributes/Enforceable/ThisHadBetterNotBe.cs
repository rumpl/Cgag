using System;

namespace Cgag.Attributes.Enforceable
{
  [AttributeUsage(AttributeTargets.Parameter)]
  public class ThisHadBetterNotBe : Attribute
  {
    public object Value { get; set; }
  }
}