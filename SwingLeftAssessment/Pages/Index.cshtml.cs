using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Npgsql;
using SwingLeftAssessment.Entities;

namespace SwingLeftAssessment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Database _database;
        public List<VoterRegistrationDeadlines> deadlines;


        public IndexModel(ILogger<IndexModel> logger, Database database)
        {
            _logger = logger;
            _database = database;
        }

        public async void OnGet()
        {
            using var context = new EFCoreDbContext();
            deadlines = await context.VoterRegistrationDeadlines.ToListAsync();
        }
    }
}
