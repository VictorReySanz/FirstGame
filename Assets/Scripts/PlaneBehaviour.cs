using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBehaviour : MonoBehaviour
{
    //[SerializeField] para establecer el valor desde el editor
    [SerializeField] int rotationLimit;
    [SerializeField] float rotationSpeedZ;
    [SerializeField] float rotationSpeedX;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool aKeyPressed = Input.GetKey(KeyCode.A);
        bool dKeyPressed = Input.GetKey(KeyCode.D);
        bool wKeyPressed = Input.GetKey(KeyCode.W);
        bool sKeyPressed = Input.GetKey(KeyCode.S);

        if (wKeyPressed == true)
        {
            //Comprobaciones excatas no suelen funcionar
            if (transform.eulerAngles.z >= -1 && transform.eulerAngles.z <= rotationLimit ||
                 transform.eulerAngles.z <= 360 && transform.eulerAngles.z >= 270)
            {
                Vector3 newRotation = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + rotationSpeedZ);
                transform.eulerAngles = newRotation;
            }
        }

        if (sKeyPressed == true)
        {

            if (transform.eulerAngles.z >= -1 && transform.eulerAngles.z <= 90 ||
                transform.eulerAngles.z < 360 && transform.eulerAngles.z > (360 - rotationLimit))
            {
                Vector3 newRotation = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z - rotationSpeedZ);
                transform.eulerAngles = newRotation;
            }
        }

        if (dKeyPressed == true)
        {
            //Comprobaciones excatas no suelen funcionar
            if (transform.eulerAngles.x >= -1 && transform.eulerAngles.x <= rotationLimit ||
                 transform.eulerAngles.x <= 360 && transform.eulerAngles.x >= 270)
            {
                Vector3 newRotation = new Vector3(transform.eulerAngles.x + rotationSpeedX, transform.eulerAngles.y, transform.eulerAngles.z);
                transform.eulerAngles = newRotation;
            }
        }

        if (aKeyPressed == true)
        {
            if (transform.eulerAngles.x >= -1 && transform.eulerAngles.x <= 90 ||
                transform.eulerAngles.x <= 360 && transform.eulerAngles.x >= (360 - rotationLimit))
            {
                Vector3 newRotation = new Vector3(transform.eulerAngles.x - rotationSpeedX, transform.eulerAngles.y, transform.eulerAngles.z);
                transform.eulerAngles = newRotation;
            }
        }

        //Unity cuenta la rotacion como de 180 a -180


        //if (transform.eulerAngles.x < 50)
        //{
        //    transform.Rotate(0.05f, 0.0f, 0.0f);
        //} else
        //{
        //    if (transform.eulerAngles.y < 75)
        //    {
        //        transform.Rotate(0.0f, 0.05f, 0.0f);
        //    }
        //}
    }

    private void OnPause(bool pause)
    {
        transform.eulerAngles = new Vector3(0,0,0);
    }
}