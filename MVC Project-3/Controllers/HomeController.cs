using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Project_3.Models;

namespace MVC_Project_3.Controllers
{
    public class ExploreService : IExploreService
    {
        List<Explore> IExploreService.GetAllExplores()
        {
            throw new NotImplementedException();
        }
    }
}
