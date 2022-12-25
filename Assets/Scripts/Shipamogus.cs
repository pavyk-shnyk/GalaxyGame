using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shipamogus : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject bullet;

    float speed = 0.1f;
    public int hp = 200;
    private float halfWidth;

    void Start()
    {
        halfWidth = spriteRenderer.bounds.size.x / 2;
    }

    void Update()
    {
        Vector3 newRPos = new Vector3(transform.position.x + speed, transform.position.y, 0);
        Vector3 newLPos = new Vector3(transform.position.x - speed, transform.position.y, 0);
        Vector3 checkLPos = new Vector3(newLPos.x - halfWidth, newLPos.y, 0);
        Vector3 checkRPos = new Vector3(newRPos.x + halfWidth, newRPos.y, 0);

        if (Input.GetKey(KeyCode.RightArrow)) {
            bool check = ScreenHelpers.ObjectNah(checkRPos);
            if (check) {
                transform.position = newRPos; 
            }            
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            bool check = ScreenHelpers.ObjectNah(checkLPos);
            if (check) {
                transform.position = newLPos; 
            }
        }

        if (Input.GetKey(KeyCode.Space)) {
            GameObject clone = Instantiate(bullet);
            clone.transform.position = transform.position;
        }
    }
    
    void OnTriggerEnter2D(Collider2D otherHitbox){
        GameObject otherObj = otherHitbox.gameObject;
        EnemyBullet bulletScript = otherObj.GetComponent<EnemyBullet>();
        if(bulletScript != null) {
            hp -= bulletScript.damage;
            Destroy(otherObj);
            if (hp <= 0) {
                 SceneManager.LoadSceneAsync(ScoueIDS.LoseSceneID);
                Destroy(gameObject);
                
            }
        }
    }
}
