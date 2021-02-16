using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Rigidbody cube;
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float force = Random.Range(4f,8f);
        cube.AddForce(new Vector3(0,0,-force), ForceMode.Acceleration);
    }
}
