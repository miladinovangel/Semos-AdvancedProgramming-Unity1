using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    private void Start()
    {
        Roditel parent = new Roditel("white", "blue", 180);
        parent.Jump();

        Dete child1 = new Dete();
        child1.Jump();
        //?

        //Dete child2 = new Dete("white", "green", 50);
        //child2.Jump();
        //child2.eyeColor = "brown";
        //child2.height = 55;
        //child2.school = "Semos";
        //child2.gender = "test";
    }
}


class Roditel
{
    public string skinColor;
    public string eyeColor;
    public int height;
    protected string gender; // moze da se pristapuva vo klasi koi nasleduvaat od ovaa klasa
    private bool test;// moze da se pristapuva samo vo ovaa klasa

    public Roditel(string skinColor, string eyeColor, int height)
    {
        // this znaci promenlivata sto se naoga vo klasata
        this.skinColor = skinColor;
        this.eyeColor = eyeColor;
        this.height = height;

    }

    protected void ProtectedFunction() { }

    public void SetSkinColor(string skinColor)
    {
        this.skinColor = skinColor;
    }

    public void GiveBirth()
    {
        if (gender == "female")
        {
            // ...
        }
    }

    // virtual - ovozmozuva vo dete klasata da napravime override (da prezapiseme)
    public virtual void Jump()
    {
        Debug.Log("Roditel:Jump");
    }

    public void Learn()
    {

    }

    public void Teach()
    {

    }
}

// : - nasleduva od
class Dete : Roditel //dete koja nasleduva od klasata Roditel
{
    public string school;


    public Dete(string skinColor, string eyeColor, int height) : base(skinColor, eyeColor, height)
    {

    }

    public Dete() : base("", "", 150)
    {
        
    }

    private void Test()
    {
        gender = "Male";
    }

    // override - ja prezapisuva funkcijata od Rodeitelot
    public override void Jump()
    {
        base.Jump();
        Debug.Log("Dete:Jump");
    }
}
