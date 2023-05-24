using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleIO : MonoBehaviour
{
   public GameObject dust;

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
        if(other.gameObject.layer == 3)
        {
            dust.gameObject.SetActive(true);
            Debug.Log("Trigger entered");
        }
    }
}
