using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InformationSystem
{
    public class Institution : IExplorable
    {
        [JsonConstructor]
        public Institution(Chief superior, string name)
        {
            Superior = superior;
            FullName = name;
            Children = new ObservableCollection<IExplorable>();
            superior.WorkPlace = this;
        }


        /// <summary>
        /// Начальник ведомства
        /// </summary>
        public Chief Superior { get; set; }

        /// <summary>
        /// Ведомства, входящие в данное
        /// </summary>
        public ObservableCollection<IExplorable> Children { get; set; }

        /// <summary>
        /// Вышестоящее ведомство
        /// </summary>
        public Institution Parent { get; set; }

        public string FullName { get; set; }

        public string Present()
        {
            return $"Institution Name: {FullName}\n\n" +
                $"Superior: {Superior.Present()}"; 
        }
    }
}