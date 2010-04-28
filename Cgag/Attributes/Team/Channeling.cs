using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Team
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
  public class Channeling : Attribute
  {
    public ChannelingEntity Entity { get; set; }
    public OpinionOfHumanity Disposition { get; set; }
  }
}