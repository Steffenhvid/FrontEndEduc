using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndEduc.Application.Interfaces
{
    public interface IMapper<Tentity, Tdto>
    {
        Tentity FromDTO(Tdto dto);

        Tdto FromEntity(Tentity entity);
    }
}