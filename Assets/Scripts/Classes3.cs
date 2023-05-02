using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes3 : MonoBehaviour
{
    private void Start()
    {
        //Number object1 = new Number();
        //object1.num = 3;
        ////object1 = null;

        //Number object2 = object1; // 2te promenlivi imaat ista referenca
        //object2.num = 103;
        ////if (object2 != null)
        ////    object2.num = 5;// null reference exception

        //Debug.Log(object1.num);
        //string string1 = "Hello World";
        //string string2 = string1;
        ////-------------------------------
        ////string1 = "H";

        //string2 = "";
        //if (string2 != null) // dokolku ima referenca
        //{
        //    Debug.Log(string2);
        //}
        //Debug.Log(string1);
        //Debug.Log(string2);
        // string1 ?
        // string2 ?
        //Number object1 = new Number();
        //object1.num = 10;
        //Test1(object1);// prakanje na objekt po referenca
        //Debug.Log(object1.num);

        //int number = 3;
        //Test2(number);
        //Debug.Log(number);

        //string someString = "Hello world";
        //Test3(someString);
        //Debug.Log(someString);
    }

    private void Test1(Number number) // vrednosta se praka preku referenca
    {
        number.num = 11;
    }
    private void Test2(int number)// vrednosta e od tip int, i vrednosta si se avtomatski duplicira
    {
        number = 0;
    }

    private void Test3(string s)
    {
        s = "";
    }
}

class Number
{
    public int num;
}
