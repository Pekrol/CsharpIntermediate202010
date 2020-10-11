using System;
using System.Collections.Generic;
using System.Text;

namespace TestRunner.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TestParamsAttribute : Attribute
    {
        public TestParamsAttribute(params object[] parameters)
        {

        }
    }
}
