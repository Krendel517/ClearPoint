using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClearBackground
{
    public class PolygonDisplay
    {
        PointF[] polygonAfterScale;

        private void SetNewPolygon(PointD[] polygon)
        {

            polygonAfterScale = new PointF[polygon.Length];

            for (int i = 0; i < polygon.Length; i++)
            {
                float simpleX = Convert.ToSingle(polygon[i].X);
                float simpleY = Convert.ToSingle(polygon[i].Y);
                polygonAfterScale[i].X = simpleX;
                polygonAfterScale[i].Y = simpleY;
            }
        }

        public void ScalingPolygon(PointD[] polygon)
        {
            SetNewPolygon(polygon);
            
            bool needToScaleX = false;
            bool needToScaleY = false;
            float[] scaleCoefficientX = new float[polygon.Length];
            float[] scaleCoefficientY = new float[polygon.Length];
            //max x=400 max y=220

            for (int i = 0; i < polygonAfterScale.Length; i++)
            {
                if (polygonAfterScale[i].X > 400)
                {
                    needToScaleX = true;
                    break;
                }
            }

            if (needToScaleX)
            {
                for (int i = 0; i < polygonAfterScale.Length; i++)
                {
                    scaleCoefficientX[i] = polygonAfterScale[i].X / 400;
                }

                float maxScaleX = scaleCoefficientX.Max();

                for (int i = 0; i < polygonAfterScale.Length; i++)
                {
                    polygonAfterScale[i].X = polygonAfterScale[i].X / maxScaleX;
                    polygonAfterScale[i].Y = polygonAfterScale[i].Y / maxScaleX;
                }
            }

            for (int i = 0; i < polygonAfterScale.Length; i++)
            {
                if (polygonAfterScale[i].Y > 220)
                {
                    needToScaleY = true;
                    break;
                }
            }

            if (needToScaleY)
            {
                for (int i = 0; i < polygonAfterScale.Length; i++)
                {
                    scaleCoefficientY[i] = polygonAfterScale[i].Y / 220;
                }

                float maxScaleY = scaleCoefficientY.Max();

                for (int i = 0; i < polygonAfterScale.Length; i++)
                {
                    polygonAfterScale[i].X = polygonAfterScale[i].X / maxScaleY;
                    polygonAfterScale[i].Y = polygonAfterScale[i].Y / maxScaleY;
                }
            }

            for (int i = 0; i < polygonAfterScale.Length; i++)
            {
                polygonAfterScale[i].X = polygonAfterScale[i].X;
                polygonAfterScale[i].Y = 220 - polygonAfterScale[i].Y;
            }

            DrawPolygon(polygonAfterScale);
        }
        
        private void DrawPolygon(PointF[] polygonAfterScale)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 1);
            graphics.DrawPolygon(pen, polygonAfterScale);
        }
    }
}
