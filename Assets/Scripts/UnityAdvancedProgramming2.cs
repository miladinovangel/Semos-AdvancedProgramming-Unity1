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

        int age = 5; // deklaracija i inic. na promenliva
        Debug.Log(age); // pecatenje na promenliva


        int[] ages1 = new int[] { 10, 11, 15, 20, 13, 3 }; // nacin 1 na inic.
        int[] ages2 = new int[5]; // nacin 2 na inic.

        //Debug.Log(ages1[2]*ages2[2]);
        // So pomos na ciklus, ispecatete gi site elementi od dvete nizi
    }

    
}
