using UnityEngine;

class Patient
{
    public string name;
    public string surname;
    public int birthYear;
    public string[] illnessHistory;
    public long idNumber;
    public string gender;

    public Patient()
    {
        name = "";
        surname = "";
        birthYear = 1950;
    }
    public Patient(string n, string s)
    {
        name = n;
        surname = s;
    }
    public Patient(string n, string s, int brt, string[] ill, long id, string g)
    {
        name = n;
        surname = s;
        birthYear = brt;
        illnessHistory = ill;
        idNumber = id;
        gender = g;
    }

    // string GetFullName() - funckijata vi vraka ime i prezime (ne pecati tuku vraka, return)
    public void PrintFullName()
    {
        Debug.Log(name + " " + surname);
    }
    public string GetFullName()
    {
        return name + " " + surname;
    }
    // bool IsUnderage - proveruva dali pacientot e maloleten i vraka true/ vo sprotivno false
    public void PrintUnderage()
    {
        int currentYear = System.DateTime.Now.Year;
        Debug.Log(currentYear);
        if (currentYear - birthYear < 18)
        {
            Debug.Log("Pacientot e maloleten");
        }
        else
        {
            Debug.Log("Pacientot ne e maloleten");
        }
    }

    public bool IsUnderage()
    {
        int currentYear = System.DateTime.Now.Year;
        if (currentYear - birthYear < 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // void PrintIllnesses() - ja pecati celata istorija na bolesti na pacientot
    public void PrintIllnesses()
    {
        for (int i = 0; i < illnessHistory.Length; i++)
        {
            Debug.Log(illnessHistory[i]);
        }
    }

    // void AddIllness(string newIllness) - dodava nova bolest vo nizata so bolesti (zaedno ke ja resavame)
    public void AddIllness(string newIllness)
    {
        // vo nizata illnessHistory treba da ja dodademe newIllness
        // 1. kreiranje nova niza so n+1 elementi
        string[] updatedIllnessHistory = new string[illnessHistory.Length + 1];
        // 2. prekopiranje na postoeckite elementi
        for (int i = 0; i < illnessHistory.Length; i++)
        {
            updatedIllnessHistory[i] = illnessHistory[i];
        }
        // 3. dodavanje na noviot element na krajot od nizata
        updatedIllnessHistory[illnessHistory.Length] = newIllness;

        // 4. dodeli ja vrednosta na novata niza na promenlivata illnessHistory
        illnessHistory = updatedIllnessHistory;
    }

}
