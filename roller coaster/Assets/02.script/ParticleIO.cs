using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleIO : MonoBehaviour
{
   public ParticleSystem dust;

    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 2)
        {
            dust.Play();
        }
    }
}
