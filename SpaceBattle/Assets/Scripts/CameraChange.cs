using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera cam1, cam2, cam3, cam4, cam5, cam6;
    public GameObject cam3half;

    void Start()
    {
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam3half.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);

        StartCoroutine(firstScene());
    }

    void Update()
    {

    }

    public IEnumerator firstScene()
    {
        cam1.gameObject.SetActive(true);

        yield return new WaitForSeconds(10f);

        StartCoroutine(secondScene());
    }

    public IEnumerator secondScene()
    {
        cam2.gameObject.SetActive(true);
        cam1.gameObject.SetActive(false);

        yield return new WaitForSeconds(6f);

        StartCoroutine(thirdScene());
    }

    public IEnumerator thirdScene()
    {
        cam3.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);

        yield return new WaitForSeconds(3f);

        StartCoroutine(thirdNhalfScene());
    }

    public IEnumerator thirdNhalfScene()
    {
        cam3half.gameObject.SetActive(true);

        yield return new WaitForSeconds(4f);

        StartCoroutine(forthScene());
    }
    public IEnumerator forthScene()
    {
        cam4.gameObject.SetActive(true);
        cam3.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
        cam3half.gameObject.SetActive(false);

        yield return new WaitForSeconds(3f);

        StartCoroutine(fifthScene());
    }
    public IEnumerator fifthScene()
    {
        cam5.gameObject.SetActive(true);
        cam4.gameObject.SetActive(false);

        yield return new WaitForSeconds(3f);

        StartCoroutine(sixthScene());
    }
    public IEnumerator sixthScene()
    {
        cam6.gameObject.SetActive(true);
        cam5.gameObject.SetActive(false);

        yield return new WaitForSeconds(3f);

        StartCoroutine(forthScene());
    }
}
