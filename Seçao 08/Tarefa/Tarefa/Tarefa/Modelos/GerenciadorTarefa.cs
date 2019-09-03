using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tarefa.Modelos
{
    public class GerenciadorTarefa
    {
        private List<Tarefas> Lista { get; set; }
        public void Salvar(Tarefas tarefa)
        {
            Lista = Listagem();
            Lista.Add(tarefa);

            SalvarNoProperties(Lista);
        }

        public void Remover(int index)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);

            SalvarNoProperties(Lista);
        }

        public void Finalizar(int index, Tarefas tarefas)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);

            tarefas.DataFinalizacao = DateTime.Now;
            Lista.Add(tarefas);
            SalvarNoProperties(Lista);
        }

        public List<Tarefas> Listagem()
        {
            return ListagemNoProperties();
        }

        private void SalvarNoProperties(List<Tarefas> Lista)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }

            string JsonVal = JsonConvert.SerializeObject(Lista);
            
            App.Current.Properties.Add("Tarefas", JsonVal);
        }
        private List<Tarefas> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                String JsonVal = (String)App.Current.Properties["Tarefas"];

                List<Tarefas> Lista =  JsonConvert.DeserializeObject<List<Tarefas>>(JsonVal);
                return Lista;
                //return (List<Tarefas>)App.Current.Properties["Tarefas"];
            }
            return new List<Tarefas>();
        }
    }
}
