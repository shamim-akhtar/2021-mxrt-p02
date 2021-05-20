using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffect : MonoBehaviour
{
    public ParticleSystem mFirePS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stop()
    {
        mFirePS.Stop();
    }

    public void Play()
    {
        mFirePS.Play();
    }
}
