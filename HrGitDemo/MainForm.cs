using System;
using System.Drawing;
using System.Windows.Forms;

namespace HrGitDemo
{
    public class MainForm : Form
    {
        private readonly Label title = new Label();
        private readonly Button openFormButton = new Button();

        public MainForm()
        {
            Text = "GitHub — лабораторная работа 4";
            Width = 600;
            Height = 350;
            StartPosition = FormStartPosition.CenterScreen;

            title.Text = "Демонстрация Git и ветвления";
            var branchLabel = new Label { Text = "Функция из ветки Addfunction", AutoSize = true, Location = new Point(180, 205) };
            Controls.Add(branchLabel);
            title.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            title.AutoSize = true;
            title.Location = new Point(120, 70);

            openFormButton.Text = "Открыть вторую форму";
            openFormButton.Size = new Size(220, 45);
            openFormButton.Location = new Point(180, 145);
            openFormButton.Click += OpenFormButton_Click;

            Controls.Add(title);
            Controls.Add(openFormButton);
        }

        private void OpenFormButton_Click(object sender, EventArgs e)
        {
            using (var form = new SecondForm())
                form.ShowDialog(this);
        }
    }
}
