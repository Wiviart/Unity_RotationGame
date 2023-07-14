using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;
    float movement = 0f;

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * moveSpeed);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        StartCoroutine(DelayTime(2f));
    }

    IEnumerator DelayTime(float time)
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(time);

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
