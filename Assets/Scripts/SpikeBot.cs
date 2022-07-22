using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBot : MonoBehaviour
{

    public float speed;




    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager2.isGameOver = true;
            Time.timeScale = 0;
        }     
    }



}
