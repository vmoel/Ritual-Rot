using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Ending1 : MonoBehaviour
{
    public Text Hovedtext;
    public Button Interknap;

    historien nuværendeBlock;

    static historien block5 = new historien("Måske ville det have ændret sig hvis du havde taget det andet valg?", "",null);
    static historien block4 = new historien("Her blev de sidste zombier fanget og låst inde, efterfulgt af en ny jubilæumsdag som paven havde bestemt sig for at kalde befrielsesdagen.", "næste", block5);
    static historien block3 = new historien("Efter din beslutning meldte ridderen det til hans øverste som på samme dag tog sit kompagni af riddere og lå i baghold til aftens begyndelse.", "næste", block4);
    static historien block2 = new historien("De var zombiernes håb, og du var deres, men nu er der intet.", "næste", block3);
    static historien block1 = new historien("Du valgte at forråde dit eget folk, at forsynde dem til døds.", "næste", block2);



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
