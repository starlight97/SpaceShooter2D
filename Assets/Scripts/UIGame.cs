using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    private Text textScore;
    private GameObject lifeImages;
    private GameObject bombImages;
    //private Text textLife;

    public int score;
    public int playerCurrentHp;
    public int playerBombCount;
    // Start is called before the first frame update
    void Awake()
    {
        textScore = transform.Find("TextScore").GetComponent<Text>();
        lifeImages = transform.Find("PlayerLife").gameObject;
        bombImages = transform.Find("PlayerBomb").gameObject;
    }

    public void UpdateUi()
    {
        textScore.text = "Á¡¼ö : " + score.ToString();
        UpdateBombUi();
        UpdateLifeUi();
    }
    private void UpdateLifeUi()
    {
        int lifeImageCount = lifeImages.transform.childCount;
        for (int index = 0; index < lifeImageCount; index++)
        {
            lifeImages.transform.GetChild(index).gameObject.SetActive(false);
        }

        for (int index = 0; index < playerCurrentHp; index++)
        {
            lifeImages.transform.GetChild(index).gameObject.SetActive(true);
        }

    }
    private void UpdateBombUi()
    {
        int bombImageCount = bombImages.transform.childCount;
        for (int index = 0; index < bombImageCount; index++)
        {
            bombImages.transform.GetChild(index).gameObject.SetActive(false);
        }

        for (int index = 0; index < playerBombCount; index++)
        {
            bombImages.transform.GetChild(index).gameObject.SetActive(true);
        }
    }
}
