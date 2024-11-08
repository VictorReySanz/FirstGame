using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialCoinScore : MonoBehaviour
{
    int specialScore;
    [SerializeField] Text specialScoreText;
    [SerializeField] int value;

    private void Start()
    {

        specialScoreText.text = "Score: " + specialScore;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            specialScore = specialScore + value;
            specialScoreText.text = "Score: " + specialScore;

            Vector3 newPosition = new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10));
            transform.position = newPosition;
        }

    }
}
