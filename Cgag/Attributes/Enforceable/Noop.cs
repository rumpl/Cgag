using System;

namespace Cgag.Attributes.Enforceable
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
  public class Noop : Attribute
  {
  }
}