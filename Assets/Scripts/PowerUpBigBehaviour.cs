using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBigBehaviour : MonoBehaviour
{
    [SerializeField] float scaleFactor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 scale = other.transform.localScale;
            scale = new Vector3(scale.x * scaleFactor, scale.y * scaleFactor, scale.z * scaleFactor);
            other.gameObject.transform.localScale = scale;

            Destroy(this.gameObject);
        }
    }
}
