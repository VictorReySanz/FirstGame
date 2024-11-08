using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    [SerializeField] int scoreToAdd;
    [SerializeField] string playerName;

    private void Start()
    {

    }


    private void OnTriggerEnter(Collider collider)
    {
        PlayerScore player;
        player = collider.gameObject.GetComponent<PlayerScore>();

        if (player != null)
        {
            player.AddScore(scoreToAdd);
            gameObject.GetComponent<AudioSource>().Play();
            //gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            Destroy(this.gameObject, 3f);
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
    }*/
}
