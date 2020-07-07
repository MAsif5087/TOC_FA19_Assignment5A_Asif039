using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNER : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject POS_1;
    public GameObject POS_2;
    public GameObject POS_3;
    public GameObject POS_4;
    public GameObject POS_5;
    public GameObject POS_6;
    public GameObject POS_7;
    public GameObject POS_8;
    public GameObject POS_9;
    public GameObject POS_10;
    public GameObject POS_11;
    public GameObject POS_12;
    public GameObject POS_13;
    public GameObject POS_14;
    public GameObject POS_15;
    public GameObject POS_16;
    public GameObject POS_17;
    public GameObject POS_18;
    public GameObject POS_19;
    public GameObject POS_20;

    public GameObject COLLECTIBLE_PREFAB;

    public int COLLECTIBLE_AMOUNT;


  //  public int RANDOM_CHECKER_1;
    //public int RANDOM_CHECKER_2;
    //public int RANDOM_CHECKER_3;
    //public int RANDOM_CHECKER_4;
    //public int RANDOM_CHECKER_5;

    public int RANDOM_POSITION;
    public int POSITIONFILLER;

    bool SPACE_CHECKER_1=true;
    bool SPACE_CHECKER_2 = true;
    bool SPACE_CHECKER_3 = true;
    bool SPACE_CHECKER_4 = true;
    bool SPACE_CHECKER_5 = true;
    bool SPACE_CHECKER_6 = true;
    bool SPACE_CHECKER_7 = true;
    bool SPACE_CHECKER_8 = true;
    bool SPACE_CHECKER_9 = true;
    bool SPACE_CHECKER_10 = true;
    bool SPACE_CHECKER_11 = true;
    bool SPACE_CHECKER_12 = true;
    bool SPACE_CHECKER_13 = true;
    bool SPACE_CHECKER_14 = true;
    bool SPACE_CHECKER_15 = true;
    bool SPACE_CHECKER_16 = true;
    bool SPACE_CHECKER_17 = true;
    bool SPACE_CHECKER_18 = true;
    bool SPACE_CHECKER_19 = true;
    bool SPACE_CHECKER_20 = true;

    GameObject PREFAB_1;
    GameObject PREFAB_2;
    GameObject PREFAB_3;
    GameObject PREFAB_4;
    GameObject PREFAB_5;
    GameObject PREFAB_6;
    GameObject PREFAB_7;
    GameObject PREFAB_8;
    GameObject PREFAB_9;
    GameObject PREFAB_10;
    GameObject PREFAB_11;
    GameObject PREFAB_12;
    GameObject PREFAB_13;
    GameObject PREFAB_14;
    GameObject PREFAB_15;
    GameObject PREFAB_16;
    GameObject PREFAB_17;
    GameObject PREFAB_18;
    GameObject PREFAB_19;
    GameObject PREFAB_20;


    void Start()
    {
        SPACE_CHECKER_1 = true;
         SPACE_CHECKER_2 = true;
         SPACE_CHECKER_3 = true;
         SPACE_CHECKER_4 = true;
         SPACE_CHECKER_5 = true;
         SPACE_CHECKER_6 = true;
         SPACE_CHECKER_7 = true;
         SPACE_CHECKER_8 = true;
         SPACE_CHECKER_9 = true;
         SPACE_CHECKER_10 = true;
         SPACE_CHECKER_11 = true;
         SPACE_CHECKER_12 = true;
         SPACE_CHECKER_13 = true;
         SPACE_CHECKER_14 = true;
         SPACE_CHECKER_15 = true;
         SPACE_CHECKER_16 = true;
         SPACE_CHECKER_17 = true;
         SPACE_CHECKER_18 = true;
         SPACE_CHECKER_19 = true;
         SPACE_CHECKER_20 = true;
        // InvokeRepeating("COLLECTIBLE_GENERATOR", 2.0f, 0.3f);
        COLLECTIBLE_GENERATOR();


    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

     void   COLLECTIBLE_GENERATOR()
    {
        Debug.Log("COLLECTIBLE_FUNCTIONS");
        InvokeRepeating("destroyprefabs",0.1f,0.3f);
       
    }

    void destroyprefabs()
    {
        Debug.Log("destroyprefabs");

        if (COLLECTIBLE_AMOUNT < 10)
        {
            RANDOM_POSITION = Random.Range(1,21);
            if (RANDOM_POSITION==1&&SPACE_CHECKER_1==true)
            {
                PREFAB_1 = Instantiate(COLLECTIBLE_PREFAB, POS_1.transform.position, POS_1.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_1 = false;

            }
            if (RANDOM_POSITION == 2 && SPACE_CHECKER_2 == true)
            {
                PREFAB_2 = Instantiate(COLLECTIBLE_PREFAB, POS_2.transform.position, POS_2.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_2 = false;

            }
            if (RANDOM_POSITION == 3 && SPACE_CHECKER_3 == true)
            {
                PREFAB_3 = Instantiate(COLLECTIBLE_PREFAB, POS_3.transform.position, POS_3.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_3 = false;

            }
            if (RANDOM_POSITION == 4 && SPACE_CHECKER_4 == true)
            {
                PREFAB_4 = Instantiate(COLLECTIBLE_PREFAB, POS_4.transform.position, POS_4.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_4 = false;

            }
            if (RANDOM_POSITION == 5 && SPACE_CHECKER_5 == true)
            {
                PREFAB_5 = Instantiate(COLLECTIBLE_PREFAB, POS_5.transform.position, POS_5.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_5 = false;

            }
            if (RANDOM_POSITION == 6 && SPACE_CHECKER_6 == true)
            {
                PREFAB_6 = Instantiate(COLLECTIBLE_PREFAB, POS_6.transform.position, POS_6.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_6 = false;

            }
            if (RANDOM_POSITION == 7 && SPACE_CHECKER_7 == true)
            {
                PREFAB_7 = Instantiate(COLLECTIBLE_PREFAB, POS_7.transform.position, POS_7.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_7 = false;

            }
            if (RANDOM_POSITION == 8 && SPACE_CHECKER_8 == true)
            {
                PREFAB_8 = Instantiate(COLLECTIBLE_PREFAB, POS_8.transform.position, POS_8.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_8 = false;

            }
            if (RANDOM_POSITION == 9 && SPACE_CHECKER_9 == true)
            {
                PREFAB_9 = Instantiate(COLLECTIBLE_PREFAB, POS_9.transform.position, POS_9.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_9 = false;

            }
            if (RANDOM_POSITION == 10 && SPACE_CHECKER_10 == true)
            {
                PREFAB_10 = Instantiate(COLLECTIBLE_PREFAB, POS_10.transform.position, POS_10.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_10 = false;

            }
            if (RANDOM_POSITION == 11 && SPACE_CHECKER_11 == true)
            {
                PREFAB_11 = Instantiate(COLLECTIBLE_PREFAB, POS_11.transform.position, POS_11.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_11 = false;

            }
            if (RANDOM_POSITION == 12 && SPACE_CHECKER_12 == true)
            {
                PREFAB_12 = Instantiate(COLLECTIBLE_PREFAB, POS_12.transform.position, POS_12.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_12 = false;

            }
            if (RANDOM_POSITION == 13 && SPACE_CHECKER_13 == true)
            {
                PREFAB_13 = Instantiate(COLLECTIBLE_PREFAB, POS_13.transform.position, POS_13.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_13 = false;

            }
            if (RANDOM_POSITION == 14 && SPACE_CHECKER_14 == true)
            {
                PREFAB_14 = Instantiate(COLLECTIBLE_PREFAB, POS_14.transform.position, POS_14.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_14 = false;

            }
            if (RANDOM_POSITION == 15 && SPACE_CHECKER_15 == true)
            {
                PREFAB_15 = Instantiate(COLLECTIBLE_PREFAB, POS_15.transform.position, POS_15.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_15 = false;

            }
            if (RANDOM_POSITION == 16 && SPACE_CHECKER_16 == true)
            {
                PREFAB_16 = Instantiate(COLLECTIBLE_PREFAB, POS_16.transform.position, POS_16.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_16 = false;

            }
            if (RANDOM_POSITION == 17 && SPACE_CHECKER_17 == true)
            {
                PREFAB_17 = Instantiate(COLLECTIBLE_PREFAB, POS_17.transform.position, POS_17.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_17 = false;

            }
            if (RANDOM_POSITION == 18 && SPACE_CHECKER_18 == true)
            {
                PREFAB_18 = Instantiate(COLLECTIBLE_PREFAB, POS_18.transform.position, POS_18.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_18 = false;

            }
            if (RANDOM_POSITION == 19 && SPACE_CHECKER_19 == true)
            {
                PREFAB_19 = Instantiate(COLLECTIBLE_PREFAB, POS_19.transform.position, POS_19.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_19 = false;

            }
            if (RANDOM_POSITION == 20 && SPACE_CHECKER_20 == true)
            {
                PREFAB_20 = Instantiate(COLLECTIBLE_PREFAB, POS_20.transform.position, POS_20.transform.rotation);
                COLLECTIBLE_AMOUNT += 1;
                SPACE_CHECKER_20 = false;

            }

        }

    }
}

    
