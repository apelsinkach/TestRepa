﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Locomotive : Vehicle
    {

        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {
                if (value > 0 && value < 150)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 50;
                }
            }
        }

        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }

            protected set
            {
                if (value > 0 && value < 0)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 4;
                }
            }
        }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {

                if (value > 300 && value < 1000)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 1000;
                }
            }
        }

        public Locomotive(int maxSpeed, int maxCountPassengers, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassengers;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(400, 500);
            startPosY = rand.Next(100, 200);
        }


        public override void drawLocomotive(Graphics g)
        {
            drawBaseLocomotive(g);
        }

        public override void moveLocomotive(Graphics g)
        {
            startPosX -= (MaxSpeed *50/(float)Weight)/(countPassengers==0?1:countPassengers);
            drawLocomotive(g);
        }

        protected virtual void drawBaseLocomotive(Graphics g)
        {
            Pen penB = new Pen(Color.Black);
            Pen penR = new Pen(Color.Red);
            Brush brushR = new SolidBrush(Color.Red);
            Brush brushB = new SolidBrush(Color.Black);
            Brush brushRB = new SolidBrush(Color.DeepPink);

            g.DrawEllipse(penR, startPosX+10, startPosY + 30, 20, 20);
            g.DrawEllipse(penR, startPosX + 25, startPosY+ 30, 20, 20);
            g.DrawEllipse(penR, startPosX + 60, startPosY + 30, 20, 20);
            g.DrawEllipse(penR, startPosX + 75, startPosY + 30, 20, 20);

           

            g.FillEllipse(brushRB, startPosX + 10, startPosY + 30, 20, 20);
            g.FillEllipse(brushRB, startPosX + 25, startPosY + 30, 20, 20);
            g.FillEllipse(brushRB, startPosX + 60, startPosY + 30, 20, 20);
            g.FillEllipse(brushRB, startPosX + 75, startPosY + 30, 20, 20);


            g.DrawRectangle(penB, startPosX, startPosY, 100, 30);

            Brush LokoBrush = new SolidBrush(ColorBody);
            g.FillRectangle(LokoBrush, startPosX, startPosY, 100, 30);
            g.DrawRectangle(penB, startPosX-5, startPosY + 20, 10, 10);

            g.FillRectangle(brushR, startPosX - 5, startPosY + 20, 10, 10);

            g.DrawRectangle(penB, startPosX + 100, startPosY +20, 5, 5);
            g.DrawRectangle(penB, startPosX + 80, startPosY + 5, 15, 15);
            g.DrawLine(penB, startPosX+15, startPosY + 38, startPosX + 40, startPosY + 40);
            g.DrawLine(penB, startPosX + 65, startPosY + 38, startPosX + 90, startPosY + 40);
        }

    }
}
