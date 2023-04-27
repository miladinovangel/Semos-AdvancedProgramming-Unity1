using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityAdvancedProgramming3 : MonoBehaviour
{
    // kako da kreirame int promenliva
    //public int neznam = 0; // promenlivi koi se del od klasata
    //public string name;
    //public bool test;
    //public char character;
    //public float decimalNumber;
    //public double doubleNumber;
    //public int[] array;
    //public GameObject[] objects;
    //public bool Test;
    //public int TestNum;

    // po default bool promenliva (vo klasa) ima vrednost false (0)
    //private bool isActive = true; // nie nemame eksplicitno zadadena vrednost za ovaa promenliva
    public GameObject[] objects;
    public int hideElementIndex;

    private void Start() // funkcija koja se povikuva na pocetokot na igrata
    {
        //int znam = 1; // lokalni promenlivi
        //Debug.Log(array);
        //int brojac = 0;
        //foreach (int element in array)
        //{
        //    // ako elementot e paren -> pecati go
        //    //if (element % 2 == 0)
        //    //{
        //    //    Debug.Log(element);
        //    //}
        //    if (element % 2 == 1)
        //    {
        //        brojac++;
        //    }
        //}
        //Debug.Log(brojac);
        // izbroivme kolku neparni elementi ima vo nizata
        //objects[0].SetActive(false);
        //objects[1].SetActive(false);

        //objects[hideElementIndex].SetActive(false);

        for(int i = 1; i < objects.Length; i += 2)
        {
            objects[i].SetActive(false);
        }
    }

    // napisete kod sto ke go isklucuva prviot objekt od nizata
    // objects koga ke stisneme na kopceto Q

    private void Update() // funckija koja se povikuva avtomatski od unity na sekoj frame
    {
        //if (Input.GetKeyDown(KeyCode.Q)) // dokolku klikneme na kopceto Q od tastaturata
        //{
        //    objects[0].SetActive(false);// iskluci go prviot objekt od nizata objects
        //    //isActive = false;
        //}
        //else if (Input.GetKeyDown(KeyCode.W))
        //{
        //    objects[0].SetActive(true);
        //}

        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    // treba da proverime dali objektot e vklucen -> iskluci
        //    if (isActive)
        //    {
        //        objects[0].SetActive(false); // iskluci
        //        isActive = false; // zapamti deka e isklucen
        //    }// treba da proverime dali objektot e isklucen -> vkluci
        //    else
        //    {
        //        objects[0].SetActive(true);
        //        isActive = true;
        //    }
        //    //objects[0].activeSelf
        //}
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    bool active = objects[0].activeSelf;
        //    objects[0].SetActive(!active);
        //}
            
    }
}
