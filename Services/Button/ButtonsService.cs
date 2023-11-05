using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Chat.Services.Button
{
    public partial class ButtonsService : Form
    {
        public ButtonsService(){}

        public void GeneratingButtons(ButtonBase button, string textButton, Bitmap backgroundImage, Bitmap image, Color borderColor, Color textColor,
            int borderSize, int fontSize, Point point, string nameButton, Size sizeButton, EventHandler ev)
        {
            button.Text = textButton;
            button.BackColor = Color.Transparent;
            button.BackgroundImage = backgroundImage;
            button.Image = image;
            button.BackgroundImageLayout = ImageLayout.Zoom; //none
            button.FlatAppearance.BorderColor = borderColor;
            button.FlatAppearance.BorderSize = borderSize;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Comic Sans MS", fontSize, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
            button.ForeColor = textColor;
            button.Location = point;
            button.Margin = new Padding(0);
            button.Name = nameButton;
            button.Size = sizeButton;
            button.TextImageRelation = TextImageRelation.TextBeforeImage;
            button.UseVisualStyleBackColor = false;
            button.Click += ev;
        }
    }
}
