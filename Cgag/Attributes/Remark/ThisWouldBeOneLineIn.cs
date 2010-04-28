using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor | AttributeTargets.Delegate,
    AllowMultiple = true, Inherited = false)]
  public class ThisWouldBeOneLineIn : Attribute
  {
    public string Language { get; set; }
    public string ToWit { get; set; }
  }
}