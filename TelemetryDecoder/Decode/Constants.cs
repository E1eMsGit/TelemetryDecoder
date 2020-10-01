using System;

namespace TelemetryDecoder.Decode
{
    static class Constants
    {
        public static int DELEGATE_CALL_COUNTER = 800; // Кол-во вызовов делегата для сброса изображений и логов. Нужно чтобы набрать 6400 строчек.

        public static int WDT = 1568; // Ширина рисунка.
        public static int HGT = 8; // Высота рисунка.

        public static DateTime referenceDate = new DateTime(2001, 1, 1, 0, 0, 0);

        public static int DL_JPEG = 1500; // Длина буфера jpeg с запасом - полос + на шапку.
        public static int DL_VIDEO = 896; // Длина видеобуфера.

        public static int DL_IN_BUF = 32768; // Длина входного буфера, должно делиться на 2048.

        public static int DL_INTRL_BUF = 2654208; // Длина буфера интерл. в битах 2048*36*36.

        public static int DL_IN_VIT_BUF = 16384; // Длина входного буф.для Витерби 2048 байт.
        public static int DL_VIT_BUF = 1024; // Длина буфера после Витарби, должно делиться на 1024.

        public static byte[] zag_tk_bit = { 
            0, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1,
            1, 1, 0, 1 };  // транспортный заголовок в битах

        //Константы по транспортному кадру
        public static int NOM_VER = 1; //2 бита - номер версии структуры пакета по CCSDS
        public static int IDENT_KA = 0; //8 бит - идент. КА     
        public static int KADR_INFO = 5; //6 бит - идент. информац. кадра
        public static int KADR_LOOSE = 63; //6 бит - идент. холостого кадра

        //Константы по парц. пакетам
        public static int APID_1 = 64;	//АПИД 1-го канала
        public static int APID_6 = 69;	//АПИД 6-го канала
        public static int APID_c = 70;	//АПИД служебного пакета
        public static int DELTA_T = 1;   //временная разница между полосами
        public static int MAX_MSU = 182;	//макс. номер МСУ
        public static int MAX_Q = 100; //макс. коэф. качества

        public static int slugLength = 112; //Байт на служебную информацию.

        public static byte[] psp = { 2, 24, 167, 163, 146, 221, 154, 191 }; //ПСП - начало кадра БРЛК

        public static int KOL_OUT_BUF = WDT * 16 + slugLength;   // Длина выходного буфера.   
   
        public static int PMEM = 128;
    }
}
