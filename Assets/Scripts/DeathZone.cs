using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        PlayerScore player;
        player = collision.gameObject.GetComponent<PlayerScore>();

        if (player != null)
        {
            player.LooseLives(damage);
            player.Respawn();
        } else
        {
            Destroy(collision.gameObject);
        }
    }
}
