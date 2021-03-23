using System;

namespace WebApp.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public DateTime TimeAdded { get; set; }
        public string FileName { get; set; } //Имя самого файла
        public string Name { get; set; } //Имя файла для фронта/сайта
        public string Path { get; set; }
        public string Group { get; set; }
        public string Course { get; set; }
    }
}
