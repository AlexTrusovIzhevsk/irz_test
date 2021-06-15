using System;
using System.Diagnostics;
using System.Windows.Forms;
using IRZ_Task2_OnTheKneeStyle_Classes;

namespace IRZ_Task2_OnTheKneeStyle_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Data data;

        private void requestButton_Click(object sender, EventArgs e)
        {
            
            var link = LinkTextBox.Text;
            var title = titleTextBox.Text;
            var author = authorTextBox.Text;

            if (link == string.Empty)
                resultTextBox.Text = "link is empty";
            else if (title == string.Empty)
                resultTextBox.Text = "title is empty";
            else if (author == string.Empty)
                resultTextBox.Text = "author is empty";
            else
            {
                try
                {
                    data = DataManager.GetDataFromWeb(title, author, link);
                    resultTextBox.Text = data.Answered;
                }
                catch (Exception exception)
                {
                    ShowException(exception);
                }
            }
        }

        private void saveXmlButton_Click(object sender, EventArgs e)
        {
            var path = pathSaveTextBox.Text;

            if (data is null)
                resultTextBox.Text = "data is null";
            else if(path == string.Empty)
                resultTextBox.Text = "path is empty";
            else
            {
                try
                {
                    DataManager.SaveDataToFile(data, path + ".xml");
                    resultTextBox.Text = "Data saved";
                }
                catch(Exception exception)
                {
                    ShowException(exception);
                }
            }
        }

        private void loadFromXmlButton_Click(object sender, EventArgs e)
        {
            var path = pathLoadTextBox.Text;
            if (path == string.Empty)
                resultTextBox.Text = "path is empty";
            else
            {
                try
                {
                    data = DataManager.ReadDataFromFile(path);
                    resultTextBox.Text = data.Answered;
                    authorTextBox.Text = data.Author;
                    titleTextBox.Text = data.Title;
                }
                catch (Exception exception)
                {
                    ShowException(exception);
                }
            }
        }

        private void saveHtmlButton_Click(object sender, EventArgs e)
        {
            var path = pathSaveTextBox.Text;

            if (data is null)
                resultTextBox.Text = "data is null";
            else if (path == string.Empty)
                resultTextBox.Text = "path is empty";
            else
            {
                try
                {
                    DataManager.SaveDataAsHtmlToFile(data, path + ".html");
                    resultTextBox.Text = "Data saved";
                }
                catch (Exception exception)
                {
                    ShowException(exception);
                }
            }
        }

        private void OpenInBrowser_Click(object sender, EventArgs e)
        {
            if (data is null)
                resultTextBox.Text = "data is null";
            else
            {
                //It is bad solution, but I leave till refactoring.
                saveHtmlButton_Click(null,null);
                var path = pathSaveTextBox.Text + ".html";
                Process.Start("explorer", path);
            }
        }

        private void ShowException(Exception exception)
        {
            var textException = string.Empty;
            while (exception != null)
            {
                textException += exception.Message + "\n\n";
                exception = exception.InnerException;
            }
            resultTextBox.Text = textException;
        }
    }
}
