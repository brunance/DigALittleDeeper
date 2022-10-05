using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "finish")
        {
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }
    }

}
