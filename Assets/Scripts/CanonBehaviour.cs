using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBehaviour : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] Transform shootingPoint;

    [SerializeField] int gustCount;
    [SerializeField] float shootingDelay;
    [SerializeField] float gustDelay;

    void Start()
    {
        StartCoroutine(CanonSequence());
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Shoot()
    {
        GameObject instantiatedBullet;
        instantiatedBullet = GameObject.Instantiate(projectile, shootingPoint.position, shootingPoint.rotation);
        instantiatedBullet.GetComponent<BulletBehabiour>().ChangeParent(transform);
    }

    IEnumerator CanonSequence()
    {
        while (true)
        {
            for (int i = 0; i < gustCount; i++)
            {
                Shoot();
                yield return new WaitForSeconds(shootingDelay);
            }

            yield return new WaitForSeconds(gustDelay);
        }
    }
}
