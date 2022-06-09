using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_board : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float sense = 0.05f; //è∞ÇÃìÆÇ≠ë¨Ç≥
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        transform.Rotate(moveHorizontal * sense, 0, moveVertical * sense);
    }
}
