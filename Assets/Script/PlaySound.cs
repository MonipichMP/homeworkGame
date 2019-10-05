using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySound : MonoBehaviour {

    [SerializeField] int timeToWait = 3;
    int currentIndex;

	// Use this for initialization
	void Start () {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
	}

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }
	
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentIndex + 1 );
    }

	// Update is called once per frame
	void Update () {
		
	}
}
