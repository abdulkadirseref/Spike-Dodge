using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    [SerializeField] private float increment;
    [SerializeField] private float speed;
    public float maxHeight;
    public float minHeight;
    private bool canMove;
    [SerializeField] private float moveCD = 1.2f;
    [SerializeField] private float currentMoveCD;
    [SerializeField] private bool canGoDown;

    void Start()
    {
       
    }


    void Update()
    {
        CheckMove();
        if (currentMoveCD >= moveCD)
        {
            canMove = true;
        }
        else
        {
            canMove = false;
            currentMoveCD += Time.deltaTime;
            currentMoveCD = Mathf.Clamp(currentMoveCD, 0.0f, moveCD);
        }


        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Mouse0) && transform.position.y < maxHeight && canMove &&canGoDown==false)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
            currentMoveCD = 1f;

        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && transform.position.y > minHeight && canMove && canGoDown == true)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
            currentMoveCD = 1f;
        }
    }

    void CheckMove()
    {
        if (transform.position.y == -3.5)
        {
            canGoDown = false;
        }
        if (transform.position.y == 0)
        {
            canGoDown = true;
        }
    }


}
