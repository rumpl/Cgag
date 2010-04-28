using System;

namespace Cgag.Attributes.Remark
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
  class OhNoYouDidnt : Attribute
  {
    private int _fingerSnapCount = 3;
    public int FingerSnapCount
    {
      get { return _fingerSnapCount; }
      set { _fingerSnapCount = value; }
    }
  }
}