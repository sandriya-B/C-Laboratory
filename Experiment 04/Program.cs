using System;

class Button
{
    // Delegate
    public delegate void ButtonClickHandler();

    // Event
    public event ButtonClickHandler? ButtonClicked;

    // Method to raise the event
    public void Click()
    {
        Console.WriteLine("Button is clicked!");

        ButtonClicked?.Invoke();
    }
}

class Program
{
    // Event handler method
    static void ShowMessage()
    {
        Console.WriteLine("Hello! Button click event handled.");
    }

    static void Main()
    {
        Button btn = new Button();

        // Connect the method to the event
        btn.ButtonClicked += ShowMessage;

        // Simulate button click
        btn.Click();

        Console.ReadLine();
    }
}