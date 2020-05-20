using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void OnTriggerStay(Collider mock)
    {
        StartCoroutine(Shoot());
    }

    int fireRate = 3;

    IEnumerator Shoot()
    {
        while (true)
        {
            GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            yield return new WaitForSeconds(1.0f / fireRate);

            yield return null;
        }
    }

    Coroutine cr;
}
