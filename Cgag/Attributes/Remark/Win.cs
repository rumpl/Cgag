using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.Assembly)]
  public class Win : Attribute
  {
    public Outcome Value { get; set; }

    public Win()
    {
      Value = Outcome.EPIC;
    }
  }
}