using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
  class RTFM : Attribute
  {
    public string Here { get; set; }

    public RTFM()
      : this("")
    {
    }

    public RTFM(string here)
    {
      Here = here;
    }
  }
}