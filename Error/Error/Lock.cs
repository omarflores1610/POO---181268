using System;
using System.IO;

abstract class Lock
{
    private int secretCode;
    private bool open;
    private int hintsUsed;

    protected int maxAttempts;
    protected int attempts;
    protected int hintsPerAttempt;
    protected string title;
    protected string description;
    protected string[] hints;

    public Lock(int secretCode, int maxAttempts)
    {
        this.secretCode = secretCode;
        this.maxAttempts = maxAttempts;

        attempts = 0;
        open = false;
        hintsUsed = 0;
        hintsPerAttempt = 1;
    }

    public bool GetOpen()
    {
        return open;
    }

    public int GetAttempts()
    {
        return attempts;
    }

    public int GetMaxAttempts()
    {
        return maxAttempts;
    }

    public int GetHintsPerAttempt()
    {
        return hintsPerAttempt;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetDescription()
    {
        return description;
    }

    public int GetHintsLength()
    {
        return hints.Length;
    }

    public bool GetNoAttemptsLeft()
    {
        if (open == false && attempts >= maxAttempts)
        {
            return true;
        }

        return false;
    }

    public bool TryOpen(string answer)
    {
        int code;

        attempts++;

        if (!int.TryParse(answer, out code))
        {
            Console.WriteLine("Debes escribir un número válido.");
            return false;
        }

        if (code == secretCode)
        {
            open = true;
            return true;
        }

        return false;
    }

    public bool TryOpen(int code)
    {
        attempts++;

        if (code == secretCode)
        {
            open = true;
            return true;
        }

        return false;
    }

    public string GiveHint()
    {
        if (hintsUsed >= hints.Length)
        {
            return hints[hints.Length - 1];
        }

        string hint = hints[hintsUsed];
        hintsUsed++;

        return hint;
    }

    public string GiveHint(int index)
    {
        if (index < 0 || index >= hints.Length)
        {
            return hints[hints.Length - 1];
        }

        return hints[index];
    }

    public abstract void OpenResource(string folder);
}