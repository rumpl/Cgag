using System;

namespace Cgag.Attributes.Disclaimer
{
  /// <summary>
  /// Discloses the condition the developer was in when writing the annotated code.
  /// </summary>
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  public class WrittenWhile : Attribute
  {
    public string Value { get; set; }

    public WrittenWhile(string value)
    {
      Value = value;
    }
  }
}