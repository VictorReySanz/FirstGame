using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenigBehaviour : MonoBehaviour
{

    protected DoorBehaviour door;
    // Start is called before the first frame update
    void Start()
    {
        door = GetComponent<DoorBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
