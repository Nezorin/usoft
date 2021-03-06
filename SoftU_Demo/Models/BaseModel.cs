using System;

namespace WebApp.Models
{
    /// <summary>
    /// Интерфейс базовой модели
    /// </summary>
    interface IBaseModel
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime Created { get; set; }
        DateTime Updated { get; set; }
    }

    /// <summary>
    /// Базовая модель для всех остальных
    /// </summary>
    public class BaseModel : IBaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public BaseModel()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}