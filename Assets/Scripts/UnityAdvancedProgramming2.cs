using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityAdvancedProgramming2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() // funkcija
    {
        // Ispecati gi broevite od 1 do 10
        //for (int i = 1; i < 11; i++)
        //{
        //    //Console.WriteLine(i); - 
        //    Debug.Log(i);
        //}

        //int age = 5; // deklaracija i inic. na promenliva
        //Debug.Log(age); // pecatenje na promenliva


        //int[] ages1 = new int[] { 10, 11, 15, 20, 13, 3 }; // nacin 1 na inic.
        //int[] ages2 = new int[5]; // nacin 2 na inic.

        //Debug.Log(ages1[2]*ages2[2]);
        //1 So pomos na ciklus, ispecatete gi site elementi od dvete nizi
        //for(int i = 0; i < ages1.Length; i++)
        //{
        //    Debug.Log(ages1[i]);
        //}
        //Debug.Log("");
        //for (int i = 0; i < ages2.Length; i++)
        //{
        //    Debug.Log(ages2[i]);
        //}

        //2 Da gi ispecatime site elementi od nizata ages1 vo obraten redosled
        //for (int i = ages1.Length - 1; i >= 0; i--)
        //{
        //    Debug.Log(ages1[i]);
        //}


        /*int[] ages1 = new int[] { 10, 11, 15, 20, 13, 3 };*/ // nacin 1 na inic.
        //3 Kreirajte nova niza ages3
        //int[] ages3 = new int[ages1.Length];
        //a. i ispolnete ja so istite elementi kako nizata ages1
        //b. so kvadratite od elemenite od nizata ages1 -> 100, 121, 225, 400, 169, 9
        //c. presmetaj ja sumata na elementite od a i b
        //for (int i = 0; i < ages3.Length; i++)
        //{
        //    ages3[i] = ages1[i];
        //    Debug.Log(ages3[i]);
        //}
        //for (int i = 0; i < ages3.Length; i++)
        //{
        //    ages3[i] = ages1[i]* ages1[i];
        //    Debug.Log(ages3[i]);
        //}
        //int suma1 = 0;
        //int suma2 = 0;
        //for (int i = 0; i < ages3.Length; i++)
        //{
        //    suma1 += ages1[i];
        //    suma2 += ages3[i];
        //}
        //Debug.Log($"{suma1} {suma2}");


        //int num = 0;
        //num = num + 2;
        //num += 2;


        //4. napisi programa koja go naoga najgolemiot i najmaliot element od nizata
        //int[] ages1 = new int[] {50,11,15,20,13,3  };
        //if (ages1.Length == 0)
        //{
        //    Debug.Log("Vasata niza e prazna");
        //}
        //else
        //{
        //    int biggestElement = ages1[ages1.Length-1];
        //    int smallestElement = ages1[ages1.Length - 1];
        //    for (int i = 0; i < ages1.Length; i++)
        //    {
        //        if (ages1[i] > biggestElement)
        //        {
        //            biggestElement = ages1[i];
        //        }
        //        if (ages1[i] < smallestElement)
        //        {
        //            smallestElement = ages1[i];
        //        }
        //    }

        //    Debug.Log("biggest" + biggestElement);
        //    Debug.Log("smallest" + smallestElement);
        //}
        //int biggestElement = ages1[0];
        //int smallestElement = ages1[0];
        //for(int i =1;i < ages1.Length; i++)
        //{
        //    if (ages1[i] > biggestElement)
        //    {
        //        biggestElement = ages1[i];
        //    }
        //    if (ages1[i] < smallestElement)
        //    {
        //        smallestElement = ages1[i];
        //    }
        //}

        //Debug.Log("biggest" + biggestElement);
        //Debug.Log("smallest" + smallestElement);

        //{ (1*1*1), (2*2*2), (3*3*3), (4*4*4), (5*5*5) } | 1, 8,,, .. 125

        //int[] array = new int[5];
        //for (int i = 1; i <= array.Length; i++) // dodeluvanje vrednosti na nizata
        //{
        //    array[i-1] = i*i*i;
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    array[i] = (i + 1) * (i + 1) * (i + 1);
        //}


        // pecatenje na nizata
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Debug.Log(array[i]);
        //}
    }


}
