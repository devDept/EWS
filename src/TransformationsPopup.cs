using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeshotWcfClientWinForms.EyeshotServiceRef;

namespace EyeshotWcfClientWinForms
{
    public enum TransformationType
    {
        Rotate,

        Translate,

        Scale
    }

    public partial class TransformationsPopup : Form
    {
        private EyeshotClient _eyeshotClient;   
        public TransformationsPopup()
        {
            InitializeComponent();
        }

        private string _transformationText = String.Empty;
        public string ShowDialog(EyeshotClient client, TransformationType transformationType)
        {
            _eyeshotClient = client;

            // Locks the popup size
            MinimumSize = MaximumSize = Size;
          
            switch (transformationType)
            {
                case TransformationType.Rotate:
                    grpTranslate.Enabled = grpScale.Enabled = false;                    
                    break;
                case TransformationType.Translate:
                    grpRotate.Enabled = grpScale.Enabled = false;
                    break;
                case TransformationType.Scale:
                    grpRotate.Enabled = grpTranslate.Enabled = false;
                    break;                
            }

            if (ShowDialog() != DialogResult.OK)
            {
                _transformationText = String.Empty;
            }
            return _transformationText;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            double radians = (double) numAngle.Value/180.0*Math.PI;

            _eyeshotClient.AddRotation(radians, (double) numVectorX.Value, (double) numVectorY.Value, (double) numVectorZ.Value, (double) numCenterX.Value, (double) numCenterY.Value, (double) numCenterZ.Value);
            _transformationText = String.Format("Rotate {0} degreees (Axis {1} {2} {3} - Center {4} {5} {6})", numAngle.Value, numVectorX.Value, numVectorY.Value, numVectorZ.Value, numCenterX.Value, numCenterY.Value, numCenterZ.Value);
            DialogResult = DialogResult.OK;
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            _eyeshotClient.AddTranslation((double) numTranslateX.Value, (double) numTranslateY.Value, (double) numTranslateZ.Value);
            _transformationText = String.Format("Translate to {0} {1} {2}", numTranslateX.Value, numTranslateY.Value, numTranslateZ.Value);
            DialogResult = DialogResult.OK;
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            _eyeshotClient.AddScaling((double) numScaleX.Value, (double) numScaleY.Value, (double) numScaleZ.Value);
            _transformationText = String.Format("Scale to {0} {1} {2}", numScaleX.Value, numScaleY.Value, numScaleZ.Value);
            DialogResult = DialogResult.OK;
        }
    }
}
