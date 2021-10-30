using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    public interface IFunctional
    {
        Task CreateDefaultSuperAdmin();
        Task GenerateRoles();
        Task InitAppData();
    }
}