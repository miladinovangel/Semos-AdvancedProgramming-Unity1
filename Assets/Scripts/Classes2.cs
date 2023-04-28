using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes2 : MonoBehaviour // unity klasa
{
    public int testValue;
    public string testString;

    private void Start()
    {
        // instancirame taa klasa / ke kreirame objketi od taa klasa
        SomeClass class1 = new SomeClass(5, 6, 7);// kreirame objekt
        // proces na inicijalizacija na promenlivite od klasata
        //class1.someInt1 = 5;
        //class1.someInt2 = 6;
        //class1.someInt3 = 7;
        class1.SomeFunction();
        SomeClass class2 = new SomeClass();// konstruktor - inicijalizacija na objekt pri negovo kreiranje


        // Patient - osnovna - base klasa
        // ime, prezime
        // godina na ragjanje
        // istorija na bolesti
        // maticen broj
        // pol

        // kreirajte default (prazen konstruktor)
        // kreirajte konstruktor samo za ime i prezime
        // kreirajte konstruktor za site promenlivi od klasata

        // nova klasa sto nasleduva od Patient i taa klasa ke bide MentalPatient
        Patient newPatient = new Patient();
        newPatient = new Patient("Sanja", "Gigova");
        string[] illnessHistory = new string[] { "cold", "anxiety", "covid19" };
        newPatient = new Patient("Sanja", "Gigova", 2000, illnessHistory, 123456666, "female");
        newPatient.PrintIllnesses();
        Debug.Log("");

        newPatient.AddIllness("depression");
        newPatient.PrintIllnesses();


        //Patient newPatient1 = new Patient();

        //Patient newPatient2 = new Patient("Sanja", "Gigova");
        //newPatient2.PrintFullName();
        //string fullName = newPatient2.GetFullName();
        //newPatient2.PrintUnderage();
        //newPatient2.PrintIllnesses();

        // float speed = player.GetSpeed();
        // player.IncreaseSpeed(speed * 1.2f);

        //string[] illnessHistory = new string[] { "cold", "anxiety", "covid19" };
        //Patient newPatient3 = new Patient("Sanja", "Gigova", 2000, illnessHistory, 123456666, "female");




    }
}
// deklariranje na klasa
class SomeClass
{
    public int someInt1; // dokolku promenlivata e public, mozeme da ja pristapuvame nadvor od klasata
    public int someInt2;
    public int someInt3;

    public SomeClass()
    {
        someInt1 = 0;
        someInt2 = 0;
        someInt3 = 0;
    }

    // konstruktor
    public SomeClass(int si1, int si2, int si3) // konstruktor so 3 parametri
    {
        someInt1 = si1;
        someInt2 = si2;
        someInt3 = si3;
    }



    public void SomeFunction()
    {

    }
}
