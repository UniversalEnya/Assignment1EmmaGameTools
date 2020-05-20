using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    float health = 1;
    public GameObject effect;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "bullet")
        {
            health--;
            if (health <= 0)
            { Dead(); }
        }
    }

    void Dead()
    {
        GameObject boom = Instantiate(effect, transform.position, transform.rotation);
        Destroy(boom.gameObject, 10);
        Destroy(gameObject);
    }
    
}
