using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Npgsql;
using SwingLeftAssessment.Models;


namespace SwingLeftAssessment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private SRDContext Context { get; }
        public List<voter_registration_deadlines> deadlines { get; set; } = new List<voter_registration_deadlines>();

        public IndexModel(SRDContext _context, ILogger<IndexModel> logger)
        {
            this.Context = _context;
            _logger = logger;
        }
        //get deadline information from database
        public void OnGet()
        {
            deadlines = this.Context.voter_registration_deadlines.ToList();
        }
    }
}
