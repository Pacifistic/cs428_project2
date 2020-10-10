using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    private AudioSource line;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<AudioSource>();
    }

    void sayLine() {
        line.PlayOneShot(line.clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
