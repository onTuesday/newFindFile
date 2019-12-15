using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindFile;
using System.Collections;




namespace FindFile
{
    public class Client
    {
        /// <summary>
        /// Входной класс для поиска файлов.
        /// Для поиска воспользуйтесь методом Find
        /// </summary>

        /// <summary>
        /// Вызывается для поиска файлов.
        /// Результат записывается в список result
        /// </summary>
        /// <param name="path">Начальная директория</param>
        /// <param name="mask">Критерий поиска</param>
        /// <returns>0 в случае успеха</returns>
        public int Find(string path, string mask)
        {
            MaskHandler maskHandler = new MaskHandler(mask);
            DirectoryHandler dirHandler = new DirectoryHandler(maskHandler);
            dirHandler.TraverseAllFiles(path);
            return 0;   
        }
    }
}
