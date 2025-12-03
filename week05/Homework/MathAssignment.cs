using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;


    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }


    public string GetTextbookSelection()
    {
        return _textbookSection;
    }

    public void SetTextbookSelection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }


    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }
}