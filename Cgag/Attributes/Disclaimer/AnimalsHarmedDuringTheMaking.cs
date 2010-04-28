using System;

namespace Cgag.Attributes.Disclaimer
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
  public class AnimalsHarmedDuringTheMaking : Attribute
  {
    public int Number { get; set;}
    public string Animal { get; set; }
    public string Disclosure { get; set; }
  }
}