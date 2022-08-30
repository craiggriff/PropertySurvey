using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;

namespace PropertySurveyService.Data
{
    public class PropertySurveyServiceContext : DbContext
    {
        public PropertySurveyServiceContext (DbContextOptions<PropertySurveyServiceContext> options)
            : base(options)
        {
        }

        public DbSet<PropertySurveyService.Models.Job> Job { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Customer> Customer { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Surveyor> Surveyor { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Header> Header { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.AlumTable> AlumTable { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.BifoldTable> BifoldTable { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.CompositeTable> CompositeTable { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.ConsTable> ConsTable { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.GarageTable> GarageTable { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.GlassTable> GlassTable { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.GreenTable> GreenTable { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.LockingTable> LockingTable { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.PanelTable> PanelTable { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.TimberTable> TimberTable { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.UPVCTable> UPVCTable { get; set; } = default!;

        public DbSet<PropertySurveyService.Models.PhotoImage> Images { get; set; } = default!;
    }
}
