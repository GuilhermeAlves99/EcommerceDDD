using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notifications
{
    public class Notifies
    {
        //construtor da classe
        public Notifies()
        {
            NotifiesMessage = new List<Notifies>();
        }
        //NotMapped para não linkar a coluna com o banco para não dar erro
        [NotMapped]
        public string NameProparties { get; set;}

        [NotMapped]
        public string Messsage { get; set; }

        [NotMapped]
        public List<Notifies> NotifiesMessage;

        /// <summary>
        /// caso o usuário não tenha preenchido algum campo, teremos um retorno de erro
        /// </summary>
        /// <param name="value"></param>
        /// <param name="namePropertie"></param>
        /// <returns></returns>
        public bool ValidatePropartiesString( string value, string namePropertie) 
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(namePropertie)) 
            {
                NotifiesMessage.Add(new Notifies { Messsage = "campo Obrigatório",
                NameProparties = namePropertie});
                
                return false;
            }
            return true;
        }
        public bool ValidatePropertiesInt(int value, string namePropertie) 
        {
            if (value < 1 || string.IsNullOrWhiteSpace(namePropertie))
            {
                NotifiesMessage.Add(new Notifies
                {
                    Messsage = "Valor deve ser maior que 0",
                    NameProparties = namePropertie
                }) ;

                return false;
            }

            return true;
        }
        public bool ValidatePropertiesDecimal(decimal value, string namePropertie) 
        {
            if (value < 1 || string.IsNullOrWhiteSpace(namePropertie))
            {
                NotifiesMessage.Add(new Notifies
                {
                    Messsage = "Valor deve ser maior que 0",
                    NameProparties = namePropertie
                });

                return false;
            }

            return true;
        }
    }
}
