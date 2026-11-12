using UnityEngine;
using System.Collections;

# Test comment!
# Second Comment!

public class ExampleClass : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject ball2;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        // hey! is the F key pressd down??! 
        if (Input.GetKeyDown("f") || Input.GetButtonDown("Jump")) // <- check true or false
            // 'yes' then do something cool!
            GetComponent<Rigidbody>().useGravity = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();

        // make the second ball bounce
        ball2.GetComponent<Rigidbody>().useGravity = true;
    }

    void OnTriggerEnter(Collider other) {
        print("triggered by " + other.name);
        // Material otherMat = other.GetComponent<Renderer>().material;
        // otherMat.SetColor("_BaseColor", Color.red);

        other.GetComponent<Renderer>().material.SetColor("_BaseColor", Color.red);
    }

    void OnTriggerExit(Collider other) {
        other.GetComponent<Renderer>().material.SetColor("_BaseColor", Color.blue);
    }

    void OnMouseDown() {
        GetComponent<Rigidbody>().useGravity = true;
    }

}
