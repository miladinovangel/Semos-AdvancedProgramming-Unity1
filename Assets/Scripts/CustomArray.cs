using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomArray
{
    public BaseEnemy[] enemies = { };//niza od BaseEnemy

    public void AddElement(BaseEnemy newElement)
    {
        BaseEnemy[] tmp = new BaseEnemy[enemies.Length + 1];
        // kopiranje na site elementi
        for (int i = 0; i < enemies.Length; i++)
        {
            tmp[i] = enemies[i];
        }
        tmp[enemies.Length] = newElement; // go dodavame vo novata niza
        enemies = tmp; // promenlivata enemies ke pokazuva kon novata niza
    }

    public void RemoveElement(int indexOfElementWeWantToRemove)
    {
        BaseEnemy[] tmp = new BaseEnemy[enemies.Length - 1];
        // copy the elemennts until the element you want to remove(i)
        for (int j = 0; j < indexOfElementWeWantToRemove; j++)
        {
            tmp[j] = enemies[j];
        }
        // copy the elements after the element you want to remove
        for (int j = indexOfElementWeWantToRemove; j < enemies.Length - 1; j++)
        {
            tmp[j] = enemies[j + 1];
        }
        enemies = tmp;
    }
}

public class CustomArrayInt
{
    public int[] enemies = { };//niza od BaseEnemy

    public void AddElement(int newElement)
    {
        int[] tmp = new int[enemies.Length + 1];
        // kopiranje na site elementi
        for (int i = 0; i < enemies.Length; i++)
        {
            tmp[i] = enemies[i];
        }
        tmp[enemies.Length] = newElement; // go dodavame vo novata niza
        enemies = tmp; // promenlivata enemies ke pokazuva kon novata niza
    }

    public void RemoveElement(int indexOfElementWeWantToRemove)
    {
        int[] tmp = new int[enemies.Length - 1];
        // copy the elemennts until the element you want to remove(i)
        for (int j = 0; j < indexOfElementWeWantToRemove; j++)
        {
            tmp[j] = enemies[j];
        }
        // copy the elements after the element you want to remove
        for (int j = indexOfElementWeWantToRemove; j < enemies.Length - 1; j++)
        {
            tmp[j] = enemies[j + 1];
        }
        enemies = tmp;
    }
}

public class CustomArrayString
{
    public string[] array = { };//niza od BaseEnemy

    public void AddElement(string newElement)
    {
        string[] tmp = new string[array.Length + 1];
        // kopiranje na site elementi
        for (int i = 0; i < array.Length; i++)
        {
            tmp[i] = array[i];
        }
        tmp[array.Length] = newElement; // go dodavame vo novata niza
        array = tmp; // promenlivata enemies ke pokazuva kon novata niza
    }

    public void RemoveElement(int indexOfElementWeWantToRemove)
    {
        string[] tmp = new string[array.Length - 1];
        // copy the elemennts until the element you want to remove(i)
        for (int j = 0; j < indexOfElementWeWantToRemove; j++)
        {
            tmp[j] = array[j];
        }
        // copy the elements after the element you want to remove
        for (int j = indexOfElementWeWantToRemove; j < array.Length - 1; j++)
        {
            tmp[j] = array[j + 1];
        }
        array = tmp;
    }
}


public class CustomGenericArray<T> // kreirame klasa so genericki tip T
{
    public T[] array = { };//niza od BaseEnemy

    public void AddElement(T newElement)
    {
        T[] tmp = new T[array.Length + 1];
        // kopiranje na site elementi
        for (int i = 0; i < array.Length; i++)
        {
            tmp[i] = array[i];
        }
        tmp[array.Length] = newElement; // go dodavame vo novata niza
        array = tmp; // promenlivata enemies ke pokazuva kon novata niza
    }

    public void RemoveElement(int indexOfElementWeWantToRemove)
    {
        T[] tmp = new T[array.Length - 1];
        // copy the elemennts until the element you want to remove(i)
        for (int j = 0; j < indexOfElementWeWantToRemove; j++)
        {
            tmp[j] = array[j];
        }
        // copy the elements after the element you want to remove
        for (int j = indexOfElementWeWantToRemove; j < array.Length - 1; j++)
        {
            tmp[j] = array[j + 1];
        }
        array = tmp;
    }
}