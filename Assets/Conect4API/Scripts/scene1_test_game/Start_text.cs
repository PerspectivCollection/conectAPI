using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;

using Content4API.Scripts;

public class Start_text : MonoBehaviour
{

    public GameObject canvas;

    public InputField input_txt;
    public GameObject button;

    //clum
    public InputField input_colon;  
    public GameObject button2;  

    public GameObject canvas2;


    public GameObject player_text1;
    public GameObject player_text2;

    private List<string> OList = new List<string>();

    GameObject gameOFile;


    //create game objet from scratch
    public GameObject prefabtospawn;
   

    public GameObject R_player1;
    public GameObject R_player2;

    int[,] field;


    int colum_chek = 8;
    int row_chek = 8;

    void Start()
    {
        canvas2.SetActive(false);
        canvas.SetActive(true);

        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(startGame);  

        
        Button btn2 = button2.GetComponent<Button>();
        btn2.onClick.AddListener(Player1);     
        
        //create objet from sc scratch
        // GameObject G = Instantiate(prefabtospawn, new Vector3(1 * 2.0f, 0, 0), Quaternion.identity) as GameObject;

        //create from crhac in code vs
        gameOFile = GameObject.Find("rute");

        field = new int[colum_chek, row_chek];

        // Red places to put a pice
        for (var x = 0; x < colum_chek; x++){
            for (var y = 0; y < row_chek; y++){
            // field [x,y] = (int)Pice.Empty; //save pice
             GameObject gRute = Instantiate(prefabtospawn, new Vector3(x, y * -1 , -1), Quaternion.identity) as GameObject;
             gRute.transform.parent = gameOFile.transform;
             }
        }
    }

    private List<string> sum_mid = new List<string>();

    void Player1(){
        // int onlyNum = Convert.ToInt32(input_colon.text);
        Debug.Log(" ");
        Debug.Log( "her er input" + input_colon.text);

            int x = Convert.ToInt32(input_colon.text); //input
            int sett_x = x - 1;
            int inp = 7; //input
            for (int i = row_chek-1; i >= 0; i--){
                if (field[sett_x, i] == 0){
                    GameObject P1 = Instantiate(R_player1, new Vector3(sett_x, inp * -1, -1), Quaternion.identity) as GameObject;
                    check_winner();
                    sum_mid.Add("1");
                    return;
                } 
            }
        }

    void check_winner(){ 
        if (sum_mid.Count >= 3){
        Debug.Log("this is the winner");
        }
    }

    void Update(){
    }

    void startGame(){
        Debug.Log("input: " + input_txt.text);
        OList.Add(input_txt.text);
        string result = string.Join(",", OList.ToArray());

        Debug.Log(result);
        Debug.Log("første index " + OList[0]);

        if (OList.Count == 2){
            canvas.SetActive(false);
            canvas2.SetActive(true);
        }
        input_txt.text = "";

        player_text1.GetComponent<Text>().text = OList[0];
        player_text2.GetComponent<Text>().text = OList[1];
    }
}
