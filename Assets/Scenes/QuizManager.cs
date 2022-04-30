using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI quizText;
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject resultPanel;
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject playGuidePanel;
    int[] primeNumbers = {2, 3, 5, 7};
    int quizNumber = 1;
    int randomNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        resetQuiz();
        closeMainPanel();
        closeResultPanel();
        closePlayGuidePanel();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void resetQuiz() {
        quizNumber = 1;
        while (quizNumber == 1) {
            for (int i = 0; i < primeNumbers.Length; i++) {
                randomNumber = UnityEngine.Random.Range(0, 4);
                if (randomNumber != 0) {
                    quizNumber *= primeNumbers[i] * randomNumber;
                }
            }
            quizText.text = quizNumber.ToString();
        }
    }

    public void pushPrimeButton(int buttonNumber) {
        if (quizNumber % buttonNumber == 0) {
            quizNumber /= buttonNumber;
            quizText.text = quizNumber.ToString();
        }

        if (quizNumber == 1) {
            openResultPanel();
        }
    }

    public void openMainPanel() {
        mainPanel.SetActive(true);
    }

    public void closeMainPanel() {
        mainPanel.SetActive(false);
    }

    public void openResultPanel() {
        resultPanel.SetActive(true);
    }

    public void closeResultPanel() {
        resultPanel.SetActive(false);
    }
    
    public void openMenuPanel() {
        menuPanel.SetActive(true);
    }

    public void closeMenuPanel() {
        menuPanel.SetActive(false);
    }
    
    public void openPlayGuidePanel() {
        playGuidePanel.SetActive(true);
    }

    public void closePlayGuidePanel() {
        playGuidePanel.SetActive(false);
    }
}
