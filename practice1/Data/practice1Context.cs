using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practice1.Model;

namespace practice1.Data
{
    public class practice1Context : DbContext
    {
        internal object patientData;

        public practice1Context (DbContextOptions<practice1Context> options)
            : base(options)
        {
        }

        public DbSet<practice1.Model.Patient> Patient { get; set; } = default!;
        public DbSet<practice1.Model.ModelInfo> ModelInfo { get; set; } = default!;
        public DbSet<practice1.Model.ProductData> ProductData { get; set; } = default!;
        public DbSet<practice1.Model.productInformation> productInformation { get; set; } = default!;


    }
}
