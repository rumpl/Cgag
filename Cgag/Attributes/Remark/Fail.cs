using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.Assembly)]
  public class Fail : Attribute
  {
    public Outcome Value { get; set; }

    public Fail()
    {
      Value = Outcome.EPIC;
    }
  }
}