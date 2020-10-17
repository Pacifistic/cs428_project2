using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawn : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform startPos;
    public float scale = .5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 randomPosDelta;

        if (Input.GetMouseButton(0) || Input.touchCount > 0) {
            randomPosDelta = new Vector3(Random.Range(-scale, scale), 0, Random.Range(-scale, scale));

            Instantiate(ballPrefab, startPos.position + randomPosDelta, startPos.rotation);
        }
    }
}
