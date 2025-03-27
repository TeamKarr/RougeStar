using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraPosition : MonoBehaviour
{
    // Start is called before the first frame update

    [Tooltip("The player object")]
    public Transform player;
    
    public bool useMousePos = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float z = transform.position.z;
        Vector3 m = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (!useMousePos) {
            Debug.Log("moving to " + player.transform.position.x + " " + player.transform.position.y + " " + z);
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, z);
        } else
        {

            transform.position = (m + player.transform.position)/2;
        }
        
    }
}
