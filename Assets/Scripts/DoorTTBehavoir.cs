using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTTBehavoir : MonoBehaviour
{
    Animator animator;
    [SerializeField] float openedTime;
    [SerializeField] bool isOpen;
    [SerializeField] SwitchBehavior trigger;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        if (isOpen)
        {
            Open();
        }
        else
        {
            Close();
        }

        trigger.RegisterFunctionToCall(OnTriggerActivate);
    }

    void OnTriggerActivate(bool active, SwitchBehavior sender)
    {
        if (!isOpen)
        {
            Open();
            timer = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            timer = timer + Time.deltaTime;
            if (timer > openedTime)
            {
                Close();
                trigger.Activate(false);
            }
        }
    }

    void Open()
    {
        animator.SetBool("Open", true);
        isOpen = true;
    }

    void Close()
    {
        animator.SetBool("Open", false);
        isOpen = false;
    }

}
