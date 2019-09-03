using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using App2_ListaBrasil.Modelo;
using System.Net;

namespace App2_ListaBrasil.Servico
{
    public class EstadoServico
    {
        public static string URL = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";

        public List<Estado> GetEstados()
        {
            WebClient wc = new WebClient();
            
            return null;
        }
    }
}
