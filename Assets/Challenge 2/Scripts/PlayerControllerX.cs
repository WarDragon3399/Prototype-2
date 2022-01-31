using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeRemaining = 3.0f;

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            
            timeRemaining -= Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeRemaining = 3.0f;
        }
    }
}
