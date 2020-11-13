using System;
using System.Windows.Forms;

class Change
{
  static void Main()
  {
    Form window = new Form();
    addButton("Upper case", 10, 10, window);
    addTextBox("The text can be made to all upper or lower case", 10, 40, window);
    addButton("Lower case", 10, 70, window);
    
    window.Text = "Change";
    Application.Run(window);
  }
  
  static void addLabel(string text, int left, int top, Form window)
  {
    Label label = new Label();
    label.Text = text;
    label.Left = left;
    label.Top  = top;
    label.Height = 20;
    window.Controls.Add(label);
  }
  
  static void addButton(string text, int left, int top, Form window)
  {
    Button label = new Button();
    label.Text = text;
    label.Left = left;
    label.Top  = top;
//    label.Height = 20;
    window.Controls.Add(label);
  }
  
  static void addTextBox(string text, int left, int top, Form window)
  {
    TextBox label = new TextBox();
    label.Text = text;
    label.Left = left;
    label.Top  = top;
    label.Width = window.Width - left - 20;
    window.Controls.Add(label);
  }
}