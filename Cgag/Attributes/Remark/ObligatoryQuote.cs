using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
  public class ObligatoryQuote : Attribute
  {
    public string Quote { get; set; }
    public string Source { get; set; }
    public string Citation { get; set; }
    public string Other { get; set; }
  }
}