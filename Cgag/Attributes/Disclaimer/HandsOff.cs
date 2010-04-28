using System;
using Cgag.Enumeration;

namespace Cgag.Attributes.Disclaimer
{
  [AttributeUsage(AttributeTargets.All)]
  public class HandsOff : Attribute
  {
    public string ByOrderOf { get; set; }
    public Consequence OnPainOf { get; set; }
  }
}