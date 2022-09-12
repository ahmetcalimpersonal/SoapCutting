using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SoapPiece"))
        {
            //Add force if knife hit a piece of soap.
            other.GetComponent<Rigidbody>().isKinematic = false;
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * Random.Range(2F,5F), ForceMode.Impulse);
        }
    }
}
