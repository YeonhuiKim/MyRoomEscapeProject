using UnityEngine;
using UnityEngine.Events;

public class Password : MonoBehaviour
{
    public UnityEvent ClearQuest;

    [SerializeField] int[] correctNumbers;
    [SerializeField] PasswordButton[] passwordButtons;

    public void CheckCorrect()
    {
        if (isCorrect())
        {
            Debug.Log("패스워드 일치");
            ClearQuest.Invoke();
        }
    }
    bool isCorrect()
    {
        for(int i=0; i<correctNumbers.Length; i++)
        {
            if (passwordButtons[i].number != correctNumbers[i])
            {
                return false;
            }
        }

        return true;
    }
}
