using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float MoveSpeed = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("LVL2");
        }
        if (other.gameObject.tag == "Finish2")
        {
            SceneManager.LoadScene("LVL3");
        }
        if (other.gameObject.tag == "Finish3")
        {
            SceneManager.LoadScene("LVL4");
        }
        if (other.gameObject.tag == "Finish4")
        {
            SceneManager.LoadScene("LVL5");
        }
    }



}