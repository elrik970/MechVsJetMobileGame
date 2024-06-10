using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2) {
                float movePos = touch.position.y;
                
                if (movePos > Screen.height) {
                    movePos = Screen.height;
                }
                if (movePos < 0) {
                    movePos = 0;
                }
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector2(touch.position.x,movePos));
                
                
                rb.MovePosition(new Vector2(transform.position.x,mousePos.y));
            }
        }
    }
}
