using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace RobozillaTechnique_Hidding_Methods_Using_Interface
{
    #region Hiding some methods using interface
    // using an interface to only view the required methods to the client
    public interface IRobozillaSafe
    {
        void ClimbStairs(); // Safe
        void PetTheRobodog(); // Safe? Might break it.
    }
    public class Robozilla : IRobozillaSafe
    {
        public static IRobozillaSafe Create()
        {
            return (IRobozillaSafe)new Robozilla();
        }
        public void Charge() // Maybe not safe
        { }
        public void SearchAndDestroy() // Dangerous
        { }
        public void LaunchGlobalThermonuclearWar() // Catastrophic
        { }
        public void ClimbStairs()
        { }
        public void PetTheRobodog()
        { }
    }
    class Prog
    {
        public static void Test()
        {
            IRobozillaSafe a = Robozilla.Create();
            a.PetTheRobodog();
        }
    }
    #endregion
    #region Another Example
    public interface IOther
    {
        void One();
        void Two();
    }
    class A : IOther
    {
        public static IOther Create()
        {
            return (IOther)new A();
        }
        public void One()
        { }
        public void Two()
        { }
        public void Three()
        { }
    }
    class B
    {
        public static void Name()
        {
            A test = new A();
            //test.
        }
    }
    #endregion

}
