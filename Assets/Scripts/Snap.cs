using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        Debug.Log ("checkTrigger");
        if (other.gameObject.CompareTag("Snapinteraction"))
        {
            Debug.Log("checkComparetag");
            other.transform.position = transform.position;
        }
    }
}
