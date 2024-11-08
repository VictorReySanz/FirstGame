using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] Text scoreText;

    Vector3 respawnPosition;
    [SerializeField] int lives;
    [SerializeField] Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;

        respawnPosition = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int scoreParameter)
    {
        score = score + scoreParameter;
        scoreText.text = "Score: " + score;
    }

    public void Respawn()
    {


        if (lives > 0)
        {
            transform.localPosition = respawnPosition;

            Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        else
        {
            livesText.text = "GAME OVER";
            Destroy(this.gameObject);
        }
    }

    public void LooseLives(int damage)
    {
        lives -= damage;
        livesText.text = "Lives: " + lives;
    }

    public int GetScore()
    {
        return score;
    }
}
