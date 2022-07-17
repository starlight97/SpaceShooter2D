using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class TitleMain : MonoBehaviour
{

    public GameObject textGo;
    public Image dim;
    private float delta;
    public float span1 = 0.1f;
    public float span2 = 0.2f;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            App.instance.Fade(this.dim, App.eFadeType.FadeOut, ()=> {
                // ¾ÀÀüÈ¯
                SceneManager.LoadScene("GameScene");
            });
        }

        this.delta += Time.deltaTime;
        if(this.delta >= this.span1)
        {
            this.textGo.SetActive(false);
        }
        
        if(this.delta >= this.span2)
        {
            this.textGo.SetActive(true);
            this.delta = 0;
        }
    }


}
