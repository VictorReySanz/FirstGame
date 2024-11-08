using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGlueBehaviour : MonoBehaviour
{

    Transform prevparent;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject plataform = this.gameObject;
            GameObject ball = collision.gameObject;

            prevparent = ball.transform.parent;
            ball.transform.SetParent(plataform.transform, true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.SetParent(prevparent, false);
        }
    }
}
