using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndEduc.Application.Interfaces
{
    public interface IUseCase<Tinput, Toutput>
    {
        Task<Toutput> ExecuteAsync(Tinput input);
    }

    public interface IUseCase<Toutput>
    {
        Task<Toutput> ExecuteAsync();
    }
}