using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
  public class Magic : Attribute
  {
    public MagicType Type { get; set; }

    public Magic()
    {
      Type = MagicType.BLACK;
    }

    public Magic(MagicType type)
    {
      Type = type;
    }
  }
}