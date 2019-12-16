using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FindFile
{
    public class DirectoryHandler
    {
        /// <summary>
        /// Класс, обслуживающий рекурсивный обход заданной директории.
        /// Для каждого найденного файла вызывает функцию обработчика маски
        /// </summary>

        private MaskHandler maskHandler; 

        public DirectoryHandler( MaskHandler maskHandler )
        {
            this.maskHandler = maskHandler;
        }

        /// <summary>
        /// Рекурсивный обход файлов.
        /// Для каждого найденного файла вызывается Compare для сопоставления файла маске
        /// </summary>
        /// <param name="path">Начальная директория</param>
        /// <returns>Количество найденных файлов</returns>
        public int TraverseAllFiles(string path)
        {
            int count = 0;
            try
            {
                string[] filesInCurrentDir = Directory.GetFiles(path);
                //Обрабатываем файлы
                foreach (var file in filesInCurrentDir)
                {
                    ++count;
                    //Передаём файлы в обработчик
                    File fileToHandle = new File(file);
                    fileToHandle.SetContentAndLenFromFile();
                    this.maskHandler.CompareWithExpression(fileToHandle);
                }
                //Рекурсивно вызываем данную функцию для каталогов
                string[] directoriesInCurrentDir = Directory.GetDirectories(path);
                foreach (var dir in directoriesInCurrentDir)
                {
                    count += TraverseAllFiles(dir);
                }
            }
            catch(UnauthorizedAccessException)
            {}
            catch(DirectoryNotFoundException)
            {
                Error.SetError(@"Directory not Found.\nCheck Your's path.");
                return count;
            }
            catch(PathTooLongException)
            {
                Error.SetError(@"Path too long!");
                return count;
            }
            catch (Exception)
            {
                Error.SetError(@"Unknown error.");
                return count;
            }
            return count;
        }

    }
}
