using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tileact : MonoBehaviour
{
    public SpriteRenderer color;
    public int scorev =1;
    public Rigidbody2D rb;
    public float speed = 500f;
    //   public AudioClip touch;
    private int i = 1;
    private bool isclicked;
    // Start is called before the first frame update
    void Start()
    {
        isclicked = false;
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, -speed*Time.deltaTime, 0);
        if(FindObjectOfType<score>().scorep > i * 10)
        {
            speed += 100;
            i++;

        }
    }
     void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isclicked == false)
            {  //  AudioSource.PlayClipAtPoint(touch, transform.position);
                color.color = Color.yellow;

                FindObjectOfType<score>().scoret();//   scorev
                isclicked = true;
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (color.color == Color.yellow)
            Debug.Log("ok");
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
