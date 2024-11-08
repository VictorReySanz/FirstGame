using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggered : MonoBehaviour
{
    [SerializeField] SwitchBehavior trigger;

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
        trigger.RegisterFunctionToCall(Trigger);
    }

    private void Trigger(bool active, SwitchBehavior sender)
    {
        if (!isOpen)
        {
            Open();
        }
        else
        {
            Close();
        }
    }

    void Open()
    {
        animator.SetBool("Open", true);
        isOpen = true;
    }

    public void Close()
    {
        animator.SetBool("Open", false);
        isOpen = false;
    }
}
