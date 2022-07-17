using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingMain : MonoBehaviour
{
    public float loadingTime = 5f;
    private Image dim;
    void Start()
    {
        dim = GameObject.Find("dim").GetComponent<Image>();
        StartCoroutine(LoadingEffectRoutine());
    }

    private IEnumerator LoadingEffectRoutine()
    {
        yield return new WaitForSeconds(loadingTime);
        App.instance.Fade(this.dim, App.eFadeType.FadeOut, () => {
            // æ¿¿¸»Ø
            SceneManager.LoadScene("TitleScene");
        });        
    }

}
