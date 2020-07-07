using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class COLLECTIBLE_MANAGER : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;

    public Text cube_txt;
    public int counter=0;
    
    string alphabets = "xm9";

    public string myString;
    int charAmount;
    public int a;
    public string first_alphabet;

    public string last_alphabet;
    void Start()
    {

        a = Random.Range(3, 8);
        GenrateRandomString();

    }

    void GeneratePallandrome()
    {
        string alphabets = "xm9";
        int charAmount = Random.Range(9, 15);
        string mstring = "";
        string reverse = "";
        for (int i = 1; i <= charAmount / 2; i++)
        {
            mstring += alphabets[Random.Range(0, alphabets.Length)];
        }
        int Length = (charAmount / 2) - 1;
        while (Length >= 0)
        {
            reverse = reverse + mstring[Length];
            Length--;
        }
        myString = mstring + reverse;
    }

    
    bool isPalindrome(string checkstring)
    {
        // Start from leftmost and rightmost corners of str 
        int l = 0;
        int h = checkstring.Length - 1;

        // Keep comparing characters while they are same 
        while (h > l)
        {
            if (checkstring[l++] != checkstring[h--])
            {
                
                return false;
            }
        }
        return true;
       
    }

    public void GenrateRandomString()
    {
        charAmount = Random.Range(9, 15);

       
        for (int i = 0; i <= charAmount; i++)
        {
            myString += alphabets[Random.Range(0, alphabets.Length)];

        }
        if (isPalindrome(myString))
        {
            counter++;
            cube.tag = "collectible";

        }
        else
        {
            counter++;
            cube.tag = "notcollectible";

        }
        if (GameObject.Find("PLAYER").GetComponent<PLAYER_CONTROLLER>().PALINDROMES_TOTAL < a)
        {
            if (counter >= 7)
            {
                GeneratePallandrome();
                counter++;
                cube.tag = "collectible";
                GameObject.Find("PLAYER").GetComponent<PLAYER_CONTROLLER>().PALINDROMES_TOTAL++;
            }

            else
            {
                GenrateRandomString();
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        cube_txt.text = myString;

       

        

    }

}
