using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gameManager : MonoBehaviour
{
    bool isFinished = false;
    public cubeMovement controlAllowed;
    public GameObject whiteOfDeath;
    public GameObject blueOfSucess;
    public Text pointOfSucces;
    public Text pointOfDeath;
    public Transform cubeTransformer;
    [SerializeField] Button restartButtonOfSuccess;
    [SerializeField] Button restartButtonOfFailure;


    public void EndGame(){
        if(!isFinished){
            isFinished = true;
            controlAllowed.enabled = false;
            whiteOfDeath.SetActive(true);
            pointOfDeath.text = cubeTransformer.position.z.ToString("0");

        }
    }

    public void SuccessfullyFinished(){ 
        if(!isFinished){
            isFinished = true;
            controlAllowed.enabled = false;
            blueOfSucess.SetActive(true);
            pointOfSucces.text = cubeTransformer.position.z.ToString("0");
            
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
