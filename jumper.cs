using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{
    // jump location support comment 
    // Start is called before the first frame update
    const float minX = -8.0f;
    const float maxX = 8.0f;
    const float minY = -4.0f;
    const float maxY = 4.0f;
    // timer support
    float TotalJumpDelaySeconds = 1f;
    float elapsedJumpDelaySeconds = 0f;

    // update timer and check if it's done
    void Update()
    {
        elapsedJumpDelaySeconds += Time.deltaTime;
        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            JumpToNewLocation();
            elapsedJumpDelaySeconds = 0f;
        }
        
        void JumpToNewLocation()
        {
            Vector3 position = transform.position;
            position.x = Random.Range(minX, maxX);
            position.y = Random.Range(minY, maxY);
            transform.position = position;
        }


    }
}
