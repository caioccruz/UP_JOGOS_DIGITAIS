using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuPrimeiroBackend.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int DanoMaximo { get; set; }

        public int Raridade { get; set; }


        //relacionando item -->TipoItem
        public int TipoItemID { get; set; }

        public virtual TipoItem _TipoItem { get; set; }
    }
}