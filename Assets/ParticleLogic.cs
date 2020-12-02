﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLogic : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 0.2f);
    }
    public void StartParticle(Vector3 particalPosition, float stayTime)
    {
        GetComponent<ParticleSystem>().Play();
        transform.position = particalPosition;
        gameObject.SetActive(true);
        Invoke("Inactive", stayTime);
    }
    void Inactive()
    {
        gameObject.SetActive(false);
    }
}
