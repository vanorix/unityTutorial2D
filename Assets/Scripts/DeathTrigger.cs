using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Application.LoadLevel(Application.loadedLevel);
            Scene current = SceneManager.GetActiveScene();
            SceneManager.LoadScene(current.name, LoadSceneMode.Single);
        }
    }
}
