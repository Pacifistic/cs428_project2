using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawn : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 randomPosDelta;

        if (Input.GetMouseButton(0) || Input.touchCount > 0) {
            randomPosDelta = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));

            Instantiate(ballPrefab, startPos.position + randomPosDelta, startPos.rotation);
        }
    }
}
