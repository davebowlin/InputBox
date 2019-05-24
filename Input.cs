/* A simple C# class to function like the VisualBasic InputBox class
 * 
 * davebowlin@gmail.com
 * 24 May 2019
 *
 * Two strings as arguments: the question or message, and the title of the inputbox
 * 
 * Example use:     string myanswer = Input.ShowDialog("My question", "My title");
 *                  MessageBox.Show(myanswer);
 *                  
 *                  
 * Add a reference to System.Windows.Forms to create the inputbox form                
 */


using System.Windows.Forms;

public static class Input
{
    public static string ShowDialog(string message, string title)
    {
        TextBox txtInput = new TextBox()
        {
            Width = 200,
            Left = 10,
            Top = 50
        };

        Label lblMessage = new Label()
        {
            Text = message,
            Left = 10,
            Top = 20,
            AutoSize = true
        };

        Button btnOK = new Button()
        {
            Width = 60,
            Height = 20,
            Left = 250,
            Top = 50,
            Text = "OK",
            DialogResult = DialogResult.OK
        };

        Button btnCancel = new Button()
        {
            Width = 60,
            Height = 20,
            Left = 250,
            Top = 20,
            Text = "Cancel",
            DialogResult = DialogResult.Cancel
        };

        Form input = new Form()
        {
            Width = 350,
            Height = 150,
            Text = title,
            StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog
        };

        btnOK.Click += (sender, e) => { input.Close(); };

        input.Controls.Add(lblMessage);
        input.Controls.Add(txtInput);
        input.Controls.Add(btnOK);
        input.Controls.Add(btnCancel);

        return input.ShowDialog() == DialogResult.OK ? txtInput.Text : "";
    }
}
