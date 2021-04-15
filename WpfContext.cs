using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp2
{
    class WpfContext : DbContext
    {
        public DbSet<ItemPenjualan> DaftarItemPenjualan { get; set; }
    }
}
