﻿using System;
using System.Drawing;
using System.Linq;

namespace ClearBackground
{
    public class PolygonDisplay
    {
        PointF[] polygonAfterScale;
        //Point[] polygonForVector;

        public PointF[] pointFs { get { return polygonAfterScale; } }

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

            float[] coordinateYAfterScale = new float[polygon.Length];
            float[] coordinateXAfterScale = new float[polygon.Length];
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
                coordinateYAfterScale[i] = polygonAfterScale[i].Y;
            }

            for (int i = 0; i < polygonAfterScale.Length; i++)
            {
                coordinateXAfterScale[i] = polygonAfterScale[i].X;
            }

            //max x=400 max y=220

            float maxY = coordinateYAfterScale.Max();
            float minY = coordinateYAfterScale.Min();
            float differenceY = maxY - minY;
            float displaceDistanceY = (220 - differenceY) / 2;

            float maxX = coordinateXAfterScale.Max();
            float minX = coordinateXAfterScale.Min();
            float differenceX = maxX - minX;
            float displaceDistanceX = (400 - differenceX) / 2;

            for (int i = 0; i < polygonAfterScale.Length; i++)
            {
                if(displaceDistanceX + minX > 200)
                {
                    polygonAfterScale[i].X = polygonAfterScale[i].X - minX + displaceDistanceX;
                }
                else
                {
                    polygonAfterScale[i].X =  polygonAfterScale[i].X - (minX - displaceDistanceX);
                }

                polygonAfterScale[i].Y = 220 + displaceDistanceY - polygonAfterScale[i].Y;

                //тут нужно добавить масштабирование для маленьких полигонов
            }    
        }
    }
}
