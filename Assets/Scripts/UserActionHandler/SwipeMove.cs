using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeMove : MonoBehaviour
{
    private float fingerStartTime  = 0.0f;
    private Vector2 fingerStartPos = Vector2.zero;
 
    private bool isSwipe = false;
    private float minSwipeDist  = 30.0f;
    private float maxSwipeTime = 10f;
 
    public GameObject player;
    //public PlayerMovement playerMovementScript;
 
    bool canInvoke = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
