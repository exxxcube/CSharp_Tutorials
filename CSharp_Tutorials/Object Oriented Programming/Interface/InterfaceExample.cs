using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace InterfaceExample
{
    #region This is an Interface
    public interface IRecordable
    {
        void TakeANote(string note);
    }
    #endregion
    ////abstract class ThingsThatRecord : IRecordable // The base class and also using an Interface
    ////{
    ////    abstract public void TakeANote(string note);
    ////}
    //class Pen : IRecordable// A subclass
    //{
    //    public void TakeANote(string note) // Interface method implementations
    //    {                                  // MUST be declared public.
    //        // ... scribble a note with a pen ...
    //    }
    //}
    //class PDA : IRecordable // Another subclass
    //{
    //    public void TakeANote(string note)
    //    {

    //    }
    //}
    //class LapTop : IRecordable // A third subclass
    //{
    //    public void TakeANote(string note)
    //    {

    //    }
    //    //void RecordTask(ThingsThatRecord recorder) // Parameter type is base class.
    //    //{
    //    //    // All classes that extend ThingsThatRecord have a TakeANote method.
    //    //    recorder.TakeANote("Shopping list");
    //    //    // ... and so on.
    //    //}
    //}
    public class Pen : IRecordable // Base class is Object.
    {
        public void TakeANote(string note)
        {
            // Record the note with a pen.
        }
    }
    public class PDA : IRecordable
    {
        public void TakeANote(string note)
        {
            // Record the note with a PDA.
        }
    }
    public class InterfaceExampleProg
    {
        public static void RecordShoppingList(IRecordable recorder)
        {
            // Jot it down, using whatever device was passed in.
            recorder.TakeANote("...");
        }
        // where CreateRecorder() is a method, often on the same class, that
        // returns not a reference to a Pen but, rather, an IRecordable reference:
        public static IRecordable CreateRecorder(string recorderType)
        {
            if (recorderType == "Pen")
                return new Pen();
            return null;
        }
        public static void InterfaceExampleMain()
        {
            PDA pda = new PDA();
            RecordShoppingList(pda);
            IRecordable recorder = null; // Yes, you can have interface-type variables.
            // Somewhere, maybe in my constructor, I call a factory method to deliver a
            // particular kind of IRecordable object:
            recorder = InterfaceExampleProg.CreateRecorder("Pen");
        }
    }
}
