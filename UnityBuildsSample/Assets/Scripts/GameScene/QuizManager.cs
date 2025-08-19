using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuizData> quizList;

    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private Button oButton;
    [SerializeField] private Button xButton;

    private int currentQuizIndex = 0;

    void Start()
    {
        oButton.onClick.AddListener(() => CheckAnswer(Answer.O));
        xButton.onClick.AddListener(() => CheckAnswer(Answer.X));

        LoadQuiz();
    }

    private void LoadQuiz()
    {

        if (currentQuizIndex >= quizList.Count)
        {

            Debug.Log("모든 퀴즈를 완료했습니다!");
            return;
        }

        QuizData currentQuiz = quizList[currentQuizIndex];
        questionText.text = $"Q{currentQuizIndex + 1}. {currentQuiz.QuestionText}";
    }

    private void CheckAnswer(Answer playerAnswer)
    {
        Answer correctAnswer = quizList[currentQuizIndex].CorrectAnswer;

        if (playerAnswer == correctAnswer)
        {
            Debug.Log("정답입니다!");
        }
        else
        {
            Debug.Log("오답입니다.");
        }

        currentQuizIndex++;
        LoadQuiz();
    }
}