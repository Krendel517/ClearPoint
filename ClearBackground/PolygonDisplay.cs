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
        private PointF[] polygonPoints;
        private float[] scaleCoefficientX;
        private float[] scaleCoefficientY;
        private float heightOfPicture = 220;
        private float widthOfPicture = 400;
        private PointF centerOfPicturebox = new PointF(200, 110);

        public PointF[] PolygonPoints => polygonPoints;

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
            polygonPoints = new PointF[polygon.Length];

            for (int i = 0; i < polygon.Length; i++)
            {
                float simpleX = Convert.ToSingle(polygon[i].X);
                float simpleY = Convert.ToSingle(polygon[i].Y);
                polygonPoints[i].X = simpleX;
                polygonPoints[i].Y = simpleY;
            }

            scaleCoefficientX = new float[polygon.Length];
            scaleCoefficientY = new float[polygon.Length];
        }

        private void CheckScalingForX()
        {
            for (int i = 0; i < polygonPoints.Length; i++)
            {
                if (polygonPoints[i].X > widthOfPicture)
                {
                    needToScaleX = true;
                    break;
                }
            }
        }

        private void CheckScalingForY()
        {
            for (int i = 0; i < polygonPoints.Length; i++)
            {
                if (polygonPoints[i].Y > heightOfPicture)
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
                for (int i = 0; i < polygonPoints.Length; i++)
                {
                    scaleCoefficientX[i] = polygonPoints[i].X / widthOfPicture;
                }

                float maxScaleX = scaleCoefficientX.Max();

                for (int i = 0; i < polygonPoints.Length; i++)
                {
                    polygonPoints[i].X = polygonPoints[i].X / maxScaleX;
                    polygonPoints[i].Y = polygonPoints[i].Y / maxScaleX;
                }
            }
        }

        private void YReductionToCoordinateSystem()
        {
            if (needToScaleY)
            {
                for (int i = 0; i < polygonPoints.Length; i++)
                {
                    scaleCoefficientY[i] = polygonPoints[i].Y / heightOfPicture;
                }

                float maxScaleY = scaleCoefficientY.Max();

                for (int i = 0; i < polygonPoints.Length; i++)
                {
                    polygonPoints[i].X = polygonPoints[i].X / maxScaleY;
                    polygonPoints[i].Y = polygonPoints[i].Y / maxScaleY;
                }
            }
        }

        private void CenteringPolygon()
        {
            float[] coordinateYAfterScale = new float[polygonPoints.Length];
            float[] coordinateXAfterScale = new float[polygonPoints.Length];

            for (int i = 0; i < polygonPoints.Length; i++)
            {
                coordinateYAfterScale[i] = polygonPoints[i].Y;
            }

            for (int i = 0; i < polygonPoints.Length; i++)
            {
                coordinateXAfterScale[i] = polygonPoints[i].X;
            }

            float maxY = coordinateYAfterScale.Max();
            float minY = coordinateYAfterScale.Min();
            yAxisSizeOfPolygon = maxY - minY;
            float displaceDistanceY = (heightOfPicture - yAxisSizeOfPolygon) / 2;

            float maxX = coordinateXAfterScale.Max();
            float minX = coordinateXAfterScale.Min();
            xAxisSizeOfPolygon = maxX - minX;
            float displaceDistanceX = (widthOfPicture - xAxisSizeOfPolygon) / 2;

            for (int i = 0; i < polygonPoints.Length; i++)
            {
                polygonPoints[i].X = polygonPoints[i].X - minX + displaceDistanceX;
                polygonPoints[i].Y = polygonPoints[i].Y * (-1) + maxY + displaceDistanceY;
            }
        }

        private void StretchingPolygon()
        {
            float vectorCoordinateX;
            float vectorCoordinateY;
            int preventingOverscale = 1;
            float doubledPolygonSizeX = xAxisSizeOfPolygon * 2;
            float doubledPolygonSizeY = yAxisSizeOfPolygon * 2;

            for (int i = 0; i < polygonPoints.Length; i++)
            {
                if (doubledPolygonSizeX > widthOfPicture || doubledPolygonSizeY > heightOfPicture)
                {
                    break;
                }

                if (widthOfPicture / xAxisSizeOfPolygon > heightOfPicture / yAxisSizeOfPolygon)
                {
                    int xSizeDifference = Convert.ToInt32(widthOfPicture / xAxisSizeOfPolygon);
                    int halfSizeDifferenceX = xSizeDifference / 2;

                    vectorCoordinateX = polygonPoints[i].X - centerOfPicturebox.X;
                    vectorCoordinateY = polygonPoints[i].Y - centerOfPicturebox.Y;
                    polygonPoints[i].X = polygonPoints[i].X + vectorCoordinateX * (halfSizeDifferenceX - preventingOverscale);
                    polygonPoints[i].Y = polygonPoints[i].Y + vectorCoordinateY * (halfSizeDifferenceX - preventingOverscale);
                }
                else if (heightOfPicture / yAxisSizeOfPolygon > widthOfPicture / xAxisSizeOfPolygon)
                {
                    int ySizeDifference = Convert.ToInt32(heightOfPicture / yAxisSizeOfPolygon);
                    int halfSizeDifferenceY = ySizeDifference / 2;

                    vectorCoordinateX = polygonPoints[i].X - centerOfPicturebox.X;
                    vectorCoordinateY = polygonPoints[i].Y - centerOfPicturebox.Y;
                    polygonPoints[i].X = polygonPoints[i].X + vectorCoordinateX * (halfSizeDifferenceY - preventingOverscale);
                    polygonPoints[i].Y = polygonPoints[i].Y + vectorCoordinateY * (halfSizeDifferenceY - preventingOverscale);
                }
            }
        }
    }
}
