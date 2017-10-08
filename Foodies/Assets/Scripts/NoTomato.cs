using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoTomato : MonoBehaviour
{

    public GameObject ChooseOtherRecipe;
    public GameObject stillGoingNext;
    public ClickToNextStep thisClick;
    public void noTomato()
    {
        ChooseOtherRecipe.SetActive(true);
    }
    public void noGarlic()
    {
        stillGoingNext.SetActive(true);
        StartCoroutine(waitOneSecond());
    }

    private IEnumerator waitOneSecond() {
        yield return new WaitForSeconds(2f);

        thisClick.NextStep();
    }
}
