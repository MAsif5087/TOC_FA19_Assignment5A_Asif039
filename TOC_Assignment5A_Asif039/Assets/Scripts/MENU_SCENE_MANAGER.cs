using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU_SCENE_MANAGER : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NEXT_LEVEL());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NEXT_LEVEL()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Main");


    }
}
