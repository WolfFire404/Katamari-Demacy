using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    Rigidbody2D dasd;
    Score f;

    void Start()
    {
        dasd = GetComponent<Rigidbody2D>();
        f = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            dasd.velocity = new Vector2(-speed, dasd.velocity.y);
        }
        else if (Input.GetKey("d"))
        {
            dasd.velocity = new Vector2(speed, dasd.velocity.y);
        }
        else
            dasd.velocity = new Vector2(0, dasd.velocity.y);

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Junk")
        {
            if(collision.gameObject.transform.localScale.x > transform.localScale.x)
            {
                //  Application.LoadLevel("lose");
                SceneManager.LoadScene("lose");
            }
            else
            {
                DestroyObject(collision.gameObject);
                var size = transform.localScale;
                size.x = size.y = size.y + 0.2f;
                transform.localScale = size;
               // f.score = (double)transform.localScale.x;
                f.AddScore(transform.localScale.x);
                if (transform.localScale.x > 4)
                {
                    // Application.LoadLevel("win");
                    SceneManager.LoadScene("win");
                }
            }
        }
    }
}
