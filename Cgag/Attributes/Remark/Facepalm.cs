using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  public class Facepalm : Attribute
  {
    public string Value { get; set; }

    public Facepalm()
      : this("")
    { }

    public Facepalm(string value)
    {
      Value = value;
    }
  }
}