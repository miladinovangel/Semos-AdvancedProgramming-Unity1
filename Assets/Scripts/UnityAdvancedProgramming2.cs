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


        int[] ages1 = new int[] { 10, 11, 15, 20, 13, 3 }; // nacin 1 na inic.
        //3 Kreirajte nova niza ages3
        int[] ages3 = new int[ages1.Length];
        //a. i ispolnete ja so istite elementi kako nizata ages1
        //b. so kvadratite od elemenite od nizata ages1 -> 100, 121, 225, 400, 169, 9
        //c. presmetaj ja sumata na elementite od a i b
        //for (int i = 0; i < ages3.Length; i++)
        //{
        //    ages3[i] = ages1[i];
        //    Debug.Log(ages3[i]);
        //}
        for (int i = 0; i < ages3.Length; i++)
        {
            ages3[i] = ages1[i]* ages1[i];
            Debug.Log(ages3[i]);
        }
        int suma1 = 0;
        int suma2 = 0;
        for (int i = 0; i < ages3.Length; i++)
        {
            suma1 += ages1[i];
            suma2 += ages3[i];
        }
        Debug.Log($"{suma1} {suma2}");

    }

    
}
