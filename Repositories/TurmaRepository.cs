using Newtonsoft.Json;
using ProjetoAula06.Entities;
using ProjetoAula06.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06.Repositories
{
    /// <summary>
    /// Repositório de dados para turma
    /// </summary>
    public class TurmaRepository : ITurmaRepository
    {
        private const string _path = "c:\\tem\\turma.json";
        public void Exportar(Turma obj)
        {
            using (var streamWriter = new StreamWriter(_path)) {
                streamWriter.Write(JsonConvert.SerializeObject(obj, Formatting.Indented));
            }
        }

        public Turma Importar()
        {
            throw new NotImplementedException();
        }
    }
}
