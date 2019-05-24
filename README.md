# InputBox
A simple C# class that mimics the Visual Basic InputBox class.
Takes two strings as arguments: the question/information, and a title for the inputbox.

Example use:

string myAnswer = Input.ShowDialog("My question", "My title");
MessageBox.Show(myAnswer);
