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
        private readonly EFCoreDbContext dbcontext;
        public List<VoterRegistrationDeadlines> deadlines { get; set; } = new List<VoterRegistrationDeadlines>();

        public IndexModel(ILogger<IndexModel> logger, Database database)
        {
            _logger = logger;
        }

        public async void OnGet()
        {           
            deadlines = await  dbcontext.VoterRegistrationDeadlines.ToListAsync();
        }
    }
}
