using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste1
{
    public partial class Form1 : Form, Affdex.ImageListener
    {
        public Form1(Affdex.Detector detector)
        {
            detector.setImageListener(this);
            InitializeComponent();
        }
        public void onImageResults(Dictionary<int, Affdex.Face> faces, Affdex.Frame frame)
        {
            foreach(KeyValuePair<int, Affdex.Face> pair in faces)
            {
                Affdex.Face face = pair.Value;
                if(faces != null)
                {
                    foreach (PropertyInfo prop in typeof(Affdex.Emotions).GetProperties()){
                        float value = (float)prop.GetValue(face.Emotions, null);
                        String output = String.Format("{0}: {1:0.00}", prop.Name, value);
                        System.Console.WriteLine(output);
                    }
                }
            }
            frame.Dispose();
        }
        public void onImageCapture(Affdex.Frame frame)
        {
            frame.Dispose();
        }
    }
}
