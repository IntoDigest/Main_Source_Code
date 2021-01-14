/*
 * ใส่ใน OBJ ที่ใช้เป็นกุญแจ
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class three_keys : MonoBehaviour
{
    public GameObject Key1;
    public GameObject Key2;
    public GameObject Key3;
    public Text scenetoload;

    
    void Update(){
        if(destroyed(Key1) && destroyed(Key2) && destroyed(Key3)){
            SceneManager.LoadScene(scenetoload);
        }
    }

    void destroyed(GameObject name){
        if(name == null){
            return true;
        }
        return false;
    }
}
