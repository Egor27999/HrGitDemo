using System.Drawing;
using System.Windows.Forms;

namespace HrGitDemo
{
    public class SecondForm : Form
    {
        public SecondForm()
        {
            Text = "Вторая форма";
            Width = 420;
            Height = 220;
            StartPosition = FormStartPosition.CenterParent;

            var label = new Label
            {
                Text = "Переход между формами работает!",
                AutoSize = true,
                Font = new Font("Segoe UI", 13),
                Location = new Point(75, 70)
            };
            Controls.Add(label);
        }
    }
}
