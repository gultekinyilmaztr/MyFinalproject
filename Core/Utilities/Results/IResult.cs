using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidleri için başlangıç
    //Void geri dönüşümsüz komut

    public interface IResult
    {
        bool Success { get; }

        string Message { get; }
    }
}
