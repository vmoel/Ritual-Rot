using UnityEngine;
using UnityEngine.SceneManagement;

public class begynd : MonoBehaviour
{
    public void NæsteScene()
    {
        SceneManager.LoadScene("Main Scene");
    }
    public void Ending1()
    {
        SceneManager.LoadScene("Ending1");
    }

    public void Ending2()
    {
        SceneManager.LoadScene("Ending2");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
