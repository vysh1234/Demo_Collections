using System;
using System.Collections.Generic;
using System.Collections;

namespace Demo_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //step1: Creating object of the class(defining collection)
            //step2:Adding Element in side Collection
            //step3:diaplaying element in collections


            //var MYLIST = new List<int> { 1, 2, 3, 4, 5 ,6, 7, 8, 9};

            // foreach(var item in MYLIST)
            // {
            // Console.WriteLine(item);
            //}
            //var MYFRDS = new List<string> { "aish", "sri", "dan" };

            //for(int i = 0; i < MYFRDS.Count; i++)
            //{
            //Console.WriteLine("Name is {0}",MYFRDS[i]);

            //}
            // Stack<string> Numbers = new Stack<string>();
            // Numbers.Push("one");
            // Numbers.Push("two");
            // Numbers.Push("three");
            // Numbers.Push("Four");
            //Display all contents of stack

            //foreach(var item in Numbers)
            //{
            //     Console.WriteLine("Following are the contents of collection: {0}", item);
            //}

            //Remove an element from stack

            // Console.WriteLine("Removing top of my stack :{0}",Numbers.Pop());
            //   Console.WriteLine("Removing top of my stack :{0}", Numbers.Pop());

            //Queue<int> Myqueue = new Queue<int>();
            //Myqueue.Enqueue(500);
            //Myqueue.Enqueue(600);
            //Myqueue.Enqueue(700);
            //Myqueue.Enqueue(800);
            //foreach(var item in Myqueue)
            //{
            //  Console.WriteLine("Following contents of collection: {0}", item);
            //}

            //Console.WriteLine("Removing elements from queue:{0}", Myqueue.Dequeue());
            //Console.WriteLine("Removing elements from queue:{0}", Myqueue.Dequeue());

            //Console.WriteLine("Total count pf queue:{0}", Myqueue.Count);
            //Console.WriteLine("Type of the queue:{0}", Myqueue.GetType());

            //ArrayList MyArrayList = new ArrayList();
            //MyArrayList.Add(24);
            //MyArrayList.Add("tom");
            //MyArrayList.Add(24.4567);
            //MyArrayList.Add(true);
            //MyArrayList.Add("DivideByZeroException");

            //foreach(var item in MyArrayList)
            //{
            //  Console.WriteLine("Content of my array list which is non generic type of collection: {0}",item);
            //}

            //SortedList<string,int> GameScore = new SortedList<string,int>();
            //GameScore.Add("My shirt cost is",423);
            //GameScore.Add("last week nfs score ",125);

            //foreach(var item in GameScore)
            //{
            //  Console.WriteLine("Content of game score {0} and value {1}", item.Key,item.Value);
            //}

            //Dictionary<string, string> PasswordDetails = new Dictionary<string, string>();
            //PasswordDetails.Add("Instagram", "@^&$%");
            //PasswordDetails.Add("twitter", "@^$%");
            //PasswordDetails.Add("linkedin", "@^&$");

            //foreach (var item in PasswordDetails)
            //{
            //  Console.WriteLine("Content of the dictionary with \tkey is {0} and value is \t{1}", item.Key, item.Value);

            //}
            //Console.WriteLine("total number count:{0}", PasswordDetails.Count);

            Hashtable MyHashTable = new Hashtable();
            MyHashTable.Add(01, "Nellore");
            MyHashTable.Add(02, "Hyderbad");
            MyHashTable.Add(03, "Chennai");

            Console.WriteLine("Total content of the hashtable is {0}", MyHashTable.Count);

            foreach(DictionaryEntry item in MyHashTable)
            {
                Console.WriteLine("Hashcode of the element is {0}", item.GetHashCode());
                Console.WriteLine("content of the table \tkey is {0} and value is \t{1}", item.Key,item.Value);
            }



        }
    }
}
