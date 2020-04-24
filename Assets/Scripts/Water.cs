using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{

    public GameObject particles;
    public GameObject Particle;
    // Start is called before the first frame update
    void Start()
    {

        particles = Instantiate(particles, Particle.transform.position, Quaternion.identity) as GameObject;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
