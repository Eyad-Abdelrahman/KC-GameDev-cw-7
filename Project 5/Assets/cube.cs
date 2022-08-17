using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cube : MonoBehaviour
{
    public Transform Max;
    public Transform Min;
    public AudioSource src;
    public float inc;
    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, Max.position.x, Min.position.x), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, Max.position.x, Min.position.x), transform.position.y, transform.position.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            src.Play();
            Invoke("Restart", 1f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
