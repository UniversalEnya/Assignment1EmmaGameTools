using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protagList : MonoBehaviour
{
    public GameObject[] protags;

    public void Start()
    {
        protags = GameObject.FindGameObjectsWithTag("Protag");
    }
}
