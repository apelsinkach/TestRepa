﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Depo
    {
        List<ClassArray<ITransport>> parkingStages;


        int countPlaces = 5;

        int placeSizeWidth = 300;

        int placeSizeHeight = 100;

        int currentLevel;

        public int getCurrentLevel
        {
            get
            {
                return currentLevel;
            }
        }

        public Depo(int countStages)
        {
            parkingStages = new List<ClassArray<ITransport>>();
            
            for(int i = 2; i < countStages+2; i++)
            {
                ClassArray<ITransport> classarr = new ClassArray<ITransport>(i, null);
                parkingStages.Add(classarr);
            } 
            

        }

        public void LevelUp()
        {
            if (currentLevel + 1 < parkingStages.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }


        public int PutLocoInDepo(ITransport locomotive)
        {
            return parkingStages[currentLevel]+locomotive;
        }

        public ITransport GetLocoInDepo(int report)
        {
            return parkingStages[currentLevel]-report;
        }


        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var locomotive = parkingStages[currentLevel][i];
                if (locomotive != null)
                {
                    locomotive.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight + 45);
                    locomotive.drawLocomotive(g);
                }

            }
        }

        public void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue),(countPlaces/3)*placeSizeWidth-70,420);
            g.DrawRectangle(pen, 0, 0, countPlaces / 5 * placeSizeWidth, 480);
            for(int i = 0; i < countPlaces / 5; i++)
            {
                for(int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen,i*placeSizeWidth,j*placeSizeHeight,i*placeSizeWidth+110,j*placeSizeHeight);

                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }


        }
    }
}
