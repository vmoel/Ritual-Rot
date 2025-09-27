using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Ending2 : MonoBehaviour
{
    public Text Hovedtext;
    public Button Interknap;

    historien nuværendeBlock;

    static historien block5 = new historien("Måske ville det have ændret sig hvis du havde taget det andet valg?", "", null);
    static historien block4 = new historien("Hvor skal du hen nu? Og hvem kan du stole på? Du føler dig alene og alt virker truende.", "næste", block5);
    static historien block3 = new historien("Du slap væk med et enkelte par ridser, men befinder dig nu i en del af byen du aldrig har set før.", "næste", block4);
    static historien block2 = new historien("Efter din beslutning blev du jaget af ridderen, men så stor og farlig han var, så langsom og opbrugt blev han.", "næste", block3);
    static historien block1 = new historien("Du valgte at beskytte dit folk, at frelse dem endnu en dag til at planlægge deres oprejsning.", "næste", block2);



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

