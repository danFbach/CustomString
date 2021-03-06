﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class Program
    {
        static void Main(string[] args)
        {
            //SystemString systemstring = new SystemString();
            ///systemstring.Length();
            ///systemstring.Insert("cacaca", 2);
            ///systemstring.Remove(4, 3);

            //SystemArrayString systemarraystring = new SystemArrayString();
            ///systemarraystring.Insert("apples", 0);
            ///systemarraystring.Length();
            ///systemarraystring.Remove(2, 3);

            //SystemLinkedListString systemlinkedliststring = new SystemLinkedListString();
            ///systemlinkedliststring.Insert("spughettos", 2);
            ///systemlinkedliststring.Length();
            ///systemlinkedliststring.Remove(2, 3);

            //CustomLinkedListString customLinkedListString = new CustomLinkedListString();
            ///customLinkedListString.Insert("spughettos", 4);
            ///customLinkedListString.Length();
            ///customLinkedListString.Remove(2, 3);
            Console.ReadKey();
        }
    }
}
//Create a custom string structure:
//    Create an ICustomString interface with the following custom functions:
//       - string ToString()
//       - void Insert(string stringToInsert)
//       - void Remove(int startIndex, int numCharsToRemove)
//       - int Length()
//    Inherit from the ICustomString interface to implement the following custom string subclasses:
//      -  SystemString
//            Underlying structure: System.string
//            Piggyback off System.string's built-in functionality to implement ICustomString's functions
//      -  SystemArrayString
//            Underlying structure: System.array
//            Each index of the underlying array holds one character
//      -  SystemLinkedListString
//            Underlying structure: System.Collections.Generic.LinkedList
//            Each node of the underlying C# LinkedList holds one character
//      -  CustomLinkedListString
//            Underlying structure: your own custom linked list
//            Each node of the underlying custom linked list structure holds one character
//  Create a System.Collections.SortedList, SortedList<ICustomString> sortedStringList, sorted by the length of each string element, populated by a mix of each of the ICustomString subclasses

//  Using a Systems.Collections.Generic.Dictionary as an underlying structure, create a Sweepstakes class with the following functions(you will need to define a Contestant class containing appropriate fields for the purpose):
//    Sweepstakes(string name)
//    void RegisterContestant(Contestant contestant)
//    string PickWinner()
//    void PrintContestantInfo(Contestant contestant)
//Create a sweepstakes management system:
//    Write an ISweepstakesManager interface with the following custom functions:
//        void InsertSweepstakes(Sweepstakes sweepstakes)
//        Sweepstakes GetNextSweepstakesWinner()
//    Inherit from the ISweepstakesManager interface to implement the following subclasses:
//        SweepstakesStackManager(using System.Collections.Generic.Stack)
//        SweepstakesQueueManager(using System.Collections.Generic.Queue)