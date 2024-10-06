using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavelAnd : MonoBehaviour {
	public string level;
    public Data data;
    public static LavelAnd rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    public void Reload()
    {
        if (data.lives > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            data.lives -= 1;
            //SaveAndLoad.Instance.Save();
        }
        else 
        {
            data.record = 0;
            data.level = "Scene1";
            data.lives = 3;
            //SaveAndLoad.Instance.Save();
            SceneManager.LoadScene("Scene1");
        }
    }
    public void Reclame()
    {
        //SaveAndLoad.Instance.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Next()
    {
        data.level = level;
       // SaveAndLoad.Instance.Save();
        SceneManager.LoadScene(level);
    }
}
