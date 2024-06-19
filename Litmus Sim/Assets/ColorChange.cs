using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Acid"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        else if (other.gameObject.CompareTag("Base"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
