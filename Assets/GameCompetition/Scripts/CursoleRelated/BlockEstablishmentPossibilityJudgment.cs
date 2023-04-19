//BlockÇê›íuÇ≈Ç´ÇÈÇ©îªíËÇ∑ÇÈ
using UnityEngine;

public class BlockEstablishmentPossibilityJudgment : MonoBehaviour
{
    public bool TateIs, YokoIs;

    private void Start()
    {
        TateIs = true;
        YokoIs = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Block")
        {
            TateIs = false;
            YokoIs = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Block")
        {
            TateIs = false;
            YokoIs = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Block")
        {
            TateIs = true;
            YokoIs = true;
        }
    }
}
