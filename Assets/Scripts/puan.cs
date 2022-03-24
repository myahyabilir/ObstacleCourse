using UnityEngine;
using UnityEngine.UI;

public class puan : MonoBehaviour
{
    public Text puanArea;
    public Transform cubeTransformer;
    void Start()
    {
        
    }

    void Update()
    {
        
        puanArea.text = cubeTransformer.position.z.ToString("0");
    }
}
