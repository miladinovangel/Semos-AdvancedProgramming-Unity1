using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clases : MonoBehaviour
{
    public string[] Names;
    public int[] Ages;


    private void Start() // Main
    {
        // kreirajte instanca od taa klasa
        int num = 5;
        Person person = new Person(); // kreiranje na objekt ili instanca od klasata
        // inicijalizirajte gi od ovde za objektot person
        person.name = "Qwerty";
        person.age = 5;

        // povikajte/izvrsete ja taa funckija od ovde
        //person.PrintNameAndAge();


        Person[] students = new Person[Names.Length];

        //students[0] = new Person(); // kreiranje objekt od tip Person i dodeluvanje na taa vrednost vo prviot element od nizata students
        //students[0].name = Names[0]; // dodeluvanje ime na prviot objekt
        //students[0].age = Ages[0]; // dodeluvanje na vozrast na prviot objekt

        //students[1] = new Person();
        //students[1].name = Names[1];
        //students[1].age = Ages[1];

        //students[2] = new Person();
        //students[2].name = Names[2];
        //students[2].age = Ages[2];

        //students[3] = new Person();
        //students[3].name = Names[3];
        //students[3].age = Ages[3];

        for (int i = 0; i <= students.Length; i++)
        {
            students[i] = new Person(); 
            students[i].name = Names[i]; 
            students[i].age = Ages[i];
        }

        // ispcati gi iminjata na site studenti i vozrasta
        //students[0].PrintNameAndAge();
        //students[1].PrintNameAndAge();
        //students[2].PrintNameAndAge();
        //students[3].PrintNameAndAge();

        for (int i = 0; i <= students.Length; i++)
        {
            students[i].PrintNameAndAge();
        }
    }
}


// napisete klasa po vas izbor
class Person
{
    // dodadete 2 promenlivi: name i age
    public string name;
    public int age;
    

    // kreirajte funckija
    // void funckija sto ke se vika PrintNameAndAge i ke pecati ime i vozrast vo edna linija
    public void PrintNameAndAge()
    {
        Debug.Log(name + " " + age);
    }
}
