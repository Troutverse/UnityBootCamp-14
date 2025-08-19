using UnityEngine;

public enum Answer
{
    O,
    X
}
[System.Serializable]
public class QuizData
{
    [TextArea(3, 5)]
    public string QuestionText;
    public Answer CorrectAnswer;
}
