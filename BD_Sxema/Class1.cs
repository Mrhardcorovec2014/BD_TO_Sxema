using System;
using System.Collections.Generic;
using System.Text;

namespace BD_Sxema
{
    public class Вид_Работы
    {
        private int Смазочные;
        private int Регулировочные;
        private int Контрольно_Диагностические;
        private int Крепежные;
        private int Заправочные;
        private int Электротехнические;

        public Цена_За_Работу Цена_За_Работу
        {
            get => default;
            set
            {
            }
        }
    }

    public class Машина
    {
        private int Модель;
        private int Вид;
        private int Год_Службы;
        private int Номерной_Знак;

        public Вид_ТО Вид_ТО
        {
            get => default;
            set
            {
            }
        }
    }
}