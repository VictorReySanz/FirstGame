using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    string name;

    public string GetName()
    {
        return name;
    }

    public void SetName(string newName)
    {
        name = newName;
    }

    public void Use()
    {

    }
}
