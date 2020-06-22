using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Generico.DTO.Response
{
    /// <summary>
    /// Clase que devuelve registros para los combos
    /// </summary>
    public class ItemBaseResponse
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Valor del item
        /// </summary>
        public string Name { get; set; }
    }
}
