using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTDFFB_20220318_CompStore
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Enums.CategoryEnum Category { get; set; }

        public Image Image { get; set; }

        public double Price { get; set; }
    }
}
