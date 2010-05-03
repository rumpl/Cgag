using System;

namespace Cgag.Attributes.Disclaimer
{
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Delegate | AttributeTargets.Property)]
  public class PokemonExceptionHandling : Attribute
  {
    public string Value { get; set; }

    public PokemonExceptionHandling()
    { }

    public PokemonExceptionHandling(string value)
    {
      Value = value;
    }
  }
}
