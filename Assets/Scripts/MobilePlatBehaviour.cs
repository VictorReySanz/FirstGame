using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlatBehaviour : MonoBehaviour
{

    [SerializeField] Transform[] positions;
    [SerializeField] float speed;
    [SerializeField] float offset;
    [SerializeField] float timeWaiting;

    int actualDestiny;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        actualDestiny = 0;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction;

        Vector3 destiny = positions[actualDestiny].position;
        Vector3 actualPosition = transform.position;

        direction = destiny - actualPosition;
        direction.Normalize();

        Vector3 newPosition;

        newPosition = actualPosition + (direction * speed * Time.deltaTime);

        transform.position = newPosition;

        float distance = Vector3.Distance(newPosition, destiny);

        if (distance < offset)
        {
            timer += Time.deltaTime;
            if(timer > timeWaiting)
            {
                actualDestiny = actualDestiny + 1;
                if (actualDestiny >= positions.Length)
                {
                    actualDestiny = 0;
                }
                timer = 0;
            }
        }
    }
}
