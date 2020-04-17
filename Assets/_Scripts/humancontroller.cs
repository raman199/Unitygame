using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humancontroller : MonoBehaviour
{
   public Camera camera;
   public GameController gameController;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       _move();
    }

    private void _move()
    {
       Vector2 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
        
        transform.position = new Vector2(Mathf.Clamp(mousePosition.x, -1.86f, 1.86f), -4.3f);
    }
   /* private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("collision!");
    }  */
    private void OnTriggerEnter2D(Collider2D other) {
        switch(other.gameObject.tag)
        {
            case "flower":
                gameController.Score += 100;
             break;
             case "stone":
                              gameController.Lives -= 1;

             break;

        }

    }
}
