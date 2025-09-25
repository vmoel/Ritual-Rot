using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Ending1 : MonoBehaviour
{
    public Text Hovedtext;
    public Button Interknap;

    historien nuværendeBlock;

    static historien block4 = new historien("Nu er det slut", "slut");
    static historien block3 = new historien("yubi", "næste", block4);
    static historien block2 = new historien("Nummer 1 kult entusiast", "næste", block3);
    static historien block1 = new historien("Du valgte at være kult fan!!", "næste", block2);



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HvisBlock(block1);
    }

    void HvisBlock(historien block)
    {
        Hovedtext.text = block.skriften;
        Interknap.GetComponentInChildren<Text>().text = block.næste;

        nuværendeBlock = block;
    }

    public void berørtknap()
    {
        HvisBlock(nuværendeBlock.næsteknapBlock);
    }
    



}
