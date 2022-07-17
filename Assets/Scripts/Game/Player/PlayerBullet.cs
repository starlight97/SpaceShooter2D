using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public int damage;
    public float moveSpeed = 2f;
    private bool isCollision = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if(this.transform.position.y >= 5.44f)
        {
            Destroy(this.gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isCollision)
        {
            if (collision.tag == "Enemy")
            {
                StartCoroutine(CollisionRoutine());
                // 적을 공격 
                collision.GetComponent<Enemy>().Hit(this.damage);
                // 총알을 제거 

                Destroy(this.gameObject);
            }
        }

    }

    private IEnumerator CollisionRoutine()
    {
        isCollision = true;
        yield return null;
    }
}
