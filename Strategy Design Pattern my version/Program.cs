using Strategy_Design_Pattern_my_version.Class;
using Strategy_Design_Pattern_my_version.Context;
using System;

namespace Strategy_Design_Pattern_my_version
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmContext armContext = new ArmContext();
            armContext.SetStrategy(new Class1());
            armContext.DoThrow();
            armContext.SetStrategy(new Class2());
            armContext.DoThrow();
            armContext.SetStrategy(new Class3());
            armContext.DoThrow();
        }
    }
}
