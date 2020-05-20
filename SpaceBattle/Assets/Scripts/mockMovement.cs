using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mockMovement : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;
    public Vector3 acceleration = Vector3.zero;
    public Vector3 force = Vector3.zero;

    protagList protagScript;

    public GameObject Protag;

    public float mass = 1.0f;

    public float maxSpeed = 5;
    public float maxForce = 10;

    public float speed = 0;

    public bool seekEnabled = false;
    public Vector3 target;
    Transform targetTransform;

    [Range(0.0f, 10.0f)]
    public float banking = 0.1f;

    public void start()
    {
        Protag = protagScript.protags[Random.Range(0, protagScript.protags.Length)];

        target = Protag.transform.position;

        wait();
    }


    public IEnumerator wait()
    {
        yield return new WaitForSeconds(15f);

        seekEnabled = true;
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + acceleration);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + velocity);

    }

    Vector3 Seek(Vector3 target)
    {
        Vector3 toTarget = target - transform.position;
        Vector3 desired = toTarget.normalized * maxSpeed;

        return desired - velocity;
    }

    public Vector3 CalculateForce()
    {
        Vector3 force = Vector3.zero;
        if (seekEnabled)
        {
            force += Seek(target);
        }

        return force;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(target, transform.position);


        if (targetTransform != null)
        {
            target = targetTransform.position;
        }

        force = CalculateForce();
        acceleration = force / mass;
        velocity += acceleration * Time.deltaTime;

        transform.position += velocity * Time.deltaTime;
        speed = velocity.magnitude;

        if (speed > 0)
        {
            Vector3 tempUp = Vector3.Lerp(transform.up, Vector3.up + (acceleration * banking), Time.deltaTime * 3.0f);
            transform.LookAt(transform.position + velocity, tempUp);

            transform.forward = velocity;
        }

    }
}

