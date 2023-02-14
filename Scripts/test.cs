using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{
    private Grid grid;
    private void Start(){
         grid  = new Grid(30,15,5f); 
    }

    private void Update() {
       if(Input.GetMouseButtonDown(0)){
            grid.SetValue(GetMouseWorldPosition(),56);
       } 
    }


    public static Vector3 GetMouseWorldPosition(){
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition,Camera.main);
        vec.z = 0f;
        return vec;
    }
    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition,Camera worldCamera){
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }
}
