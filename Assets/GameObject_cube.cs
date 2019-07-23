using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_cube : MonoBehaviour
{

public static GameObject[,] prefabsballs;

    [SerializeField]
    public int Amount = 10;

    [SerializeField]
    int step = 3;

    [Header("Prefab")]
    public GameObject prefabboal;
 

    // Start is called before the first frame update
    void Start()
    {
        prefabsballs = new GameObject[Amount, Amount];

        for (int j = 0; j < Amount; j++)
        {

            for (int i = 0; i < Amount; i++)
            {
                prefabsballs[i, j] = Instantiate(prefabboal, new Vector3(j * 3, 0, i * step), Quaternion.identity);
            }

        }
    }


}
