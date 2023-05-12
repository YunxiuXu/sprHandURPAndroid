using UnityEngine;

public class DeskFinder : MonoBehaviour
{
    public GameObject DeskCenter;
    void Start()
    {
    }
    int isFind = 0;
    void Update(){
        
        if(isFind == 0){
            GameObject[] cubes = GameObject.FindObjectsOfType<GameObject>();

            foreach (GameObject cube in cubes)
            {
                if (cube.name == "Parent")
                {
                    if(cube.layer == 9){//Furniture{
                        DeskCenter.transform.position = cube.transform.position;
                        DeskCenter.transform.rotation = cube.transform.rotation;
                        isFind = 1;
                    }
                    // 找到了名称为"Cube"的物体
                    // 在这里进行你想要的操作
                    
                }
            }
            
        }
        
    }
}
