using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapilacaklarListesi
{
   public class ToDoItem
    {
        public Guid Id { get; set; }
        public string GorevMetni { get; set; }
        public DateTime TamamlanmaTarihi { get; set; }
        public bool Tamamlandi { get; set; }

        public override string ToString()
        {
            return GorevMetni;
        }
    }
}
