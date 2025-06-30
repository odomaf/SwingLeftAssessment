# SwingLeftAssessment
## Development Context
I am a mix of a self-taught and academic-taught programmer. As a result, I sometimes find holes in my knowledge requiring me to learn as I go. My professional experience is "old school" with a poor separation of concerns and no use of javascript frameworks like React, Angular, or Vue. I have written this application using the approach I am most familiar with -- .net Core with razor pages. That said, I can learn anything, and I taught myself these concepts that I have never used before as part of completing this assessment:
- Entity Framework Core
- Creating an npm package
- jquery datatables (datatables.net)
- Postgres

## Installation
_Note: node.js, npm, and postgres must be installed for the application to work. Ideally, error messages with links to download/install instructions would be included, but I did not implement those for this assessment. Connection string uses the connecting information in the create-db.js file provided - same database name, datatable name, password_

Pull down the repo. Start in the SwingLeftAssessment directory - double check to make sure you are in this directory, you may need switch to it after pulling down the repo, because your CLI may not default you to that directory. Then run the following:
1. npm install --no-save
2. npm run db:create-db
3. npm run dev

## For Evaluation
- Pages/Index.cshtml and Index.cshtml.cs: retrieving and displaying data
- Model/voter_registration_deadlines.cs
- wwroot/css/site.css: styling for the application
- wwtoor/css/site.js: js scripts for the application
- package.json: npm setup
- appsetting.js: connection string is in here, which isn't the best approach for security, but making it more secure hit a hole in my knowledge that I was unable to address during this process
- Program.cs: everything that needs to run on application startup
- SRDContext.cs: establishes the context for using the database

## Known Concerns
- API Endpoint and associated test - These are not implemented. This is a hole in my knowledge that I did not have time to address due to time limit and brain fatigue. You can bet I'll be learning this regardless of whether I am able to join the team.
- Edge case conditions - I am not confident I've handled all of these, in a team environment, I would be asking for input from others
- Inconsistent naming conventions - I prefer to name models to match the name of the table the information is coming from. This resulted in an underscored name that doesn't match any other conventions used, and frankly, it's too long. I would reconsider this approach if doing this assignment again.

