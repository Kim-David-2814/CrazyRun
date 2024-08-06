using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerComponent : MonoBehaviour
{
    public ParticleSystem _death;
    public GameObject _player;
    public GameObject _daedPlane;
    public GameObject _winPlane;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.CompareTag("Dead"))
        {
            _death.Play();
            _player.SetActive(false);
            _daedPlane.SetActive(true);
        }

        if (other.CompareTag("End"))
        {
            _winPlane.SetActive(true);
        }
    }
}
