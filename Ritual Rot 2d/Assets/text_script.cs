using UnityEngine;
using UnityEngine.UI;
public class text_script : MonoBehaviour
{
    public interaktion skrift;
    public Text interact_text;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (skrift == true)
        {
            // interact_text.enable = true;
            interact_text.gameObject.SetActive(true);
        }        
    }
}
