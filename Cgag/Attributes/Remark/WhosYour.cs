using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All)]
  public class WhosYour : Attribute
  {
    public FamilyMember Value { get; set; }

    public WhosYour(FamilyMember familyMember)
    {
      Value = familyMember;
    }
  }
}