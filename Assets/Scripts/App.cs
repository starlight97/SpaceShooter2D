using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class App : MonoBehaviour
{
    public enum eFadeType
    {
        FadeIn, FadeOut

    }

    public static App instance;

    private void Awake()
    {
        App.instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("LoadingScene");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dim"></param>
    /// <param name="fadeType"></param>
    /// <param name="callback"></param>
    public void Fade(Image dim, eFadeType fadeType, UnityAction callback)
    {
        this.StartCoroutine(this.FadeImpl(dim, fadeType, callback));
    }
    private IEnumerator FadeImpl(Image dim, eFadeType fadeType, UnityAction callback)
    {
        while (true)
        {
            var color = dim.color;
            if (fadeType == eFadeType.FadeOut)
            {
                color.a += 0.1f;
                if (color.a >= 1) break;
            }
            else
            {
                color.a -= 0.1f;
                if (color.a <= 0) break;

            }
            dim.color = color;

            yield return null;
        }
        callback();
    }
}
