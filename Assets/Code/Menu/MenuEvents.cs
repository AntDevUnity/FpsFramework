using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuEvents : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    //event TestGame(){
    
    //}
    public void NewGame(){

        SceneManager.LoadScene(2);

    }

}
