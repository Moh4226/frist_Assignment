using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    // Start is called before the first frame update
  
    public void LoadLevelTwo() {

        Load();
    
    
    }

    private void Load()
    {
        StartCoroutine(Loadscenecoroutine());
    }

    private IEnumerator Loadscenecoroutine()
    {
        AsyncOperation OP = SceneManager.LoadSceneAsync("Level2");
        while (OP.isDone)
        {
            Debug.Log($"progress: {OP.progress}");
            yield return null;

        }



    }


}
