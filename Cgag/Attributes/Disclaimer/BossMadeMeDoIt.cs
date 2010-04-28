using System;

namespace Cgag.Attributes.Disclaimer
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  class BossMadeMeDoIt : Attribute
  {
    public string Value { get; set; }

    public BossMadeMeDoIt()
      : this("")
    { }

    public BossMadeMeDoIt(string value)
    {
      Value = value;
    }
  }
}