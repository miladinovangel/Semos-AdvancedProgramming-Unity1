using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes3 : MonoBehaviour
{
    private void Start()
    {
        Number object1 = new Number();
        object1 = null;

        Number object2 = object1; // 2te promenlivi imaat ista referenca
        if (object2 != null)
            object2.num = 5;// null reference exception

        Debug.Log(object1.num);
    }
}

class Number
{
    public int num;
}
