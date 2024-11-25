using WenAPI_video.Models;

namespace WenAPI_video.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarioList();
        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario);
        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);



    }
}
