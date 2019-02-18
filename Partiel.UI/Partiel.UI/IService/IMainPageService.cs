using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Partiel.UI.IService
{
    public interface IMainPageService
    {
        Task<string> GetCoordonnees(string adresse);
    }
}
