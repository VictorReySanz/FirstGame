using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehabiour : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] float speed;

    private void OnTriggerEnter(Collider other)
    {
        PlayerScore player = other.GetComponent<PlayerScore>();
        if (player != null)
        {
            player.LooseLives(damage);
        }
        Destroy(this.gameObject);
    }

    private void Update()
    {
        Vector3 position = transform.localPosition;
        position = new Vector3(position.x, position.y, position.z + speed + Time.deltaTime);
        transform.localPosition = position;
    }

    public void ChangeParent(Transform newParent)
    {
        transform.SetParent(newParent);
    }
}
