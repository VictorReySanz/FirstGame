using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour
{
    List<Item> items; // Colección de objetos en el inventario
    [SerializeField] int numItems;

    private void Start()
    {
        items = new List<Item>();
    }

    public Item GetItem(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            // Si me salgo del array
            return null;
        }
        else
        {
            // Si no, devuelvo lo que haya en esa posición (puede ser null)
            return items[index];
        }
    }

    public Item GetItem(string name)
    {
        foreach (Item i in items)
        {
            // Verificar nombre
            if (i.GetName() == name)
            {
                return i;
            }
        }

        return null;
    }

    public bool AddItem(Item newItem)
    {
        if(HasItem(newItem))
        {
            return false;
        }
        else
        {
            items.Add(newItem);
            return true;
        }

        // No hay huecos disponibles, devuelvo falso
        return false;
    }

    public string PrintAllItems()
    {
        string returnedString = "";
        foreach (Item i in items)
        {
            returnedString = returnedString + i.GetName() + " ";
        }

        return returnedString;
    }

    public void RemoveItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items.RemoveAt(index);
        }
    }

    public void RemoveItem(Item item)
    {
        RemoveItem(item.GetName());
    }

    public void RemoveItem(string name)
    {
        foreach (Item i in items)
        {
                // Verificar nombre
                if (i.GetName() == name)
                {
                    items.Remove(i);
                    return;
                }
        }
    }

    public void UseItem(string name)
    {
        Item it = GetItem(name);
        if (it != null)
        {
            it.Use();
        }
    }

    public void UseItem(int index)
    {
        Item it = GetItem(index);
        if (it != null)
        {
            it.Use();
        }
    }

    public bool HasItem(string name)
    {
        foreach (Item i in items)
        {
            if (i.GetName() == name)
            {
                return true;
            }
        }

        return false;
    }

    public bool HasItem(Item item)
    {
        return HasItem(item.GetName());
    }

}
