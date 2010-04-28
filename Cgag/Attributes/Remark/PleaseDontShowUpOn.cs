using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All)]
  class PleaseDontShowUpOn : Attribute
  {
    public Website Website { get; set; }

    public PleaseDontShowUpOn(Website website)
    {
      Website = website;
    }
  }
}