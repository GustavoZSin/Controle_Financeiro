using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests.Transaction
{
    public class GetTransactionByIdRequest : Request
    {
        [Required(ErrorMessage = "Id inválido")]
        public long Id { get; set; }
    }
}
