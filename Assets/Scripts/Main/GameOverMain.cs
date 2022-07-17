using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMain : MonoBehaviour
{
    private Image dim;

    // Start is called before the first frame update
    void Start()
    {
        //dim = transform.Find("dim").GetComponent<Image>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");

            //App.instance.Fade(this.dim, App.eFadeType.FadeOut, () => {
            //    // æ¿¿¸»Ø
            //    SceneManager.LoadScene("GameScene");
            //});
        }
    }
}
