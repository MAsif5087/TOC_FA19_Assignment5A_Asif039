using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PLAYER_CONTROLLER : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;
    int score;
    public Text score_txt;

   public bool DETECT_COLLISION;
    public bool DETECT_COLLISION_1;

    public int PALINDROMES_TOTAL;
    public int total_colliders;
    public GameObject GAME_OVER;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        DETECT_COLLISION = true;
        DETECT_COLLISION_1 = true;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        score_txt.text = score.ToString();
        if (DETECT_COLLISION==false)
        {
            StartCoroutine(detect_collision_corrector());
        }

        if (DETECT_COLLISION_1 == false)
        {
            StartCoroutine(detect_collision_corrector_1());
        }
        if (total_colliders >= 10)
        {

            GAME_OVER.SetActive(true);
        }
    }

    IEnumerator detect_collision_corrector()
    {
        yield return new WaitForSeconds(0.01f);
        DETECT_COLLISION = true;
    }

    IEnumerator detect_collision_corrector_1()
    {
        yield return new WaitForSeconds(0.01f);
        DETECT_COLLISION_1 = true;
    }

    void OnTriggerEnter(Collider other)
    {
        
   
        if (other.gameObject.tag=="collectible"&& DETECT_COLLISION==true)
        {
            Destroy(other.gameObject);
            score ++;
            total_colliders++;
            other.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
            DETECT_COLLISION = false;
        }
        if (other.gameObject.tag == "notcollectible"&& DETECT_COLLISION_1==true)
        {
            other.gameObject.GetComponent<Renderer>().material.color = new Color(255,0,0,255);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
                Debug.Log("notcollectiblecollides");
            total_colliders++;
            DETECT_COLLISION_1 = false;
        }
    }
}