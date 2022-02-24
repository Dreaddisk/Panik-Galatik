using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    #region Variables

    private Transform playerPosition;
    #endregion Variables



    #region Unity_Functions
    private void Start()
    {
        // take the current position = new position (0,0,0)
        transform.position = new Vector3(0, 0, 0);
        
    }


    private void Update()
    {
        
    }
    #endregion Unity_Functions
}
