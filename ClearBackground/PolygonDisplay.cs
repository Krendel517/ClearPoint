using System;
using System.Drawing;
using System.Linq;

namespace ClearBackground
{
    public class PolygonDisplay
    {
        private bool needToScaleX = false;
        private bool needToScaleY = false;
        private float xAxisSizeOfPolygon;
        private float yAxisSizeOfPolygon;
        private PointF[] polygonPointsAfterScale;
        private float[] scaleCoefficientX;
        private float[] scaleCoefficientY;
        private float heightOfPicture = 220;
        private float widthOfPicture = 400;
        private PointF centerOfPicturebox = new PointF(200, 110);

        public PointF[] PolygonPoints => polygonPointsAfterScale;

        public void ScalingPolygon(PointD[] polygon)
        {
            SetPolygon(polygon);
            CheckScalingForX();
            XReductionToCoordinateSystem();
            CheckScalingForY();
            YReductionToCoordinateSystem();
            CenteringPolygon();
            StretchingPolygon();
        }

        private void SetPolygon(PointD[] polygon)
        {
            polygonPointsAfterScale = new PointF[polygon.Length];

            for (int i = 0; i < polygon.Length; i++)
            {
                float simpleX = Convert.ToSingle(polygon[i].X);
                float simpleY = Convert.ToSingle(polygon[i].Y);
                polygonPointsAfterScale[i].X = simpleX;
                polygonPointsAfterScale[i].Y = simpleY;
            }

            scaleCoefficientX = new float[polygon.Length];
            scaleCoefficientY = new float[polygon.Length];
        }

        private void CheckScalingForX()
        {
            for (int i = 0; i < polygonPointsAfterScale.Length; i++)
            {
                if (polygonPointsAfterScale[i].X > widthOfPicture)
                {
                    needToScaleX = true;
                    break;
                }
            }
        }

        private void CheckScalingForY()
        {
            for (int i = 0; i < polygonPointsAfterScale.Length; i++)
            {
                if (polygonPointsAfterScale[i].Y > heightOfPicture)
                {
                    needToScaleY = true;
                    break;
                }
            }
        }

        private void XReductionToCoordinateSystem()
        {
            if (needToScaleX)
            {
                for (int i = 0; i < polygonPointsAfterScale.Length; i++)
                {
                    scaleCoefficientX[i] = polygonPointsAfterScale[i].X / widthOfPicture;
                }

                float maxScaleX = scaleCoefficientX.Max();

                for (int i = 0; i < polygonPointsAfterScale.Length; i++)
                {
                    polygonPointsAfterScale[i].X = polygonPointsAfterScale[i].X / maxScaleX;
                    polygonPointsAfterScale[i].Y = polygonPointsAfterScale[i].Y / maxScaleX;
                }
            }
        }

        private void YReductionToCoordinateSystem()
        {
            if (needToScaleY)
            {
                for (int i = 0; i < polygonPointsAfterScale.Length; i++)
                {
                    scaleCoefficientY[i] = polygonPointsAfterScale[i].Y / heightOfPicture;
                }

                float maxScaleY = scaleCoefficientY.Max();

                for (int i = 0; i < polygonPointsAfterScale.Length; i++)
                {
                    polygonPointsAfterScale[i].X = polygonPointsAfterScale[i].X / maxScaleY;
                    polygonPointsAfterScale[i].Y = polygonPointsAfterScale[i].Y / maxScaleY;
                }
            }
        }

        private void CenteringPolygon()
        {
            float[] coordinateYAfterScale = new float[polygonPointsAfterScale.Length];
            float[] coordinateXAfterScale = new float[polygonPointsAfterScale.Length];

            for (int i = 0; i < polygonPointsAfterScale.Length; i++)
            {
                coordinateYAfterScale[i] = polygonPointsAfterScale[i].Y;
            }

            for (int i = 0; i < polygonPointsAfterScale.Length; i++)
            {
                coordinateXAfterScale[i] = polygonPointsAfterScale[i].X;
            }

            float maxY = coordinateYAfterScale.Max();
            float minY = coordinateYAfterScale.Min();
            yAxisSizeOfPolygon = maxY - minY;
            float displaceDistanceY = (heightOfPicture - yAxisSizeOfPolygon) / 2;

            float maxX = coordinateXAfterScale.Max();
            float minX = coordinateXAfterScale.Min();
            xAxisSizeOfPolygon = maxX - minX;
            float displaceDistanceX = (widthOfPicture - xAxisSizeOfPolygon) / 2;

            for (int i = 0; i < polygonPointsAfterScale.Length; i++)
            {
                polygonPointsAfterScale[i].X = polygonPointsAfterScale[i].X - minX + displaceDistanceX;
                polygonPointsAfterScale[i].Y = polygonPointsAfterScale[i].Y * (-1) + maxY + displaceDistanceY;
            }
        }

        private void StretchingPolygon()
        {
            float vectorCoordinateX;
            float vectorCoordinateY;
            int preventingOverscale = 1;
            float doubledPolygonSizeX = xAxisSizeOfPolygon * 2;
            float doubledPolygonSizeY = yAxisSizeOfPolygon * 2;

            for (int i = 0; i < polygonPointsAfterScale.Length; i++)
            {
                if (doubledPolygonSizeX > widthOfPicture || doubledPolygonSizeY > heightOfPicture)
                {
                    break;
                }

                if (widthOfPicture / xAxisSizeOfPolygon > heightOfPicture / yAxisSizeOfPolygon)
                {
                    int xSizeDifference = Convert.ToInt32(widthOfPicture / xAxisSizeOfPolygon);
                    int halfSizeDifferenceX = xSizeDifference / 2;

                    vectorCoordinateX = polygonPointsAfterScale[i].X - centerOfPicturebox.X;
                    vectorCoordinateY = polygonPointsAfterScale[i].Y - centerOfPicturebox.Y;
                    polygonPointsAfterScale[i].X = polygonPointsAfterScale[i].X + vectorCoordinateX * (halfSizeDifferenceX - preventingOverscale);
                    polygonPointsAfterScale[i].Y = polygonPointsAfterScale[i].Y + vectorCoordinateY * (halfSizeDifferenceX - preventingOverscale);

                }
                else if (heightOfPicture / yAxisSizeOfPolygon > widthOfPicture / xAxisSizeOfPolygon)
                {
                    int ySizeDifference = Convert.ToInt32(heightOfPicture / yAxisSizeOfPolygon);
                    int halfSizeDifferenceY = ySizeDifference / 2;

                    vectorCoordinateX = polygonPointsAfterScale[i].X - centerOfPicturebox.X;
                    vectorCoordinateY = polygonPointsAfterScale[i].Y - centerOfPicturebox.Y;
                    polygonPointsAfterScale[i].X = polygonPointsAfterScale[i].X + vectorCoordinateX * (halfSizeDifferenceY - preventingOverscale);
                    polygonPointsAfterScale[i].Y = polygonPointsAfterScale[i].Y + vectorCoordinateY * (halfSizeDifferenceY - preventingOverscale);

                }
            }
        }
    }
}
