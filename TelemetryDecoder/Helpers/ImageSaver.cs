using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using TelemetryDecoder.Decode;

namespace TelemetryDecoder.Helpers
{  
    /// <summary>
    /// Класс для сохранения полученных при декодировании изображений.
    /// </summary>
    static class ImageSaver
    {
        /// <summary>
        /// Сохранение изображений.
        /// </summary>
        /// <param name="listImagesForSave">Список хранящий изображения по каждому каналу.</param> 
        /// <param name="fileName">Имя декодируемого файла или имя сеанса приема.</param> 
        /// <param name="imageCounter">Номер сохраняемого изображения.</param>  
        public static void SaveImage(List<Bitmap>[] listImagesForSave, string fileName, long imageCounter)
        {
            if (listImagesForSave.Length == 0)
            {
                return;
            }
            Parallel.For(0, listImagesForSave.Length, i =>
            {
                List<Bitmap> listImages = new List<Bitmap>(listImagesForSave[i]);
                listImagesForSave[i].Clear();

                if (listImages.Count == 0)
                {
                    return;
                }

                using (var bmp = new Bitmap(Constants.WDT, listImages.Count * Constants.HGT))
                {
                    using (var g = Graphics.FromImage(bmp))
                    {
                        int yOffset = 0;

                        for (int j = 0; j < listImages.Count; j++)
                        {
                            g.DrawImage(listImages[j], new Rectangle(0, yOffset, Constants.WDT, Constants.HGT));
                            yOffset += Constants.HGT;
                        }
                    }

                    bmp.Save($"{Path.GetDirectoryName(fileName)}\\{Path.GetFileNameWithoutExtension(fileName)}_Channel_{i + 1}\\{Path.GetFileNameWithoutExtension(fileName)}_сhannel_{i + 1}_{imageCounter}.bmp");
                }
            });          
        }
    }
}
