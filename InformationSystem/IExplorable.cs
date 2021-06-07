using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace InformationSystem
{

    [JsonObject(IsReference = true)]
    public interface IExplorable
    {
        /// <summary>
        /// Имя объекта
        /// </summary>
        string FullName { get; set; }

        /// <summary>
        /// Информация об объекте
        /// </summary>
        string Present();
    }
}