using bArt.InterviewTask.DataContext;
using Microsoft.EntityFrameworkCore;

namespace bArt.InterviewTask
{
    public static class SampleData
    {

        public static void Initialize(IServiceProvider provider)
        {
            using (var context = new IncidentContext(provider.GetRequiredService<DbContextOptions<IncidentContext>>()))
            {
               

                context.SaveChanges();
            }
        }
    }
}
