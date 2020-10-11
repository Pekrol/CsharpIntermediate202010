using System;
using System.Collections.Generic;
using System.Text;

namespace TestRunner.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Field)]
    public class TestMethodAttribute : Attribute
    {
    }
}
