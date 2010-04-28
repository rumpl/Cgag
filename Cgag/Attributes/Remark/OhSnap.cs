using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  class OhSnap : Attribute
  {
    public string Value { get; set; }

    public OhSnap()
      : this("")
    { }

    public OhSnap(string value)
    {
      Value = value;
    }
  }
}