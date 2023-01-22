using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazztelRK
{
    public partial class JazztelPriceViewer : Form
    {
        public JazztelPriceViewer()
        {
            InitializeComponent();
        }

        #region Resizing

        private Rectangle originalFormSize;
        private Dictionary<Control, OriginalProportion> originalSizes;
        private Boolean fontResizing = false;

        private class OriginalProportion
        {
            public Rectangle rectangle;
            public Font font;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(0, 0, this.Width, this.Height);
            originalSizes = new Dictionary<Control, OriginalProportion>();
            // for every control in the form
            foreach (Control control in getControls(this))
            {
                addControlSize(control);
            }
        }

        private List<Control> getControls(Control control)
        {
            List<Control> list = new List<Control>();
            foreach (Control childControl in control.Controls)
            {
                list.Add(childControl);
                list.AddRange(getControls(childControl));
            }
            return list;
        }

        private void rescale(Control control, float xFactor, float yFactor)
        {
            OriginalProportion original = originalSizes[control];
            // changes the size
            Rectangle originalSize = original.rectangle;
            control.Width = (int)(originalSize.Width * xFactor);
            control.Height = (int)(originalSize.Height * yFactor);
            control.Location = new Point((int)(originalSize.X * xFactor), (int)(originalSize.Y * yFactor));

            // changes the font
            if (control.GetType() == typeof(Label) && fontResizing)
            {
                Label controlLabel = (Label)control;
                Font originalFont = original.font;
                // picks the smallest factor
                float smallFactor = xFactor;
                if (yFactor < smallFactor) smallFactor = yFactor;

                float newSize = originalFont.Size * smallFactor;
                controlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", newSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void resize()
        { 
            float xFactor = (float)this.Width / (float)originalFormSize.Width;
            float yFactor = (float)this.Height / (float)originalFormSize.Height;

            foreach (Control control in originalSizes.Keys)
            {
                rescale(control, xFactor, yFactor);
            }
        }

        private void addControlSize(Control control)
        {
            OriginalProportion recPro = new OriginalProportion();
            recPro.rectangle = new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height);
            if (control.GetType() == typeof(Label))
            {
                Label controlLabel = (Label)control;
                recPro.font = controlLabel.Font;
            }
            originalSizes.Add(control, recPro);
        }

        public void addControlToForm(Control control)
        {
            addControlSize(control);
            resize();
        }

        #endregion
        private int posY = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            // Creates a label
            Label label = new Label();
            this.Content.Controls.Add(label);
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            posY += 40;
            label.Location = new System.Drawing.Point(376, 268 + posY);
            label.Name = "labelCreado";
            label.Size = new System.Drawing.Size(485, 37);
            label.Text = "Hola soy una fake etiqueta bonita";
            label.Click += new System.EventHandler(label1_Click);

            addControlToForm(label);
        }

        private void CheckBoxSpeed_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // check internet if not checked yet
            if (CheckBoxInternet.Checked == false)
            {
                CheckBoxInternet.Checked = true;
            }

            // uncheck other boxes
            for (int i = 0; i < CheckBoxSpeed.Items.Count; i++)
            {
                if( e.Index == i ) { continue; }
                CheckBoxSpeed.SetItemChecked(i, false);
            }
        }
        

        private void CheckBoxInternet_Click(object sender, EventArgs e)
        { 
            // if checked, uncheck all the other items
            if(CheckBoxInternet.Checked == false)
            {
                for (int i = 0; i < CheckBoxSpeed.Items.Count; i++)
                {
                    CheckBoxSpeed.SetItemChecked(i, false);
                }
                CheckBoxInternet.Checked = false;
            }
        }
    }
}
