using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("You Lose");

            other.transform.position = new Vector3(11, 1, -3);
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
